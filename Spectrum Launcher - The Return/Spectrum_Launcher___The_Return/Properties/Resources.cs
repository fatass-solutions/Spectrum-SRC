using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Spectrum_Launcher___The_Return.Properties
{
	// Token: 0x02000008 RID: 8
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00009259 File Offset: 0x00009259
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00009261 File Offset: 0x00009261
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Spectrum_Launcher___The_Return.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000928D File Offset: 0x0000928D
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00009294 File Offset: 0x00009294
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400009C RID: 156
		private static ResourceManager resourceMan;

		// Token: 0x0400009D RID: 157
		private static CultureInfo resourceCulture;
	}
}
