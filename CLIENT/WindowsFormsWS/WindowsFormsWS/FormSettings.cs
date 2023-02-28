using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static WindowsFormsWS.Form1;

namespace WindowsFormsWS
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        public Form1 own;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SetAutorunValue(checkBoxAutoRun.Checked);

            own.ClosingFormSettings(this);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;

            string name = "NotifCall";
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

            try
            {
                checkBoxAutoRun.Checked = reg.GetValue(name) != null;
            } catch { 
            }


            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://84.42.62.101/?p=137");
        }

        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            
            string name = "NotifCall";
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath);
                
                else
                    reg.DeleteValue(name);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void checkBoxAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
