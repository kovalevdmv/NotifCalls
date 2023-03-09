using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Speech.Synthesis;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsWS
{
    public partial class Form1 : Form
    {

        showWindosWithMessage FormShowMessage;

        FromSendAnyText FormAnyText;

        public class settings
        {
            public string nick { get; set; }
            public string server { get; set; }

            public bool connectStart { get; set; }

            public int timeOutCall { get; set; }

            public bool showMsgBox { get; set; }

            public int countLinesHistory { get; set; }


        }

        public int ver = 9;

        public settings sett;


        private ClientWebSocket client;

        void addHistory(string s)
        {
            if (textHistory.Lines.Count() > sett.countLinesHistory)
            {
                textHistory.Text = "";
            }
            //textHistory.Text += $"[{textHistory.Lines.Count()}][{DateTime.Now.ToString("HH:mm")}] {s}\n";
            textHistory.Text += $"[{DateTime.Now.ToString("HH:mm")}] {s}\n";

            textHistory.SelectionStart = textHistory.TextLength;
            textHistory.ScrollToCaret();
        }

        void ChangeStatus(string s)
        {
            Status2.Text = s + " |";
            if (!s.Equals(""))
            {
                addHistory(s);
            }
        }

        public async Task ConnectAsync(Uri uri, CancellationToken cancellationToken)
        {
            client = new ClientWebSocket();
            await client.ConnectAsync(uri, cancellationToken);
            addLog($"Connected to {uri}");
        }

        public void HendleStatusConnection()
        {
            Status1.Text = $"Нет подключения |";
            buttonConnect.Visible = !(client.State == WebSocketState.Open);
            nick.Enabled = !(client.State == WebSocketState.Open);

            if (client.State == WebSocketState.Open)
            {
                Status1.Text = $"Подключено к {sett.server} |";
            }
        }

        public async Task ReceiveLoopAsync(CancellationToken cancellationToken)
        {

            string all_mess = "";

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    int length_buf = 1024;
                    var buffer = new byte[length_buf];
                    var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);
                    
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        addLog("Connection closed by server");
                        break;
                    }
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        all_mess += message;
                        if (result.EndOfMessage == false)
                            continue;

                        var mes = JsonSerializer.Deserialize<Message>(all_mess);
                        all_mess = "";
                        if (mes.sender == "server")
                        {
                            if (mes.typeMessage == "clientsList")
                            {
                                var clientList = JsonSerializer.Deserialize<List<Client>>(mes.text);
                                TableClients.Rows.Clear();
                                foreach (var clint in clientList)
                                {
                                    object[] row = { "" };
                                    row[0] = clint.nickname;
                                    TableClients.Rows.Add(row);
                                }
                            }
                        }
                        if (mes.typeMessage == "showWindosWithMessage" || mes.typeMessage == "SendAnyTextSpeech" || mes.typeMessage == "SendAnyText" || mes.typeMessage == "SendAnyTextAudioMessage")
                        {
                            FormShowMessage = new showWindosWithMessage();
                            FormShowMessage.labelWho.Text = mes.sender;
                            if (mes.typeMessage == "SendAnyTextAudioMessage")
                            {
                                AudioMessage AMess = JsonSerializer.Deserialize<AudioMessage>(mes.text);
                                FormShowMessage.labText.Text = $"(Голосовое сообщение)\n{AMess.text}";
                                FormShowMessage.recordedAudio = Convert.FromBase64String(AMess.AudioData);

                            }
                            else
                            {
                                FormShowMessage.labText.Text = mes.text;
                            }

                            FormShowMessage.own = this;
                            FormShowMessage.Speech = mes.typeMessage == "SendAnyTextSpeech";
                            FormShowMessage.mes = mes;
                            FormShowMessage.Show();

                            addHistory($"От {mes.sender} \"{FormShowMessage.labText.Text}\"");

                            Send(new Message { sender = nick.Text, recipient = mes.sender, typeMessage = "showWindosWithMessage_respons", text = "OpenWindows" });
                        }
                        if (mes.typeMessage == "text" || mes.typeMessage == "textSpeech" || mes.typeMessage == "textAudioMessage")
                        {
                            var text = mes.text;

                            if (mes.typeMessage == "textAudioMessage")
                            {
                                AudioMessage AMess = JsonSerializer.Deserialize<AudioMessage>(mes.text);
                                text =  $"(Голосовое сообщение)\n{AMess.text}";
                            }



                            if (sett.showMsgBox)
                            {
                                var f = new FormRespons();
                                f.Speech = mes.typeMessage == "textSpeech";

                                if (mes.typeMessage == "textAudioMessage")
                                {
                                    AudioMessage AMess = JsonSerializer.Deserialize<AudioMessage>(mes.text);
                                    text = $"(Голосовое сообщение)\n{AMess.text}";
                                    f.recordedAudio = Convert.FromBase64String(AMess.AudioData);

                                }
                                
                                f.labelFrom.Text = $"Ответ от {mes.sender}";
                                f.labelAnswer.Text = text;
                                f.sender = mes.sender;
                                f.text = text;
                                f.Show();
                            }

                            var respons = $"{mes.sender} ответил \"{text}\"";

                            ChangeStatus(respons);
                        }
                        if (mes.typeMessage == "showWindosWithMessage_respons" && mes.text == "OpenWindows")
                        {
                            ChangeStatus($"Сообщение сейчас открыто у {mes.sender}");
                        }
                        if (mes.typeMessage == "showWindosWithMessage_respons" && mes.text == "CloseWindows")
                        {
                            ChangeStatus($"Сообщение закрыто у {mes.sender}");
                        }
                        if (mes.typeMessage == "showWindosWithMessageCancel")
                        {
                            if (FormShowMessage != null)
                            {
                                FormShowMessage.Close();
                            }

                            Send(new Message { sender = nick.Text, recipient = mes.sender, typeMessage = "showWindosWithMessage_respons", text = "CloseWindows" });

                        }
                        if (mes.typeMessage == "forHistory")
                        {
                            addHistory(mes.text);
                        }
                        addLog(message);
                    }
                }
                catch (WebSocketException ex)
                {
                    HendleStatusConnection();
                    addLog($"WebSocket exception: {ex.Message}");
                    break;
                }
                catch (Exception ex)
                {
                    HendleStatusConnection();
                    addLog($"Exception: {ex.Message}");
                }
            }
        }

        public async Task RunAsync(Uri uri, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    await ConnectAsync(uri, cancellationToken);
                    HendleStatusConnection();
                    Send(new Message { sender = nick.Text });
                    await ReceiveLoopAsync(cancellationToken);
                }
                catch (WebSocketException ex)
                {
                    HendleStatusConnection();
                    addLog($"WebSocket exception: {ex.Message}");
                }
                catch (Exception ex)
                {
                    HendleStatusConnection();
                    addLog($"Exception: {ex.Message}");
                }
                finally
                {
                    HendleStatusConnection();
                    if (client.State != WebSocketState.Closed && client.State != WebSocketState.Aborted)
                    {
                        await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                    }
                }
                addLog("Disconnected, attempting to reconnect in 5 seconds...");
                labelErr.Text = "Соединение с сервером...";
                labelErr.Visible = true;
                await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
                labelErr.Visible = false;

            }
        }


        public class Client
        {
            public string nickname { get; set; }
        }

        public string Log;

        public class Message
        {
            public string sender { get; set; }
            public string recipient { get; set; }
            public string text { get; set; }
            public string typeMessage { get; set; }

        }

        public class AudioMessage
        {
            public string text { get; set; }
            public string AudioData { get; set; }

        }



        public Log FormLog;

        public Form1()
        {
            InitializeComponent();
        }

        void addLog(string s)
        {
            return;
            FormLog.TextLog.Text += $"[{DateTime.Now}] {s}\n";
        }

        CancellationTokenSource cancellationTokenSource;

        bool ClosingByButtonClose;

        async Task Connect()
        {
            var uri = new Uri($"ws://{sett.server}/ws?nickname={nick.Text}");
            cancellationTokenSource = new CancellationTokenSource();

            await RunAsync(uri, cancellationTokenSource.Token);
        }

        public async Task Send(Message mess)
        {
            if (client.State == WebSocketState.Open)
            {
                var buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(mess));
                var text = $"{mess.typeMessage} {mess.text} {client.State}";
                addLog($"Start {text}");
                await client.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, cancellationTokenSource.Token);
                addLog($"End {text}");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nick.Text.ToLower() == "noname")
            {
                MessageBox.Show("Имя не должно noName");
                return;
            }

            if (nick.Text.Equals(""))
            {
                MessageBox.Show("nick не должен быть пустым");
                return;
            }

            Connect();
        }


        public string GetCurrNick()
        {
            if (TableClients.SelectedCells.Count > 0)
            {
                var sel = TableClients.SelectedCells[0].RowIndex;
                var nick = TableClients.Rows[sel].Cells[0].Value;
                if (nick == null) return "";
                return nick.ToString();
            }

            return "";
        }

        public async void sendCall(string s, bool Cancel = false)
        {
            string curNick = GetCurrNick();

            if (curNick.Equals(""))
                return;

            var mess = new Message();

            mess.sender = nick.Text;

            if (Cancel)
            {
                Send(new Message { sender = nick.Text, recipient = curNick, typeMessage = "showWindosWithMessageCancel", text = s });
                ChangeStatus("Ожидание отмены..");
            }
            else
            {
                Send(new Message { sender = nick.Text, recipient = curNick, typeMessage = "showWindosWithMessage", text = s });
                ChangeStatus("Ожидание открытия сообщения..");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnToTray_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        void trayDBClick()
        {
            if (this.ShowInTaskbar)
            {
                WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            trayDBClick();


        }

        void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (e.Mode == PowerModes.Suspend)
            {
                client.Abort();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            string programDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string sett_file_json = programDirectory + "\\" + "settings.json";


            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;

            Text = $"Звонки (версия {ver})";

            ChangeStatus("");
            labelErr.Visible = false;
            FormLog = new Log();

            if (!File.Exists(sett_file_json))
            {

                sett = new settings { nick = "NoName", server = "84.42.62.101:8080", timeOutCall = 15, showMsgBox = true, countLinesHistory = 10 };

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };
                File.WriteAllText(sett_file_json, JsonSerializer.Serialize<settings>(sett, options));

            }
            else
            {
                String sett_file = File.ReadAllText(sett_file_json);
                sett = JsonSerializer.Deserialize<settings>(sett_file);
            }

            nick.Text = sett.nick;

            if (sett.connectStart && !sett.server.Equals("") && !nick.Text.Equals(""))
            {
                Connect();
            }

        }

        private void buttonShowLog_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ClosingByButtonClose;

            WindowState = FormWindowState.Minimized;
            // прячем наше окно из панели
            this.ShowInTaskbar = false;
            // делаем нашу иконку в трее активной
            notifyIcon1.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        public async void ClosingFormMessage(showWindosWithMessage form, bool closeFrom = true)
        {
            var typeMessage = "text";
            var text = form.respons;

            if (form.Speech) // если было озвучка текст, ответить так же озвучкой
            {
                typeMessage = "textSpeech";
            }

            if (form.sr.recordedAudio != null) // есть данные аудио
            {
                typeMessage = "textAudioMessage";
                text = Serialize<AudioMessage>(new AudioMessage { text = text, AudioData = Convert.ToBase64String(form.sr.recordedAudio) });
            }

            await Send(new Message { sender = nick.Text, recipient = form.labelWho.Text, typeMessage = "showWindosWithMessage_respons", text = "CloseWindows" });

            await Send(new Message { sender = nick.Text, recipient = form.labelWho.Text, typeMessage = typeMessage, text = text });

            if (closeFrom)
            {
                form.Dispose();
                form.Close();
            }

            addHistory($"Твой ответ \"{form.respons}\"");

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {


        }

        string Serialize<T>(T data)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            return JsonSerializer.Serialize<T>(data, options);
        }

        public void ClosingFormSettings(FormSettings f)
        {
            bool needToRestart = sett.nick != f.textBoxNick.Text || sett.server != f.textBoxServer.Text;

            sett.nick = f.textBoxNick.Text;
            sett.server = f.textBoxServer.Text;
            sett.connectStart = f.checkBoxConnectStart.Checked;
            sett.timeOutCall = Convert.ToInt32(f.textTimeOut.Text);
            sett.showMsgBox = f.showMsgBox.Checked;
            nick.Text = f.textBoxNick.Text;
            sett.countLinesHistory = Convert.ToInt32(f.countLinesHistory.Text);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            File.WriteAllText("settings.json", JsonSerializer.Serialize<settings>(sett, options));

            f.Close();

            if (needToRestart)
                if (client == null && sett.connectStart)
                    Connect();
                else
                    client?.Abort();

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormSettings();
            f.textBoxNick.Text = sett.nick;
            f.textBoxServer.Text = sett.server;
            f.checkBoxConnectStart.Checked = sett.connectStart;
            f.textTimeOut.Text = sett.timeOutCall.ToString();
            f.countLinesHistory.Text = sett.countLinesHistory.ToString();
            f.own = this;
            f.showMsgBox.Checked = sett.showMsgBox;
            f.Show();
        }

        private void показатьЛогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLog.Show();
        }

        private void закрытьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClosingByButtonClose = true;
            Close();
        }

        private void ответьНаЗвонокВММToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCall("Ответь на звонок в matter most");
        }

        private void срочноПерезвониToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCall("Срочно перезвони");
        }

        private void прерватьЗвонокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCall("Отменить звонок", true);
        }

        private void прерватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCall("Отменить звонок", true);
        }

        private void отправитьЗвонокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TableClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Status3.Text = GetCurrNick() + " |";
        }

        private void TableClients_Click(object sender, EventArgs e)
        {
            Status3.Text = GetCurrNick() + " |";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sendCall("Ответь на звонок в matter most");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sendCall("Срочно перезвони");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendCall("Отменить звонок", true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendCall("Свяжись со мной");
        }

        private void buttonSendAnyText_Click(object sender, EventArgs e)
        {

            var cur = GetCurrNick();
            if (cur.Equals(""))
                return;

            if (IsFormOpen(typeof(FromSendAnyText)))
            {
                FormAnyText.Activate();
            }
            else
            {

                FormAnyText = new FromSendAnyText();
                FormAnyText.own = this;
                FormAnyText.recipient.Text = cur;
                FormAnyText.Show();

            }
            
        }

        public void FormSendAnyTextClosing(FromSendAnyText f)
        {

            string text = f.TextSend.Text;

            var typeMessage = "SendAnyText";

            if (f.Speech.Checked)
                typeMessage = "SendAnyTextSpeech";

            if (f.sr.recordedAudio != null) // есть данные аудио
            {
                typeMessage = "SendAnyTextAudioMessage";
                text = Serialize<AudioMessage>(new AudioMessage { text = f.TextSend.Text, AudioData = Convert.ToBase64String(f.sr.recordedAudio) });
            }

            Send(new Message { sender = nick.Text, recipient = f.recipient.Text, typeMessage = typeMessage, text = text });
            f.Dispose();
            f.Close();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(FromSendAnyText)))
            {
                FormAnyText.Activate();
            }
            if (IsFormOpen(typeof(showWindosWithMessage)))
            {
                FormShowMessage.Activate();
            }

        }

        bool IsFormOpen(Type formType)
        {
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    return true;
                }
            }
            return false;
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            настройкиToolStripMenuItem_Click(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void закрытьПрограммуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClosingByButtonClose = true;
            Close();
        }

        private void показатьскрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trayDBClick();
        }
    }
}
