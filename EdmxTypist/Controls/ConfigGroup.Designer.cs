namespace EdmxTypist.Controls
{
	partial class EdmxConfigGroup
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.GroupBox gpRegex;
			System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
			System.Windows.Forms.GroupBox gbCasing;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
			System.Windows.Forms.GroupBox groupBox6;
			System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
			System.Windows.Forms.Label label10;
			System.Windows.Forms.Label label9;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label lbFieldLabel;
			System.Windows.Forms.Label lbExample;
			System.Windows.Forms.Label lbResultHeading;
			this.flexingPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.rdBeSmart = new System.Windows.Forms.RadioButton();
			this.rdPluralize = new System.Windows.Forms.RadioButton();
			this.rdSingularize = new System.Windows.Forms.RadioButton();
			this.rdLeaveItAlone = new System.Windows.Forms.RadioButton();
			this.cbRegex = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbRegexMatch = new System.Windows.Forms.TextBox();
			this.bsContextOptions = new System.Windows.Forms.BindingSource(this.components);
			this.tbRegexReplace = new System.Windows.Forms.TextBox();
			this.rdCamelCase = new System.Windows.Forms.RadioButton();
			this.rdLowerCamelCase = new System.Windows.Forms.RadioButton();
			this.rdLowerUnderscore = new System.Windows.Forms.RadioButton();
			this.tbAddSuffix = new System.Windows.Forms.TextBox();
			this.tbAddPrefix = new System.Windows.Forms.TextBox();
			this.tbRemoveSuffix = new System.Windows.Forms.TextBox();
			this.tbRemovePrefix = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lbFormattedName = new System.Windows.Forms.Label();
			this.ddExamples = new System.Windows.Forms.ComboBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			gpRegex = new System.Windows.Forms.GroupBox();
			tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			gbCasing = new System.Windows.Forms.GroupBox();
			flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			groupBox6 = new System.Windows.Forms.GroupBox();
			tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			label10 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			lbFieldLabel = new System.Windows.Forms.Label();
			lbExample = new System.Windows.Forms.Label();
			lbResultHeading = new System.Windows.Forms.Label();
			groupBox1.SuspendLayout();
			this.flexingPanel.SuspendLayout();
			gpRegex.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsContextOptions)).BeginInit();
			gbCasing.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			groupBox6.SuspendLayout();
			tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.flexingPanel);
			groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			groupBox1.Location = new System.Drawing.Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(380, 47);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Pluralization";
			// 
			// flexingPanel
			// 
			this.flexingPanel.Controls.Add(this.rdBeSmart);
			this.flexingPanel.Controls.Add(this.rdPluralize);
			this.flexingPanel.Controls.Add(this.rdSingularize);
			this.flexingPanel.Controls.Add(this.rdLeaveItAlone);
			this.flexingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flexingPanel.Location = new System.Drawing.Point(3, 16);
			this.flexingPanel.Name = "flexingPanel";
			this.flexingPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.flexingPanel.Size = new System.Drawing.Size(374, 28);
			this.flexingPanel.TabIndex = 0;
			// 
			// rdBeSmart
			// 
			this.rdBeSmart.AutoSize = true;
			this.rdBeSmart.Checked = true;
			this.rdBeSmart.Location = new System.Drawing.Point(23, 5);
			this.rdBeSmart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.rdBeSmart.Name = "rdBeSmart";
			this.rdBeSmart.Size = new System.Drawing.Size(69, 17);
			this.rdBeSmart.TabIndex = 2;
			this.rdBeSmart.TabStop = true;
			this.rdBeSmart.Text = "Be smart!";
			this.rdBeSmart.UseVisualStyleBackColor = true;
			// 
			// rdPluralize
			// 
			this.rdPluralize.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.rdPluralize.AutoSize = true;
			this.rdPluralize.Location = new System.Drawing.Point(98, 5);
			this.rdPluralize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.rdPluralize.Name = "rdPluralize";
			this.rdPluralize.Size = new System.Drawing.Size(64, 17);
			this.rdPluralize.TabIndex = 0;
			this.rdPluralize.Text = "Pluralize";
			this.rdPluralize.UseVisualStyleBackColor = true;
			// 
			// rdSingularize
			// 
			this.rdSingularize.AutoSize = true;
			this.rdSingularize.Location = new System.Drawing.Point(168, 5);
			this.rdSingularize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.rdSingularize.Name = "rdSingularize";
			this.rdSingularize.Size = new System.Drawing.Size(76, 17);
			this.rdSingularize.TabIndex = 1;
			this.rdSingularize.Text = "Singularize";
			this.rdSingularize.UseVisualStyleBackColor = true;
			// 
			// rdLeaveItAlone
			// 
			this.rdLeaveItAlone.AutoSize = true;
			this.rdLeaveItAlone.Location = new System.Drawing.Point(250, 5);
			this.rdLeaveItAlone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.rdLeaveItAlone.Name = "rdLeaveItAlone";
			this.rdLeaveItAlone.Size = new System.Drawing.Size(92, 17);
			this.rdLeaveItAlone.TabIndex = 2;
			this.rdLeaveItAlone.Text = "Leave it alone";
			this.rdLeaveItAlone.UseVisualStyleBackColor = true;
			// 
			// gpRegex
			// 
			gpRegex.Controls.Add(tableLayoutPanel4);
			gpRegex.Dock = System.Windows.Forms.DockStyle.Fill;
			gpRegex.Location = new System.Drawing.Point(389, 56);
			gpRegex.Name = "gpRegex";
			gpRegex.Size = new System.Drawing.Size(353, 138);
			gpRegex.TabIndex = 2;
			gpRegex.TabStop = false;
			gpRegex.Text = "Apply a Regular Expression";
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 2;
			tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.23288F));
			tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.76712F));
			tableLayoutPanel4.Controls.Add(this.cbRegex, 0, 0);
			tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
			tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
			tableLayoutPanel4.Controls.Add(this.tbRegexMatch, 1, 1);
			tableLayoutPanel4.Controls.Add(this.tbRegexReplace, 1, 2);
			tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 3;
			tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			tableLayoutPanel4.Size = new System.Drawing.Size(347, 119);
			tableLayoutPanel4.TabIndex = 0;
			// 
			// cbRegex
			// 
			this.cbRegex.Anchor = System.Windows.Forms.AnchorStyles.Left;
			tableLayoutPanel4.SetColumnSpan(this.cbRegex, 2);
			this.cbRegex.DisplayMember = "Label";
			this.cbRegex.FormattingEnabled = true;
			this.cbRegex.Location = new System.Drawing.Point(20, 7);
			this.cbRegex.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.cbRegex.Name = "cbRegex";
			this.cbRegex.Size = new System.Drawing.Size(187, 21);
			this.cbRegex.TabIndex = 0;
			this.cbRegex.ValueMember = "Value";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(30, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Match:";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 91);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "Replace:";
			// 
			// tbRegexMatch
			// 
			this.tbRegexMatch.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbRegexMatch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContextOptions, "RegexMatch", true));
			this.tbRegexMatch.Location = new System.Drawing.Point(76, 45);
			this.tbRegexMatch.Name = "tbRegexMatch";
			this.tbRegexMatch.Size = new System.Drawing.Size(268, 20);
			this.tbRegexMatch.TabIndex = 2;
			// 
			// bsContextOptions
			// 
			this.bsContextOptions.DataSource = typeof(EdmxTypist.Options.ContextOptions);
			// 
			// tbRegexReplace
			// 
			this.tbRegexReplace.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbRegexReplace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContextOptions, "RegexReplace", true));
			this.tbRegexReplace.Location = new System.Drawing.Point(76, 87);
			this.tbRegexReplace.Name = "tbRegexReplace";
			this.tbRegexReplace.Size = new System.Drawing.Size(268, 20);
			this.tbRegexReplace.TabIndex = 2;
			// 
			// gbCasing
			// 
			gbCasing.Controls.Add(flowLayoutPanel1);
			gbCasing.Dock = System.Windows.Forms.DockStyle.Fill;
			gbCasing.Location = new System.Drawing.Point(389, 3);
			gbCasing.Name = "gbCasing";
			gbCasing.Size = new System.Drawing.Size(353, 47);
			gbCasing.TabIndex = 0;
			gbCasing.TabStop = false;
			gbCasing.Text = "Casing";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(this.rdCamelCase);
			flowLayoutPanel1.Controls.Add(this.rdLowerCamelCase);
			flowLayoutPanel1.Controls.Add(this.rdLowerUnderscore);
			flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new System.Drawing.Size(347, 28);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// rdCamelCase
			// 
			this.rdCamelCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.rdCamelCase.AutoSize = true;
			this.rdCamelCase.Checked = true;
			this.rdCamelCase.Location = new System.Drawing.Point(20, 5);
			this.rdCamelCase.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
			this.rdCamelCase.Name = "rdCamelCase";
			this.rdCamelCase.Size = new System.Drawing.Size(78, 17);
			this.rdCamelCase.TabIndex = 0;
			this.rdCamelCase.TabStop = true;
			this.rdCamelCase.Text = "CamelCase";
			this.rdCamelCase.UseVisualStyleBackColor = true;
			// 
			// rdLowerCamelCase
			// 
			this.rdLowerCamelCase.AutoSize = true;
			this.rdLowerCamelCase.Location = new System.Drawing.Point(104, 5);
			this.rdLowerCamelCase.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.rdLowerCamelCase.Name = "rdLowerCamelCase";
			this.rdLowerCamelCase.Size = new System.Drawing.Size(103, 17);
			this.rdLowerCamelCase.TabIndex = 1;
			this.rdLowerCamelCase.Text = "lowerCamelCase";
			this.rdLowerCamelCase.UseVisualStyleBackColor = true;
			// 
			// rdLowerUnderscore
			// 
			this.rdLowerUnderscore.AutoSize = true;
			this.rdLowerUnderscore.Location = new System.Drawing.Point(213, 5);
			this.rdLowerUnderscore.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.rdLowerUnderscore.Name = "rdLowerUnderscore";
			this.rdLowerUnderscore.Size = new System.Drawing.Size(114, 17);
			this.rdLowerUnderscore.TabIndex = 2;
			this.rdLowerUnderscore.Text = "lower_underscores";
			this.rdLowerUnderscore.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(tableLayoutPanel9);
			groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			groupBox6.Location = new System.Drawing.Point(3, 56);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new System.Drawing.Size(380, 138);
			groupBox6.TabIndex = 5;
			groupBox6.TabStop = false;
			groupBox6.Text = "Prefix and Suffix";
			// 
			// tableLayoutPanel9
			// 
			tableLayoutPanel9.ColumnCount = 3;
			tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.30769F));
			tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.69231F));
			tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
			tableLayoutPanel9.Controls.Add(label10, 2, 1);
			tableLayoutPanel9.Controls.Add(label9, 2, 0);
			tableLayoutPanel9.Controls.Add(this.tbAddSuffix, 1, 3);
			tableLayoutPanel9.Controls.Add(this.tbAddPrefix, 1, 2);
			tableLayoutPanel9.Controls.Add(this.tbRemoveSuffix, 1, 1);
			tableLayoutPanel9.Controls.Add(this.tbRemovePrefix, 1, 0);
			tableLayoutPanel9.Controls.Add(label5, 0, 3);
			tableLayoutPanel9.Controls.Add(label4, 0, 2);
			tableLayoutPanel9.Controls.Add(label3, 0, 1);
			tableLayoutPanel9.Controls.Add(lbFieldLabel, 0, 0);
			tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
			tableLayoutPanel9.Name = "tableLayoutPanel9";
			tableLayoutPanel9.RowCount = 4;
			tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			tableLayoutPanel9.Size = new System.Drawing.Size(374, 119);
			tableLayoutPanel9.TabIndex = 6;
			// 
			// label10
			// 
			label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label10.Location = new System.Drawing.Point(263, 37);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(107, 13);
			label10.TabIndex = 5;
			label10.Text = "Separated by spaces";
			// 
			// label9
			// 
			label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label9.Location = new System.Drawing.Point(263, 8);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(107, 13);
			label9.TabIndex = 6;
			label9.Text = "Separated by spaces";
			// 
			// tbAddSuffix
			// 
			this.tbAddSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAddSuffix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContextOptions, "AddSuffix", true));
			this.tbAddSuffix.Location = new System.Drawing.Point(100, 93);
			this.tbAddSuffix.Name = "tbAddSuffix";
			this.tbAddSuffix.Size = new System.Drawing.Size(157, 20);
			this.tbAddSuffix.TabIndex = 11;
			// 
			// tbAddPrefix
			// 
			this.tbAddPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAddPrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContextOptions, "AddPrefix", true));
			this.tbAddPrefix.Location = new System.Drawing.Point(100, 62);
			this.tbAddPrefix.Name = "tbAddPrefix";
			this.tbAddPrefix.Size = new System.Drawing.Size(157, 20);
			this.tbAddPrefix.TabIndex = 13;
			// 
			// tbRemoveSuffix
			// 
			this.tbRemoveSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRemoveSuffix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContextOptions, "RemoveSuffixes", true));
			this.tbRemoveSuffix.Location = new System.Drawing.Point(100, 33);
			this.tbRemoveSuffix.Name = "tbRemoveSuffix";
			this.tbRemoveSuffix.Size = new System.Drawing.Size(157, 20);
			this.tbRemoveSuffix.TabIndex = 12;
			// 
			// tbRemovePrefix
			// 
			this.tbRemovePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRemovePrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContextOptions, "RemovePrefixes", true));
			this.tbRemovePrefix.Location = new System.Drawing.Point(100, 4);
			this.tbRemovePrefix.Name = "tbRemovePrefix";
			this.tbRemovePrefix.Size = new System.Drawing.Size(157, 20);
			this.tbRemovePrefix.TabIndex = 10;
			// 
			// label5
			// 
			label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(38, 96);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(56, 13);
			label5.TabIndex = 4;
			label5.Text = "Add suffix:";
			// 
			// label4
			// 
			label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(37, 66);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(57, 13);
			label4.TabIndex = 9;
			label4.Text = "Add prefix:";
			// 
			// label3
			// 
			label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			label3.Location = new System.Drawing.Point(3, 30);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(91, 26);
			label3.TabIndex = 8;
			label3.Text = "Remove Suffixes:";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbFieldLabel
			// 
			lbFieldLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			lbFieldLabel.Location = new System.Drawing.Point(3, 1);
			lbFieldLabel.Name = "lbFieldLabel";
			lbFieldLabel.Size = new System.Drawing.Size(91, 26);
			lbFieldLabel.TabIndex = 7;
			lbFieldLabel.Text = "Remove Prefixes:";
			lbFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbExample
			// 
			lbExample.Anchor = System.Windows.Forms.AnchorStyles.Right;
			lbExample.AutoSize = true;
			lbExample.Location = new System.Drawing.Point(12, 7);
			lbExample.Name = "lbExample";
			lbExample.Size = new System.Drawing.Size(50, 13);
			lbExample.TabIndex = 1;
			lbExample.Text = "Example:";
			// 
			// lbResultHeading
			// 
			lbResultHeading.Anchor = System.Windows.Forms.AnchorStyles.Right;
			lbResultHeading.AutoSize = true;
			lbResultHeading.Location = new System.Drawing.Point(308, 7);
			lbResultHeading.Name = "lbResultHeading";
			lbResultHeading.Size = new System.Drawing.Size(40, 13);
			lbResultHeading.TabIndex = 6;
			lbResultHeading.Text = "Result:";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.91122F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.08878F));
			this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 2);
			this.tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(gpRegex, 1, 1);
			this.tableLayoutPanel3.Controls.Add(gbCasing, 1, 0);
			this.tableLayoutPanel3.Controls.Add(groupBox6, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(745, 250);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// groupBox5
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.groupBox5, 2);
			this.groupBox5.Controls.Add(this.tableLayoutPanel2);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox5.Location = new System.Drawing.Point(3, 200);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(739, 47);
			this.groupBox5.TabIndex = 11;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Preview";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.003601F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.29172F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.963985F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.98079F));
			this.tableLayoutPanel2.Controls.Add(this.lbFormattedName, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.ddExamples, 1, 0);
			this.tableLayoutPanel2.Controls.Add(lbExample, 0, 0);
			this.tableLayoutPanel2.Controls.Add(lbResultHeading, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 28);
			this.tableLayoutPanel2.TabIndex = 13;
			// 
			// lbFormattedName
			// 
			this.lbFormattedName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbFormattedName.AutoSize = true;
			this.lbFormattedName.Location = new System.Drawing.Point(354, 7);
			this.lbFormattedName.Name = "lbFormattedName";
			this.lbFormattedName.Size = new System.Drawing.Size(108, 13);
			this.lbFormattedName.TabIndex = 4;
			this.lbFormattedName.Text = "Transformed example";
			// 
			// ddExamples
			// 
			this.ddExamples.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ddExamples.FormattingEnabled = true;
			this.ddExamples.Location = new System.Drawing.Point(68, 3);
			this.ddExamples.Name = "ddExamples";
			this.ddExamples.Size = new System.Drawing.Size(198, 21);
			this.ddExamples.TabIndex = 5;
			this.ddExamples.TextUpdate += new System.EventHandler(this.UpdateResult);
			// 
			// EdmxConfigGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.tableLayoutPanel3);
			this.Name = "EdmxConfigGroup";
			this.Size = new System.Drawing.Size(745, 250);
			groupBox1.ResumeLayout(false);
			this.flexingPanel.ResumeLayout(false);
			this.flexingPanel.PerformLayout();
			gpRegex.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsContextOptions)).EndInit();
			gbCasing.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			groupBox6.ResumeLayout(false);
			tableLayoutPanel9.ResumeLayout(false);
			tableLayoutPanel9.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.ComboBox cbRegex;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbRegexMatch;
		private System.Windows.Forms.TextBox tbRegexReplace;
		private System.Windows.Forms.RadioButton rdCamelCase;
		private System.Windows.Forms.RadioButton rdLowerCamelCase;
		private System.Windows.Forms.RadioButton rdLowerUnderscore;
		private System.Windows.Forms.TextBox tbAddSuffix;
		private System.Windows.Forms.TextBox tbAddPrefix;
		private System.Windows.Forms.TextBox tbRemoveSuffix;
		private System.Windows.Forms.TextBox tbRemovePrefix;
		private System.Windows.Forms.BindingSource bsContextOptions;
		private System.Windows.Forms.RadioButton rdBeSmart;
		private System.Windows.Forms.RadioButton rdPluralize;
		private System.Windows.Forms.RadioButton rdSingularize;
		private System.Windows.Forms.RadioButton rdLeaveItAlone;
		private System.Windows.Forms.FlowLayoutPanel flexingPanel;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label lbFormattedName;
		private System.Windows.Forms.ComboBox ddExamples;
	}
}
