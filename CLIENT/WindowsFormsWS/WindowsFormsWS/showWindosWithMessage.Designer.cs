namespace WindowsFormsWS
{
    partial class showWindosWithMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showWindosWithMessage));
            this.btnStopSound = new System.Windows.Forms.Button();
            this.labelWho = new System.Windows.Forms.Label();
            this.buttonReson2 = new System.Windows.Forms.Button();
            this.buttonReson3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelErr = new System.Windows.Forms.Label();
            this.buttonWillCall = new System.Windows.Forms.Button();
            this.buttonWillCall_1min = new System.Windows.Forms.Button();
            this.buttonWillCall_5min = new System.Windows.Forms.Button();
            this.buttonWillCall_10min = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labText = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDelRec = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPlayMess = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStopSound
            // 
            this.btnStopSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopSound.Location = new System.Drawing.Point(529, 1);
            this.btnStopSound.Name = "btnStopSound";
            this.btnStopSound.Size = new System.Drawing.Size(166, 41);
            this.btnStopSound.TabIndex = 1;
            this.btnStopSound.Text = "Выключить звук";
            this.btnStopSound.UseVisualStyleBackColor = true;
            this.btnStopSound.Click += new System.EventHandler(this.btnStopSound_Click);
            // 
            // labelWho
            // 
            this.labelWho.AutoSize = true;
            this.labelWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWho.Location = new System.Drawing.Point(17, 8);
            this.labelWho.Name = "labelWho";
            this.labelWho.Size = new System.Drawing.Size(76, 25);
            this.labelWho.TabIndex = 2;
            this.labelWho.Text = "label1";
            this.labelWho.Click += new System.EventHandler(this.labelWho_Click);
            // 
            // buttonReson2
            // 
            this.buttonReson2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReson2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReson2.Location = new System.Drawing.Point(16, 189);
            this.buttonReson2.Name = "buttonReson2";
            this.buttonReson2.Size = new System.Drawing.Size(279, 51);
            this.buttonReson2.TabIndex = 4;
            this.buttonReson2.Text = "Разговариваю (не могу ответить)";
            this.buttonReson2.UseVisualStyleBackColor = true;
            this.buttonReson2.Click += new System.EventHandler(this.buttonReson2_Click);
            // 
            // buttonReson3
            // 
            this.buttonReson3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReson3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReson3.Location = new System.Drawing.Point(301, 189);
            this.buttonReson3.Name = "buttonReson3";
            this.buttonReson3.Size = new System.Drawing.Size(148, 51);
            this.buttonReson3.TabIndex = 5;
            this.buttonReson3.Text = "На совещании";
            this.buttonReson3.UseVisualStyleBackColor = true;
            this.buttonReson3.Click += new System.EventHandler(this.buttonReson3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelErr
            // 
            this.labelErr.AutoSize = true;
            this.labelErr.BackColor = System.Drawing.Color.Red;
            this.labelErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErr.Location = new System.Drawing.Point(206, -1);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(219, 37);
            this.labelErr.TabIndex = 14;
            this.labelErr.Text = "Пропущенный";
            // 
            // buttonWillCall
            // 
            this.buttonWillCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWillCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWillCall.Location = new System.Drawing.Point(17, 139);
            this.buttonWillCall.Name = "buttonWillCall";
            this.buttonWillCall.Size = new System.Drawing.Size(459, 44);
            this.buttonWillCall.TabIndex = 15;
            this.buttonWillCall.Text = "Сейчас сделаю";
            this.buttonWillCall.UseVisualStyleBackColor = true;
            this.buttonWillCall.Click += new System.EventHandler(this.buttonWillCall_Click);
            // 
            // buttonWillCall_1min
            // 
            this.buttonWillCall_1min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWillCall_1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWillCall_1min.Location = new System.Drawing.Point(482, 139);
            this.buttonWillCall_1min.Name = "buttonWillCall_1min";
            this.buttonWillCall_1min.Size = new System.Drawing.Size(64, 44);
            this.buttonWillCall_1min.TabIndex = 16;
            this.buttonWillCall_1min.Text = "1 мин.";
            this.buttonWillCall_1min.UseVisualStyleBackColor = true;
            this.buttonWillCall_1min.Click += new System.EventHandler(this.buttonWillCall_1min_Click);
            // 
            // buttonWillCall_5min
            // 
            this.buttonWillCall_5min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWillCall_5min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWillCall_5min.Location = new System.Drawing.Point(552, 139);
            this.buttonWillCall_5min.Name = "buttonWillCall_5min";
            this.buttonWillCall_5min.Size = new System.Drawing.Size(63, 44);
            this.buttonWillCall_5min.TabIndex = 17;
            this.buttonWillCall_5min.Text = "5 мин.";
            this.buttonWillCall_5min.UseVisualStyleBackColor = true;
            this.buttonWillCall_5min.Click += new System.EventHandler(this.buttonWillCall_5min_Click);
            // 
            // buttonWillCall_10min
            // 
            this.buttonWillCall_10min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWillCall_10min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWillCall_10min.Location = new System.Drawing.Point(621, 139);
            this.buttonWillCall_10min.Name = "buttonWillCall_10min";
            this.buttonWillCall_10min.Size = new System.Drawing.Size(75, 44);
            this.buttonWillCall_10min.TabIndex = 18;
            this.buttonWillCall_10min.Text = "10 мин.";
            this.buttonWillCall_10min.UseVisualStyleBackColor = true;
            this.buttonWillCall_10min.Click += new System.EventHandler(this.buttonWillCall_10min_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(455, 190);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(241, 50);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Закрыть без ответа";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labText
            // 
            this.labText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labText.BackColor = System.Drawing.SystemColors.Control;
            this.labText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText.Location = new System.Drawing.Point(17, 48);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(679, 85);
            this.labText.TabIndex = 21;
            this.labText.Text = "";
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxAnswer.Location = new System.Drawing.Point(17, 246);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(519, 45);
            this.richTextBoxAnswer.TabIndex = 22;
            this.richTextBoxAnswer.Text = "";
            this.richTextBoxAnswer.TextChanged += new System.EventHandler(this.richTextBoxAnswer_TextChanged);
            this.richTextBoxAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxAnswer_KeyDown);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer.Location = new System.Drawing.Point(542, 246);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(153, 45);
            this.buttonAnswer.TabIndex = 23;
            this.buttonAnswer.Text = "Ответить (Enter)";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Прикрепленное аудио сообщение";
            // 
            // buttonDelRec
            // 
            this.buttonDelRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelRec.Location = new System.Drawing.Point(242, 325);
            this.buttonDelRec.Name = "buttonDelRec";
            this.buttonDelRec.Size = new System.Drawing.Size(66, 40);
            this.buttonDelRec.TabIndex = 26;
            this.buttonDelRec.Text = "Удалить";
            this.buttonDelRec.UseVisualStyleBackColor = true;
            this.buttonDelRec.Click += new System.EventHandler(this.buttonDelRec_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.Location = new System.Drawing.Point(142, 325);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(94, 40);
            this.buttonPlay.TabIndex = 25;
            this.buttonPlay.Text = "Воспроизвести";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPlayMess
            // 
            this.buttonPlayMess.Image = global::WindowsFormsWS.Properties.Resources.AudioMess2;
            this.buttonPlayMess.Location = new System.Drawing.Point(482, 1);
            this.buttonPlayMess.Name = "buttonPlayMess";
            this.buttonPlayMess.Size = new System.Drawing.Size(41, 41);
            this.buttonPlayMess.TabIndex = 28;
            this.buttonPlayMess.UseVisualStyleBackColor = true;
            this.buttonPlayMess.Click += new System.EventHandler(this.buttonPlayMess_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Image = global::WindowsFormsWS.Properties.Resources.Record;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(15, 325);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 40);
            this.buttonStart.TabIndex = 24;
            this.buttonStart.Text = "Записать";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // showWindosWithMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 374);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPlayMess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDelRec);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.labText);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonWillCall_10min);
            this.Controls.Add(this.buttonWillCall_5min);
            this.Controls.Add(this.buttonWillCall_1min);
            this.Controls.Add(this.buttonWillCall);
            this.Controls.Add(this.labelErr);
            this.Controls.Add(this.buttonReson3);
            this.Controls.Add(this.buttonReson2);
            this.Controls.Add(this.labelWho);
            this.Controls.Add(this.btnStopSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "showWindosWithMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сообщение";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.showWindosWithMessage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.showWindosWithMessage_FormClosing);
            this.Load += new System.EventHandler(this.showWindosWithMessage_Load);
            this.Shown += new System.EventHandler(this.showWindosWithMessage_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStopSound;
        public System.Windows.Forms.Label labelWho;
        private System.Windows.Forms.Button buttonReson2;
        private System.Windows.Forms.Button buttonReson3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelErr;
        private System.Windows.Forms.Button buttonWillCall;
        private System.Windows.Forms.Button buttonWillCall_1min;
        private System.Windows.Forms.Button buttonWillCall_5min;
        private System.Windows.Forms.Button buttonWillCall_10min;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.RichTextBox labText;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDelRec;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPlayMess;
    }
}