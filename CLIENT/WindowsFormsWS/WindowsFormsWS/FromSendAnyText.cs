
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWS
{
    public partial class FromSendAnyText : Form
    {
        public Form1 own;

        public SoundRecord sr;


        public FromSendAnyText()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (sr.Recording)
            {
                sr.Stop();

            }
            own.FormSendAnyTextClosing(this);
        }

        private void FromSendAnyText_Load(object sender, EventArgs e)
        {
            sr = new SoundRecord();
            VisibleHendler();
        }

        void VisibleHendler()
        {
            buttonPlay.Visible = sr.recordedAudio != null;
            buttonDelRec.Visible = sr.recordedAudio != null;

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (sr.Recording)
            {
                sr.Stop();
                buttonStart.Text = "Записать";

            }
            else
            {
                sr.Start();
                buttonStart.Text = "Остановить";
            }

            VisibleHendler();

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            sr.Play();
        }

        private void buttonDelRec_Click(object sender, EventArgs e)
        {
            sr = new SoundRecord();
            buttonStart.Text = "Записать";
            VisibleHendler();
        }

        private void FromSendAnyText_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void FromSendAnyText_FormClosing(object sender, FormClosingEventArgs e)
        {
            sr.Stop();
            sr = new SoundRecord();
        }

        private void FromSendAnyText_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void TextSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                own.FormSendAnyTextClosing(this);
            }
        }
    }
}
