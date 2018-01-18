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
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.comboBoxGroupFltr1 = new System.Windows.Forms.ComboBox();
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
            this.comboBoxGroupFltr2 = new System.Windows.Forms.ComboBox();
            this.comboBoxGroupFltr3 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxFilters);
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
            this.panel1.Size = new System.Drawing.Size(511, 388);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.comboBoxGroupFltr3);
            this.groupBoxFilters.Controls.Add(this.comboBoxGroupFltr2);
            this.groupBoxFilters.Controls.Add(this.comboBoxGroupFltr1);
            this.groupBoxFilters.Location = new System.Drawing.Point(422, 33);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(73, 121);
            this.groupBoxFilters.TabIndex = 20;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Group filter";
            // 
            // comboBoxGroupFltr1
            // 
            this.comboBoxGroupFltr1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupFltr1.FormattingEnabled = true;
            this.comboBoxGroupFltr1.Location = new System.Drawing.Point(6, 16);
            this.comboBoxGroupFltr1.Name = "comboBoxGroupFltr1";
            this.comboBoxGroupFltr1.Size = new System.Drawing.Size(48, 21);
            this.comboBoxGroupFltr1.TabIndex = 19;
            this.comboBoxGroupFltr1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGroupFltrIndexChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(330, 123);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerTo.TabIndex = 15;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.DateTimePickerToValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(233, 123);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(87, 20);
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
            this.label4.Location = new System.Drawing.Point(232, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message quick view";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 109);
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
            this.listViewMessages.Location = new System.Drawing.Point(232, 168);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(263, 207);
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
            this.richTextBoxMessages.Location = new System.Drawing.Point(14, 124);
            this.richTextBoxMessages.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.ReadOnly = true;
            this.richTextBoxMessages.Size = new System.Drawing.Size(204, 251);
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
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
            // comboBoxGroupFltr2
            // 
            this.comboBoxGroupFltr2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupFltr2.FormattingEnabled = true;
            this.comboBoxGroupFltr2.Location = new System.Drawing.Point(6, 54);
            this.comboBoxGroupFltr2.Name = "comboBoxGroupFltr2";
            this.comboBoxGroupFltr2.Size = new System.Drawing.Size(48, 21);
            this.comboBoxGroupFltr2.TabIndex = 20;
            // 
            // comboBoxGroupFltr3
            // 
            this.comboBoxGroupFltr3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupFltr3.FormattingEnabled = true;
            this.comboBoxGroupFltr3.Location = new System.Drawing.Point(6, 87);
            this.comboBoxGroupFltr3.Name = "comboBoxGroupFltr3";
            this.comboBoxGroupFltr3.Size = new System.Drawing.Size(48, 21);
            this.comboBoxGroupFltr3.TabIndex = 21;
            // 
            // FormMessageFormating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 412);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMessageFormating";
            this.Text = "Messages";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.ComboBox comboBoxGroupFltr1;
        private System.Windows.Forms.ComboBox comboBoxGroupFltr2;
        private System.Windows.Forms.ComboBox comboBoxGroupFltr3;
    }
}

