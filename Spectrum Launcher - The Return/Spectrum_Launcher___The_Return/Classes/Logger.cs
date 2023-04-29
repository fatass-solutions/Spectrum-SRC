using System;
using System.Globalization;
using System.IO;

namespace Spectrum_Launcher___The_Return.Classes
{
	// Token: 0x0200000A RID: 10
	internal class Logger
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000092C4 File Offset: 0x000092C4
		private void Log(string text, string index = "INFO", bool log = false)
		{
			try
			{
				DateTime now = DateTime.Now;
				DateTime utcNow = DateTime.UtcNow;
				string[] array = new string[]
				{
					"en-US"
				};
				StreamWriter streamWriter = File.AppendText(new Non_Network_Functions().logFilePath);
				foreach (string name in array)
				{
					if (log)
					{
						CultureInfo provider = new CultureInfo(name);
						streamWriter.WriteLine(text, now.ToString(provider), now.Kind);
					}
					else
					{
						CultureInfo provider2 = new CultureInfo(name);
						streamWriter.WriteLine("{0} -- [" + index + "] -- " + text, now.ToString(provider2), now.Kind);
					}
				}
				streamWriter.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000938C File Offset: 0x0000938C
		public void Log_Info(string text, bool log = false)
		{
			this.Log(text, "Info", log);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000939B File Offset: 0x0000939B
		public void Log(string text, bool log = false)
		{
			this.Log(text, "", log);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000093AA File Offset: 0x000093AA
		public void Log_FailDownload(string text, bool log = false)
		{
			this.Log(text, "-----Fail Download-----", log);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000093B9 File Offset: 0x000093B9
		public void Log_Error(string text, bool log = false)
		{
			this.Log(text, "-----Error-----", log);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000093C8 File Offset: 0x000093C8
		public void Log_Download(string text, bool log = false)
		{
			this.Log(text, "Downloaded", log);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000093D7 File Offset: 0x000093D7
		public void Log_File(string text, bool log = false)
		{
			this.Log(text, "File", log);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000093E6 File Offset: 0x000093E6
		public void Log_Folder(string text, bool log = false)
		{
			this.Log(text, "Folder", log);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000093F5 File Offset: 0x000093F5
		public void Log_Config(string text, bool log = false)
		{
			this.Log(text, "Config", log);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009404 File Offset: 0x00009404
		public void Log_AVDetection(string text, bool log = false)
		{
			this.Log(text, "AV Detection", log);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009413 File Offset: 0x00009413
		public void Log_DGBDetection(string text, bool log = false)
		{
			this.Log(text, "Debugger Detection", log);
		}
	}
}
