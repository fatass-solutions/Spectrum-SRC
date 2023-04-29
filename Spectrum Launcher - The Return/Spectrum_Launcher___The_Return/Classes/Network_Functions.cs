using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using DiscordMessenger;
using DiscordRPC;
using Microsoft.Win32;

namespace Spectrum_Launcher___The_Return.Classes
{
	// Token: 0x0200000B RID: 11
	internal class Network_Functions
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00009424 File Offset: 0x00009424
		public void downloadInjector()
		{
			string destinationDirectoryName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum";
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum\\Injector.zip";
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Spectrum\\Injector.exe";
			string uriString = "https://spectrum.menu/Spectrum/Injector.zip";
			if (!File.Exists(text2))
			{
				WebClient webClient = new WebClient();
				this.Log.Log_File("Un-zipping injector...", false);
				webClient.DownloadFileAsync(new Uri(uriString), text);
				Thread.Sleep(5000);
				ZipFile.ExtractToDirectory(text, destinationDirectoryName);
				this.Log.Log_File("Injector unzipped...", false);
				File.Delete(text);
				Process.Start(text2);
			}
			else
			{
				File.Delete(text2);
				WebClient webClient2 = new WebClient();
				this.Log.Log_File("Un-zipping injector...", false);
				webClient2.DownloadFileAsync(new Uri(uriString), text);
				Thread.Sleep(5000);
				ZipFile.ExtractToDirectory(text, destinationDirectoryName);
				this.Log.Log_File("Injector unzipped...", false);
				File.Delete(text);
				Process.Start(text2);
			}
			int num = int.Parse(Network_Functions.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "PersonalUses"));
			string value = (num + 1).ToString();
			Registry.SetValue("HKEY_CURRENT_USER\\Spectrum GTA V", "PersonalUses", value, RegistryValueKind.String);
			new Form1().UpdatePersonalUses();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00009564 File Offset: 0x00009564
		public void download(string asinumber)
		{
			try
			{
				WebClient webClient = new WebClient();
				int num = 0;
				bool flag = false;
				uint num2 = <PrivateImplementationDetails>.ComputeStringHash(asinumber);
				string text;
				string str;
				string uriString;
				if (num2 <= 957861390U)
				{
					if (num2 <= 924306152U)
					{
						if (num2 != 857195676U)
						{
							if (num2 != 924306152U)
							{
								goto IL_2AC;
							}
							if (!(asinumber == "ASI4"))
							{
								goto IL_2AC;
							}
							text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI4_TITLE");
							str = Network_Functions.AsiFolder + "\\" + text;
							uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI4_DownloadLink");
						}
						else
						{
							if (!(asinumber == "ASI8"))
							{
								goto IL_2AC;
							}
							text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI8_TITLE");
							str = Network_Functions.AsiFolder + "\\" + text;
							uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI8_DownloadLink");
						}
					}
					else if (num2 != 941083771U)
					{
						if (num2 != 957861390U)
						{
							goto IL_2AC;
						}
						if (!(asinumber == "ASI6"))
						{
							goto IL_2AC;
						}
						text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI6_TITLE");
						str = Network_Functions.AsiFolder + "\\" + text;
						uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI6_DownloadLink");
					}
					else
					{
						if (!(asinumber == "ASI5"))
						{
							goto IL_2AC;
						}
						text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI5_TITLE");
						str = Network_Functions.AsiFolder + "\\" + text;
						uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI5_DownloadLink");
					}
				}
				else if (num2 <= 1008194247U)
				{
					if (num2 != 974639009U)
					{
						if (num2 != 1008194247U)
						{
							goto IL_2AC;
						}
						if (!(asinumber == "ASI1"))
						{
							goto IL_2AC;
						}
						text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI1_TITLE");
						str = Network_Functions.AsiFolder + "\\" + text;
						uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI1_DownloadLink");
					}
					else
					{
						if (!(asinumber == "ASI7"))
						{
							goto IL_2AC;
						}
						text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI7_TITLE");
						str = Network_Functions.AsiFolder + "\\" + text;
						uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI7_DownloadLink");
					}
				}
				else if (num2 != 1024971866U)
				{
					if (num2 != 1041749485U)
					{
						goto IL_2AC;
					}
					if (!(asinumber == "ASI3"))
					{
						goto IL_2AC;
					}
					text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI3_TITLE");
					str = Network_Functions.AsiFolder + "\\" + text;
					uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI3_DownloadLink");
				}
				else
				{
					if (!(asinumber == "ASI2"))
					{
						goto IL_2AC;
					}
					text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI2_TITLE");
					str = Network_Functions.AsiFolder + "\\" + text;
					uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI2_DownloadLink");
				}
				do
				{
					try
					{
						webClient.DownloadFileAsync(new Uri(uriString), str + ".asi");
						while (webClient.IsBusy)
						{
							Thread.Sleep(1);
						}
						webClient.Dispose();
						flag = File.Exists(str + ".asi");
						num++;
					}
					catch (Exception ex)
					{
						this.Log.Log_Error("1 ASI download failed: " + ex.ToString(), false);
					}
				}
				while (num <= 3 && (!flag || num > 3));
				if (flag)
				{
					this.Log.Log_Download("Downloaded " + text, false);
				}
				else
				{
					this.Log.Log_Download("Download failed" + text, false);
				}
				num = 0;
				flag = false;
				return;
				IL_2AC:
				text = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI1_TITLE");
				str = Network_Functions.AsiFolder + "\\" + text;
				uriString = this.ReadEcho("https://spectrum.menu/Spectrum/Launcher_Config.php?Link=ASI1_DownloadLink");
				this.Log.Log("Looaded default", false);
			}
			catch (Exception ex2)
			{
				this.Log.Log_Error("2 ASI download failed: " + ex2.ToString(), false);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009964 File Offset: 0x00009964
		private string GetIP()
		{
			IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
			return addressList[addressList.Length - 1].ToString();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009980 File Offset: 0x00009980
		public string ReadEcho(string URL)
		{
			string result;
			try
			{
				using (StreamReader streamReader = new StreamReader(new WebClient().OpenRead(URL)))
				{
					result = streamReader.ReadToEnd();
				}
			}
			catch (Exception)
			{
				this.Log.Log_Error("Failed to get data.", false);
				result = "Could not return text.";
			}
			return result;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000099E8 File Offset: 0x000099E8
		public void runURL(string url)
		{
			Process.Start(url);
			this.Log.Log_Info(url + " opened successfully.", false);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009A08 File Offset: 0x00009A08
		public void InitializeRPC()
		{
			this.client = new DiscordRpcClient("1013588702414512148");
			this.client.Initialize();
			this.client.SetPresence(new RichPresence
			{
				Details = "The BEST FREE GTA V Menu!",
				State = "https://spectrum.menu",
				Assets = new Assets
				{
					LargeImageKey = "spectrumbigg",
					LargeImageText = "Spectrum GTA V",
					SmallImageKey = "spikey_spectrum"
				}
			});
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009A83 File Offset: 0x00009A83
		public void DeinitialisePRC()
		{
			this.client.Dispose();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009A90 File Offset: 0x00009A90
		public string winver()
		{
			int num = int.Parse((string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("CurrentBuild"));
			string result;
			if (num >= 7600 && num <= 9199)
			{
				result = "Windows 7";
			}
			else
			{
				int num2 = num;
				if (num2 >= 9200 && num2 <= 9600)
				{
					result = "Windows 8";
				}
				else
				{
					int num3 = num;
					if (num3 >= 10240 && num3 <= 19045)
					{
						result = "Windows 10";
					}
					else if (num >= 22000)
					{
						result = "Windows 11";
					}
					else
					{
						result = "Fuck Knows";
					}
				}
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009B24 File Offset: 0x00009B24
		public void newDiscordWebhook(string launcherversion, string title, string webhooklink, string monitor)
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
			string text;
			using (WebClient webClient = new WebClient())
			{
				text = webClient.DownloadString("http://icanhazip.com");
			}
			IPAddress ipaddress = hostEntry.AddressList.FirstOrDefault((IPAddress ip) => ip.AddressFamily == AddressFamily.InterNetwork);
			if (ipaddress != null)
			{
				ipaddress.ToString();
			}
			Environment.ProcessorCount.ToString();
			TimeSpan.FromMilliseconds((double)Environment.TickCount);
			(from nic in NetworkInterface.GetAllNetworkInterfaces()
			where nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select nic.GetPhysicalAddress().ToString()).FirstOrDefault<string>();
			string[] logicalDrives = Environment.GetLogicalDrives();
			string.Join(", ", logicalDrives);
			string userName = Environment.UserName;
			string machineName = Environment.MachineName;
			string userDomainName = Environment.UserDomainName;
			string text2 = this.winver();
			Network_Functions.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "LastKeyUsed");
			string text3 = text;
			string text4 = "https://cdn.discordapp.com/attachments/1013263325255184436/1014305854931091528/SpectrumBIGG.png";
			string text5 = "";
			string text6 = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_VideoController").Get())
			{
				text6 = ((ManagementObject)managementBaseObject)["Name"].ToString();
			}
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0"))
			{
				text5 = registryKey.GetValue("ProcessorNameString").ToString();
			}
			using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS"))
			{
				registryKey2.GetValue("BaseBoardProduct").ToString();
				registryKey2.GetValue("BaseBoardManufacturer").ToString();
			}
			Environment.OSVersion.ToString();
			if (monitor == "yes")
			{
				new DiscordMessage().SetUsername("Spectrum").SetAvatar(text4).AddEmbed().SetTimestamp(DateTime.UtcNow).SetTitle(title).SetDescription(" ").SetColor(500).SetFooter("Spectrum Monitoring Service                                                                                      ", text4, text4).SetUrl("https://spectrum.menu").AddField("Monitoring Exemption", Network_Functions.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "username") + " is exempt from monitoring!", true).SetThumbnail(text4, null, null, null).Build().SendMessage(webhooklink);
				return;
			}
			if (monitor == "no")
			{
				new DiscordMessage().SetUsername("Spectrum").SetAvatar(text4).AddEmbed().SetTimestamp(DateTime.UtcNow).SetTitle(title).SetDescription(" ").SetColor(500).SetFooter("Spectrum Monitoring Service                                                                                      ", text4, text4).SetUrl("https://spectrum.menu").AddField("User", Network_Functions.NotNetworkFunction.Retrieve_Registry_Key_Value("Spectrum GTA V", "username"), true).AddField("Launcher Version", launcherversion, true).AddField("OS Version", text2, true).AddField("Processor Name", text5, true).AddField("External IP", text3, true).AddField("GPU", text6, true).SetThumbnail(text4, null, null, null).Build().SendMessage(webhooklink);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00110568 File Offset: 0x00110568
		public Network_Functions()
		{
			object[] 408F = new object[]
			{
				this
			};
			new 66026065().433F05E0(408F, 1065075);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00110598 File Offset: 0x00110598
		// Note: this type is marked as 'beforefieldinit'.
		static Network_Functions()
		{
			new 66026065().433F05E0(null, 1065206);
		}

		// Token: 0x0400009F RID: 159
		private static Non_Network_Functions NotNetworkFunction;

		// Token: 0x040000A0 RID: 160
		private Logger Log;

		// Token: 0x040000A1 RID: 161
		public DiscordRpcClient client;

		// Token: 0x040000A2 RID: 162
		private static string AsiFolder;

		// Token: 0x040000A3 RID: 163
		public bool asi1_downloaded;

		// Token: 0x040000A4 RID: 164
		public bool asi2_downloaded;

		// Token: 0x040000A5 RID: 165
		public bool asi3_downloaded;

		// Token: 0x040000A6 RID: 166
		public bool asi4_downloaded;

		// Token: 0x040000A7 RID: 167
		public bool asi5_downloaded;

		// Token: 0x040000A8 RID: 168
		public bool asi6_downloaded;

		// Token: 0x040000A9 RID: 169
		public bool asi7_downloaded;

		// Token: 0x040000AA RID: 170
		public bool asi8_downloaded;
	}
}
