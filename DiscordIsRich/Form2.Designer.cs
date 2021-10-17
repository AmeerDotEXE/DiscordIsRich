namespace DiscordIsRich
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.EdtList = new System.Windows.Forms.ListBox();
			this.addBTN = new System.Windows.Forms.Button();
			this.DupBTN = new System.Windows.Forms.Button();
			this.RenBTN = new System.Windows.Forms.Button();
			this.DelBTN = new System.Windows.Forms.Button();
			this.MupBTN = new System.Windows.Forms.Button();
			this.MdnBTN = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SlotNameBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// EdtList
			// 
			this.EdtList.BackColor = System.Drawing.Color.LightGray;
			this.EdtList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EdtList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EdtList.FormattingEnabled = true;
			this.EdtList.IntegralHeight = false;
			this.EdtList.ItemHeight = 21;
			this.EdtList.Location = new System.Drawing.Point(12, 12);
			this.EdtList.Name = "EdtList";
			this.EdtList.ScrollAlwaysVisible = true;
			this.EdtList.Size = new System.Drawing.Size(200, 226);
			this.EdtList.TabIndex = 1;
			this.EdtList.DoubleClick += new System.EventHandler(this.EdtList_DoubleClick);
			// 
			// addBTN
			// 
			this.addBTN.BackColor = System.Drawing.Color.LightGray;
			this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.addBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addBTN.Location = new System.Drawing.Point(218, 41);
			this.addBTN.Name = "addBTN";
			this.addBTN.Size = new System.Drawing.Size(100, 25);
			this.addBTN.TabIndex = 2;
			this.addBTN.Text = "Add";
			this.addBTN.UseVisualStyleBackColor = false;
			this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
			// 
			// DupBTN
			// 
			this.DupBTN.BackColor = System.Drawing.Color.LightGray;
			this.DupBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DupBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DupBTN.Location = new System.Drawing.Point(218, 72);
			this.DupBTN.Name = "DupBTN";
			this.DupBTN.Size = new System.Drawing.Size(100, 25);
			this.DupBTN.TabIndex = 2;
			this.DupBTN.Text = "Duplicate";
			this.DupBTN.UseVisualStyleBackColor = false;
			this.DupBTN.Click += new System.EventHandler(this.DupBTN_Click);
			// 
			// RenBTN
			// 
			this.RenBTN.BackColor = System.Drawing.Color.LightGray;
			this.RenBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RenBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.RenBTN.Location = new System.Drawing.Point(218, 103);
			this.RenBTN.Name = "RenBTN";
			this.RenBTN.Size = new System.Drawing.Size(100, 25);
			this.RenBTN.TabIndex = 2;
			this.RenBTN.Text = "Rename";
			this.RenBTN.UseVisualStyleBackColor = false;
			this.RenBTN.Click += new System.EventHandler(this.RenBTN_Click);
			// 
			// DelBTN
			// 
			this.DelBTN.BackColor = System.Drawing.Color.LightGray;
			this.DelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DelBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DelBTN.Location = new System.Drawing.Point(218, 134);
			this.DelBTN.Name = "DelBTN";
			this.DelBTN.Size = new System.Drawing.Size(100, 25);
			this.DelBTN.TabIndex = 2;
			this.DelBTN.Text = "Delete";
			this.DelBTN.UseVisualStyleBackColor = false;
			this.DelBTN.Click += new System.EventHandler(this.DelBTN_Click);
			// 
			// MupBTN
			// 
			this.MupBTN.BackColor = System.Drawing.Color.LightGray;
			this.MupBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MupBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.MupBTN.Location = new System.Drawing.Point(218, 182);
			this.MupBTN.Name = "MupBTN";
			this.MupBTN.Size = new System.Drawing.Size(100, 25);
			this.MupBTN.TabIndex = 2;
			this.MupBTN.Text = "Move Up";
			this.MupBTN.UseVisualStyleBackColor = false;
			this.MupBTN.Click += new System.EventHandler(this.MupBTN_Click);
			// 
			// MdnBTN
			// 
			this.MdnBTN.BackColor = System.Drawing.Color.LightGray;
			this.MdnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MdnBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.MdnBTN.Location = new System.Drawing.Point(218, 213);
			this.MdnBTN.Name = "MdnBTN";
			this.MdnBTN.Size = new System.Drawing.Size(100, 25);
			this.MdnBTN.TabIndex = 2;
			this.MdnBTN.Text = "Move Down";
			this.MdnBTN.UseVisualStyleBackColor = false;
			this.MdnBTN.Click += new System.EventHandler(this.MdnBTN_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(220, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Made By Ameer";
			// 
			// SlotNameBox
			// 
			this.SlotNameBox.BackColor = System.Drawing.Color.Gainsboro;
			this.SlotNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SlotNameBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SlotNameBox.Location = new System.Drawing.Point(218, 12);
			this.SlotNameBox.MaxLength = 100;
			this.SlotNameBox.Name = "SlotNameBox";
			this.SlotNameBox.PlaceholderText = "Slot Name";
			this.SlotNameBox.Size = new System.Drawing.Size(100, 25);
			this.SlotNameBox.TabIndex = 4;
			this.SlotNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(329, 251);
			this.Controls.Add(this.SlotNameBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MdnBTN);
			this.Controls.Add(this.MupBTN);
			this.Controls.Add(this.DelBTN);
			this.Controls.Add(this.RenBTN);
			this.Controls.Add(this.DupBTN);
			this.Controls.Add(this.addBTN);
			this.Controls.Add(this.EdtList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Slot Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox EdtList;
		private System.Windows.Forms.Button addBTN;
		private System.Windows.Forms.Button RenBTN;
		private System.Windows.Forms.Button DelBTN;
		private System.Windows.Forms.Button MupBTN;
		private System.Windows.Forms.Button MdnBTN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SlotNameBox;
		private System.Windows.Forms.Button DupBTN;
	}
}