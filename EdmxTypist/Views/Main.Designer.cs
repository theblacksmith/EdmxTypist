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
namespace EdmxTypist.Views
{
	using Controls;

	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label lbBaseName;
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			EdmxTypist.Options.ContextOptions contextOptions1 = new EdmxTypist.Options.ContextOptions();
			EdmxTypist.Options.ContextOptions contextOptions2 = new EdmxTypist.Options.ContextOptions();
			EdmxTypist.Options.ContextOptions contextOptions3 = new EdmxTypist.Options.ContextOptions();
			EdmxTypist.Options.ContextOptions contextOptions4 = new EdmxTypist.Options.ContextOptions();
			EdmxTypist.Options.ContextOptions contextOptions5 = new EdmxTypist.Options.ContextOptions();
			EdmxTypist.Options.ContextOptions contextOptions6 = new EdmxTypist.Options.ContextOptions();
			EdmxTypist.Options.ContextOptions contextOptions7 = new EdmxTypist.Options.ContextOptions();
			EdmxTypist.Options.ContextOptions contextOptions8 = new EdmxTypist.Options.ContextOptions();
			EdmxTypist.Options.ContextOptions contextOptions9 = new EdmxTypist.Options.ContextOptions();
			this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tabPanel = new System.Windows.Forms.TabControl();
			this.TabDefault = new System.Windows.Forms.TabPage();
			this.cgDefault = new EdmxTypist.Controls.EdmxConfigGroup();
			this.tabEntitySets = new System.Windows.Forms.TabPage();
			this.cgEntitySets = new EdmxTypist.Controls.EdmxConfigGroup();
			this.tabEntityTypes = new System.Windows.Forms.TabPage();
			this.cgEntityTypes = new EdmxTypist.Controls.EdmxConfigGroup();
			this.tabComplexTypes = new System.Windows.Forms.TabPage();
			this.cgComplexTypes = new EdmxTypist.Controls.EdmxConfigGroup();
			this.tabScalar = new System.Windows.Forms.TabPage();
			this.cgScalars = new EdmxTypist.Controls.EdmxConfigGroup();
			this.tabNavProps = new System.Windows.Forms.TabPage();
			this.cgNavProps = new EdmxTypist.Controls.EdmxConfigGroup();
			this.tabComplexProps = new System.Windows.Forms.TabPage();
			this.cgComplexProp = new EdmxTypist.Controls.EdmxConfigGroup();
			this.tabAssociations = new System.Windows.Forms.TabPage();
			this.cgAssociations = new EdmxTypist.Controls.EdmxConfigGroup();
			this.tabMethods = new System.Windows.Forms.TabPage();
			this.cgMethods = new EdmxTypist.Controls.EdmxConfigGroup();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.rdUseCurrentName = new System.Windows.Forms.RadioButton();
			this.rdUseDbName = new System.Windows.Forms.RadioButton();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbEdmxFile = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btRun = new System.Windows.Forms.Button();
			this.Menu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wannaHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			lbBaseName = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.LayoutPanel.SuspendLayout();
			this.tabPanel.SuspendLayout();
			this.TabDefault.SuspendLayout();
			this.tabEntitySets.SuspendLayout();
			this.tabEntityTypes.SuspendLayout();
			this.tabComplexTypes.SuspendLayout();
			this.tabScalar.SuspendLayout();
			this.tabNavProps.SuspendLayout();
			this.tabComplexProps.SuspendLayout();
			this.tabAssociations.SuspendLayout();
			this.tabMethods.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbBaseName
			// 
			lbBaseName.AutoSize = true;
			lbBaseName.Location = new System.Drawing.Point(5, 5);
			lbBaseName.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
			lbBaseName.Name = "lbBaseName";
			lbBaseName.Size = new System.Drawing.Size(65, 13);
			lbBaseName.TabIndex = 6;
			lbBaseName.Text = "Base Name:";
			// 
			// label1
			// 
			label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(5, 10);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(91, 13);
			label1.TabIndex = 7;
			label1.Text = "Custom Renamer:";
			// 
			// OpenFileDlg
			// 
			this.OpenFileDlg.Filter = "Entity Framework files (*.edmx)|*.edmx";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.LayoutPanel);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(832, 378);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(832, 402);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.Menu);
			// 
			// LayoutPanel
			// 
			this.LayoutPanel.ColumnCount = 1;
			this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutPanel.Controls.Add(this.tabPanel, 0, 1);
			this.LayoutPanel.Controls.Add(this.flowLayoutPanel2, 0, 0);
			this.LayoutPanel.Controls.Add(this.panel1, 0, 2);
			this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.LayoutPanel.Name = "LayoutPanel";
			this.LayoutPanel.RowCount = 3;
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutPanel.Size = new System.Drawing.Size(832, 378);
			this.LayoutPanel.TabIndex = 7;
			// 
			// tabPanel
			// 
			this.tabPanel.Controls.Add(this.TabDefault);
			this.tabPanel.Controls.Add(this.tabEntitySets);
			this.tabPanel.Controls.Add(this.tabEntityTypes);
			this.tabPanel.Controls.Add(this.tabComplexTypes);
			this.tabPanel.Controls.Add(this.tabScalar);
			this.tabPanel.Controls.Add(this.tabNavProps);
			this.tabPanel.Controls.Add(this.tabComplexProps);
			this.tabPanel.Controls.Add(this.tabAssociations);
			this.tabPanel.Controls.Add(this.tabMethods);
			this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabPanel.Location = new System.Drawing.Point(10, 40);
			this.tabPanel.Margin = new System.Windows.Forms.Padding(10);
			this.tabPanel.Name = "tabPanel";
			this.tabPanel.SelectedIndex = 0;
			this.tabPanel.Size = new System.Drawing.Size(812, 288);
			this.tabPanel.TabIndex = 4;
			// 
			// TabDefault
			// 
			this.TabDefault.Controls.Add(this.cgDefault);
			this.TabDefault.Location = new System.Drawing.Point(4, 22);
			this.TabDefault.Name = "TabDefault";
			this.TabDefault.Padding = new System.Windows.Forms.Padding(3);
			this.TabDefault.Size = new System.Drawing.Size(804, 262);
			this.TabDefault.TabIndex = 0;
			this.TabDefault.Text = "Defaults";
			this.TabDefault.UseVisualStyleBackColor = true;
			// 
			// cgDefault
			// 
			this.cgDefault.AutoSize = true;
			this.cgDefault.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgDefault.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgDefault.Examples")));
			this.cgDefault.Location = new System.Drawing.Point(3, 3);
			this.cgDefault.Name = "cgDefault";
			contextOptions1.AddPrefix = "";
			contextOptions1.AddSuffix = "";
			contextOptions1.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions1.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions1.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions1.RegexMatch = "";
			contextOptions1.RegexReplace = "";
			contextOptions1.RemovePrefixes = "";
			contextOptions1.RemoveSuffixes = "";
			this.cgDefault.Options = contextOptions1;
			this.cgDefault.ShowBeSmartOption = true;
			this.cgDefault.Size = new System.Drawing.Size(798, 256);
			this.cgDefault.TabIndex = 0;
			// 
			// tabEntitySets
			// 
			this.tabEntitySets.BackColor = System.Drawing.SystemColors.Window;
			this.tabEntitySets.Controls.Add(this.cgEntitySets);
			this.tabEntitySets.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabEntitySets.Location = new System.Drawing.Point(4, 22);
			this.tabEntitySets.Name = "tabEntitySets";
			this.tabEntitySets.Padding = new System.Windows.Forms.Padding(3);
			this.tabEntitySets.Size = new System.Drawing.Size(789, 203);
			this.tabEntitySets.TabIndex = 1;
			this.tabEntitySets.Text = "Entity Sets";
			// 
			// cgEntitySets
			// 
			this.cgEntitySets.AutoSize = true;
			this.cgEntitySets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgEntitySets.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgEntitySets.Examples")));
			this.cgEntitySets.Location = new System.Drawing.Point(3, 3);
			this.cgEntitySets.Name = "cgEntitySets";
			contextOptions2.AddPrefix = "";
			contextOptions2.AddSuffix = "";
			contextOptions2.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions2.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions2.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions2.RegexMatch = "";
			contextOptions2.RegexReplace = "";
			contextOptions2.RemovePrefixes = "";
			contextOptions2.RemoveSuffixes = "";
			this.cgEntitySets.Options = contextOptions2;
			this.cgEntitySets.ShowBeSmartOption = false;
			this.cgEntitySets.Size = new System.Drawing.Size(783, 197);
			this.cgEntitySets.TabIndex = 0;
			// 
			// tabEntityTypes
			// 
			this.tabEntityTypes.BackColor = System.Drawing.SystemColors.Window;
			this.tabEntityTypes.Controls.Add(this.cgEntityTypes);
			this.tabEntityTypes.Location = new System.Drawing.Point(4, 22);
			this.tabEntityTypes.Name = "tabEntityTypes";
			this.tabEntityTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tabEntityTypes.Size = new System.Drawing.Size(789, 203);
			this.tabEntityTypes.TabIndex = 2;
			this.tabEntityTypes.Text = "Entity Types";
			// 
			// cgEntityTypes
			// 
			this.cgEntityTypes.AutoSize = true;
			this.cgEntityTypes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgEntityTypes.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgEntityTypes.Examples")));
			this.cgEntityTypes.Location = new System.Drawing.Point(3, 3);
			this.cgEntityTypes.Name = "cgEntityTypes";
			contextOptions3.AddPrefix = "";
			contextOptions3.AddSuffix = "";
			contextOptions3.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions3.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions3.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions3.RegexMatch = "";
			contextOptions3.RegexReplace = "";
			contextOptions3.RemovePrefixes = "";
			contextOptions3.RemoveSuffixes = "";
			this.cgEntityTypes.Options = contextOptions3;
			this.cgEntityTypes.ShowBeSmartOption = false;
			this.cgEntityTypes.Size = new System.Drawing.Size(783, 197);
			this.cgEntityTypes.TabIndex = 0;
			// 
			// tabComplexTypes
			// 
			this.tabComplexTypes.BackColor = System.Drawing.SystemColors.Window;
			this.tabComplexTypes.Controls.Add(this.cgComplexTypes);
			this.tabComplexTypes.Location = new System.Drawing.Point(4, 22);
			this.tabComplexTypes.Name = "tabComplexTypes";
			this.tabComplexTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tabComplexTypes.Size = new System.Drawing.Size(789, 203);
			this.tabComplexTypes.TabIndex = 7;
			this.tabComplexTypes.Tag = "";
			this.tabComplexTypes.Text = "Complex Types";
			// 
			// cgComplexTypes
			// 
			this.cgComplexTypes.AutoSize = true;
			this.cgComplexTypes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgComplexTypes.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgComplexTypes.Examples")));
			this.cgComplexTypes.Location = new System.Drawing.Point(3, 3);
			this.cgComplexTypes.Name = "cgComplexTypes";
			contextOptions4.AddPrefix = "";
			contextOptions4.AddSuffix = "";
			contextOptions4.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions4.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions4.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions4.RegexMatch = "";
			contextOptions4.RegexReplace = "";
			contextOptions4.RemovePrefixes = "";
			contextOptions4.RemoveSuffixes = "";
			this.cgComplexTypes.Options = contextOptions4;
			this.cgComplexTypes.ShowBeSmartOption = false;
			this.cgComplexTypes.Size = new System.Drawing.Size(783, 197);
			this.cgComplexTypes.TabIndex = 0;
			// 
			// tabScalar
			// 
			this.tabScalar.BackColor = System.Drawing.SystemColors.Window;
			this.tabScalar.Controls.Add(this.cgScalars);
			this.tabScalar.Location = new System.Drawing.Point(4, 22);
			this.tabScalar.Name = "tabScalar";
			this.tabScalar.Padding = new System.Windows.Forms.Padding(3);
			this.tabScalar.Size = new System.Drawing.Size(789, 203);
			this.tabScalar.TabIndex = 5;
			this.tabScalar.Text = "Sacalar Members";
			// 
			// cgScalars
			// 
			this.cgScalars.AutoSize = true;
			this.cgScalars.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgScalars.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgScalars.Examples")));
			this.cgScalars.Location = new System.Drawing.Point(3, 3);
			this.cgScalars.Name = "cgScalars";
			contextOptions5.AddPrefix = "";
			contextOptions5.AddSuffix = "";
			contextOptions5.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions5.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions5.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions5.RegexMatch = "";
			contextOptions5.RegexReplace = "";
			contextOptions5.RemovePrefixes = "";
			contextOptions5.RemoveSuffixes = "";
			this.cgScalars.Options = contextOptions5;
			this.cgScalars.ShowBeSmartOption = false;
			this.cgScalars.Size = new System.Drawing.Size(783, 197);
			this.cgScalars.TabIndex = 0;
			// 
			// tabNavProps
			// 
			this.tabNavProps.BackColor = System.Drawing.SystemColors.Window;
			this.tabNavProps.Controls.Add(this.cgNavProps);
			this.tabNavProps.Location = new System.Drawing.Point(4, 22);
			this.tabNavProps.Name = "tabNavProps";
			this.tabNavProps.Padding = new System.Windows.Forms.Padding(3);
			this.tabNavProps.Size = new System.Drawing.Size(789, 203);
			this.tabNavProps.TabIndex = 6;
			this.tabNavProps.Text = "Navigation Properties";
			// 
			// cgNavProps
			// 
			this.cgNavProps.AutoSize = true;
			this.cgNavProps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgNavProps.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgNavProps.Examples")));
			this.cgNavProps.Location = new System.Drawing.Point(3, 3);
			this.cgNavProps.Name = "cgNavProps";
			contextOptions6.AddPrefix = "";
			contextOptions6.AddSuffix = "";
			contextOptions6.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions6.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions6.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions6.RegexMatch = "";
			contextOptions6.RegexReplace = "";
			contextOptions6.RemovePrefixes = "";
			contextOptions6.RemoveSuffixes = "";
			this.cgNavProps.Options = contextOptions6;
			this.cgNavProps.ShowBeSmartOption = true;
			this.cgNavProps.Size = new System.Drawing.Size(783, 197);
			this.cgNavProps.TabIndex = 0;
			// 
			// tabComplexProps
			// 
			this.tabComplexProps.BackColor = System.Drawing.SystemColors.Window;
			this.tabComplexProps.Controls.Add(this.cgComplexProp);
			this.tabComplexProps.Location = new System.Drawing.Point(4, 22);
			this.tabComplexProps.Name = "tabComplexProps";
			this.tabComplexProps.Padding = new System.Windows.Forms.Padding(3);
			this.tabComplexProps.Size = new System.Drawing.Size(789, 203);
			this.tabComplexProps.TabIndex = 8;
			this.tabComplexProps.Text = "Complex Properties";
			// 
			// cgComplexProp
			// 
			this.cgComplexProp.AutoSize = true;
			this.cgComplexProp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgComplexProp.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgComplexProp.Examples")));
			this.cgComplexProp.Location = new System.Drawing.Point(3, 3);
			this.cgComplexProp.Name = "cgComplexProp";
			contextOptions7.AddPrefix = "";
			contextOptions7.AddSuffix = "";
			contextOptions7.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions7.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions7.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions7.RegexMatch = "";
			contextOptions7.RegexReplace = "";
			contextOptions7.RemovePrefixes = "";
			contextOptions7.RemoveSuffixes = "";
			this.cgComplexProp.Options = contextOptions7;
			this.cgComplexProp.ShowBeSmartOption = true;
			this.cgComplexProp.Size = new System.Drawing.Size(783, 197);
			this.cgComplexProp.TabIndex = 0;
			// 
			// tabAssociations
			// 
			this.tabAssociations.Controls.Add(this.cgAssociations);
			this.tabAssociations.Location = new System.Drawing.Point(4, 22);
			this.tabAssociations.Name = "tabAssociations";
			this.tabAssociations.Padding = new System.Windows.Forms.Padding(3);
			this.tabAssociations.Size = new System.Drawing.Size(789, 203);
			this.tabAssociations.TabIndex = 3;
			this.tabAssociations.Text = "Associations";
			this.tabAssociations.UseVisualStyleBackColor = true;
			// 
			// cgAssociations
			// 
			this.cgAssociations.AutoSize = true;
			this.cgAssociations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgAssociations.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgAssociations.Examples")));
			this.cgAssociations.Location = new System.Drawing.Point(3, 3);
			this.cgAssociations.Name = "cgAssociations";
			contextOptions8.AddPrefix = "";
			contextOptions8.AddSuffix = "";
			contextOptions8.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions8.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions8.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions8.RegexMatch = "";
			contextOptions8.RegexReplace = "";
			contextOptions8.RemovePrefixes = "";
			contextOptions8.RemoveSuffixes = "";
			this.cgAssociations.Options = contextOptions8;
			this.cgAssociations.ShowBeSmartOption = true;
			this.cgAssociations.Size = new System.Drawing.Size(783, 197);
			this.cgAssociations.TabIndex = 0;
			// 
			// tabMethods
			// 
			this.tabMethods.Controls.Add(this.cgMethods);
			this.tabMethods.Location = new System.Drawing.Point(4, 22);
			this.tabMethods.Name = "tabMethods";
			this.tabMethods.Padding = new System.Windows.Forms.Padding(3);
			this.tabMethods.Size = new System.Drawing.Size(789, 203);
			this.tabMethods.TabIndex = 4;
			this.tabMethods.Text = "Methods / Procedures";
			this.tabMethods.UseVisualStyleBackColor = true;
			// 
			// cgMethods
			// 
			this.cgMethods.AutoSize = true;
			this.cgMethods.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cgMethods.Examples = ((System.Collections.Generic.List<string>)(resources.GetObject("cgMethods.Examples")));
			this.cgMethods.Location = new System.Drawing.Point(3, 3);
			this.cgMethods.Name = "cgMethods";
			contextOptions9.AddPrefix = "";
			contextOptions9.AddSuffix = "";
			contextOptions9.ApplyRegex = EdmxTypist.Options.ApplyRegexEnum.DontApply;
			contextOptions9.CaseStyle = EdmxTypist.Options.CaseStyleEnum.CamelCase;
			contextOptions9.Flexing = EdmxTypist.Options.FlexingStrategyEnum.BeSmart;
			contextOptions9.RegexMatch = "";
			contextOptions9.RegexReplace = "";
			contextOptions9.RemovePrefixes = "";
			contextOptions9.RemoveSuffixes = "";
			this.cgMethods.Options = contextOptions9;
			this.cgMethods.ShowBeSmartOption = true;
			this.cgMethods.Size = new System.Drawing.Size(783, 197);
			this.cgMethods.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(lbBaseName);
			this.flowLayoutPanel2.Controls.Add(this.rdUseCurrentName);
			this.flowLayoutPanel2.Controls.Add(this.rdUseDbName);
			this.flowLayoutPanel2.Controls.Add(this.button3);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(826, 24);
			this.flowLayoutPanel2.TabIndex = 8;
			// 
			// rdUseCurrentName
			// 
			this.rdUseCurrentName.AutoSize = true;
			this.rdUseCurrentName.Checked = true;
			this.rdUseCurrentName.Location = new System.Drawing.Point(76, 3);
			this.rdUseCurrentName.Name = "rdUseCurrentName";
			this.rdUseCurrentName.Size = new System.Drawing.Size(88, 17);
			this.rdUseCurrentName.TabIndex = 7;
			this.rdUseCurrentName.TabStop = true;
			this.rdUseCurrentName.Text = "Current name";
			this.rdUseCurrentName.UseVisualStyleBackColor = true;
			// 
			// rdUseDbName
			// 
			this.rdUseDbName.AutoSize = true;
			this.rdUseDbName.Location = new System.Drawing.Point(170, 3);
			this.rdUseDbName.Name = "rdUseDbName";
			this.rdUseDbName.Size = new System.Drawing.Size(132, 17);
			this.rdUseDbName.TabIndex = 8;
			this.rdUseDbName.Text = "Database object name";
			this.rdUseDbName.UseVisualStyleBackColor = true;
			this.rdUseDbName.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(307, 2);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 20);
			this.button3.TabIndex = 9;
			this.button3.Text = "Debug";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.DebugButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbEdmxFile);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(label1);
			this.panel1.Controls.Add(this.btRun);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 341);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(826, 34);
			this.panel1.TabIndex = 9;
			// 
			// lbEdmxFile
			// 
			this.lbEdmxFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbEdmxFile.AutoSize = true;
			this.lbEdmxFile.Location = new System.Drawing.Point(376, 10);
			this.lbEdmxFile.Name = "lbEdmxFile";
			this.lbEdmxFile.Size = new System.Drawing.Size(280, 13);
			this.lbEdmxFile.TabIndex = 9;
			this.lbEdmxFile.Text = "Hey! I need a file to work with! Choose it from File > Open.";
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(241, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Options";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Location = new System.Drawing.Point(110, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Load Custom Renamer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btRun
			// 
			this.btRun.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btRun.Enabled = false;
			this.btRun.Location = new System.Drawing.Point(662, 5);
			this.btRun.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
			this.btRun.Name = "btRun";
			this.btRun.Size = new System.Drawing.Size(157, 23);
			this.btRun.TabIndex = 3;
			this.btRun.Text = "Please, save me some time!";
			this.btRun.UseVisualStyleBackColor = true;
			this.btRun.Click += new System.EventHandler(this.btRun_Click);
			// 
			// Menu
			// 
			this.Menu.Dock = System.Windows.Forms.DockStyle.None;
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.wannaHelpToolStripMenuItem,
            this.toolStripMenuItem2});
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(832, 24);
			this.Menu.TabIndex = 12;
			this.Menu.Text = "Menu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.Menu_FileOpen_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.Menu_FileExit_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "&Settings";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.copyToolStripMenuItem.Text = "Copy...";
			// 
			// wannaHelpToolStripMenuItem
			// 
			this.wannaHelpToolStripMenuItem.Name = "wannaHelpToolStripMenuItem";
			this.wannaHelpToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.wannaHelpToolStripMenuItem.Text = "Want to help?";
			this.wannaHelpToolStripMenuItem.Click += new System.EventHandler(this.wannaHelpToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 402);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "Main";
			this.Text = "Edmx Typist";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.LayoutPanel.ResumeLayout(false);
			this.tabPanel.ResumeLayout(false);
			this.TabDefault.ResumeLayout(false);
			this.TabDefault.PerformLayout();
			this.tabEntitySets.ResumeLayout(false);
			this.tabEntitySets.PerformLayout();
			this.tabEntityTypes.ResumeLayout(false);
			this.tabEntityTypes.PerformLayout();
			this.tabComplexTypes.ResumeLayout(false);
			this.tabComplexTypes.PerformLayout();
			this.tabScalar.ResumeLayout(false);
			this.tabScalar.PerformLayout();
			this.tabNavProps.ResumeLayout(false);
			this.tabNavProps.PerformLayout();
			this.tabComplexProps.ResumeLayout(false);
			this.tabComplexProps.PerformLayout();
			this.tabAssociations.ResumeLayout(false);
			this.tabAssociations.PerformLayout();
			this.tabMethods.ResumeLayout(false);
			this.tabMethods.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog OpenFileDlg;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
		private System.Windows.Forms.TabControl tabPanel;
		private System.Windows.Forms.TabPage TabDefault;
		private EdmxConfigGroup cgDefault;
		private System.Windows.Forms.TabPage tabEntitySets;
		private System.Windows.Forms.TabPage tabEntityTypes;
		private System.Windows.Forms.TabPage tabComplexTypes;
		private System.Windows.Forms.TabPage tabScalar;
		private System.Windows.Forms.TabPage tabNavProps;
		private System.Windows.Forms.TabPage tabComplexProps;
		private System.Windows.Forms.TabPage tabAssociations;
		private System.Windows.Forms.TabPage tabMethods;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.RadioButton rdUseCurrentName;
		private System.Windows.Forms.RadioButton rdUseDbName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbEdmxFile;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btRun;
		private System.Windows.Forms.MenuStrip Menu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.Button button3;
		private EdmxConfigGroup cgEntitySets;
		private EdmxConfigGroup cgEntityTypes;
		private EdmxConfigGroup cgComplexTypes;
		private EdmxConfigGroup cgScalars;
		private EdmxConfigGroup cgNavProps;
		private EdmxConfigGroup cgComplexProp;
		private EdmxConfigGroup cgAssociations;
		private EdmxConfigGroup cgMethods;
		private System.Windows.Forms.ToolStripMenuItem wannaHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
	}
}

