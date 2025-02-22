namespace ns0
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0000411C File Offset: 0x0000231C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000414C File Offset: 0x0000234C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.backgroundWorker_0 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_1 = new System.ComponentModel.BackgroundWorker();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.productlb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneProgressBar1 = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.statuslb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.ioslb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.seriallb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.modellb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.button = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.Snow;
            this.siticoneHtmlLabel1.IsSelectionEnabled = false;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(208, 36);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "FMI OFF OPEN MENU";
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.siticoneHtmlLabel1.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // backgroundWorker_0
            // 
            this.backgroundWorker_0.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
            // 
            // backgroundWorker_1
            // 
            this.backgroundWorker_1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_1_DoWork);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.BorderRadius = 5;
            this.siticoneControlBox1.BorderThickness = 2;
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(276, 12);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 511;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel7.IsSelectionEnabled = false;
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(45, 81);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(50, 17);
            this.siticoneHtmlLabel7.TabIndex = 544;
            this.siticoneHtmlLabel7.Text = "MODEL : ";
            // 
            // productlb
            // 
            this.productlb.BackColor = System.Drawing.Color.Transparent;
            this.productlb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlb.ForeColor = System.Drawing.Color.White;
            this.productlb.IsSelectionEnabled = false;
            this.productlb.Location = new System.Drawing.Point(118, 152);
            this.productlb.Name = "productlb";
            this.productlb.Size = new System.Drawing.Size(61, 17);
            this.productlb.TabIndex = 543;
            this.productlb.Text = "No Device";
            this.productlb.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel6.IsSelectionEnabled = false;
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(45, 152);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(65, 17);
            this.siticoneHtmlLabel6.TabIndex = 542;
            this.siticoneHtmlLabel6.Text = "PRODUCT : ";
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneProgressBar1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneProgressBar1.BorderRadius = 5;
            this.siticoneProgressBar1.FillColor = System.Drawing.Color.White;
            this.siticoneProgressBar1.Location = new System.Drawing.Point(43, 260);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.ProgressColor = System.Drawing.Color.White;
            this.siticoneProgressBar1.ProgressColor2 = System.Drawing.Color.White;
            this.siticoneProgressBar1.Size = new System.Drawing.Size(239, 10);
            this.siticoneProgressBar1.TabIndex = 541;
            this.siticoneProgressBar1.Text = "progressbar";
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // statuslb
            // 
            this.statuslb.BackColor = System.Drawing.Color.Transparent;
            this.statuslb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslb.ForeColor = System.Drawing.Color.White;
            this.statuslb.IsSelectionEnabled = false;
            this.statuslb.Location = new System.Drawing.Point(45, 185);
            this.statuslb.Name = "statuslb";
            this.statuslb.Size = new System.Drawing.Size(185, 17);
            this.statuslb.TabIndex = 539;
            this.statuslb.Text = "Please Connect Your Device First ";
            // 
            // ioslb
            // 
            this.ioslb.BackColor = System.Drawing.Color.Transparent;
            this.ioslb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ioslb.ForeColor = System.Drawing.Color.White;
            this.ioslb.IsSelectionEnabled = false;
            this.ioslb.Location = new System.Drawing.Point(119, 129);
            this.ioslb.Name = "ioslb";
            this.ioslb.Size = new System.Drawing.Size(61, 17);
            this.ioslb.TabIndex = 537;
            this.ioslb.Text = "No Device";
            this.ioslb.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // seriallb
            // 
            this.seriallb.BackColor = System.Drawing.Color.Transparent;
            this.seriallb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriallb.ForeColor = System.Drawing.Color.White;
            this.seriallb.IsSelectionEnabled = false;
            this.seriallb.Location = new System.Drawing.Point(119, 104);
            this.seriallb.Name = "seriallb";
            this.seriallb.Size = new System.Drawing.Size(61, 17);
            this.seriallb.TabIndex = 536;
            this.seriallb.Text = "No Device";
            this.seriallb.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.seriallb.Click += new System.EventHandler(this.seriallb_Click);
            // 
            // modellb
            // 
            this.modellb.BackColor = System.Drawing.Color.Transparent;
            this.modellb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modellb.ForeColor = System.Drawing.Color.White;
            this.modellb.IsSelectionEnabled = false;
            this.modellb.Location = new System.Drawing.Point(119, 81);
            this.modellb.Name = "modellb";
            this.modellb.Size = new System.Drawing.Size(61, 17);
            this.modellb.TabIndex = 535;
            this.modellb.Text = "No Device";
            this.modellb.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button.BorderRadius = 5;
            this.button.BorderThickness = 2;
            this.button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button.Enabled = false;
            this.button.FillColor = System.Drawing.Color.Transparent;
            this.button.FillColor2 = System.Drawing.Color.Transparent;
            this.button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(45, 221);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(237, 33);
            this.button.TabIndex = 534;
            this.button.Text = "START FMI OFF";
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel5.IsSelectionEnabled = false;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(45, 104);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(48, 17);
            this.siticoneHtmlLabel5.TabIndex = 533;
            this.siticoneHtmlLabel5.Text = "SERIAL : ";
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel4.IsSelectionEnabled = false;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(47, 129);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(28, 17);
            this.siticoneHtmlLabel4.TabIndex = 532;
            this.siticoneHtmlLabel4.Text = "iOS : ";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel2.IsSelectionEnabled = false;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(83, 290);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(137, 17);
            this.siticoneHtmlLabel2.TabIndex = 545;
            this.siticoneHtmlLabel2.Text = "with ♡ by Christian Muhi";
            this.siticoneHtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(322, 319);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.siticoneHtmlLabel7);
            this.Controls.Add(this.productlb);
            this.Controls.Add(this.siticoneHtmlLabel6);
            this.Controls.Add(this.siticoneProgressBar1);
            this.Controls.Add(this.statuslb);
            this.Controls.Add(this.ioslb);
            this.Controls.Add(this.seriallb);
            this.Controls.Add(this.modellb);
            this.Controls.Add(this.button);
            this.Controls.Add(this.siticoneHtmlLabel5);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "FMI OFF OPEN MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000D RID: 13
		private global::System.ComponentModel.IContainer icontainer_0 = null;

		// Token: 0x0400000E RID: 14
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;

		// Token: 0x0400000F RID: 15
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000012 RID: 18
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000014 RID: 20
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;

		// Token: 0x04000015 RID: 21
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel productlb;

		// Token: 0x04000016 RID: 22
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;

		// Token: 0x04000017 RID: 23
		private global::Siticone.Desktop.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;

		// Token: 0x04000019 RID: 25
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel statuslb;

		// Token: 0x0400001B RID: 27
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel ioslb;

		// Token: 0x0400001C RID: 28
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel seriallb;

		// Token: 0x0400001D RID: 29
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel modellb;

		// Token: 0x0400001E RID: 30
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button;

		// Token: 0x0400001F RID: 31
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;

		// Token: 0x04000020 RID: 32
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
		private System.ComponentModel.IContainer components;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
    }
}
