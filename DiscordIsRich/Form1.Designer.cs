namespace DiscordIsRich
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.IdBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.infobtn = new System.Windows.Forms.Button();
			this.DropDown = new System.Windows.Forms.ComboBox();
			this.SlotEdit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.TheTimer = new System.Windows.Forms.TextBox();
			this.SmolTxt = new System.Windows.Forms.TextBox();
			this.LargeTxt = new System.Windows.Forms.TextBox();
			this.SmolImg = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.BTN22 = new System.Windows.Forms.TextBox();
			this.BTN21 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.BTN12 = new System.Windows.Forms.TextBox();
			this.BTN11 = new System.Windows.Forms.TextBox();
			this.LargeImg = new System.Windows.Forms.TextBox();
			this.StatusBox = new System.Windows.Forms.TextBox();
			this.DetailBox = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.importbtn = new System.Windows.Forms.Button();
			this.exportbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// IdBox
			// 
			this.IdBox.BackColor = System.Drawing.Color.Silver;
			this.IdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.IdBox.Location = new System.Drawing.Point(22, 53);
			this.IdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.IdBox.Name = "IdBox";
			this.IdBox.PlaceholderText = "Application Id";
			this.IdBox.Size = new System.Drawing.Size(187, 27);
			this.IdBox.TabIndex = 0;
			this.IdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.IdBox.UseSystemPasswordChar = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.infobtn);
			this.panel1.Controls.Add(this.DropDown);
			this.panel1.Controls.Add(this.SlotEdit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.IdBox);
			this.panel1.Location = new System.Drawing.Point(14, 16);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(229, 133);
			this.panel1.TabIndex = 1;
			// 
			// infobtn
			// 
			this.infobtn.BackColor = System.Drawing.Color.Transparent;
			this.infobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.infobtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.infobtn.Location = new System.Drawing.Point(183, 89);
			this.infobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.infobtn.Name = "infobtn";
			this.infobtn.Size = new System.Drawing.Size(26, 28);
			this.infobtn.TabIndex = 6;
			this.infobtn.Text = "?";
			this.infobtn.UseVisualStyleBackColor = false;
			this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
			// 
			// DropDown
			// 
			this.DropDown.BackColor = System.Drawing.Color.Silver;
			this.DropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DropDown.FormattingEnabled = true;
			this.DropDown.Items.AddRange(new object[] {
            "ea",
            "sports",
            "hehe",
            "hoho"});
			this.DropDown.Location = new System.Drawing.Point(11, 13);
			this.DropDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DropDown.Name = "DropDown";
			this.DropDown.Size = new System.Drawing.Size(173, 28);
			this.DropDown.TabIndex = 5;
			this.DropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedItemChanged);
			// 
			// SlotEdit
			// 
			this.SlotEdit.BackColor = System.Drawing.Color.LimeGreen;
			this.SlotEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SlotEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SlotEdit.Location = new System.Drawing.Point(190, 13);
			this.SlotEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SlotEdit.Name = "SlotEdit";
			this.SlotEdit.Size = new System.Drawing.Size(26, 28);
			this.SlotEdit.TabIndex = 4;
			this.SlotEdit.Text = "O";
			this.SlotEdit.UseVisualStyleBackColor = false;
			this.SlotEdit.Click += new System.EventHandler(this.SlotEdit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(11, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Made By Ameer!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Controls.Add(this.TheTimer);
			this.panel2.Controls.Add(this.SmolTxt);
			this.panel2.Controls.Add(this.LargeTxt);
			this.panel2.Controls.Add(this.SmolImg);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.LargeImg);
			this.panel2.Controls.Add(this.StatusBox);
			this.panel2.Controls.Add(this.DetailBox);
			this.panel2.Location = new System.Drawing.Point(249, 16);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(286, 213);
			this.panel2.TabIndex = 2;
			// 
			// TheTimer
			// 
			this.TheTimer.BackColor = System.Drawing.Color.Silver;
			this.TheTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TheTimer.Location = new System.Drawing.Point(206, 94);
			this.TheTimer.Name = "TheTimer";
			this.TheTimer.PlaceholderText = "Timer";
			this.TheTimer.Size = new System.Drawing.Size(67, 27);
			this.TheTimer.TabIndex = 6;
			// 
			// SmolTxt
			// 
			this.SmolTxt.BackColor = System.Drawing.Color.Silver;
			this.SmolTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SmolTxt.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SmolTxt.Location = new System.Drawing.Point(109, 93);
			this.SmolTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SmolTxt.Multiline = true;
			this.SmolTxt.Name = "SmolTxt";
			this.SmolTxt.PlaceholderText = "Small Image Hint";
			this.SmolTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.SmolTxt.Size = new System.Drawing.Size(91, 30);
			this.SmolTxt.TabIndex = 5;
			this.SmolTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LargeTxt
			// 
			this.LargeTxt.BackColor = System.Drawing.Color.Silver;
			this.LargeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LargeTxt.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LargeTxt.Location = new System.Drawing.Point(14, 93);
			this.LargeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LargeTxt.Multiline = true;
			this.LargeTxt.Name = "LargeTxt";
			this.LargeTxt.PlaceholderText = "Large Image Hint";
			this.LargeTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.LargeTxt.Size = new System.Drawing.Size(91, 30);
			this.LargeTxt.TabIndex = 5;
			this.LargeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// SmolImg
			// 
			this.SmolImg.BackColor = System.Drawing.Color.Silver;
			this.SmolImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SmolImg.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SmolImg.Location = new System.Drawing.Point(14, 53);
			this.SmolImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SmolImg.Multiline = true;
			this.SmolImg.Name = "SmolImg";
			this.SmolImg.PlaceholderText = "Small Image";
			this.SmolImg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.SmolImg.Size = new System.Drawing.Size(114, 31);
			this.SmolImg.TabIndex = 3;
			this.SmolImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkGray;
			this.panel4.Controls.Add(this.BTN22);
			this.panel4.Controls.Add(this.BTN21);
			this.panel4.Location = new System.Drawing.Point(14, 173);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(261, 31);
			this.panel4.TabIndex = 4;
			// 
			// BTN22
			// 
			this.BTN22.BackColor = System.Drawing.Color.Turquoise;
			this.BTN22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BTN22.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BTN22.Location = new System.Drawing.Point(123, 0);
			this.BTN22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BTN22.Multiline = true;
			this.BTN22.Name = "BTN22";
			this.BTN22.PlaceholderText = "Button Link";
			this.BTN22.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.BTN22.Size = new System.Drawing.Size(137, 30);
			this.BTN22.TabIndex = 1;
			// 
			// BTN21
			// 
			this.BTN21.BackColor = System.Drawing.Color.Turquoise;
			this.BTN21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BTN21.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BTN21.Location = new System.Drawing.Point(0, 0);
			this.BTN21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BTN21.Multiline = true;
			this.BTN21.Name = "BTN21";
			this.BTN21.PlaceholderText = "Button Text";
			this.BTN21.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.BTN21.Size = new System.Drawing.Size(114, 30);
			this.BTN21.TabIndex = 0;
			this.BTN21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkGray;
			this.panel3.Controls.Add(this.BTN12);
			this.panel3.Controls.Add(this.BTN11);
			this.panel3.Location = new System.Drawing.Point(14, 133);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(261, 31);
			this.panel3.TabIndex = 4;
			// 
			// BTN12
			// 
			this.BTN12.BackColor = System.Drawing.Color.Turquoise;
			this.BTN12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BTN12.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BTN12.Location = new System.Drawing.Point(123, 0);
			this.BTN12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BTN12.Multiline = true;
			this.BTN12.Name = "BTN12";
			this.BTN12.PlaceholderText = "Button Link";
			this.BTN12.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.BTN12.Size = new System.Drawing.Size(137, 30);
			this.BTN12.TabIndex = 1;
			// 
			// BTN11
			// 
			this.BTN11.BackColor = System.Drawing.Color.Turquoise;
			this.BTN11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BTN11.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BTN11.Location = new System.Drawing.Point(0, 0);
			this.BTN11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BTN11.Multiline = true;
			this.BTN11.Name = "BTN11";
			this.BTN11.PlaceholderText = "Button Text";
			this.BTN11.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.BTN11.Size = new System.Drawing.Size(114, 30);
			this.BTN11.TabIndex = 0;
			this.BTN11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LargeImg
			// 
			this.LargeImg.BackColor = System.Drawing.Color.Silver;
			this.LargeImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LargeImg.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LargeImg.Location = new System.Drawing.Point(14, 16);
			this.LargeImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LargeImg.Multiline = true;
			this.LargeImg.Name = "LargeImg";
			this.LargeImg.PlaceholderText = "Large Image";
			this.LargeImg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.LargeImg.Size = new System.Drawing.Size(114, 31);
			this.LargeImg.TabIndex = 3;
			this.LargeImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// StatusBox
			// 
			this.StatusBox.BackColor = System.Drawing.Color.Silver;
			this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StatusBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StatusBox.Location = new System.Drawing.Point(137, 53);
			this.StatusBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.StatusBox.Multiline = true;
			this.StatusBox.Name = "StatusBox";
			this.StatusBox.PlaceholderText = "Status";
			this.StatusBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.StatusBox.Size = new System.Drawing.Size(137, 31);
			this.StatusBox.TabIndex = 2;
			// 
			// DetailBox
			// 
			this.DetailBox.BackColor = System.Drawing.Color.Silver;
			this.DetailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DetailBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DetailBox.Location = new System.Drawing.Point(137, 16);
			this.DetailBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DetailBox.Multiline = true;
			this.DetailBox.Name = "DetailBox";
			this.DetailBox.PlaceholderText = "Details";
			this.DetailBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.DetailBox.Size = new System.Drawing.Size(137, 32);
			this.DetailBox.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.GreenYellow;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button2.Location = new System.Drawing.Point(96, 157);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(147, 78);
			this.button2.TabIndex = 3;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Red;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button3.Location = new System.Drawing.Point(14, 199);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(76, 36);
			this.button3.TabIndex = 4;
			this.button3.Text = "Clear";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
			// 
			// importbtn
			// 
			this.importbtn.BackColor = System.Drawing.Color.LightGray;
			this.importbtn.FlatAppearance.BorderSize = 0;
			this.importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.importbtn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.importbtn.Location = new System.Drawing.Point(14, 157);
			this.importbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.importbtn.Name = "importbtn";
			this.importbtn.Size = new System.Drawing.Size(36, 36);
			this.importbtn.TabIndex = 5;
			this.importbtn.Text = "⬇";
			this.importbtn.UseVisualStyleBackColor = false;
			this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
			// 
			// exportbtn
			// 
			this.exportbtn.BackColor = System.Drawing.Color.LightGray;
			this.exportbtn.FlatAppearance.BorderSize = 0;
			this.exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.exportbtn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.exportbtn.Location = new System.Drawing.Point(54, 157);
			this.exportbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.exportbtn.Name = "exportbtn";
			this.exportbtn.Size = new System.Drawing.Size(36, 36);
			this.exportbtn.TabIndex = 6;
			this.exportbtn.Text = "⬆";
			this.exportbtn.UseVisualStyleBackColor = false;
			this.exportbtn.Click += new System.EventHandler(this.exportbtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(553, 248);
			this.Controls.Add(this.exportbtn);
			this.Controls.Add(this.importbtn);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Discord Is Rich";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Move += new System.EventHandler(this.Form1_Move);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox IdBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox StatusBox;
		private System.Windows.Forms.TextBox DetailBox;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox BTN22;
		private System.Windows.Forms.TextBox BTN21;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox BTN12;
		private System.Windows.Forms.TextBox BTN11;
		private System.Windows.Forms.TextBox LargeImg;
		private System.Windows.Forms.TextBox SmolTxt;
		private System.Windows.Forms.TextBox LargeTxt;
		private System.Windows.Forms.TextBox SmolImg;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button SlotEdit;
		private System.Windows.Forms.ComboBox DropDown;
		private System.Windows.Forms.TextBox TheTimer;
		private System.Windows.Forms.Button infobtn;
		private System.Windows.Forms.Button importbtn;
		private System.Windows.Forms.Button exportbtn;
	}
}

