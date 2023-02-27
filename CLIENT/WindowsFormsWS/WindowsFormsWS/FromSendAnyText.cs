using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWS
{
    public partial class FromSendAnyText : Form
    {
        public Form1 own;

        public FromSendAnyText()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            own.FormSendAnyTextClosing(this);
        }

        private void FromSendAnyText_Load(object sender, EventArgs e)
        {

        }
    }
}
