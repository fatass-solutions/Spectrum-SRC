using System;
using System.IO;

// Token: 0x0200001E RID: 30
public class 09D87DBE
{
	// Token: 0x06000140 RID: 320 RVA: 0x0021D308 File Offset: 0x0021D308
	public void 031C7D82(uint 5FB06F5E)
	{
		if (this.270204F6 != 5FB06F5E)
		{
			this.68FD4065 = new byte[5FB06F5E];
		}
		this.270204F6 = 5FB06F5E;
		this.054059A6 = 0U;
		this.67F41B9A = 0U;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0021D338 File Offset: 0x0021D338
	public void 25BD01F5(Stream 45C41BF4, bool 1028066F)
	{
		this.5D037168();
		this.313A4B4F = 45C41BF4;
		if (!1028066F)
		{
			this.67F41B9A = 0U;
			this.054059A6 = 0U;
			this.5D6621C4 = 0U;
		}
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0021D364 File Offset: 0x0021D364
	public void 5D037168()
	{
		this.257A4FB1();
		this.313A4B4F = null;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0021D374 File Offset: 0x0021D374
	public void 257A4FB1()
	{
		uint num = this.054059A6 - this.67F41B9A;
		if (num == 0U)
		{
			return;
		}
		this.313A4B4F.Write(this.68FD4065, (int)this.67F41B9A, (int)num);
		if (this.054059A6 >= this.270204F6)
		{
			this.054059A6 = 0U;
		}
		this.67F41B9A = this.054059A6;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0021D3D4 File Offset: 0x0021D3D4
	public void 6F3321E8(uint 455F13F3, uint 73FF66B3)
	{
		uint num = this.054059A6 - 455F13F3 - 1U;
		if (num >= this.270204F6)
		{
			num += this.270204F6;
		}
		while (73FF66B3 > 0U)
		{
			if (num >= this.270204F6)
			{
				num = 0U;
			}
			byte[] array = this.68FD4065;
			uint num2 = this.054059A6;
			this.054059A6 = num2 + 1U;
			array[(int)num2] = this.68FD4065[(int)num++];
			if (this.054059A6 >= this.270204F6)
			{
				this.257A4FB1();
			}
			73FF66B3 -= 1U;
		}
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0021D45C File Offset: 0x0021D45C
	public void 53092D16(byte 337E061B)
	{
		byte[] array = this.68FD4065;
		uint num = this.054059A6;
		this.054059A6 = num + 1U;
		array[(int)num] = 337E061B;
		if (this.054059A6 >= this.270204F6)
		{
			this.257A4FB1();
		}
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0021D49C File Offset: 0x0021D49C
	public byte 3B144F5C(uint 2C3B4524)
	{
		uint num = this.054059A6 - 2C3B4524 - 1U;
		if (num >= this.270204F6)
		{
			num += this.270204F6;
		}
		return this.68FD4065[(int)num];
	}

	// Token: 0x04000107 RID: 263
	private byte[] 68FD4065;

	// Token: 0x04000108 RID: 264
	private uint 054059A6;

	// Token: 0x04000109 RID: 265
	private uint 270204F6;

	// Token: 0x0400010A RID: 266
	private uint 67F41B9A;

	// Token: 0x0400010B RID: 267
	private Stream 313A4B4F;

	// Token: 0x0400010C RID: 268
	private uint 66202CB0 = 1U;

	// Token: 0x0400010D RID: 269
	public uint 5D6621C4;
}
