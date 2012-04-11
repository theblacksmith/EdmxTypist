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
namespace EdmxTypist.Options
{
	using System.Collections.Generic;
	using System.Linq;
	using System.ComponentModel;

	/// <remarks>
	/// Group the options for a <see cref="NameContextEnum">naming context</see>.
	/// </remarks>
	public class ContextOptions : INotifyPropertyChanged
	{
#region "Private fields"

		private FlexingStrategyEnum? _flexing;
		private CaseStyleEnum? _caseStyle;
#endregion

		/// <summary>
		/// Whether to pluralize, singularize, leave it alone or <see cref="FlexingStrategyEnum.BeSmart"/>.
		/// </summary>
		public FlexingStrategyEnum? Flexing
		{
			get { return _flexing; }
			set
			{
				if (value != _flexing)
				{
					_flexing = value;
					NotifyPropertyChanged("Flexing");
				}
			}
		}

		/// <summary>
		/// Which writing style to choose. Can be CamelCase, lowerCamelCase or lower_underscores.
		/// </summary>
		public CaseStyleEnum? CaseStyle
		{
			get { return _caseStyle; }
			set
			{
				if (value != _caseStyle)
				{
					_caseStyle = value;
					NotifyPropertyChanged("CaseStyle");
				}
			}
		}

		/// <summary>
		/// Prefixes to remove before applying rules
		/// </summary>
		public string RemovePrefixes { get; set; }

		/// <summary>
		/// Suffixes to remove before applying rules
		/// </summary>
		public string RemoveSuffixes { get; set; }

		/// <summary>
		/// A prefix to be added to the transformed name
		/// </summary>
		public string AddPrefix { get; set; }

		/// <summary>
		/// A suffix to be added to the transformed name
		/// </summary>
		public string AddSuffix { get; set; }

		/// <summary>
		/// When to apply regex expression
		/// </summary>
		public ApplyRegexEnum? ApplyRegex { get; set; }

		/// <summary>
		/// The regex to run
		/// </summary>
		public string RegexMatch { get; set; }

		/// <summary>
		/// the regex match replacement
		/// </summary>
		public string RegexReplace { get; set; }

		public bool RemoveEntityNameFromKey { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public ContextOptions()
		{
			Flexing = FlexingStrategyEnum.BeSmart;
			CaseStyle = CaseStyleEnum.CamelCase;

			RemovePrefixes = "";
			RemoveSuffixes = "";
			AddPrefix = "";
			AddSuffix = "";

			ApplyRegex = ApplyRegexEnum.DontApply;
			RegexMatch = "";
			RegexReplace = "";

			RemoveEntityNameFromKey = true;
		}

		public ContextOptions(ref ContextOptions defaults)
		{
			CopyFrom(ref defaults);
		}

		/// <summary>
		/// Copies ALL the values from <paramref name="source"/> to <c>this</c> instance.
		/// </summary>
		/// <param name="source">ContextOptions instance to copy from</param>
		public void CopyFrom(ref ContextOptions source)
		{
			Flexing = source.Flexing ?? Flexing;
			CaseStyle = source.CaseStyle ?? CaseStyle;

			RemovePrefixes = source.RemovePrefixes ?? RemovePrefixes;
			RemoveSuffixes = source.RemoveSuffixes ?? RemoveSuffixes;
			AddPrefix = source.AddPrefix ?? AddPrefix;
			AddSuffix = source.AddSuffix ?? AddSuffix;

			ApplyRegex = source.ApplyRegex ?? ApplyRegex;
			RegexMatch = source.RegexMatch ?? RegexMatch;
			RegexReplace = source.RegexReplace ?? RegexReplace;
		}

		/// <summary>
		/// Encapsulates parsing of a word list so we can do fancy stuff later
		/// </summary>
		private List<string> parseList(string list)
		{
			return list.Split(' ').ToList();
		}

		/// <summary>
		/// Returns <see cref="RemovePrefixes"/> as a <c>List&lt;string&gt;</c>.
		/// </summary>
		public List<string> ListRemovePrefixes()
		{
			return parseList(RemovePrefixes);
		}

		/// <summary>
		/// Returns <see cref="RemoveSuffixes"/> as a <c>List&lt;string&gt;</c>.
		/// </summary>
		public List<string> ListRemoveSuffixes()
		{
			return parseList(RemoveSuffixes);
		}

		private void NotifyPropertyChanged(string p)
		{
			PropertyChangedEventHandler handler = PropertyChanged;

			if (handler != null)
				handler(this, new PropertyChangedEventArgs(p));
		}
	}
}
