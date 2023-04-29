using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x02000010 RID: 16
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000A3B4 File Offset: 0x0000A3B4
		private static string CultureToString(CultureInfo culture)
		{
			if (culture == null)
			{
				return "";
			}
			return culture.Name;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000A3C8 File Offset: 0x0000A3C8
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Assembly[] assemblies = currentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000A438 File Offset: 0x0000A438
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000A46C File Offset: 0x0000A46C
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (fullName.EndsWith(".compressed"))
			{
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						MemoryStream memoryStream = new MemoryStream();
						AssemblyLoader.CopyTo(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						return memoryStream;
					}
				}
			}
			return executingAssembly.GetManifestResourceStream(fullName);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000A4F0 File Offset: 0x0000A4F0
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return AssemblyLoader.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000A510 File Offset: 0x0000A510
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000A538 File Offset: 0x0000A538
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = requestedAssemblyName.CultureInfo.Name + "." + text;
			}
			byte[] rawAssembly;
			using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = AssemblyLoader.ReadStream(stream);
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000A5F8 File Offset: 0x0000A5F8
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = AssemblyLoader.nullCacheLock;
			lock (obj)
			{
				if (AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
			if (assembly == null)
			{
				object obj2 = AssemblyLoader.nullCacheLock;
				lock (obj2)
				{
					AssemblyLoader.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000A6D0 File Offset: 0x0000A6D0
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoader()
		{
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.symbolNames.Add("costura", "costura.costura.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("discordmessenger", "costura.discordmessenger.dll.compressed");
			AssemblyLoader.assemblyNames.Add("discordrpc", "costura.discordrpc.dll.compressed");
			AssemblyLoader.symbolNames.Add("discordrpc", "costura.discordrpc.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.bcl.asyncinterfaces", "costura.microsoft.bcl.asyncinterfaces.dll.compressed");
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("penet.asn1", "costura.penet.asn1.dll.compressed");
			AssemblyLoader.assemblyNames.Add("penet", "costura.penet.dll.compressed");
			AssemblyLoader.assemblyNames.Add("reloaded.memory", "costura.reloaded.memory.dll.compressed");
			AssemblyLoader.assemblyNames.Add("restsharp", "costura.restsharp.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.buffers", "costura.system.buffers.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.memory", "costura.system.memory.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.pkcs", "costura.system.security.cryptography.pkcs.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.text.encodings.web", "costura.system.text.encodings.web.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.text.json", "costura.system.text.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.threading.tasks.extensions", "costura.system.threading.tasks.extensions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.valuetuple", "costura.system.valuetuple.dll.compressed");
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000A8AC File Offset: 0x0000A8AC
		public static void Attach()
		{
			if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
		}

		// Token: 0x040000B8 RID: 184
		private static object nullCacheLock = new object();

		// Token: 0x040000B9 RID: 185
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x040000BA RID: 186
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x040000BB RID: 187
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x040000BC RID: 188
		private static int isAttached;
	}
}
