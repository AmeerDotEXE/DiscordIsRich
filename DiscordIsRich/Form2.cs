using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscordIsRich
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		Form1 MainForm = null;

		public void SetItUp(Form1 _MainForm, int SelectedIndex = 0)
		{
			MainForm = _MainForm;

			updatelist(MainForm.settingslist);

			if (SelectedIndex != -1) EdtList.SelectedIndex = SelectedIndex;
			else EdtList.SelectedIndex = 0;
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			MainForm.SlotEditor_Return(EdtList.SelectedIndex);
		}

		void updatelist(List<Settings> settingslist)
		{
			EdtList.Items.Clear();
			for (int i = 0; i < settingslist.Count; i++)
			{
				EdtList.Items.Add(settingslist[i].SlotName);
			}
		}

		private void addBTN_Click(object sender, EventArgs e)
		{
			if (SlotNameBox.Text != "")
			{
				if (MainForm.settingslist.Find(x => x.SlotName == SlotNameBox.Text) == null)
				{
					Settings Stng = new Settings();

					Stng.SlotName = SlotNameBox.Text;

					MainForm.settingslist.Add(Stng);

					updatelist(MainForm.settingslist);
					EdtList.SelectedIndex = EdtList.Items.IndexOf(Stng.SlotName);
				}
				else
				{
					MessageBox.Show("Please Enter a Slot Name Not Used!", "Used Slot Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Please Enter a Vaild Slot Name!", "No Slot Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DupBTN_Click(object sender, EventArgs e)
		{
			if (EdtList.SelectedIndex != -1)
			{
				Settings SelectedStng = MainForm.settingslist[EdtList.SelectedIndex];
				Settings Stng = new Settings
				{ 
					Id = SelectedStng.Id,
					SlotName = SelectedStng.SlotName,
					Detail = SelectedStng.Detail,
					Status = SelectedStng.Status,

					B11 = SelectedStng.B11,
					B12 = SelectedStng.B12,
					B21 = SelectedStng.B21,
					B22 = SelectedStng.B22,

					LIH = SelectedStng.LIH,
					LIK = SelectedStng.LIK,
					SIH = SelectedStng.SIH,
					SIK = SelectedStng.SIK,

					Timer = SelectedStng.Timer
				};

				if (MainForm.settingslist.Find(x => x.SlotName == Stng.SlotName + "_Copy") == null)
				{
					Stng.SlotName += "_Copy";
				}
				else 
				{
					int NameNum = 0;
					while (MainForm.settingslist.Find(x => x.SlotName == Stng.SlotName + NameNum) != null)
					{
						NameNum++;
					}
					if (MainForm.settingslist.Find(x => x.SlotName == Stng.SlotName + NameNum) == null)
					{
						Stng.SlotName += NameNum;
					}
				}

				MainForm.settingslist.Add(Stng);

				updatelist(MainForm.settingslist);
				EdtList.SelectedIndex = EdtList.Items.IndexOf(Stng.SlotName);
			}
			else
			{
				MessageBox.Show("Please Select a Slot to Duplicate!", "No Slot Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void RenBTN_Click(object sender, EventArgs e)
		{
			if (EdtList.SelectedIndex != -1)
			{
				if (SlotNameBox.Text != "")
				{
					if (MainForm.settingslist.Find(x => x.SlotName == SlotNameBox.Text) == null)
					{
						Settings Stng = MainForm.settingslist[EdtList.SelectedIndex];

						Stng.SlotName = SlotNameBox.Text;

						updatelist(MainForm.settingslist);
						EdtList.SelectedIndex = EdtList.Items.IndexOf(Stng.SlotName);
					}
					else
					{
						MessageBox.Show("Please Enter a Slot Name Not Used!", "Used Slot Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else
				{
					MessageBox.Show("Please Enter a Vaild Slot Name!", "No Slot Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please Select a Slot to Rename!", "No Slot Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void DelBTN_Click(object sender, EventArgs e)
		{
			if (EdtList.Items.Count > 1)
			{
				if (EdtList.SelectedIndex != -1)
				{
					Settings Stng = MainForm.settingslist[EdtList.SelectedIndex];

					MainForm.settingslist.RemoveAll(x => x == Stng);

					int Slct = EdtList.SelectedIndex;
					updatelist(MainForm.settingslist);
					if (Slct > -1 && Slct < EdtList.Items.Count) EdtList.SelectedIndex = Slct;
					else EdtList.SelectedIndex = EdtList.Items.Count - 1;
				}
				else
				{
					MessageBox.Show("Please Select a Slot to Delete!", "No Slot Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("You Can Have at least 1 Slot", "Slot Minimum", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void MupBTN_Click(object sender, EventArgs e)
		{
			if (EdtList.SelectedIndex != -1)
			{
				if (EdtList.SelectedIndex != 0)
				{
					Settings Stng = MainForm.settingslist[EdtList.SelectedIndex];

					int SelectedInd = EdtList.SelectedIndex;

					MainForm.settingslist.RemoveAt(SelectedInd);
					MainForm.settingslist.Insert(SelectedInd - 1, Stng);

					updatelist(MainForm.settingslist);
					EdtList.SelectedIndex = EdtList.Items.IndexOf(Stng.SlotName);
				}
				else
				{
					MessageBox.Show("This Slot is Already at the Top", "Already At Top", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Please Select a Slot to Move Up!", "No Slot Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void MdnBTN_Click(object sender, EventArgs e)
		{
			if (EdtList.SelectedIndex != -1)
			{
				if (EdtList.SelectedIndex != EdtList.Items.Count - 1)
				{
					Settings Stng = MainForm.settingslist[EdtList.SelectedIndex];

					int SelectedInd = EdtList.SelectedIndex;

					MainForm.settingslist.RemoveAt(SelectedInd);
					MainForm.settingslist.Insert(SelectedInd + 1, Stng);

					updatelist(MainForm.settingslist);
					EdtList.SelectedIndex = EdtList.Items.IndexOf(Stng.SlotName);
				}
				else
				{
					MessageBox.Show("This Slot is Already at the Bottom", "Already At Bottom", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Please Select a Slot to Move Down!", "No Slot Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void EdtList_DoubleClick(object sender, EventArgs e)
		{
			if (EdtList.SelectedIndex != -1)
			{
				MainForm.SlotEditor_Return(EdtList.SelectedIndex);
				this.Close();
			}
		}
	}
}
