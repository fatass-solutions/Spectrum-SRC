using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Spectrum_Launcher___The_Return.Classes
{
	// Token: 0x0200000D RID: 13
	internal class Non_Network_Functions
	{
		// Token: 0x0600008D RID: 141 RVA: 0x001105B8 File Offset: 0x001105B8
		public Non_Network_Functions()
		{
			object[] 408F = new object[]
			{
				this
			};
			new 66026065().433F05E0(408F, 1066342);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000A01C File Offset: 0x0000A01C
		public void InitialCoreDirectoryCheck(ref string fileBeingCheckedReturn, ref bool isFileOK)
		{
			try
			{
				if (!Directory.Exists(this.folderPathMain))
				{
					Directory.CreateDirectory(this.folderPathMain);
				}
				if (Directory.Exists(this.folderPathMain))
				{
					this.Log.Log_Folder("Found: " + this.folderPathMain, false);
					for (int i = 0; i < this.filePaths.Length; i++)
					{
						string text = this.folderPathMain + "\\" + this.filePaths[i];
						if (!Directory.Exists(text))
						{
							string text2 = this.filePaths[i];
							fileBeingCheckedReturn = text2;
							Directory.CreateDirectory(text);
						}
						if (Directory.Exists(text))
						{
							this.Log.Log_Folder("Found: " + text, false);
							isFileOK = false;
						}
						else
						{
							this.Log.Log_Folder("Not Found: " + text, false);
							isFileOK = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.Log.Log_Folder("Found: " + this.folderPathMain, false);
				this.Log.Log_Folder(ex.ToString(), true);
				isFileOK = false;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000A13C File Offset: 0x0000A13C
		public void AntiVirus_Check(string serviceName)
		{
			bool flag = ServiceController.GetServices().FirstOrDefault((ServiceController s) => s.ServiceName == serviceName) != null;
			string str = serviceName + " is known is to mess with Spectrum.\n";
			string caption = "AntiVirus Warning";
			string str2 = "This Anti-Virus could cause errors!\n";
			string str3 = "Press 'OK' to continue";
			if (flag)
			{
				MessageBox.Show(str + str2 + str3, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.Log.Log_AVDetection(serviceName + " has been detected.", false);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000A1C1 File Offset: 0x0000A1C1
		public void Create_Registry_Folder(string FolderName)
		{
			Registry.CurrentUser.CreateSubKey(FolderName);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000A1CF File Offset: 0x0000A1CF
		public void Create_Registry_Key(string FolderName, string KeyName, string value)
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(FolderName);
			registryKey.SetValue(KeyName, value);
			registryKey.Close();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000A1E9 File Offset: 0x0000A1E9
		public string Retrieve_Registry_Key_Value(string Foldername, string Keyname)
		{
			return Registry.CurrentUser.OpenSubKey(Foldername).GetValue(Keyname).ToString();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000A201 File Offset: 0x0000A201
		public void Registry_Folder_Check(string Foldername)
		{
			if (Registry.CurrentUser.OpenSubKey(Foldername) == null)
			{
				this.Create_Registry_Folder("Spectrum GTA V");
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A21C File Offset: 0x0000A21C
		public void Registry_Key_Check(string foldername)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Spectrum GTA V");
			object value = registryKey.GetValue("LastKeyUsed");
			object value2 = registryKey.GetValue("RememberMe");
			bool value3 = registryKey.GetValue("PersonalUses") != null;
			if (value == null)
			{
				this.Create_Registry_Key(foldername, "LastKeyUsed", "");
			}
			if (value2 == null)
			{
				this.Create_Registry_Key(foldername, "RememberMe", "");
			}
			if (!value3)
			{
				this.Create_Registry_Key(foldername, "PersonalUses", "0");
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000A298 File Offset: 0x0000A298
		public void EndTask(string taskname)
		{
			Process[] processesByName = Process.GetProcessesByName(taskname.Replace(".exe", ""));
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
				this.Log.Log_Info(taskname + " killed successfully!", false);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000A2E8 File Offset: 0x0000A2E8
		public void SpectrumFolderExists()
		{
			if (!Directory.Exists(this.folderPathMain))
			{
				Directory.CreateDirectory(this.folderPathMain);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000A303 File Offset: 0x0000A303
		public string getDebuggerName()
		{
			return Non_Network_Functions.DebuggerName;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000A30C File Offset: 0x0000A30C
		public void DebuggerDetection(string name)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName.Contains(name))
				{
					new Form1().backgroundWorker2.RunWorkerAsync();
					Non_Network_Functions.DebuggerName = name;
					this.Log.Log_DGBDetection(name + " was detected running along side the launcher.", false);
				}
			}
		}

		// Token: 0x040000AF RID: 175
		private Logger Log;

		// Token: 0x040000B0 RID: 176
		private Network_Functions NetFunctions;

		// Token: 0x040000B1 RID: 177
		public string mainFolder;

		// Token: 0x040000B2 RID: 178
		public string documentFolder;

		// Token: 0x040000B3 RID: 179
		public string folderPathMain;

		// Token: 0x040000B4 RID: 180
		public string logFilePath;

		// Token: 0x040000B5 RID: 181
		public string[] filePaths;

		// Token: 0x040000B6 RID: 182
		public static string DebuggerName;
	}
}
