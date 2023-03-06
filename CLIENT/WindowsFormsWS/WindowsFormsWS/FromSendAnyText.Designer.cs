namespace WindowsFormsWS
{
    partial class FromSendAnyText
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
            this.TextSend = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Speech = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.recipient = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonDelRec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextSend
            // 
            this.TextSend.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextSend.Location = new System.Drawing.Point(12, 85);
            this.TextSend.Name = "TextSend";
            this.TextSend.Size = new System.Drawing.Size(412, 67);
            this.TextSend.TabIndex = 0;
            this.TextSend.Text = "";
            this.TextSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextSend_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текст";
            // 
            // Speech
            // 
            this.Speech.AutoSize = true;
            this.Speech.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speech.Location = new System.Drawing.Point(12, 12);
            this.Speech.Name = "Speech";
            this.Speech.Size = new System.Drawing.Size(243, 21);
            this.Speech.TabIndex = 2;
            this.Speech.Text = "Озвучить на удаленном ПК";
            this.Speech.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.Location = new System.Drawing.Point(430, 85);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(124, 67);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Отправить (Enter)";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Если не выбрано, у получателя будет звук звонка.\r\nиначе, звонка не будет, вместо " +
    "него будет \r\nпо кругу воспроизводиться текст указанный ниже.\r\n";
            // 
            // recipient
            // 
            this.recipient.AutoSize = true;
            this.recipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipient.Location = new System.Drawing.Point(11, 36);
            this.recipient.Name = "recipient";
            this.recipient.Size = new System.Drawing.Size(57, 20);
            this.recipient.TabIndex = 5;
            this.recipient.Text = "label3";
            // 
            // buttonStart
            // 
            this.buttonStart.Image = global::WindowsFormsWS.Properties.Resources.Record;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(12, 186);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(115, 38);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Записать";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(133, 186);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(93, 38);
            this.buttonPlay.TabIndex = 7;
            this.buttonPlay.Text = "Воспроизвести";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonDelRec
            // 
            this.buttonDelRec.Location = new System.Drawing.Point(232, 186);
            this.buttonDelRec.Name = "buttonDelRec";
            this.buttonDelRec.Size = new System.Drawing.Size(65, 38);
            this.buttonDelRec.TabIndex = 8;
            this.buttonDelRec.Text = "Удалить";
            this.buttonDelRec.UseVisualStyleBackColor = true;
            this.buttonDelRec.Click += new System.EventHandler(this.buttonDelRec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Прикрепленное аудио сообщение";
            // 
            // FromSendAnyText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDelRec);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.recipient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.Speech);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSend);
            this.Name = "FromSendAnyText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FromSendAnyText_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromSendAnyText_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FromSendAnyText_FormClosed);
            this.Load += new System.EventHandler(this.FromSendAnyText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox TextSend;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox Speech;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label recipient;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonDelRec;
        private System.Windows.Forms.Label label3;
    }
}