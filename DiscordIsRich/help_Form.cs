using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using Nancy.Json;

namespace DiscordIsRich
{
	public partial class help_Form : Form
	{
		public DiscordRpcClient client = null;

		public List<Settings> settingslist = new List<Settings>();

		public help_Form()
		{
			InitializeComponent();
		}
	}
}
