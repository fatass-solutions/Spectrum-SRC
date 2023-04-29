using System;
using System.IO;

// Token: 0x0200001A RID: 26
public class 69C6414B
{
	// Token: 0x0600012E RID: 302 RVA: 0x0021C8D0 File Offset: 0x0021C8D0
	public 69C6414B()
	{
		this.543E4DC6 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.518A7ECA[num] = new 0BA3433C(6);
			num++;
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0021C9C8 File Offset: 0x0021C9C8
	private void 05ED2627(uint 019D2DE7)
	{
		if (this.543E4DC6 != 019D2DE7)
		{
			this.543E4DC6 = 019D2DE7;
			this.40DA0847 = Math.Max(this.543E4DC6, 1U);
			uint 5FB06F5E = Math.Max(this.40DA0847, 4096U);
			this.3B135A3A.031C7D82(5FB06F5E);
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0021CA18 File Offset: 0x0021CA18
	private void 4C0913DE(int 291271A7, int 7B1840E8)
	{
		if (291271A7 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (7B1840E8 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.4A7F288E.507C0AD6(291271A7, 7B1840E8);
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0021CA4C File Offset: 0x0021CA4C
	private void 685D1D98(int 66007C4E)
	{
		if (66007C4E > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << 66007C4E;
		this.48512081.0DA62033(num);
		this.47E950F4.0DA62033(num);
		this.50EE5761 = num - 1U;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0021CA94 File Offset: 0x0021CA94
	private void 01B43628(Stream 2D13726D, Stream 435235F5)
	{
		this.5CDF634D.39706074(2D13726D);
		this.3B135A3A.25BD01F5(435235F5, false);
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.50EE5761; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this.58E101C2[(int)num3].7BC3162D();
				this.28AE7D9B[(int)num3].7BC3162D();
			}
			this.3DB42BCE[(int)num].7BC3162D();
			this.6AA105F1[(int)num].7BC3162D();
			this.131B5AFA[(int)num].7BC3162D();
			this.4F35012F[(int)num].7BC3162D();
		}
		this.4A7F288E.1C4C460E();
		for (uint num = 0U; num < 4U; num += 1U)
		{
			this.518A7ECA[(int)num].7E462452();
		}
		for (uint num = 0U; num < 114U; num += 1U)
		{
			this.58545284[(int)num].7BC3162D();
		}
		this.48512081.1C7F0FF0();
		this.47E950F4.1C7F0FF0();
		this.0F785646.7E462452();
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0021CBC4 File Offset: 0x0021CBC4
	public void 71E3011B(Stream 15855A21, Stream 05596FBC, long 26E12F3C)
	{
		this.01B43628(15855A21, 05596FBC);
		6C454417.1BCD3A51 1BCD3A = default(6C454417.1BCD3A51);
		1BCD3A.7CCA6E01();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (num5 < (ulong)26E12F3C)
		{
			if (this.58E101C2[(int)((int)1BCD3A.7DA72EE7 << 4)].591B5FFF(this.5CDF634D) != 0U)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			1BCD3A.7869673B();
			byte 337E061B = this.4A7F288E.3F1F5D44(this.5CDF634D, 0U, 0);
			this.3B135A3A.53092D16(337E061B);
			num5 += 1UL;
		}
		while (num5 < (ulong)26E12F3C)
		{
			uint num6 = (uint)num5 & this.50EE5761;
			if (this.58E101C2[(int)((1BCD3A.7DA72EE7 << 4) + num6)].591B5FFF(this.5CDF634D) == 0U)
			{
				byte b = this.3B135A3A.3B144F5C(0U);
				byte 337E061B2;
				if (!1BCD3A.3B975EF3())
				{
					337E061B2 = this.4A7F288E.02D74E49(this.5CDF634D, (uint)num5, b, this.3B135A3A.3B144F5C(num));
				}
				else
				{
					337E061B2 = this.4A7F288E.3F1F5D44(this.5CDF634D, (uint)num5, b);
				}
				this.3B135A3A.53092D16(337E061B2);
				1BCD3A.7869673B();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this.3DB42BCE[(int)1BCD3A.7DA72EE7].591B5FFF(this.5CDF634D) == 1U)
				{
					if (this.6AA105F1[(int)1BCD3A.7DA72EE7].591B5FFF(this.5CDF634D) == 0U)
					{
						if (this.28AE7D9B[(int)((1BCD3A.7DA72EE7 << 4) + num6)].591B5FFF(this.5CDF634D) == 0U)
						{
							1BCD3A.7A4B3DF8();
							this.3B135A3A.53092D16(this.3B135A3A.3B144F5C(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this.131B5AFA[(int)1BCD3A.7DA72EE7].591B5FFF(this.5CDF634D) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this.4F35012F[(int)1BCD3A.7DA72EE7].591B5FFF(this.5CDF634D) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this.47E950F4.300C061F(this.5CDF634D, num6) + 2U;
					1BCD3A.47484599();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this.48512081.300C061F(this.5CDF634D, num6);
					1BCD3A.3814574C();
					uint num9 = this.518A7ECA[(int)6C454417.18D06D45(num8)].76A1148C(this.5CDF634D);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += 0BA3433C.12C61706(this.58545284, num - num9 - 1U, this.5CDF634D, num10);
						}
						else
						{
							num += this.5CDF634D.7B5C1A48(num10 - 4) << 4;
							num += this.0F785646.15B37533(this.5CDF634D);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num >= (ulong)this.3B135A3A.5D6621C4 + num5 || num >= this.40DA0847)
				{
					if (num != 4294967295U)
					{
						throw new InvalidDataException("rep0");
					}
					break;
				}
				else
				{
					this.3B135A3A.6F3321E8(num, num8);
					num5 += (ulong)num8;
				}
			}
		}
		this.3B135A3A.257A4FB1();
		this.3B135A3A.5D037168();
		this.5CDF634D.427D54D6();
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0021CF58 File Offset: 0x0021CF58
	public void 6329490E(byte[] 1ABA60C2)
	{
		if (1ABA60C2.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int 7B1840E = (int)(1ABA60C2[0] % 9);
		byte b = 1ABA60C2[0] / 9;
		int 291271A = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)1ABA60C2[1 + i] << i * 8);
		}
		this.05ED2627(num2);
		this.4C0913DE(291271A, 7B1840E);
		this.685D1D98(num);
	}

	// Token: 0x040000EA RID: 234
	private uint 729858FA = 1U;

	// Token: 0x040000EB RID: 235
	private readonly 09D87DBE 3B135A3A = new 09D87DBE();

	// Token: 0x040000EC RID: 236
	private readonly 2B4220A0 5CDF634D = new 2B4220A0();

	// Token: 0x040000ED RID: 237
	private readonly 1C617FB4[] 58E101C2 = new 1C617FB4[192];

	// Token: 0x040000EE RID: 238
	private readonly 1C617FB4[] 3DB42BCE = new 1C617FB4[12];

	// Token: 0x040000EF RID: 239
	private readonly 1C617FB4[] 6AA105F1 = new 1C617FB4[12];

	// Token: 0x040000F0 RID: 240
	private readonly 1C617FB4[] 131B5AFA = new 1C617FB4[12];

	// Token: 0x040000F1 RID: 241
	private readonly 1C617FB4[] 4F35012F = new 1C617FB4[12];

	// Token: 0x040000F2 RID: 242
	private readonly 1C617FB4[] 28AE7D9B = new 1C617FB4[192];

	// Token: 0x040000F3 RID: 243
	private readonly 0BA3433C[] 518A7ECA = new 0BA3433C[4];

	// Token: 0x040000F4 RID: 244
	private readonly 1C617FB4[] 58545284 = new 1C617FB4[114];

	// Token: 0x040000F5 RID: 245
	private 0BA3433C 0F785646 = new 0BA3433C(4);

	// Token: 0x040000F6 RID: 246
	private readonly 69C6414B.3BFE1764 48512081 = new 69C6414B.3BFE1764();

	// Token: 0x040000F7 RID: 247
	private readonly 69C6414B.3BFE1764 47E950F4 = new 69C6414B.3BFE1764();

	// Token: 0x040000F8 RID: 248
	private readonly 69C6414B.1FD73A7F 4A7F288E = new 69C6414B.1FD73A7F();

	// Token: 0x040000F9 RID: 249
	private uint 543E4DC6;

	// Token: 0x040000FA RID: 250
	private uint 40DA0847;

	// Token: 0x040000FB RID: 251
	private uint 50EE5761;

	// Token: 0x02000042 RID: 66
	private class 3BFE1764
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00222420 File Offset: 0x00222420
		public void 0DA62033(uint 2FA20318)
		{
			for (uint num = this.3564252C; num < 2FA20318; num += 1U)
			{
				this.49D251C5[(int)num] = new 0BA3433C(3);
				this.7E870AA3[(int)num] = new 0BA3433C(3);
			}
			this.3564252C = 2FA20318;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00222470 File Offset: 0x00222470
		public void 1C7F0FF0()
		{
			this.395A5F31.7BC3162D();
			for (uint num = 0U; num < this.3564252C; num += 1U)
			{
				this.49D251C5[(int)num].7E462452();
				this.7E870AA3[(int)num].7E462452();
			}
			this.59FB25E1.7BC3162D();
			this.4E9A2B7E.7E462452();
		}

		// Token: 0x060002CE RID: 718 RVA: 0x002224D8 File Offset: 0x002224D8
		public uint 300C061F(2B4220A0 5F28344D, uint 72CF4FAC)
		{
			if (this.395A5F31.591B5FFF(5F28344D) == 0U)
			{
				return this.49D251C5[(int)72CF4FAC].76A1148C(5F28344D);
			}
			uint num = 8U;
			if (this.59FB25E1.591B5FFF(5F28344D) == 0U)
			{
				num += this.7E870AA3[(int)72CF4FAC].76A1148C(5F28344D);
			}
			else
			{
				num += 8U;
				num += this.4E9A2B7E.76A1148C(5F28344D);
			}
			return num;
		}

		// Token: 0x04000146 RID: 326
		private 1C617FB4 395A5F31;

		// Token: 0x04000147 RID: 327
		private 1C617FB4 59FB25E1;

		// Token: 0x04000148 RID: 328
		private readonly 0BA3433C[] 49D251C5 = new 0BA3433C[16];

		// Token: 0x04000149 RID: 329
		private readonly 0BA3433C[] 7E870AA3 = new 0BA3433C[16];

		// Token: 0x0400014A RID: 330
		private 0BA3433C 4E9A2B7E = new 0BA3433C(8);

		// Token: 0x0400014B RID: 331
		private uint 3564252C;
	}

	// Token: 0x02000043 RID: 67
	private class 1FD73A7F
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x0022257C File Offset: 0x0022257C
		public void 507C0AD6(int 42E07E08, int 68B95F5B)
		{
			if (this.523058B6 != null && this.2C57510A == 68B95F5B && this.44A1437C == 42E07E08)
			{
				return;
			}
			this.44A1437C = 42E07E08;
			this.7DFA1D81 = (1U << 42E07E08) - 1U;
			this.2C57510A = 68B95F5B;
			uint num = 1U << this.2C57510A + this.44A1437C;
			this.523058B6 = new 69C6414B.1FD73A7F.44642EBB[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.523058B6[(int)num2].7D6059A3();
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0022260C File Offset: 0x0022260C
		public void 1C4C460E()
		{
			uint num = 1U << this.2C57510A + this.44A1437C;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.523058B6[(int)num2].58B71A8F();
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00222650 File Offset: 0x00222650
		private uint 0F4D7D2D(uint 75C7283E, byte 41976D85)
		{
			return ((75C7283E & this.7DFA1D81) << this.2C57510A) + (uint)(41976D85 >> 8 - this.2C57510A);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00222674 File Offset: 0x00222674
		public byte 3F1F5D44(2B4220A0 233D313B, uint 26BE20EF, byte 369E6B7C)
		{
			return this.523058B6[(int)this.0F4D7D2D(26BE20EF, 369E6B7C)].67BE183E(233D313B);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00222690 File Offset: 0x00222690
		public byte 02D74E49(2B4220A0 230B1217, uint 7B3E7698, byte 13093968, byte 1DAA4B74)
		{
			return this.523058B6[(int)this.0F4D7D2D(7B3E7698, 13093968)].0E076883(230B1217, 1DAA4B74);
		}

		// Token: 0x0400014C RID: 332
		private uint 50597D0F = 1U;

		// Token: 0x0400014D RID: 333
		private 69C6414B.1FD73A7F.44642EBB[] 523058B6;

		// Token: 0x0400014E RID: 334
		private int 2C57510A;

		// Token: 0x0400014F RID: 335
		private int 44A1437C;

		// Token: 0x04000150 RID: 336
		private uint 7DFA1D81;

		// Token: 0x02000044 RID: 68
		private struct 44642EBB
		{
			// Token: 0x060002D6 RID: 726 RVA: 0x002226C0 File Offset: 0x002226C0
			public void 7D6059A3()
			{
				this.3C5B2FC8 = new 1C617FB4[768];
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x002226D4 File Offset: 0x002226D4
			public void 58B71A8F()
			{
				for (int i = 0; i < 768; i++)
				{
					this.3C5B2FC8[i].7BC3162D();
				}
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00222708 File Offset: 0x00222708
			public byte 67BE183E(2B4220A0 707D7175)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.3C5B2FC8[(int)num].591B5FFF(707D7175));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x0022273C File Offset: 0x0022273C
			public byte 0E076883(2B4220A0 464B193D, byte 61F76145)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(61F76145 >> 7 & 1);
					61F76145 = (byte)(61F76145 << 1);
					uint num3 = this.3C5B2FC8[(int)((1U + num2 << 8) + num)].591B5FFF(464B193D);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_6B;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.3C5B2FC8[(int)num].591B5FFF(464B193D));
				}
				IL_6B:
				return (byte)num;
			}

			// Token: 0x04000151 RID: 337
			private 1C617FB4[] 3C5B2FC8;
		}
	}
}
