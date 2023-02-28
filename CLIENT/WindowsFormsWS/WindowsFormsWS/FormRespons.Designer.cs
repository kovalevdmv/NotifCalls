namespace WindowsFormsWS
{
    partial class FormRespons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRespons));
            this.labelFrom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(8, 9);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(57, 20);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.labelAnswer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.Location = new System.Drawing.Point(12, 43);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(346, 93);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "";
            // 
            // FormRespons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRespons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ответ";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox labelAnswer;
    }
}