namespace Simcorp.IMS.MobilePhone.MessageForm {
    partial class NewMessageForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStopMessages = new System.Windows.Forms.Button();
            this.buttonGenerateMessages = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxNewMessage = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStopMessages);
            this.panel1.Controls.Add(this.buttonGenerateMessages);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBoxNewMessage);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 290);
            this.panel1.TabIndex = 0;
            // 
            // buttonStopMessages
            // 
            this.buttonStopMessages.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStopMessages.Location = new System.Drawing.Point(107, 30);
            this.buttonStopMessages.Name = "buttonStopMessages";
            this.buttonStopMessages.Size = new System.Drawing.Size(140, 21);
            this.buttonStopMessages.TabIndex = 5;
            this.buttonStopMessages.Text = "Stop Messages";
            this.buttonStopMessages.UseVisualStyleBackColor = false;
            this.buttonStopMessages.Click += new System.EventHandler(this.ButtonStopMesssages);
            // 
            // buttonGenerateMessages
            // 
            this.buttonGenerateMessages.BackColor = System.Drawing.Color.DarkGray;
            this.buttonGenerateMessages.Location = new System.Drawing.Point(107, 3);
            this.buttonGenerateMessages.Name = "buttonGenerateMessages";
            this.buttonGenerateMessages.Size = new System.Drawing.Size(140, 21);
            this.buttonGenerateMessages.TabIndex = 4;
            this.buttonGenerateMessages.Text = "Generate Messages";
            this.buttonGenerateMessages.UseVisualStyleBackColor = false;
            this.buttonGenerateMessages.Click += new System.EventHandler(this.ButtonGenerateMessages);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Location = new System.Drawing.Point(167, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Own Message";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonSendMessage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type your message here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            // 
            // richTextBoxNewMessage
            // 
            this.richTextBoxNewMessage.Location = new System.Drawing.Point(9, 120);
            this.richTextBoxNewMessage.Name = "richTextBoxNewMessage";
            this.richTextBoxNewMessage.Size = new System.Drawing.Size(238, 159);
            this.richTextBoxNewMessage.TabIndex = 1;
            this.richTextBoxNewMessage.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.GenerateMessages);
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 308);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewMessageForm";
            this.Text = "New Message";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxNewMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonGenerateMessages;
        private System.Windows.Forms.Button buttonStopMessages;
    }
}