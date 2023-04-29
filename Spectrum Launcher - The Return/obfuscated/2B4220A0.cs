using System;
using System.IO;

// Token: 0x0200001B RID: 27
internal class 2B4220A0
{
	// Token: 0x06000135 RID: 309 RVA: 0x0021CFE0 File Offset: 0x0021CFE0
	public void 39706074(Stream 447C35A6)
	{
		this.789A27AA = 447C35A6;
		this.3E640D82 = 0U;
		this.1CBB7C6E = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.3E640D82 = (this.3E640D82 << 8 | (uint)((byte)this.789A27AA.ReadByte()));
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0021D030 File Offset: 0x0021D030
	public void 427D54D6()
	{
		this.789A27AA = null;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0021D03C File Offset: 0x0021D03C
	public uint 7B5C1A48(int 44CD1999)
	{
		uint num = this.1CBB7C6E;
		uint num2 = this.3E640D82;
		uint num3 = 0U;
		for (int i = 44CD1999; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.789A27AA.ReadByte()));
				num <<= 8;
			}
		}
		this.1CBB7C6E = num;
		this.3E640D82 = num2;
		return num3;
	}

	// Token: 0x040000FC RID: 252
	private uint 55DF6CBC = 1U;

	// Token: 0x040000FD RID: 253
	public const uint 12093DA5 = 16777216U;

	// Token: 0x040000FE RID: 254
	public uint 1CBB7C6E;

	// Token: 0x040000FF RID: 255
	public uint 3E640D82;

	// Token: 0x04000100 RID: 256
	public Stream 789A27AA;
}
