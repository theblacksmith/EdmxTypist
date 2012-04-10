using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EdmxTypist.Views
{
	using System.Diagnostics;

	public partial class HowToHelp : Form
	{
		public HowToHelp()
		{
			InitializeComponent();
		}

		private void HowToHelp_Load(object sender, EventArgs e)
		{
			donatePic.Text = donateLink.Text;
		}

		private void OpenLink(object sender, EventArgs e)
		{
			var link = sender as Control;
			
			if(link != null)
				Process.Start(link.Text);
		}
	}
}
