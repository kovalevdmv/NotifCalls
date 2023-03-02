namespace WindowsFormsWS
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.nick = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxConnectStart = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textTimeOut = new System.Windows.Forms.MaskedTextBox();
            this.textBoxServer = new System.Windows.Forms.MaskedTextBox();
            this.showMsgBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.countLinesHistory = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAutoRun = new System.Windows.Forms.CheckBox();
            this.labelErrAutoRun = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // nick
            // 
            this.nick.AutoSize = true;
            this.nick.Location = new System.Drawing.Point(12, 9);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(103, 13);
            this.nick.TabIndex = 0;
            this.nick.Text = "Имя по умолчанию";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(12, 28);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(147, 20);
            this.textBoxNick.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сервер";
            // 
            // checkBoxConnectStart
            // 
            this.checkBoxConnectStart.AutoSize = true;
            this.checkBoxConnectStart.Location = new System.Drawing.Point(165, 77);
            this.checkBoxConnectStart.Name = "checkBoxConnectStart";
            this.checkBoxConnectStart.Size = new System.Drawing.Size(158, 17);
            this.checkBoxConnectStart.TabIndex = 6;
            this.checkBoxConnectStart.Text = "Подключаться при старте";
            this.checkBoxConnectStart.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(248, 388);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 65);
            this.label2.TabIndex = 8;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // textTimeOut
            // 
            this.textTimeOut.Location = new System.Drawing.Point(15, 183);
            this.textTimeOut.Mask = "00";
            this.textTimeOut.Name = "textTimeOut";
            this.textTimeOut.Size = new System.Drawing.Size(41, 20);
            this.textTimeOut.TabIndex = 10;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(12, 77);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(147, 20);
            this.textBoxServer.TabIndex = 11;
            // 
            // showMsgBox
            // 
            this.showMsgBox.AutoSize = true;
            this.showMsgBox.Location = new System.Drawing.Point(12, 224);
            this.showMsgBox.Name = "showMsgBox";
            this.showMsgBox.Size = new System.Drawing.Size(271, 43);
            this.showMsgBox.TabIndex = 12;
            this.showMsgBox.Text = "Показывать диалоговое окно при ответе.\r\nЕсли не установлено, будет только добавле" +
    "ние \r\nв окно истории\r\n";
            this.showMsgBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(165, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "(при изменении \r\nзапуститься переподключение)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 393);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Страница программы (новые версии)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // countLinesHistory
            // 
            this.countLinesHistory.Location = new System.Drawing.Point(12, 298);
            this.countLinesHistory.Mask = "00";
            this.countLinesHistory.Name = "countLinesHistory";
            this.countLinesHistory.Size = new System.Drawing.Size(44, 20);
            this.countLinesHistory.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество строк в истории (больше будет очищаться)";
            // 
            // checkBoxAutoRun
            // 
            this.checkBoxAutoRun.AutoSize = true;
            this.checkBoxAutoRun.Location = new System.Drawing.Point(17, 335);
            this.checkBoxAutoRun.Name = "checkBoxAutoRun";
            this.checkBoxAutoRun.Size = new System.Drawing.Size(189, 17);
            this.checkBoxAutoRun.TabIndex = 17;
            this.checkBoxAutoRun.Text = "Автозагрузка вместе с windows";
            this.checkBoxAutoRun.UseVisualStyleBackColor = true;
            this.checkBoxAutoRun.CheckedChanged += new System.EventHandler(this.checkBoxAutoRun_CheckedChanged);
            // 
            // labelErrAutoRun
            // 
            this.labelErrAutoRun.AutoSize = true;
            this.labelErrAutoRun.ForeColor = System.Drawing.Color.Red;
            this.labelErrAutoRun.Location = new System.Drawing.Point(14, 355);
            this.labelErrAutoRun.Name = "labelErrAutoRun";
            this.labelErrAutoRun.Size = new System.Drawing.Size(35, 13);
            this.labelErrAutoRun.TabIndex = 18;
            this.labelErrAutoRun.Text = "label5";
            this.labelErrAutoRun.Click += new System.EventHandler(this.labelErrAutoRun_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelErrAutoRun);
            this.Controls.Add(this.checkBoxAutoRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countLinesHistory);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showMsgBox);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.textTimeOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxConnectStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.nick);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nick;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBoxConnectStart;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox textTimeOut;
        public System.Windows.Forms.MaskedTextBox textBoxServer;
        public System.Windows.Forms.CheckBox showMsgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.MaskedTextBox countLinesHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAutoRun;
        private System.Windows.Forms.Label labelErrAutoRun;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}