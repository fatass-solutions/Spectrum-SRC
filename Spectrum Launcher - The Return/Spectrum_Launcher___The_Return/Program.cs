using System;
using System.Windows.Forms;

namespace Spectrum_Launcher___The_Return
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00009242 File Offset: 0x00009242
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
