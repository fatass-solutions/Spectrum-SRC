using System;

// Token: 0x02000013 RID: 19
public class 655E1A63
{
	// Token: 0x060000A8 RID: 168 RVA: 0x0020E3CC File Offset: 0x0020E3CC
	public 655E1A63()
	{
		this.5A32673B = 337139252U;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0020E3E0 File Offset: 0x0020E3E0
	public uint 29467978(uint 3E420BF0)
	{
		uint num = 3E420BF0 ^ this.5A32673B;
		this.5A32673B = (3FA842F6.31BE6001(this.5A32673B, 7) ^ num);
		return num;
	}

	// Token: 0x040000C0 RID: 192
	private uint 5A32673B;
}
