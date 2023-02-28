namespace WindowsFormsWS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.nick = new System.Windows.Forms.TextBox();
            this.TableClients = new System.Windows.Forms.DataGridView();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnToTray = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЛогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelErr = new System.Windows.Forms.Label();
            this.textHistory = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSendAnyText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableClients)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(274, 27);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(96, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(51, 29);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(217, 20);
            this.nick.TabIndex = 2;
            // 
            // TableClients
            // 
            this.TableClients.AllowUserToAddRows = false;
            this.TableClients.AllowUserToDeleteRows = false;
            this.TableClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nickname});
            this.TableClients.Location = new System.Drawing.Point(12, 54);
            this.TableClients.Name = "TableClients";
            this.TableClients.ReadOnly = true;
            this.TableClients.Size = new System.Drawing.Size(368, 255);
            this.TableClients.TabIndex = 8;
            this.TableClients.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableClients_CellEnter);
            this.TableClients.Click += new System.EventHandler(this.TableClients_Click);
            // 
            // nickname
            // 
            this.nickname.HeaderText = "Имя";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            this.nickname.Width = 200;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Звонки";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnToTray
            // 
            this.btnToTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToTray.Location = new System.Drawing.Point(386, 29);
            this.btnToTray.Name = "btnToTray";
            this.btnToTray.Size = new System.Drawing.Size(206, 23);
            this.btnToTray.TabIndex = 10;
            this.btnToTray.Text = "Свернуть в трей";
            this.btnToTray.UseVisualStyleBackColor = true;
            this.btnToTray.Click += new System.EventHandler(this.btnToTray_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status1,
            this.Status3,
            this.Status2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status1
            // 
            this.Status1.Name = "Status1";
            this.Status1.Size = new System.Drawing.Size(45, 17);
            this.Status1.Text = "Status1";
            // 
            // Status3
            // 
            this.Status3.Name = "Status3";
            this.Status3.Size = new System.Drawing.Size(45, 17);
            this.Status3.Text = "Status3";
            // 
            // Status2
            // 
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(45, 17);
            this.Status2.Text = "Status2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.показатьЛогToolStripMenuItem,
            this.закрытьПрограммуToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // показатьЛогToolStripMenuItem
            // 
            this.показатьЛогToolStripMenuItem.Name = "показатьЛогToolStripMenuItem";
            this.показатьЛогToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.показатьЛогToolStripMenuItem.Text = "Показать лог";
            this.показатьЛогToolStripMenuItem.Click += new System.EventHandler(this.показатьЛогToolStripMenuItem_Click);
            // 
            // закрытьПрограммуToolStripMenuItem
            // 
            this.закрытьПрограммуToolStripMenuItem.Name = "закрытьПрограммуToolStripMenuItem";
            this.закрытьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.закрытьПрограммуToolStripMenuItem.Text = "Закрыть программу";
            this.закрытьПрограммуToolStripMenuItem.Click += new System.EventHandler(this.закрытьПрограммуToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(386, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ответь на звонок в ММ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(386, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Срочно перезвони";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(386, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Отменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelErr
            // 
            this.labelErr.AutoSize = true;
            this.labelErr.BackColor = System.Drawing.Color.Red;
            this.labelErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErr.Location = new System.Drawing.Point(12, 54);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(106, 37);
            this.labelErr.TabIndex = 21;
            this.labelErr.Text = "label1";
            // 
            // textHistory
            // 
            this.textHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textHistory.BackColor = System.Drawing.SystemColors.Info;
            this.textHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHistory.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHistory.Location = new System.Drawing.Point(12, 315);
            this.textHistory.Name = "textHistory";
            this.textHistory.ReadOnly = true;
            this.textHistory.Size = new System.Drawing.Size(580, 77);
            this.textHistory.TabIndex = 22;
            this.textHistory.Text = "";
            this.textHistory.WordWrap = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(386, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Свяжись со мной";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSendAnyText
            // 
            this.buttonSendAnyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendAnyText.Location = new System.Drawing.Point(386, 194);
            this.buttonSendAnyText.Name = "buttonSendAnyText";
            this.buttonSendAnyText.Size = new System.Drawing.Size(206, 23);
            this.buttonSendAnyText.TabIndex = 24;
            this.buttonSendAnyText.Text = "Отправить произвольный текст";
            this.buttonSendAnyText.UseVisualStyleBackColor = true;
            this.buttonSendAnyText.Click += new System.EventHandler(this.buttonSendAnyText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 424);
            this.Controls.Add(this.buttonSendAnyText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textHistory);
            this.Controls.Add(this.labelErr);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToTray);
            this.Controls.Add(this.TableClients);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.buttonConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звонки";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableClients)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        public System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.DataGridView TableClients;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnToTray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьЛогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьПрограммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Status2;
        private System.Windows.Forms.ToolStripStatusLabel Status3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelErr;
        private System.Windows.Forms.RichTextBox textHistory;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSendAnyText;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
    }
}

