using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
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
        public bool Speech;
        public Form1.Message mes;
        bool Speeching = true;
        SpeechSynthesizer synth;
        bool SendedTypingText = false;

        async Task SpeakAsync()
        {
            synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Rate = 3;
            while (Speeching)
            {
                synth.SpeakAsync($"Сообщение от {mes.sender}. {mes.text}");
                await Task.Delay(1000);
            }
        }



        private void showWindosWithMessage_Load(object sender, EventArgs e)
        {

            string programDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string ring1_wav = programDirectory + "\\" + "ring1.wav";

            sp = new SoundPlayer(ring1_wav);

            if (!Speech)
            {
                sp.Load();
                sp.PlayLooping();
            } else {
                SpeakAsync();
            }

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = own.sett.timeOutCall * 1000;
            labelErr.Visible = false;

            
        }

        private void btnStopSound_Click(object sender, EventArgs e)
        {
            sp.Stop();
            Speeching = false;
            
            synth?.Pause();
        }

        private void showWindosWithMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Stop();
            Speeching = false;
            synth?.Pause();

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
            synth?.Pause();
            own.ClosingFormMessage(this, false);
            
        }

        private void buttonWillCall_Click(object sender, EventArgs e)
        {
            respons = "Сейчас сделаю";
            own.ClosingFormMessage(this);

        }

        private void buttonWillCall_1min_Click(object sender, EventArgs e)
        {
            respons = "Сделаю через 1 мин.";
            own.ClosingFormMessage(this);

        }

        private void buttonWillCall_5min_Click(object sender, EventArgs e)
        {
            respons = "Сделаю через 5 мин.";
            own.ClosingFormMessage(this);

        }

        private void buttonWillCall_10min_Click(object sender, EventArgs e)
        {
            respons = "Сделаю через 10 мин.";
            own.ClosingFormMessage(this);

        }

       

        private void buttonClose_Click(object sender, EventArgs e)
        {
            respons = "Сообщение закрыто без ответа";
            own.ClosingFormMessage(this);

        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            respons = richTextBoxAnswer.Text;
            own.ClosingFormMessage(this);
        }

        private void richTextBoxAnswer_TextChanged(object sender, EventArgs e)
        {

            if (!SendedTypingText)
            {

                timer1.Enabled = false;
                timer1.Stop();

                sp.Stop();
                Speeching = false;

                synth?.Pause();

                own.Send(new Form1.Message { sender = mes.recipient, recipient = mes.sender, typeMessage = "forHistory", text = $"{mes.recipient} начал набирать ответ.." });

                SendedTypingText = true;
            }
        }

        private void richTextBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                respons = richTextBoxAnswer.Text;
                own.ClosingFormMessage(this);
            }
        }

        private void showWindosWithMessage_Activated(object sender, EventArgs e)
        {
            
        }

        private void showWindosWithMessage_Shown(object sender, EventArgs e)
        {
            richTextBoxAnswer.Focus();
        }
    }
}
