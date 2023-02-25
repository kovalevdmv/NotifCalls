using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWS
{
    public partial class showWindosWithMessage : Form
    {
        public showWindosWithMessage()
        {
            InitializeComponent();
        }

        SoundPlayer sp;
        public string respons = "";
        public Form1 own;

        private void showWindosWithMessage_Load(object sender, EventArgs e)
        {
            sp = new SoundPlayer("ring1.wav");
            sp.Load();
            sp.PlayLooping();

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = own.sett.timeOutCall * 1000;
            labelErr.Visible = false;
        }

        private void btnStopSound_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }

        private void showWindosWithMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Stop();
        }

        private void buttonReson2_Click(object sender, EventArgs e)
        {
            respons = "Разговариваю, не могу ответить";
            own.ClosingFormMessage(this);
        }

        private void buttonReson3_Click(object sender, EventArgs e)
        {
            respons = "На совещании";
            own.ClosingFormMessage(this);
        }

        private void buttonReson1_Click(object sender, EventArgs e)
        {
            respons = "Занят";
            own.ClosingFormMessage(this);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelErr.Visible = true;
            sp.Stop();
            timer1.Stop();
            timer1.Enabled = false;
            respons = "Не ответил. Звонок завершен по таймауту";
            own.ClosingFormMessage(this, false);
        }

        private void buttonWillCall_Click(object sender, EventArgs e)
        {
            respons = "Сейчас перезвоню";
            own.ClosingFormMessage(this);

        }

        private void buttonWillCall_1min_Click(object sender, EventArgs e)
        {
            respons = "Перезвоню через 1 мин.";
            own.ClosingFormMessage(this);

        }

        private void buttonWillCall_5min_Click(object sender, EventArgs e)
        {
            respons = "Перезвоню через 5 мин.";
            own.ClosingFormMessage(this);

        }

        private void buttonWillCall_10min_Click(object sender, EventArgs e)
        {
            respons = "Перезвоню через 10 мин.";
            own.ClosingFormMessage(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            respons = "Отвечу как только так сразу";
            own.ClosingFormMessage(this);
        }
    }
}
