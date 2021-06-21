using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
// By angel
        private void button1_Click(object sender, EventArgs e)
        {
            string start = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\UI", "InstallPath", "").ToString();
            Process.Start(Path.Combine(start) + "/AndroidEmulator.exe", "-vm 100");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string start = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\UI", "InstallPath", "").ToString();
            Process.Start(Path.Combine(start) + "/AndroidEmulator.exe");
        }


        }
    }
