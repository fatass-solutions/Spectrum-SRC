using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000017 RID: 23
public class 66026065
{
	// Token: 0x060000AE RID: 174 RVA: 0x0020E504 File Offset: 0x0020E504
	public 66026065()
	{
		for (;;)
		{
			IL_00:
			uint num = 938559904U;
			Dictionary<uint, 66026065.0C3B5530> dictionary = new Dictionary<uint, 66026065.0C3B5530>();
			num -= 205618637U;
			this.055920A9 = dictionary;
			for (;;)
			{
				IL_19:
				num = 571684195U >> (int)num;
				RuntimeTypeHandle handle = typeof(66026065).TypeHandle;
				num /= 71243272U;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num = (1057624551U ^ num);
				this.702D7276 = typeFromHandle.Module;
				if (num + 1281115638U == 0U)
				{
					goto IL_00;
				}
				for (;;)
				{
					IL_58:
					Stack<66026065.61781FE7> stack = new Stack<66026065.61781FE7>();
					num -= 882798897U;
					this.307C15CA = stack;
					for (;;)
					{
						IL_6B:
						num -= 1000682438U;
						List<66026065.28060A8C> list = new List<66026065.28060A8C>();
						num = 648359425U >> (int)num;
						this.56F9446E = list;
						for (;;)
						{
							IL_8C:
							this.13F94EC7 = new List<66026065.4AB007C7>();
							num |= 1322927943U;
							for (;;)
							{
								IL_9F:
								num = 422717497U / num;
								this.0E7C79AF = new Stack<66026065.4AB007C7>();
								num = (1710380854U & num);
								num += 172254216U;
								Stack<int> stack2 = new Stack<int>();
								num |= 85204183U;
								this.090E383D = stack2;
								num = (1096236353U ^ num);
								for (;;)
								{
									num = (659904750U & num);
									this.76E63DDD = new List<IntPtr>();
									num /= 1207726860U;
									if (num >= 1826767092U)
									{
										goto IL_58;
									}
									base..ctor();
									if (1435835204U * num != 0U)
									{
										goto IL_00;
									}
									num %= 1125678148U;
									Module m = this.702D7276;
									num = 1614643108U << (int)num;
									IntPtr hinstance = Marshal.GetHINSTANCE(m);
									num = 842207699U + num;
									this.598B592D = hinstance.ToInt64();
									if (num << 31 == 0U)
									{
										goto IL_6B;
									}
									num %= 6561854U;
									Dictionary<uint, 66026065.0C3B5530> dictionary2 = this.055920A9;
									uint key = num ^ 2717411U;
									num = (557610961U | num);
									IntPtr 2CF47CC = ldftn(6DE91C9C);
									num = (1262580645U ^ num);
									dictionary2[key] = new 66026065.0C3B5530(this, 2CF47CC);
									num = 426604993U / num;
									for (;;)
									{
										Dictionary<uint, 66026065.0C3B5530> dictionary3 = this.055920A9;
										num *= 1629034561U;
										uint key2 = num ^ 1U;
										num |= 1706369503U;
										66026065.0C3B5530 value = new 66026065.0C3B5530(this.6BD9278B);
										num *= 1464483264U;
										dictionary3[key2] = value;
										Dictionary<uint, 66026065.0C3B5530> dictionary4 = this.055920A9;
										num = (463604974U & num);
										uint key3 = num - 2099262U;
										num -= 500702831U;
										num /= 1987007693U;
										dictionary4[key3] = new 66026065.0C3B5530(this.275538A7);
										if (983179803U == num)
										{
											goto IL_00;
										}
										num = 873595331U - num;
										Dictionary<uint, 66026065.0C3B5530> dictionary5 = this.055920A9;
										num >>= 23;
										dictionary5[num - 101U] = new 66026065.0C3B5530(this.691027FC);
										num >>= 19;
										num ^= 1786381256U;
										Dictionary<uint, 66026065.0C3B5530> dictionary6 = this.055920A9;
										num = 1971337466U + num;
										uint key4 = num ^ 3757718726U;
										66026065.0C3B5530 value2 = new 66026065.0C3B5530(this.323A0BD0);
										num = 1460029955U << (int)num;
										dictionary6[key4] = value2;
										if (num <= 1461616207U)
										{
											goto IL_00;
										}
										num = 1382350896U >> (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary7 = this.055920A9;
										num |= 254608313U;
										uint key5 = num ^ 254617596U;
										num >>= 9;
										dictionary7[key5] = new 66026065.0C3B5530(this.59FF2598);
										Dictionary<uint, 66026065.0C3B5530> dictionary8 = this.055920A9;
										uint key6 = num ^ 497301U;
										num &= 201276715U;
										66026065.0C3B5530 value3 = new 66026065.0C3B5530(this.49D93ADC);
										num %= 784605431U;
										dictionary8[key6] = value3;
										if (2129863007 << (int)num == 0)
										{
											goto IL_00;
										}
										num = (1955079201U & num);
										Dictionary<uint, 66026065.0C3B5530> dictionary9 = this.055920A9;
										num = (1742747772U & num);
										dictionary9[num - 4294967289U] = new 66026065.0C3B5530(this.2594292F);
										num = 1202200994U * num;
										Dictionary<uint, 66026065.0C3B5530> dictionary10 = this.055920A9;
										uint key7 = num - 4294967288U;
										IntPtr 2CF47CC2 = ldftn(79934CC2);
										num = 1551185419U + num;
										66026065.0C3B5530 value4 = new 66026065.0C3B5530(this, 2CF47CC2);
										num /= 1197500038U;
										dictionary10[key7] = value4;
										num = 573844898U % num;
										Dictionary<uint, 66026065.0C3B5530> dictionary11 = this.055920A9;
										num -= 646977835U;
										uint key8 = num - 3647989452U;
										num = 2056549101U + num;
										IntPtr 2CF47CC3 = ldftn(23C10A1A);
										num = (895096951U & num);
										dictionary11[key8] = new 66026065.0C3B5530(this, 2CF47CC3);
										num -= 477051464U;
										Dictionary<uint, 66026065.0C3B5530> dictionary12 = this.055920A9;
										num = 993867320U - num;
										uint key9 = num ^ 1135368244U;
										num = (846865791U & num);
										num = (1916674643U & num);
										66026065.0C3B5530 value5 = new 66026065.0C3B5530(this.64CD587C);
										num = 411510586U + num;
										dictionary12[key9] = value5;
										Dictionary<uint, 66026065.0C3B5530> dictionary13 = this.055920A9;
										num = (999034193U | num);
										uint key10 = num - 1001336658U;
										num *= 1531213716U;
										IntPtr 2CF47CC4 = ldftn(7941752A);
										num = 28845276U + num;
										dictionary13[key10] = new 66026065.0C3B5530(this, 2CF47CC4);
										if (135026784U > num)
										{
											goto IL_19;
										}
										num = 264787837U >> (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary14 = this.055920A9;
										num |= 845029257U;
										uint key11 = num - 1071538161U;
										num = 2106293604U - num;
										IntPtr 2CF47CC5 = ldftn(404D17BA);
										num = (1927156396U ^ num);
										66026065.0C3B5530 value6 = new 66026065.0C3B5530(this, 2CF47CC5);
										num &= 198930438U;
										dictionary14[key11] = value6;
										num >>= 26;
										if (642018465U * num == 0U)
										{
											goto IL_00;
										}
										num = (498294089U & num);
										Dictionary<uint, 66026065.0C3B5530> dictionary15 = this.055920A9;
										num = 578899276U * num;
										dictionary15[num - 4294967283U] = new 66026065.0C3B5530(this.25447764);
										if (831548930U < num)
										{
											goto IL_19;
										}
										num = 1186270487U - num;
										Dictionary<uint, 66026065.0C3B5530> dictionary16 = this.055920A9;
										uint key12 = num + 3108696823U;
										num = 316411140U - num;
										66026065.0C3B5530 value7 = new 66026065.0C3B5530(this.2A45676B);
										num = 462432379U % num;
										dictionary16[key12] = value7;
										Dictionary<uint, 66026065.0C3B5530> dictionary17 = this.055920A9;
										uint key13 = num + 3832534932U;
										num &= 1975849434U;
										dictionary17[key13] = new 66026065.0C3B5530(this.0C0C742D);
										num >>= 1;
										if (1558187952U + num == 0U)
										{
											goto IL_00;
										}
										num = (1287068948U ^ num);
										Dictionary<uint, 66026065.0C3B5530> dictionary18 = this.055920A9;
										uint key14 = num ^ 1148656937U;
										num += 1188702649U;
										num = (1755148078U ^ num);
										IntPtr 2CF47CC6 = ldftn(40CA5737);
										num <<= 4;
										dictionary18[key14] = new 66026065.0C3B5530(this, 2CF47CC6);
										num /= 1545557363U;
										Dictionary<uint, 66026065.0C3B5530> dictionary19 = this.055920A9;
										num &= 1452366539U;
										uint key15 = num - 4294967279U;
										num *= 2040928843U;
										66026065.0C3B5530 value8 = new 66026065.0C3B5530(this.1D1E768B);
										num /= 2134642572U;
										dictionary19[key15] = value8;
										if (num << 11 != 0U)
										{
											goto IL_00;
										}
										num = (1214121567U | num);
										Dictionary<uint, 66026065.0C3B5530> dictionary20 = this.055920A9;
										uint key16 = num - 1214121549U;
										num -= 148572652U;
										num >>= 26;
										dictionary20[key16] = new 66026065.0C3B5530(this.3B97341D);
										num = 466048877U / num;
										if (num <= 14812966U)
										{
											goto IL_19;
										}
										num = 1451314556U * num;
										Dictionary<uint, 66026065.0C3B5530> dictionary21 = this.055920A9;
										num <<= 20;
										uint key17 = num ^ 2126512147U;
										num %= 544489669U;
										dictionary21[key17] = new 66026065.0C3B5530(this.48124C6C);
										if (469917230U > num)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary22 = this.055920A9;
										uint key18 = num + 3801924195U;
										num &= 1415323712U;
										dictionary22[key18] = new 66026065.0C3B5530(this.3C253D76);
										num /= 1479440774U;
										num %= 2050843172U;
										Dictionary<uint, 66026065.0C3B5530> dictionary23 = this.055920A9;
										uint key19 = num ^ 21U;
										num = 1393565783U << (int)num;
										num /= 120998446U;
										IntPtr 2CF47CC7 = ldftn(2A805746);
										num %= 453712588U;
										dictionary23[key19] = new 66026065.0C3B5530(this, 2CF47CC7);
										if ((753402091U ^ num) == 0U)
										{
											goto IL_58;
										}
										num /= 434263369U;
										Dictionary<uint, 66026065.0C3B5530> dictionary24 = this.055920A9;
										uint key20 = num - 4294967274U;
										IntPtr 2CF47CC8 = ldftn(6F161163);
										num <<= 16;
										dictionary24[key20] = new 66026065.0C3B5530(this, 2CF47CC8);
										num <<= 7;
										if (695556855U + num == 0U)
										{
											goto IL_00;
										}
										num = (422932230U & num);
										Dictionary<uint, 66026065.0C3B5530> dictionary25 = this.055920A9;
										uint key21 = num ^ 23U;
										num = 1555197391U + num;
										66026065.0C3B5530 value9 = new 66026065.0C3B5530(this.02D44669);
										num &= 1268469427U;
										dictionary25[key21] = value9;
										num = 201486041U / num;
										Dictionary<uint, 66026065.0C3B5530> dictionary26 = this.055920A9;
										num = 2009538758U >> (int)num;
										uint key22 = num ^ 2009538782U;
										num <<= 30;
										num = 846604782U - num;
										IntPtr 2CF47CC9 = ldftn(206F69E1);
										num = 1156384510U - num;
										dictionary26[key22] = new 66026065.0C3B5530(this, 2CF47CC9);
										if (140456667U == num)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary27 = this.055920A9;
										uint key23 = num + 1837703945U;
										num = (915476255U & num);
										num -= 1967420553U;
										dictionary27[key23] = new 66026065.0C3B5530(this.4615361D);
										num /= 2003724513U;
										num &= 1229217493U;
										Dictionary<uint, 66026065.0C3B5530> dictionary28 = this.055920A9;
										uint key24 = num ^ 27U;
										num *= 372837568U;
										IntPtr 2CF47CC10 = ldftn(12B02CA4);
										num ^= 909644812U;
										66026065.0C3B5530 value10 = new 66026065.0C3B5530(this, 2CF47CC10);
										num = 2063235202U % num;
										dictionary28[key24] = value10;
										num = 2087747451U % num;
										this.055920A9[num - 278120168U] = new 66026065.0C3B5530(this.4BFD4FC2);
										num %= 526524863U;
										if (num > 915738113U)
										{
											goto IL_8C;
										}
										num = 2065516034U * num;
										Dictionary<uint, 66026065.0C3B5530> dictionary29 = this.055920A9;
										uint key25 = num - 2246664170U;
										num <<= 6;
										66026065.0C3B5530 value11 = new 66026065.0C3B5530(this.05C85C40);
										num *= 2001099005U;
										dictionary29[key25] = value11;
										if (1007184814U < num)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary30 = this.055920A9;
										uint key26 = num ^ 310213533U;
										num <<= 12;
										IntPtr 2CF47CC11 = ldftn(08E24F7E);
										num = 1868060242U % num;
										dictionary30[key26] = new 66026065.0C3B5530(this, 2CF47CC11);
										num = (43130019U | num);
										Dictionary<uint, 66026065.0C3B5530> dictionary31 = this.055920A9;
										uint key27 = num - 1876582101U;
										num = (325727816U & num);
										num = (772110000U & num);
										IntPtr 2CF47CC12 = ldftn(79F53BF5);
										num ^= 1619414654U;
										66026065.0C3B5530 value12 = new 66026065.0C3B5530(this, 2CF47CC12);
										num += 816385272U;
										dictionary31[key27] = value12;
										num <<= 7;
										if (num <= 2031379001U)
										{
											goto IL_00;
										}
										num = 1662653979U << (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary32 = this.055920A9;
										uint key28 = num + 2632313348U;
										66026065.0C3B5530 value13 = new 66026065.0C3B5530(this.45226D21);
										num = 1507142944U % num;
										dictionary32[key28] = value13;
										num %= 2139426500U;
										num %= 393311595U;
										this.055920A9[num - 327208127U] = new 66026065.0C3B5530(this.3B3E7A40);
										num = (2121534482U | num);
										if ((num & 439306335U) == 0U)
										{
											goto IL_9F;
										}
										num = 2039942515U + num;
										Dictionary<uint, 66026065.0C3B5530> dictionary33 = this.055920A9;
										uint key29 = num ^ 4186692211U;
										num <<= 20;
										66026065.0C3B5530 value14 = new 66026065.0C3B5530(this.69424041);
										num %= 531458360U;
										dictionary33[key29] = value14;
										num &= 1119054159U;
										if (596788445U >> (int)num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary34 = this.055920A9;
										num = 1924401102U << (int)num;
										dictionary34[num ^ 3020410402U] = new 66026065.0C3B5530(this.54512335);
										num = 99444859U >> (int)num;
										if (2116692409U + num == 0U)
										{
											goto IL_00;
										}
										this.055920A9[num ^ 99444824U] = new 66026065.0C3B5530(this.40FE152F);
										if (num >= 329869556U)
										{
											goto IL_6B;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary35 = this.055920A9;
										uint key30 = num + 4195522473U;
										num -= 1201349325U;
										IntPtr 2CF47CC13 = ldftn(1FCF54CB);
										num += 1608929287U;
										66026065.0C3B5530 value15 = new 66026065.0C3B5530(this, 2CF47CC13);
										num = 1554152215U << (int)num;
										dictionary35[key30] = value15;
										num = 94637955U >> (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary36 = this.055920A9;
										num = 988752158U / num;
										uint key31 = num - 4294967269U;
										IntPtr 2CF47CC14 = ldftn(1CB93A76);
										num &= 505431480U;
										dictionary36[key31] = new 66026065.0C3B5530(this, 2CF47CC14);
										Dictionary<uint, 66026065.0C3B5530> dictionary37 = this.055920A9;
										uint key32 = num + 30U;
										num = (569276442U ^ num);
										IntPtr 2CF47CC15 = ldftn(26433BD5);
										num = (1299124173U ^ num);
										dictionary37[key32] = new 66026065.0C3B5530(this, 2CF47CC15);
										num *= 334766117U;
										if (1969961179U > num)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary38 = this.055920A9;
										uint key33 = num ^ 2872980252U;
										num *= 1759271244U;
										66026065.0C3B5530 value16 = new 66026065.0C3B5530(this.00F80003);
										num = 1064926052U % num;
										dictionary38[key33] = value16;
										num &= 1317944692U;
										if ((1912671932U ^ num) == 0U)
										{
											goto IL_00;
										}
										num ^= 464397566U;
										Dictionary<uint, 66026065.0C3B5530> dictionary39 = this.055920A9;
										num /= 1076061225U;
										uint key34 = num ^ 40U;
										66026065.0C3B5530 value17 = new 66026065.0C3B5530(this.46B61CF0);
										num = 1306487442U >> (int)num;
										dictionary39[key34] = value17;
										num >>= 19;
										Dictionary<uint, 66026065.0C3B5530> dictionary40 = this.055920A9;
										num = 1413840387U % num;
										uint key35 = num ^ 1123U;
										num ^= 1025857466U;
										dictionary40[key35] = new 66026065.0C3B5530(this.54113550);
										if (num * 477177039U == 0U)
										{
											goto IL_00;
										}
										num = 175653865U % num;
										Dictionary<uint, 66026065.0C3B5530> dictionary41 = this.055920A9;
										num /= 866470328U;
										uint key36 = num - 4294967254U;
										num /= 903155990U;
										66026065.0C3B5530 value18 = new 66026065.0C3B5530(this.221A32C2);
										num <<= 20;
										dictionary41[key36] = value18;
										if ((num ^ 1655911615U) == 0U)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary42 = this.055920A9;
										num = (1022956859U & num);
										uint key37 = num + 43U;
										IntPtr 2CF47CC16 = ldftn(223C114D);
										num |= 2090468811U;
										dictionary42[key37] = new 66026065.0C3B5530(this, 2CF47CC16);
										num &= 1603280270U;
										if ((1552962321U ^ num) == 0U)
										{
											goto IL_19;
										}
										num |= 624234804U;
										Dictionary<uint, 66026065.0C3B5530> dictionary43 = this.055920A9;
										num = 1490296180U - num;
										uint key38 = num - 3676243850U;
										num = 272893477U + num;
										num += 135153704U;
										IntPtr 2CF47CC17 = ldftn(04EC591A);
										num |= 16999314U;
										dictionary43[key38] = new 66026065.0C3B5530(this, 2CF47CC17);
										Dictionary<uint, 66026065.0C3B5530> dictionary44 = this.055920A9;
										num = (32264145U | num);
										uint key39 = num ^ 4093607934U;
										num += 1569288095U;
										num = 2095398788U / num;
										IntPtr 2CF47CC18 = ldftn(31250CEC);
										num = 1670937913U >> (int)num;
										dictionary44[key39] = new 66026065.0C3B5530(this, 2CF47CC18);
										num = (571358335U | num);
										if (466700439U >= num)
										{
											goto IL_58;
										}
										num >>= 8;
										Dictionary<uint, 66026065.0C3B5530> dictionary45 = this.055920A9;
										num |= 1834091154U;
										uint key40 = num - 1836306064U;
										num <<= 0;
										num = 1792349390U / num;
										dictionary45[key40] = new 66026065.0C3B5530(this.01BF051F);
										if ((2058162371U ^ num) == 0U)
										{
											goto IL_58;
										}
										num = (1829052918U ^ num);
										this.055920A9[num - 1829052871U] = new 66026065.0C3B5530(this.1A5D4861);
										Dictionary<uint, 66026065.0C3B5530> dictionary46 = this.055920A9;
										num += 1415936002U;
										uint key41 = num ^ 3244988872U;
										num += 1954621567U;
										num = 1594769324U / num;
										IntPtr 2CF47CC19 = ldftn(35681A3C);
										num = 1409623072U << (int)num;
										dictionary46[key41] = new 66026065.0C3B5530(this, 2CF47CC19);
										Dictionary<uint, 66026065.0C3B5530> dictionary47 = this.055920A9;
										num %= 1860856248U;
										uint key42 = num ^ 958389945U;
										num -= 999648904U;
										num >>= 15;
										IntPtr 2CF47CC20 = ldftn(001449A9);
										num *= 1753624372U;
										dictionary47[key42] = new 66026065.0C3B5530(this, 2CF47CC20);
										num = 1476022106U - num;
										if (num < 1069115269U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary48 = this.055920A9;
										num = (586505100U | num);
										uint key43 = num ^ 1861745660U;
										num = 1390567258U * num;
										IntPtr 2CF47CC21 = ldftn(208C0F82);
										num = 963601850U << (int)num;
										dictionary48[key43] = new 66026065.0C3B5530(this, 2CF47CC21);
										num = (1059941207U ^ num);
										num >>= 0;
										Dictionary<uint, 66026065.0C3B5530> dictionary49 = this.055920A9;
										num <<= 22;
										uint key44 = num - 3586129869U;
										num = (277092367U | num);
										IntPtr 2CF47CC22 = ldftn(776D5E01);
										num = 1676371311U * num;
										dictionary49[key44] = new 66026065.0C3B5530(this, 2CF47CC22);
										if (337341385U / num != 0U)
										{
											goto IL_58;
										}
										num &= 934098222U;
										Dictionary<uint, 66026065.0C3B5530> dictionary50 = this.055920A9;
										num = (1504069792U | num);
										uint key45 = num ^ 2041534868U;
										num = 1133992555U - num;
										num <<= 27;
										IntPtr 2CF47CC23 = ldftn(75DE753B);
										num = (516830416U | num);
										dictionary50[key45] = new 66026065.0C3B5530(this, 2CF47CC23);
										num %= 1046903084U;
										if (114581229U >= num)
										{
											break;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary51 = this.055920A9;
										uint key46 = num - 543669103U;
										num -= 1341029679U;
										num >>= 7;
										66026065.0C3B5530 value19 = new 66026065.0C3B5530(this.4D52134C);
										num = 1449880337U + num;
										dictionary51[key46] = value19;
										num >>= 31;
										if (num == 819288289U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary52 = this.055920A9;
										num %= 604061066U;
										uint key47 = num - 4294967242U;
										num = 1232026474U - num;
										num = 1570465904U >> (int)num;
										IntPtr 2CF47CC24 = ldftn(37AD0EB6);
										num %= 306057719U;
										66026065.0C3B5530 value20 = new 66026065.0C3B5530(this, 2CF47CC24);
										num ^= 617771535U;
										dictionary52[key47] = value20;
										num -= 161752240U;
										Dictionary<uint, 66026065.0C3B5530> dictionary53 = this.055920A9;
										num <<= 19;
										uint key48 = num - 2166882249U;
										num = 160962804U / num;
										66026065.0C3B5530 value21 = new 66026065.0C3B5530(this.08A07361);
										num -= 629175439U;
										dictionary53[key48] = value21;
										num = 1857385324U * num;
										Dictionary<uint, 66026065.0C3B5530> dictionary54 = this.055920A9;
										num >>= 1;
										uint key49 = num + 2966697186U;
										num = 6843970U % num;
										num <<= 23;
										IntPtr 2CF47CC25 = ldftn(4A20612E);
										num |= 237981699U;
										dictionary54[key49] = new 66026065.0C3B5530(this, 2CF47CC25);
										num = (2012098954U & num);
										num = (526132043U | num);
										Dictionary<uint, 66026065.0C3B5530> dictionary55 = this.055920A9;
										uint key50 = num - 1065235218U;
										num = 1202737063U + num;
										num = 1781532756U >> (int)num;
										IntPtr 2CF47CC26 = ldftn(014828E5);
										num &= 636047578U;
										66026065.0C3B5530 value22 = new 66026065.0C3B5530(this, 2CF47CC26);
										num = (198053086U & num);
										dictionary55[key50] = value22;
										num = (1404582745U | num);
										if (478817453U + num == 0U)
										{
											goto IL_6B;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary56 = this.055920A9;
										num /= 820530337U;
										uint key51 = num ^ 59U;
										num = (911606414U | num);
										IntPtr 2CF47CC27 = ldftn(670D172B);
										num = 1592138078U % num;
										66026065.0C3B5530 value23 = new 66026065.0C3B5530(this, 2CF47CC27);
										num |= 179060466U;
										dictionary56[key51] = value23;
										if (num < 328222307U)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary57 = this.055920A9;
										uint key52 = num + 3577987388U;
										IntPtr 2CF47CC28 = ldftn(249B4E53);
										num = 443112188U << (int)num;
										66026065.0C3B5530 value24 = new 66026065.0C3B5530(this, 2CF47CC28);
										num = 1464167344U * num;
										dictionary57[key52] = value24;
										num = (2085360253U ^ num);
										Dictionary<uint, 66026065.0C3B5530> dictionary58 = this.055920A9;
										uint key53 = num ^ 2085360193U;
										IntPtr 2CF47CC29 = ldftn(24954D38);
										num &= 1187583009U;
										66026065.0C3B5530 value25 = new 66026065.0C3B5530(this, 2CF47CC29);
										num = 1613044912U + num;
										dictionary58[key53] = value25;
										num = 942241721U << (int)num;
										if (1927550355U > num)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary59 = this.055920A9;
										uint key54 = num ^ 4017225789U;
										num = 1367935094U << (int)num;
										IntPtr 2CF47CC30 = ldftn(53A46177);
										num <<= 9;
										dictionary59[key54] = new 66026065.0C3B5530(this, 2CF47CC30);
										Dictionary<uint, 66026065.0C3B5530> dictionary60 = this.055920A9;
										uint key55 = num + 3991868478U;
										IntPtr 2CF47CC31 = ldftn(6DDD234F);
										num = 1178087294U + num;
										66026065.0C3B5530 value26 = new 66026065.0C3B5530(this, 2CF47CC31);
										num = 298730266U - num;
										dictionary60[key55] = value26;
										num = 294280551U / num;
										Dictionary<uint, 66026065.0C3B5530> dictionary61 = this.055920A9;
										num &= 229403806U;
										uint key56 = num ^ 63U;
										num = 1436430211U + num;
										num = 303775101U + num;
										IntPtr 2CF47CC32 = ldftn(7E2B001C);
										num >>= 5;
										dictionary61[key56] = new 66026065.0C3B5530(this, 2CF47CC32);
										if (num >= 1441018682U)
										{
											goto IL_8C;
										}
										num += 1928546749U;
										Dictionary<uint, 66026065.0C3B5530> dictionary62 = this.055920A9;
										uint key57 = num ^ 1982928229U;
										num = (890404766U ^ num);
										66026065.0C3B5530 value27 = new 66026065.0C3B5530(this.5FBA647E);
										num >>= 19;
										dictionary62[key57] = value27;
										num <<= 7;
										if (num * 1233331280U == 0U)
										{
											goto IL_19;
										}
										num |= 718234222U;
										Dictionary<uint, 66026065.0C3B5530> dictionary63 = this.055920A9;
										num = (703025491U & num);
										uint key58 = num - 684150785U;
										num &= 1024809672U;
										IntPtr 2CF47CC33 = ldftn(33F20CDA);
										num |= 909772986U;
										66026065.0C3B5530 value28 = new 66026065.0C3B5530(this, 2CF47CC33);
										num = 1277366373U % num;
										dictionary63[key58] = value28;
										num = 1356292655U + num;
										if (676883276U == num)
										{
											goto IL_19;
										}
										num = 758396470U * num;
										Dictionary<uint, 66026065.0C3B5530> dictionary64 = this.055920A9;
										uint key59 = num + 1205476806U;
										IntPtr 2CF47CC34 = ldftn(0FD22F07);
										num = 1734619474U - num;
										66026065.0C3B5530 value29 = new 66026065.0C3B5530(this, 2CF47CC34);
										num = (1857166693U | num);
										dictionary64[key59] = value29;
										num = 1403928050U - num;
										num = 547048112U / num;
										Dictionary<uint, 66026065.0C3B5530> dictionary65 = this.055920A9;
										num = 681652392U - num;
										uint key60 = num ^ 681652459U;
										num = 1549237616U + num;
										IntPtr 2CF47CC35 = ldftn(2BB71427);
										num += 1577722520U;
										dictionary65[key60] = new 66026065.0C3B5530(this, 2CF47CC35);
										num %= 968259722U;
										if (1646659079U * num == 0U)
										{
											goto IL_8C;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary66 = this.055920A9;
										num = 952592420U >> (int)num;
										uint key61 = num ^ 3701U;
										num >>= 15;
										num >>= 2;
										IntPtr 2CF47CC36 = ldftn(488A5C27);
										num %= 1488089738U;
										dictionary66[key61] = new 66026065.0C3B5530(this, 2CF47CC36);
										Dictionary<uint, 66026065.0C3B5530> dictionary67 = this.055920A9;
										uint key62 = num - 4294967227U;
										num = (1707284096U & num);
										num = 2077245722U + num;
										dictionary67[key62] = new 66026065.0C3B5530(this.0F757978);
										num = 1429165033U / num;
										if ((num & 2129908U) != 0U)
										{
											goto IL_00;
										}
										num ^= 1609775491U;
										Dictionary<uint, 66026065.0C3B5530> dictionary68 = this.055920A9;
										num >>= 27;
										uint key63 = num - 4294967237U;
										num = 1313865815U / num;
										num = 1879402571U * num;
										dictionary68[key63] = new 66026065.0C3B5530(this.1A1D0650);
										Dictionary<uint, 66026065.0C3B5530> dictionary69 = this.055920A9;
										uint key64 = num - 2567043719U;
										num *= 1145906355U;
										num |= 472006462U;
										IntPtr 2CF47CC37 = ldftn(0DE6198B);
										num ^= 48064443U;
										66026065.0C3B5530 value30 = new 66026065.0C3B5530(this, 2CF47CC37);
										num = 1321682382U + num;
										dictionary69[key64] = value30;
										if (737292034U == num)
										{
											goto IL_19;
										}
										num = 1643988230U * num;
										Dictionary<uint, 66026065.0C3B5530> dictionary70 = this.055920A9;
										num = 1769228749U / num;
										dictionary70[num - 4294967224U] = new 66026065.0C3B5530(this.22DE4DC2);
										Dictionary<uint, 66026065.0C3B5530> dictionary71 = this.055920A9;
										uint key65 = num - 4294967223U;
										num = (1077636717U ^ num);
										num <<= 5;
										IntPtr 2CF47CC38 = ldftn(49FE4D46);
										num >>= 14;
										66026065.0C3B5530 value31 = new 66026065.0C3B5530(this, 2CF47CC38);
										num += 1512400152U;
										dictionary71[key65] = value31;
										num -= 1468150456U;
										if (num / 1133929254U != 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary72 = this.055920A9;
										uint key66 = num + 4250710067U;
										num = (1707409596U | num);
										IntPtr 2CF47CC39 = ldftn(78783A8F);
										num -= 1643643084U;
										dictionary72[key66] = new 66026065.0C3B5530(this, 2CF47CC39);
										num |= 1159727074U;
										if (1146498782U >= num)
										{
											goto IL_19;
										}
										num = 1242060243U + num;
										Dictionary<uint, 66026065.0C3B5530> dictionary73 = this.055920A9;
										num = (2141004689U & num);
										uint key67 = num + 4033535691U;
										num = 1381396745U - num;
										IntPtr 2CF47CC40 = ldftn(02C01D9C);
										num = (40121485U & num);
										66026065.0C3B5530 value32 = new 66026065.0C3B5530(this, 2CF47CC40);
										num = 2056669011U * num;
										dictionary73[key67] = value32;
										num = 260321435U / num;
										if (num == 451176382U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary74 = this.055920A9;
										uint key68 = num + 76U;
										num = (594837230U & num);
										num &= 2055932577U;
										IntPtr 2CF47CC41 = ldftn(12BD4CB0);
										num -= 466235084U;
										dictionary74[key68] = new 66026065.0C3B5530(this, 2CF47CC41);
										num = (252935424U ^ num);
										Dictionary<uint, 66026065.0C3B5530> dictionary75 = this.055920A9;
										num <<= 26;
										uint key69 = num - 3489660851U;
										num *= 1956976807U;
										dictionary75[key69] = new 66026065.0C3B5530(this.46B61CF0);
										num = 2087736544U << (int)num;
										if (num == 1046178461U)
										{
											goto IL_6B;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary76 = this.055920A9;
										num += 79906146U;
										uint key70 = num ^ 2167642636U;
										IntPtr 2CF47CC42 = ldftn(48124C6C);
										num = 447874143U + num;
										dictionary76[key70] = new 66026065.0C3B5530(this, 2CF47CC42);
										num >>= 0;
										Dictionary<uint, 66026065.0C3B5530> dictionary77 = this.055920A9;
										uint key71 = num - 2615516754U;
										66026065.0C3B5530 value33 = new 66026065.0C3B5530(this.31250CEC);
										num = 1523860572U << (int)num;
										dictionary77[key71] = value33;
										Dictionary<uint, 66026065.0C3B5530> dictionary78 = this.055920A9;
										num = 1686791107U / num;
										uint key72 = num - 4294967216U;
										num = 2050060148U + num;
										IntPtr 2CF47CC43 = ldftn(1D1E768B);
										num = 984352934U * num;
										dictionary78[key72] = new 66026065.0C3B5530(this, 2CF47CC43);
										num <<= 12;
										if ((1782597963U ^ num) == 0U)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary79 = this.055920A9;
										uint key73 = num ^ 2656272465U;
										IntPtr 2CF47CC44 = ldftn(59FF2598);
										num = 1438260115U * num;
										66026065.0C3B5530 value34 = new 66026065.0C3B5530(this, 2CF47CC44);
										num ^= 495328330U;
										dictionary79[key73] = value34;
										num = 1111044446U / num;
										if (num > 1131743105U)
										{
											goto IL_19;
										}
										num ^= 1319654596U;
										Dictionary<uint, 66026065.0C3B5530> dictionary80 = this.055920A9;
										num /= 247360564U;
										uint key74 = num + 77U;
										num += 1426745993U;
										66026065.0C3B5530 value35 = new 66026065.0C3B5530(this.12B02CA4);
										num = 687937826U - num;
										dictionary80[key74] = value35;
										Dictionary<uint, 66026065.0C3B5530> dictionary81 = this.055920A9;
										uint key75 = num ^ 3556159175U;
										num += 1910444783U;
										IntPtr 2CF47CC45 = ldftn(323A0BD0);
										num <<= 30;
										dictionary81[key75] = new 66026065.0C3B5530(this, 2CF47CC45);
										num -= 555114677U;
										if (num % 687867005U == 0U)
										{
											goto IL_00;
										}
										num = 2066361657U << (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary82 = this.055920A9;
										uint key76 = num ^ 1365887060U;
										num = 69740804U << (int)num;
										num <<= 29;
										IntPtr 2CF47CC46 = ldftn(7941752A);
										num += 324956126U;
										66026065.0C3B5530 value36 = new 66026065.0C3B5530(this, 2CF47CC46);
										num ^= 1496009595U;
										dictionary82[key76] = value36;
										num = 195910525U * num;
										Dictionary<uint, 66026065.0C3B5530> dictionary83 = this.055920A9;
										uint key77 = num + 2789569732U;
										num ^= 2910257U;
										num += 1051467528U;
										IntPtr 2CF47CC47 = ldftn(670D172B);
										num *= 1239955729U;
										66026065.0C3B5530 value37 = new 66026065.0C3B5530(this, 2CF47CC47);
										num = 1346719129U * num;
										dictionary83[key77] = value37;
										Dictionary<uint, 66026065.0C3B5530> dictionary84 = this.055920A9;
										num = 1116502645U % num;
										uint key78 = num ^ 1116502563U;
										num |= 1454442918U;
										IntPtr 2CF47CC48 = ldftn(12B02CA4);
										num <<= 15;
										dictionary84[key78] = new 66026065.0C3B5530(this, 2CF47CC48);
										num *= 2071798147U;
										num *= 153768791U;
										Dictionary<uint, 66026065.0C3B5530> dictionary85 = this.055920A9;
										uint key79 = num ^ 1437171799U;
										num %= 861083053U;
										66026065.0C3B5530 value38 = new 66026065.0C3B5530(this.221A32C2);
										num = 551748742U << (int)num;
										dictionary85[key79] = value38;
										num >>= 6;
										if (1086809881U == num)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary86 = this.055920A9;
										num |= 2114729421U;
										uint key80 = num + 2170751627U;
										num = 1929786073U / num;
										66026065.0C3B5530 value39 = new 66026065.0C3B5530(this.24954D38);
										num = (642931447U & num);
										dictionary86[key80] = value39;
										if (229057262U >= num)
										{
											goto Block_51;
										}
									}
								}
								Block_51:
								num = 735409324U >> (int)num;
								Dictionary<uint, 66026065.0C3B5530> dictionary87 = this.055920A9;
								num %= 655106617U;
								uint key81 = num ^ 80302634U;
								num = 1751940124U / num;
								num /= 842740747U;
								IntPtr 2CF47CC49 = ldftn(26433BD5);
								num = 1819237019U << (int)num;
								66026065.0C3B5530 value40 = new 66026065.0C3B5530(this, 2CF47CC49);
								num += 1228239306U;
								dictionary87[key81] = value40;
								num %= 963448694U;
								if (num + 824971236U == 0U)
								{
									goto IL_00;
								}
								num ^= 679154831U;
								Dictionary<uint, 66026065.0C3B5530> dictionary88 = this.055920A9;
								uint key82 = num + 3738793422U;
								IntPtr 2CF47CC50 = ldftn(1A5D4861);
								num |= 1389911267U;
								66026065.0C3B5530 value41 = new 66026065.0C3B5530(this, 2CF47CC50);
								num %= 286202132U;
								dictionary88[key82] = value41;
								if (307713093U == num)
								{
									goto IL_00;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary89 = this.055920A9;
								uint key83 = num ^ 228870188U;
								IntPtr 2CF47CC51 = ldftn(53A46177);
								num <<= 22;
								dictionary89[key83] = new 66026065.0C3B5530(this, 2CF47CC51);
								num = 994511742U << (int)num;
								if (num < 583479139U)
								{
									break;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary90 = this.055920A9;
								num *= 1832275564U;
								uint key84 = num + 1173537588U;
								IntPtr 2CF47CC52 = ldftn(1D1E768B);
								num <<= 21;
								66026065.0C3B5530 value42 = new 66026065.0C3B5530(this, 2CF47CC52);
								num = 411648377U * num;
								dictionary90[key84] = value42;
								if (1841040210U > num)
								{
									goto IL_19;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary91 = this.055920A9;
								num <<= 4;
								uint key85 = num ^ 3489661021U;
								num %= 1526613653U;
								num = (1632320995U | num);
								66026065.0C3B5530 value43 = new 66026065.0C3B5530(this.40FE152F);
								num >>= 2;
								dictionary91[key85] = value43;
								num = (812544772U | num);
								Dictionary<uint, 66026065.0C3B5530> dictionary92 = this.055920A9;
								uint key86 = num - 1056898975U;
								num = (1294083589U ^ num);
								IntPtr 2CF47CC53 = ldftn(08A07361);
								num += 536543619U;
								dictionary92[key86] = new 66026065.0C3B5530(this, 2CF47CC53);
								num ^= 1946157765U;
								Dictionary<uint, 66026065.0C3B5530> dictionary93 = this.055920A9;
								num = 1384129078U - num;
								uint key87 = num - 1789413401U;
								num |= 1136542575U;
								dictionary93[key87] = new 66026065.0C3B5530(this.12B02CA4);
								if (2115860367U + num == 0U)
								{
									goto IL_00;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary94 = this.055920A9;
								num |= 1887468839U;
								uint key88 = num + 2218885345U;
								num = (713699728U | num);
								IntPtr 2CF47CC54 = ldftn(22DE4DC2);
								num /= 1063066788U;
								dictionary94[key88] = new 66026065.0C3B5530(this, 2CF47CC54);
								if (865481395 << (int)num == 0)
								{
									goto IL_00;
								}
								num /= 1575055986U;
								Dictionary<uint, 66026065.0C3B5530> dictionary95 = this.055920A9;
								num = 1099381961U - num;
								uint key89 = num ^ 1099381928U;
								num = (1528584904U | num);
								IntPtr 2CF47CC55 = ldftn(33F20CDA);
								num |= 1160541025U;
								66026065.0C3B5530 value44 = new 66026065.0C3B5530(this, 2CF47CC55);
								num &= 1918851173U;
								dictionary95[key89] = value44;
								if (117718817U - num == 0U)
								{
									goto IL_00;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary96 = this.055920A9;
								uint key90 = num ^ 1377785859U;
								num = 1243434474U << (int)num;
								num = 826696268U % num;
								IntPtr 2CF47CC56 = ldftn(1FCF54CB);
								num *= 1383934055U;
								dictionary96[key90] = new 66026065.0C3B5530(this, 2CF47CC56);
								Dictionary<uint, 66026065.0C3B5530> dictionary97 = this.055920A9;
								uint key91 = num ^ 701066487U;
								num &= 1764635905U;
								num %= 1767968885U;
								IntPtr 2CF47CC57 = ldftn(1FCF54CB);
								num = 831681810U - num;
								66026065.0C3B5530 value45 = new 66026065.0C3B5530(this, 2CF47CC57);
								num = (1500403284U ^ num);
								dictionary97[key91] = value45;
								Dictionary<uint, 66026065.0C3B5530> dictionary98 = this.055920A9;
								uint key92 = num - 1373898466U;
								num = (1013974244U ^ num);
								dictionary98[key92] = new 66026065.0C3B5530(this.1FCF54CB);
								num <<= 17;
								if (num >= 1431175278U)
								{
									goto IL_19;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary99 = this.055920A9;
								num = (1653211827U ^ num);
								uint key93 = num + 2586967474U;
								66026065.0C3B5530 value46 = new 66026065.0C3B5530(this.48124C6C);
								num &= 239362230U;
								dictionary99[key93] = value46;
								num *= 1492540111U;
								num += 398553326U;
								Dictionary<uint, 66026065.0C3B5530> dictionary100 = this.055920A9;
								num *= 2022113778U;
								uint key94 = num + 2471128174U;
								num = 1281053472U / num;
								IntPtr 2CF47CC58 = ldftn(12B02CA4);
								num -= 2067618524U;
								66026065.0C3B5530 value47 = new 66026065.0C3B5530(this, 2CF47CC58);
								num = (1537416475U ^ num);
								dictionary100[key94] = value47;
								num = 949824833U << (int)num;
								if ((num ^ 1736207341U) == 0U)
								{
									goto IL_19;
								}
								num = 666841111U >> (int)num;
								Dictionary<uint, 66026065.0C3B5530> dictionary101 = this.055920A9;
								num ^= 975777283U;
								uint key95 = num ^ 496377459U;
								num = (1346325598U | num);
								IntPtr 2CF47CC59 = ldftn(1D1E768B);
								num |= 1954575979U;
								66026065.0C3B5530 value48 = new 66026065.0C3B5530(this, 2CF47CC59);
								num = (1864852559U ^ num);
								dictionary101[key95] = value48;
								if (1416789189U * num == 0U)
								{
									goto IL_00;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary102 = this.055920A9;
								num = 1160451942U + num;
								uint key96 = num - 1472409902U;
								num = 94508137U << (int)num;
								IntPtr 2CF47CC60 = ldftn(48124C6C);
								num = 1270940712U * num;
								dictionary102[key96] = new 66026065.0C3B5530(this, 2CF47CC60);
								num = (2078154915U ^ num);
								if (1573668804U - num == 0U)
								{
									goto IL_00;
								}
								num <<= 30;
								Dictionary<uint, 66026065.0C3B5530> dictionary103 = this.055920A9;
								uint key97 = num ^ 3221225577U;
								IntPtr 2CF47CC61 = ldftn(670D172B);
								num |= 1555119268U;
								dictionary103[key97] = new 66026065.0C3B5530(this, 2CF47CC61);
								num += 665070217U;
								Dictionary<uint, 66026065.0C3B5530> dictionary104 = this.055920A9;
								uint key98 = num + 4222261565U;
								num %= 9663204U;
								IntPtr 2CF47CC62 = ldftn(249B4E53);
								num = (1689940543U | num);
								dictionary104[key98] = new 66026065.0C3B5530(this, 2CF47CC62);
								num = 686173405U % num;
								Dictionary<uint, 66026065.0C3B5530> dictionary105 = this.055920A9;
								num %= 1227447187U;
								uint key99 = num - 686173298U;
								num = 1724345237U + num;
								IntPtr 2CF47CC63 = ldftn(249B4E53);
								num <<= 30;
								66026065.0C3B5530 value49 = new 66026065.0C3B5530(this, 2CF47CC63);
								num = 2023439287U - num;
								dictionary105[key99] = value49;
								if (2144878160U >= num)
								{
									goto IL_19;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary106 = this.055920A9;
								num = 420028535U / num;
								dictionary106[num ^ 108U] = new 66026065.0C3B5530(this.3B97341D);
								if (78585971U <= num)
								{
									goto IL_19;
								}
								num = 1153725559U + num;
								Dictionary<uint, 66026065.0C3B5530> dictionary107 = this.055920A9;
								uint key100 = num - 1153725450U;
								num -= 2040412130U;
								num |= 137256276U;
								66026065.0C3B5530 value50 = new 66026065.0C3B5530(this.22DE4DC2);
								num &= 1502107776U;
								dictionary107[key100] = value50;
								num = 242820710U - num;
								if ((num ^ 555361228U) == 0U)
								{
									goto IL_00;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary108 = this.055920A9;
								num %= 480606571U;
								uint key101 = num - 428864758U;
								num = (1887853167U | num);
								num = 1562919667U << (int)num;
								dictionary108[key101] = new 66026065.0C3B5530(this.6F161163);
								num *= 560491729U;
								num <<= 25;
								Dictionary<uint, 66026065.0C3B5530> dictionary109 = this.055920A9;
								num = 1185304718U * num;
								uint key102 = num ^ 111U;
								num = (996755573U | num);
								IntPtr 2CF47CC64 = ldftn(3B3E7A40);
								num = 981271940U / num;
								66026065.0C3B5530 value51 = new 66026065.0C3B5530(this, 2CF47CC64);
								num = (1243756226U & num);
								dictionary109[key102] = value51;
								if (1190927282U == num)
								{
									goto IL_00;
								}
								num -= 1906010054U;
								Dictionary<uint, 66026065.0C3B5530> dictionary110 = this.055920A9;
								num = 1615804113U / num;
								uint key103 = num ^ 112U;
								num = (126580649U ^ num);
								66026065.0C3B5530 value52 = new 66026065.0C3B5530(this.01BF051F);
								num = 957743295U << (int)num;
								dictionary110[key103] = value52;
								Dictionary<uint, 66026065.0C3B5530> dictionary111 = this.055920A9;
								num = (290199930U | num);
								uint key104 = num ^ 1028488971U;
								num -= 1014645483U;
								dictionary111[key104] = new 66026065.0C3B5530(this.46B61CF0);
								if ((num ^ 1936480477U) == 0U)
								{
									goto IL_58;
								}
								num = (1725772833U | num);
								Dictionary<uint, 66026065.0C3B5530> dictionary112 = this.055920A9;
								num = (1373008067U | num);
								uint key105 = num + 2283832195U;
								num ^= 1978549871U;
								66026065.0C3B5530 value53 = new 66026065.0C3B5530(this.05C85C40);
								num = 2073125020U + num;
								dictionary112[key105] = value53;
								num <<= 20;
								if (num < 2022512983U)
								{
									goto IL_19;
								}
								Dictionary<uint, 66026065.0C3B5530> dictionary113 = this.055920A9;
								uint key106 = num ^ 2982150259U;
								num = 3434521U % num;
								dictionary113[key106] = new 66026065.0C3B5530(this.23C10A1A);
								num ^= 1913721684U;
								num /= 936474954U;
								Dictionary<uint, 66026065.0C3B5530> dictionary114 = this.055920A9;
								num /= 72617245U;
								uint key107 = num ^ 116U;
								num = 2000486979U << (int)num;
								IntPtr 2CF47CC65 = ldftn(1A1D0650);
								num -= 2074094093U;
								dictionary114[key107] = new 66026065.0C3B5530(this, 2CF47CC65);
								num &= 151661166U;
								if (790518553U <= num)
								{
									goto IL_58;
								}
								num %= 1378514084U;
								Dictionary<uint, 66026065.0C3B5530> dictionary115 = this.055920A9;
								num ^= 2031564461U;
								uint key108 = num - 1881095702U;
								num >>= 13;
								IntPtr 2CF47CC66 = ldftn(12B02CA4);
								num >>= 5;
								dictionary115[key108] = new 66026065.0C3B5530(this, 2CF47CC66);
								num = 620573780U / num;
								if (908549580U == num)
								{
									goto IL_58;
								}
								num = (1980722128U | num);
								Dictionary<uint, 66026065.0C3B5530> dictionary116 = this.055920A9;
								uint key109 = num + 2314241179U;
								num = 969766574U / num;
								IntPtr 2CF47CC67 = ldftn(08A07361);
								num = (1481594187U & num);
								dictionary116[key109] = new 66026065.0C3B5530(this, 2CF47CC67);
								num %= 1851153242U;
								num = 1139369122U - num;
								Dictionary<uint, 66026065.0C3B5530> dictionary117 = this.055920A9;
								num = 1766002538U >> (int)num;
								uint key110 = num - 441500515U;
								IntPtr 2CF47CC68 = ldftn(78783A8F);
								num = 641926410U - num;
								66026065.0C3B5530 value54 = new 66026065.0C3B5530(this, 2CF47CC68);
								num |= 1432052883U;
								dictionary117[key110] = value54;
								Dictionary<uint, 66026065.0C3B5530> dictionary118 = this.055920A9;
								num = 1019953303U + num;
								uint key111 = num ^ 2630264370U;
								num ^= 697773115U;
								IntPtr 2CF47CC69 = ldftn(12B02CA4);
								num = (1974422163U ^ num);
								66026065.0C3B5530 value55 = new 66026065.0C3B5530(this, 2CF47CC69);
								num %= 512446722U;
								dictionary118[key111] = value55;
								if (722420395U / num != 0U)
								{
									Dictionary<uint, 66026065.0C3B5530> dictionary119 = this.055920A9;
									uint key112 = num ^ 163240623U;
									IntPtr 2CF47CC70 = ldftn(2A805746);
									num = (1694050628U ^ num);
									dictionary119[key112] = new 66026065.0C3B5530(this, 2CF47CC70);
									Dictionary<uint, 66026065.0C3B5530> dictionary120 = this.055920A9;
									uint key113 = num - 1833169688U;
									num = (296974459U & num);
									66026065.0C3B5530 value56 = new 66026065.0C3B5530(this.249B4E53);
									num = (1054400U & num);
									dictionary120[key113] = value56;
									num = 647838046U * num;
									Dictionary<uint, 66026065.0C3B5530> dictionary121 = this.055920A9;
									uint key114 = num ^ 3549814907U;
									num = (1864892949U | num);
									IntPtr 2CF47CC71 = ldftn(26433BD5);
									num += 1393300584U;
									66026065.0C3B5530 value57 = new 66026065.0C3B5530(this, 2CF47CC71);
									num /= 680685415U;
									dictionary121[key114] = value57;
									if (24992323U == num)
									{
										goto IL_00;
									}
									num /= 1937253856U;
									Dictionary<uint, 66026065.0C3B5530> dictionary122 = this.055920A9;
									num = 1353198818U * num;
									uint key115 = num + 124U;
									IntPtr 2CF47CC72 = ldftn(22DE4DC2);
									num = 1296924668U + num;
									dictionary122[key115] = new 66026065.0C3B5530(this, 2CF47CC72);
									if (num >> 17 == 0U)
									{
										goto IL_00;
									}
									num = (1747063111U & num);
									Dictionary<uint, 66026065.0C3B5530> dictionary123 = this.055920A9;
									uint key116 = num ^ 1207963961U;
									num = (947413750U ^ num);
									IntPtr 2CF47CC73 = ldftn(249B4E53);
									num = 2125424703U >> (int)num;
									dictionary123[key116] = new 66026065.0C3B5530(this, 2CF47CC73);
									Dictionary<uint, 66026065.0C3B5530> dictionary124 = this.055920A9;
									num = 731124699U * num;
									uint key117 = num ^ 173066295U;
									num = 802312819U / num;
									num -= 1773431121U;
									IntPtr 2CF47CC74 = ldftn(1FCF54CB);
									num = 1019609684U + num;
									dictionary124[key117] = new 66026065.0C3B5530(this, 2CF47CC74);
									if ((2073240202U & num) == 0U)
									{
										goto IL_19;
									}
									Dictionary<uint, 66026065.0C3B5530> dictionary125 = this.055920A9;
									uint key118 = num ^ 3541145976U;
									IntPtr 2CF47CC75 = ldftn(0FD22F07);
									num = 1887051859U * num;
									66026065.0C3B5530 value58 = new 66026065.0C3B5530(this, 2CF47CC75);
									num >>= 15;
									dictionary125[key118] = value58;
									num += 2039029407U;
									if (num / 1251167948U == 0U)
									{
										goto IL_58;
									}
									num = 394809262U << (int)num;
									Dictionary<uint, 66026065.0C3B5530> dictionary126 = this.055920A9;
									num = (189293770U ^ num);
									uint key119 = num ^ 4270351434U;
									num = (712730481U & num);
									66026065.0C3B5530 value59 = new 66026065.0C3B5530(this.12B02CA4);
									num /= 1393239336U;
									dictionary126[key119] = value59;
									num = 343160147U >> (int)num;
									Dictionary<uint, 66026065.0C3B5530> dictionary127 = this.055920A9;
									num ^= 1528053122U;
									uint key120 = num ^ 1331693648U;
									num >>= 8;
									num = (253235863U ^ num);
									IntPtr 2CF47CC76 = ldftn(08A07361);
									num = (645276296U ^ num);
									dictionary127[key120] = new 66026065.0C3B5530(this, 2CF47CC76);
									if (num == 44898475U)
									{
										goto IL_19;
									}
									Dictionary<uint, 66026065.0C3B5530> dictionary128 = this.055920A9;
									num = 540427113U << (int)num;
									uint key121 = num - 3028287358U;
									num = 889671876U % num;
									66026065.0C3B5530 value60 = new 66026065.0C3B5530(this.249B4E53);
									num = (15215880U & num);
									dictionary128[key121] = value60;
									num /= 2107643895U;
									if (num + 1585607837U == 0U)
									{
										goto IL_00;
									}
									Dictionary<uint, 66026065.0C3B5530> dictionary129 = this.055920A9;
									uint key122 = num - 4294967165U;
									num ^= 542118783U;
									IntPtr 2CF47CC77 = ldftn(206F69E1);
									num = 133055944U % num;
									dictionary129[key122] = new 66026065.0C3B5530(this, 2CF47CC77);
									num = 1507856768U << (int)num;
									Dictionary<uint, 66026065.0C3B5530> dictionary130 = this.055920A9;
									num ^= 572785626U;
									uint key123 = num ^ 3258286942U;
									num = (1689350603U | num);
									dictionary130[key123] = new 66026065.0C3B5530(this.670D172B);
									num = (1976136865U ^ num);
									if (num == 932015951U)
									{
										goto IL_00;
									}
									Dictionary<uint, 66026065.0C3B5530> dictionary131 = this.055920A9;
									uint key124 = num ^ 2474412031U;
									num += 175995332U;
									66026065.0C3B5530 value61 = new 66026065.0C3B5530(this.221A32C2);
									num /= 1661811159U;
									dictionary131[key124] = value61;
									num = (1458573319U ^ num);
									Dictionary<uint, 66026065.0C3B5530> dictionary132 = this.055920A9;
									num = 203975830U << (int)num;
									uint key125 = num ^ 169551110U;
									num ^= 856104112U;
									num = (122364834U ^ num);
									IntPtr 2CF47CC78 = ldftn(24954D38);
									num = 814895373U / num;
									66026065.0C3B5530 value62 = new 66026065.0C3B5530(this, 2CF47CC78);
									num >>= 7;
									dictionary132[key125] = value62;
									Dictionary<uint, 66026065.0C3B5530> dictionary133 = this.055920A9;
									num |= 287860101U;
									uint key126 = num - 287859966U;
									num |= 262824881U;
									dictionary133[key126] = new 66026065.0C3B5530(this.1D1E768B);
									num /= 985087146U;
									if (num << 16 != 0U)
									{
										goto IL_00;
									}
									Dictionary<uint, 66026065.0C3B5530> dictionary134 = this.055920A9;
									num <<= 6;
									uint key127 = num + 136U;
									num /= 1255949285U;
									dictionary134[key127] = new 66026065.0C3B5530(this.206F69E1);
									if ((num & 1743418014U) != 0U)
									{
										goto IL_58;
									}
									Dictionary<uint, 66026065.0C3B5530> dictionary135 = this.055920A9;
									num = 943793432U - num;
									uint key128 = num - 943793295U;
									IntPtr 2CF47CC79 = ldftn(2A805746);
									num = 490884515U * num;
									dictionary135[key128] = new 66026065.0C3B5530(this, 2CF47CC79);
									num = 734419353U >> (int)num;
									if (1423144555U * num == 0U)
									{
										goto IL_19;
									}
									Dictionary<uint, 66026065.0C3B5530> dictionary136 = this.055920A9;
									uint key129 = num + 4292098609U;
									num = (429621152U | num);
									num = (1401975621U | num);
									IntPtr 2CF47CC80 = ldftn(24954D38);
									num |= 469575989U;
									dictionary136[key129] = new 66026065.0C3B5530(this, 2CF47CC80);
									num -= 1504016597U;
									Dictionary<uint, 66026065.0C3B5530> dictionary137 = this.055920A9;
									num <<= 3;
									uint key130 = num - 315898037U;
									num /= 2021985947U;
									dictionary137[key130] = new 66026065.0C3B5530(this.5FBA647E);
									num &= 1943823272U;
									if (num + 2049200889U == 0U)
									{
										goto IL_19;
									}
									Dictionary<uint, 66026065.0C3B5530> dictionary138 = this.055920A9;
									num = (1669006908U ^ num);
									uint key131 = num + 2625960528U;
									num |= 1653744212U;
									num |= 2000883073U;
									IntPtr 2CF47CC81 = ldftn(01BF051F);
									num = (1985575905U & num);
									dictionary138[key131] = new 66026065.0C3B5530(this, 2CF47CC81);
									if (220284904U <= num)
									{
										Dictionary<uint, 66026065.0C3B5530> dictionary139 = this.055920A9;
										num *= 1608076650U;
										uint key132 = num - 2211960733U;
										IntPtr 2CF47CC82 = ldftn(1A1D0650);
										num |= 2002265101U;
										66026065.0C3B5530 value63 = new 66026065.0C3B5530(this, 2CF47CC82);
										num = 1318152635U / num;
										dictionary139[key132] = value63;
										if (num > 1767259885U)
										{
											goto IL_58;
										}
										num = 141103746U >> (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary140 = this.055920A9;
										num = 2110552252U % num;
										uint key133 = num + 4159867630U;
										IntPtr 2CF47CC83 = ldftn(1FCF54CB);
										num = (1778586365U | num);
										dictionary140[key133] = new 66026065.0C3B5530(this, 2CF47CC83);
										num += 1491817926U;
										Dictionary<uint, 66026065.0C3B5530> dictionary141 = this.055920A9;
										num %= 155457057U;
										uint key134 = num ^ 6618497U;
										num += 786528585U;
										num = 1096115906U / num;
										IntPtr 2CF47CC84 = ldftn(12B02CA4);
										num |= 1463046993U;
										66026065.0C3B5530 value64 = new 66026065.0C3B5530(this, 2CF47CC84);
										num -= 784600220U;
										dictionary141[key134] = value64;
										num = 310578096U % num;
										Dictionary<uint, 66026065.0C3B5530> dictionary142 = this.055920A9;
										uint key135 = num ^ 310577952U;
										num = 1132924124U / num;
										IntPtr 2CF47CC85 = ldftn(31250CEC);
										num = 1970161870U * num;
										66026065.0C3B5530 value65 = new 66026065.0C3B5530(this, 2CF47CC85);
										num = (1902667646U | num);
										dictionary142[key135] = value65;
										num = 1119901590U << (int)num;
										if (num * 2055821619U == 0U)
										{
											goto IL_58;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary143 = this.055920A9;
										uint key136 = num ^ 2147483793U;
										num ^= 1875271416U;
										IntPtr 2CF47CC86 = ldftn(0FD22F07);
										num = 630851178U + num;
										66026065.0C3B5530 value66 = new 66026065.0C3B5530(this, 2CF47CC86);
										num = 1128800322U / num;
										dictionary143[key136] = value66;
										num <<= 20;
										if ((num & 1542077435U) == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary144 = this.055920A9;
										num >>= 14;
										uint key137 = num + 4294967250U;
										num <<= 4;
										IntPtr 2CF47CC87 = ldftn(0FD22F07);
										num |= 506618817U;
										66026065.0C3B5530 value67 = new 66026065.0C3B5530(this, 2CF47CC87);
										num = (1560686217U ^ num);
										dictionary144[key137] = value67;
										if (1201628685U <= num)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary145 = this.055920A9;
										uint key138 = num + 3167469387U;
										num >>= 18;
										IntPtr 2CF47CC88 = ldftn(31250CEC);
										num -= 457455968U;
										dictionary145[key138] = new 66026065.0C3B5530(this, 2CF47CC88);
										if (num % 1279334334U == 0U)
										{
											goto IL_19;
										}
										num = (1904224283U & num);
										Dictionary<uint, 66026065.0C3B5530> dictionary146 = this.055920A9;
										num *= 1612467237U;
										uint key139 = num + 2894156615U;
										num += 1300964867U;
										dictionary146[key139] = new 66026065.0C3B5530(this.24954D38);
										num = (1801345495U & num);
										if (479083258 << (int)num == 0)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary147 = this.055920A9;
										uint key140 = num - 554193083U;
										num *= 268845017U;
										IntPtr 2CF47CC89 = ldftn(00F80003);
										num >>= 20;
										dictionary147[key140] = new 66026065.0C3B5530(this, 2CF47CC89);
										num = 701710657U << (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary148 = this.055920A9;
										uint key141 = num + 3221225622U;
										num *= 1090197884U;
										IntPtr 2CF47CC90 = ldftn(46B61CF0);
										num = 2135767459U + num;
										66026065.0C3B5530 value68 = new 66026065.0C3B5530(this, 2CF47CC90);
										num /= 959514774U;
										dictionary148[key141] = value68;
										if (1574970101U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary149 = this.055920A9;
										num += 764306875U;
										uint key142 = num - 764306726U;
										num &= 458433674U;
										IntPtr 2CF47CC91 = ldftn(249B4E53);
										num >>= 9;
										dictionary149[key142] = new 66026065.0C3B5530(this, 2CF47CC91);
										num %= 821913755U;
										Dictionary<uint, 66026065.0C3B5530> dictionary150 = this.055920A9;
										uint key143 = num ^ 295306U;
										num = 816605627U - num;
										num %= 1243315252U;
										IntPtr 2CF47CC92 = ldftn(206F69E1);
										num = (1058295440U ^ num);
										66026065.0C3B5530 value69 = new 66026065.0C3B5530(this, 2CF47CC92);
										num <<= 13;
										dictionary150[key143] = value69;
										if (1738084375U >= num)
										{
											goto IL_6B;
										}
										num -= 795236383U;
										Dictionary<uint, 66026065.0C3B5530> dictionary151 = this.055920A9;
										num = (835943140U & num);
										uint key144 = num ^ 20988537U;
										num = 1313479731U >> (int)num;
										66026065.0C3B5530 value70 = new 66026065.0C3B5530(this.221A32C2);
										num = 1391594278U % num;
										dictionary151[key144] = value70;
										if (num - 706301729U == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary152 = this.055920A9;
										uint key145 = num ^ 78114409U;
										num &= 226496572U;
										num *= 601229789U;
										IntPtr 2CF47CC93 = ldftn(1FCF54CB);
										num = 1058341688U * num;
										66026065.0C3B5530 value71 = new 66026065.0C3B5530(this, 2CF47CC93);
										num *= 726234276U;
										dictionary152[key145] = value71;
										num -= 1294729309U;
										Dictionary<uint, 66026065.0C3B5530> dictionary153 = this.055920A9;
										num &= 2032227061U;
										uint key146 = num ^ 1744916538U;
										66026065.0C3B5530 value72 = new 66026065.0C3B5530(this.1FCF54CB);
										num = 1950356607U % num;
										dictionary153[key146] = value72;
										num /= 1383466133U;
										if (3164246U == num)
										{
											goto IL_00;
										}
										num = 1361992450U * num;
										Dictionary<uint, 66026065.0C3B5530> dictionary154 = this.055920A9;
										num |= 1522886713U;
										uint key147 = num ^ 1522886821U;
										IntPtr 2CF47CC94 = ldftn(78783A8F);
										num |= 1470133361U;
										66026065.0C3B5530 value73 = new 66026065.0C3B5530(this, 2CF47CC94);
										num = 1025723247U << (int)num;
										dictionary154[key147] = value73;
										num |= 80813277U;
										Dictionary<uint, 66026065.0C3B5530> dictionary155 = this.055920A9;
										num >>= 17;
										uint key148 = num ^ 28661U;
										66026065.0C3B5530 value74 = new 66026065.0C3B5530(this.1A5D4861);
										num &= 1341351677U;
										dictionary155[key148] = value74;
										num &= 1093275085U;
										if (1549937228U == num)
										{
											goto IL_00;
										}
										num &= 509241619U;
										Dictionary<uint, 66026065.0C3B5530> dictionary156 = this.055920A9;
										num %= 1041521981U;
										dictionary156[num - 4294967138U] = new 66026065.0C3B5530(this.2A45676B);
										num = 512251018U - num;
										Dictionary<uint, 66026065.0C3B5530> dictionary157 = this.055920A9;
										uint key149 = num - 512250859U;
										num = 462904163U << (int)num;
										dictionary157[key149] = new 66026065.0C3B5530(this.3B3E7A40);
										num |= 1502176451U;
										num *= 496923408U;
										Dictionary<uint, 66026065.0C3B5530> dictionary158 = this.055920A9;
										uint key150 = num ^ 4153697680U;
										IntPtr 2CF47CC95 = ldftn(206F69E1);
										num = (1100371791U | num);
										dictionary158[key150] = new 66026065.0C3B5530(this, 2CF47CC95);
										num -= 797076087U;
										if (402803894U - num == 0U)
										{
											goto IL_00;
										}
										num = (1418815754U | num);
										Dictionary<uint, 66026065.0C3B5530> dictionary159 = this.055920A9;
										num = 206444881U >> (int)num;
										uint key151 = num + 4294765851U;
										num = (389903369U & num);
										IntPtr 2CF47CC96 = ldftn(46B61CF0);
										num <<= 14;
										dictionary159[key151] = new 66026065.0C3B5530(this, 2CF47CC96);
										num = 1255894345U / num;
										Dictionary<uint, 66026065.0C3B5530> dictionary160 = this.055920A9;
										num = (779112691U & num);
										uint key152 = num + 161U;
										num = 623208268U >> (int)num;
										dictionary160[key152] = new 66026065.0C3B5530(this.1D1E768B);
										if ((num ^ 1272208041U) == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary161 = this.055920A9;
										uint key153 = num - 311603971U;
										num = 1936685198U * num;
										num = 1243939686U - num;
										dictionary161[key153] = new 66026065.0C3B5530(this.25447764);
										num = 270161257U << (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary162 = this.055920A9;
										num = (1159475297U ^ num);
										uint key154 = num + 4014460995U;
										num = (1764640077U | num);
										num = (610997850U | num);
										IntPtr 2CF47CC97 = ldftn(3B3E7A40);
										num |= 1618374948U;
										dictionary162[key154] = new 66026065.0C3B5530(this, 2CF47CC97);
										num = 1783586612U * num;
										if (num <= 1061172006U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary163 = this.055920A9;
										num = 1673494030U << (int)num;
										dictionary163[num ^ 4158709925U] = new 66026065.0C3B5530(this.78783A8F);
										num = (2141279006U | num);
										Dictionary<uint, 66026065.0C3B5530> dictionary164 = this.055920A9;
										uint key155 = num ^ 4292998072U;
										num -= 965753392U;
										num |= 205218457U;
										66026065.0C3B5530 value75 = new 66026065.0C3B5530(this.48124C6C);
										num = (380896789U & num);
										dictionary164[key155] = value75;
										num &= 461576648U;
										num %= 550600081U;
										Dictionary<uint, 66026065.0C3B5530> dictionary165 = this.055920A9;
										uint key156 = num - 33554265U;
										num = 2013163406U - num;
										dictionary165[key156] = new 66026065.0C3B5530(this.1A5D4861);
										if (num == 1483547385U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary166 = this.055920A9;
										num = (1668485460U & num);
										uint key157 = num ^ 1634861484U;
										num %= 115045886U;
										dictionary166[key157] = new 66026065.0C3B5530(this.22DE4DC2);
										Dictionary<uint, 66026065.0C3B5530> dictionary167 = this.055920A9;
										num = (172451032U ^ num);
										uint key158 = num ^ 188148049U;
										num /= 675743064U;
										num |= 752037851U;
										IntPtr 2CF47CC98 = ldftn(79934CC2);
										num += 1139436255U;
										66026065.0C3B5530 value76 = new 66026065.0C3B5530(this, 2CF47CC98);
										num *= 227700950U;
										dictionary167[key158] = value76;
										num *= 72514726U;
										if (1181233643U + num == 0U)
										{
											goto IL_58;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary168 = this.055920A9;
										uint key159 = num + 1222178370U;
										num = (1044805356U ^ num);
										num /= 970603244U;
										IntPtr 2CF47CC99 = ldftn(79F53BF5);
										num = 2007645629U / num;
										66026065.0C3B5530 value77 = new 66026065.0C3B5530(this, 2CF47CC99);
										num *= 2025411284U;
										dictionary168[key159] = value77;
										num = 2129599227U % num;
										if (214895629U == num)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary169 = this.055920A9;
										num *= 457591868U;
										uint key160 = num ^ 1688602943U;
										num = 1498113831U * num;
										dictionary169[key160] = new 66026065.0C3B5530(this.79934CC2);
										num %= 1145193307U;
										if (2014384956U == num)
										{
											goto IL_00;
										}
										num = 296180775U + num;
										this.055920A9[num - 854006188U] = new 66026065.0C3B5530(this.12BD4CB0);
										num %= 356152397U;
										if (1626890494U <= num)
										{
											goto IL_58;
										}
										num = 945029739U % num;
										Dictionary<uint, 66026065.0C3B5530> dictionary170 = this.055920A9;
										uint key161 = num ^ 94820186U;
										num = (1438275994U & num);
										IntPtr 2CF47CC100 = ldftn(208C0F82);
										num >>= 2;
										66026065.0C3B5530 value78 = new 66026065.0C3B5530(this, 2CF47CC100);
										num = 1635154268U >> (int)num;
										dictionary170[key161] = value78;
										Dictionary<uint, 66026065.0C3B5530> dictionary171 = this.055920A9;
										uint key162 = num - 102196967U;
										66026065.0C3B5530 value79 = new 66026065.0C3B5530(this.6F161163);
										num = 2055632913U % num;
										dictionary171[key162] = value79;
										num = 215360315U % num;
										num *= 1166571072U;
										Dictionary<uint, 66026065.0C3B5530> dictionary172 = this.055920A9;
										num *= 849153442U;
										uint key163 = num ^ 2016484399U;
										num += 1551378101U;
										num &= 140597283U;
										66026065.0C3B5530 value80 = new 66026065.0C3B5530(this.12B02CA4);
										num = 1193825967U / num;
										dictionary172[key163] = value80;
										if (num > 716603333U)
										{
											goto IL_00;
										}
										num = (1277887324U | num);
										Dictionary<uint, 66026065.0C3B5530> dictionary173 = this.055920A9;
										num = 1617517197U / num;
										uint key164 = num + 175U;
										num = 222455857U / num;
										num &= 1974997442U;
										IntPtr 2CF47CC101 = ldftn(223C114D);
										num = 1248863183U << (int)num;
										dictionary173[key164] = new 66026065.0C3B5530(this, 2CF47CC101);
										num = (1724470662U | num);
										Dictionary<uint, 66026065.0C3B5530> dictionary174 = this.055920A9;
										num += 512560988U;
										uint key165 = num + 1920563590U;
										num = 1271089460U * num;
										num >>= 20;
										IntPtr 2CF47CC102 = ldftn(275538A7);
										num >>= 20;
										dictionary174[key165] = new 66026065.0C3B5530(this, 2CF47CC102);
										num ^= 1143618129U;
										Dictionary<uint, 66026065.0C3B5530> dictionary175 = this.055920A9;
										num |= 111500801U;
										uint key166 = num ^ 1185906403U;
										num = (416036346U & num);
										num = 1783976782U + num;
										dictionary175[key166] = new 66026065.0C3B5530(this.6DE91C9C);
										num = (2075409408U & num);
										Dictionary<uint, 66026065.0C3B5530> dictionary176 = this.055920A9;
										uint key167 = num + 2506095795U;
										num = 986332834U >> (int)num;
										num = 1923815986U * num;
										IntPtr 2CF47CC103 = ldftn(1FCF54CB);
										num += 407388624U;
										66026065.0C3B5530 value81 = new 66026065.0C3B5530(this, 2CF47CC103);
										num >>= 0;
										dictionary176[key167] = value81;
										num -= 58931929U;
										num <<= 5;
										Dictionary<uint, 66026065.0C3B5530> dictionary177 = this.055920A9;
										num = 1131874501U % num;
										uint key168 = num - 1131874321U;
										num = 1942645441U >> (int)num;
										66026065.0C3B5530 value82 = new 66026065.0C3B5530(this.24954D38);
										num = 1457090480U - num;
										dictionary177[key168] = value82;
										if ((95188651U ^ num) == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary178 = this.055920A9;
										num = 492003607U << (int)num;
										uint key169 = num + 2751463605U;
										num >>= 24;
										IntPtr 2CF47CC104 = ldftn(1A5D4861);
										num += 1279142518U;
										66026065.0C3B5530 value83 = new 66026065.0C3B5530(this, 2CF47CC104);
										num &= 267718568U;
										dictionary178[key169] = value83;
										if (1030774793 << (int)num == 0)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary179 = this.055920A9;
										num = 1378175857U + num;
										uint key170 = num ^ 1582912839U;
										num %= 1332894995U;
										66026065.0C3B5530 value84 = new 66026065.0C3B5530(this.1FCF54CB);
										num -= 452266126U;
										dictionary179[key170] = value84;
										num ^= 1770261602U;
										if (282725320U - num == 0U)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary180 = this.055920A9;
										num -= 1937181278U;
										dictionary180[num + 3640725219U] = new 66026065.0C3B5530(this.1FCF54CB);
										if (441997319U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary181 = this.055920A9;
										uint key171 = num + 3640725220U;
										num /= 2055485207U;
										num = (369389510U ^ num);
										IntPtr 2CF47CC105 = ldftn(2A45676B);
										num *= 531050493U;
										dictionary181[key171] = new 66026065.0C3B5530(this, 2CF47CC105);
										num >>= 18;
										if (916219753U == num)
										{
											goto IL_19;
										}
										num = (1229918996U & num);
										Dictionary<uint, 66026065.0C3B5530> dictionary182 = this.055920A9;
										num = 34412380U - num;
										uint key172 = num + 4260559457U;
										num &= 157942750U;
										IntPtr 2CF47CC106 = ldftn(31250CEC);
										num = (2091985557U ^ num);
										66026065.0C3B5530 value85 = new 66026065.0C3B5530(this, 2CF47CC106);
										num = 1247477872U / num;
										dictionary182[key172] = value85;
										num += 206718611U;
										Dictionary<uint, 66026065.0C3B5530> dictionary183 = this.055920A9;
										uint key173 = num ^ 206718505U;
										66026065.0C3B5530 value86 = new 66026065.0C3B5530(this.79934CC2);
										num = 1567446766U % num;
										dictionary183[key173] = value86;
										num |= 77687949U;
										if (num * 1926505956U == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary184 = this.055920A9;
										num ^= 2075023181U;
										uint key174 = num - 2080586469U;
										num = (954822546U & num);
										IntPtr 2CF47CC107 = ldftn(01BF051F);
										num = 998774516U % num;
										dictionary184[key174] = new 66026065.0C3B5530(this, 2CF47CC107);
										num = 1655274532U >> (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary185 = this.055920A9;
										num = 179663035U - num;
										uint key175 = num - 179661269U;
										num = 1570974382U * num;
										IntPtr 2CF47CC108 = ldftn(48124C6C);
										num = (1182162228U ^ num);
										dictionary185[key175] = new 66026065.0C3B5530(this, 2CF47CC108);
										num = 2096982461U << (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary186 = this.055920A9;
										num = 894914569U % num;
										uint key176 = num ^ 894914740U;
										num = 1314273129U % num;
										66026065.0C3B5530 value87 = new 66026065.0C3B5530(this.79F53BF5);
										num >>= 5;
										dictionary186[key176] = value87;
										if (474045085U >> (int)num == 0U)
										{
											goto IL_19;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary187 = this.055920A9;
										uint key177 = num - 13104765U;
										num = 867577231U + num;
										IntPtr 2CF47CC109 = ldftn(08A07361);
										num = 446700182U / num;
										dictionary187[key177] = new 66026065.0C3B5530(this, 2CF47CC109);
										num /= 296169670U;
										num = 1001742345U << (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary188 = this.055920A9;
										uint key178 = num + 3293225142U;
										num -= 460216770U;
										IntPtr 2CF47CC110 = ldftn(24954D38);
										num = 1229280270U << (int)num;
										66026065.0C3B5530 value88 = new 66026065.0C3B5530(this, 2CF47CC110);
										num = 779354996U - num;
										dictionary188[key178] = value88;
										if (1864504144U > num)
										{
											goto IL_19;
										}
										num /= 1283749832U;
										Dictionary<uint, 66026065.0C3B5530> dictionary189 = this.055920A9;
										num ^= 1527531897U;
										uint key179 = num ^ 1527531960U;
										num = 439770040U % num;
										IntPtr 2CF47CC111 = ldftn(323A0BD0);
										num = 653276244U % num;
										66026065.0C3B5530 value89 = new 66026065.0C3B5530(this, 2CF47CC111);
										num = (2064534681U & num);
										dictionary189[key179] = value89;
										Dictionary<uint, 66026065.0C3B5530> dictionary190 = this.055920A9;
										uint key180 = num ^ 134760537U;
										num = 1723092997U >> (int)num;
										num = 621553200U << (int)num;
										IntPtr 2CF47CC112 = ldftn(2A805746);
										num &= 286604239U;
										66026065.0C3B5530 value90 = new 66026065.0C3B5530(this, 2CF47CC112);
										num += 864693549U;
										dictionary190[key180] = value90;
										num = 554304236U / num;
										Dictionary<uint, 66026065.0C3B5530> dictionary191 = this.055920A9;
										uint key181 = num - 4294967102U;
										66026065.0C3B5530 value91 = new 66026065.0C3B5530(this.206F69E1);
										num = 1739997417U + num;
										dictionary191[key181] = value91;
										Dictionary<uint, 66026065.0C3B5530> dictionary192 = this.055920A9;
										uint key182 = num ^ 1739997226U;
										num = 1466174813U / num;
										num &= 220361724U;
										66026065.0C3B5530 value92 = new 66026065.0C3B5530(this.22DE4DC2);
										num *= 822181805U;
										dictionary192[key182] = value92;
										num &= 1806918887U;
										if (1132230956U < num)
										{
											goto IL_19;
										}
										num = 1120345857U >> (int)num;
										Dictionary<uint, 66026065.0C3B5530> dictionary193 = this.055920A9;
										uint key183 = num ^ 1120346053U;
										num %= 37750411U;
										IntPtr 2CF47CC113 = ldftn(2A45676B);
										num = (1011908045U ^ num);
										dictionary193[key183] = new 66026065.0C3B5530(this, 2CF47CC113);
										num = (1126131488U | num);
										num = 994999152U - num;
										Dictionary<uint, 66026065.0C3B5530> dictionary194 = this.055920A9;
										num = 1114785268U << (int)num;
										uint key184 = num ^ 2229570349U;
										num -= 1470367139U;
										66026065.0C3B5530 value93 = new 66026065.0C3B5530(this.206F69E1);
										num = (707791163U & num);
										dictionary194[key184] = value93;
										num %= 654996803U;
										Dictionary<uint, 66026065.0C3B5530> dictionary195 = this.055920A9;
										num = (1120956919U & num);
										dictionary195[num - 13631472U] = new 66026065.0C3B5530(this.54512335);
										num <<= 1;
										Dictionary<uint, 66026065.0C3B5530> dictionary196 = this.055920A9;
										num += 1025077867U;
										uint key185 = num + 3242626288U;
										num = 38939892U >> (int)num;
										num = 1501129291U << (int)num;
										IntPtr 2CF47CC114 = ldftn(25447764);
										num = 451441119U + num;
										66026065.0C3B5530 value94 = new 66026065.0C3B5530(this, 2CF47CC114);
										num *= 2020298440U;
										dictionary196[key185] = value94;
										num = (463150721U | num);
										Dictionary<uint, 66026065.0C3B5530> dictionary197 = this.055920A9;
										num %= 1945112100U;
										uint key186 = num ^ 1208955229U;
										num >>= 23;
										num = (505561603U | num);
										66026065.0C3B5530 value95 = new 66026065.0C3B5530(this.2A45676B);
										num &= 2097369093U;
										dictionary197[key186] = value95;
										num = 552956877U - num;
										Dictionary<uint, 66026065.0C3B5530> dictionary198 = this.055920A9;
										uint key187 = num ^ 83047173U;
										IntPtr 2CF47CC115 = ldftn(1FCF54CB);
										num >>= 0;
										66026065.0C3B5530 value96 = new 66026065.0C3B5530(this, 2CF47CC115);
										num = 346584734U * num;
										dictionary198[key187] = value96;
										num = (1363895293U | num);
										if (1380200592U * num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary199 = this.055920A9;
										num = 713912861U % num;
										uint key188 = num ^ 713913047U;
										num <<= 9;
										dictionary199[key188] = new 66026065.0C3B5530(this.04EC591A);
										num = (973996203U | num);
										num >>= 4;
										Dictionary<uint, 66026065.0C3B5530> dictionary200 = this.055920A9;
										uint key189 = num ^ 61793121U;
										num = 1726952449U % num;
										IntPtr 2CF47CC116 = ldftn(221A32C2);
										num = 1475088073U - num;
										66026065.0C3B5530 value97 = new 66026065.0C3B5530(this, 2CF47CC116);
										num &= 278035622U;
										dictionary200[key189] = value97;
										num = 951149900U << (int)num;
										if (num + 1472949598U == 0U)
										{
											goto IL_58;
										}
										Dictionary<uint, 66026065.0C3B5530> dictionary201 = this.055920A9;
										num = (1583505211U ^ num);
										uint key190 = num - 1916472175U;
										num = 1760756428U + num;
										dictionary201[key190] = new 66026065.0C3B5530(this.488A5C27);
										Dictionary<uint, 66026065.0C3B5530> dictionary202 = this.055920A9;
										uint key191 = num + 617738694U;
										num = 1564424817U / num;
										66026065.0C3B5530 value98 = new 66026065.0C3B5530(this.79934CC2);
										num = 2064338856U * num;
										dictionary202[key191] = value98;
										num = 1979924723U - num;
										if (num >= 435364637U)
										{
											num = 1896817441U << (int)num;
											Dictionary<uint, 66026065.0C3B5530> dictionary203 = this.055920A9;
											num <<= 5;
											uint key192 = num ^ 553648334U;
											num = 534475184U << (int)num;
											num &= 1083848396U;
											66026065.0C3B5530 value99 = new 66026065.0C3B5530(this.12B02CA4);
											num = 995522847U / num;
											dictionary203[key192] = value99;
											num = 1722811815U * num;
											Dictionary<uint, 66026065.0C3B5530> dictionary204 = this.055920A9;
											uint key193 = num - 1331833119U;
											num = 1949437387U - num;
											66026065.0C3B5530 value100 = new 66026065.0C3B5530(this.206F69E1);
											num = 850280828U - num;
											dictionary204[key193] = value100;
											num /= 835738801U;
											Dictionary<uint, 66026065.0C3B5530> dictionary205 = this.055920A9;
											uint key194 = num - 4294967088U;
											num >>= 19;
											IntPtr 2CF47CC117 = ldftn(670D172B);
											num *= 1557012963U;
											66026065.0C3B5530 value101 = new 66026065.0C3B5530(this, 2CF47CC117);
											num %= 812921891U;
											dictionary205[key194] = value101;
											num = 2100825375U * num;
											num = 252643699U << (int)num;
											Dictionary<uint, 66026065.0C3B5530> dictionary206 = this.055920A9;
											num >>= 3;
											uint key195 = num ^ 31580671U;
											num = 378691647U / num;
											IntPtr 2CF47CC118 = ldftn(24954D38);
											num <<= 11;
											dictionary206[key195] = new 66026065.0C3B5530(this, 2CF47CC118);
											num /= 1387730813U;
											if ((num & 720450982U) != 0U)
											{
												goto IL_19;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary207 = this.055920A9;
											num &= 1224936135U;
											uint key196 = num + 210U;
											num <<= 5;
											66026065.0C3B5530 value102 = new 66026065.0C3B5530(this.1A5D4861);
											num ^= 878535646U;
											dictionary207[key196] = value102;
											num |= 1193295258U;
											if ((num ^ 934967144U) == 0U)
											{
												break;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary208 = this.055920A9;
											uint key197 = num - 2004713227U;
											num >>= 0;
											66026065.0C3B5530 value103 = new 66026065.0C3B5530(this.26433BD5);
											num >>= 23;
											dictionary208[key197] = value103;
											num = 891357212U * num;
											if (1772114245U < num)
											{
												goto IL_6B;
											}
											num <<= 8;
											Dictionary<uint, 66026065.0C3B5530> dictionary209 = this.055920A9;
											uint key198 = num - 3045721900U;
											num -= 1470306538U;
											IntPtr 2CF47CC119 = ldftn(2A805746);
											num |= 435512589U;
											66026065.0C3B5530 value104 = new 66026065.0C3B5530(this, 2CF47CC119);
											num = 930095384U + num;
											dictionary209[key198] = value104;
											if (num + 1666076699U == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary210 = this.055920A9;
											uint key199 = num ^ 2506625250U;
											num = 865338796U % num;
											66026065.0C3B5530 value105 = new 66026065.0C3B5530(this.02C01D9C);
											num /= 1311010777U;
											dictionary210[key199] = value105;
											Dictionary<uint, 66026065.0C3B5530> dictionary211 = this.055920A9;
											uint key200 = num + 214U;
											IntPtr 2CF47CC120 = ldftn(249B4E53);
											num %= 1323398510U;
											66026065.0C3B5530 value106 = new 66026065.0C3B5530(this, 2CF47CC120);
											num %= 1882148290U;
											dictionary211[key200] = value106;
											num = 877139769U - num;
											Dictionary<uint, 66026065.0C3B5530> dictionary212 = this.055920A9;
											uint key201 = num + 3417827742U;
											num |= 190531365U;
											num = (328675576U ^ num);
											dictionary212[key201] = new 66026065.0C3B5530(this.4615361D);
											if (1586379147U % num == 0U)
											{
												goto IL_19;
											}
											num = 767785511U % num;
											Dictionary<uint, 66026065.0C3B5530> dictionary213 = this.055920A9;
											uint key202 = num ^ 16192186U;
											num *= 215951428U;
											IntPtr 2CF47CC121 = ldftn(6F161163);
											num = 1089295645U >> (int)num;
											dictionary213[key202] = new 66026065.0C3B5530(this, 2CF47CC121);
											Dictionary<uint, 66026065.0C3B5530> dictionary214 = this.055920A9;
											num = 1348030534U / num;
											uint key203 = num ^ 485U;
											num = 1723881985U + num;
											num += 1116170866U;
											66026065.0C3B5530 value107 = new 66026065.0C3B5530(this.2BB71427);
											num &= 515578522U;
											dictionary214[key203] = value107;
											num = 1204500967U << (int)num;
											if (692941744U >> (int)num == 0U)
											{
												goto IL_19;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary215 = this.055920A9;
											num = 870414675U + num;
											uint key204 = num + 2671176583U;
											num %= 1090540971U;
											num |= 458692128U;
											IntPtr 2CF47CC122 = ldftn(249B4E53);
											num = (634654823U | num);
											66026065.0C3B5530 value108 = new 66026065.0C3B5530(this, 2CF47CC122);
											num ^= 1351156428U;
											dictionary215[key204] = value108;
											num = 1450277365U % num;
											Dictionary<uint, 66026065.0C3B5530> dictionary216 = this.055920A9;
											num = 1553209196U * num;
											uint key205 = num ^ 930641543U;
											num <<= 12;
											num = (1547306808U | num);
											IntPtr 2CF47CC123 = ldftn(12BD4CB0);
											num >>= 24;
											dictionary216[key205] = new 66026065.0C3B5530(this, 2CF47CC123);
											num = 1320301919U - num;
											Dictionary<uint, 66026065.0C3B5530> dictionary217 = this.055920A9;
											num = 1210521181U + num;
											uint key206 = num ^ 2530822657U;
											IntPtr 2CF47CC124 = ldftn(3C253D76);
											num = 10491693U * num;
											66026065.0C3B5530 value109 = new 66026065.0C3B5530(this, 2CF47CC124);
											num /= 1310791046U;
											dictionary217[key206] = value109;
											num = (846350172U & num);
											Dictionary<uint, 66026065.0C3B5530> dictionary218 = this.055920A9;
											uint key207 = num ^ 221U;
											IntPtr 2CF47CC125 = ldftn(206F69E1);
											num /= 924589561U;
											66026065.0C3B5530 value110 = new 66026065.0C3B5530(this, 2CF47CC125);
											num = 1793081426U - num;
											dictionary218[key207] = value110;
											num = 2069571548U + num;
											if (1059330380U == num)
											{
												goto IL_00;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary219 = this.055920A9;
											num = 2126473531U / num;
											uint key208 = num - 4294967074U;
											num = 171272570U << (int)num;
											IntPtr 2CF47CC126 = ldftn(3B3E7A40);
											num = 680879750U / num;
											dictionary219[key208] = new 66026065.0C3B5530(this, 2CF47CC126);
											num = 390138040U % num;
											Dictionary<uint, 66026065.0C3B5530> dictionary220 = this.055920A9;
											num %= 1591960515U;
											uint key209 = num ^ 222U;
											num /= 2040873871U;
											IntPtr 2CF47CC127 = ldftn(79934CC2);
											num = (1683168109U ^ num);
											dictionary220[key209] = new 66026065.0C3B5530(this, 2CF47CC127);
											num = 1886344700U - num;
											num = 728530156U % num;
											Dictionary<uint, 66026065.0C3B5530> dictionary221 = this.055920A9;
											num += 330434007U;
											uint key210 = num + 3845533130U;
											num = 394100361U / num;
											IntPtr 2CF47CC128 = ldftn(48124C6C);
											num |= 1490225195U;
											dictionary221[key210] = new 66026065.0C3B5530(this, 2CF47CC128);
											num ^= 1961391355U;
											num = 1110454148U - num;
											Dictionary<uint, 66026065.0C3B5530> dictionary222 = this.055920A9;
											num = 1158888559U >> (int)num;
											uint key211 = num ^ 1200U;
											IntPtr 2CF47CC129 = ldftn(33F20CDA);
											num *= 1825782430U;
											dictionary222[key211] = new 66026065.0C3B5530(this, 2CF47CC129);
											num = (61020075U & num);
											Dictionary<uint, 66026065.0C3B5530> dictionary223 = this.055920A9;
											num = 279601904U * num;
											uint key212 = num ^ 1481540482U;
											num = 951809375U >> (int)num;
											IntPtr 2CF47CC130 = ldftn(7E2B001C);
											num /= 700133890U;
											dictionary223[key212] = new 66026065.0C3B5530(this, 2CF47CC130);
											num <<= 15;
											Dictionary<uint, 66026065.0C3B5530> dictionary224 = this.055920A9;
											num = 1421752462U >> (int)num;
											uint key213 = num + 2873215061U;
											IntPtr 2CF47CC131 = ldftn(3B3E7A40);
											num %= 573135990U;
											66026065.0C3B5530 value111 = new 66026065.0C3B5530(this, 2CF47CC131);
											num = 733944774U >> (int)num;
											dictionary224[key213] = value111;
											num <<= 15;
											if (1103979082U >> (int)num == 0U)
											{
												goto IL_00;
											}
											num += 1011695202U;
											Dictionary<uint, 66026065.0C3B5530> dictionary225 = this.055920A9;
											num = 784406792U + num;
											uint key214 = num - 1317459590U;
											num = (1724974018U & num);
											num = (1739409271U | num);
											IntPtr 2CF47CC132 = ldftn(79934CC2);
											num = 1238269252U / num;
											66026065.0C3B5530 value112 = new 66026065.0C3B5530(this, 2CF47CC132);
											num -= 695091960U;
											dictionary225[key214] = value112;
											Dictionary<uint, 66026065.0C3B5530> dictionary226 = this.055920A9;
											num = (648424863U | num);
											uint key215 = num ^ 4139236730U;
											num = 1633891795U % num;
											num = (575634365U | num);
											66026065.0C3B5530 value113 = new 66026065.0C3B5530(this.1FCF54CB);
											num <<= 2;
											dictionary226[key215] = value113;
											num %= 391129058U;
											if (num + 187572955U == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary227 = this.055920A9;
											num = 1837043121U << (int)num;
											uint key216 = num ^ 229703910U;
											num = 1642665195U - num;
											IntPtr 2CF47CC133 = ldftn(24954D38);
											num = 1985969711U / num;
											66026065.0C3B5530 value114 = new 66026065.0C3B5530(this, 2CF47CC133);
											num = 16282528U >> (int)num;
											dictionary227[key216] = value114;
											num %= 620633054U;
											Dictionary<uint, 66026065.0C3B5530> dictionary228 = this.055920A9;
											num = (731538827U & num);
											dictionary228[num ^ 1581415U] = new 66026065.0C3B5530(this.54113550);
											num = (116598905U & num);
											Dictionary<uint, 66026065.0C3B5530> dictionary229 = this.055920A9;
											uint key217 = num + 4293910760U;
											num = 2133227326U * num;
											IntPtr 2CF47CC134 = ldftn(1FCF54CB);
											num %= 2021859241U;
											dictionary229[key217] = new 66026065.0C3B5530(this, 2CF47CC134);
											num ^= 1191933947U;
											Dictionary<uint, 66026065.0C3B5530> dictionary230 = this.055920A9;
											uint key218 = num ^ 97302290U;
											num = (972837155U | num);
											num <<= 18;
											IntPtr 2CF47CC135 = ldftn(7941752A);
											num ^= 1380650745U;
											66026065.0C3B5530 value115 = new 66026065.0C3B5530(this, 2CF47CC135);
											num = 1902994583U % num;
											dictionary230[key218] = value115;
											num = (1979267008U & num);
											num -= 1839865273U;
											Dictionary<uint, 66026065.0C3B5530> dictionary231 = this.055920A9;
											uint key219 = num ^ 62850605U;
											num = 2054102347U >> (int)num;
											IntPtr 2CF47CC136 = ldftn(6BD9278B);
											num = (494891145U | num);
											66026065.0C3B5530 value116 = new 66026065.0C3B5530(this, 2CF47CC136);
											num ^= 1011109323U;
											dictionary231[key219] = value116;
											num = (2144040045U & num);
											Dictionary<uint, 66026065.0C3B5530> dictionary232 = this.055920A9;
											num = 2015582496U % num;
											uint key220 = num ^ 327272683U;
											num /= 934768497U;
											dictionary232[key220] = new 66026065.0C3B5530(this.1A5D4861);
											if (num >= 80039829U)
											{
												goto IL_00;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary233 = this.055920A9;
											uint key221 = num ^ 236U;
											num = (1552820138U | num);
											IntPtr 2CF47CC137 = ldftn(12B02CA4);
											num = 1259433805U % num;
											dictionary233[key221] = new 66026065.0C3B5530(this, 2CF47CC137);
											num = 238965649U + num;
											Dictionary<uint, 66026065.0C3B5530> dictionary234 = this.055920A9;
											uint key222 = num - 1498399217U;
											num /= 1651770555U;
											num = (411585886U & num);
											66026065.0C3B5530 value117 = new 66026065.0C3B5530(this.26433BD5);
											num |= 1279729751U;
											dictionary234[key222] = value117;
											num |= 101993482U;
											Dictionary<uint, 66026065.0C3B5530> dictionary235 = this.055920A9;
											num = 1516272004U >> (int)num;
											uint key223 = num ^ 238U;
											num = (1097336902U | num);
											num = 24796094U << (int)num;
											IntPtr 2CF47CC138 = ldftn(488A5C27);
											num *= 927086183U;
											66026065.0C3B5530 value118 = new 66026065.0C3B5530(this, 2CF47CC138);
											num >>= 3;
											dictionary235[key223] = value118;
											num = 1151873331U / num;
											if ((1092821952U ^ num) == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary236 = this.055920A9;
											uint key224 = num + 224U;
											66026065.0C3B5530 value119 = new 66026065.0C3B5530(this.79F53BF5);
											num &= 1144600003U;
											dictionary236[key224] = value119;
											num |= 1968580083U;
											num >>= 17;
											Dictionary<uint, 66026065.0C3B5530> dictionary237 = this.055920A9;
											uint key225 = num + 4294952517U;
											num = 558114224U % num;
											num += 793972301U;
											66026065.0C3B5530 value120 = new 66026065.0C3B5530(this.2A45676B);
											num %= 1899193698U;
											dictionary237[key225] = value120;
											num = 1507930474U * num;
											num <<= 20;
											Dictionary<uint, 66026065.0C3B5530> dictionary238 = this.055920A9;
											num /= 1611533424U;
											uint key226 = num ^ 243U;
											num = 1903906845U - num;
											66026065.0C3B5530 value121 = new 66026065.0C3B5530(this.1FCF54CB);
											num = 411705100U << (int)num;
											dictionary238[key226] = value121;
											if (num == 29644239U)
											{
												goto IL_00;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary239 = this.055920A9;
											uint key227 = num ^ 1610612978U;
											num -= 2127059027U;
											66026065.0C3B5530 value122 = new 66026065.0C3B5530(this.48124C6C);
											num = (102966377U | num);
											dictionary239[key227] = value122;
											num *= 541881627U;
											Dictionary<uint, 66026065.0C3B5530> dictionary240 = this.055920A9;
											uint key228 = num ^ 1291453964U;
											num = (1379934481U ^ num);
											num %= 850880763U;
											66026065.0C3B5530 value123 = new 66026065.0C3B5530(this.79934CC2);
											num = 1592220429U / num;
											dictionary240[key228] = value123;
											num %= 158216936U;
											if ((73755093U ^ num) == 0U)
											{
												goto IL_00;
											}
											num = 877532530U / num;
											Dictionary<uint, 66026065.0C3B5530> dictionary241 = this.055920A9;
											uint key229 = num ^ 292510863U;
											num = 665334809U - num;
											num = 447900027U * num;
											dictionary241[key229] = new 66026065.0C3B5530(this.4D52134C);
											if (1423124191U - num == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 66026065.0C3B5530> dictionary242 = this.055920A9;
											num >>= 7;
											uint key230 = num ^ 32192056U;
											num = 1198982536U / num;
											IntPtr 2CF47CC139 = ldftn(4BFD4FC2);
											num >>= 1;
											dictionary242[key230] = new 66026065.0C3B5530(this, 2CF47CC139);
											if (num >> 10 != 0U)
											{
												goto IL_00;
											}
											num %= 1908088728U;
											Dictionary<uint, 66026065.0C3B5530> dictionary243 = this.055920A9;
											num = 1751203910U - num;
											uint key231 = num ^ 1751204034U;
											num = 1010712916U << (int)num;
											dictionary243[key231] = new 66026065.0C3B5530(this.1A1D0650);
											if (num >> 2 != 0U)
											{
												goto Block_131;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			Block_131:
			num = 1967544131U / num;
			Dictionary<uint, 66026065.0C3B5530> dictionary244 = this.055920A9;
			num = (1782976433U | num);
			uint key232 = num - 1782976190U;
			num %= 1545687519U;
			num %= 603552492U;
			66026065.0C3B5530 value124 = new 66026065.0C3B5530(this.1FCF54CB);
			num <<= 6;
			dictionary244[key232] = value124;
			num = (1238118921U ^ num);
			Dictionary<uint, 66026065.0C3B5530> dictionary245 = this.055920A9;
			uint key233 = num - 3236120209U;
			num = 1182933410U - num;
			num = 1173642018U << (int)num;
			IntPtr 2CF47CC140 = ldftn(26433BD5);
			num = 1354202930U * num;
			66026065.0C3B5530 value125 = new 66026065.0C3B5530(this, 2CF47CC140);
			num &= 1294405950U;
			dictionary245[key233] = value125;
			num = 1367545098U >> (int)num;
			if (num <= 1450211112U)
			{
				num = (1937980652U & num);
				Dictionary<uint, 66026065.0C3B5530> dictionary246 = this.055920A9;
				num -= 1324967545U;
				uint key234 = num ^ 42577270U;
				num %= 1584665693U;
				num = 707932250U * num;
				66026065.0C3B5530 value126 = new 66026065.0C3B5530(this.7E2B001C);
				num *= 2046849719U;
				dictionary246[key234] = value126;
				num = 397293492U * num;
				if (num % 1827958112U != 0U)
				{
					num = 381644727U >> (int)num;
					Dictionary<uint, 66026065.0C3B5530> dictionary247 = this.055920A9;
					uint key235 = num - 1490549U;
					num /= 1044995210U;
					IntPtr 2CF47CC141 = ldftn(221A32C2);
					num = 1512185625U + num;
					66026065.0C3B5530 value127 = new 66026065.0C3B5530(this, 2CF47CC141);
					num = (1127437985U & num);
					dictionary247[key235] = value127;
					Dictionary<uint, 66026065.0C3B5530> dictionary248 = this.055920A9;
					uint key236 = num + 3185437434U;
					num *= 1490645390U;
					num -= 102395343U;
					66026065.0C3B5530 value128 = new 66026065.0C3B5530(this.75DE753B);
					num = 1116294134U + num;
					dictionary248[key236] = value128;
					Dictionary<uint, 66026065.0C3B5530> dictionary249 = this.055920A9;
					uint key237 = num ^ 4125524809U;
					num = 413012761U / num;
					IntPtr 2CF47CC142 = ldftn(24954D38);
					num = 851248914U << (int)num;
					66026065.0C3B5530 value129 = new 66026065.0C3B5530(this, 2CF47CC142);
					num = (979982492U & num);
					dictionary249[key237] = value129;
					if (1113149192U % num != 0U)
					{
						this.055920A9[num + 3453419757U] = new 66026065.0C3B5530(this.1A5D4861);
						Dictionary<uint, 66026065.0C3B5530> dictionary250 = this.055920A9;
						num %= 7437240U;
						uint key238 = num + 4293827878U;
						num = (307972656U ^ num);
						IntPtr 2CF47CC143 = ldftn(6BD9278B);
						num %= 415920228U;
						dictionary250[key238] = new 66026065.0C3B5530(this, 2CF47CC143);
						if (1671056050U >= num)
						{
							Dictionary<uint, 66026065.0C3B5530> dictionary251 = this.055920A9;
							uint key239 = num + 3988117271U;
							num = (2109750825U | num);
							num <<= 3;
							IntPtr 2CF47CC144 = ldftn(3B3E7A40);
							num = 2096254059U - num;
							dictionary251[key239] = new 66026065.0C3B5530(this, 2CF47CC144);
							if (1013405533U < num)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00212A04 File Offset: 0x00212A04
	private void 2A5A7C53(66026065.28060A8C 59F20687)
	{
		uint num = 121330274U;
		if ((1806859694U & num) != 0U)
		{
			this.307C15CA.Push(59F20687.5412D03B());
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00212A34 File Offset: 0x00212A34
	private 66026065.28060A8C 254C0263()
	{
		return this.307C15CA.Pop();
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00212A4C File Offset: 0x00212A4C
	private 66026065.28060A8C 050E096B()
	{
		return this.307C15CA.Peek();
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00212A6C File Offset: 0x00212A6C
	private byte 08AB1195()
	{
		uint num = 2014915623U;
		long value = this.598B592D + (long)this.7F97109A;
		num &= 886652827U;
		IntPtr ptr = new IntPtr(value);
		num = 1482365426U / num;
		byte result = Marshal.ReadByte(ptr);
		this.7F97109A += (int)(num ^ 0U);
		return result;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00212ABC File Offset: 0x00212ABC
	private short 1FC8038B()
	{
		uint num = 1199405737U;
		long num2 = this.598B592D;
		long num3 = (long)this.7F97109A;
		num = 439893770U * num;
		long num4 = num3;
		num %= 1118725604U;
		long value = num2 + num4;
		num = 1059012597U / num;
		short result = Marshal.ReadInt16(new IntPtr(value));
		num += 850599422U;
		int num5 = this.7F97109A;
		int num6 = (int)(num - 850599421U);
		num = 879711758U * num;
		int num7 = num5 + num6;
		num = (1173619696U ^ num);
		this.7F97109A = num7;
		return result;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00212B2C File Offset: 0x00212B2C
	private int 51984E22()
	{
		uint num = 1643672616U;
		long num2 = this.598B592D;
		num <<= 22;
		IntPtr ptr = new IntPtr(num2 + (long)this.7F97109A);
		num = (242223960U | num);
		int result = Marshal.ReadInt32(ptr);
		num |= 173678424U;
		num = 761008842U % num;
		int num3 = this.7F97109A;
		num ^= 917376007U;
		this.7F97109A = num3 + (int)(num ^ 927185089U);
		return result;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00212B94 File Offset: 0x00212B94
	private long 6C613E40()
	{
		long num = this.598B592D;
		uint num2 = 1373334360U;
		long num3 = (long)this.7F97109A;
		num2 >>= 19;
		long value = num + num3;
		num2 = 1934916795U * num2;
		IntPtr ptr = new IntPtr(value);
		num2 ^= 92224680U;
		long result = Marshal.ReadInt64(ptr);
		num2 >>= 6;
		int num4 = this.7F97109A;
		num2 = 1880688826U >> (int)num2;
		int num5 = (int)(num2 + 4265581542U);
		num2 <<= 10;
		int num6 = num4 + num5;
		num2 |= 174406441U;
		this.7F97109A = num6;
		return result;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00212C14 File Offset: 0x00212C14
	private float 4A424B0E()
	{
		uint num = 1287984270U;
		num %= 459680392U;
		int value = this.51984E22();
		num /= 225775666U;
		return BitConverter.ToSingle(BitConverter.GetBytes(value), (int)(num - 1U));
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00212C50 File Offset: 0x00212C50
	private double 1D1F20BF()
	{
		uint num = 961312376U;
		byte[] bytes = BitConverter.GetBytes(this.6C613E40());
		num %= 2063291802U;
		int startIndex = (int)(num ^ 961312376U);
		num /= 1249974565U;
		return BitConverter.ToDouble(bytes, startIndex);
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00212C8C File Offset: 0x00212C8C
	private void 02D44669()
	{
		uint num;
		byte b2;
		int num5;
		int num6;
		66026065.4AB007C7 4AB007C;
		for (;;)
		{
			IL_00:
			num = 239820138U;
			byte b = this.08AB1195();
			num = 549021259U << (int)num;
			b2 = b;
			for (;;)
			{
				IL_1E:
				int num2 = this.51984E22();
				int num3;
				for (;;)
				{
					num = (1212686651U | num);
					num3 = this.51984E22();
					num = 836242681U >> (int)num;
					if (843654705U < num)
					{
						goto IL_1E;
					}
					num += 394791130U;
					int num4 = this.51984E22();
					num += 1131564092U;
					num5 = num4;
					num = 2131037142U - num;
					if (num >= 664209370U)
					{
						goto IL_1E;
					}
					num6 = this.51984E22();
					if (1967400186U / num != 0U)
					{
						4AB007C = null;
						num = 2124876398U / num;
						int num7 = (int)(num ^ 3U);
						num >>= 4;
						int num8 = num7;
						for (;;)
						{
							num = (537397439U & num);
							if ((num ^ 330972766U) == 0U)
							{
								goto IL_00;
							}
							int num9 = num8;
							List<66026065.4AB007C7> list = this.13F94EC7;
							num = (1754137307U ^ num);
							if (num9 >= list.Count)
							{
								goto Block_9;
							}
							num = 1744906558U;
							List<66026065.4AB007C7> list2 = this.13F94EC7;
							int index = num8;
							num >>= 11;
							66026065.4AB007C7 4AB007C2 = list2[index];
							num = (974611469U | num);
							if ((529561845U & num) == 0U)
							{
								break;
							}
							66026065.4AB007C7 4AB007C3 = 4AB007C2;
							num = 1831942284U - num;
							int num10 = 4AB007C3.49CD1B84();
							num -= 740654740U;
							if (num10 == num2)
							{
								if (1422541328U % num == 0U)
								{
									goto IL_1E;
								}
								int num11 = 4AB007C2.13F7030A();
								int num12 = num3;
								num += 0U;
								if (num11 == num12)
								{
									goto Block_6;
								}
							}
							int num13 = num8;
							num = (1764710458U ^ num);
							int num14 = (int)(num ^ 1875054064U);
							num = 1585976546U * num;
							num8 = num13 + num14;
							num += 850320702U;
						}
					}
				}
				IL_1B7:
				num /= 710101796U;
				if (num / 1734608318U != 0U)
				{
					continue;
				}
				if (4AB007C == null)
				{
					num = (1227379220U & num);
					bool flag = (num ^ 0U) != 0U;
					num = 716403082U - num;
					int <<EMPTY_NAME>> = num2;
					num = 1001221296U - num;
					66026065.4AB007C7 4AB007C4 = new 66026065.4AB007C7(<<EMPTY_NAME>>, num3);
					num = 149294761U + num;
					4AB007C = 4AB007C4;
					int i = (int)(num ^ 434112975U);
					while (i < this.13F94EC7.Count)
					{
						List<66026065.4AB007C7> list3 = this.13F94EC7;
						int index2 = i;
						num = 1039816676U;
						66026065.4AB007C7 4AB007C5 = list3[index2];
						num %= 2045524842U;
						66026065.4AB007C7 4AB007C6 = 4AB007C5;
						num &= 1369243825U;
						66026065.4AB007C7 4AB007C7 = 4AB007C;
						66026065.4AB007C7 66EF08BA = 4AB007C6;
						num = (1071213925U | num);
						uint num15 = (uint)4AB007C7.08FC2856(66EF08BA);
						num = (374232607U | num);
						if (num15 < (num ^ 1071611903U))
						{
							if ((1532167725U ^ num) == 0U)
							{
								goto IL_00;
							}
							this.13F94EC7.Insert(i, 4AB007C);
							num = (1560700324U | num);
							flag = (num + 2149613570U != 0U);
							IL_2ED:
							num = 1036195076U / num;
							bool flag2 = flag;
							num = (11761609U | num);
							num += 4283205687U;
							if (flag2)
							{
								goto IL_353;
							}
							if (num + 797319830U != 0U)
							{
								num -= 922574565U;
								List<66026065.4AB007C7> list4 = this.13F94EC7;
								num = (791831629U ^ num);
								66026065.4AB007C7 item = 4AB007C;
								num %= 676617791U;
								list4.Add(item);
								num += 3816100325U;
								goto IL_353;
							}
							goto IL_1E;
						}
						else
						{
							if (1434615550U < num)
							{
								goto IL_00;
							}
							int num16 = i;
							int num17 = (int)(num - 1071611902U);
							num = 1199772229U / num;
							i = num16 + num17;
							num ^= 434112974U;
						}
					}
					num ^= 1715435056U;
					goto IL_2ED;
				}
				IL_353:
				if ((num & 644244018U) == 0U)
				{
					goto Block_18;
				}
				continue;
				Block_9:
				num ^= 1851938576U;
				goto IL_1B7;
				Block_6:
				if (num / 1652367765U == 0U)
				{
					66026065.4AB007C7 4AB007C2;
					4AB007C = 4AB007C2;
					goto IL_1B7;
				}
				break;
			}
		}
		Block_18:
		66026065.4AB007C7 4AB007C8 = 4AB007C;
		byte 56E = b2;
		num = 2077635579U + num;
		int 739A54E = num5;
		int 221C0DDB = num6;
		num = 1663574233U % num;
		4AB007C8.76AA06B8(56E, 739A54E, 221C0DDB);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00213018 File Offset: 0x00213018
	private TypeCode 6C215FC2(66026065.28060A8C 505C6652, 66026065.28060A8C 637A2298)
	{
		uint num = 582040341U;
		TypeCode typeCode2;
		TypeCode typeCode3;
		for (;;)
		{
			IL_06:
			TypeCode typeCode = 505C6652.04C738A1();
			num = (807424294U | num);
			typeCode2 = typeCode;
			num = 914973227U << (int)num;
			for (;;)
			{
				num = 226379551U * num;
				typeCode3 = 637A2298.04C738A1();
				if (903771582U > num)
				{
					goto IL_3D;
				}
				goto IL_7B;
				IL_4B:
				TypeCode typeCode4 = typeCode2;
				num %= 564150739U;
				uint num2 = num ^ 264573932U;
				num += 564150739U;
				if (typeCode4 == num2)
				{
					goto IL_BA;
				}
				num -= 2103004185U;
				if (1938301141U != num)
				{
					goto IL_7B;
				}
				continue;
				IL_3D:
				bool flag = typeCode2 != TypeCode.Empty;
				num = 384128448U + num;
				if (flag)
				{
					goto IL_4B;
				}
				goto IL_BA;
				IL_7B:
				bool flag2 = typeCode3 != TypeCode.Empty;
				num = 363926190U << (int)num;
				num ^= 3924558528U;
				if (!flag2)
				{
					goto IL_BA;
				}
				num = 1951599827U << (int)num;
				if (typeCode3 == (TypeCode)(num ^ 1951599826U))
				{
					goto Block_3;
				}
				TypeCode typeCode5 = typeCode2;
				num += 1649372405U;
				uint num3 = num - 3600972222U;
				num = 2141333646U - num;
				if (typeCode5 == num3)
				{
					if (num * 830550481U != 0U)
					{
						goto Block_5;
					}
				}
				else
				{
					num = 853150677U - num;
					if (num < 59970025U)
					{
						goto IL_3D;
					}
					TypeCode typeCode6 = typeCode3;
					uint num4 = num ^ 2312789253U;
					num %= 466162228U;
					if (typeCode6 == num4)
					{
						if (606750195U <= num)
						{
							goto IL_06;
						}
						TypeCode typeCode7 = typeCode2;
						uint num5 = num + 3846826954U;
						num = 275653077U % num;
						if (typeCode7 != num5)
						{
							goto Block_10;
						}
						if (2143052451U - num != 0U)
						{
							return typeCode3;
						}
					}
					else
					{
						num = 1223164830U >> (int)num;
						TypeCode typeCode8 = typeCode2;
						uint num6 = num ^ 12U;
						num %= 1385106020U;
						if (typeCode8 == num6)
						{
							break;
						}
						if ((num & 178000913U) != 0U)
						{
							goto IL_3D;
						}
						uint num7 = (uint)typeCode3;
						num <<= 13;
						if (num7 == num + 12U)
						{
							if (1165314013U >= num)
							{
								TypeCode typeCode9 = typeCode2;
								uint num8 = num ^ 9U;
								num = 2079415256U + num;
								if (typeCode9 != num8)
								{
									if (699285770U > num)
									{
										continue;
									}
									TypeCode typeCode10 = typeCode2;
									uint num9 = num - 2079415245U;
									num += 0U;
									if (typeCode10 != num9)
									{
										goto Block_21;
									}
								}
								if (num >= 2001606348U)
								{
									return typeCode2;
								}
							}
						}
						else
						{
							uint num10 = (uint)typeCode2;
							num = 699166833U >> (int)num;
							if (num10 == (num ^ 699166847U))
							{
								goto IL_2C2;
							}
							num >>= 29;
							if (num * 1235820400U == 0U)
							{
								goto IL_4B;
							}
							uint num11 = (uint)typeCode3;
							num *= 594812954U;
							if (num11 == (num ^ 594812948U))
							{
								goto Block_25;
							}
							num = 473764317U * num;
							uint num12 = (uint)typeCode2;
							num |= 1075410587U;
							if (num12 == num + 811895058U)
							{
								goto IL_31A;
							}
							TypeCode typeCode11 = typeCode3;
							num |= 1542130751U;
							uint num13 = num + 537166094U;
							num = 1585996384U - num;
							if (typeCode11 == num13)
							{
								goto Block_27;
							}
							num /= 1058354332U;
							if ((1506047844U ^ num) != 0U)
							{
								goto Block_28;
							}
						}
					}
				}
			}
			if (525358761U >= num)
			{
				goto Block_13;
			}
		}
		Block_3:
		num ^= 1161189651U;
		IL_BA:
		num = 155993874U * num;
		return (TypeCode)(num - 3370665856U);
		Block_5:
		if (typeCode3 != (int)num + (TypeCode)1459638595)
		{
			num |= 1813120806U;
			return (TypeCode)(num ^ 3976179686U);
		}
		return typeCode2;
		Block_10:
		num = 263793065U - num;
		return (int)num + (TypeCode)11860012;
		Block_13:
		TypeCode typeCode12 = typeCode3;
		uint num14 = num ^ 9U;
		num = 1175983107U - num;
		if (typeCode12 != num14)
		{
			TypeCode typeCode13 = typeCode3;
			num = 157040423U - num;
			uint num15 = num ^ 3276024623U;
			num = 430995602U >> (int)num;
			num ^= 1199772554U;
			if (typeCode13 != num15)
			{
				num = 1857497417U + num;
				return (TypeCode)(num ^ 3033480524U);
			}
		}
		num /= 422386869U;
		return typeCode2;
		Block_21:
		return (TypeCode)(num ^ 2079415256U);
		Block_25:
		num ^= 181948523U;
		IL_2C2:
		num = 350625170U << (int)num;
		return (TypeCode)(num ^ 992215054U);
		Block_27:
		num ^= 2971112858U;
		IL_31A:
		return (TypeCode)(num ^ 3483072246U);
		Block_28:
		TypeCode typeCode14 = typeCode2;
		num = 342169305U - num;
		uint num16 = num ^ 342169308U;
		num <<= 25;
		if (typeCode14 != num16)
		{
			TypeCode typeCode15 = typeCode3;
			uint num17 = num - 2919235573U;
			num >>= 11;
			if (typeCode15 != num17)
			{
				return (TypeCode)(num - 1425399U);
			}
			num += 2917810176U;
		}
		num = (498283149U & num);
		return (int)num + (TypeCode)(-201326581);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x002133AC File Offset: 0x002133AC
	private unsafe 66026065.28060A8C 73F651C6(66026065.28060A8C 266F6884, 66026065.28060A8C 45EC5D6F, bool 77A376FE, bool 7E7D48FC)
	{
		uint num;
		int num12;
		ulong num22;
		ulong num23;
		double num37;
		long num38;
		long num39;
		float num40;
		float num42;
		double num44;
		int num51;
		int num54;
		int num56;
		for (;;)
		{
			IL_00:
			num = 185811528U;
			num >>= 13;
			num = (741497482U & num);
			TypeCode typeCode = this.6C215FC2(266F6884, 45EC5D6F);
			num ^= 1972770766U;
			TypeCode typeCode2 = typeCode;
			num -= 1475749695U;
			if ((num ^ 959468980U) == 0U)
			{
				goto IL_94;
			}
			for (;;)
			{
				IL_46:
				uint num2 = (uint)typeCode2;
				num = 1197741957U * num;
				uint num3 = num2 - (num ^ 3435216272U);
				num >>= 27;
				switch (num3)
				{
				case 0:
					goto IL_94;
				case 1:
					num ^= 666184029U;
					if (num > 2027186329U)
					{
						goto IL_00;
					}
					num >>= 9;
					if (7E7D48FC)
					{
						uint num4 = 266F6884.45E9448C();
						num %= 811406772U;
						num = 773548845U << (int)num;
						uint num5 = 45EC5D6F.45E9448C();
						num *= 1635935472U;
						uint num6 = num5;
						num /= 1927635167U;
						int num9;
						if (!77A376FE)
						{
							num = (1947419387U | num);
							int num7 = (int)num4;
							num -= 1312257414U;
							int num8 = (int)num6;
							num <<= 24;
							num9 = num7 + num8;
						}
						else
						{
							int num10 = (int)num4;
							int num11 = (int)num6;
							num &= 534989926U;
							num9 = checked(num10 + num11);
							num += 1962934272U;
						}
						num12 = num9;
					}
					else
					{
						num |= 912737301U;
						if (num > 991320313U)
						{
							goto IL_00;
						}
						int num13 = 266F6884.D02DFB88();
						num = 586835902U << (int)num;
						if (num - 665651463U == 0U)
						{
							goto IL_00;
						}
						int num14 = 45EC5D6F.D02DFB88();
						num = 365838610U % num;
						int num15 = num14;
						num &= 2016239640U;
						num %= 893391012U;
						int num18;
						if (!77A376FE)
						{
							num -= 866658647U;
							int num16 = num13;
							num = (302606529U ^ num);
							int num17 = num15;
							num = 227295722U >> (int)num;
							num18 = num16 + num17;
						}
						else
						{
							num = 818839504U * num;
							int num19 = num13;
							int num20 = num15;
							num = 1430549152U + num;
							num18 = checked(num19 + num20);
							num ^= 4292898733U;
						}
						num12 = num18;
						num ^= 1962934285U;
					}
					if (2048937765U != num)
					{
						goto Block_45;
					}
					break;
				case 2:
					num = 1709982208U - num;
					if (num + 753468291U == 0U)
					{
						goto IL_00;
					}
					num = 1834696992U - num;
					if (!7E7D48FC)
					{
						goto IL_30E;
					}
					if (1809582435U != num)
					{
						ulong num21 = 266F6884.6100687B();
						num >>= 16;
						num22 = num21;
						num >>= 25;
						if (num >= 1503662913U)
						{
							goto IL_8F;
						}
						num = 1285173136U << (int)num;
						num23 = 45EC5D6F.6100687B();
						num ^= 359941664U;
						if (795046603U == num)
						{
							goto IL_94;
						}
						if (!77A376FE)
						{
							if (539302766U < num)
							{
								goto Block_15;
							}
						}
						else if (num > 868894532U)
						{
							goto Block_16;
						}
					}
					break;
				case 3:
				{
					num = (148333552U & num);
					if (num > 2112111688U)
					{
						goto IL_00;
					}
					num <<= 14;
					if (7E7D48FC)
					{
						num /= 849962200U;
						if (num << 7 != 0U)
						{
							break;
						}
						ulong num24 = 266F6884.6100687B();
						num = (1501785496U & num);
						ulong num25 = 45EC5D6F.6100687B();
						if (473367090U * num != 0U)
						{
							goto IL_00;
						}
						num <<= 19;
						long num28;
						if (!77A376FE)
						{
							if (num == 38696046U)
							{
								goto IL_94;
							}
							long num26 = (long)num24;
							long num27 = (long)num25;
							num <<= 27;
							num28 = num26 + num27;
						}
						else
						{
							if (num * 1723342777U != 0U)
							{
								break;
							}
							num28 = (long)(checked(num24 + num25));
							num ^= 0U;
						}
						long num29 = num28;
						if ((num ^ 1294869003U) == 0U)
						{
							break;
						}
					}
					else
					{
						if (1127157783U + num == 0U)
						{
							break;
						}
						long num30 = 266F6884.E7FBC3B9();
						num = 48920359U % num;
						long num31 = num30;
						num *= 1626541077U;
						if (1824471272U >= num)
						{
							break;
						}
						long num32 = 45EC5D6F.E7FBC3B9();
						num = 945822180U % num;
						long num33 = num32;
						num = (771121230U & num);
						num = (2131846689U ^ num);
						long num36;
						if (!77A376FE)
						{
							long num34 = num31;
							long num35 = num33;
							num *= 1132878454U;
							num36 = num34 + num35;
						}
						else
						{
							num ^= 1381519467U;
							if (696592596U == num)
							{
								goto IL_00;
							}
							num36 = checked(num31 + num33);
							num ^= 822837888U;
						}
						num |= 2129686726U;
						long num29 = num36;
						num ^= 2129851598U;
					}
					TypeCode typeCode3 = 266F6884.04C738A1();
					TypeCode typeCode4 = typeCode2;
					num &= 1443057442U;
					if (typeCode3 != typeCode4)
					{
						if (1161700144 << (int)num != 0)
						{
							goto Block_61;
						}
					}
					else if (777146032U != num)
					{
						goto Block_62;
					}
					break;
				}
				case 4:
					if (num / 1147935152U != 0U)
					{
						goto IL_00;
					}
					if (7E7D48FC)
					{
						goto IL_3F2;
					}
					num = 1284460474U / num;
					if (num < 411709301U)
					{
						goto Block_25;
					}
					break;
				case 5:
					if ((num ^ 2066230960U) != 0U)
					{
						num = (390668347U & num);
						66026065.28060A8C 28060A8C;
						if (!7E7D48FC)
						{
							num ^= 435431129U;
							if (1832407173U == num)
							{
								goto IL_00;
							}
							28060A8C = 266F6884;
						}
						else
						{
							if (259070761U < num)
							{
								goto IL_00;
							}
							28060A8C = 266F6884.31D8F335();
							num ^= 435431129U;
						}
						num = 1795826146U * num;
						num37 = 28060A8C.B1479B35();
						num = 516568042U / num;
						if (1116018262U > num)
						{
							if (!7E7D48FC)
							{
								goto Block_35;
							}
							num = 1162686280U + num;
							if (num % 1554589610U != 0U)
							{
								goto Block_36;
							}
						}
					}
					break;
				default:
					if (num - 1770800889U != 0U)
					{
						goto IL_8F;
					}
					break;
				}
			}
			IL_30E:
			num *= 346043658U;
			if ((524123742U ^ num) == 0U)
			{
				continue;
			}
			num38 = 266F6884.E7FBC3B9();
			if ((247081731U ^ num) == 0U)
			{
				goto IL_D5;
			}
			num &= 292847054U;
			num39 = 45EC5D6F.E7FBC3B9();
			if (170542599U >= num)
			{
				break;
			}
			num <<= 28;
			if (!77A376FE)
			{
				if (2093626101U != num)
				{
					goto Block_21;
				}
				continue;
			}
			else
			{
				num %= 711152454U;
				if (1051096554U % num != 0U)
				{
					goto Block_22;
				}
				goto IL_D5;
			}
			IL_3F2:
			num = 798165919U << (int)num;
			if (976184022U >= num)
			{
				continue;
			}
			66026065.28060A8C 28060A8C2 = 266F6884.31D8F335();
			num ^= 1024456946U;
			IL_41E:
			num40 = 28060A8C2.88D23451();
			66026065.28060A8C 28060A8C3;
			if (!7E7D48FC)
			{
				28060A8C3 = 45EC5D6F;
			}
			else
			{
				num >>= 25;
				28060A8C3 = 45EC5D6F.31D8F335();
				num ^= 51378419U;
			}
			num /= 1569468652U;
			float num41 = 28060A8C3.88D23451();
			num = 19555378U >> (int)num;
			num42 = num41;
			if (!77A376FE)
			{
				goto Block_28;
			}
			num >>= 22;
			if ((num ^ 1639915420U) != 0U)
			{
				goto Block_29;
			}
			continue;
			Block_25:
			28060A8C2 = 266F6884;
			goto IL_41E;
			IL_57E:
			66026065.28060A8C 28060A8C4;
			double num43 = 28060A8C4.B1479B35();
			num = (1169914042U & num);
			num44 = num43;
			num = 1911901064U - num;
			num >>= 9;
			if (!77A376FE)
			{
				goto Block_37;
			}
			num >>= 14;
			if ((1268400987U ^ num) != 0U)
			{
				goto Block_38;
			}
			continue;
			Block_36:
			28060A8C4 = 45EC5D6F.31D8F335();
			num ^= 1162686280U;
			goto IL_57E;
			Block_35:
			28060A8C4 = 45EC5D6F;
			goto IL_57E;
			Block_45:
			TypeCode typeCode5 = 266F6884.04C738A1();
			TypeCode typeCode6 = typeCode2;
			num = 27865929U / num;
			if (typeCode5 != typeCode6)
			{
				goto Block_46;
			}
			if (1466716556U * num == 0U)
			{
				goto Block_47;
			}
			continue;
			IL_D5:
			num = 1254051991U * num;
			uint num45 = 45EC5D6F.45E9448C();
			int num48;
			if (!77A376FE)
			{
				num = 1938374453U - num;
				if (185152960U / num != 0U)
				{
					continue;
				}
				uint num47;
				int num46 = (int)num47;
				num -= 1396662981U;
				num48 = num46 + (int)num45;
			}
			else
			{
				if (1977878052U == num)
				{
					break;
				}
				uint num47;
				int num49 = (int)num47;
				int num50 = (int)num45;
				num = 856186627U / num;
				num48 = checked(num49 + num50);
				num ^= 3293174896U;
			}
			num *= 663882602U;
			num51 = num48;
			if ((num ^ 1712876102U) != 0U)
			{
				goto Block_5;
			}
			continue;
			IL_94:
			num = 287721292U / num;
			num ^= 41439297U;
			if (7E7D48FC)
			{
				num >>= 11;
				num <<= 26;
				uint num52 = 266F6884.45E9448C();
				num &= 511379538U;
				uint num47 = num52;
				goto IL_D5;
			}
			num = (1373777947U ^ num);
			num %= 1875523802U;
			int num53 = 266F6884.D02DFB88();
			num = 1602752474U * num;
			num54 = num53;
			if (num % 1821201740U == 0U)
			{
				goto IL_46;
			}
			num |= 1294417640U;
			int num55 = 45EC5D6F.D02DFB88();
			num %= 972232256U;
			num56 = num55;
			num >>= 6;
			if (77A376FE)
			{
				goto IL_1E1;
			}
			num /= 53638921U;
			if (num < 1027160811U)
			{
				goto Block_8;
			}
			goto IL_46;
		}
		IL_8F:
		while (1724328226U * num == 0U)
		{
		}
		throw new InvalidOperationException();
		Block_5:
		goto IL_220;
		Block_8:
		int num57 = num54;
		int num58 = num56;
		num >>= 1;
		int num59 = num57 + num58;
		goto IL_204;
		IL_1E1:
		num = (569849134U ^ num);
		int num60 = num54;
		int num61 = num56;
		num |= 1946039364U;
		num59 = checked(num60 + num61);
		num ^= 1946039655U;
		IL_204:
		num = 352528590U << (int)num;
		num51 = num59;
		num ^= 804077230U;
		IL_220:
		num = (612528061U ^ num);
		int 73704D = num51;
		num += 2003650880U;
		return new 66026065.152602F0(73704D);
		Block_15:
		long num62 = (long)(num22 + num23);
		goto IL_2FD;
		Block_16:
		num62 = (long)(checked(num22 + num23));
		num ^= 0U;
		IL_2FD:
		num ^= 328152231U;
		long 156A0AAB = num62;
		goto IL_3BA;
		Block_21:
		long num63 = num38 + num39;
		goto IL_3AE;
		Block_22:
		long num64 = num38;
		num = 1697782934U / num;
		num63 = checked(num64 + num39);
		num += 2684354557U;
		IL_3AE:
		156A0AAB = num63;
		num += 2858507543U;
		IL_3BA:
		return new 66026065.6DA9264D(156A0AAB);
		Block_28:
		num = 305860142U / num;
		float 34DA3CFB = num40 + num42;
		goto IL_4BD;
		Block_29:
		float num65 = num40;
		float num66 = num42;
		num = 945690069U << (int)num;
		34DA3CFB = num65 + num66;
		num ^= 2246139231U;
		IL_4BD:
		num = 186057078U * num;
		return new 66026065.7CEE5B47(34DA3CFB);
		Block_37:
		num = 279579560U - num;
		double num67 = num37;
		num = (988708517U & num);
		double 5FD904DC = num67 + num44;
		goto IL_607;
		Block_38:
		double num68 = num37;
		num %= 1671386955U;
		double num69 = num44;
		num = 1789422093U << (int)num;
		5FD904DC = num68 + num69;
		num ^= 1159938153U;
		IL_607:
		return new 66026065.18527F7D(5FD904DC);
		Block_46:
		num <<= 11;
		num = 1139178252U >> (int)num;
		66026065.30C00244 30C = (66026065.30C00244)45EC5D6F;
		goto IL_7F0;
		Block_47:
		num /= 51535726U;
		30C = (66026065.30C00244)266F6884;
		num += 1139178252U;
		IL_7F0:
		66026065.30C00244 30C2 = 30C;
		num = 1257588205U % num;
		int value = num12;
		num /= 773798113U;
		IntPtr intPtr = new IntPtr(value);
		num &= 284115057U;
		IntPtr intPtr2 = intPtr;
		void* ptr = intPtr2.ToPointer();
		66026065.30C00244 30C3 = 30C2;
		num ^= 338848428U;
		return new 66026065.30C00244(Pointer.Box(ptr, 30C3.3A6449B8()), 30C2.3A6449B8());
		Block_61:
		num = 1068587352U << (int)num;
		66026065.30C00244 30C4 = (66026065.30C00244)45EC5D6F;
		goto IL_A1D;
		Block_62:
		num *= 1777759122U;
		30C4 = (66026065.30C00244)266F6884;
		num += 1068587352U;
		IL_A1D:
		66026065.30C00244 30C5 = 30C4;
		if ((num & 1473262211U) != 0U)
		{
			long num29;
			long value2 = num29;
			num ^= 2111401779U;
			intPtr2 = new IntPtr(value2);
			num = (1987466296U & num);
			void* ptr2 = intPtr2.ToPointer();
			num = 332205148U % num;
			object 15D532E = Pointer.Box(ptr2, 30C5.3A6449B8());
			num |= 2059290090U;
			Type 48732EC = 30C5.3A6449B8();
			num = 1948540854U * num;
			return new 66026065.30C00244(15D532E, 48732EC);
		}
		goto IL_8F;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00213E54 File Offset: 0x00213E54
	private unsafe 66026065.28060A8C 71FD0992(66026065.28060A8C 31761F55, 66026065.28060A8C 223F2C9D, bool 2A1D1A00, bool 16A16B94)
	{
		uint num;
		TypeCode typeCode2;
		ulong num7;
		long num9;
		long num11;
		float num15;
		int 73704D;
		ulong num29;
		float num31;
		double num32;
		double num33;
		int num41;
		66026065.30C00244 30C2;
		IntPtr intPtr;
		for (;;)
		{
			IL_00:
			num = 1947497069U;
			num |= 1108960024U;
			num -= 364673648U;
			TypeCode typeCode = this.6C215FC2(31761F55, 223F2C9D);
			num = 355558392U % num;
			typeCode2 = typeCode;
			if (592738640 << (int)num != 0)
			{
				int num4;
				int num6;
				ulong num12;
				ulong num13;
				for (;;)
				{
					uint num2 = (uint)typeCode2;
					num = 1099043586U >> (int)num;
					uint num3 = num2 - (num ^ 72U);
					num += 50552285U;
					switch (num3)
					{
					case 0:
						break;
					case 1:
						num += 2054441673U;
						if (16A16B94)
						{
							if (1208364447U < num)
							{
								goto Block_35;
							}
						}
						else
						{
							num4 = 31761F55.D02DFB88();
							num = 1055811996U << (int)num;
							if (1862938543U - num == 0U)
							{
								goto IL_91;
							}
							num = 767690448U - num;
							int num5 = 223F2C9D.D02DFB88();
							num = 715073921U * num;
							num6 = num5;
							if (num << 27 == 0U)
							{
								goto IL_00;
							}
							num = 889004642U - num;
							if (!2A1D1A00)
							{
								goto Block_41;
							}
							if (num < 1551049277U)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 2:
						num = 46677156U * num;
						if (16A16B94)
						{
							if (num <= 2066764702U)
							{
								goto IL_00;
							}
							num *= 258364162U;
							num7 = 31761F55.6100687B();
							if (983328856 << (int)num != 0)
							{
								goto Block_12;
							}
						}
						else
						{
							if (1332487946U % num == 0U)
							{
								goto IL_00;
							}
							long num8 = 31761F55.E7FBC3B9();
							num ^= 1281187807U;
							num9 = num8;
							num &= 1089083025U;
							if (1249781885 << (int)num == 0)
							{
								goto IL_91;
							}
							num ^= 1518949075U;
							long num10 = 223F2C9D.E7FBC3B9();
							num = 1926325186U >> (int)num;
							num11 = num10;
							if (1591805469U >> (int)num == 0U)
							{
								goto IL_91;
							}
							if (2A1D1A00)
							{
								goto IL_36B;
							}
							if (num < 1234250452U)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						num = 1086749081U * num;
						if (16A16B94)
						{
							if (num < 1629766313U)
							{
								goto IL_91;
							}
							num12 = 31761F55.6100687B();
							num = 842730390U + num;
							if ((1998610416U ^ num) == 0U)
							{
								continue;
							}
							num = 1193177866U % num;
							num13 = 223F2C9D.6100687B();
							num = 38231880U + num;
							if ((num ^ 1053915348U) == 0U)
							{
								continue;
							}
							if (!2A1D1A00)
							{
								goto Block_49;
							}
							if (751905777U <= num)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							num = (2125991787U | num);
							if (num == 571627195U)
							{
								goto IL_91;
							}
							long num14 = 31761F55.E7FBC3B9();
							num %= 696414025U;
							if (num / 1327896027U == 0U)
							{
								goto Block_53;
							}
						}
						break;
					case 4:
					{
						num *= 303853620U;
						num ^= 1231362317U;
						66026065.28060A8C 28060A8C;
						if (!16A16B94)
						{
							num = (380051981U & num);
							if (1264146259U <= num)
							{
								goto IL_00;
							}
							28060A8C = 31761F55;
						}
						else
						{
							num = 2145648671U << (int)num;
							28060A8C = 31761F55.31D8F335();
							num += 270606853U;
						}
						num15 = 28060A8C.88D23451();
						num = (1795058625U ^ num);
						if (num > 1303596684U)
						{
							goto Block_22;
						}
						continue;
					}
					case 5:
						goto IL_507;
					default:
						if ((num & 148192114U) != 0U)
						{
							goto IL_91;
						}
						break;
					}
					num |= 223765398U;
					if (16A16B94)
					{
						break;
					}
					num &= 401558085U;
					if (821777640U < num)
					{
						goto IL_00;
					}
					int num16 = 31761F55.D02DFB88();
					num -= 2018129640U;
					if ((975378427U ^ num) != 0U)
					{
						goto Block_4;
					}
				}
				num -= 798504512U;
				if (num != 1350067155U)
				{
					goto IL_BD;
				}
				continue;
				Block_4:
				int num17 = 223F2C9D.D02DFB88();
				num = (1274241642U & num);
				int num18 = num17;
				if (1830628568U < num)
				{
					continue;
				}
				num = (904861639U | num);
				int num20;
				if (!2A1D1A00)
				{
					if ((923408637U ^ num) == 0U)
					{
						goto IL_BD;
					}
					int num16;
					int num19 = num16;
					num >>= 18;
					num20 = num19 - num18;
				}
				else
				{
					num = 1641301445U << (int)num;
					if (439247764U >= num)
					{
						continue;
					}
					int num16;
					int num21 = num16;
					num >>= 26;
					int num22 = num18;
					num = 608847000U - num;
					num20 = checked(num21 - num22);
					num += 3686124399U;
				}
				num = 844838530U / num;
				73704D = num20;
				num += 4294760987U;
				IL_208:
				if (num <= 967723451U)
				{
					goto Block_9;
				}
				continue;
				IL_D9:
				uint num23 = 223F2C9D.45E9448C();
				num <<= 27;
				uint num25;
				int num26;
				if (!2A1D1A00)
				{
					num = (335682122U & num);
					int num24 = (int)num25;
					num <<= 1;
					num26 = num24 - (int)num23;
				}
				else
				{
					int num27 = (int)num25;
					num = 462909207U / num;
					num26 = checked(num27 - (int)num23);
					num += 0U;
				}
				73704D = num26;
				goto IL_208;
				IL_BD:
				num = 2035896548U % num;
				num25 = 31761F55.45E9448C();
				num %= 175981245U;
				goto IL_D9;
				Block_12:
				num = 1859587918U + num;
				ulong num28 = 223F2C9D.6100687B();
				num *= 1761888545U;
				num29 = num28;
				num %= 1953573032U;
				if (!2A1D1A00)
				{
					goto Block_13;
				}
				if (num < 1685409780U)
				{
					goto Block_14;
				}
				continue;
				Block_22:
				66026065.28060A8C 28060A8C2;
				if (!16A16B94)
				{
					num = 167133245U / num;
					28060A8C2 = 223F2C9D;
				}
				else
				{
					num = (1460495999U | num);
					28060A8C2 = 223F2C9D.31D8F335();
					num ^= 2147446783U;
				}
				num = 1218390523U >> (int)num;
				float num30 = 28060A8C2.88D23451();
				num = 899170713U * num;
				num31 = num30;
				num ^= 534271381U;
				if ((1298352228U ^ num) == 0U)
				{
					continue;
				}
				num = 2650179U << (int)num;
				if (!2A1D1A00)
				{
					goto Block_25;
				}
				if (num - 949159131U != 0U)
				{
					goto Block_26;
				}
				goto IL_D9;
				IL_507:
				num = 1619200530U - num;
				if ((431971299U & num) == 0U)
				{
					continue;
				}
				num = 641821661U + num;
				66026065.28060A8C 28060A8C3;
				if (!16A16B94)
				{
					28060A8C3 = 31761F55;
				}
				else
				{
					num -= 829126528U;
					num <<= 11;
					28060A8C3 = 31761F55.31D8F335();
					num ^= 784572369U;
				}
				num32 = 28060A8C3.B1479B35();
				num >>= 13;
				66026065.28060A8C 28060A8C4;
				if (!16A16B94)
				{
					28060A8C4 = 223F2C9D;
				}
				else
				{
					if (num > 1096047173U)
					{
						continue;
					}
					28060A8C4 = 223F2C9D.31D8F335();
					num += 0U;
				}
				num33 = 28060A8C4.B1479B35();
				num >>= 31;
				if (475282056U - num == 0U)
				{
					continue;
				}
				if (!2A1D1A00)
				{
					goto Block_32;
				}
				if (984513154U + num != 0U)
				{
					goto Block_33;
				}
				continue;
				Block_35:
				num = 327036263U << (int)num;
				uint num34 = 31761F55.45E9448C();
				if (num < 1401028823U)
				{
					continue;
				}
				num = 1089104900U + num;
				uint num35 = 223F2C9D.45E9448C();
				num = (1692084643U ^ num);
				int num38;
				if (!2A1D1A00)
				{
					if (num - 1712266537U == 0U)
					{
						continue;
					}
					int num36 = (int)num34;
					num = 2025684145U << (int)num;
					int num37 = (int)num35;
					num = 1198477405U << (int)num;
					num38 = num36 - num37;
				}
				else
				{
					int num39 = (int)num34;
					num = 1990222532U >> (int)num;
					int num40 = (int)num35;
					num += 1690581786U;
					num38 = checked(num39 - num40);
					num += 3787314302U;
				}
				num = 1922529287U % num;
				num41 = num38;
				IL_78C:
				if (818285929U > num)
				{
					goto Block_43;
				}
				continue;
				IL_776:
				num = (1548629684U ^ num);
				int num42;
				num41 = num42;
				num += 173219428U;
				goto IL_78C;
				Block_42:
				int num43 = num4;
				num /= 1205209096U;
				num42 = checked(num43 - num6);
				num ^= 2090549234U;
				goto IL_776;
				Block_41:
				int num44 = num4;
				num = (1553538930U | num);
				num42 = num44 - num6;
				goto IL_776;
				Block_49:
				num = 523714937U * num;
				long num45;
				if (1190748190U <= num)
				{
					num45 = (long)(num12 - num13);
					goto IL_8EE;
				}
				continue;
				Block_53:
				long num46 = 223F2C9D.E7FBC3B9();
				num >>= 0;
				if ((num & 790327713U) == 0U)
				{
					continue;
				}
				long num49;
				if (!2A1D1A00)
				{
					num = 859923841U << (int)num;
					long num14;
					long num47 = num14;
					num /= 1281828390U;
					long num48 = num46;
					num = 2059144962U + num;
					num49 = num47 - num48;
				}
				else
				{
					num = 729566457U >> (int)num;
					if (1366110750U <= num)
					{
						continue;
					}
					long num14;
					long num50 = num14;
					long num51 = num46;
					num /= 1325562700U;
					num49 = checked(num50 - num51);
					num ^= 2059144962U;
				}
				long num52 = num49;
				num += 2386884990U;
				IL_9C5:
				if (num == 1752132445U)
				{
					continue;
				}
				TypeCode typeCode3 = 31761F55.04C738A1();
				num <<= 4;
				66026065.30C00244 30C;
				if (typeCode3 != typeCode2)
				{
					if (1304758170U + num == 0U)
					{
						continue;
					}
					num <<= 4;
					30C = (66026065.30C00244)223F2C9D;
				}
				else
				{
					if ((num ^ 719001853U) == 0U)
					{
						continue;
					}
					30C = (66026065.30C00244)31761F55;
					num += 1895299072U;
				}
				30C2 = 30C;
				long value = num52;
				num += 2111399396U;
				intPtr = new IntPtr(value);
				num = 1098127410U - num;
				if (1454320856U + num != 0U)
				{
					goto Block_61;
				}
				continue;
				IL_8EE:
				num &= 256444817U;
				num52 = num45;
				goto IL_9C5;
				Block_51:
				long num53 = (long)num12;
				long num54 = (long)num13;
				num = (2145782973U & num);
				num45 = checked(num53 - num54);
				num ^= 3762371282U;
				goto IL_8EE;
			}
			break;
		}
		IL_91:
		num >>= 10;
		throw new InvalidOperationException();
		Block_9:
		return new 66026065.152602F0(73704D);
		Block_13:
		long num55 = (long)(num7 - num29);
		goto IL_2B9;
		Block_14:
		long num56 = (long)num7;
		long num57 = (long)num29;
		num &= 1516311503U;
		num55 = checked(num56 - num57);
		num += 68061200U;
		IL_2B9:
		num %= 650934950U;
		long num58 = num55;
		goto IL_3A4;
		Block_19:
		long num59 = num9;
		num = (601901587U ^ num);
		long num60 = num11;
		num = 1366646988U % num;
		long num61 = num59 - num60;
		goto IL_398;
		IL_36B:
		num ^= 496855556U;
		long num62 = num9;
		num = 1595298791U * num;
		long num63 = num11;
		num >>= 17;
		num61 = checked(num62 - num63);
		num += 162827942U;
		IL_398:
		num58 = num61;
		num ^= 234498472U;
		IL_3A4:
		num = (755368514U & num);
		long 156A0AAB = num58;
		num <<= 16;
		return new 66026065.6DA9264D(156A0AAB);
		Block_25:
		num &= 1018047760U;
		float num64 = num15;
		num /= 380455686U;
		float 34DA3CFB = num64 - num31;
		goto IL_4F7;
		Block_26:
		float num65 = num15;
		float num66 = num31;
		num = 1202145212U - num;
		34DA3CFB = num65 - num66;
		num += 3373840452U;
		IL_4F7:
		num = 338118187U - num;
		return new 66026065.7CEE5B47(34DA3CFB);
		Block_32:
		num &= 525558952U;
		double num67 = num32;
		num %= 859926920U;
		double num68 = num33;
		num = 330766198U >> (int)num;
		double 5FD904DC = num67 - num68;
		goto IL_601;
		Block_33:
		5FD904DC = num32 - num33;
		num += 330766198U;
		IL_601:
		num = 361323987U - num;
		return new 66026065.18527F7D(5FD904DC);
		Block_43:
		66026065.30C00244 30C3;
		if (31761F55.04C738A1() != typeCode2)
		{
			30C3 = (66026065.30C00244)223F2C9D;
		}
		else
		{
			num = 321342029U - num;
			30C3 = (66026065.30C00244)31761F55;
			num ^= 3436643593U;
		}
		66026065.30C00244 30C4 = 30C3;
		num += 951610026U;
		int value2 = num41;
		num <<= 2;
		IntPtr intPtr2 = new IntPtr(value2);
		num ^= 1950301005U;
		intPtr = intPtr2;
		num *= 270821297U;
		void* ptr = intPtr.ToPointer();
		66026065.30C00244 30C5 = 30C4;
		num += 1329735358U;
		Type type = 30C5.3A6449B8();
		num |= 1807636738U;
		object 15D532E = Pointer.Box(ptr, type);
		Type 48732EC = 30C4.3A6449B8();
		num = 1770403422U << (int)num;
		return new 66026065.30C00244(15D532E, 48732EC);
		Block_61:
		num = 273693961U % num;
		void* ptr2 = intPtr.ToPointer();
		66026065.30C00244 30C6 = 30C2;
		num |= 34938912U;
		Type type2 = 30C6.3A6449B8();
		num *= 1559114925U;
		object 15D532E2 = Pointer.Box(ptr2, type2);
		66026065.30C00244 30C7 = 30C2;
		num += 293429445U;
		Type 48732EC2 = 30C7.3A6449B8();
		num &= 1568239693U;
		return new 66026065.30C00244(15D532E2, 48732EC2);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00214918 File Offset: 0x00214918
	private 66026065.28060A8C 2A965EEF(66026065.28060A8C 3D240467, 66026065.28060A8C 33352FB8, bool 1B56013D, bool 30B72C6A)
	{
		uint num;
		int num4;
		int num5;
		uint num6;
		uint num7;
		long num15;
		float num24;
		float num25;
		for (;;)
		{
			IL_00:
			num = 1034705655U;
			TypeCode typeCode = this.6C215FC2(3D240467, 33352FB8);
			num %= 1537887682U;
			TypeCode typeCode2 = typeCode;
			num |= 1678837468U;
			if (1086204797U >= num)
			{
				goto IL_7C;
			}
			for (;;)
			{
				IL_2B:
				TypeCode typeCode3 = typeCode2;
				num |= 1200578787U;
				uint num2 = num - 2143256310U;
				num = 2115900116U << (int)num;
				switch (typeCode3 - num2)
				{
				case 0:
					while (!30B72C6A)
					{
						num = (1257204651U | num);
						if (num - 1641949762U == 0U)
						{
							goto IL_00;
						}
						int num3 = 3D240467.D02DFB88();
						num = 1867080589U * num;
						num4 = num3;
						if ((815021669U ^ num) != 0U)
						{
							num5 = 33352FB8.D02DFB88();
							num &= 2127134485U;
							num = 1012804508U - num;
							if (!1B56013D)
							{
								goto Block_9;
							}
							if (num >> 5 != 0U)
							{
								goto Block_11;
							}
							goto IL_2B;
						}
					}
					goto Block_2;
				case 1:
				case 3:
					goto IL_54E;
				case 2:
					goto IL_1EA;
				case 4:
					goto IL_32E;
				case 5:
					goto IL_449;
				}
				break;
			}
			if (num * 425789262U == 0U)
			{
				break;
			}
			continue;
			Block_2:
			num <<= 2;
			num6 = 3D240467.45E9448C();
			if (1832013845U < num)
			{
				continue;
			}
			num = 1289754896U + num;
			num7 = 33352FB8.45E9448C();
			if ((num ^ 1538154567U) == 0U)
			{
				goto IL_7C;
			}
			num |= 1603485139U;
			if (!1B56013D)
			{
				goto Block_5;
			}
			num = 1651265101U / num;
			if (num + 1553144664U != 0U)
			{
				goto Block_6;
			}
			continue;
			IL_1EA:
			num /= 1556419863U;
			if (30B72C6A)
			{
				if (657929921U <= num)
				{
					goto IL_7C;
				}
				ulong num8 = 3D240467.6100687B();
				if (num == 1525362751U)
				{
					continue;
				}
				ulong num9 = 33352FB8.6100687B();
				num *= 1375103885U;
				long num12;
				if (!1B56013D)
				{
					if (num << 7 != 0U)
					{
						continue;
					}
					long num10 = (long)num8;
					long num11 = (long)num9;
					num = 723023758U + num;
					num12 = num10 * num11;
				}
				else
				{
					num = 2093614422U + num;
					long num13 = (long)num8;
					num *= 1645556280U;
					long num14 = (long)num9;
					num %= 1858739858U;
					num12 = checked(num13 * num14);
					num ^= 911311198U;
				}
				num15 = num12;
				if (1401034870U <= num)
				{
					goto IL_7C;
				}
			}
			else
			{
				if (101849093U >> (int)num == 0U)
				{
					continue;
				}
				num ^= 457779163U;
				long num16 = 3D240467.E7FBC3B9();
				num /= 18377668U;
				long num17 = num16;
				long num18 = 33352FB8.E7FBC3B9();
				num = 509561545U % num;
				num = 1901360132U % num;
				long num20;
				if (!1B56013D)
				{
					if (num << 24 != 0U)
					{
						goto IL_7C;
					}
					long num19 = num17;
					num <<= 1;
					num20 = num19 * num18;
				}
				else
				{
					num = 192755955U - num;
					long num21 = num17;
					long num22 = num18;
					num = 368520969U / num;
					num20 = checked(num21 * num22);
					num += uint.MaxValue;
				}
				num15 = num20;
				num += 723023758U;
			}
			if (num % 796949770U != 0U)
			{
				goto Block_21;
			}
			continue;
			IL_32E:
			num %= 211634274U;
			if (num > 1415272387U)
			{
				continue;
			}
			num = (1069044843U & num);
			66026065.28060A8C 28060A8C;
			if (!30B72C6A)
			{
				num = (654386809U & num);
				if ((975128683U & num) != 0U)
				{
					continue;
				}
				28060A8C = 3D240467;
			}
			else
			{
				if (num - 213728620U == 0U)
				{
					goto IL_117;
				}
				28060A8C = 3D240467.31D8F335();
				num ^= 0U;
			}
			num |= 62980693U;
			float num23 = 28060A8C.88D23451();
			num >>= 27;
			num24 = num23;
			num = 1880176768U << (int)num;
			66026065.28060A8C 28060A8C2;
			if (!30B72C6A)
			{
				num *= 1807033502U;
				28060A8C2 = 33352FB8;
			}
			else
			{
				num = 295595797U * num;
				if (num >= 537144573U)
				{
					continue;
				}
				28060A8C2 = 33352FB8.31D8F335();
				num ^= 251395456U;
			}
			num >>= 3;
			num25 = 28060A8C2.88D23451();
			num %= 229120980U;
			num = 687350977U % num;
			if (!1B56013D)
			{
				if (109409993U != num)
				{
					goto Block_29;
				}
				continue;
			}
			else
			{
				if ((807223439U ^ num) != 0U)
				{
					goto Block_30;
				}
				continue;
			}
			IL_449:
			if (num < 780813870U)
			{
				goto Block_31;
			}
		}
		num ^= 0U;
		IL_7C:
		goto IL_54E;
		Block_5:
		num = 43653926U * num;
		int num26 = (int)num6;
		num = 1301183112U + num;
		int num27 = (int)num7;
		num /= 1495951941U;
		int num28 = num26 * num27;
		goto IL_115;
		Block_6:
		int num29 = (int)num6;
		int num30 = (int)num7;
		num = (713753453U ^ num);
		num28 = checked(num29 * num30);
		num ^= 713753452U;
		IL_115:
		int 73704D = num28;
		IL_117:
		goto IL_1DA;
		Block_9:
		num = 662110764U << (int)num;
		int num32;
		if (1974549008U / num != 0U)
		{
			int num31 = num4;
			num = 760236563U << (int)num;
			num32 = num31 * num5;
			goto IL_1C8;
		}
		goto IL_7C;
		Block_11:
		int num33 = num4;
		num = 1576546568U << (int)num;
		int num34 = num5;
		num = 315377351U - num;
		num32 = checked(num33 * num34);
		num ^= 2744913108U;
		IL_1C8:
		num /= 1987382881U;
		73704D = num32;
		num += 0U;
		IL_1DA:
		num += 1766145224U;
		return new 66026065.152602F0(73704D);
		Block_21:
		long 156A0AAB = num15;
		num = 1379471497U >> (int)num;
		return new 66026065.6DA9264D(156A0AAB);
		Block_29:
		double num35 = (double)num24;
		double num36 = (double)num25;
		num >>= 27;
		double num37 = num35 * num36;
		goto IL_43A;
		Block_30:
		num37 = (double)(num24 * num25);
		num += 4292658879U;
		IL_43A:
		num -= 1670911349U;
		return new 66026065.18527F7D(num37);
		Block_31:
		66026065.28060A8C 28060A8C3;
		if (!30B72C6A)
		{
			num = 643769383U << (int)num;
			if (num > 2121805703U)
			{
				goto IL_7C;
			}
			28060A8C3 = 3D240467;
		}
		else
		{
			num = 350245579U * num;
			num = (1356562348U | num);
			28060A8C3 = 3D240467.31D8F335();
			num ^= 1988385675U;
		}
		num -= 1436097812U;
		double num38 = 28060A8C3.B1479B35();
		num &= 1147535427U;
		double num39 = num38;
		num = 241631953U >> (int)num;
		66026065.28060A8C 28060A8C4;
		if (!30B72C6A)
		{
			num %= 2072194810U;
			28060A8C4 = 33352FB8;
		}
		else
		{
			num = 12201488U >> (int)num;
			28060A8C4 = 33352FB8.31D8F335();
			num ^= 30203994U;
		}
		num = 633492012U / num;
		double num40 = 28060A8C4.B1479B35();
		num &= 771361518U;
		double 5FD904DC;
		if (!1B56013D)
		{
			5FD904DC = num39 * num40;
		}
		else
		{
			num = (871702029U | num);
			double num41 = num39;
			num = (1912750090U | num);
			double num42 = num40;
			num = (951200190U ^ num);
			5FD904DC = num41 * num42;
			num ^= 1262843829U;
		}
		num = 1070079173U >> (int)num;
		return new 66026065.18527F7D(5FD904DC);
		IL_54E:
		if (num <= 2104891290U)
		{
			throw new InvalidOperationException();
		}
		goto IL_7C;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00214E84 File Offset: 0x00214E84
	private 66026065.28060A8C 4FA71865(66026065.28060A8C 51DC3310, 66026065.28060A8C 094A0DCB, bool 4CA9451E)
	{
		uint num = 631598179U;
		if (num / 1794381508U == 0U)
		{
			for (;;)
			{
				num *= 997290697U;
				num = 503321468U >> (int)num;
				TypeCode typeCode = this.6C215FC2(51DC3310, 094A0DCB);
				if (2123787630U <= num)
				{
					goto IL_74;
				}
				for (;;)
				{
					switch (typeCode - (TypeCode)(num ^ 10U))
					{
					case 0:
						if (1284598812U >= num)
						{
							goto Block_2;
						}
						continue;
					case 1:
					case 3:
						goto IL_30D;
					case 2:
						goto IL_13B;
					case 4:
						goto IL_1D7;
					case 5:
						goto IL_287;
					}
					goto Block_1;
				}
				IL_13B:
				num = 841707354U >> (int)num;
				if (!4CA9451E)
				{
					goto IL_17C;
				}
				if (1115445494U >= num)
				{
					goto Block_6;
				}
				continue;
				IL_287:
				num -= 216743482U;
				if (1902477226U % num != 0U)
				{
					goto Block_10;
				}
			}
			Block_1:
			num ^= 0U;
			goto IL_74;
			Block_2:
			num = 898196460U << (int)num;
			int 73704D;
			if (4CA9451E)
			{
				num |= 1223894779U;
				if (1753689793U >> (int)num == 0U)
				{
					goto IL_74;
				}
				int num2 = (int)51DC3310.45E9448C();
				num |= 259468451U;
				num = (952833964U | num);
				uint num3 = 094A0DCB.45E9448C();
				73704D = num2 / (int)num3;
			}
			else
			{
				num = (886266022U & num);
				int num4 = 51DC3310.D02DFB88();
				num >>= 7;
				int num5 = 094A0DCB.D02DFB88();
				int num6 = num5;
				num /= 1295856558U;
				int num7 = num4 / num6;
				num <<= 25;
				73704D = num7;
				num ^= 4294918143U;
			}
			num /= 698185474U;
			return new 66026065.152602F0(73704D);
			Block_6:
			long num8 = (long)51DC3310.6100687B();
			num = (387142029U & num);
			ulong num9 = 094A0DCB.6100687B();
			long num10 = num8 / (long)num9;
			goto IL_1C6;
			IL_17C:
			num = 937319975U >> (int)num;
			long num11 = 51DC3310.E7FBC3B9();
			num >>= 20;
			long num12 = 094A0DCB.E7FBC3B9();
			num = 852044100U + num;
			long num13 = num12;
			num *= 352854304U;
			num10 = num11 / num13;
			num ^= 597142793U;
			IL_1C6:
			long 156A0AAB = num10;
			num %= 1734832689U;
			return new 66026065.6DA9264D(156A0AAB);
			IL_1D7:
			num >>= 11;
			if (1888776844U * num == 0U)
			{
				66026065.28060A8C 28060A8C;
				if (!4CA9451E)
				{
					num = (1247169100U & num);
					28060A8C = 51DC3310;
				}
				else
				{
					num <<= 11;
					28060A8C = 51DC3310.31D8F335();
					num ^= 0U;
				}
				float num14 = 28060A8C.88D23451();
				num = (214976432U ^ num);
				66026065.28060A8C 28060A8C2;
				if (!4CA9451E)
				{
					num |= 1772508849U;
					28060A8C2 = 094A0DCB;
				}
				else
				{
					num = 43272277U << (int)num;
					28060A8C2 = 094A0DCB.31D8F335();
					num += 631330737U;
				}
				float num15 = 28060A8C2.88D23451();
				num = 1090137932U / num;
				float num16 = num15;
				float 34DA3CFB = num14 / num16;
				num &= 169235525U;
				return new 66026065.7CEE5B47(34DA3CFB);
			}
			goto IL_74;
			Block_10:
			66026065.28060A8C 28060A8C3;
			if (!4CA9451E)
			{
				num = 1521369791U >> (int)num;
				28060A8C3 = 51DC3310;
			}
			else
			{
				28060A8C3 = 51DC3310.31D8F335();
				num ^= 4080637672U;
			}
			double num17 = 28060A8C3.B1479B35();
			num = 197592161U / num;
			66026065.28060A8C 28060A8C4;
			if (!4CA9451E)
			{
				28060A8C4 = 094A0DCB;
			}
			else
			{
				28060A8C4 = 094A0DCB.31D8F335();
				num ^= 0U;
			}
			double num18 = 28060A8C4.B1479B35();
			num &= 1846892182U;
			return new 66026065.18527F7D(num17 / num18);
		}
		IL_74:
		IL_30D:
		num = (2023056687U ^ num);
		throw new InvalidOperationException();
	}

	// Token: 0x060000BE RID: 190 RVA: 0x002151B0 File Offset: 0x002151B0
	private 66026065.28060A8C 60E804D7(66026065.28060A8C 2E04682D, 66026065.28060A8C 5815766B, bool 35AD3BC7)
	{
		uint num = 1214649139U;
		for (;;)
		{
			TypeCode typeCode = 2E04682D.04C738A1();
			for (;;)
			{
				TypeCode typeCode2 = typeCode;
				uint num2 = num + 3080318166U;
				num = 1203596203U - num;
				if (typeCode2 != num2)
				{
					num %= 435176418U;
					TypeCode typeCode3 = typeCode;
					uint num3 = num + 3927640709U;
					num = 95826711U << (int)num;
					if (typeCode3 != num3)
					{
						break;
					}
					num &= 718230504U;
					if (num + 738664464U == 0U)
					{
						continue;
					}
					num = 1907431762U + num;
					if (35AD3BC7)
					{
						goto Block_8;
					}
					if (799569182U != num)
					{
						goto Block_9;
					}
				}
				num >>= 3;
				num &= 1693263651U;
				if (!35AD3BC7)
				{
					goto IL_B5;
				}
				if ((2130401902U & num) != 0U)
				{
					goto Block_5;
				}
			}
			if ((1827039577U & num) == 0U)
			{
				continue;
			}
			num = 746588347U << (int)num;
			if (num >= 717117838U)
			{
				goto Block_10;
			}
			continue;
			IL_B5:
			if (894130003U + num != 0U)
			{
				goto Block_6;
			}
		}
		Block_5:
		int num4 = (int)2E04682D.45E9448C();
		num <<= 27;
		num ^= 968832393U;
		uint num5 = 5815766B.45E9448C();
		num = 1507935233U / num;
		int num6 = (int)num5;
		num = 742991502U << (int)num;
		return new 66026065.152602F0(num4 % num6);
		Block_6:
		num = (811076625U | num);
		int num7 = 2E04682D.D02DFB88();
		int num8 = 5815766B.D02DFB88();
		num ^= 748427596U;
		int 73704D = num7 % num8;
		num = 550262972U % num;
		return new 66026065.152602F0(73704D);
		Block_8:
		num |= 1612081163U;
		num = (77604790U & num);
		long num9 = (long)2E04682D.6100687B();
		ulong num10 = 5815766B.6100687B();
		num = 252461410U + num;
		long 156A0AAB = num9 % (long)num10;
		num %= 408247373U;
		return new 66026065.6DA9264D(156A0AAB);
		Block_9:
		num = 2077895833U - num;
		long num11 = 2E04682D.E7FBC3B9();
		num += 1373831217U;
		long num12 = 5815766B.E7FBC3B9();
		long 156A0AAB2 = num11 % num12;
		num |= 409666056U;
		return new 66026065.6DA9264D(156A0AAB2);
		Block_10:
		throw new InvalidOperationException();
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0021535C File Offset: 0x0021535C
	private 66026065.28060A8C 2F957EEB(66026065.28060A8C 65C75B10, 66026065.28060A8C 68C460AC)
	{
		uint num;
		for (;;)
		{
			num = 34175476U;
			num |= 1353278574U;
			TypeCode typeCode = this.6C215FC2(65C75B10, 68C460AC);
			num <<= 3;
			TypeCode typeCode2 = typeCode;
			num &= 2040153266U;
			if (616841642U <= num)
			{
				goto IL_78;
			}
			for (;;)
			{
				object obj = typeCode2;
				num = 1589056758U / num;
				object obj2 = num - 4294967292U;
				num /= 1795966828U;
				object obj3 = obj - obj2;
				num = 1727732630U + num;
				switch (obj3)
				{
				case 0:
					goto IL_7D;
				case 1:
				case 3:
					goto IL_1EC;
				case 2:
					goto IL_C6;
				case 4:
				{
					if (1215969074U >= num)
					{
						goto IL_78;
					}
					uint size = (uint)IntPtr.Size;
					num %= 153880466U;
					if (size == (num ^ 35047508U))
					{
						goto IL_152;
					}
					if (387456356U >= num)
					{
						goto Block_4;
					}
					continue;
				}
				case 5:
					goto IL_16D;
				}
				goto Block_0;
			}
			IL_7D:
			num = 1102860085U - num;
			if ((num ^ 1800875093U) != 0U)
			{
				goto Block_1;
			}
		}
		Block_0:
		num += 0U;
		IL_78:
		goto IL_1EC;
		Block_1:
		num = 2080067242U - num;
		int num2 = 65C75B10.D02DFB88();
		num = 2077693674U * num;
		int num3 = 68C460AC.D02DFB88();
		num = (1173437082U ^ num);
		int num4 = num3;
		int num5 = num4;
		num = 890505008U % num;
		return new 66026065.152602F0(num2 ^ num5);
		IL_C6:
		num = 619318684U + num;
		long num6 = 65C75B10.E7FBC3B9();
		num = 1564365462U - num;
		num /= 2086748278U;
		long num7 = 68C460AC.E7FBC3B9();
		num |= 1555779716U;
		long num8 = num7;
		num = 417925995U >> (int)num;
		long num9 = num8;
		num = (1077636028U ^ num);
		long 156A0AAB = num6 ^ num9;
		num -= 1530155113U;
		return new 66026065.6DA9264D(156A0AAB);
		Block_4:
		float 34DA3CFB = 0f;
		goto IL_15F;
		IL_152:
		34DA3CFB = float.NaN;
		num += 0U;
		IL_15F:
		num = 1280199829U * num;
		return new 66026065.7CEE5B47(34DA3CFB);
		IL_16D:
		num |= 1704426472U;
		if (104605903U < num)
		{
			int size2 = IntPtr.Size;
			uint num10 = num ^ 1744796666U;
			num *= 1109991248U;
			double 5FD904DC;
			if (size2 != num10)
			{
				num = 1144786279U / num;
				if (num * 1348497544U != 0U)
				{
					goto IL_C6;
				}
				5FD904DC = 0.0;
			}
			else
			{
				num = 1645748425U << (int)num;
				if (num - 585571255U == 0U)
				{
					goto IL_78;
				}
				5FD904DC = double.NaN;
				num += 2649218871U;
			}
			return new 66026065.18527F7D(5FD904DC);
		}
		IL_1EC:
		throw new InvalidOperationException();
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0021555C File Offset: 0x0021555C
	private 66026065.28060A8C 28AB10D0(66026065.28060A8C 18D947D6, 66026065.28060A8C 4EC36EFE)
	{
		uint num = 105930235U;
		for (;;)
		{
			num = 842736244U >> (int)num;
			num -= 1560554259U;
			TypeCode typeCode = this.6C215FC2(18D947D6, 4EC36EFE);
			if (num != 581451089U)
			{
				object obj = typeCode;
				object obj2 = num + 1560554262U;
				num = (1067870885U | num);
				object obj3 = obj - obj2;
				num += 33227857U;
				switch (obj3)
				{
				case 0:
					goto IL_73;
				case 1:
				case 3:
					goto IL_1F0;
				case 2:
					goto IL_C0;
				case 4:
				{
					num >>= 11;
					if ((867398398U ^ num) == 0U)
					{
						continue;
					}
					int size = IntPtr.Size;
					num ^= 611647908U;
					uint num2 = num ^ 611139264U;
					num /= 1334799149U;
					if (size != num2)
					{
						goto Block_5;
					}
					num = (479739405U ^ num);
					if (num >= 187651537U)
					{
						goto Block_6;
					}
					continue;
				}
				case 5:
					num &= 1586974712U;
					if ((num & 47786194U) != 0U)
					{
						goto Block_7;
					}
					continue;
				}
				break;
			}
		}
		num += 0U;
		IL_6E:
		goto IL_1F0;
		IL_73:
		num >>= 28;
		int num3 = 18D947D6.D02DFB88();
		num = 264263398U - num;
		num = (594430341U & num);
		int num4 = 4EC36EFE.D02DFB88();
		num -= 1081940856U;
		int num5 = num4;
		num = (717323711U ^ num);
		int num6 = num5;
		num = (258159965U ^ num);
		int 73704D = num3 | num6;
		num %= 224461277U;
		return new 66026065.152602F0(73704D);
		IL_C0:
		num = 234510045U << (int)num;
		if (1887707273U != num)
		{
			long num7 = 18D947D6.E7FBC3B9();
			num |= 1734305846U;
			long num8 = 4EC36EFE.E7FBC3B9();
			long num9 = num8;
			num = 795287954U + num;
			long 156A0AAB = num7 | num9;
			num &= 1298818897U;
			return new 66026065.6DA9264D(156A0AAB);
		}
		goto IL_73;
		Block_5:
		num = 1975203463U * num;
		float 34DA3CFB = 0f;
		goto IL_16D;
		Block_6:
		34DA3CFB = float.NaN;
		num ^= 479739405U;
		IL_16D:
		num += 1386953097U;
		return new 66026065.7CEE5B47(34DA3CFB);
		Block_7:
		int size2 = IntPtr.Size;
		num = (1426201741U ^ num);
		uint num10 = num ^ 361832385U;
		num += 1167329902U;
		double 5FD904DC;
		if (size2 != num10)
		{
			if (num <= 978738770U)
			{
				goto IL_6E;
			}
			5FD904DC = 0.0;
		}
		else
		{
			num ^= 487742564U;
			5FD904DC = double.NaN;
			num ^= 487742564U;
		}
		num ^= 1554270425U;
		return new 66026065.18527F7D(5FD904DC);
		IL_1F0:
		throw new InvalidOperationException();
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00215760 File Offset: 0x00215760
	private 66026065.28060A8C 62206324(66026065.28060A8C 5D371C03, 66026065.28060A8C 20A5775E)
	{
		uint num;
		for (;;)
		{
			TypeCode typeCode = this.6C215FC2(5D371C03, 20A5775E);
			num = 384724424U;
			TypeCode typeCode2 = typeCode;
			num *= 271404515U;
			object obj = typeCode2;
			object obj2 = num ^ 3633872977U;
			num = (1847531651U | num);
			object obj3 = obj - obj2;
			num = 183915641U - num;
			switch (obj3)
			{
			case 0:
				goto IL_5A;
			case 1:
			case 3:
				goto IL_19E;
			case 2:
				goto IL_A9;
			case 4:
				num = (1717917751U ^ num);
				if (46093878U <= num)
				{
					goto Block_1;
				}
				continue;
			case 5:
			{
				num = (1066280570U ^ num);
				int size = IntPtr.Size;
				uint num2 = num ^ 869834208U;
				num <<= 31;
				if (size != num2)
				{
					goto Block_3;
				}
				num += 855008672U;
				if (2091143444U >= num)
				{
					goto Block_4;
				}
				continue;
			}
			}
			break;
		}
		num += 0U;
		goto IL_19E;
		IL_5A:
		num = 224336329U << (int)num;
		num = 893062401U - num;
		int num3 = 5D371C03.D02DFB88();
		num = 2079328660U >> (int)num;
		int num4 = 20A5775E.D02DFB88();
		num ^= 750527680U;
		int num5 = num4;
		int 73704D = num3 & num5;
		num = 85460466U >> (int)num;
		return new 66026065.152602F0(73704D);
		IL_A9:
		num = (936579013U & num);
		long num6 = 5D371C03.E7FBC3B9();
		num %= 1210734258U;
		num = 2026637828U / num;
		long num7 = 20A5775E.E7FBC3B9();
		long 156A0AAB = num6 & num7;
		num |= 41299765U;
		return new 66026065.6DA9264D(156A0AAB);
		Block_1:
		float 34DA3CFB;
		if (IntPtr.Size != (int)(num - 1781785509U))
		{
			num = 1118645157U + num;
			34DA3CFB = 0f;
		}
		else
		{
			num &= 1956453409U;
			34DA3CFB = float.NaN;
			num ^= 3438284655U;
		}
		num = 867844959U >> (int)num;
		return new 66026065.7CEE5B47(34DA3CFB);
		Block_3:
		double 5FD904DC = 0.0;
		goto IL_190;
		Block_4:
		5FD904DC = double.NaN;
		num ^= 855008672U;
		IL_190:
		num <<= 3;
		return new 66026065.18527F7D(5FD904DC);
		IL_19E:
		throw new InvalidOperationException();
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00215910 File Offset: 0x00215910
	private int 0AAF37FE(66026065.28060A8C 0E485D74, 66026065.28060A8C 44A41FA8, bool 70D15AEC, int 374777DD)
	{
		uint num = 420028896U;
		for (;;)
		{
			IL_07:
			num = 1632442693U - num;
			int num2 = 374777DD;
			num = (1839007698U & num);
			for (;;)
			{
				IL_1E:
				TypeCode typeCode = 0E485D74.04C738A1();
				num ^= 743904914U;
				TypeCode typeCode2 = typeCode;
				if (num << 26 != 0U)
				{
					for (;;)
					{
						num += 1000163841U;
						TypeCode typeCode3 = 44A41FA8.04C738A1();
						num = 1222850638U + num;
						TypeCode typeCode4 = typeCode3;
						num %= 858138519U;
						for (;;)
						{
							if (typeCode2 != (int)num + (TypeCode)(-473822660))
							{
								num ^= 633886460U;
								if ((num & 1715278688U) == 0U)
								{
									goto IL_07;
								}
								for (;;)
								{
									TypeCode typeCode5 = typeCode4;
									num %= 1550599679U;
									uint num3 = num ^ 972399416U;
									num |= 23622294U;
									if (typeCode5 == num3)
									{
										goto Block_2;
									}
									if (num >= 2010193232U)
									{
										goto IL_07;
									}
									uint num4 = (uint)typeCode2;
									num -= 672020072U;
									if (num4 == num + 3994043063U)
									{
										break;
									}
									num = 633107504U - num;
									uint num5 = (uint)typeCode4;
									num ^= 1938182971U;
									if (num5 == num - 1615521236U)
									{
										goto Block_11;
									}
									uint num6 = (uint)typeCode2;
									num = (337920556U | num);
									if (num6 == (num ^ 1953425379U))
									{
										goto IL_26A;
									}
									num = 369719753U % num;
									TypeCode typeCode6 = typeCode4;
									num /= 952773942U;
									uint num7 = num ^ 13U;
									num = 850939170U + num;
									if (typeCode6 == num7)
									{
										goto Block_15;
									}
									if (1335102695U < num)
									{
										goto IL_1E;
									}
									uint num8 = (uint)typeCode2;
									num = 1721565470U >> (int)num;
									if (num8 != num + 3864575940U)
									{
										num >>= 13;
										if (num == 424624649U)
										{
											goto IL_07;
										}
										TypeCode typeCode7 = typeCode4;
										uint num9 = num - 52527U;
										num = 703295913U / num;
										if (typeCode7 != num9)
										{
											goto IL_400;
										}
										num ^= 430404621U;
									}
									int num11;
									if (!70D15AEC)
									{
										num = 153762291U * num;
										long num10 = 0E485D74.E7FBC3B9();
										num = 1510087162U / num;
										num += 95839271U;
										long value = 44A41FA8.E7FBC3B9();
										num = 313018492U % num;
										num11 = num10.CompareTo(value);
									}
									else
									{
										if (num + 1678006342U == 0U)
										{
											goto IL_07;
										}
										ulong num12 = 0E485D74.6100687B();
										num |= 31924301U;
										ulong num13 = num12;
										num = 11232953U / num;
										num &= 1169300624U;
										ulong value2 = 44A41FA8.6100687B();
										num = 1535142044U * num;
										num11 = num13.CompareTo(value2);
										num ^= 25500679U;
									}
									num += 941187253U;
									num2 = num11;
									if (889201706U <= num)
									{
										goto Block_24;
									}
								}
								IL_1BF:
								num = 300574293U * num;
								if (num <= 1049718969U)
								{
									goto IL_07;
								}
								num = (867330541U | num);
								double num14 = 0E485D74.B1479B35();
								if (1472230637U <= num)
								{
									double value3 = 44A41FA8.B1479B35();
									num >>= 23;
									num2 = num14.CompareTo(value3);
									num += 2766929689U;
									goto IL_522;
								}
								continue;
								Block_11:
								num ^= 1906661557U;
								goto IL_1BF;
								Block_24:
								num ^= 2641525948U;
								goto IL_522;
								IL_26A:
								num = 2021995685U % num;
								if (841753210U + num == 0U)
								{
									goto IL_07;
								}
								num |= 760109933U;
								float num15 = 0E485D74.88D23451();
								num ^= 1758141153U;
								float num16 = num15;
								if (num > 303650720U)
								{
									num = 2107993745U * num;
									float value4 = 44A41FA8.88D23451();
									num = 1672627944U / num;
									num2 = num16.CompareTo(value4);
									num ^= 2766929920U;
									goto IL_522;
								}
								goto IL_07;
								Block_15:
								num += 1102486220U;
								goto IL_26A;
								Block_2:
								num ^= 633341562U;
								goto IL_B6;
								IL_400:
								num += 1767667179U;
								TypeCode typeCode8 = typeCode2;
								uint num17 = num - 1767680556U;
								num &= 788677881U;
								if (typeCode8 != num17)
								{
									num = 45941162U << (int)num;
									TypeCode typeCode9 = typeCode4;
									num = 1314139453U << (int)num;
									uint num18 = num - 1314139444U;
									num = 387060811U * num;
									num += 1970273057U;
									if (typeCode9 != num18)
									{
										goto IL_522;
									}
									num ^= 2381054001U;
								}
								if (num % 39783365U != 0U)
								{
									num = 288254094U % num;
									int num20;
									if (!70D15AEC)
									{
										num = 2040600912U >> (int)num;
										if ((212433862U ^ num) == 0U)
										{
											goto IL_07;
										}
										int num19 = 0E485D74.D02DFB88();
										int value5 = 44A41FA8.D02DFB88();
										num <<= 27;
										num20 = num19.CompareTo(value5);
									}
									else
									{
										num = (1148941047U ^ num);
										num *= 1785490057U;
										uint num21 = 0E485D74.45E9448C();
										if (1296833903U / num == 0U)
										{
											continue;
										}
										num &= 1352666564U;
										num20 = num21.CompareTo(44A41FA8.45E9448C());
										num += 528481088U;
									}
									num2 = num20;
									num ^= 2230059008U;
									goto IL_522;
								}
							}
							IL_B6:
							num %= 1973164649U;
							num ^= 1549540942U;
							object obj = 0E485D74.6DCA9058();
							num = (2047942070U & num);
							if (num <= 249059209U)
							{
								goto IL_07;
							}
							object obj2 = 44A41FA8.6DCA9058();
							num %= 1136203774U;
							object obj3 = obj2;
							object obj4 = obj;
							object obj5 = obj3;
							num = (1698567408U | num);
							if (obj4 == obj5)
							{
								goto Block_4;
							}
							num = 962554171U << (int)num;
							if (5447878U > num)
							{
								goto IL_07;
							}
							if (obj3 == null)
							{
								goto Block_6;
							}
							if ((278733785U ^ num) == 0U)
							{
								continue;
							}
							if (obj == null)
							{
								goto Block_8;
							}
							IL_522:
							if (num == 2072976940U)
							{
								break;
							}
							uint num22 = (uint)num2;
							num = (1947933850U | num);
							if (num22 < (num ^ 4110359706U))
							{
								goto Block_32;
							}
							if (num / 147344392U != 0U)
							{
								goto Block_34;
							}
						}
					}
					Block_32:
					num = 321136661U - num;
					num2 = (int)(num - 505744252U);
					if ((799171265U & num) != 0U)
					{
						break;
					}
				}
			}
			IL_5C1:
			num = (763363940U | num);
			if ((num ^ 2071732653U) != 0U)
			{
				return num2;
			}
			continue;
			Block_34:
			int num23 = num2;
			num <<= 20;
			uint num24 = num ^ 3382706176U;
			num ^= 3615820667U;
			if (num23 > num24)
			{
				num -= 1442144412U;
				int num25 = (int)(num ^ 3358567134U);
				num += 510862896U;
				num2 = num25;
				num += 931281516U;
			}
			goto IL_5C1;
		}
		Block_4:
		num = 614544032U * num;
		return (int)(num + 2273445056U);
		Block_6:
		return (int)(num + 1528037377U);
		Block_8:
		num /= 832177725U;
		return (int)(num ^ 4294967292U);
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00215EF8 File Offset: 0x00215EF8
	private 66026065.28060A8C 192E7B74(66026065.28060A8C 041648AC)
	{
		uint num = 2024238110U;
		for (;;)
		{
			TypeCode typeCode = 041648AC.04C738A1();
			num = 1886468084U << (int)num;
			TypeCode typeCode2 = typeCode;
			if (143401920U - num != 0U)
			{
				uint num2 = (uint)typeCode2;
				num = 1966193U << (int)num;
				if (num2 == num - 1966184U && num << 26 != 0U)
				{
					break;
				}
				uint num3 = (uint)typeCode2;
				num = 1369180923U * num;
				if (num3 == num - 1330305216U && num != 1585014547U)
				{
					goto Block_3;
				}
				if (num % 1972062133U != 0U)
				{
					goto Block_4;
				}
			}
		}
		num %= 717757068U;
		int num4 = 041648AC.D02DFB88();
		num -= 629552404U;
		return new 66026065.152602F0(~num4);
		Block_3:
		long num5 = 041648AC.E7FBC3B9();
		num = 2097379229U - num;
		return new 66026065.6DA9264D(~num5);
		Block_4:
		throw new InvalidOperationException();
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00215FBC File Offset: 0x00215FBC
	private 66026065.28060A8C 3F947D0C(66026065.28060A8C 059C1B61)
	{
		uint num;
		for (;;)
		{
			TypeCode typeCode = 059C1B61.04C738A1();
			num = 157971160U;
			for (;;)
			{
				TypeCode typeCode2 = typeCode;
				uint num2 = num - 157971151U;
				num = 1512920209U << (int)num;
				switch (typeCode2 - num2)
				{
				case 0:
					goto IL_59;
				case 1:
				case 3:
					goto IL_DE;
				case 2:
					num <<= 31;
					if (1916674847U >= num)
					{
						goto Block_3;
					}
					goto IL_59;
				case 4:
					goto IL_A1;
				case 5:
					goto IL_C9;
				}
				break;
				IL_59:
				num = (618350252U | num);
				if (num >= 171978000U)
				{
					goto Block_2;
				}
			}
			if (num >= 1100052349U)
			{
				break;
			}
			continue;
			IL_A1:
			num |= 1432714388U;
			if (1574663805U != num)
			{
				goto Block_4;
			}
		}
		num += 0U;
		goto IL_DE;
		Block_2:
		return new 66026065.152602F0(-059C1B61.D02DFB88());
		Block_3:
		num = (845498827U ^ num);
		return new 66026065.6DA9264D(-059C1B61.E7FBC3B9());
		Block_4:
		float num3 = 059C1B61.88D23451();
		num = (309019746U & num);
		return new 66026065.7CEE5B47(-num3);
		IL_C9:
		num = 886470755U * num;
		return new 66026065.18527F7D(-059C1B61.B1479B35());
		IL_DE:
		throw new InvalidOperationException();
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x002160AC File Offset: 0x002160AC
	private 66026065.28060A8C 070E41F9(66026065.28060A8C 6E420B44, 66026065.28060A8C 3CC27267, bool 080824A8)
	{
		uint num = 1793666647U;
		num /= 1539075727U;
		TypeCode typeCode = 6E420B44.04C738A1();
		num ^= 679155725U;
		TypeCode typeCode2 = typeCode;
		num = 1184173179U / num;
		for (;;)
		{
			if (typeCode2 != (TypeCode)(num ^ 8U))
			{
				num = 1109161700U + num;
			}
			else
			{
				num = 1267949747U % num;
				num = 475691100U * num;
				if (!080824A8)
				{
					goto IL_AD;
				}
				if (1811163639U + num != 0U)
				{
					goto Block_4;
				}
			}
			uint num2 = (uint)typeCode2;
			num -= 1403668645U;
			if (num2 != num + 294506955U)
			{
				break;
			}
			num %= 1186353902U;
			if (!080824A8)
			{
				goto IL_147;
			}
			if ((1987540585U ^ num) != 0U)
			{
				goto Block_6;
			}
		}
		num |= 1619677998U;
		throw new InvalidOperationException();
		Block_4:
		num -= 1343498717U;
		uint num3 = 6E420B44.45E9448C();
		num <<= 3;
		int num4 = 3CC27267.D02DFB88();
		int num5 = num4 & (int)(num ^ 2136912135U);
		num = 1534157731U * num;
		return new 66026065.152602F0(num3 >> num5);
		IL_AD:
		num = (1800824691U | num);
		int num6 = 6E420B44.D02DFB88();
		int num7 = 3CC27267.D02DFB88();
		int num8 = num7;
		num <<= 11;
		int num9 = (int)(num ^ 3007027231U);
		num = 1224894147U << (int)num;
		return new 66026065.152602F0(num6 >> (num8 & num9));
		Block_6:
		ulong num10 = 6E420B44.6100687B();
		num = 315915153U / num;
		num = 95166270U >> (int)num;
		int num11 = 3CC27267.D02DFB88();
		num -= 723544590U;
		int num12 = num11;
		int num13 = num12;
		int num14 = (int)(num - 3666588913U);
		num = (400777487U ^ num);
		return new 66026065.6DA9264D(num10 >> (num13 & num14));
		IL_147:
		num = 427107558U % num;
		if (1385781961U * num != 0U)
		{
			long num15 = 6E420B44.E7FBC3B9();
			num = 737698396U % num;
			int num16 = 3CC27267.D02DFB88();
			num %= 1023239190U;
			int num17 = num16;
			num = 1090002020U / num;
			int num18 = num17;
			int num19 = (int)(num ^ 60U);
			num = 2002923706U + num;
			int num20 = num18 & num19;
			num *= 1858866805U;
			return new 66026065.6DA9264D(num15 >> num20);
		}
		goto IL_AD;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00216268 File Offset: 0x00216268
	private 66026065.28060A8C 65D41E1D(66026065.28060A8C 72AB27A9, 66026065.28060A8C 4B8B7786)
	{
		uint num = 1903182929U;
		if ((num ^ 1972271257U) == 0U)
		{
			goto IL_35;
		}
		IL_12:
		num = 1779187719U / num;
		TypeCode typeCode = 72AB27A9.04C738A1();
		num >>= 24;
		TypeCode typeCode2 = typeCode;
		if ((1426023354U ^ num) == 0U)
		{
			goto IL_5E;
		}
		IL_35:
		TypeCode typeCode3 = typeCode2;
		uint num2 = num ^ 9U;
		num = (666916607U ^ num);
		if (typeCode3 == num2)
		{
			num = 1722360031U + num;
			int num3 = 72AB27A9.D02DFB88();
			num -= 883049218U;
			int num4 = 4B8B7786.D02DFB88();
			int num5 = num4;
			int num6 = (int)(num ^ 1506227395U);
			num = 634785249U / num;
			return new 66026065.152602F0(num3 << (num5 & num6));
		}
		num = 1618814759U / num;
		if (num * 564280026U == 0U)
		{
			goto IL_12;
		}
		IL_5E:
		TypeCode typeCode4 = typeCode2;
		num = 927940909U % num;
		uint num7 = num - 4294967286U;
		num <<= 27;
		if (typeCode4 != num7)
		{
			num -= 1700673877U;
			throw new InvalidOperationException();
		}
		num = 1535522273U << (int)num;
		num &= 1930237108U;
		long num8 = 72AB27A9.E7FBC3B9();
		int num9 = 4B8B7786.D02DFB88();
		num = (1257526321U ^ num);
		int num10 = num9;
		int num11 = num10 & (int)(num ^ 435175598U);
		num = (1422469336U | num);
		return new 66026065.6DA9264D(num8 << num11);
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x0021637C File Offset: 0x0021637C
	private unsafe 66026065.28060A8C 64A3721C(object 4C20265C, Type 2A7B54D7)
	{
		uint num;
		66026065.28060A8C 28060A8C;
		for (;;)
		{
			IL_00:
			object obj = 4C20265C;
			num = 1717377213U;
			28060A8C = (obj as 66026065.28060A8C);
			for (;;)
			{
				num = 111963249U - num;
				bool isEnum = 2A7B54D7.IsEnum;
				num /= 2052981886U;
				if (isEnum)
				{
					num = 533806127U * num;
					goto IL_30;
				}
				if (1686969302U == num)
				{
					continue;
				}
				TypeCode typeCode = Type.GetTypeCode(2A7B54D7);
				num |= 426266121U;
				TypeCode typeCode2 = typeCode;
				uint num2 = (uint)typeCode2;
				num = 4945935U % num;
				uint num3 = num2 - (num - 4945932U);
				num = (932993118U ^ num);
				switch (num3)
				{
				case 0:
				{
					num = 216745300U + num;
					if (num >= 1987915928U)
					{
						goto IL_00;
					}
					bool flag = 28060A8C != null;
					num = 701173859U / num;
					if (flag)
					{
						goto IL_1EE;
					}
					if ((2092128670U ^ num) != 0U)
					{
						goto Block_14;
					}
					continue;
				}
				case 1:
				{
					num ^= 1787640608U;
					if (1910983926 << (int)num == 0)
					{
						continue;
					}
					bool flag2 = 28060A8C != null;
					num ^= 1138498784U;
					if (!flag2)
					{
						goto Block_16;
					}
					num &= 623464019U;
					if ((1627021362U ^ num) != 0U)
					{
						goto Block_17;
					}
					continue;
				}
				case 2:
					num = (1136424382U & num);
					if (1001934272U * num != 0U)
					{
						goto Block_18;
					}
					goto IL_30;
				case 3:
					num = 1088175514U - num;
					if (num <= 1551765268U)
					{
						goto Block_21;
					}
					continue;
				case 4:
				{
					num >>= 11;
					bool flag3 = 28060A8C != null;
					num %= 219758902U;
					if (flag3)
					{
						goto IL_368;
					}
					num = 607418071U * num;
					if (1366851195U - num != 0U)
					{
						goto Block_25;
					}
					goto IL_41;
				}
				case 5:
					goto IL_384;
				case 6:
					goto IL_3C1;
				case 7:
					num >>= 27;
					if (num > 776144487U)
					{
						goto IL_59;
					}
					if (28060A8C == null)
					{
						goto Block_31;
					}
					if (num < 1240689282U)
					{
						goto Block_33;
					}
					goto IL_30;
				case 8:
					goto IL_484;
				case 9:
					if (num >= 407642816U)
					{
						goto Block_37;
					}
					continue;
				case 10:
					num -= 2088899245U;
					if (num != 414208656U)
					{
						goto Block_39;
					}
					goto IL_30;
				case 11:
					goto IL_57B;
				case 12:
				case 13:
				case 14:
					break;
				case 15:
					goto IL_5ED;
				default:
					if ((861961709U ^ num) == 0U)
					{
						goto IL_00;
					}
					num += 0U;
					break;
				}
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num = 2031121902U * num;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num <<= 2;
				if (2A7B54D7 == typeFromHandle)
				{
					if (1989894791U == num)
					{
						goto IL_00;
					}
					bool flag4 = 28060A8C != null;
					num = 1280062768U - num;
					if (flag4)
					{
						goto Block_49;
					}
					bool flag5 = 4C20265C != null;
					num = 1088710936U % num;
					if (!flag5)
					{
						goto Block_50;
					}
					if (648546369U >= num)
					{
						goto Block_52;
					}
					continue;
				}
				else
				{
					num -= 1273848372U;
					if (num % 415784936U == 0U)
					{
						goto IL_30;
					}
					Type typeFromHandle2 = typeof(UIntPtr);
					num &= 1649503172U;
					if (2A7B54D7 == typeFromHandle2)
					{
						goto Block_54;
					}
					num = (1688883829U & num);
					num >>= 20;
					bool isValueType = 2A7B54D7.IsValueType;
					num = 1140407414U % num;
					if (isValueType)
					{
						goto Block_58;
					}
					if (1212237885U < num)
					{
						goto IL_30;
					}
					num = 1245252493U >> (int)num;
					bool isArray = 2A7B54D7.IsArray;
					num = 39133692U * num;
					if (isArray)
					{
						goto Block_64;
					}
					num <<= 21;
					if (!2A7B54D7.IsPointer)
					{
						goto IL_98F;
					}
					if (1375169313U + num == 0U)
					{
						goto IL_00;
					}
					bool flag6 = 28060A8C != null;
					num *= 381162446U;
					if (flag6)
					{
						num <<= 5;
						if (num <= 858801612U)
						{
							goto Block_71;
						}
						goto IL_A2;
					}
					else
					{
						num *= 151922634U;
						if (4C20265C == null)
						{
							goto Block_72;
						}
						num /= 1840922208U;
						if (num << 12 == 0U)
						{
							goto Block_73;
						}
						continue;
					}
				}
				IL_B3:
				num = 1373056496U + num;
				bool flag7 = 4C20265C != null;
				num /= 1027873986U;
				if (!flag7)
				{
					break;
				}
				num <<= 2;
				if (1338332035U + num != 0U)
				{
					goto Block_7;
				}
				continue;
				IL_59:
				if (286349587U + num != 0U)
				{
					bool flag8 = 4C20265C != null;
					num -= 1507490234U;
					if (!flag8)
					{
						goto IL_B3;
					}
					if ((num ^ 1887509826U) != 0U)
					{
						object obj2 = 4C20265C;
						num >>= 17;
						bool flag9 = obj2 is Enum;
						num += 3321257850U;
						if (!flag9)
						{
							num ^= 872309516U;
							goto IL_A2;
						}
						goto IL_B3;
					}
				}
				IL_30:
				if (28060A8C == null)
				{
					goto IL_59;
				}
				if (num != 490485433U)
				{
					goto IL_41;
				}
				goto IL_00;
				IL_A2:
				4C20265C = Enum.ToObject(2A7B54D7, 4C20265C);
				num ^= 872309516U;
				goto IL_B3;
				IL_41:
				object obj3 = 28060A8C.6DCA9058();
				num = 1611989173U % num;
				4C20265C = obj3;
				num ^= 527462407U;
				goto IL_59;
			}
			num %= 15886702U;
			if (num - 443291542U != 0U)
			{
				goto Block_8;
			}
			continue;
			Block_18:
			if (28060A8C == null)
			{
				goto Block_19;
			}
			if (1366846810U > num)
			{
				goto Block_20;
			}
			continue;
			Block_21:
			if (28060A8C == null)
			{
				goto Block_22;
			}
			if (num - 416825244U != 0U)
			{
				goto Block_23;
			}
			continue;
			IL_3C1:
			if (1593520007U - num == 0U)
			{
				continue;
			}
			bool flag10 = 28060A8C != null;
			num /= 415050824U;
			if (!flag10)
			{
				goto Block_28;
			}
			num = 449925760U / num;
			if (num < 1016418661U)
			{
				goto Block_29;
			}
			continue;
			Block_31:
			num &= 577984666U;
			if ((732513150U ^ num) != 0U)
			{
				goto Block_32;
			}
			continue;
			IL_484:
			if ((num ^ 1365643702U) == 0U)
			{
				continue;
			}
			bool flag11 = 28060A8C != null;
			num = 2049838487U - num;
			if (!flag11)
			{
				goto Block_35;
			}
			num &= 639500836U;
			if (207826831U != num)
			{
				goto Block_36;
			}
			continue;
			Block_39:
			bool flag12 = 28060A8C != null;
			num = 384062512U - num;
			if (flag12)
			{
				goto IL_55F;
			}
			if (num != 1852995421U)
			{
				goto Block_41;
			}
			continue;
			IL_57B:
			num = 731785538U << (int)num;
			if ((num ^ 1119702037U) == 0U)
			{
				continue;
			}
			bool flag13 = 28060A8C != null;
			num -= 618863137U;
			if (!flag13)
			{
				goto Block_43;
			}
			num <<= 11;
			if (num <= 1583295019U)
			{
				goto Block_44;
			}
			continue;
			IL_5ED:
			if (28060A8C == null)
			{
				goto Block_45;
			}
			if (1226927133U - num != 0U)
			{
				goto Block_46;
			}
			continue;
			Block_50:
			if (1484276969U != num)
			{
				goto Block_51;
			}
			continue;
			Block_54:
			if (28060A8C == null)
			{
				goto IL_725;
			}
			num = 810353163U / num;
			if (num >> 2 == 0U)
			{
				goto Block_56;
			}
			continue;
			Block_58:
			num *= 1378883925U;
			if (28060A8C != null)
			{
				num = (1886211860U | num);
				if (1574654946U < num)
				{
					goto Block_60;
				}
				continue;
			}
			else
			{
				num = 299791701U << (int)num;
				if (4C20265C == null)
				{
					goto IL_7DD;
				}
				if (1320311547U >> (int)num != 0U)
				{
					goto Block_62;
				}
				continue;
			}
			Block_64:
			if (28060A8C == null)
			{
				if (675760807U < num)
				{
					goto Block_66;
				}
				continue;
			}
			else
			{
				if (num >= 473438210U)
				{
					goto Block_67;
				}
				continue;
			}
			IL_98F:
			if (1986284752U > num)
			{
				if (28060A8C == null)
				{
					goto Block_75;
				}
				if (num - 1235123757U != 0U)
				{
					goto Block_76;
				}
			}
		}
		Block_7:
		object obj4 = 4C20265C;
		num %= 1164320671U;
		Enum 010D580F = (Enum)obj4;
		goto IL_11F;
		Block_8:
		object obj5 = Activator.CreateInstance(2A7B54D7);
		num = (1642418055U | num);
		010D580F = (Enum)obj5;
		num ^= 1642418055U;
		IL_11F:
		return new 66026065.5A13537F(010D580F);
		Block_14:
		bool 51A52E5B = Convert.ToBoolean(4C20265C);
		goto IL_20A;
		IL_1EE:
		num = 884953367U >> (int)num;
		51A52E5B = 28060A8C.AE4D32F2();
		num += 3410013929U;
		IL_20A:
		num >>= 27;
		return new 66026065.770A6FD1(51A52E5B);
		Block_16:
		object value = 4C20265C;
		num = (101012225U | num);
		char 73117D = Convert.ToChar(value);
		goto IL_27D;
		Block_17:
		66026065.28060A8C 28060A8C2 = 28060A8C;
		num ^= 513999970U;
		73117D = 28060A8C2.CE499C06();
		num ^= 69490146U;
		IL_27D:
		return new 66026065.287D7C28(73117D);
		Block_19:
		num /= 1340081387U;
		sbyte 490A56BD = Convert.ToSByte(4C20265C);
		goto IL_2D1;
		Block_20:
		66026065.28060A8C 28060A8C3 = 28060A8C;
		num <<= 14;
		490A56BD = 28060A8C3.3B8993E9();
		num += 4160487424U;
		IL_2D1:
		return new 66026065.4E7A3FAE(490A56BD);
		Block_22:
		object value2 = 4C20265C;
		num >>= 6;
		byte 08C76E2E = Convert.ToByte(value2);
		goto IL_31D;
		Block_23:
		08C76E2E = 28060A8C.701A708C();
		num ^= 153159996U;
		IL_31D:
		num = (1507681562U | num);
		return new 66026065.3A541C87(08C76E2E);
		Block_25:
		object value3 = 4C20265C;
		num ^= 1903888548U;
		short 241E7B0B = Convert.ToInt16(value3);
		goto IL_37E;
		IL_368:
		66026065.28060A8C 28060A8C4 = 28060A8C;
		num = (456873340U | num);
		241E7B0B = 28060A8C4.D496EFA1();
		num ^= 697645604U;
		IL_37E:
		return new 66026065.2C066D18(241E7B0B);
		IL_384:
		num = (1326453062U | num);
		bool flag14 = 28060A8C != null;
		num ^= 2064067491U;
		ushort 3F;
		if (!flag14)
		{
			3F = Convert.ToUInt16(4C20265C);
		}
		else
		{
			66026065.28060A8C 28060A8C5 = 28060A8C;
			num *= 391384444U;
			3F = 28060A8C5.EF893D1B();
			num ^= 2934663364U;
		}
		return new 66026065.50A37309(3F);
		Block_28:
		num = 1743659978U + num;
		object value4 = 4C20265C;
		num = 1684097848U / num;
		int 73704D = Convert.ToInt32(value4);
		goto IL_417;
		Block_29:
		73704D = 28060A8C.D02DFB88();
		num += 4070004416U;
		IL_417:
		num = 1861242826U - num;
		return new 66026065.152602F0(73704D);
		Block_32:
		object value5 = 4C20265C;
		num = (21314175U | num);
		uint 0FD36B8F = Convert.ToUInt32(value5);
		goto IL_47E;
		Block_33:
		0FD36B8F = 28060A8C.45E9448C();
		num += 21314169U;
		IL_47E:
		return new 66026065.23EE4D1F(0FD36B8F);
		Block_35:
		long 156A0AAB = Convert.ToInt64(4C20265C);
		goto IL_4D2;
		Block_36:
		66026065.28060A8C 28060A8C6 = 28060A8C;
		num |= 1053130332U;
		156A0AAB = 28060A8C6.E7FBC3B9();
		num += 58683114U;
		IL_4D2:
		return new 66026065.6DA9264D(156A0AAB);
		Block_37:
		bool flag15 = 28060A8C != null;
		num >>= 2;
		ulong 034E529E;
		if (!flag15)
		{
			object value6 = 4C20265C;
			num |= 1251621699U;
			034E529E = Convert.ToUInt64(value6);
		}
		else
		{
			66026065.28060A8C 28060A8C7 = 28060A8C;
			num = 884359034U - num;
			034E529E = 28060A8C7.6100687B();
			num ^= 1765772337U;
		}
		return new 66026065.374343A0(034E529E);
		Block_41:
		object value7 = 4C20265C;
		num &= 1081414348U;
		float 34DA3CFB = Convert.ToSingle(value7);
		goto IL_56D;
		IL_55F:
		34DA3CFB = 28060A8C.88D23451();
		num += 3832921088U;
		IL_56D:
		num = 1808035479U - num;
		return new 66026065.7CEE5B47(34DA3CFB);
		Block_43:
		object value8 = 4C20265C;
		num *= 929585369U;
		double 5FD904DC = Convert.ToDouble(value8);
		goto IL_5DF;
		Block_44:
		66026065.28060A8C 28060A8C8 = 28060A8C;
		num >>= 28;
		5FD904DC = 28060A8C8.B1479B35();
		num += 1207927303U;
		IL_5DF:
		num = 237119789U / num;
		return new 66026065.18527F7D(5FD904DC);
		Block_45:
		num = 930765171U - num;
		string 7F7E7F = (string)4C20265C;
		goto IL_620;
		Block_46:
		7F7E7F = 28060A8C.ToString();
		num += 3352041681U;
		IL_620:
		num = 1785556753U % num;
		return new 66026065.1B84428C(7F7E7F);
		Block_49:
		num = 303505029U >> (int)num;
		IntPtr 610560FE = 28060A8C.8ACF22C2();
		num = (1225288543U ^ num);
		return new 66026065.17975C69(610560FE);
		Block_51:
		IntPtr 610560FE2 = IntPtr.Zero;
		goto IL_6CD;
		Block_52:
		object obj6 = 4C20265C;
		num = (2111639548U ^ num);
		610560FE2 = (IntPtr)obj6;
		num += 3048929860U;
		IL_6CD:
		return new 66026065.17975C69(610560FE2);
		Block_56:
		return new 66026065.7DEE7F40(28060A8C.16A92427());
		IL_725:
		num = 1181700772U * num;
		bool flag16 = 4C20265C != null;
		num = 684731099U - num;
		UIntPtr 377D2CBF;
		if (!flag16)
		{
			377D2CBF = UIntPtr.Zero;
		}
		else
		{
			num = (1606315770U & num);
			377D2CBF = (UIntPtr)4C20265C;
			num += 2151714817U;
		}
		return new 66026065.7DEE7F40(377D2CBF);
		Block_60:
		return new 66026065.35B110E2(28060A8C.6DCA9058());
		Block_62:
		object 7C65154C = 4C20265C;
		goto IL_801;
		IL_7DD:
		num = 1709069395U - num;
		num = 629021328U << (int)num;
		7C65154C = Activator.CreateInstance(2A7B54D7);
		num ^= 1238712320U;
		IL_801:
		num -= 316563348U;
		return new 66026065.35B110E2(7C65154C);
		Block_66:
		object obj7 = 4C20265C;
		num &= 2069385934U;
		Array 100B = (Array)obj7;
		goto IL_885;
		Block_67:
		object obj8 = 28060A8C.6DCA9058();
		num = 969696191U + num;
		100B = (Array)obj8;
		num += 1175229217U;
		IL_885:
		num = 1755598734U >> (int)num;
		return new 66026065.2BBE3DF2(100B);
		Block_71:
		object ptr = 28060A8C.6DCA9058();
		num = 756776352U - num;
		void* ptr2 = Pointer.Unbox(ptr);
		num = 1122764846U >> (int)num;
		num >>= 17;
		object 15D532E = Pointer.Box(ptr2, 2A7B54D7);
		num ^= 503599473U;
		num &= 100664588U;
		return new 66026065.30C00244(15D532E, 2A7B54D7);
		Block_72:
		num >>= 14;
		void* ptr3 = num + 4294950912U;
		goto IL_96C;
		Block_73:
		object ptr4 = 4C20265C;
		num = (1318397819U & num);
		ptr3 = Pointer.Unbox(ptr4);
		num += 16384U;
		IL_96C:
		num &= 17989183U;
		object 15D532E2 = Pointer.Box(ptr3, 2A7B54D7);
		num = 859392366U >> (int)num;
		return new 66026065.30C00244(15D532E2, 2A7B54D7);
		Block_75:
		num = (550265673U | num);
		object 085C45CB = 4C20265C;
		goto IL_9D0;
		Block_76:
		66026065.28060A8C 28060A8C9 = 28060A8C;
		num += 1176271814U;
		085C45CB = 28060A8C9.6DCA9058();
		num ^= 3738179727U;
		IL_9D0:
		return new 66026065.332067BD(085C45CB);
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00216D60 File Offset: 0x00216D60
	private string 59041F06(int 24063463)
	{
		Dictionary<int, object> dictionary;
		uint num;
		do
		{
			dictionary = 66026065.2B507720;
			num = 1938646196U;
		}
		while (num >> 31 != 0U);
		object obj = dictionary;
		num ^= 2036403809U;
		Monitor.Enter(obj);
		string result;
		try
		{
			if (1391549116U != num)
			{
				Dictionary<int, object> dictionary2 = 66026065.2B507720;
				num = 163080577U + num;
				object obj2;
				bool flag = dictionary2.TryGetValue(24063463, out obj2);
				num = (533087911U | num);
				if (!flag)
				{
					goto IL_87;
				}
				num -= 1893556009U;
				if (num >> 5 == 0U)
				{
					goto IL_87;
				}
				do
				{
					IL_67:
					object obj3 = obj2;
					num = 57558625U / num;
					result = (string)obj3;
				}
				while (num > 214844375U);
				return result;
				IL_87:
				num = 259395967U / num;
				string text = this.702D7276.ResolveString(24063463);
				num <<= 26;
				string text2 = text;
				num |= 2092119815U;
				if (num << 12 == 0U)
				{
					goto IL_67;
				}
				Dictionary<int, object> dictionary3 = 66026065.2B507720;
				num = (1748786873U ^ num);
				dictionary3.Add(24063463, text2);
				num += 1773427923U;
				string text3 = text2;
				num = (772816552U & num);
				result = text3;
			}
		}
		finally
		{
			Monitor.Exit(dictionary);
		}
		return result;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00216E7C File Offset: 0x00216E7C
	private Type 22C50466(int 0F8107B5)
	{
		uint num = 409293480U;
		Dictionary<int, object> dictionary = 66026065.2B507720;
		object obj = dictionary;
		num += 994339184U;
		Monitor.Enter(obj);
		Type result;
		try
		{
			for (;;)
			{
				object obj2;
				bool flag = 66026065.2B507720.TryGetValue(0F8107B5, out obj2);
				num *= 1549882147U;
				if (!flag)
				{
					break;
				}
				num |= 824465991U;
				if (num == 1176112224U)
				{
					goto IL_63;
				}
				Type type = (Type)obj2;
				num *= 1647784134U;
				result = type;
				if (num != 1490711135U)
				{
					goto IL_63;
				}
			}
			Type type2;
			do
			{
				num = 381383497U + num;
				Module module = this.702D7276;
				num <<= 8;
				type2 = module.ResolveType(0F8107B5);
				num %= 963137957U;
				if (num <= 17775584U)
				{
					goto IL_63;
				}
				Dictionary<int, object> dictionary2 = 66026065.2B507720;
				num ^= 529613236U;
				dictionary2.Add(0F8107B5, type2);
			}
			while ((1620789396U ^ num) == 0U);
			result = type2;
			if (1830562820U != num)
			{
			}
			IL_63:;
		}
		finally
		{
			Monitor.Exit(dictionary);
		}
		return result;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00216F80 File Offset: 0x00216F80
	private MethodBase 0E5643BA(int 37DF7CC3)
	{
		uint num = 1896421391U;
		Dictionary<int, object> dictionary2;
		if (num / 1546011891U != 0U)
		{
			Dictionary<int, object> dictionary = 66026065.2B507720;
			num = (264266983U ^ num);
			dictionary2 = dictionary;
		}
		Monitor.Enter(dictionary2);
		MethodBase result;
		try
		{
			num /= 353907192U;
			if (num != 1965560155U)
			{
				object obj;
				MethodBase methodBase;
				for (;;)
				{
					Dictionary<int, object> dictionary3 = 66026065.2B507720;
					num |= 1906448988U;
					bool flag = dictionary3.TryGetValue(37DF7CC3, out obj);
					num /= 1197213385U;
					if (flag)
					{
						if (976357438U % num == 0U)
						{
							break;
						}
					}
					else
					{
						if (num >= 1444627032U)
						{
							break;
						}
						methodBase = this.702D7276.ResolveMethod(37DF7CC3);
						num -= 1525113324U;
						if (num >= 1616794079U)
						{
							Dictionary<int, object> dictionary4 = 66026065.2B507720;
							num &= 2146067776U;
							object value = methodBase;
							num /= 491543089U;
							dictionary4.Add(37DF7CC3, value);
							if (num << 20 != 0U)
							{
								goto Block_7;
							}
						}
					}
				}
				for (;;)
				{
					IL_67:
					MethodBase methodBase2 = (MethodBase)obj;
					num = (1197213428U | num);
					result = methodBase2;
					if (num >= 1114392043U)
					{
						goto IL_82;
					}
				}
				Block_7:
				result = methodBase;
				if (945754784U * num == 0U)
				{
					goto IL_67;
				}
			}
			IL_82:;
		}
		finally
		{
			num = 1893686603U;
			if ((num ^ 93459371U) != 0U)
			{
				object obj2 = dictionary2;
				num /= 1476094104U;
				Monitor.Exit(obj2);
			}
		}
		return result;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x002170C0 File Offset: 0x002170C0
	private FieldInfo 4AE41C96(int 0EDE536C)
	{
		Dictionary<int, object> dictionary = 66026065.2B507720;
		uint num = 1299849119U;
		object obj = dictionary;
		num /= 140265280U;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			num -= 1870822955U;
			do
			{
				Dictionary<int, object> dictionary2 = 66026065.2B507720;
				num = 152180385U >> (int)num;
				object obj2;
				if (!dictionary2.TryGetValue(0EDE536C, out obj2))
				{
					if (1751325420U < num)
					{
						continue;
					}
					Module module = this.702D7276;
					num = 1303315559U + num;
					num |= 723340239U;
					FieldInfo fieldInfo = module.ResolveField(0EDE536C);
					num <<= 10;
					FieldInfo fieldInfo2 = fieldInfo;
					if ((num ^ 1221679636U) != 0U)
					{
						Dictionary<int, object> dictionary3 = 66026065.2B507720;
						object value = fieldInfo2;
						num >>= 13;
						dictionary3.Add(0EDE536C, value);
						result = fieldInfo2;
						if ((num ^ 1443894665U) != 0U)
						{
							break;
						}
					}
				}
				object obj3 = obj2;
				num += 1450931474U;
				result = (FieldInfo)obj3;
			}
			while (922377023U >= num);
		}
		finally
		{
			Monitor.Exit(dictionary);
		}
		return result;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x002171C4 File Offset: 0x002171C4
	private 66026065.28060A8C 1A630F05(MethodBase 7D941E57)
	{
		uint num;
		Dictionary<int, 66026065.28060A8C> dictionary;
		object[] array2;
		object obj2;
		for (;;)
		{
			num = 1704666241U;
			ParameterInfo[] parameters = 7D941E57.GetParameters();
			num -= 1780941357U;
			for (;;)
			{
				dictionary = new Dictionary<int, 66026065.28060A8C>();
				num <<= 27;
				ParameterInfo[] array = parameters;
				num = (2115571018U | num);
				array2 = new object[array.Length];
				int num2 = parameters.Length;
				int num3 = (int)(num ^ 4263054667U);
				num = 292775965U >> (int)num;
				int num4 = num2 - num3;
				for (;;)
				{
					num = 2063803U << (int)num;
					if (num4 < (int)(num ^ 3959422976U))
					{
						goto Block_2;
					}
					num = 1639599839U;
					66026065.28060A8C 28060A8C = this.254C0263();
					num *= 1205226218U;
					66026065.28060A8C 28060A8C2 = 28060A8C;
					num = 1885405314U + num;
					if (28060A8C2.55CDE352())
					{
						num &= 485888255U;
						Dictionary<int, 66026065.28060A8C> dictionary2 = dictionary;
						num /= 1673420523U;
						int key = num4;
						num = (1356205959U | num);
						dictionary2[key] = 28060A8C;
						num += 369983185U;
					}
					num <<= 14;
					object[] array3 = array2;
					int num5 = num4;
					num |= 2012744224U;
					num = 162415276U >> (int)num;
					object 4C20265C = 28060A8C;
					num = 1699512179U << (int)num;
					ParameterInfo[] array4 = parameters;
					num = 638286667U * num;
					object obj = this.64A3721C(4C20265C, array4[num4].ParameterType).6DCA9058();
					num -= 1887129688U;
					array3[num5] = obj;
					num = 871852031U >> (int)num;
					if (num >= 915151014U)
					{
						break;
					}
					int num6 = num4;
					num = 306010932U % num;
					int num7 = (int)(num - 2906212U);
					num >>= 23;
					num4 = num6 - num7;
					num ^= 285914U;
				}
			}
			Block_2:
			if (22167361U <= num)
			{
				ConstructorInfo constructorInfo = (ConstructorInfo)7D941E57;
				num = (2124163577U | num);
				object[] parameters2 = array2;
				num -= 1647775765U;
				obj2 = constructorInfo.Invoke(parameters2);
				num = 1617305849U * num;
				if (num + 846735386U != 0U)
				{
					break;
				}
			}
		}
		Dictionary<int, 66026065.28060A8C> dictionary3 = dictionary;
		num *= 1274884174U;
		Dictionary<int, 66026065.28060A8C>.Enumerator enumerator = dictionary3.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<int, 66026065.28060A8C> keyValuePair;
				do
				{
					num = 962875903U;
					num = 2051960760U * num;
					keyValuePair = enumerator.Current;
				}
				while (532249115U > num);
				66026065.28060A8C value = keyValuePair.Value;
				object[] array5 = array2;
				num *= 73940018U;
				num = (1385392191U | num);
				object 35C42CED = array5[keyValuePair.Key];
				num ^= 923083054U;
				value.5F352F29(35C42CED);
				num ^= 2164469929U;
			}
		}
		finally
		{
			do
			{
				num = 1973509148U;
				if (1781684577U > num)
				{
					break;
				}
				num *= 1833191477U;
				((IDisposable)enumerator).Dispose();
			}
			while (171276882U > num);
		}
		num = 1129916270U;
		num = 188185430U * num;
		object 4C20265C2 = obj2;
		num -= 1599106342U;
		return this.64A3721C(4C20265C2, 7D941E57.DeclaringType);
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00217458 File Offset: 0x00217458
	private bool 52EE1DF0(MethodBase 0A4F17D3, object 067112C5, ref object 4C330FDD, object[] 137101B0)
	{
		uint num = 2097698973U;
		for (;;)
		{
			Type declaringType = 0A4F17D3.DeclaringType;
			num = 522485692U % num;
			Type type = declaringType;
			if (559613216U % num != 0U)
			{
				goto IL_21;
			}
			goto IL_A1;
			IL_2F:
			if (636451061 << (int)num != 0)
			{
				Type type2 = type;
				num |= 105849351U;
				if (!type2.IsGenericType)
				{
					goto IL_24B;
				}
				num <<= 15;
				if (num % 564199859U != 0U)
				{
					goto IL_68;
				}
				continue;
			}
			IL_21:
			if (type == null)
			{
				break;
			}
			goto IL_2F;
			IL_A1:
			string name = 0A4F17D3.Name;
			string b = "get_HasValue";
			num %= 553919685U;
			bool flag = string.Equals(name, b, (StringComparison)(num ^ 527400891U));
			num -= 1878883482U;
			if (flag)
			{
				num = (1059224351U ^ num);
				if ((1983871007U & num) == 0U)
				{
					goto IL_21;
				}
				object obj = 067112C5 != null;
				num = 125658273U >> (int)num;
				4C330FDD = obj;
				if (num != 1714357065U)
				{
					goto Block_7;
				}
				goto IL_2F;
			}
			else
			{
				num |= 228621171U;
				if (156857042U / num == 0U)
				{
					num ^= 1044135109U;
					string name2 = 0A4F17D3.Name;
					string b2 = "get_Value";
					num /= 577207043U;
					StringComparison comparisonType = (StringComparison)(num - 0U);
					num = 858855436U / num;
					bool flag2 = string.Equals(name2, b2, comparisonType);
					num >>= 15;
					if (flag2)
					{
						if ((num ^ 335220503U) == 0U)
						{
							continue;
						}
						if (067112C5 == null)
						{
							goto Block_11;
						}
						if (1935151022U >= num)
						{
							goto Block_12;
						}
						goto IL_2F;
					}
					else
					{
						if (493176690U * num == 0U)
						{
							continue;
						}
						string name3 = 0A4F17D3.Name;
						num |= 50295302U;
						string value = "GetValueOrDefault";
						num %= 158466258U;
						StringComparison comparisonType2 = (StringComparison)(num ^ 50297754U);
						num <<= 18;
						bool flag3 = name3.Equals(value, comparisonType2);
						num ^= 4000841729U;
						if (!flag3)
						{
							goto IL_243;
						}
						bool flag4 = 067112C5 != null;
						num = (1055402272U | num);
						if (!flag4)
						{
							num /= 1572808863U;
							Type underlyingType = Nullable.GetUnderlyingType(0A4F17D3.DeclaringType);
							num %= 63116628U;
							object obj2 = Activator.CreateInstance(underlyingType);
							num = 891446163U - num;
							067112C5 = obj2;
							num += 163956110U;
						}
						num ^= 1135871638U;
						if (1415663334U != num)
						{
							goto Block_16;
						}
						continue;
					}
				}
			}
			IL_68:
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			RuntimeTypeHandle handle = typeof(Nullable<>).TypeHandle;
			num = 273613278U + num;
			Type typeFromHandle = Type.GetTypeFromHandle(handle);
			num = 1226254479U / num;
			num += 527400895U;
			if (genericTypeDefinition != typeFromHandle)
			{
				goto IL_24B;
			}
			if ((1458994750U ^ num) != 0U)
			{
				goto IL_A1;
			}
			goto IL_21;
		}
		return num - 522485692U != 0U;
		Block_7:
		goto IL_243;
		Block_11:
		throw new InvalidOperationException();
		Block_12:
		num >>= 5;
		4C330FDD = 067112C5;
		num ^= 205U;
		goto IL_243;
		Block_16:
		object obj3 = 067112C5;
		num = 1350967957U % num;
		4C330FDD = obj3;
		num += 2943999340U;
		IL_243:
		return num + 0U != 0U;
		IL_24B:
		num %= 1449356178U;
		return num - 527400895U != 0U;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x002176C0 File Offset: 0x002176C0
	private 66026065.28060A8C 4427197E(MethodBase 5DEF5E6B, bool 3EBC542F)
	{
		uint num;
		MethodInfo methodInfo;
		object obj3;
		object obj5;
		Dictionary<int, 66026065.28060A8C> dictionary2;
		object[] array3;
		object[] array5;
		for (;;)
		{
			IL_00:
			num = 1887327338U;
			methodInfo = (5DEF5E6B as MethodInfo);
			if ((285823921U ^ num) != 0U)
			{
				goto IL_1C;
			}
			ParameterInfo[] parameters;
			66026065.28060A8C 28060A8C2;
			do
			{
				IL_65:
				ParameterInfo[] array = parameters;
				num = 1073689053U >> (int)num;
				int num2 = array.Length;
				num = 2022245368U * num;
				int num3 = num2 - (int)(num ^ 567537697U);
				num = (1230392424U & num);
				int num4 = num3;
				for (;;)
				{
					num -= 318443886U;
					if (1510287790 << (int)num == 0)
					{
						goto IL_34;
					}
					if (num4 < (int)(num ^ 3998690994U))
					{
						if (num == 763125606U)
						{
							goto IL_00;
						}
						num = 392317217U >> (int)num;
						66026065.28060A8C 28060A8C;
						if (!5DEF5E6B.IsStatic)
						{
							num = (143409829U | num);
							28060A8C = this.254C0263();
						}
						else
						{
							if (1547920860U <= num)
							{
								goto IL_00;
							}
							28060A8C = null;
							num += 143409701U;
						}
						num &= 1367436363U;
						28060A8C2 = 28060A8C;
						num = (1380679578U ^ num);
						bool flag = 28060A8C2 != null;
						num = 278659754U * num;
						object obj;
						if (!flag)
						{
							num = 701629916U * num;
							obj = null;
						}
						else
						{
							num <<= 0;
							obj = 28060A8C2.6DCA9058();
							num ^= 548032470U;
						}
						num = 1927218982U + num;
						object obj2;
						if ((obj2 = obj) == null)
						{
							if (1077371179U == num)
							{
								goto IL_24;
							}
							obj2 = null;
							num += 0U;
						}
						num /= 1838756074U;
						obj3 = obj2;
						if (num >= 617229518U)
						{
							goto IL_00;
						}
						if (3EBC542F)
						{
							if (97715121U == num)
							{
								goto IL_00;
							}
							bool flag2 = obj3 != null;
							num <<= 20;
							num ^= 1048577U;
							if (!flag2)
							{
								goto Block_16;
							}
						}
						num <<= 23;
						if ((1156459575U ^ num) == 0U)
						{
							goto IL_00;
						}
						object obj4 = null;
						num = 1039604791U + num;
						obj5 = obj4;
						num = 1253797420U * num;
						if (num <= 1355633514U)
						{
							goto IL_00;
						}
						num -= 1585084601U;
						if (!5DEF5E6B.IsConstructor)
						{
							goto IL_475;
						}
						num <<= 3;
						bool isValueType = 5DEF5E6B.DeclaringType.IsValueType;
						num <<= 14;
						num ^= 188547771U;
						if (!isValueType)
						{
							goto IL_475;
						}
						num = 1833895095U << (int)num;
						if (num * 1770344533U != 0U)
						{
							break;
						}
					}
					num = 654122180U;
					28060A8C2 = this.254C0263();
					if (1814855392U - num == 0U)
					{
						goto IL_00;
					}
					66026065.28060A8C 28060A8C3 = 28060A8C2;
					num %= 745214516U;
					bool flag3 = 28060A8C3.55CDE352();
					num += 395466678U;
					if (flag3)
					{
						num = (975440573U | num);
						if (2018278721U <= num)
						{
							goto IL_00;
						}
						Dictionary<int, 66026065.28060A8C> dictionary = dictionary2;
						int key = num4;
						num %= 1372348887U;
						dictionary[key] = 28060A8C2;
						num ^= 2099845U;
					}
					num += 954223067U;
					if (num + 2027583546U == 0U)
					{
						goto IL_34;
					}
					object[] array2 = array3;
					num >>= 13;
					int num5 = num4;
					num &= 1217332860U;
					num = (1558794202U & num);
					object 4C20265C = 28060A8C2;
					num = 302609422U - num;
					ParameterInfo parameterInfo = parameters[num4];
					num /= 2142306589U;
					66026065.28060A8C 28060A8C4 = this.64A3721C(4C20265C, parameterInfo.ParameterType);
					num %= 1257177835U;
					object obj6 = 28060A8C4.6DCA9058();
					num = 1157922760U * num;
					array2[num5] = obj6;
					num |= 473460826U;
					if (1043033158U == num)
					{
						goto IL_00;
					}
					int num6 = num4;
					int num7 = (int)(num - 473460825U);
					num *= 55988976U;
					int num8 = num6 - num7;
					num = 1475893832U / num;
					num4 = num8;
					num ^= 22167585U;
				}
				Type declaringType = 5DEF5E6B.DeclaringType;
				object[] args = array3;
				num ^= 817709445U;
				object obj7 = Activator.CreateInstance(declaringType, args);
				num ^= 496642296U;
				obj3 = obj7;
				if (568622808U > num)
				{
					goto IL_00;
				}
				if (28060A8C2 == null)
				{
					goto IL_BAF;
				}
				num = (929255341U ^ num);
			}
			while (num == 88103283U);
			66026065.28060A8C 28060A8C5 = 28060A8C2;
			num = 107446090U << (int)num;
			bool flag4 = 28060A8C5.55CDE352();
			num ^= 3933038973U;
			if (!flag4)
			{
				goto IL_BAF;
			}
			66026065.28060A8C 28060A8C6 = 28060A8C2;
			object 4C20265C2 = obj3;
			num = 828728026U - num;
			num &= 775560711U;
			66026065.28060A8C 28060A8C7 = this.64A3721C(4C20265C2, 5DEF5E6B.DeclaringType);
			num = (32921383U & num);
			28060A8C6.5F352F29(28060A8C7.6DCA9058());
			if ((num ^ 695808799U) != 0U)
			{
				goto Block_26;
			}
			continue;
			IL_475:
			num = 272972362U - num;
			num = (998995010U ^ num);
			object 067112C = obj3;
			num = 1053182814U + num;
			object[] 137101B = array3;
			num *= 2112361793U;
			bool flag5 = this.52EE1DF0(5DEF5E6B, 067112C, ref obj5, 137101B);
			num += 1151413810U;
			num ^= 3444860512U;
			if (flag5)
			{
				goto IL_BAF;
			}
			if (256915454U < num)
			{
				if (3EBC542F)
				{
					goto IL_B7F;
				}
				num = (880217600U & num);
				bool isVirtual = 5DEF5E6B.IsVirtual;
				num = 1203452267U >> (int)num;
				num ^= 3533459478U;
				if (!isVirtual)
				{
					goto IL_B7F;
				}
				num = 1336506655U * num;
				if (739192605U * num == 0U)
				{
					continue;
				}
				bool isFinal = 5DEF5E6B.IsFinal;
				num = 240983304U + num;
				num ^= 1621397846U;
				if (isFinal)
				{
					goto IL_B7F;
				}
				ParameterInfo[] array4 = parameters;
				num >>= 12;
				int num9 = array4.Length;
				num += 451747185U;
				int num10 = num9 + (int)(num - 452358118U);
				num /= 1889796164U;
				array5 = new object[num10];
				num = 2063826662U * num;
				if (454698566U >> (int)num == 0U)
				{
					goto IL_24;
				}
				array5[(int)(num ^ 0U)] = obj3;
				num = (1102915392U ^ num);
				int num11 = (int)(num - 1102915392U);
				if (699869739U == num)
				{
					goto IL_1C;
				}
				for (;;)
				{
					num = 1403330230U >> (int)num;
					int num12 = num11;
					ParameterInfo[] array6 = parameters;
					num &= 1966221288U;
					if (num12 >= array6.Length)
					{
						goto Block_36;
					}
					object[] array7 = array5;
					int num13 = num11;
					num = 1675577255U;
					int num14 = num13 + (int)(num + 2619390042U);
					num = 882641843U * num;
					object[] array8 = array3;
					int num15 = num11;
					num /= 388443786U;
					object obj8 = array8[num15];
					num = (1821397378U ^ num);
					array7[num14] = obj8;
					num -= 1823803785U;
					if (num <= 379668480U)
					{
						goto IL_00;
					}
					num11 += (int)(num ^ 4292560888U);
					num += 1105321799U;
				}
			}
			IL_34:
			ParameterInfo[] array9 = parameters;
			num = 1477399614U >> (int)num;
			array3 = new object[array9.Length];
			num = 1334192688U / num;
			if (num <= 987198341U)
			{
				goto IL_65;
			}
			IL_24:
			Dictionary<int, 66026065.28060A8C> dictionary3 = new Dictionary<int, 66026065.28060A8C>();
			num = 1083921993U % num;
			dictionary2 = dictionary3;
			goto IL_34;
			IL_1C:
			parameters = 5DEF5E6B.GetParameters();
			goto IL_24;
		}
		Block_16:
		num = 828258171U % num;
		throw new NullReferenceException();
		Block_26:
		num += 2499238264U;
		goto IL_BAF;
		Block_36:
		Dictionary<MethodBase, DynamicMethod> dictionary4 = 66026065.187A683B;
		num += 1386424035U;
		Dictionary<MethodBase, DynamicMethod> obj9 = dictionary4;
		DynamicMethod dynamicMethod;
		lock (obj9)
		{
			for (;;)
			{
				IL_65A:
				Dictionary<MethodBase, DynamicMethod> dictionary5 = 66026065.187A683B;
				num = (1019554553U | num);
				num = 1208820672U >> (int)num;
				bool flag6 = dictionary5.TryGetValue(5DEF5E6B, out dynamicMethod);
				num *= 1899431844U;
				if (flag6)
				{
					goto IL_A64;
				}
				num <<= 4;
				if (num == 1028881644U)
				{
					goto IL_6E1;
				}
				IL_6A6:
				int num16 = array5.Length;
				num = 1976581480U << (int)num;
				int num17 = num16;
				num %= 28576196U;
				Type[] array10 = new Type[num17];
				num = (725502638U & num);
				if (num % 231280423U == 0U)
				{
					continue;
				}
				IL_6E1:
				array10[(int)(num + 4294440316U)] = 5DEF5E6B.DeclaringType;
				ILGenerator ilgenerator;
				for (;;)
				{
					IL_6F2:
					int num18 = (int)(num ^ 526980U);
					if (num + 986974386U != 0U)
					{
						for (;;)
						{
							num -= 868102010U;
							int num19 = num18;
							ParameterInfo[] parameters;
							ParameterInfo[] array11 = parameters;
							num |= 953426189U;
							if (num19 >= array11.Length)
							{
								break;
							}
							Type[] array12 = array10;
							int num20 = num18 + 1;
							num = 591618691U;
							ParameterInfo[] array13 = parameters;
							int num21 = num18;
							num |= 995432751U;
							array12[num20] = array13[num21].ParameterType;
							int num22 = num18 + (int)(num + 3299378258U);
							num /= 220483382U;
							num18 = num22;
							num ^= 526976U;
						}
						string name = "";
						num = 1187133613U / num;
						if (methodInfo == null)
						{
							goto IL_7C4;
						}
						num = (73473564U | num);
						MethodInfo methodInfo2 = methodInfo;
						num ^= 1426016404U;
						Type returnType = methodInfo2.ReturnType;
						RuntimeTypeHandle handle = typeof(void).TypeHandle;
						num = (847068225U ^ num);
						if (returnType == Type.GetTypeFromHandle(handle))
						{
							num += 2635896119U;
							goto IL_7C4;
						}
						num = (2084534223U | num);
						MethodInfo methodInfo3 = methodInfo;
						num /= 832260067U;
						Type returnType2 = methodInfo3.ReturnType;
						num ^= 2U;
						IL_7EF:
						Type[] parameterTypes = array10;
						num -= 285035837U;
						RuntimeTypeHandle handle2 = typeof(66026065).TypeHandle;
						num = 815405476U >> (int)num;
						Module module = Type.GetTypeFromHandle(handle2).Module;
						num = 1818498801U * num;
						bool skipVisibility = num - 2419637235U != 0U;
						num /= 1871660062U;
						dynamicMethod = new DynamicMethod(name, returnType2, parameterTypes, module, skipVisibility);
						if (59783674U - num == 0U)
						{
							goto IL_65A;
						}
						ilgenerator = dynamicMethod.GetILGenerator();
						num -= 1890411935U;
						if (912730422U == num)
						{
							goto IL_65A;
						}
						ILGenerator ilgenerator2 = ilgenerator;
						num = 533005613U % num;
						66026065.28060A8C 28060A8C2;
						66026065.28060A8C 28060A8C8 = 28060A8C2;
						num ^= 1858026631U;
						OpCode opcode;
						if (!28060A8C8.55CDE352())
						{
							num ^= 1334536952U;
							opcode = OpCodes.Ldarg;
						}
						else
						{
							opcode = OpCodes.Ldarga;
							num ^= 1334536952U;
						}
						num = 1799505746U * num;
						ilgenerator2.Emit(opcode, (int)(num - 3633081924U));
						num = (879118754U ^ num);
						int num23 = (int)(num ^ 3974768615U);
						num *= 225451987U;
						int num24 = num23;
						if (95298903U > num)
						{
							goto IL_65A;
						}
						for (;;)
						{
							num = (1613180540U & num);
							if (390475432U == num)
							{
								goto IL_65A;
							}
							int num25 = num24;
							int num26 = array10.Length;
							num = 179261540U - num;
							if (num25 >= num26)
							{
								goto Block_57;
							}
							num = 1076826368U;
							if ((1877898810U ^ num) == 0U)
							{
								goto IL_6F2;
							}
							ILGenerator ilgenerator3 = ilgenerator;
							num = (1269070550U ^ num);
							Dictionary<int, 66026065.28060A8C> dictionary6 = dictionary2;
							num /= 1404915369U;
							int num27 = num24;
							num = 1097139043U - num;
							int num28 = (int)(num - 1097139042U);
							num = (1923051388U | num);
							int key2 = num27 - num28;
							num = (266426898U ^ num);
							OpCode opcode2;
							if (!dictionary6.ContainsKey(key2))
							{
								num = 1064988992U - num;
								opcode2 = OpCodes.Ldarg;
							}
							else
							{
								opcode2 = OpCodes.Ldarga;
								num ^= 3208777406U;
							}
							num *= 503920881U;
							ilgenerator3.Emit(opcode2, num24);
							if (num == 561580349U)
							{
								goto IL_6A6;
							}
							int num29 = num24;
							int num30 = (int)(num ^ 3948247458U);
							num = 789648672U << (int)num;
							int num31 = num29 + num30;
							num >>= 25;
							num24 = num31;
							num ^= 3262364846U;
						}
						IL_7C4:
						returnType2 = null;
						goto IL_7EF;
					}
					goto IL_65A;
				}
				Block_57:
				num = (1138434175U & num);
				ILGenerator ilgenerator4 = ilgenerator;
				num = 1003559166U << (int)num;
				OpCode call = OpCodes.Call;
				MethodInfo meth = methodInfo;
				num = (1417494534U | num);
				ilgenerator4.Emit(call, meth);
				if (num + 320212184U == 0U)
				{
					continue;
				}
				ilgenerator.Emit(OpCodes.Ret);
				Dictionary<MethodBase, DynamicMethod> dictionary7 = 66026065.187A683B;
				num += 1332158998U;
				num = 344221411U / num;
				dictionary7[5DEF5E6B] = dynamicMethod;
				num ^= 4209984708U;
				IL_A64:
				if (1413832807U * num != 0U)
				{
					break;
				}
				goto IL_6A6;
			}
		}
		do
		{
			MethodBase methodBase = dynamicMethod;
			num = 467823862U;
			object obj10 = null;
			num = 908138579U / num;
			object obj11 = methodBase.Invoke(obj10, array5);
			num &= 767559415U;
			obj5 = obj11;
			num = 1928294353U >> (int)num;
		}
		while (num % 119741374U == 0U);
		using (Dictionary<int, 66026065.28060A8C>.Enumerator enumerator = dictionary2.GetEnumerator())
		{
			if (1948809267U <= num)
			{
				goto IL_AE9;
			}
			IL_AD5:
			goto IL_B1B;
			IL_AE9:
			KeyValuePair<int, 66026065.28060A8C> keyValuePair;
			66026065.28060A8C value = keyValuePair.Value;
			object[] array14 = array5;
			int key3 = keyValuePair.Key;
			int num32 = (int)(num + 3684204636U);
			num ^= 962868976U;
			value.5F352F29(array14[key3 + num32]);
			num ^= 611647165U;
			IL_B1B:
			num &= 1808470103U;
			if (733302339U != num)
			{
				num |= 6563743U;
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, 66026065.28060A8C> keyValuePair2 = enumerator.Current;
					num = 610762661U;
					keyValuePair = keyValuePair2;
					goto IL_AE9;
				}
				if (322700598U > num)
				{
					goto IL_AD5;
				}
			}
		}
		dictionary2.Clear();
		num = 2502388093U;
		goto IL_BAF;
		IL_B7F:
		num = (590305725U | num);
		object obj12 = 5DEF5E6B.Invoke(obj3, array3);
		num = 1156461988U >> (int)num;
		obj5 = obj12;
		num += 2502388091U;
		IL_BAF:
		num |= 1502099290U;
		using (Dictionary<int, 66026065.28060A8C>.Enumerator enumerator = dictionary2.GetEnumerator())
		{
			if (173034534U >= num)
			{
				goto IL_BF8;
			}
			IL_BCD:
			goto IL_C40;
			IL_BF8:
			KeyValuePair<int, 66026065.28060A8C> keyValuePair3;
			66026065.28060A8C value2 = keyValuePair3.Value;
			object[] array15 = array3;
			num ^= 1058084681U;
			num = (125399805U ^ num);
			int key4 = keyValuePair3.Key;
			num = 2013671461U + num;
			object 35C42CED = array15[key4];
			num = 311638962U % num;
			value2.5F352F29(35C42CED);
			num += 3407627213U;
			IL_C40:
			num = 533139000U / num;
			if ((1480489186U ^ num) == 0U)
			{
				goto IL_BCD;
			}
			num = 829167039U + num;
			bool flag7 = enumerator.MoveNext();
			num *= 22094245U;
			if (!flag7)
			{
				if (711150224U >= num)
				{
					goto IL_BCD;
				}
			}
			else
			{
				num = 1270634378U;
				keyValuePair3 = enumerator.Current;
				num = 213078612U / num;
				if (num >> 5 == 0U)
				{
					goto IL_BF8;
				}
				goto IL_BCD;
			}
		}
		for (;;)
		{
			bool flag8 = methodInfo != null;
			num = 855393102U;
			if (!flag8)
			{
				goto IL_CE2;
			}
			num |= 1240277247U;
			Type returnType3 = methodInfo.ReturnType;
			num = (1597522996U ^ num);
			RuntimeTypeHandle handle3 = typeof(void).TypeHandle;
			num = (1475570343U ^ num);
			if (returnType3 == Type.GetTypeFromHandle(handle3))
			{
				break;
			}
			if (1797861390U - num != 0U)
			{
				goto Block_43;
			}
		}
		num ^= 1103760930U;
		IL_CE2:
		return null;
		Block_43:
		object 4C20265C3 = obj5;
		num = 413873175U >> (int)num;
		return this.64A3721C(4C20265C3, methodInfo.ReturnType);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0021842C File Offset: 0x0021842C
	private 66026065.28060A8C 687359D7(int 1D925D64, bool 5E6E1C7E)
	{
		uint num;
		Dictionary<int, 66026065.28060A8C> dictionary2;
		object[] array;
		int num13;
		for (;;)
		{
			IL_00:
			num = 1937972121U;
			int num2 = this.7F97109A;
			num = 2118520801U - num;
			for (;;)
			{
				IL_15:
				int num3 = 1D925D64;
				num <<= 14;
				this.7F97109A = num3;
				num = 616565048U - num;
				ushort num4 = (ushort)this.1FC8038B();
				num /= 1107250017U;
				ushort num5 = num4;
				num = 305738183U % num;
				Dictionary<int, 66026065.28060A8C> dictionary = new Dictionary<int, 66026065.28060A8C>();
				num ^= 2143306933U;
				dictionary2 = dictionary;
				if (num + 2064457387U != 0U)
				{
					array = null;
					num = (263460815U ^ num);
					IL_69:
					while ((uint)num5 > num + 2408295558U)
					{
						if ((1022563738U ^ num) == 0U)
						{
							goto IL_15;
						}
						int num6 = (int)num5;
						num = 642586307U + num;
						array = new object[num6];
						num |= 443952112U;
						if (num <= 849889480U)
						{
							goto IL_15;
						}
						int num7 = (int)((uint)num5 - (num + 1627952132U));
						num = 977086825U + num;
						int num8 = num7;
						if (num > 1546078654U)
						{
							for (;;)
							{
								num >>= 8;
								uint num9 = (uint)num8;
								num &= 2084378468U;
								if (num9 < num + 4293323772U)
								{
									break;
								}
								num = 1919828277U;
								66026065.28060A8C 28060A8C = this.254C0263();
								num -= 1455371530U;
								66026065.28060A8C 28060A8C2 = 28060A8C;
								num = 104681636U % num;
								66026065.28060A8C 28060A8C3 = 28060A8C2;
								num = 1720070546U >> (int)num;
								bool flag = 28060A8C3.55CDE352();
								num = (55056712U | num);
								if (flag)
								{
									num /= 1137051260U;
									if (458826665U * num != 0U)
									{
										goto IL_00;
									}
									Dictionary<int, 66026065.28060A8C> dictionary3 = dictionary2;
									int key = num8;
									66026065.28060A8C value = 28060A8C2;
									num %= 1216898156U;
									dictionary3[key] = value;
									num ^= 124287833U;
								}
								num /= 962360646U;
								if (num == 1151665312U)
								{
									goto IL_69;
								}
								object[] array2 = array;
								int num10 = num8;
								num <<= 0;
								object 4C20265C = 28060A8C2;
								num >>= 13;
								int 0F8107B = this.51984E22();
								num = 634609449U >> (int)num;
								Type 2A7B54D = this.22C50466(0F8107B);
								num /= 685080293U;
								object obj = this.64A3721C(4C20265C, 2A7B54D).6DCA9058();
								num = 1541231812U << (int)num;
								array2[num10] = obj;
								num >>= 31;
								int num11 = num8;
								num = (1450653142U | num);
								int num12 = (int)(num - 1450653141U);
								num *= 1830711545U;
								num8 = num11 - num12;
								num += 715102272U;
							}
							num ^= 1886209918U;
							break;
						}
						goto IL_00;
					}
					num = (1015042219U ^ num);
					num13 = this.51984E22();
					if (num < 1535539660U)
					{
						1D925D64 = this.7F97109A;
						num = 921978443U >> (int)num;
						int num14 = num2;
						num = 1115951543U << (int)num;
						this.7F97109A = num14;
						if (!5E6E1C7E)
						{
							goto IL_290;
						}
						bool flag2 = array != null;
						num &= 262426879U;
						if (!flag2)
						{
							goto IL_282;
						}
						num <<= 18;
						if (num << 19 == 0U)
						{
							goto Block_12;
						}
					}
				}
			}
		}
		Block_12:
		object[] array3 = array;
		int num15 = (int)(num ^ 0U);
		num = 1976435504U * num;
		bool flag3 = array3[num15];
		num ^= 3690987520U;
		if (flag3)
		{
			goto IL_290;
		}
		num += 805306368U;
		IL_282:
		num /= 373848844U;
		throw new NullReferenceException();
		IL_290:
		num = 144596405U << (int)num;
		66026065 <<EMPTY_NAME>> = new 66026065();
		num <<= 16;
		object[] 408F = array;
		num = 1940326649U / num;
		object obj2 = <<EMPTY_NAME>>.433F05E0(408F, 1D925D64);
		num = 1922971906U << (int)num;
		Dictionary<int, 66026065.28060A8C>.Enumerator enumerator = dictionary2.GetEnumerator();
		num *= 2043439309U;
		using (Dictionary<int, 66026065.28060A8C>.Enumerator enumerator2 = enumerator)
		{
			for (;;)
			{
				for (;;)
				{
					num <<= 15;
					if (!enumerator2.MoveNext())
					{
						goto Block_19;
					}
					num = 300964072U;
					KeyValuePair<int, 66026065.28060A8C> keyValuePair = enumerator2.Current;
					num ^= 1145324466U;
					KeyValuePair<int, 66026065.28060A8C> keyValuePair2 = keyValuePair;
					if (num >= 1280597470U)
					{
						66026065.28060A8C value2 = keyValuePair2.Value;
						object[] array4 = array;
						num = (728512043U | num);
						int key2 = keyValuePair2.Key;
						num |= 49306659U;
						object 35C42CED = array4[key2];
						num &= 1346193206U;
						value2.5F352F29(35C42CED);
						num += 2393679362U;
					}
				}
			}
			Block_19:;
		}
		Type type;
		do
		{
			bool flag4 = num13 != 0;
			num = 841175259U;
			if (!flag4)
			{
				goto IL_3E2;
			}
			num = 862668056U << (int)num;
			if (1229923684U > num)
			{
				break;
			}
			type = this.22C50466(num13);
			num = 1274741900U >> (int)num;
		}
		while (1608135779U <= num);
		Type type2 = type;
		RuntimeTypeHandle handle = typeof(void).TypeHandle;
		num = (1001551619U ^ num);
		Type typeFromHandle = Type.GetTypeFromHandle(handle);
		num ^= 1114252116U;
		if (type2 != typeFromHandle)
		{
			num /= 771583665U;
			object 4C20265C2 = obj2;
			Type 2A7B54D2 = type;
			num |= 751247408U;
			return this.64A3721C(4C20265C2, 2A7B54D2);
		}
		IL_3E2:
		return null;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00218838 File Offset: 0x00218838
	private bool 494D54B7(object 56B56308, Type 049A25F4)
	{
		uint num = 1326139686U;
		if (1259089366U * num == 0U)
		{
			goto IL_30;
		}
		IL_12:
		num = (526125170U & num);
		if (56B56308 == null)
		{
			num += 393635510U;
			return num + 3649147177U != 0U;
		}
		IL_30:
		if (471883167U >= num)
		{
			num %= 1280067089U;
			Type type = 56B56308.GetType();
			num ^= 792427194U;
			Type type2 = type;
			num /= 2093613633U;
			if (type2 != 049A25F4)
			{
				if (!049A25F4.IsAssignableFrom(type))
				{
					return (num ^ 0U) != 0U;
				}
				num ^= 0U;
			}
			num = 1815546374U - num;
			return num + 2479420923U != 0U;
		}
		goto IL_12;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x002188D4 File Offset: 0x002188D4
	private void 77080C9E(Exception 62A67181)
	{
		uint num = 1886075712U;
		66026065.608572C1 608572C;
		for (;;)
		{
			IL_06:
			this.307C15CA.Clear();
			do
			{
				IL_11:
				this.090E383D.Clear();
				if ((1337293132U & num) == 0U)
				{
					goto IL_06;
				}
				for (;;)
				{
					IL_28:
					bool flag = this.51A00CFC != null;
					num &= 2104780259U;
					if (!flag)
					{
						num >>= 5;
						if (num <= 814635896U)
						{
							goto IL_4E;
						}
						goto IL_11;
					}
					for (;;)
					{
						IL_577:
						num ^= 2092324244U;
						num = (1271411748U & num);
						if (this.0E7C79AF.Count == 0)
						{
							goto Block_33;
						}
						num = 1977891528U;
						num -= 1269779418U;
						List<66026065.608572C1> list = this.0E7C79AF.Peek().24E26117();
						num >>= 9;
						if (1801456411 << (int)num == 0)
						{
							goto IL_06;
						}
						num = 1807090824U * num;
						int num2;
						if (this.51A00CFC != null)
						{
							if (1487761385U > num)
							{
								goto IL_06;
							}
							List<66026065.608572C1> list2 = list;
							num = 715288867U * num;
							num2 = list2.IndexOf(this.51A00CFC) + (int)(num ^ 154067113U);
						}
						else
						{
							num <<= 22;
							num2 = (int)(num ^ 3456106496U);
							num += 992927912U;
						}
						num %= 2078616541U;
						this.51A00CFC = null;
						int num3 = num2;
						if (num > 755332378U)
						{
							goto IL_11;
						}
						for (;;)
						{
							int num4 = num3;
							num ^= 1647121346U;
							List<66026065.608572C1> list3 = list;
							num = 695809234U / num;
							int count = list3.Count;
							num += 739993494U;
							if (num4 >= count)
							{
								break;
							}
							num = 612464674U;
							if (1191336589U <= num)
							{
								goto IL_28;
							}
							List<66026065.608572C1> list4 = list;
							int index = num3;
							num = 1564356131U - num;
							608572C = list4[index];
							num = 1041379267U >> (int)num;
							if (1265786081U >> (int)num == 0U)
							{
								goto IL_06;
							}
							byte b = 608572C.00381BFD();
							num = 1535268505U << (int)num;
							if (num * 9507348U == 0U)
							{
								goto IL_73;
							}
							bool flag2 = b != 0;
							num = (313883462U | num);
							if (flag2)
							{
								num *= 1455633323U;
								byte b2 = b;
								uint num5 = num ^ 861414867U;
								num = (2114529894U & num);
								if (b2 == num5)
								{
									goto IL_2EB;
								}
								if (num * 2055081270U == 0U)
								{
									goto IL_4E;
								}
							}
							else
							{
								num = 319571748U - num;
								if (1917352819U <= num)
								{
									goto IL_06;
								}
								Type type = 62A67181.GetType();
								num = 919101900U << (int)num;
								num = 151735025U >> (int)num;
								66026065.608572C1 608572C2 = 608572C;
								num = 447685399U + num;
								Type type2 = this.22C50466(608572C2.02ED5F43());
								if (1467179063U - num == 0U)
								{
									goto IL_11;
								}
								Type type3 = type;
								num = 1030949337U >> (int)num;
								Type type4 = type2;
								num -= 2109830033U;
								if (type3 == type4)
								{
									goto IL_270;
								}
								Type type5 = type;
								num |= 1898528806U;
								bool flag3 = type5.IsSubclassOf(type2);
								num = 49508663U * num;
								num ^= 3188499024U;
								if (flag3)
								{
									goto Block_15;
								}
							}
							num = 1225877848U + num;
							if (num <= 1014462559U)
							{
								goto IL_06;
							}
							int num6 = num3;
							num /= 1398765287U;
							int num7 = (int)(num + 0U);
							num = (636115382U ^ num);
							int num8 = num6 + num7;
							num |= 497706711U;
							num3 = num8;
							num += 3410256049U;
						}
						if ((2015447082U ^ num) == 0U)
						{
							goto IL_11;
						}
						num = (689205643U & num);
						Stack<66026065.4AB007C7> stack = this.0E7C79AF;
						num = (136914994U & num);
						stack.Pop();
						num /= 241069260U;
						if (1710442137U == num)
						{
							goto IL_11;
						}
						int num9 = list.Count;
						for (;;)
						{
							num /= 111358061U;
							if ((num & 472933941U) != 0U)
							{
								goto IL_06;
							}
							if (num9 <= (int)(num ^ 0U))
							{
								break;
							}
							num = 1539589289U;
							if (num == 299302987U)
							{
								goto IL_11;
							}
							List<66026065.608572C1> list5 = list;
							num = 1082528636U * num;
							int num10 = num9;
							int num11 = (int)(num - 882887899U);
							num <<= 9;
							66026065.608572C1 608572C3 = list5[num10 - num11];
							num = (430064098U & num);
							66026065.608572C1 608572C4 = 608572C3;
							if (num + 443956810U == 0U)
							{
								goto IL_28;
							}
							if ((uint)608572C4.00381BFD() == num + 3867148290U)
							{
								goto IL_490;
							}
							if (num / 530594148U != 0U)
							{
								goto IL_06;
							}
							if ((uint)608572C4.00381BFD() == num - 427819004U)
							{
								num += 0U;
								goto IL_490;
							}
							IL_4C5:
							num = (1762273682U & num);
							int num12 = num9 - (int)(num ^ 150994945U);
							num = 1981304792U / num;
							num9 = num12;
							num ^= 13U;
							continue;
							IL_490:
							if ((num ^ 1909196036U) != 0U)
							{
								num &= 1113477253U;
								Stack<int> stack2 = this.090E383D;
								num /= 227573607U;
								stack2.Push(608572C4.0A1E119D());
								num ^= 427819008U;
								goto IL_4C5;
							}
							goto IL_4E;
						}
						num *= 1993155600U;
						if (num / 1195520982U != 0U)
						{
							goto IL_11;
						}
						num &= 577001344U;
						bool count2 = this.090E383D.Count != 0;
						num = 745489883U << (int)num;
						num += 1139858277U;
						if (count2)
						{
							goto Block_32;
						}
					}
					IL_270:
					num <<= 22;
					num |= 55059134U;
					this.0E7C79AF.Pop();
					if (num >= 362676872U)
					{
						goto Block_16;
					}
					goto IL_4E;
					Block_15:
					num ^= 2960383802U;
					goto IL_270;
					IL_73:
					goto IL_577;
					IL_4E:
					num = (489581938U ^ num);
					num = 580992032U >> (int)num;
					this.62390F5C = 62A67181;
					num ^= 1885348194U;
					goto IL_73;
				}
				IL_2EB:;
			}
			while (num == 431580422U);
			66026065.608572C1 608572C5 = 608572C;
			num = (1909858531U | num);
			this.51A00CFC = 608572C5;
			num = 1256266401U >> (int)num;
			Stack<66026065.61781FE7> stack3 = this.307C15CA;
			num &= 329277495U;
			object 085C45CB = this.62390F5C;
			num += 885207751U;
			66026065.61781FE7 item = new 66026065.332067BD(085C45CB);
			num >>= 31;
			stack3.Push(item);
			66026065.608572C1 608572C6 = 608572C;
			num = 191782870U + num;
			this.7F97109A = 608572C6.02ED5F43();
			if (2045736071U > num)
			{
				return;
			}
		}
		Block_16:
		Stack<66026065.61781FE7> stack4 = this.307C15CA;
		num = 1136535324U % num;
		object 085C45CB2 = this.62390F5C;
		num = 1517901428U - num;
		66026065.61781FE7 item2 = new 66026065.332067BD(085C45CB2);
		num = 1266033066U / num;
		stack4.Push(item2);
		num = 41906146U % num;
		num = 1147088184U * num;
		int num13 = 608572C.0A1E119D();
		num = 787178855U / num;
		this.7F97109A = num13;
		return;
		Block_32:
		num >>= 0;
		num |= 885150291U;
		int num14 = this.090E383D.Pop();
		num -= 413869993U;
		this.7F97109A = num14;
		return;
		Block_33:
		num = 1541492790U / num;
		throw 62A67181;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00218E84 File Offset: 0x00218E84
	private void 37AD0EB6()
	{
		uint num = 765550215U;
		66026065.28060A8C 28060A8C;
		66026065.28060A8C 28060A8C4;
		for (;;)
		{
			num = 1980961150U - num;
			Type 2A7B54D = this.22C50466(this.254C0263().D02DFB88());
			if (1654795538U >= num)
			{
				do
				{
					28060A8C = this.254C0263();
				}
				while (num + 1840711308U == 0U);
				66026065.28060A8C 28060A8C2 = this.254C0263();
				num &= 1160793683U;
				object 4C20265C = 28060A8C2.6DCA9058();
				num = 648954434U / num;
				66026065.28060A8C 28060A8C3 = this.64A3721C(4C20265C, 2A7B54D);
				num = 197555216U - num;
				28060A8C4 = 28060A8C3;
				num *= 267126187U;
				if (num != 624839494U)
				{
					break;
				}
			}
		}
		66026065.28060A8C 28060A8C5 = 28060A8C;
		num ^= 128086436U;
		if (28060A8C5.55CDE352())
		{
			66026065.28060A8C 71DE45FC = 28060A8C4;
			66026065.28060A8C 6BF636B = 28060A8C;
			num = 1671914356U % num;
			66026065.28060A8C 28060A8C6 = new 66026065.1FE710AC(71DE45FC, 6BF636B);
			num = 1483361571U * num;
			28060A8C4 = 28060A8C6;
			num ^= 2917522376U;
		}
		num >>= 25;
		List<66026065.28060A8C> list = this.56F9446E;
		num >>= 16;
		66026065.28060A8C item = 28060A8C4;
		num = 2096250367U + num;
		list.Add(item);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00218F64 File Offset: 0x00218F64
	private void 6DE91C9C()
	{
		uint num = 1790919114U;
		int num2;
		do
		{
			num2 = this.254C0263().D02DFB88();
		}
		while (2099529688U / num == 0U);
		List<66026065.4AB007C7>.Enumerator enumerator = this.13F94EC7.GetEnumerator();
		num = 44630272U / num;
		List<66026065.4AB007C7>.Enumerator enumerator2 = enumerator;
		try
		{
			for (;;)
			{
				num = (1321546310U & num);
				if (!enumerator2.MoveNext())
				{
					break;
				}
				66026065.4AB007C7 4AB007C = enumerator2.Current;
				int num3 = 4AB007C.49CD1B84();
				num = 1785154871U;
				int num4 = num2;
				num -= 1770281934U;
				num += 4280094359U;
				if (num3 == num4)
				{
					num -= 2034173312U;
					num = 1587947596U + num;
					Stack<66026065.4AB007C7> stack = this.0E7C79AF;
					66026065.4AB007C7 item = 4AB007C;
					num = 491615924U / num;
					stack.Push(item);
					num ^= 0U;
				}
			}
		}
		finally
		{
			do
			{
				num = 1327109926U;
				((IDisposable)enumerator2).Dispose();
			}
			while (911752540U / num != 0U);
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00219054 File Offset: 0x00219054
	private void 001449A9()
	{
		uint num = 825702183U;
		if (1489130219U >= num)
		{
			do
			{
				num %= 1754344007U;
				this.2A5A7C53(new 66026065.152602F0(this.51984E22()));
			}
			while (427969433U > num);
		}
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00219098 File Offset: 0x00219098
	private void 08E24F7E()
	{
		uint num = 619450027U;
		num >>= 11;
		long 156A0AAB = this.6C613E40();
		num %= 352197051U;
		66026065.28060A8C 59F = new 66026065.6DA9264D(156A0AAB);
		num = (1445756094U | num);
		this.2A5A7C53(59F);
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x002190D4 File Offset: 0x002190D4
	private void 26433BD5()
	{
		uint num;
		do
		{
			num = 1358501414U;
			float 34DA3CFB = this.4A424B0E();
			num = 759106910U - num;
			66026065.28060A8C 59F = new 66026065.7CEE5B47(34DA3CFB);
			num -= 790456847U;
			this.2A5A7C53(59F);
		}
		while (1839293497U >= num);
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00219114 File Offset: 0x00219114
	private void 206F69E1()
	{
		uint num;
		do
		{
			num = 1904499349U;
			num &= 1037655023U;
			double 5FD904DC = this.1D1F20BF();
			num += 1660974383U;
			66026065.28060A8C 59F = new 66026065.18527F7D(5FD904DC);
			num <<= 16;
			this.2A5A7C53(59F);
		}
		while (num << 2 == 0U);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0021915C File Offset: 0x0021915C
	private void 323A0BD0()
	{
		uint num = 28997792U;
		if (996812410U >= num)
		{
			do
			{
				this.2A5A7C53(new 66026065.332067BD(null));
			}
			while (num - 1081545602U == 0U);
		}
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00219194 File Offset: 0x00219194
	private void 45226D21()
	{
		uint num = 82583250U;
		if ((1891311754U ^ num) != 0U)
		{
			do
			{
				num %= 1851420646U;
				66026065.28060A8C 28060A8C = this.254C0263();
				num = 1029376085U - num;
				string 7F7E7F = this.59041F06(28060A8C.D02DFB88());
				num = 648750214U >> (int)num;
				this.2A5A7C53(new 66026065.1B84428C(7F7E7F));
			}
			while (num * 1532061390U == 0U);
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x002191FC File Offset: 0x002191FC
	private void 46B61CF0()
	{
		uint num = 597450773U;
		66026065.28060A8C 28060A8C = this.050E096B();
		num = (1875922935U ^ num);
		66026065.28060A8C 59F = 28060A8C.1368930D();
		num = 354450083U % num;
		this.2A5A7C53(59F);
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00219230 File Offset: 0x00219230
	private void 2A45676B()
	{
		66026065.28060A8C 28060A8C = this.254C0263();
		uint num = 2026387257U;
		66026065.28060A8C 28060A8C2 = 28060A8C;
		if (928449946U % num != 0U)
		{
			do
			{
				66026065.28060A8C 28060A8C3 = this.254C0263();
				num = 1518011500U + num;
				num -= 1773933359U;
				66026065.28060A8C 266F = 28060A8C2;
				num <<= 13;
				66026065.28060A8C 45EC5D6F = 28060A8C3;
				bool 77A376FE = num - 3842949120U != 0U;
				num = 1329928433U << (int)num;
				66026065.28060A8C 59F = this.73F651C6(266F, 45EC5D6F, 77A376FE, num - 1329928433U != 0U);
				num = 922446519U / num;
				this.2A5A7C53(59F);
			}
			while (num > 1903326643U);
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x002192B4 File Offset: 0x002192B4
	private void 00F80003()
	{
		uint num = 925506683U;
		66026065.28060A8C 28060A8C = this.254C0263();
		num /= 881488851U;
		66026065.28060A8C 28060A8C2 = 28060A8C;
		num = 718366368U + num;
		66026065.28060A8C 28060A8C3 = this.254C0263();
		do
		{
			66026065.28060A8C 266F = 28060A8C2;
			num %= 420162524U;
			66026065.28060A8C 45EC5D6F = 28060A8C3;
			num = 100227674U >> (int)num;
			bool 77A376FE = num + 4291835183U != 0U;
			num &= 1973829611U;
			this.2A5A7C53(this.73F651C6(266F, 45EC5D6F, 77A376FE, num - 2493122U != 0U));
		}
		while (num >= 1136070498U);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x0021932C File Offset: 0x0021932C
	private void 23C10A1A()
	{
		uint num = 148964605U;
		66026065.28060A8C 28060A8C2;
		do
		{
			num |= 1399354047U;
			66026065.28060A8C 28060A8C = this.254C0263();
			num <<= 23;
			28060A8C2 = 28060A8C;
			num >>= 27;
		}
		while (num > 50992391U);
		do
		{
			66026065.28060A8C 28060A8C3 = this.254C0263();
			num <<= 29;
			66026065.28060A8C 28060A8C4 = 28060A8C3;
			66026065.28060A8C 266F = 28060A8C2;
			num = 610491066U * num;
			66026065.28060A8C 45EC5D6F = 28060A8C4;
			num *= 586562871U;
			bool 77A376FE = (num ^ 1073741825U) != 0U;
			num |= 38945452U;
			bool 7E7D48FC = (num ^ 1112687277U) != 0U;
			num = 52441504U >> (int)num;
			66026065.28060A8C 59F = this.73F651C6(266F, 45EC5D6F, 77A376FE, 7E7D48FC);
			num = 1312516097U * num;
			this.2A5A7C53(59F);
		}
		while (785212081U > num);
	}

	// Token: 0x060000DE RID: 222 RVA: 0x002193D0 File Offset: 0x002193D0
	private void 05C85C40()
	{
		for (;;)
		{
			66026065.28060A8C 28060A8C = this.254C0263();
			uint num = 2028699633U;
			66026065.28060A8C 28060A8C2 = 28060A8C;
			if (1292764114 << (int)num == 0)
			{
				break;
			}
			for (;;)
			{
				66026065.28060A8C 28060A8C3 = this.254C0263();
				num = 2045332381U + num;
				66026065.28060A8C 28060A8C4 = 28060A8C3;
				if (num <= 408318133U)
				{
					break;
				}
				num /= 756356365U;
				66026065.28060A8C 31761F = 28060A8C4;
				num = (1190812754U | num);
				66026065.28060A8C 223F2C9D = 28060A8C2;
				num += 533666409U;
				66026065.28060A8C 59F = this.71FD0992(31761F, 223F2C9D, num - 1724479168U != 0U, num + 2570488128U != 0U);
				num += 1318548709U;
				this.2A5A7C53(59F);
				if (num > 682361610U)
				{
					return;
				}
			}
		}
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00219460 File Offset: 0x00219460
	private void 3B3E7A40()
	{
		uint num = 2022799585U;
		66026065.28060A8C 28060A8C = this.254C0263();
		66026065.28060A8C 28060A8C2 = this.254C0263();
		num = 1386118212U / num;
		66026065.28060A8C 28060A8C3 = 28060A8C2;
		do
		{
			num = (1509834500U ^ num);
			66026065.28060A8C 31761F = 28060A8C3;
			num = 1792753841U % num;
			66026065.28060A8C 223F2C9D = 28060A8C;
			num ^= 1891528179U;
			bool 2A1D1A = (num ^ 1617128543U) != 0U;
			bool 16A16B = (num ^ 1617128542U) != 0U;
			num = 1182466074U / num;
			this.2A5A7C53(this.71FD0992(31761F, 223F2C9D, 2A1D1A, 16A16B));
		}
		while (368185509U == num);
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x002194D0 File Offset: 0x002194D0
	private void 5FBA647E()
	{
		66026065.28060A8C 28060A8C = this.254C0263();
		uint num = 1995469687U;
		num -= 561469808U;
		66026065.28060A8C 28060A8C2 = this.254C0263();
		num = (1653281156U & num);
		66026065.28060A8C 28060A8C3 = 28060A8C2;
		num = (890596154U & num);
		66026065.28060A8C 31761F = 28060A8C3;
		num = (817122942U & num);
		66026065.28060A8C 223F2C9D = 28060A8C;
		num = (2060269432U & num);
		bool 2A1D1A = (num ^ 1U) != 0U;
		bool 16A16B = (num ^ 1U) != 0U;
		num %= 1758744543U;
		this.2A5A7C53(this.71FD0992(31761F, 223F2C9D, 2A1D1A, 16A16B));
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00219540 File Offset: 0x00219540
	private void 208C0F82()
	{
		uint num = 646451836U;
		66026065.28060A8C 33352FB = this.254C0263();
		num = 1899190944U - num;
		66026065.28060A8C 28060A8C;
		if (830950552U - num != 0U)
		{
			28060A8C = this.254C0263();
			num += 514224718U;
		}
		num *= 1639931832U;
		66026065.28060A8C 3D = 28060A8C;
		num = 1619344410U << (int)num;
		66026065.28060A8C 59F = this.2A965EEF(3D, 33352FB, num - 1008336896U != 0U, num - 1008336896U != 0U);
		num &= 1429088113U;
		this.2A5A7C53(59F);
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x002195B8 File Offset: 0x002195B8
	private void 12B02CA4()
	{
		uint num = 2132762400U;
		if (845371944U < num)
		{
			66026065.28060A8C 28060A8C;
			do
			{
				num /= 547491548U;
				28060A8C = this.254C0263();
			}
			while (773864335U % num == 0U);
			num &= 984423398U;
			66026065.28060A8C 28060A8C2 = this.254C0263();
			num = 631263561U - num;
			66026065.28060A8C 28060A8C3 = 28060A8C2;
			num &= 886271802U;
			num = (1971927754U ^ num);
			66026065.28060A8C 3D = 28060A8C3;
			num *= 1991997161U;
			66026065.28060A8C 33352FB = 28060A8C;
			bool 1B56013D = (num ^ 3150436617U) != 0U;
			bool 30B72C6A = (num ^ 3150436616U) != 0U;
			num = (2029657556U | num);
			66026065.28060A8C 59F = this.2A965EEF(3D, 33352FB, 1B56013D, 30B72C6A);
			num *= 670900078U;
			this.2A5A7C53(59F);
		}
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0021964C File Offset: 0x0021964C
	private void 7941752A()
	{
		uint num = 18300111U;
		66026065.28060A8C 28060A8C = this.254C0263();
		num = (509377937U ^ num);
		66026065.28060A8C 28060A8C2 = 28060A8C;
		num = 2042190099U % num;
		66026065.28060A8C 28060A8C4;
		do
		{
			66026065.28060A8C 28060A8C3 = this.254C0263();
			num = 832781746U / num;
			28060A8C4 = 28060A8C3;
			num = (2086091739U & num);
		}
		while (num / 809005195U != 0U);
		num = 736561230U / num;
		66026065.28060A8C 3D = 28060A8C4;
		num = 1733586239U - num;
		66026065.28060A8C 33352FB = 28060A8C2;
		bool 1B56013D = (num ^ 997025008U) != 0U;
		num = 1217409140U % num;
		bool 30B72C6A = (num ^ 220384130U) != 0U;
		num = (1256931485U ^ num);
		66026065.28060A8C 59F = this.2A965EEF(3D, 33352FB, 1B56013D, 30B72C6A);
		num += 1642207336U;
		this.2A5A7C53(59F);
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x002196E0 File Offset: 0x002196E0
	private void 08A07361()
	{
		uint num = 1050683052U;
		if (70402627U / num != 0U)
		{
			goto IL_30;
		}
		66026065.28060A8C 28060A8C = this.254C0263();
		IL_19:
		66026065.28060A8C 28060A8C2 = this.254C0263();
		num %= 1426669910U;
		66026065.28060A8C 28060A8C3 = 28060A8C2;
		num &= 1271995767U;
		IL_30:
		num = (597580361U | num);
		num = 2116030787U + num;
		66026065.28060A8C 51DC = 28060A8C3;
		num = 36068466U - num;
		66026065.28060A8C 094A0DCB = 28060A8C;
		num >>= 19;
		this.2A5A7C53(this.4FA71865(51DC, 094A0DCB, (num ^ 2828U) != 0U));
		if ((248537913U & num) != 0U)
		{
			return;
		}
		goto IL_19;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00219760 File Offset: 0x00219760
	private void 53A46177()
	{
		uint num = 1295415747U;
		num = (2097628043U | num);
		66026065.28060A8C 094A0DCB = this.254C0263();
		num ^= 1037181201U;
		if (1202346723U * num != 0U)
		{
			do
			{
				66026065.28060A8C 28060A8C = this.254C0263();
				num >>= 8;
				66026065.28060A8C 51DC = 28060A8C;
				num ^= 65104467U;
				if ((1488847321U & num) == 0U)
				{
					break;
				}
				66026065.28060A8C 59F = this.4FA71865(51DC, 094A0DCB, num - 60919560U != 0U);
				num = (1434534154U ^ num);
				this.2A5A7C53(59F);
			}
			while (num <= 87445792U);
		}
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x002197E4 File Offset: 0x002197E4
	private void 3B97341D()
	{
		uint num;
		66026065.28060A8C 5815766B;
		66026065.28060A8C 2E04682D;
		do
		{
			num = 2074348257U;
			5815766B = this.254C0263();
			if (941425355U >> (int)num == 0U)
			{
				return;
			}
			num = (500629755U & num);
			66026065.28060A8C 28060A8C = this.254C0263();
			num = 853621421U + num;
			2E04682D = 28060A8C;
		}
		while (num >= 1494419861U);
		num /= 288248004U;
		num = (1559300654U & num);
		66026065.28060A8C 59F = this.60E804D7(2E04682D, 5815766B, (num ^ 4U) != 0U);
		num = (142214278U ^ num);
		this.2A5A7C53(59F);
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00219860 File Offset: 0x00219860
	private void 40CA5737()
	{
		uint num = 1006581707U;
		66026065.28060A8C 28060A8C = this.254C0263();
		66026065.28060A8C 28060A8C2 = this.254C0263();
		num &= 87566884U;
		66026065.28060A8C 28060A8C3 = 28060A8C2;
		num = 967922237U % num;
		num = 1237519888U * num;
		66026065.28060A8C 2E04682D = 28060A8C3;
		66026065.28060A8C 5815766B = 28060A8C;
		num &= 1777556242U;
		66026065.28060A8C 59F = this.60E804D7(2E04682D, 5815766B, num + 3208439537U != 0U);
		num &= 776358082U;
		this.2A5A7C53(59F);
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x002198C0 File Offset: 0x002198C0
	private void 40FE152F()
	{
		uint num = 439442616U;
		66026065.28060A8C 20A5775E = this.254C0263();
		num = (1239881657U & num);
		66026065.28060A8C 28060A8C = this.254C0263();
		num |= 927089216U;
		66026065.28060A8C 5D371C = 28060A8C;
		num = (534599319U & num);
		if (num % 1320965892U != 0U)
		{
			do
			{
				num = 734557365U * num;
				num >>= 19;
				66026065.28060A8C 59F = this.62206324(5D371C, 20A5775E);
				num /= 243427748U;
				this.2A5A7C53(59F);
			}
			while (num > 1487565230U);
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00219938 File Offset: 0x00219938
	private void 59FF2598()
	{
		uint num = 361181478U;
		for (;;)
		{
			num &= 340533340U;
			66026065.28060A8C 4EC36EFE = this.254C0263();
			66026065.28060A8C 28060A8C = this.254C0263();
			num -= 1107131189U;
			if (946805337U % num != 0U)
			{
				num = 1407504U << (int)num;
				66026065.28060A8C 18D947D = 28060A8C;
				num = 1455884535U << (int)num;
				66026065.28060A8C 59F = this.28AB10D0(18D947D, 4EC36EFE);
				num /= 1315077755U;
				this.2A5A7C53(59F);
				if (num != 1652891465U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060000EA RID: 234 RVA: 0x002199B4 File Offset: 0x002199B4
	private void 1A1D0650()
	{
		uint num;
		do
		{
			num = 787051398U;
			66026065.28060A8C 28060A8C = this.254C0263();
			num *= 890665831U;
			66026065.28060A8C 28060A8C2 = 28060A8C;
			num += 1654148344U;
			if (1441803901U == num)
			{
				break;
			}
			num >>= 26;
			66026065.28060A8C 28060A8C3 = this.254C0263();
			num >>= 29;
			66026065.28060A8C 28060A8C4 = 28060A8C3;
			num *= 981022910U;
			if (189556068U == num)
			{
				break;
			}
			66026065.28060A8C 65C75B = 28060A8C4;
			66026065.28060A8C 68C460AC = 28060A8C2;
			num = 532821591U - num;
			66026065.28060A8C 59F = this.2F957EEB(65C75B, 68C460AC);
			num >>= 31;
			this.2A5A7C53(59F);
		}
		while (1822574611U < num);
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00219A3C File Offset: 0x00219A3C
	private void 35681A3C()
	{
		uint num = 245516907U;
		if (894720625U < num)
		{
			goto IL_28;
		}
		IL_11:
		66026065.28060A8C 28060A8C = this.254C0263();
		num = (90843260U & num);
		66026065.28060A8C 041648AC = 28060A8C;
		num = (1061313712U ^ num);
		IL_28:
		num = 541263462U / num;
		66026065.28060A8C 59F = this.192E7B74(041648AC);
		num >>= 3;
		this.2A5A7C53(59F);
		if (801580569U * num == 0U)
		{
			return;
		}
		goto IL_11;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00219A9C File Offset: 0x00219A9C
	private void 6DDD234F()
	{
		66026065.28060A8C 28060A8C = this.254C0263();
		uint num = 540749564U;
		66026065.28060A8C 28060A8C2 = 28060A8C;
		num |= 17182007U;
		66026065.28060A8C 059C1B = 28060A8C2;
		num += 513805482U;
		66026065.28060A8C 59F = this.3F947D0C(059C1B);
		num |= 603420874U;
		this.2A5A7C53(59F);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00219ADC File Offset: 0x00219ADC
	private void 0DE6198B()
	{
		uint num = 806642241U;
		if (num != 1125019439U)
		{
			goto IL_11;
		}
		66026065.28060A8C 28060A8C2;
		do
		{
			IL_20:
			66026065.28060A8C 28060A8C = this.254C0263();
			num = 1354782270U * num;
			28060A8C2 = 28060A8C;
			num = 884606642U % num;
		}
		while (num > 1706442568U);
		num = (1097759529U ^ num);
		num *= 294010641U;
		66026065.28060A8C 6E420B = 28060A8C2;
		num = (2077250361U & num);
		66026065.28060A8C 28060A8C3;
		66026065.28060A8C 3CC = 28060A8C3;
		bool 080824A = num + 3623858167U != 0U;
		num = 1160986205U / num;
		66026065.28060A8C 59F = this.070E41F9(6E420B, 3CC, 080824A);
		num |= 1823159985U;
		this.2A5A7C53(59F);
		if (1151669645U + num != 0U)
		{
			return;
		}
		IL_11:
		66026065.28060A8C 28060A8C4 = this.254C0263();
		num = (340946977U & num);
		28060A8C3 = 28060A8C4;
		goto IL_20;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00219B74 File Offset: 0x00219B74
	private void 0FD22F07()
	{
		uint num = 1411861522U;
		66026065.28060A8C 28060A8C = this.254C0263();
		num >>= 29;
		do
		{
			num = 1811964896U - num;
			66026065.28060A8C 28060A8C2 = this.254C0263();
			num >>= 24;
			66026065.28060A8C 28060A8C3 = 28060A8C2;
			num -= 1800476335U;
			num *= 826359013U;
			66026065.28060A8C 6E420B = 28060A8C3;
			num = 1226866219U << (int)num;
			66026065.28060A8C 3CC = 28060A8C;
			bool 080824A = (num ^ 4233494529U) != 0U;
			num ^= 865032875U;
			66026065.28060A8C 59F = this.070E41F9(6E420B, 3CC, 080824A);
			num %= 1631983696U;
			this.2A5A7C53(59F);
		}
		while (num == 794847242U);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00219BFC File Offset: 0x00219BFC
	private void 223C114D()
	{
		uint num = 643127031U;
		num -= 493905227U;
		66026065.28060A8C 28060A8C = this.254C0263();
		num -= 198004631U;
		66026065.28060A8C 4B8B = 28060A8C;
		66026065.28060A8C 72AB27A = this.254C0263();
		num = (1116623094U | num);
		66026065.28060A8C 59F = this.65D41E1D(72AB27A, 4B8B);
		num = 2077184316U / num;
		this.2A5A7C53(59F);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00219C4C File Offset: 0x00219C4C
	private void 78783A8F()
	{
		uint num;
		Type type2;
		do
		{
			num = 1256468385U;
			num -= 1753491976U;
			int 0F8107B = this.254C0263().D02DFB88();
			num = 60431294U << (int)num;
			Type type = this.22C50466(0F8107B);
			num &= 1079136691U;
			type2 = type;
			num = 1235688695U - num;
		}
		while (617965651 << (int)num == 0);
		object 4C20265C = this.254C0263();
		Type 2A7B54D = type2;
		num <<= 13;
		this.2A5A7C53(this.64A3721C(4C20265C, 2A7B54D));
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00219CC4 File Offset: 0x00219CC4
	private void 0F757978()
	{
		uint num = 66004559U;
		Type type2;
		if (1181906448U >> (int)num != 0U)
		{
			66026065.28060A8C 28060A8C = this.254C0263();
			num -= 752031592U;
			Type type = this.22C50466(28060A8C.D02DFB88());
			num ^= 996087665U;
			type2 = type;
			num -= 1450077707U;
		}
		66026065.28060A8C 28060A8C2 = this.254C0263();
		num = (1133191615U | num);
		Type <<EMPTY_NAME>> = type2;
		num = 1780288558U - num;
		object 4C20265C = 28060A8C2.F7157180(<<EMPTY_NAME>>, num - 2453495919U != 0U);
		Type 2A7B54D = type2;
		num = 130643178U % num;
		this.2A5A7C53(this.64A3721C(4C20265C, 2A7B54D));
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00219D4C File Offset: 0x00219D4C
	private void 12BD4CB0()
	{
		uint num = 1670462434U;
		Type type = this.22C50466(this.254C0263().D02DFB88());
		do
		{
			num += 908658036U;
			num = 961031752U / num;
			num += 164968244U;
			66026065.28060A8C 28060A8C = this.254C0263();
			num *= 743445819U;
			66026065.28060A8C 59F = this.64A3721C(28060A8C.F7157180(type, (num ^ 4058709245U) != 0U), type);
			num = 1833251443U * num;
			this.2A5A7C53(59F);
		}
		while (num == 1566588593U);
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00219DC4 File Offset: 0x00219DC4
	private void 2A805746()
	{
		uint num = 1373855449U;
		if (num << 15 != 0U)
		{
			num >>= 9;
			num = (1199320838U ^ num);
			num *= 1616258865U;
			int 0F8107B = this.51984E22();
			num = 1612015233U * num;
			this.2A5A7C53(new 66026065.152602F0(Marshal.SizeOf(this.22C50466(0F8107B))));
		}
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00219E20 File Offset: 0x00219E20
	private unsafe void 02C01D9C()
	{
		uint num;
		for (;;)
		{
			66026065.28060A8C 28060A8C = this.254C0263();
			num = 1120559366U;
			Type type = this.22C50466(28060A8C.D02DFB88());
			num = (161699151U ^ num);
			if (1497694462U >= num)
			{
				goto IL_2B;
			}
			IL_42:
			66026065.28060A8C 28060A8C3;
			66026065.28060A8C 28060A8C2 = 28060A8C3;
			num %= 1699348521U;
			bool flag = 28060A8C2.55CDE352();
			num = 1637025064U << (int)num;
			if (!flag)
			{
				num = 790239617U >> (int)num;
				if (num - 312160379U == 0U)
				{
					goto IL_2B;
				}
				if (!(28060A8C3.6DCA9058() is Pointer))
				{
					break;
				}
				num = (454243291U ^ num);
				66026065.28060A8C 28060A8C4 = 28060A8C3;
				num = 1262948737U >> (int)num;
				object ptr = 28060A8C4.6DCA9058();
				num *= 1091970021U;
				void* value = Pointer.Unbox(ptr);
				num = 1201961506U + num;
				IntPtr 76C33B = new IntPtr(value);
				Type 4F5157E = type;
				num = 639766282U % num;
				28060A8C3 = new 66026065.6F802366(76C33B, 4F5157E);
				num ^= 716842570U;
			}
			num = 1504258392U / num;
			if (num - 1710909814U != 0U)
			{
				this.2A5A7C53(this.64A3721C(28060A8C3, type));
				if (num != 658667572U)
				{
					return;
				}
				continue;
			}
			IL_2B:
			66026065.28060A8C 28060A8C5 = this.254C0263();
			num = 196816986U - num;
			28060A8C3 = 28060A8C5;
			num = 257194692U + num;
			goto IL_42;
		}
		num = 260668151U / num;
		throw new ArgumentException();
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00219F48 File Offset: 0x00219F48
	private void 1D1E768B()
	{
		uint num;
		FieldInfo fieldInfo;
		do
		{
			num = 1656561208U;
			num = 149706144U - num;
			int 0EDE536C = this.254C0263().D02DFB88();
			num = 98720363U << (int)num;
			fieldInfo = this.4AE41C96(0EDE536C);
			num = 917664064U << (int)num;
		}
		while (num <= 622279711U);
		66026065.28060A8C 28060A8C = this.254C0263();
		num = 1549153395U % num;
		object obj = 28060A8C.6DCA9058();
		num %= 1083731145U;
		object obj2 = obj;
		for (;;)
		{
			FieldInfo fieldInfo2 = fieldInfo;
			num = 608723080U << (int)num;
			bool isStatic = fieldInfo2.IsStatic;
			num = 354956847U >> (int)num;
			if (!isStatic)
			{
				num <<= 18;
				bool flag = obj2 != null;
				num += 1013724719U;
				if (!flag)
				{
					break;
				}
			}
			if (num <= 1458056183U)
			{
				goto Block_3;
			}
		}
		throw new NullReferenceException();
		Block_3:
		num = 964846913U + num;
		object value = fieldInfo.GetValue(obj2);
		FieldInfo fieldInfo3 = fieldInfo;
		num /= 1537879634U;
		Type fieldType = fieldInfo3.FieldType;
		num %= 338578607U;
		66026065.28060A8C 59F = this.64A3721C(value, fieldType);
		num = (1457028301U ^ num);
		this.2A5A7C53(59F);
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x0021A040 File Offset: 0x0021A040
	private void 49D93ADC()
	{
		FieldInfo fieldInfo = this.4AE41C96(this.254C0263().D02DFB88());
		uint num = 401816640U;
		FieldInfo fieldInfo2 = fieldInfo;
		num >>= 9;
		66026065.28060A8C 28060A8C = this.254C0263();
		num = 585901322U / num;
		object obj = 28060A8C.6DCA9058();
		num = 1402102063U / num;
		for (;;)
		{
			if (!fieldInfo2.IsStatic)
			{
				num = 2089888856U * num;
				bool flag = obj != null;
				num <<= 2;
				num ^= 1093071653U;
				if (!flag)
				{
					num = 1459296401U + num;
					if (843984316U < num)
					{
						break;
					}
					continue;
				}
			}
			while (7085865U != num)
			{
				FieldInfo 07BC39E = fieldInfo2;
				object 2E = obj;
				num %= 491990833U;
				this.2A5A7C53(new 66026065.6AFE5B30(07BC39E, 2E));
				if (num < 11013362U)
				{
					return;
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0021A0F8 File Offset: 0x0021A0F8
	private void 49FE4D46()
	{
		for (;;)
		{
			IL_00:
			uint num = 1953114408U;
			66026065.28060A8C 28060A8C = this.254C0263();
			num /= 1336240169U;
			int 0EDE536C = 28060A8C.D02DFB88();
			num = 1289907017U % num;
			FieldInfo fieldInfo = this.4AE41C96(0EDE536C);
			num = 1707753868U + num;
			FieldInfo fieldInfo2 = fieldInfo;
			if (num - 1234263900U != 0U)
			{
				66026065.28060A8C 28060A8C2;
				object obj;
				for (;;)
				{
					num %= 829699107U;
					28060A8C2 = this.254C0263();
					if (num / 82929508U == 0U)
					{
						obj = this.254C0263().6DCA9058();
						num %= 1806980062U;
						if ((num ^ 2086435862U) == 0U)
						{
							goto IL_00;
						}
						bool isStatic = fieldInfo2.IsStatic;
						num &= 873351067U;
						if (isStatic)
						{
							goto IL_BD;
						}
						num *= 1293638962U;
						if (1696940987U != num)
						{
							break;
						}
					}
				}
				bool flag = obj != null;
				num += 1931465886U;
				if (!flag)
				{
					if (num << 6 != 0U)
					{
						break;
					}
					continue;
				}
				IL_BD:
				FieldInfo fieldInfo3 = fieldInfo2;
				num %= 135007247U;
				object obj2 = obj;
				object 4C20265C = 28060A8C2;
				FieldInfo fieldInfo4 = fieldInfo2;
				num -= 2009154478U;
				Type fieldType = fieldInfo4.FieldType;
				num = 1889080107U * num;
				66026065.28060A8C 28060A8C3 = this.64A3721C(4C20265C, fieldType);
				num <<= 10;
				object value = 28060A8C3.6DCA9058();
				num = 1263165170U % num;
				fieldInfo3.SetValue(obj2, value);
				if (num >= 854592622U)
				{
					return;
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0021A210 File Offset: 0x0021A210
	private void 6BD9278B()
	{
		uint num = 1025400927U;
		if (185206390U != num)
		{
			for (;;)
			{
				num <<= 7;
				FieldInfo fieldInfo = this.4AE41C96(this.254C0263().D02DFB88());
				num = 1939558225U - num;
				for (;;)
				{
					num *= 712653556U;
					66026065.28060A8C 28060A8C = this.254C0263();
					if (891516512U > num)
					{
						break;
					}
					FieldInfo fieldInfo2 = fieldInfo;
					object obj = null;
					num >>= 21;
					object 4C20265C = 28060A8C;
					FieldInfo fieldInfo3 = fieldInfo;
					num ^= 1111508207U;
					Type fieldType = fieldInfo3.FieldType;
					num = 55138899U % num;
					66026065.28060A8C 28060A8C2 = this.64A3721C(4C20265C, fieldType);
					num *= 1685601497U;
					fieldInfo2.SetValue(obj, 28060A8C2.6DCA9058());
					if ((560085031U & num) != 0U)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x0021A2B0 File Offset: 0x0021A2B0
	private unsafe void 3C253D76()
	{
		uint num;
		Type type;
		66026065.28060A8C 28060A8C;
		66026065.28060A8C 28060A8C2;
		for (;;)
		{
			num = 1130432609U;
			num = 921573393U % num;
			int 0F8107B = this.254C0263().D02DFB88();
			num = 609361232U - num;
			type = this.22C50466(0F8107B);
			num = 606297940U % num;
			for (;;)
			{
				28060A8C = this.254C0263();
				if (1420254128U >> (int)num == 0U)
				{
					break;
				}
				num -= 1017385093U;
				28060A8C2 = this.254C0263();
				num |= 1339303139U;
				if (!28060A8C2.55CDE352())
				{
					object obj = 28060A8C2.6DCA9058();
					num = 788166377U << (int)num;
					if (!(obj is Pointer))
					{
						goto IL_E9;
					}
					num *= 1714690324U;
					if (num * 1993369593U == 0U)
					{
						break;
					}
					66026065.28060A8C 28060A8C3 = 28060A8C2;
					num >>= 26;
					void* value = Pointer.Unbox(28060A8C3.6DCA9058());
					num /= 45882197U;
					IntPtr 76C33B = new IntPtr(value);
					num %= 1026164237U;
					Type 4F5157E = type;
					num <<= 25;
					66026065.28060A8C 28060A8C4 = new 66026065.6F802366(76C33B, 4F5157E);
					num |= 550110304U;
					28060A8C2 = 28060A8C4;
					num ^= 3476384399U;
				}
				num = (1715422405U ^ num);
				if (1672890886U != num)
				{
					goto Block_4;
				}
			}
		}
		IL_E9:
		throw new ArgumentException();
		Block_4:
		66026065.28060A8C 28060A8C5 = 28060A8C2;
		object 4C20265C = 28060A8C;
		num /= 473780429U;
		Type 2A7B54D = type;
		num = 2000631395U * num;
		66026065.28060A8C 28060A8C6 = this.64A3721C(4C20265C, 2A7B54D);
		num >>= 10;
		28060A8C5.5F352F29(28060A8C6.6DCA9058());
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0021A3EC File Offset: 0x0021A3EC
	private void 79934CC2()
	{
		uint num = 62325803U;
		if (num < 1750561656U)
		{
			do
			{
				num = 169873064U << (int)num;
				List<66026065.28060A8C> list = this.56F9446E;
				num *= 1121791289U;
				66026065.28060A8C 28060A8C = list[(int)((ushort)this.1FC8038B())];
				num *= 757483526U;
				this.2A5A7C53(28060A8C.1368930D());
			}
			while (num + 1744503427U == 0U);
		}
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0021A454 File Offset: 0x0021A454
	private void 2594292F()
	{
		uint num;
		do
		{
			num = 1230847575U;
			List<66026065.28060A8C> list = this.56F9446E;
			num /= 67437026U;
			ushort num2 = (ushort)this.1FC8038B();
			num = 1403351789U * num;
			int index = (int)num2;
			num = 5785228U + num;
			66026065.28060A8C 188635D = list[index];
			num = 987051570U - num;
			this.2A5A7C53(new 66026065.1348406A(188635D));
		}
		while (num == 1409744990U);
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0021A4B0 File Offset: 0x0021A4B0
	private void 249B4E53()
	{
		uint num;
		do
		{
			66026065.28060A8C 28060A8C = this.254C0263();
			List<66026065.28060A8C> list = this.56F9446E;
			int index = (int)((ushort)this.1FC8038B());
			num = 1122581927U;
			66026065.28060A8C 28060A8C2 = list[index];
			num -= 1610623366U;
			66026065.28060A8C 28060A8C3 = 28060A8C2;
			num = 1911045021U - num;
			66026065.28060A8C 28060A8C4 = 28060A8C3;
			num %= 1533757881U;
			object 4C20265C = 28060A8C;
			num += 155284681U;
			66026065.28060A8C 28060A8C5 = 28060A8C3;
			num ^= 1187345689U;
			Type 2A7B54D = 28060A8C5.36A9B5E8();
			num /= 1597249486U;
			66026065.28060A8C 28060A8C6 = this.64A3721C(4C20265C, 2A7B54D);
			num = 646601586U - num;
			28060A8C4.5F352F29(28060A8C6.6DCA9058());
		}
		while (num >= 1364008791U);
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0021A538 File Offset: 0x0021A538
	private void 31250CEC()
	{
		uint num = 848768862U;
		num = (1633241553U | num);
		num = 138166537U - num;
		int 0F8107B = this.254C0263().D02DFB88();
		num = 467422311U % num;
		this.343C5B08 = this.22C50466(0F8107B);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0021A57C File Offset: 0x0021A57C
	private void 404D17BA()
	{
		uint num = 1379476563U;
		for (;;)
		{
			num = 1061967209U / num;
			num %= 121506429U;
			int 37DF7CC = this.254C0263().D02DFB88();
			num = (1951794577U & num);
			MethodBase methodBase = this.0E5643BA(37DF7CC);
			num = 1706834467U - num;
			MethodBase methodBase2 = methodBase;
			if (num > 487998035U)
			{
				66026065.28060A8C 28060A8C2;
				for (;;)
				{
					num = (380379763U | num);
					MethodBase 5DEF5E6B = methodBase2;
					bool 3EBC542F = num + 2286142861U != 0U;
					num = (467485119U | num);
					66026065.28060A8C 28060A8C = this.4427197E(5DEF5E6B, 3EBC542F);
					num = 1318263932U << (int)num;
					28060A8C2 = 28060A8C;
					num &= 1460946378U;
					if (83187511U == num)
					{
						goto IL_9C;
					}
					bool flag = 28060A8C2 != null;
					num = (921836978U ^ num);
					if (!flag)
					{
						break;
					}
					if (num >= 5137910U)
					{
						goto IL_9C;
					}
				}
				IL_BB:
				if ((535181845U ^ num) != 0U)
				{
					break;
				}
				continue;
				IL_9C:
				num &= 1169976768U;
				66026065.28060A8C 59F = 28060A8C2;
				num &= 310706988U;
				this.2A5A7C53(59F);
				num ^= 913448114U;
				goto IL_BB;
			}
		}
	}

	// Token: 0x060000FF RID: 255 RVA: 0x0021A650 File Offset: 0x0021A650
	private void 2BB71427()
	{
		for (;;)
		{
			IL_00:
			uint num = 1294156512U;
			num <<= 10;
			66026065.28060A8C 28060A8C = this.254C0263();
			num ^= 1906189253U;
			MethodBase methodBase = this.0E5643BA(28060A8C.D02DFB88());
			num &= 424636240U;
			MethodBase methodBase2 = methodBase;
			num = 2049121325U / num;
			for (;;)
			{
				num = 1157198948U * num;
				bool flag = this.343C5B08 != null;
				num >>= 3;
				if (flag)
				{
					Type[] array;
					for (;;)
					{
						ParameterInfo[] parameters = methodBase2.GetParameters();
						num = (555825148U | num);
						int num2 = parameters.Length;
						num = 1347296057U + num;
						array = new Type[num2];
						int num3 = (int)(num - 2072648503U);
						num -= 1724464292U;
						int num4 = num3;
						ParameterInfo[] array2 = parameters;
						int num5 = (int)(num - 348184211U);
						if (num + 141643896U == 0U)
						{
							goto IL_00;
						}
						for (;;)
						{
							num *= 633423428U;
							int num6 = num5;
							num = (854401717U & num);
							ParameterInfo[] array3 = array2;
							num >>= 25;
							int num7 = array3.Length;
							num = 337516822U - num;
							if (num6 >= num7)
							{
								goto Block_3;
							}
							ParameterInfo[] array4 = array2;
							num = 1914636956U;
							int num8 = num5;
							num = 1250698055U % num;
							ParameterInfo parameterInfo = array4[num8];
							num = (86383036U ^ num);
							ParameterInfo parameterInfo2 = parameterInfo;
							num <<= 17;
							if (288047170 << (int)num == 0)
							{
								goto IL_00;
							}
							Type[] array5 = array;
							int num9 = num4;
							num += 400636117U;
							num += 399732097U;
							num4 = num9 + (int)(num ^ 2779424343U);
							Type parameterType = parameterInfo2.ParameterType;
							num *= 775370638U;
							array5[num9] = parameterType;
							if (551166328U > num)
							{
								break;
							}
							num5 += (int)(num + 1092698701U);
							num += 1440882911U;
						}
					}
					Block_3:
					if (2135166792U == num)
					{
						break;
					}
					Type type = this.343C5B08;
					num >>= 22;
					string name = methodBase2.Name;
					num = 1549741924U + num;
					BindingFlags bindingAttr = (int)num + (BindingFlags)(-1549729408);
					num |= 2066165513U;
					Binder binder = null;
					num = 74543085U / num;
					Type[] types = array;
					ParameterModifier[] modifiers = null;
					num = (1113019013U | num);
					MethodInfo method = type.GetMethod(name, bindingAttr, binder, types, modifiers);
					num *= 1402481122U;
					MethodInfo methodInfo = method;
					num %= 381964371U;
					bool flag2 = methodInfo != null;
					num <<= 26;
					if (flag2)
					{
						MethodBase methodBase3 = methodInfo;
						num += 968624122U;
						methodBase2 = methodBase3;
						num ^= 1505495034U;
					}
					num = 79188207U % num;
					Type type2 = null;
					num = 774272037U - num;
					this.343C5B08 = type2;
					num ^= 578145160U;
				}
				MethodBase 5DEF5E6B = methodBase2;
				num &= 125640346U;
				66026065.28060A8C 28060A8C2 = this.4427197E(5DEF5E6B, num - 51972249U != 0U);
				if (1334268616U + num == 0U)
				{
					break;
				}
				bool flag3 = 28060A8C2 != null;
				num = (1412759984U | num);
				if (flag3)
				{
					num /= 516783075U;
					if (735854410U >> (int)num == 0U)
					{
						continue;
					}
					num += 680603404U;
					66026065.28060A8C 59F = 28060A8C2;
					num += 175339898U;
					this.2A5A7C53(59F);
					num ^= 1681498418U;
				}
				if (511336430U <= num)
				{
					return;
				}
			}
		}
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0021A91C File Offset: 0x0021A91C
	private void 54113550()
	{
		uint num;
		for (;;)
		{
			object obj = this.254C0263().6DCA9058();
			num = 1477794709U;
			MethodBase methodBase = obj as MethodBase;
			if (1882810601U / num != 0U)
			{
				if (methodBase != null)
				{
					goto IL_42;
				}
				num &= 518613552U;
				if (1530480293U >= num)
				{
					break;
				}
			}
		}
		IL_3C:
		throw new ArgumentException();
		IL_42:
		num = 2135172509U >> (int)num;
		if (num < 192547527U)
		{
			MethodBase methodBase;
			MethodBase 5DEF5E6B = methodBase;
			num = 2129346984U + num;
			66026065.28060A8C 28060A8C = this.4427197E(5DEF5E6B, num + 2165619294U != 0U);
			num -= 1715672580U;
			66026065.28060A8C 28060A8C2 = 28060A8C;
			num = 1034832325U % num;
			bool flag = 28060A8C2 != null;
			num = 2107852796U * num;
			if (flag)
			{
				num ^= 2120812631U;
				if (num - 1121914076U == 0U)
				{
					goto IL_3C;
				}
				this.2A5A7C53(28060A8C2);
				num += 1709770833U;
			}
			return;
		}
		goto IL_3C;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x0021A9DC File Offset: 0x0021A9DC
	private void 488A5C27()
	{
		uint num = 2132955967U;
		66026065.28060A8C 28060A8C2;
		if (1374695158U != num)
		{
			num = (784628426U | num);
			int 1D925D = this.254C0263().D02DFB88();
			bool 5E6E1C7E = (num ^ 2145811455U) != 0U;
			num <<= 24;
			66026065.28060A8C 28060A8C = this.687359D7(1D925D, 5E6E1C7E);
			num /= 1384129874U;
			28060A8C2 = 28060A8C;
		}
		if (28060A8C2 != null)
		{
			66026065.28060A8C 59F = 28060A8C2;
			num ^= 749174561U;
			this.2A5A7C53(59F);
			num += 3545792737U;
		}
	}

	// Token: 0x06000102 RID: 258 RVA: 0x0021AA48 File Offset: 0x0021AA48
	private void 22DE4DC2()
	{
		uint num;
		do
		{
			num = 383674698U;
			66026065.28060A8C 28060A8C = this.254C0263();
			num -= 1251238871U;
			int 1D925D = 28060A8C.D02DFB88();
			bool 5E6E1C7E = (num ^ 3427403122U) != 0U;
			num = (1516524151U & num);
			66026065.28060A8C 28060A8C2 = this.687359D7(1D925D, 5E6E1C7E);
			num %= 1343757570U;
			if (445254174U != num)
			{
				bool flag = 28060A8C2 != null;
				num = 10559924U * num;
				if (flag)
				{
					num = 1885609576U << (int)num;
					if (num == 1245851821U)
					{
						continue;
					}
					num = 1408630876U + num;
					66026065.28060A8C 59F = 28060A8C2;
					num = (1618422892U ^ num);
					this.2A5A7C53(59F);
					num ^= 3873640428U;
				}
			}
		}
		while (num == 1105687205U);
	}

	// Token: 0x06000103 RID: 259 RVA: 0x0021AAE8 File Offset: 0x0021AAE8
	private void 04EC591A()
	{
		uint num = 526062112U;
		if (689584340U % num == 0U)
		{
			goto IL_76;
		}
		MethodBase methodBase2;
		do
		{
			num <<= 7;
			66026065.28060A8C 28060A8C = this.254C0263();
			num = 1742944720U + num;
			MethodBase methodBase = this.0E5643BA(28060A8C.D02DFB88());
			num -= 1271362280U;
			methodBase2 = methodBase;
			num += 1947206028U;
		}
		while (num << 0 == 0U);
		IL_50:
		MethodBase 7D941E = methodBase2;
		num ^= 61684178U;
		66026065.28060A8C 28060A8C2 = this.1A630F05(7D941E);
		num = 1058151679U << (int)num;
		66026065.28060A8C 28060A8C3 = 28060A8C2;
		num = 998127241U - num;
		IL_76:
		bool flag = 28060A8C3 != null;
		num = 284654304U << (int)num;
		if (flag)
		{
			if (1844196229U * num == 0U)
			{
				goto IL_50;
			}
			this.2A5A7C53(28060A8C3);
			num += 0U;
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0021AB9C File Offset: 0x0021AB9C
	private void 4BFD4FC2()
	{
		uint num;
		66026065.28060A8C 28060A8C3;
		for (;;)
		{
			IL_00:
			num = 590114336U;
			num += 1449087551U;
			66026065.28060A8C 28060A8C = this.254C0263();
			num = 802226463U / num;
			int 0F8107B = 28060A8C.D02DFB88();
			num -= 1687778965U;
			Type type = this.22C50466(0F8107B);
			for (;;)
			{
				66026065.28060A8C 28060A8C2 = this.254C0263();
				num = 1252539707U + num;
				28060A8C3 = 28060A8C2;
				if (1021258935U >= num)
				{
					return;
				}
				bool isGenericType = type.IsGenericType;
				num = 604776732U << (int)num;
				if (!isGenericType)
				{
					goto IL_AE;
				}
				Type type2 = type;
				num = 1917529766U / num;
				Type genericTypeDefinition = type2.GetGenericTypeDefinition();
				num >>= 19;
				RuntimeTypeHandle handle = typeof(Nullable<>).TypeHandle;
				num = (212869229U & num);
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num += 51005184U;
				if (genericTypeDefinition != typeFromHandle)
				{
					goto IL_AE;
				}
				IL_99:
				28060A8C3.5F352F29(null);
				if ((1265925064U & num) != 0U)
				{
					return;
				}
				continue;
				IL_AE:
				num = (1436383912U & num);
				bool isValueType = type.IsValueType;
				num = (276694247U | num);
				if (!isValueType)
				{
					goto IL_1E5;
				}
				if ((num ^ 1215508375U) == 0U)
				{
					goto IL_99;
				}
				Type type3 = type;
				num >>= 14;
				FieldInfo[] fields = type3.GetFields((int)num + (BindingFlags)(-17797));
				int num2 = (int)(num - 17913U);
				num += 1781072057U;
				int num3 = num2;
				for (;;)
				{
					num -= 1827434769U;
					if (num3 >= fields.Length)
					{
						goto Block_8;
					}
					num = 48723292U;
					if ((1270546791U & num) == 0U)
					{
						goto IL_00;
					}
					FieldInfo[] array = fields;
					int num4 = num3;
					num *= 1735143863U;
					FieldInfo fieldInfo = array[num4];
					num |= 1792809721U;
					if (num == 1351110467U)
					{
						break;
					}
					FieldInfo fieldInfo2 = fieldInfo;
					object obj = 28060A8C3.6DCA9058();
					FieldInfo fieldInfo3 = fieldInfo;
					num = 868367498U - num;
					bool isValueType2 = fieldInfo3.FieldType.IsValueType;
					num = 831336422U % num;
					object value;
					if (!isValueType2)
					{
						num |= 1783189895U;
						value = null;
					}
					else
					{
						num = 1496975717U / num;
						FieldInfo fieldInfo4 = fieldInfo;
						num <<= 6;
						value = Activator.CreateInstance(fieldInfo4.FieldType);
						num += 2077065127U;
					}
					num = (768046510U ^ num);
					fieldInfo2.SetValue(obj, value);
					num = (1787176656U & num);
					if (1385526960U < num)
					{
						goto IL_99;
					}
					int num5 = num3;
					num += 1035697580U;
					num3 = num5 + (int)(num + 2151841813U);
					num ^= 362035550U;
				}
			}
			Block_8:
			if (num > 1222787092U)
			{
				return;
			}
			continue;
			IL_1E5:
			num = 1628650283U + num;
			if ((1251956699U & num) != 0U)
			{
				goto Block_10;
			}
		}
		return;
		Block_10:
		66026065.28060A8C 28060A8C4 = 28060A8C3;
		object 35C42CED = null;
		num &= 797445481U;
		28060A8C4.5F352F29(35C42CED);
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0021ADB4 File Offset: 0x0021ADB4
	private void 6F161163()
	{
		for (;;)
		{
			uint num = 268896338U;
			int 374777DD = this.254C0263().D02DFB88();
			num -= 1763520477U;
			if (747138693U % num != 0U)
			{
				66026065.28060A8C 44A41FA = this.254C0263();
				num &= 953811660U;
				66026065.28060A8C 0E485D = this.254C0263();
				this.2A5A7C53(new 66026065.152602F0(this.0AAF37FE(0E485D, 44A41FA, num - 549978180U != 0U, 374777DD)));
				if (num <= 1446860711U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0021AE24 File Offset: 0x0021AE24
	private void 691027FC()
	{
		66026065.28060A8C 28060A8C = this.254C0263();
		uint num = 2031315875U;
		int num2 = 28060A8C.D02DFB88();
		num = (392958907U & num);
		if (978198302U >> (int)num == 0U)
		{
			goto IL_74;
		}
		66026065.28060A8C 28060A8C3;
		66026065.28060A8C 28060A8C4;
		for (;;)
		{
			IL_2C:
			66026065.28060A8C 28060A8C2 = this.254C0263();
			num = (19671051U | num);
			28060A8C3 = 28060A8C2;
			num = 388053269U >> (int)num;
			if (num != 624820663U)
			{
				num = 1100293129U >> (int)num;
				28060A8C4 = this.254C0263();
				if (num != 1702245378U)
				{
					break;
				}
			}
		}
		IL_74:
		num = (681068489U | num);
		66026065.28060A8C 0E485D = 28060A8C4;
		num %= 1059522641U;
		66026065.28060A8C 44A41FA = 28060A8C3;
		bool 70D15AEC = (num ^ 681275336U) != 0U;
		num = 2143296546U % num;
		int 374777DD = num2;
		num |= 520955130U;
		66026065.28060A8C 59F = new 66026065.152602F0(this.0AAF37FE(0E485D, 44A41FA, 70D15AEC, 374777DD));
		num -= 274623349U;
		this.2A5A7C53(59F);
		if (2092845140U > num)
		{
			return;
		}
		goto IL_2C;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0021AEF4 File Offset: 0x0021AEF4
	private void 54512335()
	{
		uint num = 537868471U;
		if (num != 598438374U)
		{
			num = 1833455426U >> (int)num;
			int 0F8107B = this.254C0263().D02DFB88();
			num = (509290257U | num);
			Type type = this.22C50466(0F8107B);
			num ^= 1522413746U;
			num = (1896364297U & num);
			Type elementType = type;
			num /= 669205760U;
			66026065.28060A8C 28060A8C = this.254C0263();
			num = 53174647U / num;
			int length = 28060A8C.D02DFB88();
			num = (1642403866U & num);
			Array 100B = Array.CreateInstance(elementType, length);
			num = 629366710U + num;
			66026065.28060A8C 59F = new 66026065.2BBE3DF2(100B);
			num ^= 1708473177U;
			this.2A5A7C53(59F);
		}
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0021AF90 File Offset: 0x0021AF90
	private void 4D52134C()
	{
		uint num;
		Type 2A7B54D;
		do
		{
			int 0F8107B = this.254C0263().D02DFB88();
			num = 1878142433U;
			2A7B54D = this.22C50466(0F8107B);
		}
		while (num == 1099113770U);
		66026065.28060A8C 28060A8C;
		66026065.28060A8C 28060A8C3;
		Array array;
		do
		{
			28060A8C = this.254C0263();
			num /= 137132739U;
			if (num >= 405086561U)
			{
				goto IL_9A;
			}
			num = 1852322984U >> (int)num;
			66026065.28060A8C 28060A8C2 = this.254C0263();
			num = 1671646283U << (int)num;
			28060A8C3 = 28060A8C2;
			num -= 1212693444U;
			array = (this.254C0263().6DCA9058() as Array);
		}
		while (1624720325U >= num);
		if (array == null)
		{
			num = (1121979177U ^ num);
			throw new ArgumentException();
		}
		IL_9A:
		Array array2 = array;
		object 4C20265C = 28060A8C;
		num -= 641949386U;
		object 4C20265C2 = this.64A3721C(4C20265C, 2A7B54D);
		Type elementType = array.GetType().GetElementType();
		num = (1488218941U & num);
		66026065.28060A8C 28060A8C4 = this.64A3721C(4C20265C2, elementType);
		num %= 830234861U;
		object value = 28060A8C4.6DCA9058();
		num /= 1326911368U;
		66026065.28060A8C 28060A8C5 = 28060A8C3;
		num = 1780101069U - num;
		int index = 28060A8C5.D02DFB88();
		num %= 1927439145U;
		array2.SetValue(value, index);
	}

	// Token: 0x06000109 RID: 265 RVA: 0x0021B094 File Offset: 0x0021B094
	private void 1A5D4861()
	{
		uint num = 1947824408U;
		if (754679666U > num)
		{
			goto IL_62;
		}
		IL_11:
		num = 922488523U << (int)num;
		num += 2049459735U;
		66026065.28060A8C 28060A8C = this.254C0263();
		num &= 671158301U;
		int 0F8107B = 28060A8C.D02DFB88();
		num = 617553548U >> (int)num;
		Type type = this.22C50466(0F8107B);
		num -= 1358511785U;
		Type type2 = type;
		if (num <= 1942894567U)
		{
			goto IL_92;
		}
		IL_62:
		66026065.28060A8C 28060A8C2 = this.254C0263();
		num ^= 35812138U;
		66026065.28060A8C 28060A8C3 = this.254C0263();
		num = (1172177905U ^ num);
		object obj = 28060A8C3.6DCA9058();
		num /= 114829955U;
		Array array = obj as Array;
		IL_92:
		if (array == null)
		{
			throw new ArgumentException();
		}
		num = 199448716U - num;
		if ((num & 1808539845U) == 0U)
		{
			goto IL_11;
		}
		Array array2 = array;
		num = 582972397U >> (int)num;
		66026065.28060A8C 28060A8C4 = 28060A8C2;
		num ^= 678199235U;
		int index = 28060A8C4.D02DFB88();
		num = (1134853661U & num);
		object value = array2.GetValue(index);
		num = 207823238U << (int)num;
		Type 2A7B54D = type2;
		num *= 673842172U;
		this.2A5A7C53(this.64A3721C(value, 2A7B54D));
		if (num < 925504848U)
		{
			return;
		}
		goto IL_11;
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0021B1AC File Offset: 0x0021B1AC
	private void 4A20612E()
	{
		uint num = 38429225U;
		for (;;)
		{
			66026065.28060A8C 28060A8C = this.254C0263();
			num >>= 30;
			object obj = 28060A8C.6DCA9058();
			num %= 1487696167U;
			Array array = obj as Array;
			num = (1593989988U ^ num);
			Array array2 = array;
			if (array2 == null)
			{
				break;
			}
			num = (404901914U | num);
			this.2A5A7C53(new 66026065.152602F0(array2.Length));
			if (num < 2123921722U)
			{
				return;
			}
		}
		num ^= 463678633U;
		throw new ArgumentException();
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0021B220 File Offset: 0x0021B220
	private void 48124C6C()
	{
		for (;;)
		{
			uint num = 843212771U;
			66026065.28060A8C 28060A8C = this.254C0263();
			num = (1370173707U | num);
			66026065.28060A8C 28060A8C2 = 28060A8C;
			num = 142504231U % num;
			Array array = this.254C0263().6DCA9058() as Array;
			num /= 1430021246U;
			Array array2 = array;
			if ((1310805020U ^ num) == 0U)
			{
				break;
			}
			for (;;)
			{
				bool flag = array2 != null;
				num >>= 17;
				if (!flag)
				{
					goto IL_50;
				}
				num ^= 2124635097U;
				if ((776488743U ^ num) == 0U)
				{
					break;
				}
				num -= 1175350070U;
				Array 20A714D = array2;
				int 7F4648B = 28060A8C2.D02DFB88();
				num &= 1442976809U;
				this.2A5A7C53(new 66026065.739E46E3(20A714D, 7F4648B));
				if (num >= 243413456U)
				{
					return;
				}
			}
		}
		IL_50:
		throw new ArgumentException();
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0021B2C4 File Offset: 0x0021B2C4
	private void 1CB93A76()
	{
		uint num = 246763339U;
		num = 2063278214U / num;
		66026065.28060A8C 59F = new 66026065.78DF15B2(this.0E5643BA(this.254C0263().D02DFB88()));
		num = 1293247127U % num;
		this.2A5A7C53(59F);
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0021B304 File Offset: 0x0021B304
	private void 014828E5()
	{
		uint num = 908094274U;
		MethodBase methodBase;
		for (;;)
		{
			IL_06:
			int 37DF7CC = this.254C0263().D02DFB88();
			num = 1665821328U >> (int)num;
			methodBase = this.0E5643BA(37DF7CC);
			if (1579578757U >> (int)num != 0U)
			{
				for (;;)
				{
					IL_38:
					object obj = this.254C0263().6DCA9058();
					num *= 1025314446U;
					Type type = obj.GetType();
					num &= 1449359299U;
					Type type2 = type;
					Type declaringType;
					Type[] array2;
					int num2;
					ParameterInfo[] array3;
					int num4;
					do
					{
						declaringType = methodBase.DeclaringType;
						num = (2089970798U & num);
						if ((1063021009U ^ num) == 0U)
						{
							goto IL_38;
						}
						MethodBase methodBase2 = methodBase;
						num = 994458624U >> (int)num;
						ParameterInfo[] parameters = methodBase2.GetParameters();
						num = 654393396U * num;
						Type[] array = new Type[parameters.Length];
						num |= 1651321365U;
						array2 = array;
						num = 1147748781U << (int)num;
						num2 = (int)(num ^ 899678208U);
						num += 1140937674U;
						array3 = parameters;
						num = (1943800898U & num);
						int num3 = (int)(num + 2390753214U);
						num = 1925019005U / num;
						num4 = num3;
					}
					while (num > 1716994527U);
					for (;;)
					{
						num *= 1910970878U;
						int num5 = num4;
						num = 1721243130U << (int)num;
						ParameterInfo[] array4 = array3;
						num &= 270028362U;
						if (num5 >= array4.Length)
						{
							break;
						}
						ParameterInfo[] array5 = array3;
						num = 190472461U;
						ParameterInfo parameterInfo = array5[num4];
						num |= 528566580U;
						Type[] array6 = array2;
						int num6 = num2;
						num = 310136135U / num;
						int num7 = (int)(num + 1U);
						num >>= 12;
						int num8 = num6 + num7;
						num = (640876747U | num);
						num2 = num8;
						Type parameterType = parameterInfo.ParameterType;
						num >>= 18;
						array6[num6] = parameterType;
						int num9 = num4;
						int num10 = (int)(num ^ 2445U);
						num = 1863267655U / num;
						num4 = num9 + num10;
						num ^= 762385U;
					}
					MethodInfo methodInfo;
					for (;;)
					{
						num = 1715295164U << (int)num;
						bool flag = type2 != null;
						num %= 355804090U;
						num ^= 2539150281U;
						if (!flag)
						{
							goto IL_272;
						}
						if (891629980U > num)
						{
							goto IL_38;
						}
						if (type2 == declaringType)
						{
							goto Block_12;
						}
						Type type3 = type2;
						string name = methodBase.Name;
						BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding;
						num = 1759987598U;
						Binder binder = null;
						CallingConventions callConvention = (int)num + (CallingConventions)(-1759987595);
						num = 2022122566U << (int)num;
						MethodInfo method = type3.GetMethod(name, bindingAttr, binder, callConvention, array2, null);
						num = 1329733405U - num;
						methodInfo = method;
						if (499127787U >= num)
						{
							goto IL_38;
						}
						if (methodInfo != null)
						{
							if (99830090U >= num)
							{
								goto IL_06;
							}
							MethodInfo methodInfo2 = methodInfo;
							num |= 1222054949U;
							MethodInfo baseDefinition = methodInfo2.GetBaseDefinition();
							MethodBase methodBase3 = methodBase;
							num ^= 1221001248U;
							if (baseDefinition == methodBase3)
							{
								break;
							}
						}
						num = 1766217281U >> (int)num;
						type2 = type2.BaseType;
						num += 4294967293U;
					}
					if (num < 693568976U)
					{
						break;
					}
					methodBase = methodInfo;
					if (num != 1848060796U)
					{
						goto Block_9;
					}
				}
			}
		}
		Block_9:
		goto IL_272;
		Block_12:
		num += 0U;
		IL_272:
		MethodBase <<EMPTY_NAME>> = methodBase;
		num >>= 21;
		66026065.28060A8C 59F = new 66026065.78DF15B2(<<EMPTY_NAME>>);
		num = 1029001100U - num;
		this.2A5A7C53(59F);
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0021B5A0 File Offset: 0x0021B5A0
	private void 69424041()
	{
		this.7F97109A = this.254C0263().D02DFB88();
	}

	// Token: 0x0600010F RID: 271 RVA: 0x0021B5C4 File Offset: 0x0021B5C4
	private void 79F53BF5()
	{
		uint num = 1548970368U;
		if (num > 852450009U)
		{
			do
			{
				this.254C0263();
			}
			while (1578580719U + num == 0U);
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0021B5F8 File Offset: 0x0021B5F8
	private void 670D172B()
	{
		uint num = 1566731895U;
		for (;;)
		{
			IL_06:
			num += 1047810975U;
			Stack<int> stack = this.090E383D;
			num = (1218782039U & num);
			num = 1337481388U >> (int)num;
			66026065.28060A8C 28060A8C = this.254C0263();
			num *= 1913612026U;
			int item = 28060A8C.D02DFB88();
			num = (1471100079U & num);
			stack.Push(item);
			num = 1019444175U / num;
			for (;;)
			{
				num /= 202865265U;
				int num2 = this.254C0263().D02DFB88();
				num += 648570337U;
				int num3 = num2;
				if (num >= 670249628U)
				{
					goto IL_B0;
				}
				IL_16C:
				num ^= 107833791U;
				if ((num ^ 1834052279U) == 0U)
				{
					continue;
				}
				Stack<66026065.4AB007C7> stack2 = this.0E7C79AF;
				num *= 267155543U;
				bool count = stack2.Count != 0;
				num -= 1746949331U;
				List<66026065.608572C1> list;
				if (count)
				{
					if (1012736211U < num)
					{
						continue;
					}
					int num4 = num3;
					66026065.4AB007C7 4AB007C = this.0E7C79AF.Peek();
					num = 785921524U >> (int)num;
					if (num4 <= 4AB007C.13F7030A())
					{
						num += 21688095U;
					}
					else
					{
						num = 879584403U;
						Stack<66026065.4AB007C7> stack3 = this.0E7C79AF;
						num ^= 612118102U;
						list = stack3.Pop().24E26117();
						if (930808331U != num)
						{
							goto IL_A8;
						}
						continue;
					}
				}
				num = 955260302U % num;
				num = 1962744494U << (int)num;
				Exception ex = null;
				num = (237584323U | num);
				this.62390F5C = ex;
				num += 2108516772U;
				if (num / 1317894942U != 0U)
				{
					continue;
				}
				num = 82400289U + num;
				this.307C15CA.Clear();
				if (num / 850857770U == 0U)
				{
					goto IL_79;
				}
				num = (55275990U & num);
				this.7F97109A = this.090E383D.Pop();
				if ((num ^ 1096640804U) != 0U)
				{
					return;
				}
				IL_A8:
				int num5 = list.Count;
				IL_B0:
				for (;;)
				{
					num <<= 24;
					int num6 = num5;
					num >>= 1;
					uint num7 = num ^ 1652555776U;
					num = 2091460821U % num;
					if (num6 <= num7)
					{
						break;
					}
					List<66026065.608572C1> list2 = list;
					num = 1747284629U;
					int num8 = num5;
					num *= 369118755U;
					int num9 = (int)(num ^ 1946685534U);
					num &= 1914841522U;
					66026065.608572C1 608572C = list2[num8 - num9];
					num = (1398828404U & num);
					byte b = 608572C.00381BFD();
					uint num10 = num ^ 1342177298U;
					num >>= 20;
					if (b == num10)
					{
						Stack<int> stack4 = this.090E383D;
						66026065.608572C1 608572C2 = 608572C;
						num |= 2017283479U;
						stack4.Push(608572C2.0A1E119D());
						num ^= 2017282199U;
					}
					if (1258714759U == num)
					{
						goto IL_06;
					}
					num5 -= (int)(num ^ 1281U);
					num += 269567429U;
				}
				num += 209665292U;
				IL_79:
				goto IL_16C;
			}
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0021B85C File Offset: 0x0021B85C
	private void 24954D38()
	{
		bool flag = this.62390F5C != null;
		uint num = 1421698602U;
		if (!flag)
		{
			num *= 265124896U;
		}
		else if (758464088U != num)
		{
			num = 632116659U + num;
			this.77080C9E(this.62390F5C);
			return;
		}
		num *= 1120822266U;
		num *= 172695126U;
		Stack<int> stack = this.090E383D;
		num = 892078840U / num;
		this.7F97109A = stack.Pop();
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0021B8CC File Offset: 0x0021B8CC
	private void 221A32C2()
	{
		uint num = 762737743U;
		if (num << 12 == 0U)
		{
			goto IL_36;
		}
		if (this.254C0263().D02DFB88() == 0)
		{
			num *= 451888588U;
			num = 950803671U / num;
			this.77080C9E(this.62390F5C);
			if (num >> 11 == 0U)
			{
				return;
			}
			goto IL_36;
		}
		IL_22:
		num = 1172979520U / num;
		this.0E7C79AF.Pop();
		IL_36:
		this.307C15CA.Push(new 66026065.332067BD(this.62390F5C));
		num &= 280828135U;
		if ((2121139000U ^ num) != 0U)
		{
			num = 2071745544U - num;
			num <<= 29;
			this.7F97109A = this.51A00CFC.0A1E119D();
			num = (787104059U ^ num);
			if (1467424270U == num)
			{
				goto IL_22;
			}
			num = 2129199979U << (int)num;
			this.51A00CFC = null;
		}
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0021B9AC File Offset: 0x0021B9AC
	private void 1FCF54CB()
	{
		uint num = 579874645U;
		do
		{
			int 0F8107B = this.254C0263().D02DFB88();
			num ^= 223413237U;
			Type type = this.22C50466(0F8107B);
			num <<= 19;
			Type type2 = type;
			if (121790280U - num == 0U)
			{
				break;
			}
			num = (1083131664U & num);
			object 4C20265C = this.254C0263();
			num /= 861097336U;
			Type 2A7B54D = type2;
			num = (1660036662U ^ num);
			66026065.28060A8C 59F = new 66026065.332067BD(this.64A3721C(4C20265C, 2A7B54D).6DCA9058());
			num >>= 25;
			this.2A5A7C53(59F);
		}
		while (num >= 1862891606U);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0021BA38 File Offset: 0x0021BA38
	private void 75DE753B()
	{
		uint num = 2103077814U;
		num += 821698967U;
		num = 167514895U + num;
		Type type = this.22C50466(this.254C0263().D02DFB88());
		num = (1700015842U | num);
		Type type2 = type;
		num = 1719824343U + num;
		object 4C20265C = this.254C0263().6DCA9058();
		num = 1413879825U / num;
		Type 2A7B54D = type2;
		num &= 420630922U;
		66026065.28060A8C 59F = this.64A3721C(4C20265C, 2A7B54D);
		num *= 526408096U;
		this.2A5A7C53(59F);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0021BAB0 File Offset: 0x0021BAB0
	private void 275538A7()
	{
		uint num = 1946909891U;
		if (num <= 1039270005U)
		{
			goto IL_8F;
		}
		Type type2;
		do
		{
			IL_11:
			num = (567819086U & num);
			66026065.28060A8C 28060A8C = this.254C0263();
			num -= 239434397U;
			int 0F8107B = 28060A8C.D02DFB88();
			num = 1474720594U % num;
			Type type = this.22C50466(0F8107B);
			num /= 2087125820U;
			type2 = type;
		}
		while (num * 1256287291U != 0U);
		IL_4F:
		66026065.28060A8C 28060A8C2 = this.254C0263();
		IL_56:
		object obj = 28060A8C2.6DCA9058();
		num &= 156329803U;
		object obj2 = obj;
		num %= 1532186945U;
		IL_6E:
		if (obj2 == null)
		{
			num = 1957432162U - num;
			if ((864031007U ^ num) != 0U)
			{
				throw new NullReferenceException();
			}
			goto IL_11;
		}
		IL_8F:
		Type type3 = type2;
		num %= 1734161315U;
		if (type3.IsValueType)
		{
			num = 235866874U + num;
			if (num >> 22 == 0U)
			{
				goto IL_4F;
			}
			Type type4 = type2;
			object obj3 = obj2;
			num = 322922601U - num;
			if (type4 != obj3.GetType())
			{
				num *= 403331405U;
				if (num / 321811374U != 0U)
				{
					throw new InvalidCastException();
				}
				goto IL_4F;
			}
			else
			{
				if (1792958371U == num)
				{
					goto IL_11;
				}
				this.2A5A7C53(28060A8C2);
				if ((1633755899U & num) != 0U)
				{
					return;
				}
				goto IL_11;
			}
		}
		else
		{
			num <<= 20;
			if (1853568727U - num == 0U)
			{
				goto IL_11;
			}
			TypeCode typeCode = Type.GetTypeCode(type2);
			num = 1062143926U >> (int)num;
			if ((1093745393U ^ num) == 0U)
			{
				goto IL_56;
			}
			switch (typeCode - (TypeCode)(num ^ 1062143925U))
			{
			case 0:
			{
				num &= 1521317665U;
				if (1611227676U == num)
				{
					goto IL_4F;
				}
				object obj4 = obj2;
				num = (798039569U & num);
				66026065.28060A8C 59F = new 66026065.770A6FD1((bool)obj4);
				num = 835734670U << (int)num;
				this.2A5A7C53(59F);
				if (num << 21 != 0U)
				{
					return;
				}
				goto IL_11;
			}
			case 1:
				num *= 1583966087U;
				this.2A5A7C53(new 66026065.287D7C28((char)obj2));
				return;
			case 2:
			{
				num = 1071854035U << (int)num;
				object obj5 = obj2;
				num |= 53693204U;
				this.2A5A7C53(new 66026065.4E7A3FAE((sbyte)obj5));
				return;
			}
			case 3:
			{
				if ((num & 1812083363U) == 0U)
				{
					goto IL_4F;
				}
				num /= 970616725U;
				object obj6 = obj2;
				num = 1587241694U * num;
				this.2A5A7C53(new 66026065.3A541C87((byte)obj6));
				if (num < 1918769301U)
				{
					return;
				}
				goto IL_4F;
			}
			case 4:
			{
				num >>= 27;
				num = 1509455407U >> (int)num;
				short 241E7B0B = (short)obj2;
				num = 655828724U >> (int)num;
				this.2A5A7C53(new 66026065.2C066D18(241E7B0B));
				return;
			}
			case 5:
				if ((num & 557126002U) != 0U)
				{
					ushort 3F = (ushort)obj2;
					num |= 214971590U;
					this.2A5A7C53(new 66026065.50A37309(3F));
					return;
				}
				goto IL_4F;
			case 6:
			{
				num ^= 650993604U;
				object obj7 = obj2;
				num %= 1361645107U;
				this.2A5A7C53(new 66026065.152602F0((int)obj7));
				if (num != 1774522732U)
				{
					return;
				}
				goto IL_6E;
			}
			case 7:
			{
				object obj8 = obj2;
				num = (723417313U | num);
				this.2A5A7C53(new 66026065.23EE4D1F((uint)obj8));
				return;
			}
			case 8:
				num &= 1842172059U;
				num = 519195467U / num;
				this.2A5A7C53(new 66026065.6DA9264D((long)obj2));
				return;
			case 9:
			{
				num /= 1519733331U;
				object obj9 = obj2;
				num = 1729170639U - num;
				66026065.28060A8C 59F2 = new 66026065.374343A0((ulong)obj9);
				num = 1973186328U + num;
				this.2A5A7C53(59F2);
				if (663229554U != num)
				{
					return;
				}
				goto IL_6E;
			}
			case 10:
			{
				num = (885132229U ^ num);
				object obj10 = obj2;
				num >>= 11;
				float 34DA3CFB = (float)obj10;
				num |= 2145285786U;
				this.2A5A7C53(new 66026065.7CEE5B47(34DA3CFB));
				if (num != 888617854U)
				{
					return;
				}
				goto IL_4F;
			}
			case 11:
			{
				if (1154363075U == num)
				{
					goto IL_56;
				}
				num = 1560819447U / num;
				object obj11 = obj2;
				num = 1828390858U % num;
				double 5FD904DC = (double)obj11;
				num = 969568445U >> (int)num;
				this.2A5A7C53(new 66026065.18527F7D(5FD904DC));
				if ((num ^ 1188968163U) != 0U)
				{
					return;
				}
				goto IL_4F;
			}
			default:
				if (num != 361458699U)
				{
					throw new InvalidCastException();
				}
				goto IL_11;
			}
		}
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0021BE90 File Offset: 0x0021BE90
	private void 25447764()
	{
		uint num2;
		do
		{
			long num = this.598B592D;
			num2 = 1430131176U;
			IntPtr ptr = new IntPtr(num + (long)((ulong)this.254C0263().45E9448C()));
			num2 = 72557493U * num2;
			this.2A5A7C53(new 66026065.152602F0(Marshal.ReadInt32(ptr)));
		}
		while (2106356387U == num2);
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0021BEE0 File Offset: 0x0021BEE0
	private void 0C0C742D()
	{
		uint num = 851267023U;
		int num3;
		int num7;
		ModuleHandle moduleHandle2;
		do
		{
			num = 2021724802U - num;
			int num2 = this.254C0263().D02DFB88();
			num %= 915019586U;
			num3 = num2;
			num = (1926240283U & num);
			for (;;)
			{
				int num4 = num3;
				int num5 = (int)(num + 4260362247U);
				num &= 531578570U;
				int num6 = num4 >> num5;
				num ^= 1798790379U;
				num7 = num6;
				num = 896142067U - num;
				if (189948575 << (int)num == 0)
				{
					goto IL_7B;
				}
				do
				{
					IL_5E:
					int num8 = num7;
					uint num9 = num ^ 3425875458U;
					num %= 1825201066U;
					if (num8 <= num9)
					{
						goto Block_1;
					}
					num &= 747504592U;
					int num10 = num7;
					uint num11 = num - 201851445U;
					num -= 1017053416U;
					num += 3852176886U;
					if (num10 == num11)
					{
						goto IL_17D;
					}
					num += 1340288604U;
				}
				while (num * 1799239410U == 0U);
				int num12 = num7;
				uint num13 = num ^ 82296209U;
				num = 278530184U << (int)num;
				num += 2500104030U;
				if (num12 != num13)
				{
					goto Block_7;
				}
				goto IL_1E5;
				Block_1:
				num *= 2132563772U;
				goto IL_7B;
				IL_1E5:
				num = (1188717734U | num);
				num = 1196893273U - num;
				num = 1382051803U / num;
				ModuleHandle moduleHandle = this.702D7276.ModuleHandle;
				num = 912523805U + num;
				moduleHandle2 = moduleHandle;
				int methodToken = num3;
				num = (483811454U ^ num);
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(methodToken);
				num = 1497564525U >> (int)num;
				66026065.28060A8C 59F = new 66026065.35B110E2(runtimeMethodHandle);
				num = 1961702860U % num;
				this.2A5A7C53(59F);
				if (num != 1523934528U)
				{
					return;
				}
				continue;
				IL_7B:
				uint num14 = (uint)num7;
				num = 1569812310U + num;
				switch (num14 - (num ^ 3036974943U))
				{
				case 0U:
				case 1U:
				{
					IL_17D:
					num /= 1727213666U;
					Module module = this.702D7276;
					num /= 151876874U;
					ModuleHandle moduleHandle3 = module.ModuleHandle;
					num *= 1656770426U;
					moduleHandle2 = moduleHandle3;
					num += 539428421U;
					num = 1945533899U * num;
					int typeToken = num3;
					num /= 641084016U;
					object 7C65154C = moduleHandle2.ResolveTypeHandle(typeToken);
					num |= 1141314987U;
					this.2A5A7C53(new 66026065.35B110E2(7C65154C));
					if (num > 795035926U)
					{
						return;
					}
					goto IL_5E;
				}
				case 2U:
				case 4U:
					goto IL_30A;
				case 3U:
					goto IL_138;
				case 5U:
					goto IL_1E5;
				}
				break;
			}
		}
		while ((316374922U & num) == 0U);
		if (num7 != (int)(num ^ 3036974932U))
		{
			num += 0U;
			goto IL_30A;
		}
		num %= 1538535417U;
		try
		{
			num = (841686557U & num);
			do
			{
				this.2A5A7C53(new 66026065.35B110E2(this.702D7276.ModuleHandle.ResolveFieldHandle(num3)));
			}
			while (num - 1433799870U == 0U);
			return;
		}
		catch
		{
			do
			{
				num = 1191869565U;
				Module module2 = this.702D7276;
				num = (1136279818U | num);
				moduleHandle2 = module2.ModuleHandle;
				num = 1381913310U * num;
				num *= 1357790870U;
				int methodToken2 = num3;
				num *= 1711416262U;
				object 7C65154C2 = moduleHandle2.ResolveMethodHandle(methodToken2);
				num = 1288330091U << (int)num;
				66026065.28060A8C 59F2 = new 66026065.35B110E2(7C65154C2);
				num = (1275425901U | num);
				this.2A5A7C53(59F2);
			}
			while (num <= 1736066694U);
			return;
		}
		goto IL_30A;
		Block_7:
		num ^= 0U;
		goto IL_30A;
		IL_138:
		ModuleHandle moduleHandle4 = this.702D7276.ModuleHandle;
		num = (196493629U ^ num);
		moduleHandle2 = moduleHandle4;
		int fieldToken = num3;
		num &= 1628245647U;
		RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(fieldToken);
		num = 1120539364U - num;
		66026065.28060A8C 59F3 = new 66026065.35B110E2(runtimeFieldHandle);
		num = 612461513U / num;
		this.2A5A7C53(59F3);
		return;
		IL_30A:
		num ^= 1906137031U;
		if ((num ^ 299500926U) != 0U)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0021C230 File Offset: 0x0021C230
	private void 33F20CDA()
	{
		66026065.28060A8C 28060A8C = this.254C0263();
		uint num = 1735860167U;
		Exception ex = 28060A8C.6DCA9058() as Exception;
		num >>= 24;
		num -= 1387542473U;
		if (ex == null)
		{
			num ^= 921185157U;
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0021C278 File Offset: 0x0021C278
	private void 776D5E01()
	{
		uint num = 1514496950U;
		for (;;)
		{
			num = 2117760368U / num;
			if (this.62390F5C == null)
			{
				break;
			}
			if ((num ^ 993794117U) != 0U)
			{
				goto Block_2;
			}
		}
		throw new InvalidOperationException();
		Block_2:
		throw this.62390F5C;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0021C2B8 File Offset: 0x0021C2B8
	private void 64CD587C()
	{
		uint num = 1429946189U;
		Type type;
		66026065.28060A8C 28060A8C;
		if (46808596U < num)
		{
			do
			{
				num = 1283201255U >> (int)num;
				num = (1114450695U ^ num);
				int 0F8107B = this.254C0263().D02DFB88();
				num >>= 19;
				type = this.22C50466(0F8107B);
			}
			while ((num & 2026520974U) == 0U);
			num = 1092897381U % num;
			28060A8C = this.254C0263();
		}
		num = 141757269U + num;
		66026065.28060A8C 28060A8C2 = 28060A8C;
		num = 76771653U << (int)num;
		object 56B = 28060A8C2.6DCA9058();
		Type 049A25F = type;
		num = 606935599U * num;
		bool flag = this.494D54B7(56B, 049A25F);
		num |= 1537356920U;
		if (!flag)
		{
			if (1374172909U / num == 0U)
			{
				throw new InvalidCastException();
			}
		}
		else
		{
			num = 432805068U * num;
			66026065.28060A8C 59F = 28060A8C;
			num |= 940792888U;
			this.2A5A7C53(59F);
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0021C384 File Offset: 0x0021C384
	private void 7E2B001C()
	{
		uint num = 4730617U;
		if ((1434204855U ^ num) == 0U)
		{
			goto IL_BA;
		}
		Type type;
		66026065.28060A8C 28060A8C2;
		do
		{
			num = (1261001790U & num);
			num = 1034553146U << (int)num;
			66026065.28060A8C 28060A8C = this.254C0263();
			num = (1023685345U ^ num);
			int 0F8107B = 28060A8C.D02DFB88();
			num = (1685135874U & num);
			type = this.22C50466(0F8107B);
			num = 919616219U << (int)num;
			28060A8C2 = this.254C0263();
			num = 13654570U >> (int)num;
		}
		while (num - 2059080001U == 0U);
		IL_79:
		num |= 1954174785U;
		object 56B = 28060A8C2.6DCA9058();
		num = 1383011943U << (int)num;
		Type 049A25F = type;
		num = 382871089U >> (int)num;
		if (this.494D54B7(56B, 049A25F) || 1281951268U <= num)
		{
			goto IL_DF;
		}
		IL_BA:
		object 085C45CB = null;
		num = 553465917U << (int)num;
		66026065.28060A8C 28060A8C3 = new 66026065.332067BD(085C45CB);
		num /= 102245374U;
		28060A8C2 = 28060A8C3;
		num ^= 23393U;
		IL_DF:
		num *= 184487008U;
		if (num < 1664364762U)
		{
			goto IL_BA;
		}
		num |= 1896632897U;
		this.2A5A7C53(28060A8C2);
		if ((1542422331U ^ num) != 0U)
		{
			return;
		}
		goto IL_79;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0021C4A0 File Offset: 0x0021C4A0
	private void 01BF051F()
	{
		66026065.28060A8C 28060A8C;
		uint num;
		for (;;)
		{
			IL_00:
			28060A8C = this.254C0263();
			num = 1084948788U;
			for (;;)
			{
				IL_0D:
				object obj = 28060A8C.6DCA9058();
				num -= 1807093397U;
				bool flag = obj is IConvertible;
				num = (355615791U & num);
				if (flag)
				{
					num <<= 1;
					if (num << 23 == 0U)
					{
						continue;
					}
				}
				else if ((num & 1430128914U) != 0U)
				{
					28060A8C = new 66026065.18527F7D(double.NaN);
					num ^= 624915610U;
					goto IL_E7;
				}
				for (;;)
				{
					IL_41:
					66026065.28060A8C 28060A8C2 = 28060A8C;
					num = 1624735063U + num;
					double num2 = 28060A8C2.B1479B35();
					num = 1154958134U << (int)num;
					double num3 = num2;
					num = 575675568U * num;
					if (num <= 1338600622U)
					{
						goto IL_00;
					}
					bool flag2 = double.IsNaN(num3);
					num ^= 1609442573U;
					if (!flag2)
					{
						if (num * 1567976400U == 0U)
						{
							goto IL_0D;
						}
						double d = num3;
						num = 1482960536U - num;
						bool flag3 = double.IsInfinity(d);
						num ^= 1836662046U;
						if (!flag3)
						{
							break;
						}
						num += 3403608184U;
					}
					if (num > 1306212918U)
					{
						goto Block_5;
					}
				}
				IL_E7:
				num = 415064290U / num;
				if (num + 802836145U != 0U)
				{
					goto Block_7;
				}
				goto IL_41;
			}
		}
		Block_5:
		throw new OverflowException();
		Block_7:
		66026065.28060A8C 59F = 28060A8C;
		num = 1583839789U * num;
		this.2A5A7C53(59F);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0021C5B8 File Offset: 0x0021C5B8
	private unsafe void 4615361D()
	{
		uint num = 1363115053U;
		66026065.28060A8C 28060A8C = this.254C0263();
		num |= 2001356974U;
		IntPtr cb = 28060A8C.8ACF22C2();
		num /= 1644123479U;
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		num >>= 23;
		List<IntPtr> list = this.76E63DDD;
		num ^= 258500545U;
		IntPtr item = intPtr;
		num /= 2000641941U;
		list.Add(item);
		num &= 1282037153U;
		num -= 1698380651U;
		num |= 505167935U;
		void* ptr = intPtr.ToPointer();
		num = (436539307U | num);
		RuntimeTypeHandle handle = typeof(void*).TypeHandle;
		num = 1392975874U % num;
		66026065.28060A8C 59F = new 66026065.332067BD(Pointer.Box(ptr, Type.GetTypeFromHandle(handle)));
		num = 250167216U / num;
		this.2A5A7C53(59F);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0021C664 File Offset: 0x0021C664
	private void 50B87684()
	{
		uint num = 1709377466U;
		num = (1347054880U ^ num);
		List<IntPtr> list = this.76E63DDD;
		num |= 1394620997U;
		List<IntPtr>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			while (24735273 << (int)num != 0)
			{
				num /= 1614310195U;
				if (!enumerator.MoveNext())
				{
					break;
				}
				num = 196492013U;
				IntPtr hglobal = enumerator.Current;
				num &= 719731240U;
				Marshal.FreeHGlobal(hglobal);
				num ^= 2098151671U;
			}
		}
		finally
		{
			do
			{
				num = 7431505U;
				num = 1884950296U * num;
				((IDisposable)enumerator).Dispose();
			}
			while (340738649U >= num);
		}
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0021C728 File Offset: 0x0021C728
	public object 433F05E0(object[] 408F4135, int 13C504BB)
	{
		uint num = 1108934844U;
		this.7F97109A = 13C504BB;
		num = 162014656U * num;
		num = 1756319032U << (int)num;
		66026065.28060A8C 59F = new 66026065.2BBE3DF2(408F4135);
		num = 682654001U * num;
		this.2A5A7C53(59F);
		object result;
		try
		{
			for (;;)
			{
				try
				{
					num = 1726356608U;
					Dictionary<uint, 66026065.0C3B5530> dictionary = this.055920A9;
					num %= 533603376U;
					num = 248538243U << (int)num;
					66026065.0C3B5530 0C3B = dictionary[(uint)this.08AB1195()];
					num = 1511737816U % num;
					0C3B();
					num = 673600701U - num;
					if (num == 1691776971U || this.7F97109A != 0)
					{
						continue;
					}
				}
				catch (Exception 62A)
				{
					num = 1015114220U;
					if (528506145U != num)
					{
						do
						{
							num <<= 29;
							this.77080C9E(62A);
						}
						while (1165498707U > num);
					}
					continue;
				}
				break;
			}
			result = this.254C0263().6DCA9058();
		}
		finally
		{
			this.50B87684();
		}
		return result;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0021C85C File Offset: 0x0021C85C
	// Note: this type is marked as 'beforefieldinit'.
	static 66026065()
	{
		uint num = 2030897279U;
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		num /= 457931250U;
		66026065.2B507720 = dictionary;
		do
		{
			66026065.187A683B = new Dictionary<MethodBase, DynamicMethod>();
		}
		while (288641106U <= num);
	}

	// Token: 0x040000C3 RID: 195
	private readonly Dictionary<uint, 66026065.0C3B5530> 055920A9;

	// Token: 0x040000C4 RID: 196
	private readonly Module 702D7276;

	// Token: 0x040000C5 RID: 197
	private readonly long 598B592D;

	// Token: 0x040000C6 RID: 198
	private int 7F97109A;

	// Token: 0x040000C7 RID: 199
	private Type 343C5B08;

	// Token: 0x040000C8 RID: 200
	private Stack<66026065.61781FE7> 307C15CA;

	// Token: 0x040000C9 RID: 201
	private static readonly Dictionary<int, object> 2B507720;

	// Token: 0x040000CA RID: 202
	private static readonly Dictionary<MethodBase, DynamicMethod> 187A683B;

	// Token: 0x040000CB RID: 203
	private List<66026065.28060A8C> 56F9446E;

	// Token: 0x040000CC RID: 204
	private List<66026065.4AB007C7> 13F94EC7;

	// Token: 0x040000CD RID: 205
	private Stack<66026065.4AB007C7> 0E7C79AF;

	// Token: 0x040000CE RID: 206
	private Stack<int> 090E383D;

	// Token: 0x040000CF RID: 207
	private Exception 62390F5C;

	// Token: 0x040000D0 RID: 208
	private 66026065.608572C1 51A00CFC;

	// Token: 0x040000D1 RID: 209
	private List<IntPtr> 76E63DDD;

	// Token: 0x0200001F RID: 31
	private abstract class 28060A8C
	{
		// Token: 0x06000148 RID: 328
		public abstract 66026065.28060A8C 1368930D();

		// Token: 0x06000149 RID: 329
		public abstract object 6DCA9058();

		// Token: 0x0600014A RID: 330
		public abstract void 5F352F29(object 35C42CED);

		// Token: 0x0600014B RID: 331 RVA: 0x0020E4B0 File Offset: 0x0020E4B0
		public virtual bool 55CDE352()
		{
			return false;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0021D51C File Offset: 0x0021D51C
		public virtual 66026065.61781FE7 5412D03B()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0021D534 File Offset: 0x0021D534
		public virtual 66026065.28060A8C 31D8F335()
		{
			return this;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0021D51C File Offset: 0x0021D51C
		public virtual Type 36A9B5E8()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0021D51C File Offset: 0x0021D51C
		public virtual TypeCode 04C738A1()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0021D548 File Offset: 0x0021D548
		public virtual bool AE4D32F2()
		{
			uint num = 1221945327U;
			num <<= 14;
			object value = this.6DCA9058();
			num = 1050435285U - num;
			return Convert.ToBoolean(value);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0021D578 File Offset: 0x0021D578
		public virtual sbyte 3B8993E9()
		{
			return Convert.ToSByte(this.6DCA9058());
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0021D590 File Offset: 0x0021D590
		public virtual short D496EFA1()
		{
			return Convert.ToInt16(this.6DCA9058());
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0021D5B0 File Offset: 0x0021D5B0
		public virtual int D02DFB88()
		{
			uint num = 14963658U;
			num >>= 24;
			return Convert.ToInt32(this.6DCA9058());
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0021D5D8 File Offset: 0x0021D5D8
		public virtual long E7FBC3B9()
		{
			uint num = 1884639316U;
			num /= 1017601633U;
			object value = this.6DCA9058();
			num = 1194213492U << (int)num;
			return Convert.ToInt64(value);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0021D60C File Offset: 0x0021D60C
		public virtual char CE499C06()
		{
			uint num = 910760627U;
			object value = this.6DCA9058();
			num = (514989587U | num);
			return Convert.ToChar(value);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0021D634 File Offset: 0x0021D634
		public virtual byte 701A708C()
		{
			return Convert.ToByte(this.6DCA9058());
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0021D654 File Offset: 0x0021D654
		public virtual ushort EF893D1B()
		{
			uint num = 1350398584U;
			num = 1555112280U / num;
			return Convert.ToUInt16(this.6DCA9058());
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0021D67C File Offset: 0x0021D67C
		public virtual uint 45E9448C()
		{
			uint num = 341323142U;
			num = 1988640594U << (int)num;
			return Convert.ToUInt32(this.6DCA9058());
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0021D6A8 File Offset: 0x0021D6A8
		public virtual ulong 6100687B()
		{
			return Convert.ToUInt64(this.6DCA9058());
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0021D6C8 File Offset: 0x0021D6C8
		public virtual float 88D23451()
		{
			return Convert.ToSingle(this.6DCA9058());
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0021D6E0 File Offset: 0x0021D6E0
		public virtual double B1479B35()
		{
			return Convert.ToDouble(this.6DCA9058());
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0021D700 File Offset: 0x0021D700
		public override string ToString()
		{
			uint num = 701119605U;
			object obj2;
			if (524702846U <= num)
			{
				num |= 533950049U;
				object obj = this.6DCA9058();
				num = 530015294U * num;
				obj2 = obj;
			}
			if (obj2 == null)
			{
				num ^= 1524176514U;
				return null;
			}
			num /= 2076576805U;
			object value = obj2;
			num *= 1072451371U;
			return Convert.ToString(value);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0021D51C File Offset: 0x0021D51C
		public virtual IntPtr 8ACF22C2()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0021D51C File Offset: 0x0021D51C
		public virtual UIntPtr 16A92427()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0021D51C File Offset: 0x0021D51C
		public virtual object F7157180(Type 49726897, bool 7CFE3A76)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0020E47C File Offset: 0x0020E47C
		protected 28060A8C()
		{
			uint num = 512367528U;
			if (num != 790516869U)
			{
				base..ctor();
			}
		}
	}

	// Token: 0x02000020 RID: 32
	private abstract class 61781FE7 : 66026065.28060A8C
	{
		// Token: 0x06000161 RID: 353 RVA: 0x0021D534 File Offset: 0x0021D534
		public override 66026065.61781FE7 5412D03B()
		{
			return this;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0020E4B0 File Offset: 0x0020E4B0
		public override TypeCode 04C738A1()
		{
			return TypeCode.Empty;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0021D75C File Offset: 0x0021D75C
		protected 61781FE7()
		{
			uint num = 503129349U;
			if (698231002U / num != 0U)
			{
				do
				{
					base..ctor();
				}
				while (num == 667306989U);
			}
		}
	}

	// Token: 0x02000021 RID: 33
	private sealed class 152602F0 : 66026065.61781FE7
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0021D78C File Offset: 0x0021D78C
		public 152602F0(int 73704D05)
		{
			uint num = 463760437U;
			if (num % 20400276U != 0U)
			{
				base..ctor();
				num = 1551238032U >> (int)num;
				do
				{
					this.1EBB2762 = 73704D05;
				}
				while (205212227U < num);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0021D7D4 File Offset: 0x0021D7D4
		public override Type 36A9B5E8()
		{
			return typeof(int);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0021D7EC File Offset: 0x0021D7EC
		public override TypeCode 04C738A1()
		{
			return TypeCode.Int32;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0021D7FC File Offset: 0x0021D7FC
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 424675915U;
			int 73704D = this.1EBB2762;
			num = 604577670U + num;
			return new 66026065.152602F0(73704D);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0021D824 File Offset: 0x0021D824
		public override object 6DCA9058()
		{
			return this.1EBB2762;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0021D844 File Offset: 0x0021D844
		public override void 5F352F29(object 74F87D3A)
		{
			uint num;
			do
			{
				num = 2133805379U;
				int num2 = Convert.ToInt32(74F87D3A);
				num = 1101550519U - num;
				this.1EBB2762 = num2;
			}
			while (1411518619U - num == 0U);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0021D878 File Offset: 0x0021D878
		public override bool AE4D32F2()
		{
			uint num = 1013087208U;
			int num2 = this.1EBB2762;
			num += 49219755U;
			uint num3 = num ^ 1062306963U;
			num >>= 26;
			return num2 > num3;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0021D8AC File Offset: 0x0021D8AC
		public override sbyte 3B8993E9()
		{
			return (sbyte)this.1EBB2762;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0021D8C8 File Offset: 0x0021D8C8
		public override short D496EFA1()
		{
			uint num = 1321563970U;
			short num2 = (short)this.1EBB2762;
			num -= 1190616232U;
			return num2;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0021D8EC File Offset: 0x0021D8EC
		public override int D02DFB88()
		{
			return this.1EBB2762;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0021D900 File Offset: 0x0021D900
		public override long E7FBC3B9()
		{
			return (long)this.1EBB2762;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0021D914 File Offset: 0x0021D914
		public override char CE499C06()
		{
			return (char)this.1EBB2762;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0021D930 File Offset: 0x0021D930
		public override byte 701A708C()
		{
			uint num = 852507894U;
			num <<= 30;
			byte b = (byte)this.1EBB2762;
			num = (899097483U | num);
			return b;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0021D914 File Offset: 0x0021D914
		public override ushort EF893D1B()
		{
			return (ushort)this.1EBB2762;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0021D8EC File Offset: 0x0021D8EC
		public override uint 45E9448C()
		{
			return (uint)this.1EBB2762;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0021D95C File Offset: 0x0021D95C
		public override ulong 6100687B()
		{
			return (ulong)this.1EBB2762;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0021D978 File Offset: 0x0021D978
		public override float 88D23451()
		{
			return (float)this.1EBB2762;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0021D994 File Offset: 0x0021D994
		public override double B1479B35()
		{
			uint num = 254494146U;
			double num2 = (double)this.1EBB2762;
			num <<= 10;
			return num2;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0021D9B8 File Offset: 0x0021D9B8
		public override IntPtr 8ACF22C2()
		{
			return new IntPtr(this.1EBB2762);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0021D9D8 File Offset: 0x0021D9D8
		public override UIntPtr 16A92427()
		{
			uint num = 661337539U;
			uint value = (uint)this.1EBB2762;
			num = 1163882552U - num;
			return new UIntPtr(value);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0021DA00 File Offset: 0x0021DA00
		public override 66026065.28060A8C 31D8F335()
		{
			uint num = 1343560759U;
			num %= 717104417U;
			uint 0FD36B8F = (uint)this.1EBB2762;
			num /= 1629845676U;
			return new 66026065.23EE4D1F(0FD36B8F);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0021DA30 File Offset: 0x0021DA30
		public override object F7157180(Type 499344D9, bool 430805A6)
		{
			uint num;
			for (;;)
			{
				Type typeFromHandle = typeof(IntPtr);
				num = 1014788957U;
				if (499344D9 != typeFromHandle && 2009694196U >> (int)num != 0U)
				{
					if (499344D9 == typeof(UIntPtr))
					{
						if (num << 21 == 0U)
						{
							goto IL_3A;
						}
						num = 66081354U >> (int)num;
						if (!430805A6)
						{
							goto Block_7;
						}
						if (num != 1835607550U)
						{
							goto Block_8;
						}
						continue;
					}
					else
					{
						num &= 1700861093U;
						TypeCode typeCode = Type.GetTypeCode(499344D9);
						object obj = typeCode;
						object obj2 = num ^ 610275328U;
						num = (733950206U ^ num);
						object obj3 = obj - obj2;
						num = (1523721045U & num);
						switch (obj3)
						{
						case 0:
							if (430805A6)
							{
								goto IL_212;
							}
							num %= 1831602373U;
							if (num <= 1790463994U)
							{
								goto Block_11;
							}
							continue;
						case 1:
							num *= 630748800U;
							num = 2123831129U - num;
							if (430805A6)
							{
								goto IL_38D;
							}
							num ^= 1074203489U;
							if ((num ^ 608459271U) != 0U)
							{
								goto Block_22;
							}
							continue;
						case 2:
							if (num > 1521036681U)
							{
								continue;
							}
							if (!430805A6)
							{
								if (2109220629U >> (int)num != 0U)
								{
									goto Block_14;
								}
								continue;
							}
							else
							{
								if (num << 15 != 0U)
								{
									goto Block_15;
								}
								goto IL_3A;
							}
							break;
						case 3:
							goto IL_3AB;
						case 4:
							num = (974286284U ^ num);
							if (430805A6)
							{
								goto IL_2CE;
							}
							if ((num ^ 319310289U) != 0U)
							{
								goto Block_17;
							}
							continue;
						case 5:
							goto IL_414;
						case 6:
							num >>= 0;
							if (1412382440U <= num)
							{
								goto IL_53;
							}
							if (!430805A6)
							{
								goto Block_19;
							}
							if (1350257081U >= num)
							{
								goto Block_20;
							}
							goto IL_3A;
						case 7:
							num *= 387607072U;
							if (!430805A6)
							{
								num = 915111379U - num;
								if (num % 1271798436U != 0U)
								{
									goto Block_28;
								}
								continue;
							}
							else
							{
								if (num > 645138908U)
								{
									goto Block_29;
								}
								continue;
							}
							break;
						case 8:
							break;
						case 9:
							num /= 51841113U;
							if ((155601441U ^ num) == 0U)
							{
								continue;
							}
							if (430805A6)
							{
								goto IL_4F4;
							}
							if ((1141585711U & num) != 0U)
							{
								goto Block_32;
							}
							continue;
						default:
							num ^= 0U;
							break;
						}
						if (num != 426403916U)
						{
							goto Block_33;
						}
					}
				}
				IL_16:
				int size = IntPtr.Size;
				uint num2 = num + 3280178343U;
				num -= 734807328U;
				if (size != num2)
				{
					goto IL_91;
				}
				if (num <= 2001416822U)
				{
					goto IL_3A;
				}
				continue;
				IL_53:
				num >>= 26;
				if (1858144066U > num)
				{
					goto Block_1;
				}
				goto IL_16;
				IL_3A:
				num += 32186898U;
				if (!430805A6)
				{
					break;
				}
				goto IL_53;
			}
			IL_48:
			int value = this.1EBB2762;
			goto IL_7E;
			Block_1:
			int num3 = (int)(checked((uint)this.1EBB2762));
			num &= 1271557317U;
			value = num3;
			num ^= 312168523U;
			IL_7E:
			IntPtr intPtr = new IntPtr(value);
			num -= 1321287134U;
			return intPtr;
			IL_91:
			long value2;
			if (!430805A6)
			{
				num -= 1288243980U;
				if (num / 905511842U == 0U)
				{
					goto IL_48;
				}
				num /= 1869242332U;
				value2 = (long)this.1EBB2762;
			}
			else
			{
				num = 1666521762U - num;
				value2 = (long)((ulong)this.1EBB2762);
				num ^= 1386540132U;
			}
			num = (537478060U ^ num);
			IntPtr intPtr2 = new IntPtr(value2);
			num += 1417903247U;
			return intPtr2;
			Block_7:
			num >>= 6;
			uint num4 = (uint)this.1EBB2762;
			num += 1021787494U;
			uint value3 = num4;
			goto IL_170;
			Block_8:
			num *= 1092770556U;
			value3 = (uint)this.1EBB2762;
			num ^= 1021787494U;
			IL_170:
			num %= 397674753U;
			return new UIntPtr(value3);
			Block_11:
			num <<= 20;
			sbyte b;
			sbyte b2;
			checked
			{
				b = (sbyte)this.1EBB2762;
				goto IL_232;
				IL_212:
				num = 82344200U % num;
				b2 = (sbyte)((uint)this.1EBB2762);
			}
			num += 54094086U;
			b = b2;
			num ^= 221372942U;
			IL_232:
			num = (877544829U ^ num);
			return b;
			Block_14:
			short num5 = (short)this.1EBB2762;
			num = (1683192065U ^ num);
			short num6 = num5;
			goto IL_29B;
			Block_15:
			num >>= 19;
			num6 = checked((short)((uint)this.1EBB2762));
			num += 1853970422U;
			IL_29B:
			num -= 1038294647U;
			return num6;
			Block_17:
			int num7 = this.1EBB2762;
			goto IL_2E6;
			IL_2CE:
			uint num8 = (uint)this.1EBB2762;
			num += 647959503U;
			num7 = checked((int)num8);
			num += 3647007793U;
			IL_2E6:
			return num7;
			Block_19:
			num = (190322969U ^ num);
			num |= 608528916U;
			long num9 = (long)this.1EBB2762;
			num /= 1187907342U;
			long num10 = num9;
			goto IL_343;
			Block_20:
			num10 = (long)((ulong)this.1EBB2762);
			num += 4113424303U;
			IL_343:
			return num10;
			Block_22:
			num = 468413473U >> (int)num;
			byte b3 = checked((byte)this.1EBB2762);
			goto IL_3A5;
			IL_38D:
			uint num11 = (uint)this.1EBB2762;
			num -= 2010587952U;
			b3 = checked((byte)num11);
			num += 575507058U;
			IL_3A5:
			return b3;
			IL_3AB:
			num -= 377847745U;
			ushort num13;
			if (!430805A6)
			{
				num = 789672416U / num;
				if (num == 1898056739U)
				{
					goto IL_91;
				}
				ushort num12 = (ushort)this.1EBB2762;
				num /= 656817850U;
				num13 = num12;
			}
			else
			{
				num = (2107200779U | num);
				uint num14 = (uint)this.1EBB2762;
				num = 2047629886U >> (int)num;
				ushort num15 = (ushort)num14;
				num %= 1946099318U;
				num13 = num15;
				num += 4294967281U;
			}
			return num13;
			IL_414:
			num = 1785079911U + num;
			num &= 80761546U;
			uint num16;
			if (!430805A6)
			{
				num &= 47526076U;
				num16 = checked((uint)this.1EBB2762);
			}
			else
			{
				if (num == 114300647U)
				{
					goto IL_48;
				}
				num = (971966791U ^ num);
				num16 = (uint)this.1EBB2762;
				num ^= 1039092039U;
			}
			return num16;
			Block_28:
			uint num17 = (uint)this.1EBB2762;
			num += 437727816U;
			uint num18 = num17;
			goto IL_4B4;
			Block_29:
			num18 = (uint)this.1EBB2762;
			num += 2061731803U;
			IL_4B4:
			return num18;
			Block_32:
			num = 1479742024U - num;
			double num19 = (double)this.1EBB2762;
			goto IL_51C;
			IL_4F4:
			num <<= 30;
			num = (102595428U & num);
			int num20 = this.1EBB2762;
			num = 1349469601U - num;
			num19 = num20;
			num += 130272420U;
			IL_51C:
			return num19;
			Block_33:
			throw new ArgumentException();
		}

		// Token: 0x0400010E RID: 270
		private int 1EBB2762;
	}

	// Token: 0x02000022 RID: 34
	private sealed class 6DA9264D : 66026065.61781FE7
	{
		// Token: 0x0600017A RID: 378 RVA: 0x0021DF70 File Offset: 0x0021DF70
		public 6DA9264D(long 156A0AAB)
		{
			uint num = 815030650U;
			base..ctor();
			num /= 1892235508U;
			this.3E83054A = 156A0AAB;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0021DF98 File Offset: 0x0021DF98
		public override Type 36A9B5E8()
		{
			return typeof(long);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0021DFB8 File Offset: 0x0021DFB8
		public override TypeCode 04C738A1()
		{
			uint num = 1729448711U;
			return (int)num + (TypeCode)(-1729448700);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0021DFD4 File Offset: 0x0021DFD4
		public override 66026065.28060A8C 31D8F335()
		{
			uint num = 201600224U;
			ulong 034E529E = (ulong)this.3E83054A;
			num |= 1027546721U;
			return new 66026065.374343A0(034E529E);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0021DFFC File Offset: 0x0021DFFC
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.6DA9264D(this.3E83054A);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0021E01C File Offset: 0x0021E01C
		public override object 6DCA9058()
		{
			uint num = 901932228U;
			num = 898970723U << (int)num;
			long num2 = this.3E83054A;
			num %= 1367094848U;
			return num2;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0021E050 File Offset: 0x0021E050
		public override void 5F352F29(object 7A0E39A5)
		{
			uint num = 877344531U;
			if (num * 1344225112U != 0U)
			{
				do
				{
					num >>= 6;
					num <<= 29;
					long num2 = Convert.ToInt64(7A0E39A5);
					num = (1011047456U ^ num);
					this.3E83054A = num2;
				}
				while ((num & 1986219004U) == 0U);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0021E0A0 File Offset: 0x0021E0A0
		public override bool AE4D32F2()
		{
			uint num = 1598782814U;
			long num2 = this.3E83054A;
			long num3 = (long)(num ^ 1598782814U);
			num = (59594729U & num);
			return num2 > num3;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0021E0CC File Offset: 0x0021E0CC
		public override char CE499C06()
		{
			return (char)this.3E83054A;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0021E0E0 File Offset: 0x0021E0E0
		public override byte 701A708C()
		{
			uint num = 1712390326U;
			num <<= 21;
			return (byte)this.3E83054A;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0021E104 File Offset: 0x0021E104
		public override sbyte 3B8993E9()
		{
			return (sbyte)this.3E83054A;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0021E118 File Offset: 0x0021E118
		public override short D496EFA1()
		{
			uint num = 1232474289U;
			short num2 = (short)this.3E83054A;
			num *= 1826502626U;
			return num2;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0021E13C File Offset: 0x0021E13C
		public override int D02DFB88()
		{
			return (int)this.3E83054A;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0021E158 File Offset: 0x0021E158
		public override long E7FBC3B9()
		{
			return this.3E83054A;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0021E0CC File Offset: 0x0021E0CC
		public override ushort EF893D1B()
		{
			return (ushort)this.3E83054A;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0021E174 File Offset: 0x0021E174
		public override uint 45E9448C()
		{
			return (uint)this.3E83054A;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0021E158 File Offset: 0x0021E158
		public override ulong 6100687B()
		{
			return (ulong)this.3E83054A;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0021E190 File Offset: 0x0021E190
		public override float 88D23451()
		{
			return (float)this.3E83054A;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0021E1AC File Offset: 0x0021E1AC
		public override double B1479B35()
		{
			return (double)this.3E83054A;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0021E1C8 File Offset: 0x0021E1C8
		public override IntPtr 8ACF22C2()
		{
			uint num = 1469527661U;
			long value;
			if (num > 1188445495U)
			{
				uint size = (uint)IntPtr.Size;
				num %= 395646650U;
				if (size == num - 282587707U && 1910461355U > num)
				{
					value = (long)((int)this.3E83054A);
					num += 570425408U;
					goto IL_58;
				}
			}
			num |= 843076184U;
			value = this.3E83054A;
			IL_58:
			return new IntPtr(value);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0021E234 File Offset: 0x0021E234
		public override UIntPtr 16A92427()
		{
			uint num;
			ulong value;
			if (UIntPtr.Size != 4)
			{
				num = 673587218U;
				value = (ulong)this.3E83054A;
			}
			else
			{
				num = 886055993U;
				num %= 1060986911U;
				value = (ulong)((uint)this.3E83054A);
				num += 4082498521U;
			}
			num &= 1812008982U;
			return new UIntPtr(value);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0021E288 File Offset: 0x0021E288
		public override object F7157180(Type 200E51FA, bool 4EAF1B55)
		{
			uint num = 824851811U;
			if (num - 1593656328U == 0U)
			{
				goto IL_42;
			}
			for (;;)
			{
				IL_12:
				num = 1696609885U % num;
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num *= 2106359475U;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num = (1014787730U & num);
				if (200E51FA == typeFromHandle)
				{
					break;
				}
				for (;;)
				{
					num = (168187370U & num);
					if (200E51FA == typeof(UIntPtr))
					{
						goto Block_4;
					}
					num *= 341854807U;
					if ((num ^ 436894739U) == 0U)
					{
						goto IL_42;
					}
					num <<= 25;
					TypeCode typeCode = Type.GetTypeCode(200E51FA);
					num += 344213076U;
					TypeCode typeCode2 = typeCode;
					if (683162468U * num != 0U)
					{
						int num2 = typeCode2 - (TypeCode)(num ^ 344213073U);
						num |= 1767207026U;
						switch (num2)
						{
						case 0:
							goto IL_1B7;
						case 1:
							num += 1740339997U;
							if (num + 1791381824U != 0U)
							{
								goto Block_22;
							}
							continue;
						case 2:
							goto IL_22B;
						case 3:
							goto IL_3BB;
						case 4:
							goto IL_296;
						case 5:
							goto IL_44C;
						case 6:
							goto IL_2E1;
						case 7:
							goto IL_4A0;
						case 8:
							goto IL_558;
						case 9:
							goto IL_4F7;
						}
						goto Block_10;
					}
					goto IL_12;
				}
				IL_1B7:
				if (num >= 1031695928U)
				{
					goto Block_12;
				}
				continue;
				IL_22B:
				num = 220809921U - num;
				if (num != 732909076U)
				{
					goto Block_15;
				}
				continue;
				IL_296:
				if (num != 659585904U)
				{
					goto Block_17;
				}
				continue;
				IL_2E1:
				num |= 1055807298U;
				if ((num & 1578828962U) == 0U)
				{
					continue;
				}
				num = (923165757U & num);
				if (4EAF1B55)
				{
					goto IL_321;
				}
				if (num > 883913404U)
				{
					goto Block_21;
				}
				continue;
				Block_22:
				if (!4EAF1B55)
				{
					num = 935801671U % num;
					if (num >> 2 != 0U)
					{
						goto Block_24;
					}
					continue;
				}
				else
				{
					if ((653542285U ^ num) != 0U)
					{
						goto Block_25;
					}
					continue;
				}
				IL_3BB:
				num *= 1522353001U;
				if (935608889U >= num)
				{
					continue;
				}
				num %= 583427145U;
				if (!4EAF1B55)
				{
					goto Block_27;
				}
				num = 138872732U << (int)num;
				if ((323897999U ^ num) != 0U)
				{
					goto Block_29;
				}
				continue;
				IL_44C:
				if (4EAF1B55)
				{
					goto IL_47A;
				}
				num *= 116748042U;
				if (num + 334459329U != 0U)
				{
					goto Block_31;
				}
				continue;
				IL_4A0:
				num = (150675579U | num);
				if (num == 626270520U)
				{
					continue;
				}
				if (4EAF1B55)
				{
					goto IL_4D8;
				}
				num = 332478041U / num;
				if (1072123648U >= num)
				{
					goto Block_34;
				}
				continue;
				IL_4F7:
				num |= 187176113U;
				num = 147408090U << (int)num;
				if (4EAF1B55)
				{
					goto IL_532;
				}
				num = (1598635687U ^ num);
				if (969690929U >= num)
				{
					goto Block_37;
				}
			}
			num = (839792159U | num);
			goto IL_42;
			Block_4:
			num |= 169370798U;
			if (1621183464U > num)
			{
				num = (380133193U & num);
				ulong value;
				if (!4EAF1B55)
				{
					ulong num3 = (ulong)this.3E83054A;
					num = (2114982244U | num);
					value = num3;
				}
				else
				{
					num <<= 27;
					if (num <= 263864996U)
					{
						goto IL_42;
					}
					value = (ulong)this.3E83054A;
					num += 1041782124U;
				}
				num >>= 5;
				UIntPtr uintPtr = new UIntPtr(value);
				num /= 1030638750U;
				return uintPtr;
			}
			goto IL_69;
			Block_10:
			if (num % 108003942U != 0U)
			{
				num ^= 0U;
				goto IL_558;
			}
			goto IL_42;
			Block_12:
			num = 749619833U >> (int)num;
			sbyte b2;
			if (!4EAF1B55)
			{
				num *= 89395833U;
				num >>= 5;
				sbyte b = (sbyte)this.3E83054A;
				num = 1771657520U % num;
				b2 = b;
			}
			else
			{
				if (2053861613U == num)
				{
					goto IL_42;
				}
				sbyte b3 = (sbyte)(checked((ulong)this.3E83054A));
				num = 452731114U - num;
				b2 = b3;
				num ^= 518766502U;
			}
			num = 1122635784U + num;
			return b2;
			Block_15:
			short num5;
			if (!4EAF1B55)
			{
				num >>= 13;
				num <<= 12;
				short num4 = (short)this.3E83054A;
				num >>= 2;
				num5 = num4;
			}
			else
			{
				num >>= 18;
				ulong num6 = (ulong)this.3E83054A;
				num = 1511525330U * num;
				num5 = checked((short)num6);
				num ^= 4100786152U;
			}
			num &= 209273590U;
			return num5;
			Block_17:
			num = 148207266U + num;
			int num7;
			if (!4EAF1B55)
			{
				num7 = checked((int)this.3E83054A);
			}
			else
			{
				ulong num8 = (ulong)this.3E83054A;
				num = 882911223U * num;
				int num9 = (int)num8;
				num = (788729704U | num);
				num7 = num9;
				num ^= 2845934192U;
			}
			return num7;
			Block_21:
			num = (1303411347U ^ num);
			long num10 = this.3E83054A;
			goto IL_339;
			IL_321:
			ulong num11 = (ulong)this.3E83054A;
			num /= 1210659337U;
			num10 = checked((long)num11);
			num += 2058755751U;
			IL_339:
			num >>= 19;
			return num10;
			Block_24:
			byte b4 = checked((byte)this.3E83054A);
			goto IL_3AD;
			Block_25:
			num = (687493314U ^ num);
			ulong num12 = (ulong)this.3E83054A;
			num -= 2051671688U;
			b4 = checked((byte)num12);
			num ^= 1692903822U;
			IL_3AD:
			num = 1298730559U - num;
			return b4;
			Block_27:
			num -= 1126503007U;
			ushort num13;
			if (708987042U - num != 0U)
			{
				num = 1151484684U - num;
				num13 = checked((ushort)this.3E83054A);
				goto IL_43E;
			}
			goto IL_5E;
			Block_29:
			num = 1558145657U + num;
			uint num14 = (uint)this.3E83054A;
			num >>= 16;
			num13 = checked((ushort)num14);
			num += 2221765828U;
			IL_43E:
			num <<= 28;
			return num13;
			Block_31:
			uint num15 = (uint)this.3E83054A;
			num /= 1541816218U;
			uint num16 = num15;
			goto IL_49A;
			IL_47A:
			num += 1852377863U;
			uint num17 = (uint)(checked((ulong)this.3E83054A));
			num += 421152223U;
			num16 = num17;
			num += 4205263013U;
			IL_49A:
			return num16;
			Block_34:
			ulong num18 = checked((ulong)this.3E83054A);
			goto IL_4F1;
			IL_4D8:
			if (1094721558U >= num)
			{
				goto IL_5E;
			}
			num18 = (ulong)this.3E83054A;
			num ^= 2113894015U;
			IL_4F1:
			return num18;
			Block_37:
			double num19 = (double)this.3E83054A;
			goto IL_552;
			IL_532:
			num += 1087523437U;
			long num20 = this.3E83054A;
			num = 92471487U * num;
			num19 = num20;
			num ^= 3571825140U;
			IL_552:
			return num19;
			IL_558:
			throw new ArgumentException();
			IL_42:
			num = 1179930020U >> (int)num;
			if (4EAF1B55)
			{
				goto IL_69;
			}
			num <<= 16;
			IL_5E:
			long value2 = this.3E83054A;
			goto IL_95;
			IL_69:
			if (num << 2 != 0U)
			{
				goto IL_12;
			}
			num &= 298940143U;
			ulong num21 = (ulong)this.3E83054A;
			num -= 1520244851U;
			value2 = checked((long)num21);
			num ^= 2774722445U;
			IL_95:
			return new IntPtr(value2);
		}

		// Token: 0x0400010F RID: 271
		private long 3E83054A;
	}

	// Token: 0x02000023 RID: 35
	private sealed class 7CEE5B47 : 66026065.61781FE7
	{
		// Token: 0x06000190 RID: 400 RVA: 0x0021E7F4 File Offset: 0x0021E7F4
		public 7CEE5B47(float 34DA3CFB)
		{
			this.07C260FB = 34DA3CFB;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0021E810 File Offset: 0x0021E810
		public override Type 36A9B5E8()
		{
			return typeof(float);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0021E828 File Offset: 0x0021E828
		public override TypeCode 04C738A1()
		{
			uint num = 1339041489U;
			return (TypeCode)(num ^ 1339041500U);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0021E844 File Offset: 0x0021E844
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.7CEE5B47(this.07C260FB);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0021E864 File Offset: 0x0021E864
		public override object 6DCA9058()
		{
			uint num = 293604783U;
			float num2 = this.07C260FB;
			num -= 791563819U;
			return num2;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0021E88C File Offset: 0x0021E88C
		public override void 5F352F29(object 4DFB26FF)
		{
			uint num = 87450302U;
			do
			{
				this.07C260FB = Convert.ToSingle(4DFB26FF);
			}
			while (num * 1255174823U == 0U);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0021E8B8 File Offset: 0x0021E8B8
		public override bool AE4D32F2()
		{
			uint num = 295246244U;
			num += 1106651050U;
			return Convert.ToBoolean(this.07C260FB);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0021E8E0 File Offset: 0x0021E8E0
		public override sbyte 3B8993E9()
		{
			uint num = 2100511407U;
			num &= 2041265057U;
			return (sbyte)this.07C260FB;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0021E904 File Offset: 0x0021E904
		public override short D496EFA1()
		{
			return (short)this.07C260FB;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0021E920 File Offset: 0x0021E920
		public override int D02DFB88()
		{
			return (int)this.07C260FB;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0021E93C File Offset: 0x0021E93C
		public override long E7FBC3B9()
		{
			uint num = 1940062972U;
			num = 2038514423U - num;
			long num2 = (long)this.07C260FB;
			num /= 874987594U;
			return num2;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0021E968 File Offset: 0x0021E968
		public override char CE499C06()
		{
			uint num = 837699569U;
			num ^= 1795908887U;
			return (char)this.07C260FB;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0021E98C File Offset: 0x0021E98C
		public override byte 701A708C()
		{
			return (byte)this.07C260FB;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0021E968 File Offset: 0x0021E968
		public override ushort EF893D1B()
		{
			uint num = 837699569U;
			num ^= 1795908887U;
			return (ushort)this.07C260FB;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0021E9A0 File Offset: 0x0021E9A0
		public override uint 45E9448C()
		{
			uint num = 426391552U;
			num = 1005679381U >> (int)num;
			return (uint)this.07C260FB;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0021E9C8 File Offset: 0x0021E9C8
		public override ulong 6100687B()
		{
			uint num = 1302665391U;
			num %= 1622097284U;
			ulong num2 = (ulong)this.07C260FB;
			num = (1911294749U ^ num);
			return num2;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0021E9F4 File Offset: 0x0021E9F4
		public override float 88D23451()
		{
			return this.07C260FB;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0021EA10 File Offset: 0x0021EA10
		public override double B1479B35()
		{
			return (double)this.07C260FB;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0021EA2C File Offset: 0x0021EA2C
		public override IntPtr 8ACF22C2()
		{
			int size = IntPtr.Size;
			uint num = 1495734831U;
			uint num2 = num - 1495734827U;
			num %= 1057758706U;
			long value;
			if (size == num2 && num << 3 != 0U)
			{
				int num3 = (int)this.07C260FB;
				num -= 770919753U;
				value = (long)num3;
				num ^= 2921835132U;
			}
			else
			{
				long num4 = (long)this.07C260FB;
				num = 669321291U + num;
				value = num4;
			}
			num = (283537485U & num);
			return new IntPtr(value);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0021EAA0 File Offset: 0x0021EAA0
		public override UIntPtr 16A92427()
		{
			uint num = 2131051834U;
			int size = IntPtr.Size;
			num <<= 29;
			uint num2 = num + 3221225476U;
			num = 1544511846U << (int)num;
			ulong value;
			if (size != num2)
			{
				num = (200488905U | num);
				ulong num3 = (ulong)this.07C260FB;
				num |= 177819294U;
				value = num3;
			}
			else
			{
				num |= 950229738U;
				uint num4 = (uint)this.07C260FB;
				num %= 47020059U;
				value = (ulong)num4;
				num += 1587587253U;
			}
			return new UIntPtr(value);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0021EB1C File Offset: 0x0021EB1C
		public override object F7157180(Type 1F5975C9, bool 16F55D2C)
		{
			uint num = 559119578U;
			for (;;)
			{
				IL_06:
				num = (1985045886U ^ num);
				Type typeFromHandle = typeof(IntPtr);
				num = 1139155619U + num;
				if (1F5975C9 == typeFromHandle)
				{
					break;
				}
				while ((num ^ 52582214U) != 0U)
				{
					num ^= 1108156399U;
					RuntimeTypeHandle handle = typeof(UIntPtr).TypeHandle;
					num = (1561005650U | num);
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
					num &= 917916211U;
					if (1F5975C9 == typeFromHandle2)
					{
						goto Block_3;
					}
					TypeCode typeCode = Type.GetTypeCode(1F5975C9);
					num = 1181577006U * num;
					TypeCode typeCode2 = typeCode;
					num = (1047690538U | num);
					uint num2 = num ^ 3220963323U;
					num = 164505748U << (int)num;
					switch (typeCode2 - num2)
					{
					case 0:
						num = 1391217643U << (int)num;
						if (num / 446629669U == 0U)
						{
							goto IL_2E;
						}
						num = (1498312508U | num);
						if (!16F55D2C)
						{
							goto Block_6;
						}
						if (2087743565U > num)
						{
							goto Block_8;
						}
						continue;
					case 1:
						goto IL_229;
					case 2:
						num = (1035814895U ^ num);
						if (16F55D2C)
						{
							goto IL_1D8;
						}
						if (num + 422262591U != 0U)
						{
							goto Block_10;
						}
						goto IL_06;
					case 3:
						goto IL_251;
					case 4:
						goto IL_21C;
					case 5:
						goto IL_27E;
					case 6:
						goto IL_2B8;
					case 7:
						goto IL_293;
					}
					goto Block_4;
				}
				goto IL_2E;
			}
			num >>= 17;
			IL_2E:
			long num3 = (long)this.07C260FB;
			num &= 69754075U;
			IntPtr intPtr = new IntPtr(num3);
			num = (1670210656U | num);
			return intPtr;
			Block_3:
			num /= 1068521512U;
			ulong num4 = (ulong)this.07C260FB;
			num &= 1476854471U;
			ulong value = num4;
			num = (606870117U ^ num);
			return new UIntPtr(value);
			Block_4:
			num += 0U;
			goto IL_2B8;
			Block_6:
			num = (83121314U | num);
			sbyte b2;
			if (1785341358U >= num)
			{
				num -= 27224487U;
				sbyte b = (sbyte)this.07C260FB;
				num = 1029469510U >> (int)num;
				b2 = b;
				goto IL_194;
			}
			goto IL_2E;
			Block_8:
			num = 1646599475U << (int)num;
			b2 = checked((sbyte)((uint)this.07C260FB));
			num ^= 2147483709U;
			IL_194:
			num >>= 0;
			return b2;
			Block_10:
			num -= 1291348884U;
			short num5 = (short)this.07C260FB;
			num = (1523658355U ^ num);
			short num6 = num5;
			goto IL_20E;
			IL_1D8:
			num = 1357736592U - num;
			num = 1371691564U + num;
			uint num7 = (uint)this.07C260FB;
			num = 208424380U << (int)num;
			short num8 = (short)num7;
			num = (2008096110U & num);
			num6 = num8;
			num ^= 2879713832U;
			IL_20E:
			num = (1668832341U ^ num);
			return num6;
			IL_21C:
			checked
			{
				return (int)this.07C260FB;
				IL_229:
				if (1187795333U >= num)
				{
					num = (1973961931U | num);
					byte b3 = (byte)this.07C260FB;
					num |= 883650577U;
					return b3;
				}
				goto IL_2E;
				IL_251:
				num &= 223632105U;
			}
			num += 1691776504U;
			ushort num9 = (ushort)this.07C260FB;
			num /= 372407917U;
			ushort num10 = num9;
			num = 1145714724U - num;
			return num10;
			IL_27E:
			uint num11 = (uint)this.07C260FB;
			num = (1255367903U & num);
			return num11;
			IL_293:
			num |= 1638466269U;
			num = (1258763165U ^ num);
			ulong num12 = (ulong)this.07C260FB;
			num |= 983771909U;
			return num12;
			IL_2B8:
			throw new ArgumentException();
		}

		// Token: 0x04000110 RID: 272
		private float 07C260FB;
	}

	// Token: 0x02000024 RID: 36
	private sealed class 18527F7D : 66026065.61781FE7
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x0021EDE8 File Offset: 0x0021EDE8
		public 18527F7D(double 5FD904DC)
		{
			uint num = 1239570733U;
			do
			{
				num = 1061630241U + num;
				base..ctor();
			}
			while ((num & 1183252805U) == 0U);
			do
			{
				num /= 634726463U;
				this.31E50D5F = 5FD904DC;
			}
			while (1920205809U + num == 0U);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0021EE30 File Offset: 0x0021EE30
		public override Type 36A9B5E8()
		{
			return typeof(double);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0021EE48 File Offset: 0x0021EE48
		public override TypeCode 04C738A1()
		{
			uint num = 1057451332U;
			return (TypeCode)(num ^ 1057451338U);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0021EE64 File Offset: 0x0021EE64
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.18527F7D(this.31E50D5F);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0021EE84 File Offset: 0x0021EE84
		public override object 6DCA9058()
		{
			return this.31E50D5F;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0021EEA4 File Offset: 0x0021EEA4
		public override void 5F352F29(object 6C8076B6)
		{
			uint num = 207497592U;
			if (362507467U != num)
			{
				num = 1701005774U % num;
				num = (731451706U & num);
				double num2 = (double)6C8076B6;
				num = 1078815518U << (int)num;
				this.31E50D5F = num2;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0021EEEC File Offset: 0x0021EEEC
		public override bool AE4D32F2()
		{
			uint num = 237653314U;
			num = 1064049057U - num;
			return Convert.ToBoolean(this.31E50D5F);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0021EF14 File Offset: 0x0021EF14
		public override sbyte 3B8993E9()
		{
			uint num = 1455454243U;
			sbyte b = (sbyte)this.31E50D5F;
			num = (963718257U & num);
			return b;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0021EF38 File Offset: 0x0021EF38
		public override short D496EFA1()
		{
			uint num = 2028210883U;
			num = 923216706U / num;
			return (short)this.31E50D5F;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0021EF5C File Offset: 0x0021EF5C
		public override int D02DFB88()
		{
			return (int)this.31E50D5F;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0021EF78 File Offset: 0x0021EF78
		public override long E7FBC3B9()
		{
			return (long)this.31E50D5F;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0021EF94 File Offset: 0x0021EF94
		public override char CE499C06()
		{
			uint num = 1135479808U;
			num = 2081714693U % num;
			char c = (char)this.31E50D5F;
			num <<= 16;
			return c;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0021EFC0 File Offset: 0x0021EFC0
		public override byte 701A708C()
		{
			return (byte)this.31E50D5F;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0021EF94 File Offset: 0x0021EF94
		public override ushort EF893D1B()
		{
			uint num = 1135479808U;
			num = 2081714693U % num;
			ushort num2 = (ushort)this.31E50D5F;
			num <<= 16;
			return num2;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0021EFDC File Offset: 0x0021EFDC
		public override uint 45E9448C()
		{
			uint num = 1312496541U;
			num |= 1067205014U;
			return (uint)this.31E50D5F;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0021F000 File Offset: 0x0021F000
		public override ulong 6100687B()
		{
			return (ulong)this.31E50D5F;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0021F01C File Offset: 0x0021F01C
		public override float 88D23451()
		{
			return (float)this.31E50D5F;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0021F038 File Offset: 0x0021F038
		public override double B1479B35()
		{
			uint num = 1203651930U;
			num = 147994892U - num;
			return this.31E50D5F;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0021F05C File Offset: 0x0021F05C
		public override IntPtr 8ACF22C2()
		{
			uint size = (uint)IntPtr.Size;
			uint num = 1521570976U;
			long value;
			if (size != (num ^ 1521570980U))
			{
				num = (1380078632U & num);
				num = 751578061U - num;
				long num2 = (long)this.31E50D5F;
				num |= 1893556140U;
				value = num2;
			}
			else
			{
				num = (345840996U & num);
				num = 1586764197U >> (int)num;
				long num3 = (long)((int)this.31E50D5F);
				num /= 1097819895U;
				value = num3;
				num ^= 4208975788U;
			}
			num >>= 6;
			return new IntPtr(value);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0021F0E0 File Offset: 0x0021F0E0
		public override UIntPtr 16A92427()
		{
			uint num = 789736177U;
			ulong value;
			if (IntPtr.Size != (int)(num ^ 789736181U))
			{
				num += 137251222U;
				num |= 407716999U;
				ulong num2 = (ulong)this.31E50D5F;
				num = 812672772U / num;
				value = num2;
			}
			else
			{
				value = (ulong)((uint)this.31E50D5F);
				num ^= 789736177U;
			}
			num >>= 0;
			return new UIntPtr(value);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0021F148 File Offset: 0x0021F148
		public override object F7157180(Type 0520416F, bool 49CC5D03)
		{
			uint num = 1397122431U;
			if (num + 288907003U != 0U)
			{
				for (;;)
				{
					IL_12:
					RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
					num = 874975317U << (int)num;
					Type typeFromHandle = Type.GetTypeFromHandle(handle);
					num = 1748527632U + num;
					if (0520416F == typeFromHandle)
					{
						break;
					}
					for (;;)
					{
						IL_52:
						num >>= 4;
						if (num * 2048466689U == 0U)
						{
							goto IL_12;
						}
						RuntimeTypeHandle handle2 = typeof(UIntPtr).TypeHandle;
						num >>= 8;
						Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
						num = 452075981U % num;
						if (0520416F == typeFromHandle2)
						{
							goto Block_3;
						}
						for (;;)
						{
							TypeCode typeCode = Type.GetTypeCode(0520416F);
							num <<= 29;
							uint num2 = (uint)typeCode;
							num = (9332985U | num);
							switch (num2 - (num + 2675021580U))
							{
							case 0U:
								goto IL_11E;
							case 1U:
								goto IL_24C;
							case 2U:
								if (2054581139U <= num)
								{
									goto IL_52;
								}
								num = 1623796866U + num;
								if (49CC5D03)
								{
									goto IL_1BF;
								}
								num = 634936439U / num;
								if (1478904904U != num)
								{
									goto Block_10;
								}
								continue;
							case 3U:
								goto IL_26D;
							case 4U:
								goto IL_201;
							case 5U:
								goto IL_292;
							case 6U:
								goto IL_21E;
							case 7U:
								goto IL_2C3;
							case 8U:
								goto IL_300;
							case 9U:
								goto IL_2F4;
							}
							break;
						}
						if (1952923870U > num)
						{
							goto Block_5;
						}
						continue;
						IL_1BF:
						num = 376972917U / num;
						if (289499578U - num != 0U)
						{
							goto Block_11;
						}
					}
					IL_24C:
					if ((830305959U ^ num) != 0U)
					{
						goto Block_13;
					}
				}
				num = 445467795U + num;
				goto IL_40;
				Block_3:
				num = (1509570904U | num);
				if (1114209771U > num)
				{
					goto IL_40;
				}
				IL_99:
				UIntPtr uintPtr = new UIntPtr(checked((ulong)this.31E50D5F));
				num = 820591956U << (int)num;
				return uintPtr;
				Block_5:
				num ^= 0U;
				goto IL_300;
				IL_11E:
				sbyte b2;
				if (!49CC5D03)
				{
					num = 1797207997U >> (int)num;
					if (num >= 873532988U)
					{
						goto IL_40;
					}
					sbyte b = (sbyte)this.31E50D5F;
					num &= 2144560698U;
					b2 = b;
				}
				else
				{
					num ^= 483470743U;
					uint num3 = (uint)this.31E50D5F;
					num ^= 589316452U;
					b2 = checked((sbyte)num3);
					num += 2692807718U;
				}
				num = (1496153509U & num);
				return b2;
				Block_10:
				short num4 = (short)this.31E50D5F;
				num %= 1152085134U;
				short num5 = num4;
				goto IL_1F3;
				Block_11:
				num -= 1718968982U;
				uint num6 = (uint)this.31E50D5F;
				num *= 1868645502U;
				num5 = checked((short)num6);
				num ^= 4281573932U;
				IL_1F3:
				num = 1309240086U * num;
				return num5;
				IL_201:
				num %= 759517111U;
				int num7 = checked((int)this.31E50D5F);
				num -= 1477467237U;
				return num7;
				IL_21E:
				byte b3;
				checked
				{
					if (1671184089U >= num)
					{
						num = 2038585594U / num;
						long num8 = (long)this.31E50D5F;
						num = 640180523U >> (int)num;
						return num8;
					}
					goto IL_40;
					Block_13:
					b3 = (byte)this.31E50D5F;
				}
				num = 921987100U - num;
				return b3;
				IL_26D:
				num |= 1575642560U;
				ushort num9 = (ushort)this.31E50D5F;
				num *= 1394370271U;
				ushort num10 = num9;
				num += 181341249U;
				return num10;
				IL_292:
				num |= 1213626703U;
				if (num - 1935288453U != 0U)
				{
					num >>= 19;
					uint num11 = (uint)this.31E50D5F;
					num = 820134954U + num;
					return num11;
				}
				goto IL_99;
				IL_2C3:
				if (357326712U - num != 0U)
				{
					num += 1228286232U;
					ulong num12 = (ulong)this.31E50D5F;
					num *= 1131766985U;
					ulong num13 = num12;
					num <<= 3;
					return num13;
				}
				goto IL_40;
				IL_2F4:
				return this.31E50D5F;
				IL_300:
				throw new ArgumentException();
			}
			IL_40:
			return new IntPtr(checked((long)this.31E50D5F));
		}

		// Token: 0x04000111 RID: 273
		private double 31E50D5F;
	}

	// Token: 0x02000025 RID: 37
	private sealed class 1B84428C : 66026065.61781FE7
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0021F45C File Offset: 0x0021F45C
		public 1B84428C(string 7F7E7F35)
		{
			uint num = 1094401889U;
			base..ctor();
			if (1745570015U > num)
			{
				this.5DD476CD = 7F7E7F35;
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0021F488 File Offset: 0x0021F488
		public override Type 36A9B5E8()
		{
			uint num = 911749729U;
			RuntimeTypeHandle handle = typeof(string).TypeHandle;
			num = 1696483741U << (int)num;
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0020E4A0 File Offset: 0x0020E4A0
		public override TypeCode 04C738A1()
		{
			return TypeCode.Object;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0021F4B4 File Offset: 0x0021F4B4
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.1B84428C(this.5DD476CD);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0021F4D4 File Offset: 0x0021F4D4
		public override object 6DCA9058()
		{
			return this.5DD476CD;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0021F4F0 File Offset: 0x0021F4F0
		public override void 5F352F29(object 36582049)
		{
			string text;
			if (36582049 == null)
			{
				text = null;
			}
			else
			{
				uint num = 1795508511U;
				num *= 198541258U;
				text = Convert.ToString(36582049);
			}
			this.5DD476CD = text;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0021F52C File Offset: 0x0021F52C
		public override bool AE4D32F2()
		{
			uint num = 2104315285U;
			object obj = this.5DD476CD;
			num += 1790335189U;
			return obj != null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0021F4D4 File Offset: 0x0021F4D4
		public override string ToString()
		{
			return this.5DD476CD;
		}

		// Token: 0x04000112 RID: 274
		private string 5DD476CD;
	}

	// Token: 0x02000026 RID: 38
	private sealed class 2C066D18 : 66026065.28060A8C
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x0021F550 File Offset: 0x0021F550
		public 2C066D18(short 241E7B0B)
		{
			uint num = 239674790U;
			base..ctor();
			num >>= 20;
			do
			{
				this.1EEF1FCA = 241E7B0B;
			}
			while (num >= 483066767U);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0021F584 File Offset: 0x0021F584
		public override Type 36A9B5E8()
		{
			return typeof(short);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0021F5A4 File Offset: 0x0021F5A4
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 1926235475U;
			short 241E7B0B = this.1EEF1FCA;
			num = (1139701820U ^ num);
			return new 66026065.2C066D18(241E7B0B);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0021F5CC File Offset: 0x0021F5CC
		public override object 6DCA9058()
		{
			uint num = 915681371U;
			short num2 = this.1EEF1FCA;
			num = 1491735564U >> (int)num;
			return num2;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0021F5F8 File Offset: 0x0021F5F8
		public override void 5F352F29(object 0237090D)
		{
			uint num;
			do
			{
				num = 784859154U;
				this.1EEF1FCA = Convert.ToInt16(0237090D);
			}
			while (num % 1577680065U == 0U);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0021F624 File Offset: 0x0021F624
		public override 66026065.61781FE7 5412D03B()
		{
			return new 66026065.152602F0(this.D02DFB88());
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0021F644 File Offset: 0x0021F644
		public override sbyte 3B8993E9()
		{
			uint num = 1217612105U;
			num = 1607233540U / num;
			sbyte b = (sbyte)this.1EEF1FCA;
			num = (1742498283U ^ num);
			return b;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0021F670 File Offset: 0x0021F670
		public override byte 701A708C()
		{
			return (byte)this.1EEF1FCA;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0021F68C File Offset: 0x0021F68C
		public override short D496EFA1()
		{
			return this.1EEF1FCA;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0021F6A8 File Offset: 0x0021F6A8
		public override ushort EF893D1B()
		{
			return (ushort)this.1EEF1FCA;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0021F68C File Offset: 0x0021F68C
		public override int D02DFB88()
		{
			return (int)this.1EEF1FCA;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0021F68C File Offset: 0x0021F68C
		public override uint 45E9448C()
		{
			return (uint)this.1EEF1FCA;
		}

		// Token: 0x04000113 RID: 275
		private short 1EEF1FCA;
	}

	// Token: 0x02000027 RID: 39
	private sealed class 50A37309 : 66026065.28060A8C
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0021F6C4 File Offset: 0x0021F6C4
		public 50A37309(ushort 3F730815)
		{
			uint num = 1333541739U;
			if (257587514U * num != 0U)
			{
				base..ctor();
				if (num <= 1535141940U)
				{
					num = (1369338488U & num);
					num -= 926383865U;
					this.4FF5589A = 3F730815;
				}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0021F70C File Offset: 0x0021F70C
		public override Type 36A9B5E8()
		{
			return typeof(ushort);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0021F72C File Offset: 0x0021F72C
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.50A37309(this.4FF5589A);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0021F744 File Offset: 0x0021F744
		public override object 6DCA9058()
		{
			return this.4FF5589A;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0021F764 File Offset: 0x0021F764
		public override void 5F352F29(object 0A7C7C8E)
		{
			uint num = 1550215613U;
			do
			{
				num += 1366626475U;
				ushort num2 = Convert.ToUInt16(0A7C7C8E);
				num = (1018778126U & num);
				this.4FF5589A = num2;
			}
			while (1613373165U == num);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0021F624 File Offset: 0x0021F624
		public override 66026065.61781FE7 5412D03B()
		{
			return new 66026065.152602F0(this.D02DFB88());
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0021F7A0 File Offset: 0x0021F7A0
		public override sbyte 3B8993E9()
		{
			return (sbyte)this.4FF5589A;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0021F7BC File Offset: 0x0021F7BC
		public override byte 701A708C()
		{
			uint num = 743841288U;
			num = 881787468U % num;
			return (byte)this.4FF5589A;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0021F7E0 File Offset: 0x0021F7E0
		public override short D496EFA1()
		{
			uint num = 790327187U;
			num = 1702173529U * num;
			return (short)this.4FF5589A;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0021F804 File Offset: 0x0021F804
		public override ushort EF893D1B()
		{
			return this.4FF5589A;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0021F804 File Offset: 0x0021F804
		public override int D02DFB88()
		{
			return (int)this.4FF5589A;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0021F804 File Offset: 0x0021F804
		public override uint 45E9448C()
		{
			return (uint)this.4FF5589A;
		}

		// Token: 0x04000114 RID: 276
		private ushort 4FF5589A;
	}

	// Token: 0x02000028 RID: 40
	private sealed class 770A6FD1 : 66026065.28060A8C
	{
		// Token: 0x060001DA RID: 474 RVA: 0x0021F820 File Offset: 0x0021F820
		public 770A6FD1(bool 51A52E5B)
		{
			uint num = 1490512036U;
			if (159386707U != num)
			{
				base..ctor();
				num = 368786597U + num;
				if (291124774U != num)
				{
					num >>= 0;
					this.67996DA7 = 51A52E5B;
				}
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0021F868 File Offset: 0x0021F868
		public override Type 36A9B5E8()
		{
			uint num = 655371372U;
			RuntimeTypeHandle handle = typeof(bool).TypeHandle;
			num = (690168150U ^ num);
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0021F890 File Offset: 0x0021F890
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.770A6FD1(this.67996DA7);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0021F8A8 File Offset: 0x0021F8A8
		public override object 6DCA9058()
		{
			return this.67996DA7;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0021F8C0 File Offset: 0x0021F8C0
		public override void 5F352F29(object 1D935C11)
		{
			uint num = 2113407540U;
			bool flag = Convert.ToBoolean(1D935C11);
			num >>= 14;
			this.67996DA7 = flag;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0021F624 File Offset: 0x0021F624
		public override 66026065.61781FE7 5412D03B()
		{
			return new 66026065.152602F0(this.D02DFB88());
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0021F8E8 File Offset: 0x0021F8E8
		public override int D02DFB88()
		{
			bool flag = this.67996DA7;
			uint num = 1095901848U;
			if (!flag)
			{
				return (int)(num + 3199065448U);
			}
			return (int)(num ^ 1095901849U);
		}

		// Token: 0x04000115 RID: 277
		private bool 67996DA7;
	}

	// Token: 0x02000029 RID: 41
	private sealed class 287D7C28 : 66026065.28060A8C
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0021F918 File Offset: 0x0021F918
		public 287D7C28(char 73117D49)
		{
			uint num = 357067659U;
			base..ctor();
			num = (19083883U ^ num);
			num = 648557642U + num;
			num *= 501114822U;
			this.44FF41FF = 73117D49;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0021F950 File Offset: 0x0021F950
		public override Type 36A9B5E8()
		{
			uint num = 707228108U;
			RuntimeTypeHandle handle = typeof(char).TypeHandle;
			num = (756171399U | num);
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0021F978 File Offset: 0x0021F978
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.287D7C28(this.44FF41FF);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0021F998 File Offset: 0x0021F998
		public override object 6DCA9058()
		{
			return this.44FF41FF;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0021F9B8 File Offset: 0x0021F9B8
		public override void 5F352F29(object 03B66B60)
		{
			uint num = 557327970U;
			char c = Convert.ToChar(03B66B60);
			num = 1260547630U * num;
			this.44FF41FF = c;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0021F624 File Offset: 0x0021F624
		public override 66026065.61781FE7 5412D03B()
		{
			return new 66026065.152602F0(this.D02DFB88());
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0021F9E0 File Offset: 0x0021F9E0
		public override sbyte 3B8993E9()
		{
			uint num = 77297114U;
			num &= 2054380867U;
			return (sbyte)this.44FF41FF;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0021FA04 File Offset: 0x0021FA04
		public override byte 701A708C()
		{
			uint num = 818963447U;
			num = (737551239U | num);
			return (byte)this.44FF41FF;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0021FA28 File Offset: 0x0021FA28
		public override short D496EFA1()
		{
			return (short)this.44FF41FF;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0021FA44 File Offset: 0x0021FA44
		public override ushort EF893D1B()
		{
			return (ushort)this.44FF41FF;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0021FA44 File Offset: 0x0021FA44
		public override int D02DFB88()
		{
			return (int)this.44FF41FF;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0021FA44 File Offset: 0x0021FA44
		public override uint 45E9448C()
		{
			return (uint)this.44FF41FF;
		}

		// Token: 0x04000116 RID: 278
		private char 44FF41FF;
	}

	// Token: 0x0200002A RID: 42
	private sealed class 3A541C87 : 66026065.28060A8C
	{
		// Token: 0x060001ED RID: 493 RVA: 0x0021FA58 File Offset: 0x0021FA58
		public 3A541C87(byte 08C76E2E)
		{
			uint num = 1635593759U;
			do
			{
				base..ctor();
				if ((212665628U ^ num) == 0U)
				{
					break;
				}
				this.4C4379D3 = 08C76E2E;
			}
			while (num == 1574271796U);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0021FA90 File Offset: 0x0021FA90
		public override Type 36A9B5E8()
		{
			return typeof(byte);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0021FAA8 File Offset: 0x0021FAA8
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 2118021141U;
			byte 08C76E2E = this.4C4379D3;
			num <<= 30;
			return new 66026065.3A541C87(08C76E2E);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0021FAD0 File Offset: 0x0021FAD0
		public override object 6DCA9058()
		{
			return this.4C4379D3;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0021FAF0 File Offset: 0x0021FAF0
		public override void 5F352F29(object 57794746)
		{
			this.4C4379D3 = Convert.ToByte(57794746);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0021F624 File Offset: 0x0021F624
		public override 66026065.61781FE7 5412D03B()
		{
			return new 66026065.152602F0(this.D02DFB88());
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0021FB0C File Offset: 0x0021FB0C
		public override sbyte 3B8993E9()
		{
			uint num = 1579426355U;
			num += 726673849U;
			return (sbyte)this.4C4379D3;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0021FB30 File Offset: 0x0021FB30
		public override byte 701A708C()
		{
			return this.4C4379D3;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0021FB30 File Offset: 0x0021FB30
		public override short D496EFA1()
		{
			return (short)this.4C4379D3;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0021FB30 File Offset: 0x0021FB30
		public override ushort EF893D1B()
		{
			return (ushort)this.4C4379D3;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0021FB30 File Offset: 0x0021FB30
		public override int D02DFB88()
		{
			return (int)this.4C4379D3;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0021FB30 File Offset: 0x0021FB30
		public override uint 45E9448C()
		{
			return (uint)this.4C4379D3;
		}

		// Token: 0x04000117 RID: 279
		private byte 4C4379D3;
	}

	// Token: 0x0200002B RID: 43
	private sealed class 4E7A3FAE : 66026065.28060A8C
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x0021FB44 File Offset: 0x0021FB44
		public 4E7A3FAE(sbyte 490A56BD)
		{
			uint num;
			do
			{
				base..ctor();
				num = 1096697180U;
				this.52F234FA = 490A56BD;
			}
			while (num == 1386571714U);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0021FB70 File Offset: 0x0021FB70
		public override Type 36A9B5E8()
		{
			return typeof(sbyte);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0021FB90 File Offset: 0x0021FB90
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 1196120868U;
			num = 1213495472U * num;
			return new 66026065.4E7A3FAE(this.52F234FA);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0021FBB8 File Offset: 0x0021FBB8
		public override object 6DCA9058()
		{
			return this.52F234FA;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0021FBD8 File Offset: 0x0021FBD8
		public override void 5F352F29(object 2E406C14)
		{
			this.52F234FA = Convert.ToSByte(2E406C14);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0021F624 File Offset: 0x0021F624
		public override 66026065.61781FE7 5412D03B()
		{
			return new 66026065.152602F0(this.D02DFB88());
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0021FBF4 File Offset: 0x0021FBF4
		public override sbyte 3B8993E9()
		{
			return this.52F234FA;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0021FC08 File Offset: 0x0021FC08
		public override byte 701A708C()
		{
			return (byte)this.52F234FA;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0021FBF4 File Offset: 0x0021FBF4
		public override short D496EFA1()
		{
			return (short)this.52F234FA;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0021FC24 File Offset: 0x0021FC24
		public override ushort EF893D1B()
		{
			uint num = 308368445U;
			ushort num2 = (ushort)this.52F234FA;
			num -= 92362198U;
			return num2;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0021FBF4 File Offset: 0x0021FBF4
		public override int D02DFB88()
		{
			return (int)this.52F234FA;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0021FBF4 File Offset: 0x0021FBF4
		public override uint 45E9448C()
		{
			return (uint)this.52F234FA;
		}

		// Token: 0x04000118 RID: 280
		private sbyte 52F234FA;
	}

	// Token: 0x0200002C RID: 44
	private sealed class 23EE4D1F : 66026065.28060A8C
	{
		// Token: 0x06000205 RID: 517 RVA: 0x0021FC48 File Offset: 0x0021FC48
		public 23EE4D1F(uint 0FD36B8F)
		{
			uint num = 2127580454U;
			do
			{
				num *= 36994028U;
				base..ctor();
			}
			while (1921065669U > num);
			num ^= 640952666U;
			num |= 544417895U;
			this.5C8E596C = 0FD36B8F;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0021FC8C File Offset: 0x0021FC8C
		public override Type 36A9B5E8()
		{
			return typeof(uint);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0021FCAC File Offset: 0x0021FCAC
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 233055703U;
			uint 0FD36B8F = this.5C8E596C;
			num >>= 8;
			return new 66026065.23EE4D1F(0FD36B8F);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0021FCD4 File Offset: 0x0021FCD4
		public override object 6DCA9058()
		{
			uint num = 1279869622U;
			num %= 891817957U;
			return this.5C8E596C;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0021FCFC File Offset: 0x0021FCFC
		public override void 5F352F29(object 10C34C1F)
		{
			uint num = 888892739U;
			do
			{
				num &= 569128504U;
				num <<= 23;
				this.5C8E596C = Convert.ToUInt32(10C34C1F);
			}
			while (1332628122U == num);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0021F624 File Offset: 0x0021F624
		public override 66026065.61781FE7 5412D03B()
		{
			return new 66026065.152602F0(this.D02DFB88());
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0021FD38 File Offset: 0x0021FD38
		public override sbyte 3B8993E9()
		{
			uint num = 943746750U;
			sbyte b = (sbyte)this.5C8E596C;
			num = 1634422872U >> (int)num;
			return b;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0021FD60 File Offset: 0x0021FD60
		public override byte 701A708C()
		{
			return (byte)this.5C8E596C;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0021FD74 File Offset: 0x0021FD74
		public override short D496EFA1()
		{
			uint num = 532424399U;
			num &= 246228239U;
			return (short)this.5C8E596C;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0021FD98 File Offset: 0x0021FD98
		public override ushort EF893D1B()
		{
			return (ushort)this.5C8E596C;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0021FDB4 File Offset: 0x0021FDB4
		public override int D02DFB88()
		{
			return (int)this.5C8E596C;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0021FDB4 File Offset: 0x0021FDB4
		public override uint 45E9448C()
		{
			return this.5C8E596C;
		}

		// Token: 0x04000119 RID: 281
		private uint 5C8E596C;
	}

	// Token: 0x0200002D RID: 45
	private sealed class 374343A0 : 66026065.28060A8C
	{
		// Token: 0x06000211 RID: 529 RVA: 0x0021FDD0 File Offset: 0x0021FDD0
		public 374343A0(ulong 034E529E)
		{
			uint num = 400102104U;
			base..ctor();
			if (60779762U % num != 0U)
			{
				this.270E6DC7 = 034E529E;
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0021FDFC File Offset: 0x0021FDFC
		public override Type 36A9B5E8()
		{
			return typeof(ulong);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0021FE14 File Offset: 0x0021FE14
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 1220482460U;
			ulong 034E529E = this.270E6DC7;
			num = 248205553U - num;
			return new 66026065.374343A0(034E529E);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0021FE3C File Offset: 0x0021FE3C
		public override object 6DCA9058()
		{
			uint num = 2035291169U;
			num %= 1084968778U;
			return this.270E6DC7;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0021FE64 File Offset: 0x0021FE64
		public override void 5F352F29(object 43917640)
		{
			uint num = 260270793U;
			ulong num2 = Convert.ToUInt64(43917640);
			num = 926117378U >> (int)num;
			this.270E6DC7 = num2;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0021FE94 File Offset: 0x0021FE94
		public override 66026065.61781FE7 5412D03B()
		{
			uint num = 456199009U;
			num >>= 3;
			long 156A0AAB = this.E7FBC3B9();
			num = (1462780999U ^ num);
			return new 66026065.6DA9264D(156A0AAB);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0021FEC4 File Offset: 0x0021FEC4
		public override sbyte 3B8993E9()
		{
			uint num = 1853510436U;
			sbyte b = (sbyte)this.270E6DC7;
			num >>= 6;
			return b;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0021FEE8 File Offset: 0x0021FEE8
		public override byte 701A708C()
		{
			return (byte)this.270E6DC7;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0021FF04 File Offset: 0x0021FF04
		public override short D496EFA1()
		{
			return (short)this.270E6DC7;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0021FF20 File Offset: 0x0021FF20
		public override ushort EF893D1B()
		{
			uint num = 2074283280U;
			ushort num2 = (ushort)this.270E6DC7;
			num %= 1068761930U;
			return num2;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0021FF44 File Offset: 0x0021FF44
		public override int D02DFB88()
		{
			return (int)this.270E6DC7;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0021FF60 File Offset: 0x0021FF60
		public override uint 45E9448C()
		{
			uint num = 265781200U;
			uint num2 = (uint)this.270E6DC7;
			num = 510331191U >> (int)num;
			return num2;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0021FF88 File Offset: 0x0021FF88
		public override long E7FBC3B9()
		{
			return (long)this.270E6DC7;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0021FF88 File Offset: 0x0021FF88
		public override ulong 6100687B()
		{
			return this.270E6DC7;
		}

		// Token: 0x0400011A RID: 282
		private ulong 270E6DC7;
	}

	// Token: 0x0200002E RID: 46
	private sealed class 332067BD : 66026065.61781FE7
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0021FFA4 File Offset: 0x0021FFA4
		public 332067BD(object 085C45CB)
		{
			this.075C03CD = 085C45CB;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0021FFC0 File Offset: 0x0021FFC0
		public override Type 36A9B5E8()
		{
			return typeof(object);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0020E4A0 File Offset: 0x0020E4A0
		public override TypeCode 04C738A1()
		{
			return TypeCode.Object;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0021FFE0 File Offset: 0x0021FFE0
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.332067BD(this.075C03CD);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00220000 File Offset: 0x00220000
		public override object 6DCA9058()
		{
			uint num = 424026877U;
			num = 1066226353U >> (int)num;
			return this.075C03CD;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00220028 File Offset: 0x00220028
		public override void 5F352F29(object 5F8A4C52)
		{
			this.075C03CD = 5F8A4C52;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00220044 File Offset: 0x00220044
		public override bool AE4D32F2()
		{
			return this.075C03CD != null;
		}

		// Token: 0x0400011B RID: 283
		private object 075C03CD;
	}

	// Token: 0x0200002F RID: 47
	private sealed class 30C00244 : 66026065.61781FE7
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00220060 File Offset: 0x00220060
		public 30C00244(object 15D532E3, Type 48732EC7)
		{
			uint num;
			do
			{
				num = 1870739939U;
				base..ctor();
				num = 614885059U >> (int)num;
			}
			while ((num ^ 231606761U) == 0U);
			do
			{
				num |= 487198614U;
				this.6CBE699C = 15D532E3;
				num = 633298199U + num;
				this.56B13E91 = 48732EC7;
				num *= 467017389U;
			}
			while (num + 1129075564U == 0U);
			num ^= 1319986517U;
			this.2B08250C = 66026065.30C00244.070F455A(15D532E3);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x002200DC File Offset: 0x002200DC
		private static 66026065.28060A8C 070F455A(object 7F315A71)
		{
			uint num;
			IntPtr intPtr2;
			for (;;)
			{
				if (7F315A71 != null)
				{
					goto IL_06;
				}
				IntPtr intPtr = IntPtr.Zero;
				num = 1672683853U;
				IL_27:
				intPtr2 = intPtr;
				num *= 1952331496U;
				if ((167332590U & num) != 0U)
				{
					int size = IntPtr.Size;
					num |= 668075941U;
					uint num2 = num - 1743941609U;
					num >>= 24;
					if (size == num2)
					{
						break;
					}
					num /= 582249548U;
					if (num != 1183588434U)
					{
						goto Block_2;
					}
					continue;
				}
				IL_06:
				num = 1672683853U;
				intPtr = new IntPtr(Pointer.Unbox(7F315A71));
				goto IL_27;
			}
			num = (1536380037U ^ num);
			num >>= 31;
			return new 66026065.152602F0(intPtr2.ToInt32());
			Block_2:
			return new 66026065.6DA9264D(intPtr2.ToInt64());
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0021FFC0 File Offset: 0x0021FFC0
		public override Type 36A9B5E8()
		{
			return typeof(object);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00220184 File Offset: 0x00220184
		public Type 3A6449B8()
		{
			return this.56B13E91;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x002201A0 File Offset: 0x002201A0
		public override TypeCode 04C738A1()
		{
			uint num = 483924246U;
			int size = IntPtr.Size;
			num /= 1955101838U;
			uint num2 = num - 4294967292U;
			num = 1187133284U - num;
			if (size != num2)
			{
				return (TypeCode)(num ^ 1187133288U);
			}
			return (TypeCode)(num ^ 1187133294U);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x002201E4 File Offset: 0x002201E4
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 555381978U;
			object 15D532E = this.6CBE699C;
			Type 48732EC = this.56B13E91;
			num = 368062937U * num;
			return new 66026065.30C00244(15D532E, 48732EC);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00220210 File Offset: 0x00220210
		public override object 6DCA9058()
		{
			return this.6CBE699C;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0022022C File Offset: 0x0022022C
		public override void 5F352F29(object 1F2759D4)
		{
			uint num;
			do
			{
				num = 439484643U;
				this.6CBE699C = 1F2759D4;
				if (num > 781464364U)
				{
					break;
				}
				num <<= 0;
				66026065.28060A8C 28060A8C = 66026065.30C00244.070F455A(1F2759D4);
				num = 1135500146U + num;
				this.2B08250C = 28060A8C;
			}
			while ((546311788U ^ num) == 0U);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0022027C File Offset: 0x0022027C
		public override bool AE4D32F2()
		{
			return this.6CBE699C != null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00220294 File Offset: 0x00220294
		public override sbyte 3B8993E9()
		{
			uint num = 1556562724U;
			66026065.28060A8C 28060A8C = this.2B08250C;
			num = 1304695445U + num;
			return 28060A8C.3B8993E9();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x002202BC File Offset: 0x002202BC
		public override short D496EFA1()
		{
			return this.2B08250C.D496EFA1();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x002202DC File Offset: 0x002202DC
		public override int D02DFB88()
		{
			uint num = 999573609U;
			num |= 1728018807U;
			66026065.28060A8C 28060A8C = this.2B08250C;
			num /= 435845070U;
			return 28060A8C.D02DFB88();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0022030C File Offset: 0x0022030C
		public override long E7FBC3B9()
		{
			uint num = 1838765185U;
			num <<= 1;
			66026065.28060A8C 28060A8C = this.2B08250C;
			num = 1957957010U << (int)num;
			return 28060A8C.E7FBC3B9();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00220340 File Offset: 0x00220340
		public override byte 701A708C()
		{
			uint num = 825889931U;
			num = (1645612322U | num);
			return this.2B08250C.701A708C();
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00220368 File Offset: 0x00220368
		public override ushort EF893D1B()
		{
			uint num = 1367958015U;
			66026065.28060A8C 28060A8C = this.2B08250C;
			num = 1660430364U / num;
			return 28060A8C.EF893D1B();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00220390 File Offset: 0x00220390
		public override uint 45E9448C()
		{
			return this.2B08250C.45E9448C();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x002203B0 File Offset: 0x002203B0
		public override ulong 6100687B()
		{
			uint num = 949037293U;
			num = 1187345065U % num;
			66026065.28060A8C 28060A8C = this.2B08250C;
			num >>= 15;
			return 28060A8C.6100687B();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x002203E0 File Offset: 0x002203E0
		public override float 88D23451()
		{
			return this.2B08250C.88D23451();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x002203F8 File Offset: 0x002203F8
		public override double B1479B35()
		{
			return this.2B08250C.B1479B35();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00220418 File Offset: 0x00220418
		public override IntPtr 8ACF22C2()
		{
			return this.2B08250C.8ACF22C2();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00220438 File Offset: 0x00220438
		public override UIntPtr 16A92427()
		{
			return this.2B08250C.16A92427();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00220458 File Offset: 0x00220458
		public override object F7157180(Type 2ACD2294, bool 721C3A1D)
		{
			uint num = 74143236U;
			66026065.28060A8C 28060A8C = this.2B08250C;
			num = 1932490787U - num;
			return 28060A8C.F7157180(2ACD2294, 721C3A1D);
		}

		// Token: 0x0400011C RID: 284
		private object 6CBE699C;

		// Token: 0x0400011D RID: 285
		private Type 56B13E91;

		// Token: 0x0400011E RID: 286
		private 66026065.28060A8C 2B08250C;
	}

	// Token: 0x02000030 RID: 48
	private sealed class 35B110E2 : 66026065.61781FE7
	{
		// Token: 0x0600023C RID: 572 RVA: 0x00220480 File Offset: 0x00220480
		public 35B110E2(object 7C65154C)
		{
			uint num = 1128924887U;
			for (;;)
			{
				num /= 1780307991U;
				base..ctor();
				if (num % 1485995569U == 0U)
				{
					num = 741761126U * num;
					if (7C65154C != null)
					{
						num += 890272850U;
						for (;;)
						{
							num = (102173996U & num);
							bool flag = 7C65154C is ValueType;
							num ^= 68160512U;
							if (flag)
							{
								break;
							}
							if ((num & 2079214440U) == 0U)
							{
								goto Block_4;
							}
						}
					}
					num |= 1518631495U;
					if ((207757555U & num) != 0U)
					{
						num = 612924474U - num;
						this.2442619E = 7C65154C;
						if (179714542U * num != 0U)
						{
							return;
						}
					}
				}
			}
			Block_4:
			throw new ArgumentException();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00220520 File Offset: 0x00220520
		public override Type 36A9B5E8()
		{
			uint num = 2066507663U;
			RuntimeTypeHandle handle = typeof(ValueType).TypeHandle;
			num = (1860784756U | num);
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00220548 File Offset: 0x00220548
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.35B110E2(this.2442619E);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00220568 File Offset: 0x00220568
		public override object 6DCA9058()
		{
			return this.2442619E;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00220584 File Offset: 0x00220584
		public override void 5F352F29(object 003306DA)
		{
			for (;;)
			{
				uint num = 1770288921U;
				if (003306DA == null)
				{
					goto IL_5A;
				}
				num = 734462942U << (int)num;
				if (num != 2071473353U)
				{
					bool flag = 003306DA is ValueType;
					num = 209808197U + num;
					num ^= 2701466716U;
					if (flag)
					{
						goto IL_5A;
					}
					num |= 1091907971U;
					if ((464663301U ^ num) != 0U)
					{
						break;
					}
				}
			}
			throw new ArgumentException();
			IL_5A:
			this.2442619E = 003306DA;
		}

		// Token: 0x0400011F RID: 287
		private object 2442619E;
	}

	// Token: 0x02000031 RID: 49
	private sealed class 2BBE3DF2 : 66026065.61781FE7
	{
		// Token: 0x06000241 RID: 577 RVA: 0x002205F4 File Offset: 0x002205F4
		public 2BBE3DF2(Array 100B3053)
		{
			uint num;
			do
			{
				base..ctor();
				num = 1784960137U;
			}
			while (1012821111 << (int)num == 0);
			num /= 300578805U;
			num -= 1848856354U;
			this.39A80F3F = 100B3053;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00220638 File Offset: 0x00220638
		public override Type 36A9B5E8()
		{
			return typeof(Array);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00220658 File Offset: 0x00220658
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 751126613U;
			num |= 174741815U;
			return new 66026065.2BBE3DF2(this.39A80F3F);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00220680 File Offset: 0x00220680
		public override object 6DCA9058()
		{
			return this.39A80F3F;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00220694 File Offset: 0x00220694
		public override void 5F352F29(object 39B11521)
		{
			this.39A80F3F = (Array)39B11521;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x002206B0 File Offset: 0x002206B0
		public override bool AE4D32F2()
		{
			uint num = 1759852042U;
			object obj = this.39A80F3F;
			num /= 1434481366U;
			return obj != null;
		}

		// Token: 0x04000120 RID: 288
		private Array 39A80F3F;
	}

	// Token: 0x02000032 RID: 50
	private abstract class 4DE278F2 : 66026065.61781FE7
	{
		// Token: 0x06000247 RID: 583 RVA: 0x0020E4A0 File Offset: 0x0020E4A0
		public override bool 55CDE352()
		{
			return true;
		}
	}

	// Token: 0x02000033 RID: 51
	private sealed class 1348406A : 66026065.4DE278F2
	{
		// Token: 0x06000249 RID: 585 RVA: 0x002206E8 File Offset: 0x002206E8
		public 1348406A(66026065.28060A8C 188635D9)
		{
			uint num = 1570007489U;
			num = 1904961528U % num;
			base..ctor();
			num = 1986405358U * num;
			this.175144C7 = 188635D9;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00220718 File Offset: 0x00220718
		public override Type 36A9B5E8()
		{
			return this.175144C7.36A9B5E8();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00220730 File Offset: 0x00220730
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 925787585U;
			num = 1783369887U - num;
			return new 66026065.1348406A(this.175144C7);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00220758 File Offset: 0x00220758
		public override object 6DCA9058()
		{
			uint num = 690971790U;
			num = 1866030839U - num;
			return this.175144C7.6DCA9058();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00220780 File Offset: 0x00220780
		public override void 5F352F29(object 605D3F08)
		{
			uint num = 380400565U;
			if (713425058U >> (int)num != 0U)
			{
				66026065.28060A8C 28060A8C = this.175144C7;
				num ^= 812078597U;
				28060A8C.5F352F29(605D3F08);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x002207BC File Offset: 0x002207BC
		public override bool AE4D32F2()
		{
			return this.175144C7 != null;
		}

		// Token: 0x04000121 RID: 289
		private 66026065.28060A8C 175144C7;
	}

	// Token: 0x02000034 RID: 52
	private sealed class 1FE710AC : 66026065.4DE278F2
	{
		// Token: 0x0600024F RID: 591 RVA: 0x002207D4 File Offset: 0x002207D4
		public 1FE710AC(66026065.28060A8C 71DE45FC, 66026065.28060A8C 6BF636B8)
		{
			uint num = 1129410365U;
			do
			{
				num = (676799483U | num);
				this.726A5418 = 71DE45FC;
				num = 169681846U << (int)num;
			}
			while (num >= 1672434452U);
			num = 387270729U - num;
			num -= 1938962665U;
			this.733A6986 = 6BF636B8;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0022082C File Offset: 0x0022082C
		public override Type 36A9B5E8()
		{
			return this.726A5418.36A9B5E8();
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0022084C File Offset: 0x0022084C
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 60240476U;
			num = (1274969417U ^ num);
			66026065.28060A8C 71DE45FC = this.726A5418;
			num %= 1158631196U;
			num = 1012992573U / num;
			66026065.28060A8C 6BF636B = this.733A6986;
			num += 356189529U;
			return new 66026065.1FE710AC(71DE45FC, 6BF636B);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00220890 File Offset: 0x00220890
		public override object 6DCA9058()
		{
			uint num = 396646086U;
			num = 31722096U / num;
			return this.726A5418.6DCA9058();
		}

		// Token: 0x06000253 RID: 595 RVA: 0x002208B8 File Offset: 0x002208B8
		public override void 5F352F29(object 75501E1D)
		{
			uint num = 17326043U;
			if (num <= 974671155U)
			{
				num = 677932642U * num;
				66026065.28060A8C 28060A8C = this.726A5418;
				num = 836120674U % num;
				28060A8C.5F352F29(75501E1D);
				num |= 927008715U;
				num = 506611241U % num;
				66026065.28060A8C 28060A8C2 = this.733A6986;
				num = (456992207U ^ num);
				28060A8C2.5F352F29(this.726A5418.6DCA9058());
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00220920 File Offset: 0x00220920
		public override bool AE4D32F2()
		{
			uint num = 481839785U;
			66026065.28060A8C 28060A8C = this.726A5418;
			object obj = null;
			num = 886048442U - num;
			return 28060A8C > obj;
		}

		// Token: 0x04000122 RID: 290
		private 66026065.28060A8C 726A5418;

		// Token: 0x04000123 RID: 291
		private 66026065.28060A8C 733A6986;
	}

	// Token: 0x02000035 RID: 53
	private sealed class 6AFE5B30 : 66026065.4DE278F2
	{
		// Token: 0x06000255 RID: 597 RVA: 0x00220944 File Offset: 0x00220944
		public 6AFE5B30(FieldInfo 07BC39E1, object 2E855812)
		{
			uint num;
			do
			{
				num = 1332028298U;
				base..ctor();
				num = 352782223U * num;
				if ((num ^ 2141849046U) == 0U)
				{
					break;
				}
				this.53732AF5 = 07BC39E1;
				num = (1188431869U & num);
				if (1644109517U / num == 0U)
				{
					break;
				}
				this.318353C7 = 2E855812;
			}
			while (num << 24 == 0U);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x002209A0 File Offset: 0x002209A0
		public override Type 36A9B5E8()
		{
			return this.53732AF5.FieldType;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x002209C0 File Offset: 0x002209C0
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.6AFE5B30(this.53732AF5, this.318353C7);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x002209E4 File Offset: 0x002209E4
		public override object 6DCA9058()
		{
			return this.53732AF5.GetValue(this.318353C7);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00220A08 File Offset: 0x00220A08
		public override void 5F352F29(object 0AEF51F7)
		{
			FieldInfo fieldInfo = this.53732AF5;
			object obj = this.318353C7;
			uint num = 622617761U;
			num %= 1067802085U;
			fieldInfo.SetValue(obj, 0AEF51F7);
		}

		// Token: 0x04000124 RID: 292
		private FieldInfo 53732AF5;

		// Token: 0x04000125 RID: 293
		private object 318353C7;
	}

	// Token: 0x02000036 RID: 54
	private sealed class 739E46E3 : 66026065.4DE278F2
	{
		// Token: 0x0600025A RID: 602 RVA: 0x00220A38 File Offset: 0x00220A38
		public 739E46E3(Array 20A714D5, int 7F4648B1)
		{
			uint num = 1029191294U;
			if (939086742U - num != 0U)
			{
				num = 64950862U - num;
				num = 1818374804U % num;
				this.41537A34 = 20A714D5;
				num ^= 753557695U;
			}
			this.1DDF1228 = 7F4648B1;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00220A84 File Offset: 0x00220A84
		public override Type 36A9B5E8()
		{
			return this.41537A34.GetType().GetElementType();
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00220AA8 File Offset: 0x00220AA8
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 1077312734U;
			Array 20A714D = this.41537A34;
			num = 778927046U - num;
			int 7F4648B = this.1DDF1228;
			num = (965152459U & num);
			return new 66026065.739E46E3(20A714D, 7F4648B);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00220ADC File Offset: 0x00220ADC
		public override object 6DCA9058()
		{
			uint num = 92890948U;
			Array array = this.41537A34;
			num %= 450786420U;
			return array.GetValue(this.1DDF1228);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00220B08 File Offset: 0x00220B08
		public override void 5F352F29(object 79290CC5)
		{
			Array array = this.41537A34;
			uint num = 338823204U;
			num <<= 18;
			int index = this.1DDF1228;
			num = (1258432613U & num);
			array.SetValue(79290CC5, index);
		}

		// Token: 0x04000126 RID: 294
		private Array 41537A34;

		// Token: 0x04000127 RID: 295
		private int 1DDF1228;
	}

	// Token: 0x02000037 RID: 55
	private sealed class 78DF15B2 : 66026065.61781FE7
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00220B40 File Offset: 0x00220B40
		public 78DF15B2(MethodBase 39455996)
		{
			this.46676AFD = 39455996;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00220B60 File Offset: 0x00220B60
		public override Type 36A9B5E8()
		{
			return typeof(MethodBase);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00220B80 File Offset: 0x00220B80
		public override 66026065.28060A8C 1368930D()
		{
			return new 66026065.78DF15B2(this.46676AFD);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00220BA0 File Offset: 0x00220BA0
		public override object 6DCA9058()
		{
			return this.46676AFD;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00220BB4 File Offset: 0x00220BB4
		public override void 5F352F29(object 2BF45D97)
		{
			uint num = 718144987U;
			num = (292622973U ^ num);
			num -= 832337474U;
			MethodBase methodBase = (MethodBase)2BF45D97;
			num = 1740665102U << (int)num;
			this.46676AFD = methodBase;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00220BF4 File Offset: 0x00220BF4
		public override bool AE4D32F2()
		{
			uint num = 380183117U;
			MethodBase methodBase = this.46676AFD;
			object obj = null;
			num = 530405660U >> (int)num;
			return methodBase > obj;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00220C20 File Offset: 0x00220C20
		public override IntPtr 8ACF22C2()
		{
			uint num;
			RuntimeMethodHandle runtimeMethodHandle;
			do
			{
				num = 1614485944U;
				RuntimeMethodHandle methodHandle = this.46676AFD.MethodHandle;
				num -= 1695117424U;
				runtimeMethodHandle = methodHandle;
			}
			while (num <= 716326859U);
			return runtimeMethodHandle.GetFunctionPointer();
		}

		// Token: 0x04000128 RID: 296
		private MethodBase 46676AFD;
	}

	// Token: 0x02000038 RID: 56
	private sealed class 17975C69 : 66026065.61781FE7
	{
		// Token: 0x06000266 RID: 614 RVA: 0x00220C5C File Offset: 0x00220C5C
		public 17975C69(IntPtr 610560FE)
		{
			uint num = 1207056538U;
			if (num != 1698771197U)
			{
				base..ctor();
				if (num * 2104580826U != 0U)
				{
					do
					{
						num = 664171482U >> (int)num;
						this.2F532F71 = 610560FE;
						num >>= 19;
						num = (144663708U ^ num);
						this.7D917D76 = 66026065.17975C69.21020138(this.2F532F71);
					}
					while (num == 1586382382U);
				}
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00220CD0 File Offset: 0x00220CD0
		private static 66026065.28060A8C 21020138(IntPtr 60E607E4)
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 1611220766U;
			if (size != num)
			{
				num2 %= 493882195U;
				if ((num2 & 1415644157U) != 0U)
				{
					return new 66026065.6DA9264D(60E607E4.ToInt64());
				}
			}
			num2 = 1201214219U + num2;
			return new 66026065.152602F0(60E607E4.ToInt32());
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00220D24 File Offset: 0x00220D24
		public override Type 36A9B5E8()
		{
			return typeof(IntPtr);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00220D44 File Offset: 0x00220D44
		public override TypeCode 04C738A1()
		{
			return this.7D917D76.04C738A1();
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00220D64 File Offset: 0x00220D64
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 2043809611U;
			IntPtr 610560FE = this.2F532F71;
			num = 2103201932U << (int)num;
			return new 66026065.17975C69(610560FE);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00220D90 File Offset: 0x00220D90
		public override object 6DCA9058()
		{
			return this.2F532F71;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00220DA8 File Offset: 0x00220DA8
		public override void 5F352F29(object 6C3C0AED)
		{
			uint num;
			do
			{
				this.2F532F71 = (IntPtr)6C3C0AED;
				num = 299706961U;
				if (num > 382488538U)
				{
					break;
				}
				num = (2099392974U ^ num);
				IntPtr 60E607E = this.2F532F71;
				num >>= 26;
				66026065.28060A8C 28060A8C = 66026065.17975C69.21020138(60E607E);
				num += 1965709077U;
				this.7D917D76 = 28060A8C;
			}
			while (num < 1112884029U);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00220E08 File Offset: 0x00220E08
		public override bool AE4D32F2()
		{
			uint num = 2063534849U;
			IntPtr value = this.2F532F71;
			IntPtr zero = IntPtr.Zero;
			num -= 14244216U;
			return value != zero;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00220E34 File Offset: 0x00220E34
		public override sbyte 3B8993E9()
		{
			uint num = 973755852U;
			num = 1599829660U / num;
			66026065.28060A8C 28060A8C = this.7D917D76;
			num += 1331063141U;
			return 28060A8C.3B8993E9();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00220E64 File Offset: 0x00220E64
		public override short D496EFA1()
		{
			uint num = 1719877520U;
			num /= 1478826425U;
			return this.7D917D76.D496EFA1();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00220E8C File Offset: 0x00220E8C
		public override int D02DFB88()
		{
			uint num = 1439126629U;
			66026065.28060A8C 28060A8C = this.7D917D76;
			num |= 1794012206U;
			return 28060A8C.D02DFB88();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00220EB4 File Offset: 0x00220EB4
		public override long E7FBC3B9()
		{
			return this.7D917D76.E7FBC3B9();
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00220ED4 File Offset: 0x00220ED4
		public override byte 701A708C()
		{
			return this.7D917D76.701A708C();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00220EF4 File Offset: 0x00220EF4
		public override ushort EF893D1B()
		{
			uint num = 1760301571U;
			66026065.28060A8C 28060A8C = this.7D917D76;
			num = 1884842197U + num;
			return 28060A8C.EF893D1B();
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00220F1C File Offset: 0x00220F1C
		public override uint 45E9448C()
		{
			uint num = 597244145U;
			num = 1331045641U + num;
			return this.7D917D76.45E9448C();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00220F44 File Offset: 0x00220F44
		public override ulong 6100687B()
		{
			return this.7D917D76.6100687B();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00220F5C File Offset: 0x00220F5C
		public override float 88D23451()
		{
			return this.7D917D76.88D23451();
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00220F7C File Offset: 0x00220F7C
		public override double B1479B35()
		{
			uint num = 1740135738U;
			num = 1425101685U / num;
			66026065.28060A8C 28060A8C = this.7D917D76;
			num = (1670149924U ^ num);
			return 28060A8C.B1479B35();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00220FAC File Offset: 0x00220FAC
		public override IntPtr 8ACF22C2()
		{
			return this.2F532F71;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00220FC8 File Offset: 0x00220FC8
		public override UIntPtr 16A92427()
		{
			return this.7D917D76.16A92427();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00220FE0 File Offset: 0x00220FE0
		public override object F7157180(Type 049E2B6F, bool 7BBD7B42)
		{
			uint num = 897744802U;
			66026065.28060A8C 28060A8C = this.7D917D76;
			num += 301295682U;
			return 28060A8C.F7157180(049E2B6F, 7BBD7B42);
		}

		// Token: 0x04000129 RID: 297
		private IntPtr 2F532F71;

		// Token: 0x0400012A RID: 298
		private 66026065.28060A8C 7D917D76;
	}

	// Token: 0x02000039 RID: 57
	private sealed class 7DEE7F40 : 66026065.61781FE7
	{
		// Token: 0x0600027B RID: 635 RVA: 0x00221008 File Offset: 0x00221008
		public 7DEE7F40(UIntPtr 377D2CBF)
		{
			uint num = 1506697210U;
			base..ctor();
			if (630807500U != num)
			{
				num *= 63465472U;
				this.5A157533 = 377D2CBF;
				num = (2083724380U & num);
				if (num < 21066251U)
				{
					return;
				}
			}
			num = 422582983U % num;
			66026065.28060A8C 28060A8C = 66026065.7DEE7F40.298A3C9E(this.5A157533);
			num = 857941593U / num;
			this.67D76320 = 28060A8C;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00221070 File Offset: 0x00221070
		private static 66026065.28060A8C 298A3C9E(UIntPtr 54CB58E2)
		{
			uint num;
			for (;;)
			{
				int size = IntPtr.Size;
				num = 1783769618U;
				uint num2 = num + 2511197682U;
				num = 941051587U - num;
				if (size == num2)
				{
					break;
				}
				if (num >= 1885097599U)
				{
					goto Block_1;
				}
			}
			num = 1515395017U >> (int)num;
			num <<= 2;
			int 73704D = (int)54CB58E2.ToUInt32();
			num ^= 10297205U;
			return new 66026065.152602F0(73704D);
			Block_1:
			long 156A0AAB = (long)54CB58E2.ToUInt64();
			num &= 1067277033U;
			return new 66026065.6DA9264D(156A0AAB);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x002210E8 File Offset: 0x002210E8
		public override Type 36A9B5E8()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00221108 File Offset: 0x00221108
		public override TypeCode 04C738A1()
		{
			return this.67D76320.04C738A1();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00221128 File Offset: 0x00221128
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 983196022U;
			UIntPtr 377D2CBF = this.5A157533;
			num = 1448032977U * num;
			return new 66026065.7DEE7F40(377D2CBF);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00221150 File Offset: 0x00221150
		public override object 6DCA9058()
		{
			return this.5A157533;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00221168 File Offset: 0x00221168
		public override void 5F352F29(object 5CD85176)
		{
			uint num = 1799909037U;
			this.5A157533 = (UIntPtr)5CD85176;
			do
			{
				num = (506285212U & num);
				num = 1894339769U * num;
				UIntPtr 54CB58E = this.5A157533;
				num += 1308654119U;
				66026065.28060A8C 28060A8C = 66026065.7DEE7F40.298A3C9E(54CB58E);
				num = 319956617U / num;
				this.67D76320 = 28060A8C;
			}
			while ((num & 152641909U) != 0U);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x002211C4 File Offset: 0x002211C4
		public override bool AE4D32F2()
		{
			uint num = 130110214U;
			num = 1460693204U % num;
			UIntPtr value = this.5A157533;
			UIntPtr zero = UIntPtr.Zero;
			num = (122961144U & num);
			return value != zero;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x002211F8 File Offset: 0x002211F8
		public override sbyte 3B8993E9()
		{
			return this.67D76320.3B8993E9();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00221210 File Offset: 0x00221210
		public override short D496EFA1()
		{
			uint num = 1254231858U;
			num += 169749178U;
			return this.67D76320.D496EFA1();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00221238 File Offset: 0x00221238
		public override int D02DFB88()
		{
			uint num = 1517780811U;
			num ^= 1374641370U;
			return this.67D76320.D02DFB88();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00221260 File Offset: 0x00221260
		public override long E7FBC3B9()
		{
			return this.67D76320.E7FBC3B9();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00221278 File Offset: 0x00221278
		public override byte 701A708C()
		{
			uint num = 1744767246U;
			66026065.28060A8C 28060A8C = this.67D76320;
			num ^= 2103137550U;
			return 28060A8C.701A708C();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x002212A0 File Offset: 0x002212A0
		public override ushort EF893D1B()
		{
			uint num = 1272926628U;
			66026065.28060A8C 28060A8C = this.67D76320;
			num ^= 236914530U;
			return 28060A8C.EF893D1B();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x002212C8 File Offset: 0x002212C8
		public override uint 45E9448C()
		{
			uint num = 1998405670U;
			66026065.28060A8C 28060A8C = this.67D76320;
			num = 1146763390U + num;
			return 28060A8C.45E9448C();
		}

		// Token: 0x0600028A RID: 650 RVA: 0x002212F0 File Offset: 0x002212F0
		public override ulong 6100687B()
		{
			uint num = 815469413U;
			num *= 283011667U;
			return this.67D76320.6100687B();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00221318 File Offset: 0x00221318
		public override float 88D23451()
		{
			return this.67D76320.88D23451();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00221338 File Offset: 0x00221338
		public override double B1479B35()
		{
			return this.67D76320.B1479B35();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00221358 File Offset: 0x00221358
		public override IntPtr 8ACF22C2()
		{
			return this.67D76320.8ACF22C2();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00221378 File Offset: 0x00221378
		public override UIntPtr 16A92427()
		{
			return this.5A157533;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00221394 File Offset: 0x00221394
		public override object F7157180(Type 1E8A7131, bool 5B8405E8)
		{
			uint num = 316020049U;
			num = 224076996U >> (int)num;
			66026065.28060A8C 28060A8C = this.67D76320;
			num %= 865469371U;
			return 28060A8C.F7157180(1E8A7131, 5B8405E8);
		}

		// Token: 0x0400012B RID: 299
		private UIntPtr 5A157533;

		// Token: 0x0400012C RID: 300
		private 66026065.28060A8C 67D76320;
	}

	// Token: 0x0200003A RID: 58
	private sealed class 5A13537F : 66026065.61781FE7
	{
		// Token: 0x06000290 RID: 656 RVA: 0x002213CC File Offset: 0x002213CC
		public 5A13537F(Enum 010D580F)
		{
			uint num;
			for (;;)
			{
				num = 129724534U;
				base..ctor();
				if ((1509247086U ^ num) != 0U)
				{
					num /= 733419545U;
					if (010D580F == null)
					{
						break;
					}
				}
				num = 32265066U + num;
				num = 1750402127U % num;
				this.1FE64D5F = 010D580F;
				if (94663900U >> (int)num != 0U)
				{
					goto Block_2;
				}
			}
			num *= 1296369020U;
			throw new ArgumentException();
			Block_2:
			this.65125250 = 66026065.5A13537F.425D428E(this.1FE64D5F);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00221448 File Offset: 0x00221448
		private static 66026065.28060A8C 425D428E(Enum 6C7B3011)
		{
			uint num = 1279947363U;
			TypeCode typeCode = 6C7B3011.GetTypeCode();
			num = (1824284240U & num);
			if (num >= 1204624912U)
			{
				for (;;)
				{
					uint num2 = (uint)typeCode;
					num = (1383216232U | num);
					uint num3 = num2 - (num ^ 1585084013U);
					num %= 779496031U;
					switch (num3)
					{
					case 0:
					case 2:
					case 4:
						goto IL_7F;
					case 1:
					case 3:
					case 5:
						goto IL_63;
					case 6:
						num = 2033481358U + num;
						if (num < 2099715906U)
						{
							goto Block_2;
						}
						continue;
					case 7:
						goto IL_A3;
					}
					break;
				}
				throw new InvalidOperationException();
				IL_63:
				num = 1297245644U / num;
				int 73704D = (int)Convert.ToUInt32(6C7B3011);
				num <<= 11;
				return new 66026065.152602F0(73704D);
				IL_A3:
				num = 1524780244U << (int)num;
				long 156A0AAB = (long)Convert.ToUInt64(6C7B3011);
				num = 962226655U % num;
				return new 66026065.6DA9264D(156A0AAB);
				Block_2:
				num /= 1480075698U;
				long 156A0AAB2 = Convert.ToInt64(6C7B3011);
				num = 838733115U << (int)num;
				return new 66026065.6DA9264D(156A0AAB2);
			}
			IL_7F:
			num ^= 1258301624U;
			num /= 1053126656U;
			int 73704D2 = Convert.ToInt32(6C7B3011);
			num += 534927943U;
			return new 66026065.152602F0(73704D2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00221554 File Offset: 0x00221554
		public override 66026065.28060A8C 31D8F335()
		{
			uint num = 870021897U;
			num = 1024337539U >> (int)num;
			66026065.28060A8C 28060A8C = this.65125250;
			num |= 1703495255U;
			return 28060A8C.31D8F335();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00221588 File Offset: 0x00221588
		public override Type 36A9B5E8()
		{
			return this.1FE64D5F.GetType();
		}

		// Token: 0x06000294 RID: 660 RVA: 0x002215A0 File Offset: 0x002215A0
		public override TypeCode 04C738A1()
		{
			uint num = 1793736963U;
			66026065.28060A8C 28060A8C = this.65125250;
			num = 576810949U + num;
			return 28060A8C.04C738A1();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x002215C8 File Offset: 0x002215C8
		public override 66026065.28060A8C 1368930D()
		{
			uint num = 1935830282U;
			Enum 010D580F = this.1FE64D5F;
			num |= 2080325629U;
			return new 66026065.5A13537F(010D580F);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x002215F0 File Offset: 0x002215F0
		public override object 6DCA9058()
		{
			uint num = 1239687651U;
			num <<= 21;
			return this.1FE64D5F;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00221614 File Offset: 0x00221614
		public override void 5F352F29(object 3B2D4EF0)
		{
			uint num = 593458275U;
			num %= 183983519U;
			if (3B2D4EF0 != null)
			{
				do
				{
					if (num <= 569841934U)
					{
						num = 882652508U * num;
						Enum @enum = (Enum)3B2D4EF0;
						num %= 91701265U;
						this.1FE64D5F = @enum;
						if (num - 752296889U == 0U)
						{
							goto IL_14;
						}
					}
					this.65125250 = 66026065.5A13537F.425D428E(this.1FE64D5F);
				}
				while (1688682203U < num);
				return;
			}
			IL_14:
			throw new ArgumentException();
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0022168C File Offset: 0x0022168C
		public override byte 701A708C()
		{
			return this.65125250.701A708C();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x002216AC File Offset: 0x002216AC
		public override sbyte 3B8993E9()
		{
			return this.65125250.3B8993E9();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x002216CC File Offset: 0x002216CC
		public override short D496EFA1()
		{
			return this.65125250.D496EFA1();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x002216EC File Offset: 0x002216EC
		public override ushort EF893D1B()
		{
			uint num = 1022771481U;
			66026065.28060A8C 28060A8C = this.65125250;
			num = 412296050U % num;
			return 28060A8C.EF893D1B();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00221714 File Offset: 0x00221714
		public override int D02DFB88()
		{
			uint num = 433092527U;
			66026065.28060A8C 28060A8C = this.65125250;
			num = 1122855898U + num;
			return 28060A8C.D02DFB88();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0022173C File Offset: 0x0022173C
		public override uint 45E9448C()
		{
			return this.65125250.45E9448C();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0022175C File Offset: 0x0022175C
		public override long E7FBC3B9()
		{
			uint num = 792162129U;
			num = 1508602906U + num;
			66026065.28060A8C 28060A8C = this.65125250;
			num = 681987753U << (int)num;
			return 28060A8C.E7FBC3B9();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00221790 File Offset: 0x00221790
		public override ulong 6100687B()
		{
			return this.65125250.6100687B();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x002217B0 File Offset: 0x002217B0
		public override float 88D23451()
		{
			uint num = 1465286100U;
			66026065.28060A8C 28060A8C = this.65125250;
			num *= 233258651U;
			return 28060A8C.88D23451();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x002217D8 File Offset: 0x002217D8
		public override double B1479B35()
		{
			uint num = 304629684U;
			num = 2107277095U - num;
			return this.65125250.B1479B35();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00221800 File Offset: 0x00221800
		public override IntPtr 8ACF22C2()
		{
			uint num = 519201764U;
			long value;
			if (521425190U < num || IntPtr.Size == (int)(num + 3775765536U))
			{
				num = 147198193U % num;
				if (num <= 160305478U)
				{
					num = 1767930952U * num;
					long num2 = (long)this.D02DFB88();
					num += 1044586757U;
					value = num2;
					num += 645095221U;
					goto IL_67;
				}
			}
			num /= 221389799U;
			value = this.E7FBC3B9();
			IL_67:
			return new IntPtr(value);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0022187C File Offset: 0x0022187C
		public override UIntPtr 16A92427()
		{
			uint num = 925453221U;
			while (IntPtr.Size != (int)(num - 925453217U))
			{
				num = 97345159U * num;
				if (num != 231146694U)
				{
					IL_2A:
					ulong value = this.6100687B();
					IL_5F:
					num = 1958485929U / num;
					return new UIntPtr(value);
				}
			}
			if (num != 1599105065U)
			{
				num <<= 4;
				ulong num2 = (ulong)this.45E9448C();
				num %= 1839817794U;
				ulong value = num2;
				num ^= 138750989U;
				goto IL_5F;
			}
			goto IL_2A;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x002218F8 File Offset: 0x002218F8
		public override object F7157180(Type 10524255, bool 45453F3E)
		{
			uint num = 962942501U;
			num = 390219258U / num;
			66026065.28060A8C 28060A8C = this.65125250;
			num = 1303648314U + num;
			num = 443645789U % num;
			num += 1195842681U;
			return 28060A8C.F7157180(10524255, 45453F3E);
		}

		// Token: 0x0400012D RID: 301
		private Enum 1FE64D5F;

		// Token: 0x0400012E RID: 302
		private 66026065.28060A8C 65125250;
	}

	// Token: 0x0200003B RID: 59
	private sealed class 6F802366 : 66026065.4DE278F2
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x00221938 File Offset: 0x00221938
		public 6F802366(IntPtr 76C33B30, Type 4F5157E5)
		{
			uint num = 1462253145U;
			base..ctor();
			num = 1661876354U >> (int)num;
			this.685738EE = 76C33B30;
			num >>= 12;
			this.56815975 = 4F5157E5;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00221978 File Offset: 0x00221978
		public override Type 36A9B5E8()
		{
			return typeof(Pointer);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0020E4B0 File Offset: 0x0020E4B0
		public override TypeCode 04C738A1()
		{
			return TypeCode.Empty;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00221998 File Offset: 0x00221998
		public override 66026065.28060A8C 1368930D()
		{
			IntPtr 76C33B = this.685738EE;
			uint num = 2131430179U;
			Type 4F5157E = this.56815975;
			num <<= 14;
			return new 66026065.6F802366(76C33B, 4F5157E);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x002219C4 File Offset: 0x002219C4
		public override object 6DCA9058()
		{
			uint num = 465350U;
			do
			{
				bool isValueType = this.56815975.IsValueType;
				num += 2124231719U;
				if (!isValueType)
				{
					goto IL_59;
				}
				num = 527050452U << (int)num;
			}
			while (721031407U > num);
			IL_37:
			num &= 769023906U;
			IntPtr ptr = this.685738EE;
			Type structureType = this.56815975;
			num = (1507414111U & num);
			return Marshal.PtrToStructure(ptr, structureType);
			IL_59:
			num = 1344037361U * num;
			if (num != 967722967U)
			{
				throw new InvalidOperationException();
			}
			goto IL_37;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00221A44 File Offset: 0x00221A44
		public override void 5F352F29(object 73B5324E)
		{
			uint num = 645926670U;
			if (1493449864U * num != 0U)
			{
				IL_12:
				while (73B5324E != null || 795355255U == num)
				{
					while (814680821U - num != 0U)
					{
						Type type = this.56815975;
						num = 464859584U % num;
						bool isValueType = type.IsValueType;
						num = 1347816607U + num;
						if (isValueType)
						{
							num |= 80611134U;
							if (1305365558U == num)
							{
								break;
							}
						}
						else if (1119124038U >> (int)num == 0U)
						{
							Type type2 = 73B5324E.GetType();
							num = (1075119335U ^ num);
							TypeCode typeCode = Type.GetTypeCode(type2);
							num >>= 13;
							if (num << 9 == 0U)
							{
								continue;
							}
							uint num2 = (uint)typeCode;
							num = (1536105202U | num);
							uint num3 = num2 - (num + 2758837521U);
							num >>= 5;
							switch (num3)
							{
							case 0:
							{
								num %= 273298413U;
								IntPtr ptr = this.685738EE;
								num = 1511724620U << (int)num;
								num /= 665073333U;
								Marshal.WriteInt16(ptr, Convert.ToChar(73B5324E));
								return;
							}
							case 1:
								num = (277643075U & num);
								if (1801463754U * num != 0U)
								{
									num = 1645043044U >> (int)num;
									IntPtr ptr2 = this.685738EE;
									num &= 524030350U;
									byte b = (byte)Convert.ToSByte(73B5324E);
									num *= 455287151U;
									byte val = b;
									num &= 1987074768U;
									Marshal.WriteByte(ptr2, val);
									return;
								}
								goto IL_12;
							case 2:
								num = (2066184161U & num);
								if (1890726724 << (int)num != 0)
								{
									num = 872816332U / num;
									IntPtr ptr3 = this.685738EE;
									num >>= 8;
									num ^= 833245774U;
									byte val2 = Convert.ToByte(73B5324E);
									num = 269812873U >> (int)num;
									Marshal.WriteByte(ptr3, val2);
									if (766338747U != num)
									{
										return;
									}
									continue;
								}
								break;
							case 3:
							{
								IntPtr ptr4 = this.685738EE;
								short val3 = Convert.ToInt16(73B5324E);
								num = 1311718699U % num;
								Marshal.WriteInt16(ptr4, val3);
								if (num << 11 != 0U)
								{
									return;
								}
								goto IL_12;
							}
							case 4:
							{
								num = 1120278879U >> (int)num;
								IntPtr ptr5 = this.685738EE;
								short num4 = (short)Convert.ToUInt16(73B5324E);
								num = 1068134587U + num;
								Marshal.WriteInt16(ptr5, num4);
								return;
							}
							case 5:
								num /= 1951551204U;
								if (814171884U != num)
								{
									num <<= 18;
									IntPtr ptr6 = this.685738EE;
									num = 1980249385U * num;
									int val4 = Convert.ToInt32(73B5324E);
									num = 1462854208U << (int)num;
									Marshal.WriteInt32(ptr6, val4);
									return;
								}
								goto IL_12;
							case 6:
								if (180623604U % num != 0U)
								{
									IntPtr ptr7 = this.685738EE;
									num ^= 648501100U;
									Marshal.WriteInt32(ptr7, (int)Convert.ToUInt32(73B5324E));
									return;
								}
								break;
							case 7:
							{
								if (1581202146U == num)
								{
									goto IL_23;
								}
								num = 2131449861U >> (int)num;
								IntPtr ptr8 = this.685738EE;
								num = 1262502088U << (int)num;
								Marshal.WriteInt64(ptr8, Convert.ToInt64(73B5324E));
								if (1428881661U > num)
								{
									return;
								}
								continue;
							}
							case 8:
								if (num % 261372463U != 0U)
								{
									IntPtr ptr9 = this.685738EE;
									long val5 = (long)Convert.ToUInt64(73B5324E);
									num ^= 2072789818U;
									Marshal.WriteInt64(ptr9, val5);
									return;
								}
								goto IL_12;
							case 9:
							{
								IntPtr ptr10 = this.685738EE;
								num = 689272142U >> (int)num;
								float value = Convert.ToSingle(73B5324E);
								num = (1092834956U ^ num);
								byte[] bytes = BitConverter.GetBytes(value);
								num += 422778871U;
								int startIndex = (int)(num - 1515613909U);
								num = 1328092261U % num;
								int val6 = BitConverter.ToInt32(bytes, startIndex);
								num &= 1358694000U;
								Marshal.WriteInt32(ptr10, val6);
								if (num / 1973121493U == 0U)
								{
									return;
								}
								continue;
							}
							case 10:
							{
								num <<= 5;
								IntPtr ptr11 = this.685738EE;
								byte[] bytes2 = BitConverter.GetBytes(Convert.ToDouble(73B5324E));
								int startIndex2 = (int)(num ^ 1536129760U);
								num ^= 1520790504U;
								Marshal.WriteInt64(ptr11, BitConverter.ToInt64(bytes2, startIndex2));
								return;
							}
							default:
								if (1114464560U <= num)
								{
									goto IL_23;
								}
								num *= 1614952366U;
								if (571232794U < num)
								{
									throw new ArgumentException();
								}
								goto IL_12;
							}
						}
						num = (441588302U & num);
						Marshal.StructureToPtr(73B5324E, this.685738EE, num + 4156417458U != 0U);
						if (1056254200U >> (int)num != 0U)
						{
							return;
						}
					}
					break;
				}
			}
			IL_23:
			throw new ArgumentException();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00221E20 File Offset: 0x00221E20
		public override sbyte 3B8993E9()
		{
			return (sbyte)Marshal.ReadByte(this.685738EE);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00221E40 File Offset: 0x00221E40
		public override short D496EFA1()
		{
			uint num = 1245731262U;
			num = 618489630U - num;
			return Marshal.ReadInt16(this.685738EE);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00221E68 File Offset: 0x00221E68
		public override int D02DFB88()
		{
			return Marshal.ReadInt32(this.685738EE);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00221E88 File Offset: 0x00221E88
		public override long E7FBC3B9()
		{
			uint num = 961303198U;
			num <<= 20;
			return Marshal.ReadInt64(this.685738EE);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00221EB0 File Offset: 0x00221EB0
		public override char CE499C06()
		{
			uint num = 1004498121U;
			char c = (char)Marshal.ReadInt16(this.685738EE);
			num *= 1649607832U;
			return c;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00221ED8 File Offset: 0x00221ED8
		public override byte 701A708C()
		{
			uint num = 1855347440U;
			num |= 1148335202U;
			return Marshal.ReadByte(this.685738EE);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00221EB0 File Offset: 0x00221EB0
		public override ushort EF893D1B()
		{
			uint num = 1004498121U;
			ushort num2 = (ushort)Marshal.ReadInt16(this.685738EE);
			num *= 1649607832U;
			return num2;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00221E68 File Offset: 0x00221E68
		public override uint 45E9448C()
		{
			return (uint)Marshal.ReadInt32(this.685738EE);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00221E88 File Offset: 0x00221E88
		public override ulong 6100687B()
		{
			uint num = 961303198U;
			num <<= 20;
			return (ulong)Marshal.ReadInt64(this.685738EE);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00221F00 File Offset: 0x00221F00
		public override float 88D23451()
		{
			uint num = 308347900U;
			num = 2049196519U % num;
			int value = Marshal.ReadInt32(this.685738EE);
			num = (1831428106U | num);
			byte[] bytes = BitConverter.GetBytes(value);
			int startIndex = (int)(num ^ 1879009791U);
			num = (259291912U | num);
			return BitConverter.ToSingle(bytes, startIndex);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00221F48 File Offset: 0x00221F48
		public override double B1479B35()
		{
			long value = Marshal.ReadInt64(this.685738EE);
			uint num = 298925822U;
			byte[] bytes = BitConverter.GetBytes(value);
			int startIndex = (int)(num + 3996041474U);
			num |= 1474835629U;
			return BitConverter.ToDouble(bytes, startIndex);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00221F80 File Offset: 0x00221F80
		public override IntPtr 8ACF22C2()
		{
			uint num = 1062753264U;
			do
			{
				int size = IntPtr.Size;
				uint num2 = num + 3232214036U;
				num = 1635474220U % num;
				if (size == num2)
				{
					goto IL_4B;
				}
				num ^= 1852915144U;
			}
			while ((num ^ 212098417U) == 0U);
			num &= 1754673003U;
			long value = Marshal.ReadInt64(this.685738EE);
			goto IL_7D;
			IL_4B:
			num = 2004435019U - num;
			num = 2114719751U << (int)num;
			long num3 = (long)Marshal.ReadInt32(this.685738EE);
			num = 1335366838U - num;
			value = num3;
			num ^= 260488918U;
			IL_7D:
			return new IntPtr(value);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00222010 File Offset: 0x00222010
		public override UIntPtr 16A92427()
		{
			uint num = 1600787777U;
			ulong value;
			if (1265193182U <= num)
			{
				for (;;)
				{
					uint size = (uint)IntPtr.Size;
					num = 1636595805U << (int)num;
					if (size != (num ^ 3273191614U))
					{
						break;
					}
					num &= 2126777319U;
					if (2073452842U >> (int)num != 0U)
					{
						goto Block_2;
					}
				}
				num = (1183087811U & num);
				goto IL_38;
				Block_2:
				IntPtr ptr = this.685738EE;
				num = (1187594093U & num);
				value = (ulong)Marshal.ReadInt32(ptr);
				num ^= 1060198024U;
				goto IL_8C;
			}
			IL_38:
			num = 1598838186U << (int)num;
			value = (ulong)Marshal.ReadInt64(this.685738EE);
			IL_8C:
			return new UIntPtr(value);
		}

		// Token: 0x0400012F RID: 303
		private IntPtr 685738EE;

		// Token: 0x04000130 RID: 304
		private Type 56815975;
	}

	// Token: 0x0200003C RID: 60
	private sealed class 608572C1
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x002220B0 File Offset: 0x002220B0
		public 608572C1(byte 226255D6, int 75741756, int 636C0E28)
		{
			uint num = 1818764327U;
			if (103827404U == num)
			{
				goto IL_5C;
			}
			num = 593635025U - num;
			base..ctor();
			num = 792805125U % num;
			do
			{
				IL_27:
				num = 1111848075U % num;
				this.346A13F3 = 226255D6;
				if (num >> 30 != 0U)
				{
					return;
				}
				num ^= 531315315U;
				this.6D5B6C4B = 75741756;
			}
			while (num > 1942054273U);
			IL_5C:
			num ^= 83981892U;
			num = 34940422U >> (int)num;
			this.347519B4 = 636C0E28;
			if (num % 1421610982U == 0U)
			{
				goto IL_27;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00222144 File Offset: 0x00222144
		public byte 00381BFD()
		{
			return this.346A13F3;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00222160 File Offset: 0x00222160
		public int 0A1E119D()
		{
			return this.6D5B6C4B;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0022217C File Offset: 0x0022217C
		public int 02ED5F43()
		{
			uint num = 1332747533U;
			num /= 1396116036U;
			return this.347519B4;
		}

		// Token: 0x04000131 RID: 305
		private byte 346A13F3;

		// Token: 0x04000132 RID: 306
		private int 6D5B6C4B;

		// Token: 0x04000133 RID: 307
		private int 347519B4;
	}

	// Token: 0x0200003D RID: 61
	private sealed class 4AB007C7
	{
		// Token: 0x060002BC RID: 700 RVA: 0x002221A0 File Offset: 0x002221A0
		public 4AB007C7(int 23520742, int 6DFB0AE0)
		{
			for (;;)
			{
				List<66026065.608572C1> list = new List<66026065.608572C1>();
				uint num = 1367556871U;
				this.0893152B = list;
				base..ctor();
				if (num * 921116955U != 0U)
				{
					num = 46605780U * num;
					this.1C695793 = 23520742;
					if (45241104U <= num)
					{
						break;
					}
				}
			}
			this.1D09257C = 6DFB0AE0;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x002221F4 File Offset: 0x002221F4
		public int 49CD1B84()
		{
			uint num = 1482054349U;
			num <<= 8;
			return this.1C695793;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00222218 File Offset: 0x00222218
		public int 13F7030A()
		{
			uint num = 869432235U;
			num += 366176814U;
			return this.1D09257C;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0022223C File Offset: 0x0022223C
		public int 08FC2856(66026065.4AB007C7 66EF08BA)
		{
			uint num;
			int num2;
			int num3;
			for (;;)
			{
				num = 594423103U;
				if (66EF08BA == null)
				{
					break;
				}
				while (num * 1244991452U != 0U)
				{
					num = 1461601259U * num;
					int value = 66EF08BA.49CD1B84();
					num = 1575486644U << (int)num;
					num2 = this.1C695793.CompareTo(value);
					num -= 1692807118U;
					if ((1799375506U & num) == 0U)
					{
						goto IL_0C;
					}
					if (num2 != 0)
					{
						goto IL_B3;
					}
					num = 406784117U % num;
					num = (2008883875U ^ num);
					num3 = 66EF08BA.13F7030A();
					if (1161441320U / num == 0U)
					{
						goto Block_3;
					}
				}
			}
			IL_0C:
			return (int)(num - 594423102U);
			Block_3:
			num = (1147143069U | num);
			int value2 = this.1D09257C;
			num %= 351806735U;
			int num4 = num3.CompareTo(value2);
			num ^= 549877841U;
			num2 = num4;
			num += 164283757U;
			IL_B3:
			num ^= 2090630723U;
			if (num != 1529100545U)
			{
				return num2;
			}
			goto IL_0C;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00222310 File Offset: 0x00222310
		public void 76AA06B8(byte 56E51171, int 739A54E6, int 221C0DDB)
		{
			List<66026065.608572C1> list = this.0893152B;
			uint num = 603740492U;
			num <<= 21;
			66026065.608572C1 item = new 66026065.608572C1(56E51171, 739A54E6, 221C0DDB);
			num = 2019844586U << (int)num;
			list.Add(item);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0022234C File Offset: 0x0022234C
		public List<66026065.608572C1> 24E26117()
		{
			uint num = 1123625030U;
			num = 2027322204U + num;
			return this.0893152B;
		}

		// Token: 0x04000134 RID: 308
		private int 1C695793;

		// Token: 0x04000135 RID: 309
		private int 1D09257C;

		// Token: 0x04000136 RID: 310
		private List<66026065.608572C1> 0893152B;
	}

	// Token: 0x0200003E RID: 62
	// (Invoke) Token: 0x060002C3 RID: 707
	internal delegate void 0C3B5530();
}
