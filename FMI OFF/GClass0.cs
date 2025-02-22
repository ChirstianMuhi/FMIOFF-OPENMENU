using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ns0
{
	public class GClass0
	{
		public string method_0(string product)
		{
			string text = "";
			if (product.Contains("iPhone"))
			{
				text = "iPhone";
			}
			if (product.Contains("iPad"))
			{
				text = "iPad";
			}
			if (product.Contains("iPod"))
			{
				text = "iPod";
			}
			return string.Concat(new string[]
			{
				"https://statici.icloud.com/fmipmobile/deviceImages-9.0/",
				text,
				"/",
				product,
				"/online-infobox__3x.png"
			});
		}

		public string method_1(string colorcode)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"1",
					"Black"
				},
				{
					"2",
					"White"
				},
				{
					"3",
					"Gold"
				},
				{
					"4",
					"Rose Gold"
				},
				{
					"5",
					"Jet Black"
				},
				{
					"6",
					"Red"
				},
				{
					"7",
					"Yellow"
				},
				{
					"8",
					"Coral"
				},
				{
					"9",
					"Blue"
				},
				{
					"#e4e7e8",
					"Rose Gold"
				},
				{
					"#3b3b3c",
					"White"
				}
			};
			string text;
			string result;
			if (!dictionary.TryGetValue(colorcode, out text))
			{
				foreach (KeyValuePair<string, string> keyValuePair in dictionary)
				{
					if (keyValuePair.Value.Equals(colorcode, StringComparison.OrdinalIgnoreCase))
					{
						return keyValuePair.Value;
					}
				}
				result = string.Empty;
			}
			else
			{
				result = text;
			}
			return result;
		}

		public string method_2()
		{
			return Environment.CurrentDirectory + "\\winx64";
		}

		public string method_3()
		{
			string result = "";
			using (Process process = new Process())
			{
				process.StartInfo.FileName = this.method_2() + "\\idevicepair.exe";
				process.StartInfo.Arguments = "pair";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				result = process.StandardOutput.ReadToEnd();
				process.WaitForExit();
			}
			return result;
		}

		public double method_4()
		{
			try
			{
				using (Process process = Process.Start(new ProcessStartInfo
				{
					FileName = this.method_2() + "\\ideviceinfo.exe",
					Arguments = "-q com.apple.disk_usage.factory -k TotalDataAvailable",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}))
				{
					string text = process.StandardOutput.ReadToEnd();
					process.WaitForExit();
					long num;
					if (long.TryParse(text.Trim(), out num))
					{
						return Math.Round((double)num / 1073741824.0, 2);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			return 0.0;
		}

		public double method_5()
		{
			try
			{
				using (Process process = Process.Start(new ProcessStartInfo
				{
					FileName = this.method_2() + "\\ideviceinfo.exe",
					Arguments = "-q com.apple.disk_usage.factory -k TotalDiskCapacity",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}))
				{
					string text = process.StandardOutput.ReadToEnd();
					process.WaitForExit();
					long num;
					if (long.TryParse(text.Trim(), out num))
					{
						return Math.Round((double)num / 1073741824.0, 2);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			return 0.0;
		}

		internal static uint smethod_0(string string_0)
		{
			uint num = 0U;
			if (string_0 != null)
			{
				num = 2166136261U;
				for (int i = 0; i < string_0.Length; i++)
				{
					num = ((uint)string_0[i] ^ num) * 16777619U;
				}
			}
			return num;
		}

		public string method_6(string productType)
		{
			uint num = GClass0.smethod_0(productType);
			if (num <= 1613858532U)
			{
				if (num <= 493807482U)
				{
					if (num <= 268341164U)
					{
						if (num <= 201230688U)
						{
							if (num <= 137893251U)
							{
								if (num > 80824001U)
								{
									if (num != 121115632U)
									{
										if (num == 137893251U && productType == "iPad13,6")
										{
											return "iPad Pro 11 inch 5th Gen";
										}
									}
									else if (productType == "iPad13,7")
									{
										return "iPad Pro 11 inch 5th Gen";
									}
								}
								else if (num != 13713525U)
								{
									if (num == 80824001U && productType == "iPad6,8")
									{
										return "iPad Pro (12.9 inch, WiFi+LTE)";
									}
								}
								else if (productType == "iPad6,4")
								{
									return "iPad Pro (9.7 inch, WiFi+LTE)";
								}
							}
							else if (num <= 171448489U)
							{
								if (num != 154670870U)
								{
									if (num == 171448489U && productType == "iPad13,4")
									{
										return "iPad Pro 11 inch 5th Gen";
									}
								}
								else if (productType == "iPad13,5")
								{
									return "iPad Pro 11 inch 5th Gen";
								}
							}
							else if (num != 194068216U)
							{
								if (num == 201230688U && productType == "iPad7,2")
								{
									return "iPad Pro 2nd Gen (WiFi+Cellular)";
								}
							}
							else if (productType == "iPhone5,1")
							{
								return "iPhone 5 (GSM)";
							}
						}
						else if (num <= 227623454U)
						{
							if (num <= 218008307U)
							{
								if (num != 205003727U)
								{
									if (num == 218008307U && productType == "iPad7,3")
									{
										return "iPad Pro 10.5-inch 2nd Gen";
									}
								}
								else if (productType == "iPad13,2")
								{
									return "iPad Air 4th Gen (WiFi+Cellular)";
								}
							}
							else if (num != 221781346U)
							{
								if (num == 227623454U && productType == "iPhone5,3")
								{
									return "iPhone 5C (GSM)";
								}
							}
							else if (productType == "iPad13,1")
							{
								return "iPad Air 4th Gen (WiFi)";
							}
						}
						else if (num <= 240921132U)
						{
							if (num != 235638739U)
							{
								if (num == 240921132U && productType == "iPad6,12")
								{
									return "iPad (2017)";
								}
							}
							else if (productType == "iPhone4,1")
							{
								return "iPhone 4S";
							}
						}
						else if (num != 244401073U)
						{
							if (num != 251563545U)
							{
								if (num == 268341164U && productType == "iPad7,6")
								{
									return "iPad 6th Gen (WiFi+Cellular)";
								}
							}
							else if (productType == "iPad7,1")
							{
								return "iPad Pro 2nd Gen (WiFi)";
							}
						}
						else if (productType == "iPhone5,2")
						{
							return "iPhone 5 (GSM+CDMA)";
						}
					}
					else if (num <= 372779917U)
					{
						if (num <= 318674021U)
						{
							if (num <= 291253989U)
							{
								if (num != 277956311U)
								{
									if (num == 291253989U && productType == "iPad6,11")
									{
										return "iPad (2017)";
									}
								}
								else if (productType == "iPhone5,4")
								{
									return "iPhone 5C (Global)";
								}
							}
							else if (num != 301896402U)
							{
								if (num == 318674021U && productType == "iPad7,5")
								{
									return "iPad 6th Gen (WiFi)";
								}
							}
							else if (productType == "iPad7,4")
							{
								return "iPad Pro 10.5-inch 2nd Gen";
							}
						}
						else if (num <= 342808911U)
						{
							if (num != 326031292U)
							{
								if (num == 342808911U && productType == "iPad8,8")
								{
									return "iPad Pro 12.9 inch 3rd Gen (1TB, WiFi+Cellular)";
								}
							}
							else if (productType == "iPad8,9")
							{
								return "iPad Pro 11 inch 4th Gen (WiFi)";
							}
						}
						else if (num != 350181282U)
						{
							if (num != 356002298U)
							{
								if (num == 372779917U && productType == "iPad13,8")
								{
									return "iPad Pro 12.9 inch 5th Gen";
								}
							}
							else if (productType == "iPad13,9")
							{
								return "iPad Pro 12.9 inch 5th Gen";
							}
						}
						else if (productType == "iPhone11,8")
						{
							return "iPhone XR";
						}
					}
					else if (num <= 417291758U)
					{
						if (num <= 393141768U)
						{
							if (num != 383736520U)
							{
								if (num == 393141768U && productType == "iPad8,5")
								{
									return "iPad Pro 12.9 inch 3rd Gen (WiFi)";
								}
							}
							else if (productType == "iPhone11,6")
							{
								return "iPhone XS Max Global";
							}
						}
						else if (num != 409919387U)
						{
							if (num == 417291758U && productType == "iPhone11,4")
							{
								return "iPhone XS Max";
							}
						}
						else if (productType == "iPad8,4")
						{
							return "iPad Pro 11 inch 3rd Gen (1TB, WiFi+Cellular)";
						}
					}
					else if (num <= 443474625U)
					{
						if (num != 426697006U)
						{
							if (num == 443474625U && productType == "iPad8,6")
							{
								return "iPad Pro 12.9 inch 3rd Gen (1TB, WiFi)";
							}
						}
						else if (productType == "iPad8,7")
						{
							return "iPad Pro 12.9 inch 3rd Gen (WiFi+Cellular)";
						}
					}
					else if (num != 450846996U)
					{
						if (num != 460252244U)
						{
							if (num == 493807482U && productType == "iPad8,3")
							{
								return "iPad Pro 11 inch 3rd Gen (WiFi+Cellular)";
							}
						}
						else if (productType == "iPad8,1")
						{
							return "iPad Pro 11 inch 3rd Gen (WiFi)";
						}
					}
					else if (productType == "iPhone11,2")
					{
						return "iPhone XS";
					}
				}
				else if (num <= 897947417U)
				{
					if (num <= 693515438U)
					{
						if (num <= 576072105U)
						{
							if (num <= 519927770U)
							{
								if (num != 510585101U)
								{
									if (num == 519927770U && productType == "iPod4,1")
									{
										return "4th Gen iPod";
									}
								}
								else if (productType == "iPad8,2")
								{
									return "iPad Pro 11 inch 3rd Gen (1TB, WiFi)";
								}
							}
							else if (num != 559294486U)
							{
								if (num == 576072105U && productType == "iPad13,11")
								{
									return "iPad Pro 12.9 inch 5th Gen";
								}
							}
							else if (productType == "iPad13,10")
							{
								return "iPad Pro 12.9 inch 5th Gen";
							}
						}
						else if (num <= 609627343U)
						{
							if (num != 592849724U)
							{
								if (num == 609627343U && productType == "iPad13,17")
								{
									return "iPad Air 5th Gen (WiFi+Cellular)";
								}
							}
							else if (productType == "iPad13,16")
							{
								return "iPad Air 5th Gen (WiFi)";
							}
						}
						else if (num != 638364159U)
						{
							if (num != 688697016U)
							{
								if (num == 693515438U && productType == "iPad13,18")
								{
									return "iPad 10th Gen";
								}
							}
							else if (productType == "iPhone12,5")
							{
								return "iPhone 11 Pro Max";
							}
						}
						else if (productType == "iPhone12,8")
						{
							return "iPhone SE 2nd Gen";
						}
					}
					else if (num <= 789362730U)
					{
						if (num <= 734278272U)
						{
							if (num != 710293057U)
							{
								if (num == 734278272U && productType == "iPhone13,4")
								{
									return "iPhone 12 Pro Max";
								}
							}
							else if (productType == "iPad13,19")
							{
								return "iPad 10th Gen";
							}
						}
						else if (num != 755807492U)
						{
							if (num == 789362730U && productType == "iPhone12,3")
							{
								return "iPhone 11 Pro";
							}
						}
						else if (productType == "iPhone12,1")
						{
							return "iPhone 11";
						}
					}
					else if (num <= 834943986U)
					{
						if (num != 818166367U)
						{
							if (num == 834943986U && productType == "iPhone13,2")
							{
								return "iPhone 12";
							}
						}
						else if (productType == "iPhone13,1")
						{
							return "iPhone 12 Mini";
						}
					}
					else if (num != 851721605U)
					{
						if (num != 876599987U)
						{
							if (num == 897947417U && productType == "iPod9,1")
							{
								return "7th Gen iPod";
							}
						}
						else if (productType == "iPhone9,4")
						{
							return "iPhone 7 Plus";
						}
					}
					else if (productType == "iPhone13,3")
					{
						return "iPhone 12 Pro";
					}
				}
				else if (num <= 1118200753U)
				{
					if (num <= 993594948U)
					{
						if (num <= 960488082U)
						{
							if (num != 926932844U)
							{
								if (num == 960488082U && productType == "iPhone9,3")
								{
									return "iPhone 7";
								}
							}
							else if (productType == "iPhone9,1")
							{
								return "iPhone 7";
							}
						}
						else if (num != 977265701U)
						{
							if (num == 993594948U && productType == "iPhone3,3")
							{
								return "iPhone 4 CDMA";
							}
						}
						else if (productType == "iPhone9,2")
						{
							return "iPhone 7 Plus";
						}
					}
					else if (num <= 1027150186U)
					{
						if (num != 1010372567U)
						{
							if (num == 1027150186U && productType == "iPhone3,1")
							{
								return "iPhone 4";
							}
						}
						else if (productType == "iPhone3,2")
						{
							return "iPhone 4 GSM Rev A";
						}
					}
					else if (num != 1084645515U)
					{
						if (num != 1101423134U)
						{
							if (num == 1118200753U && productType == "iPad5,3")
							{
								return "iPad Air 2 (WiFi)";
							}
						}
						else if (productType == "iPad5,2")
						{
							return "4th Gen iPad mini (WiFi+Cellular)";
						}
					}
					else if (productType == "iPad5,1")
					{
						return "iPad mini 4 (WiFi)";
					}
				}
				else if (num <= 1533782097U)
				{
					if (num <= 1158652399U)
					{
						if (num != 1134978372U)
						{
							if (num == 1158652399U && productType == "iPod7,1")
							{
								return "6th Gen iPod";
							}
						}
						else if (productType == "iPad5,4")
						{
							return "iPad Air 2 (Cellular)";
						}
					}
					else if (num != 1483449240U)
					{
						if (num == 1533782097U && productType == "iPhone16,2")
						{
							return "iPhone 15 Pro Max";
						}
					}
					else if (productType == "iPhone16,1")
					{
						return "iPhone 15 Pro";
					}
				}
				else if (num <= 1571900294U)
				{
					if (num != 1538345056U)
					{
						if (num == 1571900294U && productType == "iPad3,4")
						{
							return "4th Gen iPad";
						}
					}
					else if (productType == "iPad3,6")
					{
						return "4th Gen iPad CDMA+LTE";
					}
				}
				else if (num != 1588677913U)
				{
					if (num != 1605455532U)
					{
						if (num == 1613858532U && productType == "iPhone1,1")
						{
							return "iPhone";
						}
					}
					else if (productType == "iPad3,2")
					{
						return "3rd Gen iPad CDMA";
					}
				}
				else if (productType == "iPad3,5")
				{
					return "4th Gen iPad GSM+LTE";
				}
			}
			else if (num <= 2777501608U)
			{
				if (num <= 2286986705U)
				{
					if (num <= 2081752929U)
					{
						if (num <= 1743237195U)
						{
							if (num <= 1655788389U)
							{
								if (num != 1622233151U)
								{
									if (num == 1655788389U && productType == "iPad3,1")
									{
										return "3rd Gen iPad";
									}
								}
								else if (productType == "iPad3,3")
								{
									return "3rd Gen iPad GSM";
								}
							}
							else if (num != 1664191389U)
							{
								if (num == 1743237195U && productType == "iPhone7,2")
								{
									return "iPhone 6";
								}
							}
							else if (productType == "iPhone1,2")
							{
								return "iPhone 3G";
							}
						}
						else if (num <= 1886294147U)
						{
							if (num != 1760014814U)
							{
								if (num == 1886294147U && productType == "iPod3,1")
								{
									return "3rd Gen iPod";
								}
							}
							else if (productType == "iPhone7,1")
							{
								return "iPhone 6 Plus";
							}
						}
						else if (num != 2031420072U)
						{
							if (num == 2081752929U && productType == "iPhone6,1")
							{
								return "iPhone 5S (GSM)";
							}
						}
						else if (productType == "iPhone6,2")
						{
							return "iPhone 5S (Global)";
						}
					}
					else if (num <= 2175364388U)
					{
						if (num <= 2141809150U)
						{
							if (num != 2125031531U)
							{
								if (num == 2141809150U && productType == "iPad14,2")
								{
									return "iPad mini 6th Gen (WiFi+Cellular)";
								}
							}
							else if (productType == "iPad14,1")
							{
								return "iPad mini 6th Gen (WiFi)";
							}
						}
						else if (num != 2158586769U)
						{
							if (num == 2175364388U && productType == "iPad14,4")
							{
								return "iPad Pro 11 inch 4th Gen";
							}
						}
						else if (productType == "iPad14,3")
						{
							return "iPad Pro 11 inch 4th Gen";
						}
					}
					else if (num <= 2208919626U)
					{
						if (num != 2192142007U)
						{
							if (num == 2208919626U && productType == "iPad14,6")
							{
								return "iPad Pro 12.9 inch 6th Gen";
							}
						}
						else if (productType == "iPad14,5")
						{
							return "iPad Pro 12.9 inch 6th Gen";
						}
					}
					else if (num != 2253431467U)
					{
						if (num != 2270209086U)
						{
							if (num == 2286986705U && productType == "iPhone10,4")
							{
								return "iPhone 8";
							}
						}
						else if (productType == "iPhone10,5")
						{
							return "iPhone 8 Plus";
						}
					}
					else if (productType == "iPhone10,6")
					{
						return "iPhone X GSM";
					}
				}
				else if (num <= 2643280656U)
				{
					if (num <= 2475788652U)
					{
						if (num <= 2320541943U)
						{
							if (num != 2303764324U)
							{
								if (num == 2320541943U && productType == "iPhone10,2")
								{
									return "iPhone 8 Plus";
								}
							}
							else if (productType == "iPhone10,3")
							{
								return "iPhone X Global";
							}
						}
						else if (num != 2337319562U)
						{
							if (num == 2475788652U && productType == "iPad8,10")
							{
								return "iPad Pro 11 inch 4th Gen (WiFi+Cellular)";
							}
						}
						else if (productType == "iPhone10,1")
						{
							return "iPhone 8";
						}
					}
					else if (num <= 2509343890U)
					{
						if (num != 2492566271U)
						{
							if (num == 2509343890U && productType == "iPad8,12")
							{
								return "iPad Pro 12.9 inch 4th Gen (WiFi+Cellular)";
							}
						}
						else if (productType == "iPad8,11")
						{
							return "iPad Pro 12.9 inch 4th Gen (WiFi)";
						}
					}
					else if (num != 2509658711U)
					{
						if (num != 2526436330U)
						{
							if (num == 2643280656U && productType == "iPad4,1")
							{
								return "iPad Air (WiFi)";
							}
						}
						else if (productType == "iPad1,2")
						{
							return "iPad 3G";
						}
					}
					else if (productType == "iPad1,1")
					{
						return "iPad";
					}
				}
				else if (num <= 2696174405U)
				{
					if (num <= 2676835894U)
					{
						if (num != 2645841548U)
						{
							if (num == 2676835894U && productType == "iPad4,3")
							{
								return "1st Gen iPad Air (China)";
							}
						}
						else if (productType == "iPad12,2")
						{
							return "iPad 9th Gen (WiFi+Cellular)";
						}
					}
					else if (num != 2693613513U)
					{
						if (num == 2696174405U && productType == "iPad12,1")
						{
							return "iPad 9th Gen (WiFi)";
						}
					}
					else if (productType == "iPad4,2")
					{
						return "iPad Air (GSM+CDMA)";
					}
				}
				else if (num <= 2727168751U)
				{
					if (num != 2710391132U)
					{
						if (num == 2727168751U && productType == "iPad4,4")
						{
							return "iPad mini Retina (WiFi)";
						}
					}
					else if (productType == "iPad4,5")
					{
						return "iPad mini Retina (GSM+CDMA)";
					}
				}
				else if (num != 2743946370U)
				{
					if (num != 2760723989U)
					{
						if (num == 2777501608U && productType == "iPad4,9")
						{
							return "iPad Mini 3 (China)";
						}
					}
					else if (productType == "iPad4,6")
					{
						return "iPad mini Retina (China)";
					}
				}
				else if (productType == "iPad4,7")
				{
					return "iPad mini 3 (WiFi)";
				}
			}
			else if (num <= 3341589448U)
			{
				if (num <= 3001134901U)
				{
					if (num <= 2934024425U)
					{
						if (num <= 2900469187U)
						{
							if (num != 2794279227U)
							{
								if (num == 2900469187U && productType == "iPad11,4")
								{
									return "iPad Air 3rd Gen";
								}
							}
							else if (productType == "iPad4,8")
							{
								return "iPad mini 3 (GSM+CDMA)";
							}
						}
						else if (num != 2917246806U)
						{
							if (num == 2934024425U && productType == "iPad11,6")
							{
								return "iPad 8th Gen (WiFi)";
							}
						}
						else if (productType == "iPad11,7")
						{
							return "iPad 8th Gen (WiFi+Cellular)";
						}
					}
					else if (num <= 2952740857U)
					{
						if (num != 2950802044U)
						{
							if (num == 2952740857U && productType == "iPhone14,8")
							{
								return "iPhone 14 Plus";
							}
						}
						else if (productType == "iPad11,1")
						{
							return "iPad mini 5th Gen (WiFi)";
						}
					}
					else if (num != 2984357282U)
					{
						if (num != 2989097949U)
						{
							if (num == 3001134901U && productType == "iPad11,2")
							{
								return "iPad mini 5th Gen";
							}
						}
						else if (productType == "iPod5,1")
						{
							return "5th Gen iPod";
						}
					}
					else if (productType == "iPad11,3")
					{
						return "iPad Air 3rd Gen (WiFi)";
					}
				}
				else if (num <= 3120517047U)
				{
					if (num <= 3053406571U)
					{
						if (num != 3036628952U)
						{
							if (num == 3053406571U && productType == "iPhone14,2")
							{
								return "iPhone 13 Pro";
							}
						}
						else if (productType == "iPhone14,3")
						{
							return "iPhone 13 Pro Max";
						}
					}
					else if (num != 3103739428U)
					{
						if (num == 3120517047U && productType == "iPhone14,6")
						{
							return "iPhone SE 3rd Gen";
						}
					}
					else if (productType == "iPhone14,7")
					{
						return "iPhone 14";
					}
				}
				else if (num <= 3154072285U)
				{
					if (num != 3137294666U)
					{
						if (num == 3154072285U && productType == "iPhone14,4")
						{
							return "iPhone 13 Mini";
						}
					}
					else if (productType == "iPhone14,5")
					{
						return "iPhone 13";
					}
				}
				else if (num != 3266955512U)
				{
					if (num != 3317288369U)
					{
						if (num == 3341589448U && productType == "iPhone15,2")
						{
							return "iPhone 14 Pro";
						}
					}
					else if (productType == "iPad7,12")
					{
						return "iPad 7th Gen 10.2-inch (WiFi+Cellular)";
					}
				}
				else if (productType == "iPad7,11")
				{
					return "iPad 7th Gen 10.2-inch (WiFi)";
				}
			}
			else if (num <= 3480373359U)
			{
				if (num <= 3430040502U)
				{
					if (num <= 3396485264U)
					{
						if (num != 3358367067U)
						{
							if (num == 3396485264U && productType == "iPad2,7")
							{
								return "iPad mini CDMA+LTE";
							}
						}
						else if (productType == "iPhone15,3")
						{
							return "iPhone 14 Pro Max";
						}
					}
					else if (num != 3413262883U)
					{
						if (num == 3430040502U && productType == "iPad2,5")
						{
							return "iPad mini";
						}
					}
					else if (productType == "iPad2,6")
					{
						return "iPad mini GSM+LTE";
					}
				}
				else if (num <= 3446818121U)
				{
					if (num != 3442255162U)
					{
						if (num == 3446818121U && productType == "iPad2,4")
						{
							return "2nd Gen iPad New Revision";
						}
					}
					else if (productType == "iPhone15,4")
					{
						return "iPhone 15";
					}
				}
				else if (num != 3459032781U)
				{
					if (num != 3463595740U)
					{
						if (num == 3480373359U && productType == "iPad2,2")
						{
							return "2nd Gen iPad GSM";
						}
					}
					else if (productType == "iPad2,3")
					{
						return "2nd Gen iPad CDMA";
					}
				}
				else if (productType == "iPhone15,5")
				{
					return "iPhone 15 Plus";
				}
			}
			else if (num <= 3663264999U)
			{
				if (num <= 3506766125U)
				{
					if (num != 3497150978U)
					{
						if (num == 3506766125U && productType == "iPhone2,1")
						{
							return "iPhone 3GS";
						}
					}
					else if (productType == "iPad2,1")
					{
						return "2nd Gen iPad";
					}
				}
				else if (num != 3579376904U)
				{
					if (num == 3663264999U && productType == "iPhone8,1")
					{
						return "iPhone 6s";
					}
				}
				else if (productType == "iPhone8,4")
				{
					return "iPhone SE (GSM)";
				}
			}
			else if (num <= 3721962577U)
			{
				if (num != 3680042618U)
				{
					if (num == 3721962577U && productType == "iPod1,1")
					{
						return "1st Gen iPod";
					}
				}
				else if (productType == "iPhone8,2")
				{
					return "iPhone 6s Plus";
				}
			}
			else if (num != 3981813096U)
			{
				if (num != 4191237488U)
				{
					if (num == 4258347964U && productType == "iPad6,7")
					{
						return "iPad Pro (12.9 inch, WiFi)";
					}
				}
				else if (productType == "iPad6,3")
				{
					return "iPad Pro (9.7 inch, WiFi)";
				}
			}
			else if (productType == "iPod2,1")
			{
				return "2nd Gen iPod";
			}
			return "Unknown Device";
		}

		public string method_7()
		{
			string text = "";
			Process process = new Process();
			process.StartInfo.FileName = this.method_2() + "\\idevicebackup2.exe";
			process.StartInfo.Arguments = "encryption on 123";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.CreateNoWindow = true;
			try
			{
				process.Start();
				if (process.WaitForExit(30000))
				{
					text = process.StandardOutput.ReadToEnd();
					Console.WriteLine(text);
				}
				else
				{
					process.Kill();
					text = "The process was terminated due to timeout.";
				}
			}
			catch (Exception ex)
			{
				text = "An error occurred: " + ex.Message;
			}
			finally
			{
				process.Close();
			}
			return text;
		}

		public string method_8(string path)
		{
			string text = "";
			Process process = new Process();
			process.StartInfo.FileName = this.method_2() + "\\idevicebackup2.exe";
			process.StartInfo.Arguments = "backup --full " + path;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.CreateNoWindow = true;
			try
			{
				process.Start();
				text = process.StandardOutput.ReadToEnd();
				Console.WriteLine(text);
			}
			catch (Exception ex)
			{
				text = "An error occurred: " + ex.Message;
			}
			finally
			{
				process.Close();
			}
			return text;
		}

		private string string_0 = Path.GetTempPath();

		private string string_1 = Directory.GetCurrentDirectory();
	}
}
