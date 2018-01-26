namespace Simcorp.IMS.MobilePhone.CallsForm {
    partial class FormCalls {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listViewCalls = new System.Windows.Forms.ListView();
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReceivedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountTimesCalled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.listViewCalls);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 336);
            this.panel1.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(3, 47);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(3, 18);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // listViewCalls
            // 
            this.listViewCalls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contact,
            this.CountTimesCalled,
            this.Number,
            this.ReceivedTime,
            this.Direction});
            this.listViewCalls.Location = new System.Drawing.Point(3, 88);
            this.listViewCalls.Name = "listViewCalls";
            this.listViewCalls.Size = new System.Drawing.Size(385, 245);
            this.listViewCalls.TabIndex = 4;
            this.listViewCalls.UseCompatibleStateImageBehavior = false;
            this.listViewCalls.View = System.Windows.Forms.View.Details;
            // 
            // Contact
            // 
            this.Contact.Text = "Contact";
            this.Contact.Width = 80;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 80;
            // 
            // ReceivedTime
            // 
            this.ReceivedTime.Text = "Received Time";
            this.ReceivedTime.Width = 120;
            // 
            // Direction
            // 
            this.Direction.Text = "Direction";
            this.Direction.Width = 55;
            // 
            // CountTimesCalled
            // 
            this.CountTimesCalled.Text = "Called";
            this.CountTimesCalled.Width = 45;
            // 
            // FormCalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 360);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCalls";
            this.Text = "Calls";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewCalls;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.ColumnHeader ReceivedTime;
        private System.Windows.Forms.ColumnHeader Direction;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader CountTimesCalled;
    }
}

