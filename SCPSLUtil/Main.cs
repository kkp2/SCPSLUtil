using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Security.Principal;
using System.Security.Cryptography.X509Certificates;
using System.Deployment.Application;
using System.Security.AccessControl;

namespace SCPSLUtil
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void Memory_CheckedChanged(object sender, EventArgs e)
        {
            Remove.Checked = false;
            return;
        }

        public void Sign_CheckedChanged(object sender, EventArgs e)
        {
            Sign.Checked = false;
            System.Diagnostics.Process.Start("https://bit.ly/DigitalSignatureFailure");
            return;
        }

        public void Remove_CheckedChanged(object sender, EventArgs e)
        {
            Memory.Checked = false;
            return;
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }


        public void Execute_Click(object sender, EventArgs e)
        {
            bool SCPSLexist = false;
            bool steamexist = false;

            Process[] SCPSL = Process.GetProcessesByName("SCPSL");
            if (SCPSL.Length > 0)
            {
                SCPSLexist = true;
            }

            Process[] steam = Process.GetProcessesByName("steam");
            if (steam.Length > 0)
            {
                steamexist = true;
            }

            if (steamexist == true && SCPSLexist == true)
            {
                if (MessageBox.Show("다음 프로세스가 종료됩니다.\n - SCPSL.exe\n - steam.exe", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SCPSL[0].Kill();
                    steam[0].Kill();
                    Proceed();
                    return;
                }
                else
                {
                    MessageBox.Show("작업을 취소합니다.");
                    return;
                }
            }
            else if (steamexist == true && SCPSLexist == false)
            {
                if (MessageBox.Show("다음 프로세스가 종료됩니다.\n - steam.exe", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    steam[0].Kill();
                    Proceed();
                    return;
                }
                else
                {
                    MessageBox.Show("작업을 취소합니다.");
                    return;
                }
            }
            else
            {
                Proceed();
                return;
            }
        }


        public void Proceed()
        {
            if (InfLoad.Checked == true)
            {
                Session.Text = "무한로딩 해결 중...";
                ProgressBar.Value = 33;

                ProcessStartInfo prosi = new ProcessStartInfo();
                Process pro = new Process();

                prosi.FileName = @"cmd";
                prosi.CreateNoWindow = true;
                prosi.UseShellExecute = false;
                prosi.RedirectStandardInput = true;
                prosi.RedirectStandardOutput = true;
                prosi.RedirectStandardError = true;

                pro.StartInfo = prosi;
                pro.Start();

                pro.StandardInput.Write(@"tzutil /s UTC" + Environment.NewLine);
                pro.StandardInput.Close();
                pro.WaitForExit();
                pro.Close();
            }

            if (Memory.Checked == true)
            {
                Session.Text = "메모리 오류 해결 중...";
                ProgressBar.Value = 66;

                string[] modifysettings = File.ReadAllLines(Environment.ExpandEnvironmentVariables(@"%userprofile%\Appdata\Roaming\SCP Secret Laboratory\registry.txt"), Encoding.Default);
                modifysettings[63] = "07graphics_api::-%(|::0";
                File.WriteAllLines(Environment.ExpandEnvironmentVariables(@"%userprofile%\Appdata\Roaming\SCP Secret Laboratory\registry.txt"), modifysettings, Encoding.Default);
                MessageBox.Show("Finished!", "Done");
            }

            if (Remove.Checked == true)
            {
                Session.Text = "SCP:SL 완전히 제거하는 중...";
                ProgressBar.Value = 100;

                RegistryKey steampath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Valve\Steam\");
                string gamepath = steampath.GetValue("InstallPath").ToString() + @"\steamapps\common\SCP Secret Laboratory";
                string manifestpath = steampath.GetValue("InstallPath").ToString() + @"\steamapps\appmanifest_700330.acf";
                string Roaming = Environment.ExpandEnvironmentVariables(@"%userprofile%\Appdata\Roaming\SCP Secret Laboratory");
                string LocalLowH = Environment.ExpandEnvironmentVariables(@"%userprofile%\Appdata\LocalLow\Hubert Moszka");
                string LocalLowN = Environment.ExpandEnvironmentVariables(@"%userprofile%\Appdata\LocalLow\Northwood");

                if (Directory.Exists(gamepath))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    DirectoryInfo gamedel = new DirectoryInfo(gamepath);
                    gamedel.EnumerateFiles().ToList().ForEach(f => f.Delete());
                    gamedel.EnumerateDirectories().ToList().ForEach(d => d.Delete(true));
                    Directory.Delete(gamepath, true);
                }

                if (File.Exists(manifestpath))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    FileInfo manifestdel = new FileInfo(manifestpath);
                    manifestdel.Delete();
                }

                if (File.Exists(Roaming))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    DirectoryInfo roamdel = new DirectoryInfo(Roaming);
                    roamdel.EnumerateFiles().ToList().ForEach(f => f.Delete());
                    roamdel.EnumerateDirectories().ToList().ForEach(d => d.Delete(true));
                    Directory.Delete(Roaming, true);
                }

                if (File.Exists(LocalLowH))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    DirectoryInfo LLHdel = new DirectoryInfo(LocalLowH);
                    LLHdel.EnumerateFiles().ToList().ForEach(f => f.Delete());
                    LLHdel.EnumerateDirectories().ToList().ForEach(d => d.Delete(true));
                    Directory.Delete(LocalLowH, true);
                }

                if (File.Exists(LocalLowN))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    DirectoryInfo LLNdel = new DirectoryInfo(LocalLowN);
                    LLNdel.EnumerateFiles().ToList().ForEach(f => f.Delete());
                    LLNdel.EnumerateDirectories().ToList().ForEach(d => d.Delete(true));
                    Directory.Delete(LocalLowN, true);
                }

                RegistryKey Installed = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Valve\Steam\Apps\700330\");
                Installed.SetValue("Installed", 0, RegistryValueKind.DWord);
                try
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"SOFTWARE\Northwood");
                }
                catch (ArgumentException)
                {

                }

                try
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"SOFTWARE\Hubert Moszka");
                }
                catch (ArgumentException)
                {

                }

                MessageBox.Show("미리 스팀에서 SCP:SL을 삭제하지 않으셨을 경우\n제어판에서 프로그램이 그대로남게됩니다.\n제어판에서 제거 버튼을 누를 경우 정상적으로 사라집니다.");
            }
            Session.Text = "완료되었습니다!";
            ProgressBar.Value = 0;
            return;
        }
    }
}
