using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace DIR_Updater
{
	public partial class Form1 : Form
	{
		public string version = "";
		public Form1()
		{
			InitializeComponent();
		}

		private void cacl_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void OnLoaded(object sender, EventArgs e)
		{
			Application.Idle -= new EventHandler(OnLoaded);

			WebClient webClient = new WebClient();
			var client = new WebClient();

			if (File.Exists("Ameer.version"))
			{
				version = File.ReadAllText("Ameer.version");
			}

			try
			{
				if (version != "")
				{
					if (webClient.DownloadString("https://raw.githubusercontent.com/AmeerDotEXE/DiscordIsRich/main/Ameer.version").Contains(version))
					{
						MessageBox.Show("You are up-to-date have fun!", "DIR Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Process.Start("DiscordIsRich.exe");
						this.Close();
					}
					else { updat(client); }
				}
				else { updat(client); }
			}
			catch
			{
				if (File.Exists(@".\DiscordIsRich.exe"))
					Process.Start("DiscordIsRich.exe");

				this.Close();
			}
		}

		private void updat(WebClient client)
		{
			try
			{
				dwnld.Value = 5;
				updttxt.Text = "Deleting Old Files";

				var files = Directory.GetFiles("./");

				foreach (var file in files)
				{
					if (dwnld.Value < 20) dwnld.Value += 1;

					if (!file.EndsWith(".Ameer") && !file.Contains("DIR Updater"))
					{
						try
						{
							File.Delete(file);
						}
						catch { }
					}
				}

				updttxt.Text = "Deleting Old Folders";

				var dirfiles = Directory.GetDirectories("./");

				foreach (var file in dirfiles)
				{
					if (dwnld.Value < 35) dwnld.Value += 1;

					if (!file.Contains("DIR Updater"))
					{
						try
						{
							Directory.Delete(file, true);
						}
						catch { }
					}
				}

				cacl.Enabled = false;
				dwnld.Value = 40;
				updttxt.Text = "Downloading The New Version";

				client.DownloadFile("https://github.com/AmeerDotEXE/DiscordIsRich/archive/refs/heads/main.zip", @".\update.zip");

				cacl.Enabled = true;
				dwnld.Value = 60;
				updttxt.Text = "Extracting The New Version";

				string zipPath = @".\update.zip";
				string extractPath = @".\";
				ZipFile.ExtractToDirectory(zipPath, extractPath);

				dwnld.Value = 70;
				updttxt.Text = "Moving Files";

				var movefiles = Directory.GetFiles(@".\DiscordIsRich-main\");

				foreach (var file in movefiles)
				{
					if (dwnld.Value < 80) dwnld.Value += 1;

					if (!file.Contains("DIR Updater"))
					{
						try
						{
							var filename = Path.GetFileName(file);
							File.Move(file, $"{Directory.GetCurrentDirectory()}\\{filename}", true);
						}
						catch { }
					}
				}

				updttxt.Text = "Moving Folders";

				var movedirfiles = Directory.GetFiles(@".\DiscordIsRich-main\");

				foreach (var file in movedirfiles)
				{
					if (dwnld.Value < 90) dwnld.Value += 1;

					if (!file.Contains("DIR Updater"))
					{
						try
						{
							var filename = Path.GetDirectoryName(file);
							Directory.Move(file, $"{Directory.GetCurrentDirectory()}\\{filename}");
						}
						catch { }
					}
				}

				dwnld.Value = 95;
				updttxt.Text = "Deleting Extra Files and Folders";

				File.Delete(@".\update.zip");
				Directory.Delete(@".\DiscordIsRich-main", true);
				Process.Start(@".\DiscordIsRich.exe");

				dwnld.Value = 100;
				updttxt.Text = "Update is Done!";

				this.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show("An Error Occur:\n" + err.ToString(), "DIR Updater", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Application.Idle += new EventHandler(OnLoaded);
		}
	}
}
