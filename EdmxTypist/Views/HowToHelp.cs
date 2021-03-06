﻿/**
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
	using System;
	using System.Windows.Forms;
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
