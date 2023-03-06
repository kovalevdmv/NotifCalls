using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace WindowsFormsWS
{

    public class SoundRecord
    {

        public byte[] recordedAudio;

        WaveInEvent waveIn;
        public bool Recording;
        public MemoryStream outputStream;
        public WaveOut waveOut;

        public SoundRecord()
        {
            // Создаем новый объект WaveInEvent
            waveIn = new WaveInEvent();

            // Устанавливаем формат записи (16 бит, 44.1 кГц, моно)
            waveIn.WaveFormat = new WaveFormat(44100, 16, 1);

            outputStream = new MemoryStream();

            waveOut = new WaveOut();
        }

        public void Start()
        {
            waveIn.DataAvailable += (sender, e) =>
            {
                byte[] buffer = e.Buffer;
                outputStream.Write(buffer, 0, buffer.Length);
            };

            waveIn.StartRecording();

            Recording = true;
        }

        public void Stop()
        {
            waveIn.StopRecording();

            recordedAudio = outputStream.ToArray();

            Recording = false;
        }

        public void Play()
        {
            if (recordedAudio == null) 
                return;

            
            WaveStream waveStream = new RawSourceWaveStream(new MemoryStream(recordedAudio), waveIn.WaveFormat);
            waveOut.Init(waveStream);
            waveOut.Play();
        }

    }

}
