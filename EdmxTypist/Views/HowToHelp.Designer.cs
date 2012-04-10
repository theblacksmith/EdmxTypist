namespace EdmxTypist.Views
{
	partial class HowToHelp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToHelp));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gitLink = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.donateLink = new System.Windows.Forms.LinkLabel();
			this.donatePic = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.donatePic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Coding";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Just go to my GitHub repository";
			// 
			// gitLink
			// 
			this.gitLink.AutoSize = true;
			this.gitLink.CausesValidation = false;
			this.gitLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.gitLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.gitLink.Location = new System.Drawing.Point(40, 63);
			this.gitLink.Name = "gitLink";
			this.gitLink.Size = new System.Drawing.Size(189, 13);
			this.gitLink.TabIndex = 2;
			this.gitLink.TabStop = true;
			this.gitLink.Text = "http://github.com/svallory/EdmxTypist";
			this.gitLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.gitLink.Click += new System.EventHandler(this.OpenLink);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(212, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Fork it, add code to it then fill a pull request.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Donating";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(234, 130);
			this.label5.TabIndex = 1;
			this.label5.Text = resources.GetString("label5.Text");
			// 
			// donateLink
			// 
			this.donateLink.AutoSize = true;
			this.donateLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.donateLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.donateLink.Location = new System.Drawing.Point(40, 364);
			this.donateLink.Name = "donateLink";
			this.donateLink.Size = new System.Drawing.Size(213, 13);
			this.donateLink.TabIndex = 5;
			this.donateLink.TabStop = true;
			this.donateLink.Text = "http://www.pledgie.com/campaigns/17089";
			this.donateLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.donateLink.Click += new System.EventHandler(this.OpenLink);
			// 
			// donatePic
			// 
			this.donatePic.Cursor = System.Windows.Forms.Cursors.Hand;
			this.donatePic.Image = global::EdmxTypist.Properties.Resources.donate;
			this.donatePic.Location = new System.Drawing.Point(43, 312);
			this.donatePic.Name = "donatePic";
			this.donatePic.Size = new System.Drawing.Size(149, 37);
			this.donatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.donatePic.TabIndex = 6;
			this.donatePic.TabStop = false;
			this.donatePic.Click += new System.EventHandler(this.OpenLink);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EdmxTypist.Properties.Resources.license;
			this.pictureBox1.Location = new System.Drawing.Point(267, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// HowToHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(379, 400);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.donatePic);
			this.Controls.Add(this.donateLink);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gitLink);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Name = "HowToHelp";
			this.Text = "How can you help this project";
			this.Load += new System.EventHandler(this.HowToHelp_Load);
			((System.ComponentModel.ISupportInitialize)(this.donatePic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel gitLink;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel donateLink;
		private System.Windows.Forms.PictureBox donatePic;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}