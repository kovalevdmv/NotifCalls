using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            own.ClosingFormSettings(this);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://84.42.62.101/?p=137");
        }
    }
}
