using System;
using System.Runtime.InteropServices;

// Token: 0x02000012 RID: 18
public class 76DB7FE3
{
	// Token: 0x060000A6 RID: 166 RVA: 0x0020E304 File Offset: 0x0020E304
	public 76DB7FE3()
	{
		if (76DB7FE3.24A11B35 == null)
		{
			76DB7FE3.24A11B35 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				76DB7FE3.24A11B35[i] = num;
			}
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0020E380 File Offset: 0x0020E380
	public uint 70BF6985(IntPtr 0F9554ED, uint 643C467C)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)643C467C))
		{
			num = (76DB7FE3.24A11B35[(int)(((uint)Marshal.ReadByte(new IntPtr(0F9554ED.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x040000BF RID: 191
	private static uint[] 24A11B35;
}
