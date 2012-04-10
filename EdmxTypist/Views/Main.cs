namespace EdmxTypist.Views
{
	using EdmxTypist;
	using System;
	using System.IO;
	using System.Windows.Forms;
	using ModelInfo;
	using Options;
	using Flexer.RuleSets;
	using Properties;
	using Renamer;

	public partial class Main : Form
	{
		public GlobalOptions Options;
		public string edmxFile;
		private Typist typist;

		private EdmxNamesSample samples;

		public Main()
		{
			InitializeComponent();

			Options = new GlobalOptions();
			typist = new Typist();

			cgDefault.Options = Options.Defaults;
			cgAssociations.Options = Options.Associations;
			cgComplexProp.Options = Options.ComplexProps;
			cgComplexTypes.Options = Options.ComplexTypes;
			cgEntitySets.Options = Options.EntitySets;
			cgEntityTypes.Options = Options.EntityTypes;
			cgMethods.Options = Options.Methods;
			cgNavProps.Options = Options.NavigationProps;
			cgScalars.Options = Options.ScalarMembers;
		}

		private void UpdateOptions()
		{
			Options.Defaults = cgDefault.Options;

		}

		private void Run()
		{
			UpdateOptions();

			typist.Run(edmxFile, new PortugueseRuleSet(), Options, null);

			MessageBox.Show("Done!");
		}

		private void OnFileLoad()
		{
			samples = typist.SampleNames(edmxFile);
		}

		#region "Tedious interface stuff"
		// ReSharper disable InconsistentNaming
		private void Menu_FileOpen_Click(object sender, EventArgs e)
		{
			var result = OpenFileDlg.ShowDialog(this);

			if(result == DialogResult.OK)
			{
				edmxFile = OpenFileDlg.FileName;
				lbEdmxFile.Text = String.Format("Ok, I'll change the {0} file for you!", Path.GetFileName(OpenFileDlg.FileName));
				btRun.Enabled = true;
			}

			OnFileLoad();
		}

		private void Menu_FileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btRun_Click(object sender, EventArgs e)
		{
			Run();
		}
		#endregion

		private void DebugButton_Click(object sender, EventArgs e)
		{
			var debugging = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Resources.not_available_yet_wanna_help);
		}

		private void wannaHelpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new HowToHelp();
			f.Show(this);
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show(Resources.not_available_yet_wanna_help);
			rdUseDbName.Checked = false;
			rdUseCurrentName.Checked = true;
		}

		// ReSharper restore InconsistentNaming
	}
}
