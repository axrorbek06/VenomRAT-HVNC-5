﻿namespace Server.Forms
{
	// Token: 0x02000092 RID: 146
	public partial class FormRegValueEditBinary : global::System.Windows.Forms.Form
	{
		// Token: 0x06000479 RID: 1145 RVA: 0x00004593 File Offset: 0x00002793
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0002FC34 File Offset: 0x0002DE34
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormRegValueEditBinary));
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.hexEditor = new global::Server.Helper.HexEditor.HexEditor();
			this.cancelButton = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.okButton = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.valueNameTxtBox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel2.Controls.Add(this.hexEditor);
			this.panel2.Controls.Add(this.cancelButton);
			this.panel2.Controls.Add(this.okButton);
			this.panel2.Controls.Add(this.valueNameTxtBox);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(0, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(505, 316);
			this.panel2.TabIndex = 168;
			this.hexEditor.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.hexEditor.BorderColor = global::System.Drawing.Color.Empty;
			this.hexEditor.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.hexEditor.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.hexEditor.ForeColor = global::System.Drawing.Color.LightGray;
			this.hexEditor.Location = new global::System.Drawing.Point(32, 89);
			this.hexEditor.Name = "hexEditor";
			this.hexEditor.Size = new global::System.Drawing.Size(442, 165);
			this.hexEditor.TabIndex = 69;
			this.cancelButton.Animated = true;
			this.cancelButton.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.cancelButton.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.cancelButton.BorderRadius = 1;
			this.cancelButton.BorderThickness = 1;
			this.cancelButton.CheckedState.Parent = this.cancelButton;
			this.cancelButton.CustomImages.Parent = this.cancelButton;
			this.cancelButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.cancelButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.cancelButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.cancelButton.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.cancelButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.cancelButton.DisabledState.Parent = this.cancelButton;
			this.cancelButton.FillColor = global::System.Drawing.Color.Transparent;
			this.cancelButton.FillColor2 = global::System.Drawing.Color.Transparent;
			this.cancelButton.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.cancelButton.ForeColor = global::System.Drawing.Color.DarkGray;
			this.cancelButton.HoverState.Parent = this.cancelButton;
			this.cancelButton.Location = new global::System.Drawing.Point(343, 273);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
			this.cancelButton.Size = new global::System.Drawing.Size(131, 31);
			this.cancelButton.TabIndex = 68;
			this.cancelButton.Text = "Cancel";
			this.okButton.Animated = true;
			this.okButton.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.okButton.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.okButton.BorderRadius = 1;
			this.okButton.BorderThickness = 1;
			this.okButton.CheckedState.Parent = this.okButton;
			this.okButton.CustomImages.Parent = this.okButton;
			this.okButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.okButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.okButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.okButton.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.okButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.okButton.DisabledState.Parent = this.okButton;
			this.okButton.FillColor = global::System.Drawing.Color.Transparent;
			this.okButton.FillColor2 = global::System.Drawing.Color.Transparent;
			this.okButton.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.okButton.ForeColor = global::System.Drawing.Color.DarkGray;
			this.okButton.HoverState.Parent = this.okButton;
			this.okButton.Location = new global::System.Drawing.Point(30, 273);
			this.okButton.Name = "okButton";
			this.okButton.ShadowDecoration.Parent = this.okButton;
			this.okButton.Size = new global::System.Drawing.Size(131, 31);
			this.okButton.TabIndex = 68;
			this.okButton.Text = "OK";
			this.okButton.Click += new global::System.EventHandler(this.okButton_Click);
			this.valueNameTxtBox.Animated = true;
			this.valueNameTxtBox.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.valueNameTxtBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.valueNameTxtBox.DefaultText = "";
			this.valueNameTxtBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.valueNameTxtBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.valueNameTxtBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.valueNameTxtBox.DisabledState.Parent = this.valueNameTxtBox;
			this.valueNameTxtBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.valueNameTxtBox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.valueNameTxtBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.valueNameTxtBox.FocusedState.Parent = this.valueNameTxtBox;
			this.valueNameTxtBox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.valueNameTxtBox.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.valueNameTxtBox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.valueNameTxtBox.HoverState.Parent = this.valueNameTxtBox;
			this.valueNameTxtBox.Location = new global::System.Drawing.Point(30, 27);
			this.valueNameTxtBox.Name = "valueNameTxtBox";
			this.valueNameTxtBox.PasswordChar = '\0';
			this.valueNameTxtBox.PlaceholderText = "";
			this.valueNameTxtBox.SelectedText = "";
			this.valueNameTxtBox.ShadowDecoration.Parent = this.valueNameTxtBox;
			this.valueNameTxtBox.Size = new global::System.Drawing.Size(444, 25);
			this.valueNameTxtBox.TabIndex = 2;
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(29, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(66, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Value name:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(34, 59);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(61, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Value data:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(3, 8);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(164, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Reg Value Edit Binary";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(505, 31);
			this.siticoneGradientPanel4.TabIndex = 166;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(505, 34);
			this.panel1.TabIndex = 167;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(478, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(505, 381);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormRegValueEditBinary";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormRegValueEditBinary";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000354 RID: 852
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000355 RID: 853
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000356 RID: 854
		private global::Server.Helper.HexEditor.HexEditor hexEditor;

		// Token: 0x04000357 RID: 855
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton cancelButton;

		// Token: 0x04000358 RID: 856
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton okButton;

		// Token: 0x04000359 RID: 857
		public global::Siticone.Desktop.UI.WinForms.SiticoneTextBox valueNameTxtBox;

		// Token: 0x0400035A RID: 858
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400035B RID: 859
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400035C RID: 860
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400035D RID: 861
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x0400035E RID: 862
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400035F RID: 863
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000360 RID: 864
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000361 RID: 865
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
