using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Spectrum_Launcher___The_Return.Properties
{
	// Token: 0x02000009 RID: 9
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000929C File Offset: 0x0000929C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400009E RID: 158
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
