using System;
using System.Runtime.InteropServices;

// Token: 0x02000018 RID: 24
internal static class 10C93EC0
{
	// Token: 0x06000121 RID: 289
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFile", SetLastError = true)]
	public static extern IntPtr 261B2BFA(string 0156656A, int 2B2B0B9C, int 7E193063, IntPtr 6CB32CEE, int 00A92C65, int 47D61F42, IntPtr 4AB2667A);

	// Token: 0x06000122 RID: 290
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFileMapping", SetLastError = true)]
	public static extern IntPtr 777E0ABB(IntPtr 5F4C5D03, IntPtr 05465A79, 10C93EC0.5C873BCC 1A5C5FED, int 74816820, int 159F5EC1, string 0E6D1E62);

	// Token: 0x06000123 RID: 291
	[DllImport("kernel32", EntryPoint = "MapViewOfFile", SetLastError = true)]
	public static extern IntPtr 3C7321E8(IntPtr 1106133D, 10C93EC0.21B67457 79235102, int 7F1E1C4B, int 34332C61, IntPtr 19935079);

	// Token: 0x06000124 RID: 292
	[DllImport("kernel32", EntryPoint = "UnmapViewOfFile", SetLastError = true)]
	public static extern bool 4B392B9C(IntPtr 71463B95);

	// Token: 0x06000125 RID: 293
	[DllImport("kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool 79C11619(IntPtr 1EF414A9);

	// Token: 0x06000126 RID: 294
	[DllImport("kernel32", EntryPoint = "GetFileSize", SetLastError = true)]
	public static extern uint 6EA9565E(IntPtr 600214BA, IntPtr 1DB50B09);

	// Token: 0x06000127 RID: 295
	[DllImport("kernel32", EntryPoint = "VirtualProtect", SetLastError = true)]
	public static extern bool 4C5F02A2(IntPtr 712E1F8D, UIntPtr 707A2E46, 10C93EC0.5C873BCC 55172A37, out 10C93EC0.5C873BCC 4F932CFD);

	// Token: 0x06000128 RID: 296
	[DllImport("kernel32", EntryPoint = "IsDebuggerPresent")]
	public static extern bool 2905367D();

	// Token: 0x06000129 RID: 297
	[DllImport("kernel32", EntryPoint = "CheckRemoteDebuggerPresent")]
	public static extern bool 1BB15A6F();

	// Token: 0x0600012A RID: 298
	[DllImport("ntdll", EntryPoint = "NtQueryInformationProcess")]
	public static extern int 4D9336C1(IntPtr 39324066, int 1BC21973, byte[] 090278A2, uint 46454185, out uint 363C2BDF);

	// Token: 0x040000D2 RID: 210
	public const int 7A1042E2 = -2147483648;

	// Token: 0x040000D3 RID: 211
	public const int 4C2A4B4E = 3;

	// Token: 0x040000D4 RID: 212
	public const int 6A5B2F77 = 128;

	// Token: 0x040000D5 RID: 213
	public const int 524D4879 = 1;

	// Token: 0x040000D6 RID: 214
	public const int 6A5C562B = 2;

	// Token: 0x040000D7 RID: 215
	public static readonly IntPtr 4246438F = new IntPtr(-1);

	// Token: 0x040000D8 RID: 216
	public static readonly IntPtr 325603CD = IntPtr.Zero;

	// Token: 0x040000D9 RID: 217
	public static readonly IntPtr 14F773FC = new IntPtr(-1);

	// Token: 0x0200003F RID: 63
	public enum 5C873BCC : uint
	{
		// Token: 0x04000138 RID: 312
		5B993F8D = 1U,
		// Token: 0x04000139 RID: 313
		55FB0381,
		// Token: 0x0400013A RID: 314
		416C2968 = 4U,
		// Token: 0x0400013B RID: 315
		6CAD4FE6 = 8U,
		// Token: 0x0400013C RID: 316
		0310673D = 16U,
		// Token: 0x0400013D RID: 317
		452841C1 = 32U,
		// Token: 0x0400013E RID: 318
		27D74528 = 64U,
		// Token: 0x0400013F RID: 319
		14EA2B2E = 256U
	}

	// Token: 0x02000040 RID: 64
	public enum 21B67457 : uint
	{
		// Token: 0x04000141 RID: 321
		04ED7418 = 1U,
		// Token: 0x04000142 RID: 322
		6DFE44C7,
		// Token: 0x04000143 RID: 323
		62EA1136 = 4U,
		// Token: 0x04000144 RID: 324
		5BA36E1A = 31U
	}
}
