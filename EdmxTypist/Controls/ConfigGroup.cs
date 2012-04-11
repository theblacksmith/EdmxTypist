/**
 * This file is part of Edmx Typist  - A cyber typist to help you fix your edmx file.
 * Copyright (C) 2012 Saulo Vallory <me@saulovallory.com>
 * 
 * Edmx Typist is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *  
 * Edmx Typist is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with Edmx Typist. If not, see <http://www.gnu.org/licenses/>.
 */
namespace EdmxTypist.Controls
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq.Expressions;
	using System.Windows.Forms;
	using BindingTools;
	using Options;

	/// <remarks>
	/// Custom control to make easy modifying configuration groups
	/// </remarks>
	[DesignerCategory("Edmx Typist")]
	public partial class EdmxConfigGroup : UserControl
	{
		private ContextOptions _options;

		private List<string> _examples;
		//private BindingSource _bsExamples;

		public List<string> Examples
		{
			get { return _examples; }
			set { 
				
				_examples = value;
				ddExamples.DataSource = value;
				ddExamples.ResetBindings();
			}
		}

		[Browsable(false)]
		public ContextOptions Options
		{
			get { return _options; }
			set
			{
				_options = value;

				foreach (var bs in bindingSources)
				{
					bs.ResetBindings(false);
				}
			}
		}

		private List<BindingSource> bindingSources;

		private bool _showBeSmart;

		[Description("Use dynamic flexing in contexts where the name can represent one or many objects.")]
		[Category("Behavior")]
		public bool ShowBeSmartOption
		{
			get { return _showBeSmart; }
			set
			{
				_showBeSmart = value;
				rdBeSmart.Visible = value;

				if (rdBeSmart.Checked && !rdBeSmart.Visible)
					rdLeaveItAlone.Checked = true;
			}
		}

		/// <summary>
		/// The sole constructor
		/// </summary>
		public EdmxConfigGroup()
		{
			InitializeComponent();

			bindingSources = new List<BindingSource>();

			Options = new ContextOptions();
			bsContextOptions.Add(Options);

			Dock = DockStyle.Fill;

			cbRegex.DataSource = EnumBinder.Bind<ApplyRegexEnum>();
			cbRegex.ValueMember = "Value";
			cbRegex.DisplayMember = "Label";

			rdBeSmart.DataBindings.Add("Checked", GetBSForRadio(p => p.Flexing, FlexingStrategyEnum.BeSmart), "Value");
			rdLeaveItAlone.DataBindings.Add("Checked", GetBSForRadio(p => p.Flexing, FlexingStrategyEnum.LeaveItAlone), "Value");
			rdPluralize.DataBindings.Add("Checked", GetBSForRadio(p => p.Flexing, FlexingStrategyEnum.Pluralize), "Value");
			rdSingularize.DataBindings.Add("Checked", GetBSForRadio(p => p.Flexing, FlexingStrategyEnum.Singularize), "Value");

			rdCamelCase.DataBindings.Add("Checked", GetBSForRadio(p => p.CaseStyle, CaseStyleEnum.CamelCase), "Value");
			rdLowerCamelCase.DataBindings.Add("Checked", GetBSForRadio(p => p.CaseStyle, CaseStyleEnum.LowerCamelCase), "Value");
			rdLowerUnderscore.DataBindings.Add("Checked", GetBSForRadio(p => p.CaseStyle, CaseStyleEnum.Undescores), "Value");

			// Examples
			//_bsExamples = new BindingSource();
			_examples = new List<string>();
			ddExamples.DataSource = _examples;
		}

		private BindingSource GetBSForRadio<TEnum>(Expression<Func<ContextOptions, TEnum>> prop, TEnum value)
		{
			var bs = new BindingSource();
			bs.DataSource = new ComparisonBinder<ContextOptions, TEnum>(Options, prop, value);

			bindingSources.Add(bs);

			return bs;
		}

		private void UpdateResult(object sender, EventArgs e)
		{

		}
	}
}
