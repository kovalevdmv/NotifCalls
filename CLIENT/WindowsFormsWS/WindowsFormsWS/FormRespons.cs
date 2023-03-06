using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWS
{
    public partial class FormRespons : Form
    {
        public FormRespons()
        {
            InitializeComponent();
        }

        public byte[] recordedAudio;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1.Message mes;

        public bool Speech;

        bool Speeching = true;

        SpeechSynthesizer synth;


        public string sender;
        public string text;

        async Task SpeakAsync()
        {
            synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Rate = 3;
            synth.SpeakAsync($"Сообщение от {sender}. {text}");
        }

        private void FormRespons_Load(object sender, EventArgs e)
        {
            var sr = new SoundRecord();
            sr.recordedAudio = recordedAudio;
            sr.Play();
            buttonPlayMess.Visible = recordedAudio != null;

            if (Speech && recordedAudio == null)
            {
                SpeakAsync();
            }

            buttonStopSpeech.Visible = Speech;
        }

        private void labelFrom_Click(object sender, EventArgs e)
        {
            var sr = new SoundRecord();
            sr.recordedAudio = recordedAudio;
            sr.Play();
        }

        private void buttonPlayMess_Click(object sender, EventArgs e)
        {
            var sr = new SoundRecord();
            sr.recordedAudio = recordedAudio;
            sr.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Speeching = false;

            synth?.Pause();
        }
    }
}
