using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Spectrum_Launcher___The_Return.Classes;

namespace Spectrum_Launcher___The_Return
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00110538 File Offset: 0x00110538
		public Form1()
		{
			object[] 408F = new object[]
			{
				this
			};
			new 66026065().433F05E0(408F, 1065340);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000022FC File Offset: 0x000022FC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.timer1.Interval = 1000;
			this.timer1.Start();
			this.NotNetworkFunction.SpectrumFolderExists();
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("             Spectrum Launcher Launched              ", true);
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log_Info("Starting debug checks...", false);
			this.backgroundWorker1.RunWorkerAsync();
			this.Log.Log_Info("Performing core directory check...", false);
			this.NotNetworkFunction.InitialCoreDirectoryCheck(ref this.Avi, ref this.Donny);
			this.Log.Log_Info("Core directory check complete.", false);
			this.Log.Log_Info("Performing ASI checks...", false);
			this.Asi_download_Check(true);
			this.Log.Log_Info("ASI check completed.", false);
			this.Log.Log_Info("Checking for updates...", false);
			this.UpdateCheck();
			this.Log.Log_Info("Update checks completed.", false);
			this.Log.Log_Info("Performing Spectrum detection check...", false);
			this.DetectionCheck();
			this.Log.Log_Info("Spectrum detection check complete.", false);
			this.Log.Log_Info("Performing antivirus check...", false);
			this.NotNetworkFunction.AntiVirus_Check("AVG Antivirus");
			this.NotNetworkFunction.AntiVirus_Check("avast Antivirus");
			this.Log.Log_Info("AntiVirus check complete.", false);
			this.Log.Log_Info("Populating announcenemts...", false);
			this.richTextBox1.Text = Form1.PostRequest("https://spectrum.menu/Auth/API", "fetch_announcement");
			this.Log.Log_Info("Announcements populated.", false);
			this.Log.Log_Info("Populating changelogs...", false);
			this.richTextBox2.Text = Form1.PostRequest("https://spectrum.menu/Auth/API", "fetch_changelog");
			this.Log.Log_Info("Changelogs populated.", false);
			this.Log.Log_Info("Populating global users count...", false);
			this.label3.Text = Form1.PostRequest("https://spectrum.menu/Auth/API", "fetch_totalusers");
			this.Log.Log_Info("Global users count populated.", false);
			this.Log.Log_Info("Populating ASI titles...", false);
			this.label1_ASI1.Text = this.NetFunctions.ReadEcho(this.baseurl + this.ASI1_TITLE);
			this.label2_ASI2.Text = this.NetFunctions.ReadEcho(this.baseurl + this.ASI2_TITLE);
			this.label3_ASI3.Text = this.NetFunctions.ReadEcho(this.baseurl + this.ASI3_TITLE);
			this.label4_ASI4.Text = this.NetFunctions.ReadEcho(this.baseurl + this.ASI4_TITLE);
			this.label8_ASI5.Text = this.NetFunctions.ReadEcho(this.baseurl + this.ASI5_TITLE);
			this.label7_ASI6.Text = this.NetFunctions.ReadEcho(this.baseurl + this.ASI6_TITLE);
			this.label6_ASI7.Text = this.NetFunctions.ReadEcho(this.baseurl + this.ASI7_TITLE);
			this.label5_ASI8.Text = this.NetFunctions.ReadEcho(this.baseurl + this.ASI8_TITLE);
			this.Log.Log_Info("ASI titles populated.", false);
			this.Log.Log_Info("Populating Rockstar server status...", false);
			this.label1_RockstarServerStatus.Text = this.NetFunctions.ReadEcho(this.baseurl + this.rockstarserver);
			this.Log.Log_Info("Rockstar server status populated.", false);
			this.Log.Log_Info("Populating Spectrum server status...", false);
			this.label2_SpectrumServerStatus.Text = Form1.PostRequest("https://spectrum.menu/Auth/API", "fetch_authstatus");
			this.Log.Log_Info("Spectrum server status populated.", false);
			this.Log.Log_Info("Populating GTA V game version...", false);
			this.label1_gameVersion.Text = this.NetFunctions.ReadEcho(this.baseurl + this.gameVersion);
			this.Log.Log_Info("GTA V game version populated.", false);
			this.Log.Log_Info("Populating Spectrum launcher version...", false);
			this.label1_LauncherVersion.Text = this.NetFunctions.ReadEcho(this.baseurl + this.launcherVersion);
			this.Log.Log_Info("Spectrum launcher version populated.", false);
			this.Log.Log_Info("Creating/checking relevant registry keys...", false);
			this.NotNetworkFunction.Registry_Folder_Check("Spectrum GTA V");
			this.NotNetworkFunction.Registry_Key_Check("Spectrum GTA V");
			this.Log.Log_Info("Registry keys created/checked.", false);
			this.Log.Log_Info("Populating personal uses...", false);
			this.label2.Text = this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "PersonalUses");
			this.Log.Log_Info("Personal uses populated.", false);
			this.Log.Log_Info("Setting Discord RPC...", false);
			this.NetFunctions.InitializeRPC();
			this.Log.Log_Info("Discord RPC set.", false);
			if (this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "RememberMe") == "yes")
			{
				this.textBox1.Text = this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "username");
				this.textBox2.Text = this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "password");
				this.checkBox1_RememberMe.Checked = true;
			}
			else
			{
				this.textBox1.Text = "";
				this.textBox2.Text = "";
			}
			if (this.label1_RockstarServerStatus.Text == "Online")
			{
				this.label1_RockstarServerStatus.ForeColor = Color.LimeGreen;
			}
			else
			{
				this.label1_RockstarServerStatus.ForeColor = Color.Red;
			}
			if (this.label2_SpectrumServerStatus.Text == "Online")
			{
				this.label2_SpectrumServerStatus.ForeColor = Color.LimeGreen;
				return;
			}
			this.label2_SpectrumServerStatus.ForeColor = Color.Red;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002948 File Offset: 0x00002948
		private void Form1_Shown(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000294C File Offset: 0x0000294C
		public static string AuthPostRequest(string url, string postFields1, string postFields2)
		{
			string result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				string s = postFields1 + "&" + postFields2;
				byte[] bytes = Encoding.ASCII.GetBytes(s);
				httpWebRequest.ContentLength = (long)bytes.Length;
				using (Stream requestStream = httpWebRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
				result = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()).ReadToEnd();
			}
			catch (WebException ex)
			{
				Console.WriteLine("Error on POST: " + ex.Message);
				result = "FATAL";
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002A1C File Offset: 0x00002A1C
		public static string PostRequest(string url, string postFields)
		{
			string result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				byte[] bytes = Encoding.ASCII.GetBytes(postFields);
				httpWebRequest.ContentLength = (long)bytes.Length;
				using (Stream requestStream = httpWebRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
				result = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()).ReadToEnd();
			}
			catch (WebException ex)
			{
				Console.WriteLine("Error on POST: " + ex.Message);
				result = "FATAL";
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002ADC File Offset: 0x00002ADC
		public void DetectionCheck()
		{
			if (this.NetFunctions.ReadEcho(this.baseurl + this.detected) == "Yes")
			{
				this.tabControl1.SelectedTab = this.Detected;
				this.Log.Log_Info("Spectrum is Detected", false);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002B34 File Offset: 0x00002B34
		public void UpdateCheck()
		{
			try
			{
				Version version = new Version(this.NetFunctions.ReadEcho(this.baseurl + this.launcherVersion));
				if (this.version < version)
				{
					this.tabControl1.SelectedTab = this.Update;
					this.Log.Log_Info("Update available.", false);
					Logger log = this.Log;
					string str = "This launcher version is: ";
					Version version2 = this.version;
					log.Log_Info(str + ((version2 != null) ? version2.ToString() : null), false);
					Logger log2 = this.Log;
					string str2 = "Updated launcher version is: ";
					Version version3 = version;
					log2.Log_Info(str2 + ((version3 != null) ? version3.ToString() : null), false);
				}
			}
			catch
			{
				this.Log.Log_Error("Connection Issue!", true);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002C04 File Offset: 0x00002C04
		private void button1_login_Click(object sender, EventArgs e)
		{
			if (this.checkBox1_RememberMe.Checked)
			{
				this.NotNetworkFunction.Create_Registry_Key("Spectrum GTA V", "RememberMe", "yes");
				this.NotNetworkFunction.Create_Registry_Key("Spectrum GTA V", "username", this.textBox1.Text);
				this.NotNetworkFunction.Create_Registry_Key("Spectrum GTA V", "password", this.textBox2.Text);
			}
			else
			{
				this.NotNetworkFunction.Create_Registry_Key("Spectrum GTA V", "RememberMe", "no");
				this.NotNetworkFunction.Create_Registry_Key("Spectrum GTA V", "username", this.textBox1.Text);
				this.NotNetworkFunction.Create_Registry_Key("Spectrum GTA V", "password", this.textBox2.Text);
			}
			this.Auth(this.textBox1.Text, this.textBox2.Text);
			GC.Collect();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002CF8 File Offset: 0x00002CF8
		public Task<string> ReadEchoAsync(string url)
		{
			Form1.<ReadEchoAsync>d__51 <ReadEchoAsync>d__;
			<ReadEchoAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadEchoAsync>d__.url = url;
			<ReadEchoAsync>d__.<>1__state = -1;
			<ReadEchoAsync>d__.<>t__builder.Start<Form1.<ReadEchoAsync>d__51>(ref <ReadEchoAsync>d__);
			return <ReadEchoAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002D3C File Offset: 0x00002D3C
		public void Auth(string username, string password)
		{
			Form1.<Auth>d__53 <Auth>d__;
			<Auth>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Auth>d__.<>4__this = this;
			<Auth>d__.username = username;
			<Auth>d__.password = password;
			<Auth>d__.<>1__state = -1;
			<Auth>d__.<>t__builder.Start<Form1.<Auth>d__53>(ref <Auth>d__);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002D84 File Offset: 0x00002D84
		public void HWID_Reset(string username, string password)
		{
			Form1.<HWID_Reset>d__54 <HWID_Reset>d__;
			<HWID_Reset>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<HWID_Reset>d__.<>4__this = this;
			<HWID_Reset>d__.username = username;
			<HWID_Reset>d__.password = password;
			<HWID_Reset>d__.<>1__state = -1;
			<HWID_Reset>d__.<>t__builder.Start<Form1.<HWID_Reset>d__54>(ref <HWID_Reset>d__);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002DCC File Offset: 0x00002DCC
		private Task WriteAuthInfoToFileAsync(string username, string password)
		{
			Form1.<WriteAuthInfoToFileAsync>d__55 <WriteAuthInfoToFileAsync>d__;
			<WriteAuthInfoToFileAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAuthInfoToFileAsync>d__.<>4__this = this;
			<WriteAuthInfoToFileAsync>d__.username = username;
			<WriteAuthInfoToFileAsync>d__.password = password;
			<WriteAuthInfoToFileAsync>d__.<>1__state = -1;
			<WriteAuthInfoToFileAsync>d__.<>t__builder.Start<Form1.<WriteAuthInfoToFileAsync>d__55>(ref <WriteAuthInfoToFileAsync>d__);
			return <WriteAuthInfoToFileAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002E1F File Offset: 0x00002E1F
		private void button2_GTA_With_EPIC_Click(object sender, EventArgs e)
		{
			Process.Start("com.epicgames.launcher://apps/9d2d0eb64d5c44529cece33fe2a46482?action=launch&silent=true");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002E2C File Offset: 0x00002E2C
		private void button2_GTA_WITH_STEAM_Click(object sender, EventArgs e)
		{
			Process.Start("steam://rungameid/271590");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002E39 File Offset: 0x00002E39
		private void button2_GTA_KILL_Click(object sender, EventArgs e)
		{
			this.NotNetworkFunction.EndTask(this.gtaProcessName);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002E4C File Offset: 0x00002E4C
		private void button2_exitapp_Click(object sender, EventArgs e)
		{
			this.NetFunctions.DeinitialisePRC();
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("             Spectrum Launcher Terminated            ", true);
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("", true);
			Application.Exit();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002EAD File Offset: 0x00002EAD
		private void button2_minimiseApplication_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002EB6 File Offset: 0x00002EB6
		private void button2_Logout_Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = this.Login;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002EC9 File Offset: 0x00002EC9
		private void button2_DicordLink_Click(object sender, EventArgs e)
		{
			this.NetFunctions.runURL(this.NetFunctions.ReadEcho(this.baseurl + this.discordurl));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002EF2 File Offset: 0x00002EF2
		private void button2_webURL_Click(object sender, EventArgs e)
		{
			this.NetFunctions.runURL(this.NetFunctions.ReadEcho(this.baseurl + this.weburl));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002F1C File Offset: 0x00002F1C
		private void button4_UPDATE_EXIT_Click(object sender, EventArgs e)
		{
			this.NetFunctions.DeinitialisePRC();
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("             Spectrum Launcher Terminated            ", true);
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("", true);
			Application.Exit();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002EAD File Offset: 0x00002EAD
		private void button5_UPDATE_MIN_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002EC9 File Offset: 0x00002EC9
		private void button6_UPDATE_DISC_Click(object sender, EventArgs e)
		{
			this.NetFunctions.runURL(this.NetFunctions.ReadEcho(this.baseurl + this.discordurl));
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002EF2 File Offset: 0x00002EF2
		private void button7_UPDATE_WEB_Click(object sender, EventArgs e)
		{
			this.NetFunctions.runURL(this.NetFunctions.ReadEcho(this.baseurl + this.weburl));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002F80 File Offset: 0x00002F80
		private void button4_DETECTED_EXIT_Click(object sender, EventArgs e)
		{
			this.NetFunctions.DeinitialisePRC();
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("             Spectrum Launcher Terminated            ", true);
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("", true);
			Application.Exit();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002EAD File Offset: 0x00002EAD
		private void button5_DETECTED_MIN_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002EC9 File Offset: 0x00002EC9
		private void button6_DETECTED_DISCORD_Click(object sender, EventArgs e)
		{
			this.NetFunctions.runURL(this.NetFunctions.ReadEcho(this.baseurl + this.discordurl));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002EF2 File Offset: 0x00002EF2
		private void button7_DETECTED_WEBLINK_Click(object sender, EventArgs e)
		{
			this.NetFunctions.runURL(this.NetFunctions.ReadEcho(this.baseurl + this.weburl));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002EF2 File Offset: 0x00002EF2
		private void button1_weblink_Click(object sender, EventArgs e)
		{
			this.NetFunctions.runURL(this.NetFunctions.ReadEcho(this.baseurl + this.weburl));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002EC9 File Offset: 0x00002EC9
		private void button1_discord_Click(object sender, EventArgs e)
		{
			this.NetFunctions.runURL(this.NetFunctions.ReadEcho(this.baseurl + this.discordurl));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002FE4 File Offset: 0x00002FE4
		private void button1_exit_Click(object sender, EventArgs e)
		{
			this.NetFunctions.DeinitialisePRC();
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("             Spectrum Launcher Terminated            ", true);
			this.Log.Log("-----------------------------------------------------", true);
			this.Log.Log("", true);
			Application.Exit();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002EAD File Offset: 0x00002EAD
		private void button1_minimise_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003045 File Offset: 0x00003045
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003068 File Offset: 0x00003068
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000030BB File Offset: 0x000030BB
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003045 File Offset: 0x00003045
		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000030C4 File Offset: 0x000030C4
		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000030BB File Offset: 0x000030BB
		private void panel2_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003045 File Offset: 0x00003045
		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003118 File Offset: 0x00003118
		private void panel3_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000030BB File Offset: 0x000030BB
		private void panel3_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003045 File Offset: 0x00003045
		private void panel4_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000316C File Offset: 0x0000316C
		private void panel4_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000030BB File Offset: 0x000030BB
		private void panel4_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002948 File Offset: 0x00002948
		private void textBox5_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002948 File Offset: 0x00002948
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002948 File Offset: 0x00002948
		private void textBox1_keyInputBox_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000031C0 File Offset: 0x000031C0
		private void backgroundWorker1_DiscordWebhook_DoWork(object sender, DoWorkEventArgs e)
		{
			string text = Form1.PostRequest("https://spectrum.menu/Spectrum/monitor", "username=" + this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "username"));
			this.NetFunctions.newDiscordWebhook(this.NetFunctions.ReadEcho(this.baseurl + this.launcherVersion), "Spectrum Successfully Authenticated \n", "https://discord.com/api/webhooks/989679806314602587/BuURcnPdD3F5MwMOF5k5KPcYXU5-roQyZ6NgTNNLZvq-IUWPnmEZU8XWzg7ZAkWgZj6I", text.ToString());
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003230 File Offset: 0x00003230
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				this.NotNetworkFunction.DebuggerDetection("x64dbg");
				this.NotNetworkFunction.DebuggerDetection("x32dbg");
				this.NotNetworkFunction.DebuggerDetection("ida");
				this.NotNetworkFunction.DebuggerDetection("ida64");
				this.NotNetworkFunction.DebuggerDetection("DbgX.Shell");
				this.NotNetworkFunction.DebuggerDetection("vsjitdebugger");
				this.NotNetworkFunction.DebuggerDetection("HTTPDebuggerUI");
				this.NotNetworkFunction.DebuggerDetection("HTTPDebuggerSvc");
				this.NotNetworkFunction.DebuggerDetection("OLLYDBG");
				this.NotNetworkFunction.DebuggerDetection("dnSpy");
				this.NotNetworkFunction.DebuggerDetection("Scylla_x64");
				this.NotNetworkFunction.DebuggerDetection("Scylla_x86");
				this.NotNetworkFunction.DebuggerDetection("javaw");
				this.NotNetworkFunction.DebuggerDetection("procexp64");
				this.NotNetworkFunction.DebuggerDetection("procexp");
				this.NotNetworkFunction.DebuggerDetection("tcpview64");
				this.NotNetworkFunction.DebuggerDetection("tcpview");
				this.NotNetworkFunction.DebuggerDetection("HxD");
				this.NotNetworkFunction.DebuggerDetection("ILSpy");
				this.NotNetworkFunction.DebuggerDetection("dotPeek64");
				this.NotNetworkFunction.DebuggerDetection("dotMemory64");
				this.NotNetworkFunction.DebuggerDetection("ollydbg");
				this.NotNetworkFunction.DebuggerDetection("ProcessHacker");
				this.NotNetworkFunction.DebuggerDetection("tcpview");
				this.NotNetworkFunction.DebuggerDetection("autoruns");
				this.NotNetworkFunction.DebuggerDetection("autorunsc");
				this.NotNetworkFunction.DebuggerDetection("filemon");
				this.NotNetworkFunction.DebuggerDetection("procmon");
				this.NotNetworkFunction.DebuggerDetection("regmon");
				this.NotNetworkFunction.DebuggerDetection("procexp");
				this.NotNetworkFunction.DebuggerDetection("idaq.exe");
				this.NotNetworkFunction.DebuggerDetection("idaq64.exe");
				this.NotNetworkFunction.DebuggerDetection("ImmunityDebugger");
				this.NotNetworkFunction.DebuggerDetection("Wireshark");
				this.NotNetworkFunction.DebuggerDetection("dumpcap");
				this.NotNetworkFunction.DebuggerDetection("HookExplorer");
				this.NotNetworkFunction.DebuggerDetection("ImportREC");
				this.NotNetworkFunction.DebuggerDetection("PETools");
				this.NotNetworkFunction.DebuggerDetection("LordPE");
				this.NotNetworkFunction.DebuggerDetection("SysInspector");
				this.NotNetworkFunction.DebuggerDetection("proc_analyzer");
				this.NotNetworkFunction.DebuggerDetection("sysAnalyzer");
				this.NotNetworkFunction.DebuggerDetection("sniff_hit");
				this.NotNetworkFunction.DebuggerDetection("windbg.exe");
				this.NotNetworkFunction.DebuggerDetection("joeboxcontrol");
				this.NotNetworkFunction.DebuggerDetection("joeboxserver");
				this.NotNetworkFunction.DebuggerDetection("x64dbg");
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000353C File Offset: 0x0000353C
		public void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			this.NetFunctions.newDiscordWebhook(this.NetFunctions.ReadEcho(this.baseurl + this.launcherVersion), "DEBUGGER DETECTED: " + this.NotNetworkFunction.getDebuggerName() + "\n", "https://discord.com/api/webhooks/1013606753256087674/OMglGHIzcve2-z9gxh5d5xFm9v1m0b_euhM4wKGfZklPdaL9S03R585fbgAjfI-vNzrp", Form1.PostRequest("https://spectrum.menu/Spectrum/monitor", "username=" + this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "username")));
			Application.Exit();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000035C0 File Offset: 0x000035C0
		private void button2_DownloadASI_1_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_DownloadASI_1.IsBusy)
			{
				return;
			}
			try
			{
				if (this.button2_DownloadASI_1.Text == "Download")
				{
					this.button2_DownloadASI_1.Text = "Downloading...";
					this.backgroundWorker3_DownloadASI_1.RunWorkerAsync();
				}
				if (this.button2_DownloadASI_1.Text == "Delete")
				{
					this.backgroundWorker3_DownloadASI_1.RunWorkerAsync();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003648 File Offset: 0x00003648
		private void button2_DownloadASI_2_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_Download_ASI_2.IsBusy)
			{
				return;
			}
			try
			{
				if (this.button2_DownloadASI_2.Text == "Download")
				{
					this.button2_DownloadASI_2.Text = "Downloading...";
					this.backgroundWorker3_Download_ASI_2.RunWorkerAsync();
				}
				if (this.button2_DownloadASI_2.Text == "Delete")
				{
					this.backgroundWorker3_Download_ASI_2.RunWorkerAsync();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000036D0 File Offset: 0x000036D0
		private void button3_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_Download_ASI_3.IsBusy)
			{
				return;
			}
			try
			{
				if (this.button3.Text == "Download")
				{
					this.button3.Text = "Downloading...";
					this.backgroundWorker3_Download_ASI_3.RunWorkerAsync();
				}
				if (this.button3.Text == "Delete")
				{
					this.backgroundWorker3_Download_ASI_3.RunWorkerAsync();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003758 File Offset: 0x00003758
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_Download_ASI_4.IsBusy)
			{
				return;
			}
			try
			{
				if (this.button2.Text == "Download")
				{
					this.button2.Text = "Downloading...";
					this.backgroundWorker3_Download_ASI_4.RunWorkerAsync();
				}
				if (this.button2.Text == "Delete")
				{
					this.backgroundWorker3_Download_ASI_4.RunWorkerAsync();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000037E0 File Offset: 0x000037E0
		private void button2_DownloadASI_5_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_Download_ASI_5.IsBusy)
			{
				return;
			}
			try
			{
				if (this.button2_DownloadASI_5.Text == "Download")
				{
					this.button2_DownloadASI_5.Text = "Downloading...";
					this.backgroundWorker3_Download_ASI_5.RunWorkerAsync();
				}
				if (this.button2_DownloadASI_5.Text == "Delete")
				{
					this.backgroundWorker3_Download_ASI_5.RunWorkerAsync();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003868 File Offset: 0x00003868
		private void button2_DownloadASI_6_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_Download_ASI_6.IsBusy)
			{
				return;
			}
			try
			{
				if (this.button2_DownloadASI_6.Text == "Download")
				{
					this.button2_DownloadASI_6.Text = "Downloading...";
					this.backgroundWorker3_Download_ASI_6.RunWorkerAsync();
				}
				if (this.button2_DownloadASI_6.Text == "Delete")
				{
					this.backgroundWorker3_Download_ASI_6.RunWorkerAsync();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000038F0 File Offset: 0x000038F0
		private void button2_DownloadASI_7_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_Download_ASI_7.IsBusy)
			{
				return;
			}
			try
			{
				if (this.button2_DownloadASI_7.Text == "Download")
				{
					this.button2_DownloadASI_7.Text = "Downloading...";
					this.backgroundWorker3_Download_ASI_7.RunWorkerAsync();
				}
				if (this.button2_DownloadASI_7.Text == "Delete")
				{
					this.backgroundWorker3_Download_ASI_7.RunWorkerAsync();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003978 File Offset: 0x00003978
		private void button2_DownloadASI_8_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_Download_ASI_8.IsBusy)
			{
				return;
			}
			try
			{
				if (this.button2_DownloadASI_8.Text == "Download")
				{
					this.button2_DownloadASI_8.Text = "Downloading...";
					this.backgroundWorker3_Download_ASI_8.RunWorkerAsync();
				}
				if (this.button2_DownloadASI_8.Text == "Delete")
				{
					this.backgroundWorker3_Download_ASI_8.RunWorkerAsync();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003A00 File Offset: 0x00003A00
		public void Asi_download_Check(bool log)
		{
			Button[] array = new Button[]
			{
				this.button2_DownloadASI_1,
				this.button2_DownloadASI_2,
				this.button3,
				this.button2,
				this.button2_DownloadASI_5,
				this.button2_DownloadASI_6,
				this.button2_DownloadASI_7,
				this.button2_DownloadASI_8
			};
			string[] array2 = new string[]
			{
				this.asi1path,
				this.asi2path,
				this.asi3path,
				this.asi4path,
				this.asi5path,
				this.asi6path,
				this.asi7path,
				this.asi8path
			};
			for (int i = 0; i < array2.Length; i++)
			{
				if (File.Exists(array2[i] + ".asi"))
				{
					array[i].Text = "Delete";
					if (array2[i].Length <= 0)
					{
						File.Delete(array2[i]);
						this.Log.Log_File(array2[i] + " encountered an error downloading.", false);
						array[i].Text = "Download";
					}
					if (log)
					{
						this.Log.Log_File(array2[i] + " found.", false);
					}
				}
				else
				{
					array[i].Text = "Download";
					if (log)
					{
						this.Log.Log_File(array2[i] + " not found.", false);
					}
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003B60 File Offset: 0x00003B60
		public void deletefile(string path)
		{
			try
			{
				if (File.Exists(path + ".asi"))
				{
					File.Delete(path + ".asi");
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003BA4 File Offset: 0x00003BA4
		private void backgroundWorker3_DownloadASI_1_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.button2_DownloadASI_1.Text == "Downloading...")
			{
				this.NetFunctions.download("ASI1");
			}
			if (this.button2_DownloadASI_1.Text == "Delete")
			{
				this.deletefile(this.asi1path);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003BFB File Offset: 0x00003BFB
		private void backgroundWorker3_DownloadASI_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Asi_download_Check(false);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003C04 File Offset: 0x00003C04
		private void backgroundWorker3_Download_ASI_2_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.button2_DownloadASI_2.Text == "Downloading...")
			{
				this.NetFunctions.download("ASI2");
			}
			if (this.button2_DownloadASI_2.Text == "Delete")
			{
				this.deletefile(this.asi2path);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003BFB File Offset: 0x00003BFB
		private void backgroundWorker3_Download_ASI_2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Asi_download_Check(false);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003C5C File Offset: 0x00003C5C
		private void backgroundWorker3_Download_ASI_3_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.button3.Text == "Downloading...")
			{
				this.NetFunctions.download("ASI3");
			}
			if (this.button3.Text == "Delete")
			{
				this.deletefile(this.asi3path);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003BFB File Offset: 0x00003BFB
		private void backgroundWorker3_Download_ASI_3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Asi_download_Check(false);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003CB4 File Offset: 0x00003CB4
		private void backgroundWorker3_Download_ASI_4_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.button2.Text == "Downloading...")
			{
				this.NetFunctions.download("ASI4");
			}
			if (this.button2.Text == "Delete")
			{
				this.deletefile(this.asi4path);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003BFB File Offset: 0x00003BFB
		private void backgroundWorker3_Download_ASI_4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Asi_download_Check(false);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003D0C File Offset: 0x00003D0C
		private void backgroundWorker3_Download_ASI_5_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.button2_DownloadASI_5.Text == "Downloading...")
			{
				this.NetFunctions.download("ASI5");
			}
			if (this.button2_DownloadASI_5.Text == "Delete")
			{
				this.deletefile(this.asi5path);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003BFB File Offset: 0x00003BFB
		private void backgroundWorker3_Download_ASI_5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Asi_download_Check(false);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003D64 File Offset: 0x00003D64
		private void backgroundWorker3_Download_ASI_6_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.button2_DownloadASI_6.Text == "Downloading...")
			{
				this.NetFunctions.download("ASI6");
			}
			if (this.button2_DownloadASI_6.Text == "Delete")
			{
				this.deletefile(this.asi6path);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003BFB File Offset: 0x00003BFB
		private void backgroundWorker3_Download_ASI_6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Asi_download_Check(false);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003DBC File Offset: 0x00003DBC
		private void backgroundWorker3_Download_ASI_7_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.button2_DownloadASI_7.Text == "Downloading...")
			{
				this.NetFunctions.download("ASI7");
			}
			if (this.button2_DownloadASI_7.Text == "Delete")
			{
				this.deletefile(this.asi7path);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003BFB File Offset: 0x00003BFB
		private void backgroundWorker3_Download_ASI_7_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Asi_download_Check(false);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003E14 File Offset: 0x00003E14
		private void backgroundWorker3_Download_ASI_8_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.button2_DownloadASI_8.Text == "Downloading...")
			{
				this.NetFunctions.download("ASI8");
			}
			if (this.button2_DownloadASI_8.Text == "Delete")
			{
				this.deletefile(this.asi8path);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003BFB File Offset: 0x00003BFB
		private void backgroundWorker3_Download_ASI_8_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Asi_download_Check(false);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003E6B File Offset: 0x00003E6B
		private void button2_DeleteAllASI_Click(object sender, EventArgs e)
		{
			Directory.Delete(Form1.AsiFolder, true);
			Directory.CreateDirectory(Form1.AsiFolder);
			this.Asi_download_Check(false);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003E8A File Offset: 0x00003E8A
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.backgroundWorker3_downloadInjector.IsBusy)
			{
				MessageBox.Show("The launcher is processing the injection\n\nPlease wait!", "Hold up!");
				return;
			}
			this.backgroundWorker3_downloadInjector.RunWorkerAsync();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002948 File Offset: 0x00002948
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002948 File Offset: 0x00002948
		private void button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003EB8 File Offset: 0x00003EB8
		private void backgroundWorker3_DownloadZip_DoWork(object sender, DoWorkEventArgs e)
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum\\Arrays";
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum\\Arrays";
			string destinationDirectoryName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum\\Arrays";
			string destinationDirectoryName2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum\\Arrays";
			string path = text + "\\VehicleImages";
			string path2 = text + "\\WeaponImages";
			string path3 = text + "\\PedImages";
			string path4 = text + "\\Textures";
			string text3 = text + "\\VehicleImages.zip";
			string text4 = text2 + "\\WeaponImages.zip";
			string text5 = text + "\\Peds.zip";
			string text6 = text + "\\Textures.zip";
			string uriString = "https://spectrum.menu/Spectrum/Zip/VehicleImages.zip";
			string uriString2 = "https://spectrum.menu/Spectrum/Zip/WeaponImages.zip";
			string uriString3 = "https://spectrum.menu/Spectrum/Zip/Peds.zip";
			string uriString4 = "https://spectrum.menu/Spectrum/Zip/Textures.zip";
			int num = int.Parse(this.NetFunctions.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ExpNumOfWeapons"));
			int num2 = int.Parse(this.NetFunctions.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ExpNumOfVehicles"));
			int num3 = int.Parse(this.NetFunctions.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ExpNumOfPeds"));
			int num4 = int.Parse(this.NetFunctions.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ExpNumOfTex"));
			WebClient webClient = new WebClient();
			new WebClient();
			if (Directory.Exists(path4))
			{
				if (Directory.GetFiles(path4, "*", SearchOption.TopDirectoryOnly).Length != num4)
				{
					this.Log.Log_File("Updating textures...", false);
					try
					{
						Directory.Delete(path, true);
						webClient.DownloadFile(new Uri(uriString4), text6);
						webClient.Dispose();
						this.Log.Log_File("Textures downloaded.", false);
						this.Log.Log_File("Un-zipping textures...", false);
						ZipFile.ExtractToDirectory(text6, destinationDirectoryName2);
						this.Log.Log_File("Textures unzipped.", false);
						File.Delete(text6);
						this.Log.Log_File("Original texture zip deleted.", false);
						goto IL_299;
					}
					catch
					{
						this.Log.Log_FailDownload("Error downloading textures...", false);
						goto IL_299;
					}
				}
				this.Log.Log_File("Texture files do not need updating.", false);
			}
			else
			{
				this.Log.Log_File("Updating textures...", false);
				try
				{
					webClient.DownloadFile(new Uri(uriString4), text6);
					webClient.Dispose();
					this.Log.Log_File("Textures downloaded.", false);
					this.Log.Log_File("Un-zipping textures...", false);
					ZipFile.ExtractToDirectory(text6, destinationDirectoryName2);
					this.Log.Log_File("Textures unzipped.", false);
					File.Delete(text6);
					this.Log.Log_File("Original texture zip deleted.", false);
				}
				catch
				{
					this.Log.Log_FailDownload("Error downloading textures...", false);
				}
			}
			IL_299:
			if (Directory.Exists(path))
			{
				if (Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length != num2)
				{
					this.Log.Log_File("Updating vehicle images...", false);
					try
					{
						Directory.Delete(path, true);
						webClient.DownloadFile(new Uri(uriString), text3);
						webClient.Dispose();
						this.Log.Log_File("Vehicle images downloaded.", false);
						this.Log.Log_File("Un-zipping vehicle images...", false);
						ZipFile.ExtractToDirectory(text3, text);
						this.Log.Log_File("Vehicle images unzipped.", false);
						File.Delete(text3);
						this.Log.Log_File("Original vehicle zip deleted.", false);
						goto IL_401;
					}
					catch
					{
						this.Log.Log_FailDownload("Error downloading vehicle images...", false);
						goto IL_401;
					}
				}
				this.Log.Log_File("Vehicle files do not need updating.", false);
			}
			else
			{
				this.Log.Log_File("Updating vehicle images...", false);
				try
				{
					webClient.DownloadFile(new Uri(uriString), text3);
					webClient.Dispose();
					this.Log.Log_File("Vehicle images downloaded.", false);
					this.Log.Log_File("Un-zipping vehicle images...", false);
					ZipFile.ExtractToDirectory(text3, text);
					this.Log.Log_File("Vehicle images unzipped.", false);
					File.Delete(text3);
					this.Log.Log_File("Original vehicle zip deleted.", false);
				}
				catch
				{
					this.Log.Log_FailDownload("Error downloading vehicle images...", false);
				}
			}
			IL_401:
			if (Directory.Exists(path2))
			{
				if (Directory.GetFiles(path2, "*", SearchOption.TopDirectoryOnly).Length != num)
				{
					this.Log.Log_File("Updating weapon images...", false);
					try
					{
						Directory.Delete(path2, true);
						webClient.DownloadFile(new Uri(uriString2), text4);
						webClient.Dispose();
						this.Log.Log_File("Weapon images downloaded.", false);
						this.Log.Log_File("Un-zipping weapon images...", false);
						ZipFile.ExtractToDirectory(text4, text2);
						this.Log.Log_File("Weapon images unzipped.", false);
						File.Delete(text4);
						this.Log.Log_File("Original weapon zip deleted.", false);
						goto IL_569;
					}
					catch
					{
						this.Log.Log_FailDownload("Error downloading weapon images...", false);
						goto IL_569;
					}
				}
				this.Log.Log_File("Weapon files do not need updating.", false);
			}
			else
			{
				this.Log.Log_File("Updating weapon images...", false);
				try
				{
					webClient.DownloadFile(new Uri(uriString2), text4);
					webClient.Dispose();
					this.Log.Log_File("Weapon images downloaded.", false);
					this.Log.Log_File("Un-zipping weapon images...", false);
					ZipFile.ExtractToDirectory(text4, text2);
					this.Log.Log_File("Weapon images unzipped.", false);
					File.Delete(text4);
					this.Log.Log_File("Original weapon zip deleted.", false);
				}
				catch
				{
					this.Log.Log_FailDownload("Error downloading weapon images...", false);
				}
			}
			IL_569:
			if (Directory.Exists(path3))
			{
				if (Directory.GetFiles(path3, "*", SearchOption.TopDirectoryOnly).Length != num3)
				{
					this.Log.Log_File("Updating ped images...", false);
					try
					{
						Directory.Delete(path3, true);
						webClient.DownloadFile(new Uri(uriString3), text5);
						webClient.Dispose();
						this.Log.Log_File("Ped images downloaded.", false);
						this.Log.Log_File("Un-zipping ped images...", false);
						ZipFile.ExtractToDirectory(text5, destinationDirectoryName);
						this.Log.Log_File("Ped images unzipped.", false);
						File.Delete(text5);
						this.Log.Log_File("Original ped zip deleted.", false);
						return;
					}
					catch
					{
						this.Log.Log_FailDownload("Error downloading ped images...", false);
						return;
					}
				}
				this.Log.Log_File("Ped files do not need updating.", false);
				return;
			}
			this.Log.Log_File("Updating ped images...", false);
			try
			{
				webClient.DownloadFile(new Uri(uriString3), text5);
				webClient.Dispose();
				this.Log.Log_File("Ped images downloaded.", false);
				this.Log.Log_File("Un-zipping ped images...", false);
				ZipFile.ExtractToDirectory(text5, destinationDirectoryName);
				this.Log.Log_File("Ped images unzipped.", false);
				File.Delete(text5);
				this.Log.Log_File("Original ped zip deleted.", false);
			}
			catch
			{
				this.Log.Log_FailDownload("Error downloading ped images...", false);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002948 File Offset: 0x00002948
		private void button4_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000045F8 File Offset: 0x000045F8
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004624 File Offset: 0x00004624
		private void button2_ClearAllSpectrumData_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will close the Launcher\n\nAre you sure?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Spectrum GTA V", true))
					{
						foreach (string subkey in registryKey.GetSubKeyNames())
						{
							registryKey.DeleteSubKeyTree(subkey);
						}
						registryKey.DeleteValue(null, false);
						Registry.CurrentUser.DeleteSubKey("Spectrum GTA V");
						this.textBox1.Text = "";
						this.textBox2.Text = "";
						this.checkBox1_RememberMe.Checked = false;
						Directory.Delete(Form1.SpectrumFolder, true);
						Application.Exit();
					}
					return;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error deleting registry key: " + ex.Message);
					return;
				}
				return;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004714 File Offset: 0x00004714
		public void UpdatePersonalUses()
		{
			this.label2.Text = this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "PersonalUses");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004736 File Offset: 0x00004736
		private void button2_OpenASIFolder_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", Form1.AsiFolder);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004748 File Offset: 0x00004748
		private void backgroundWorker3_downloadInjector_DoWork(object sender, DoWorkEventArgs e)
		{
			this.NetFunctions.downloadInjector();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004755 File Offset: 0x00004755
		private void button6_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.gta5-mods.com/all/tags/asi/most-downloaded");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004762 File Offset: 0x00004762
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.button1_login.PerformClick();
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004762 File Offset: 0x00004762
		private void button1_login_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.button1_login.PerformClick();
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004779 File Offset: 0x00004779
		private void button2_ResetConfigFile_Click(object sender, EventArgs e)
		{
			this.HWID_Reset(this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "username"), this.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "password"));
		}

		// Token: 0x04000001 RID: 1
		private Network_Functions NetFunctions;

		// Token: 0x04000002 RID: 2
		private Non_Network_Functions NotNetworkFunction;

		// Token: 0x04000003 RID: 3
		private Version version;

		// Token: 0x04000004 RID: 4
		private Logger Log;

		// Token: 0x04000005 RID: 5
		private string baseurl;

		// Token: 0x04000006 RID: 6
		private string gtaProcessName;

		// Token: 0x04000007 RID: 7
		private string weburl;

		// Token: 0x04000008 RID: 8
		private string discordurl;

		// Token: 0x04000009 RID: 9
		private string announcementurl;

		// Token: 0x0400000A RID: 10
		private string changelogurl;

		// Token: 0x0400000B RID: 11
		private string rockstarserver;

		// Token: 0x0400000C RID: 12
		private string spectrumserver;

		// Token: 0x0400000D RID: 13
		private string ASI1_TITLE;

		// Token: 0x0400000E RID: 14
		private string ASI2_TITLE;

		// Token: 0x0400000F RID: 15
		private string ASI3_TITLE;

		// Token: 0x04000010 RID: 16
		private string ASI4_TITLE;

		// Token: 0x04000011 RID: 17
		private string ASI5_TITLE;

		// Token: 0x04000012 RID: 18
		private string ASI6_TITLE;

		// Token: 0x04000013 RID: 19
		private string ASI7_TITLE;

		// Token: 0x04000014 RID: 20
		private string ASI8_TITLE;

		// Token: 0x04000015 RID: 21
		private string ASI1_DownloadLink;

		// Token: 0x04000016 RID: 22
		private string ASI2_DownloadLink;

		// Token: 0x04000017 RID: 23
		private string ASI3_DownloadLink;

		// Token: 0x04000018 RID: 24
		private string ASI4_DownloadLink;

		// Token: 0x04000019 RID: 25
		private string ASI5_DownloadLink;

		// Token: 0x0400001A RID: 26
		private string ASI6_DownloadLink;

		// Token: 0x0400001B RID: 27
		private string ASI7_DownloadLink;

		// Token: 0x0400001C RID: 28
		private string ASI8_DownloadLink;

		// Token: 0x0400001D RID: 29
		private string gameVersion;

		// Token: 0x0400001E RID: 30
		private string launcherVersion;

		// Token: 0x0400001F RID: 31
		private static string AsiFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum\\ASI";

		// Token: 0x04000020 RID: 32
		private static string SpectrumFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum";

		// Token: 0x04000021 RID: 33
		private string asi1path;

		// Token: 0x04000022 RID: 34
		private string asi2path;

		// Token: 0x04000023 RID: 35
		private string asi3path;

		// Token: 0x04000024 RID: 36
		private string asi4path;

		// Token: 0x04000025 RID: 37
		private string asi5path;

		// Token: 0x04000026 RID: 38
		private string asi6path;

		// Token: 0x04000027 RID: 39
		private string asi7path;

		// Token: 0x04000028 RID: 40
		private string asi8path;

		// Token: 0x04000029 RID: 41
		private string detected;

		// Token: 0x0400002A RID: 42
		private string Avi;

		// Token: 0x0400002B RID: 43
		private bool Donny;

		// Token: 0x0400002C RID: 44
		private string AuthFilePath;

		// Token: 0x0400002D RID: 45
		private bool _dragging;

		// Token: 0x0400002E RID: 46
		private Point _offset;

		// Token: 0x0400002F RID: 47
		private Point _start_point;
	}
}
