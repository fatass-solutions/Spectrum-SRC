using System;

// Token: 0x0200001C RID: 28
internal struct 1C617FB4
{
	// Token: 0x06000139 RID: 313 RVA: 0x0021D0C8 File Offset: 0x0021D0C8
	public void 7BC3162D()
	{
		this.06480A1A = 1024U;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x0021D0D8 File Offset: 0x0021D0D8
	public uint 591B5FFF(2B4220A0 09BC08F6)
	{
		uint num = (09BC08F6.1CBB7C6E >> 11) * this.06480A1A;
		if (09BC08F6.3E640D82 < num)
		{
			09BC08F6.1CBB7C6E = num;
			this.06480A1A += 2048U - this.06480A1A >> 5;
			if (09BC08F6.1CBB7C6E < 16777216U)
			{
				09BC08F6.3E640D82 = (09BC08F6.3E640D82 << 8 | (uint)((byte)09BC08F6.789A27AA.ReadByte()));
				09BC08F6.1CBB7C6E <<= 8;
			}
			return 0U;
		}
		09BC08F6.1CBB7C6E -= num;
		09BC08F6.3E640D82 -= num;
		this.06480A1A -= this.06480A1A >> 5;
		if (09BC08F6.1CBB7C6E < 16777216U)
		{
			09BC08F6.3E640D82 = (09BC08F6.3E640D82 << 8 | (uint)((byte)09BC08F6.789A27AA.ReadByte()));
			09BC08F6.1CBB7C6E <<= 8;
		}
		return 1U;
	}

	// Token: 0x04000101 RID: 257
	private const int 2EE3477A = 11;

	// Token: 0x04000102 RID: 258
	private const uint 3F0E32FB = 2048U;

	// Token: 0x04000103 RID: 259
	private const int 2B2B5AE5 = 5;

	// Token: 0x04000104 RID: 260
	private uint 06480A1A;
}
