
namespace DIR_Updater
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.updttxt = new System.Windows.Forms.Label();
			this.dwnld = new System.Windows.Forms.ProgressBar();
			this.cacl = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// updttxt
			// 
			this.updttxt.AutoSize = true;
			this.updttxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.updttxt.Location = new System.Drawing.Point(13, 13);
			this.updttxt.Name = "updttxt";
			this.updttxt.Size = new System.Drawing.Size(189, 23);
			this.updttxt.TabIndex = 0;
			this.updttxt.Text = "Checking For Updates...";
			// 
			// dwnld
			// 
			this.dwnld.Location = new System.Drawing.Point(13, 39);
			this.dwnld.Name = "dwnld";
			this.dwnld.Size = new System.Drawing.Size(300, 30);
			this.dwnld.TabIndex = 1;
			// 
			// cacl
			// 
			this.cacl.Location = new System.Drawing.Point(219, 75);
			this.cacl.Name = "cacl";
			this.cacl.Size = new System.Drawing.Size(94, 29);
			this.cacl.TabIndex = 2;
			this.cacl.Text = "Cancel";
			this.cacl.UseVisualStyleBackColor = true;
			this.cacl.Click += new System.EventHandler(this.cacl_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 115);
			this.Controls.Add(this.cacl);
			this.Controls.Add(this.dwnld);
			this.Controls.Add(this.updttxt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label updttxt;
		private System.Windows.Forms.ProgressBar dwnld;
		private System.Windows.Forms.Button cacl;
	}
}

