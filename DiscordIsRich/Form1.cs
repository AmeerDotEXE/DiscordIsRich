using DiscordRPC;
using DiscordRPC.Logging;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace DiscordIsRich
{
	public partial class Form1 : Form
	{
		public DiscordRpcClient client = null;

		public List<Settings> settingslist = new List<Settings>();

		public string version = "1.1.2";

		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (DropDown.SelectedIndex != -1)
			{
				settingslist[DropDown.SelectedIndex] = editSetting(settingslist[DropDown.SelectedIndex]);

				SaveSettings();

				if (settingslist[DropDown.SelectedIndex].Id != null && settingslist[DropDown.SelectedIndex].Id != "")
				{
					authrich(settingslist[DropDown.SelectedIndex].Id);

					setRich(settingslist[DropDown.SelectedIndex]);
				}
				else
				{
					MessageBox.Show("Enter an Application Id", "No Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Select a Slot Before Updating!", "Slot Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			IdBox.Text = "";

			LargeImg.Text = "";
			LargeTxt.Text = "";
			SmolImg.Text = "";
			SmolTxt.Text = "";

			DetailBox.Text = "";
			StatusBox.Text = "";

			TheTimer.Text = "";

			BTN11.Text = "";
			BTN12.Text = "";
			BTN21.Text = "";
			BTN22.Text = "";
		}

		void authrich(string theId)
		{
			if (theId != null && theId != "")
			{
				if (client != null)
				{
					if (client.ApplicationID != theId)
					{
						client.Deinitialize();
						client.Dispose();

						client = new DiscordRpcClient(theId);
						client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
						client.Initialize();
					}
				}
				else
				{
					client = new DiscordRpcClient(theId);
					client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
					client.Initialize();
				}
			}
		}

		Settings editSetting(Settings settings)
		{

			settings.Id = IdBox.Text;

			settings.LIK = LargeImg.Text;
			settings.LIH = LargeTxt.Text;
			settings.SIK = SmolImg.Text;
			settings.SIH = SmolTxt.Text;

			settings.Detail = DetailBox.Text;
			settings.Status = StatusBox.Text;

			settings.Timer = TheTimer.Text;

			settings.B11 = BTN11.Text;
			settings.B12 = BTN12.Text;
			settings.B21 = BTN21.Text;
			settings.B22 = BTN22.Text;

			return settings;
		}

		public void SaveSettings()
		{
			File.WriteAllText("Settings.Ameer", new JavaScriptSerializer().Serialize(settingslist));
		}

		public void LoadSettings()
		{
			if (File.Exists("Settings.Ameer"))
			{
				settingslist = new JavaScriptSerializer().Deserialize<List<Settings>>(File.ReadAllText("Settings.Ameer"));
			}
		}

		void setFields(Settings LoadedSettings)
		{
			IdBox.Text = LoadedSettings.Id;

			LargeImg.Text = LoadedSettings.LIK;
			LargeTxt.Text = LoadedSettings.LIH;
			SmolImg.Text = LoadedSettings.SIK;
			SmolTxt.Text = LoadedSettings.SIH;

			DetailBox.Text = LoadedSettings.Detail;
			StatusBox.Text = LoadedSettings.Status;

			TheTimer.Text = LoadedSettings.Timer;

			BTN11.Text = LoadedSettings.B11;
			BTN12.Text = LoadedSettings.B12;
			BTN21.Text = LoadedSettings.B21;
			BTN22.Text = LoadedSettings.B22;
		}

		void setRich(Settings settings)
		{
			var RichBoy = new DiscordRPC.RichPresence();

			DiscordRPC.Assets Assets = new Assets();

			if (settings.LIK != "")
			{
				Assets.LargeImageKey = settings.LIK;

				if (settings.LIH != "")
				{
					Assets.LargeImageText = settings.LIH;
				}
			}

			if (settings.SIK != "")
			{
				Assets.SmallImageKey = settings.SIK;

				if (settings.SIH != "")
				{
					Assets.SmallImageText = settings.SIH;
				}
			}

			if (Assets != null)
			{
				RichBoy.Assets = Assets;
			}

			if (settings.Detail != "")
			{
				RichBoy.Details = settings.Detail;
			}

			if (settings.Status != "")
			{
				RichBoy.State = settings.Status;
			}

			if (settings.Timer != "")
			{
				bool success = int.TryParse(settings.Timer, out int tmr);

				if (success)
				{
					Timestamps deTime = new Timestamps();
					if (ulong.MaxValue >= (ulong)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - (tmr * 1000)))
					{
						if (settings.Timer.StartsWith('-'))
						{
							deTime.EndUnixMilliseconds = (ulong)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - (tmr * 1000));
						}
						else if (settings.Timer.StartsWith('+'))
						{
							deTime.StartUnixMilliseconds = (ulong)(DateTimeOffset.Now.ToUnixTimeMilliseconds() + (tmr * 1000));
						}
						else
						{
							deTime.StartUnixMilliseconds = (ulong)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - (tmr * 1000));
						}
					}
					RichBoy.Timestamps = deTime;
				}
				else
				{
					RichBoy.Timestamps = new Timestamps();
				}
			}

			DiscordRPC.Button[] Buttons = null;

			if (settings.B11 != "" && settings.B12 != "")
			{
				DiscordRPC.Button BTN = new DiscordRPC.Button
				{
					Label = settings.B11,
					Url = settings.B12
				};

				Buttons = new DiscordRPC.Button[] { BTN };
			}

			if (settings.B21 != "" && settings.B22 != "")
			{
				DiscordRPC.Button BTN = new DiscordRPC.Button
				{
					Label = settings.B21,
					Url = settings.B22
				};

				List<DiscordRPC.Button> Buton = Buttons.ToList();

				Buton.Add(BTN);

				Buttons = Buton.ToArray();
			}

			if (Buttons != null)
			{
				RichBoy.Buttons = Buttons;
			}

			client.SetPresence(RichBoy);
		}

		void updatedroplist()
		{
			DropDown.Items.Clear();
			for (int i = 0; i < settingslist.Count; i++)
			{
				DropDown.Items.Add(settingslist[i].SlotName);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdaterNow();

			LoadSettings();

			if (settingslist.Count > 0) setFields(settingslist[0]);
			else
			{
				var setng = new Settings
				{
					SlotName = "First Slot"
				};

				settingslist.Add(setng);

				SaveSettings();
			}

			updatedroplist();
			DropDown.SelectedIndex = 0;

			setFields(settingslist[0]);

			notifyIcon1.Text = "Click to Show";
			notifyIcon1.Visible = false;
		}

		private void Form1_Move(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				notifyIcon1.Visible = true;
			}
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon1.Visible = false;
		}
		
		private void DropDown_SelectedItemChanged(object sender, EventArgs e)
		{
			if (DropDown.SelectedIndex != -1)
			{
				var stang = settingslist[DropDown.SelectedIndex];

				setFields(stang);
			}
		}

		private void SlotEdit_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			frm.SetItUp(this, DropDown.SelectedIndex);
			frm.ShowDialog();
		}

		public void SlotEditor_Return(int SelectedIndex = 0)
		{
			updatedroplist();

			if (SelectedIndex != -1) DropDown.SelectedIndex = SelectedIndex;
			else DropDown.SelectedIndex = 0;

			SaveSettings();
		}

		private void infobtn_Click(object sender, EventArgs e)
		{
			help_Form frm = new help_Form();
			frm.ShowDialog();
		}

		private void UpdaterNow()
		{
			WebClient webClient = new WebClient();

			if (File.Exists("Ameer.version"))
			{
				version = File.ReadAllText("Ameer.version");
			}

			try
			{
				if (!webClient.DownloadString("https://raw.githubusercontent.com/AmeerDotEXE/DiscordIsRich/main/Ameer.version").Contains(version))
				{
					if (MessageBox.Show("Looks like there is an update! Do you want to download it?", "Discord Is Rich", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Process.Start("DIR Updater.exe");
						this.Close();
					}
				}
			} catch { }
		}

		private void importbtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();

			open.Title = "Import Data";
			open.Filter = "Data Files|Settings.Ameer|All Files|*.*";

			if (open.ShowDialog() == DialogResult.OK)
			{
				try
				{
					settingslist = new JavaScriptSerializer().Deserialize<List<Settings>>(File.ReadAllText(open.FileName));

					if (settingslist.Count > 0) setFields(settingslist[0]);
					else
					{
						var setng = new Settings
						{
							SlotName = "First Slot"
						};

						settingslist.Add(setng);

						SaveSettings();
					}

					updatedroplist();
					DropDown.SelectedIndex = 0;

					setFields(settingslist[0]);

					notifyIcon1.Text = "Click to Show";
					notifyIcon1.Visible = false;

					SaveSettings();
				}
				catch { }
			}
		}

		private void exportbtn_Click(object sender, EventArgs e)
		{
			SaveFileDialog open = new SaveFileDialog();

			open.Title = "Export Data";
			open.Filter = "Data Files|Settings.Ameer|All Files|*.*";

			if (open.ShowDialog() == DialogResult.OK)
			{
				try
				{
					File.WriteAllText(open.FileName, new JavaScriptSerializer().Serialize(settingslist));
				}
				catch { }
			}
		}
	}
}
