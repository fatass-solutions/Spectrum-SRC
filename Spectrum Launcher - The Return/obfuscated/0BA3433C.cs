using System;

// Token: 0x0200001D RID: 29
internal struct 0BA3433C
{
	// Token: 0x0600013B RID: 315 RVA: 0x0021D1CC File Offset: 0x0021D1CC
	public 0BA3433C(int 7FCD7F93)
	{
		this.37C95BC5 = 7FCD7F93;
		this.0A3A2AAE = new 1C617FB4[1 << 7FCD7F93];
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0021D1E8 File Offset: 0x0021D1E8
	public void 7E462452()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.37C95BC5 & 31)))
		{
			this.0A3A2AAE[(int)num].7BC3162D();
			num += 1U;
		}
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0021D224 File Offset: 0x0021D224
	public uint 76A1148C(2B4220A0 41DF2652)
	{
		uint num = 1U;
		for (int i = this.37C95BC5; i > 0; i--)
		{
			num = (num << 1) + this.0A3A2AAE[(int)num].591B5FFF(41DF2652);
		}
		return num - (1U << this.37C95BC5);
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0021D270 File Offset: 0x0021D270
	public uint 15B37533(2B4220A0 66684F83)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.37C95BC5; i++)
		{
			uint num3 = this.0A3A2AAE[(int)num].591B5FFF(66684F83);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x0021D2C0 File Offset: 0x0021D2C0
	public static uint 12C61706(1C617FB4[] 03091B26, uint 7D365082, 2B4220A0 40197316, int 5A4553F0)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < 5A4553F0; i++)
		{
			uint num3 = 03091B26[(int)(7D365082 + num)].591B5FFF(40197316);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x04000105 RID: 261
	private readonly 1C617FB4[] 0A3A2AAE;

	// Token: 0x04000106 RID: 262
	private readonly int 37C95BC5;
}
