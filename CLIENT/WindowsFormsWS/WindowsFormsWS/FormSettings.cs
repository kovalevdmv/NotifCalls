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
            if (textBoxNick.Text.ToLower() == "noname")
            {
                MessageBox.Show("Имя не должно noName");
                return;
            }

            SetAutorunValue(checkBoxAutoRun.Checked);

            own.ClosingFormSettings(this);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

            labelErrAutoRun.Visible = false;

            string ExePath = System.Windows.Forms.Application.ExecutablePath;

            string name = "NotifCall";
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

            try
            {
                checkBoxAutoRun.Checked = reg.GetValue(name).ToString() == ExePath;
                if (reg.GetValue(name) != null && reg.GetValue(name).ToString() != ExePath)
                {
                    labelErrAutoRun.Text = "Автозапуск был настроек на другой путь.\nВозможно сменился каталог программы.\nНадо включить флаг еще раз.";
                    labelErrAutoRun.Visible = true;
                }
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

        private void labelErrAutoRun_Click(object sender, EventArgs e)
        {

        }
    }
}
