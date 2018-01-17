namespace Simcorp.IMS.MobilePhone.MessageForm {
    partial class FormMessageFormating {
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
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMessageSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUniqueUsers = new System.Windows.Forms.ComboBox();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxFormattingOpt = new System.Windows.Forms.ComboBox();
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxMessageSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxUniqueUsers);
            this.panel1.Controls.Add(this.listViewMessages);
            this.panel1.Controls.Add(this.comboBoxFormattingOpt);
            this.panel1.Controls.Add(this.richTextBoxMessages);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 388);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(330, 126);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(86, 20);
            this.dateTimePickerTo.TabIndex = 15;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.DateTimePickerToValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(233, 126);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(89, 20);
            this.dateTimePickerFrom.TabIndex = 12;
            this.dateTimePickerFrom.Value = new System.DateTime(2018, 1, 17, 18, 49, 52, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.DateTimePickerFromValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contacts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Message Search ";
            // 
            // textBoxMessageSearch
            // 
            this.textBoxMessageSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxMessageSearch.Location = new System.Drawing.Point(234, 87);
            this.textBoxMessageSearch.Name = "textBoxMessageSearch";
            this.textBoxMessageSearch.Size = new System.Drawing.Size(182, 20);
            this.textBoxMessageSearch.TabIndex = 9;
            this.textBoxMessageSearch.TextChanged += new System.EventHandler(this.TextBoxMessageSearchTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message quick view";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message detailed view";
            // 
            // comboBoxUniqueUsers
            // 
            this.comboBoxUniqueUsers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxUniqueUsers.FormattingEnabled = true;
            this.comboBoxUniqueUsers.Location = new System.Drawing.Point(233, 49);
            this.comboBoxUniqueUsers.Name = "comboBoxUniqueUsers";
            this.comboBoxUniqueUsers.Size = new System.Drawing.Size(183, 21);
            this.comboBoxUniqueUsers.TabIndex = 5;
            this.comboBoxUniqueUsers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUsersIndexChanged);
            // 
            // listViewMessages
            // 
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUser,
            this.columnText});
            this.listViewMessages.Location = new System.Drawing.Point(232, 163);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(184, 212);
            this.listViewMessages.TabIndex = 4;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Tile;
            // 
            // columnUser
            // 
            this.columnUser.Text = "User Name";
            // 
            // columnText
            // 
            this.columnText.Text = "Message Text";
            // 
            // comboBoxFormattingOpt
            // 
            this.comboBoxFormattingOpt.FormattingEnabled = true;
            this.comboBoxFormattingOpt.Location = new System.Drawing.Point(14, 86);
            this.comboBoxFormattingOpt.Name = "comboBoxFormattingOpt";
            this.comboBoxFormattingOpt.Size = new System.Drawing.Size(204, 21);
            this.comboBoxFormattingOpt.TabIndex = 1;
            this.comboBoxFormattingOpt.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFormattingIndexChanged);
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxMessages.Location = new System.Drawing.Point(14, 125);
            this.richTextBoxMessages.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.ReadOnly = true;
            this.richTextBoxMessages.Size = new System.Drawing.Size(204, 250);
            this.richTextBoxMessages.TabIndex = 2;
            this.richTextBoxMessages.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select message format output:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMessageToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // newMessageToolStripMenuItem
            // 
            this.newMessageToolStripMenuItem.Name = "newMessageToolStripMenuItem";
            this.newMessageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMessageToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.newMessageToolStripMenuItem.Text = "New Message";
            this.newMessageToolStripMenuItem.Click += new System.EventHandler(this.StripMenuCreateNewMessage);
            // 
            // FormMessageFormating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 412);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMessageFormating";
            this.Text = "Messages";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.ComboBox comboBoxFormattingOpt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMessageToolStripMenuItem;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ColumnHeader columnUser;
        private System.Windows.Forms.ColumnHeader columnText;
        private System.Windows.Forms.ComboBox comboBoxUniqueUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMessageSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}

