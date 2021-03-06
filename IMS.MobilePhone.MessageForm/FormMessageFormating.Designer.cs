﻿namespace Simcorp.IMS.MobilePhone.MessageForm {
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
            this.buttonStopCharge = new System.Windows.Forms.Button();
            this.buttonCharge = new System.Windows.Forms.Button();
            this.progressBarCharge = new System.Windows.Forms.ProgressBar();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.CheckBoxOr2 = new System.Windows.Forms.CheckBox();
            this.CheckBoxOr1 = new System.Windows.Forms.CheckBox();
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
            this.labelChargePers = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChargePers);
            this.panel1.Controls.Add(this.buttonStopCharge);
            this.panel1.Controls.Add(this.buttonCharge);
            this.panel1.Controls.Add(this.progressBarCharge);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 415);
            this.panel1.TabIndex = 0;
            // 
            // buttonStopCharge
            // 
            this.buttonStopCharge.Location = new System.Drawing.Point(112, 56);
            this.buttonStopCharge.Name = "buttonStopCharge";
            this.buttonStopCharge.Size = new System.Drawing.Size(108, 24);
            this.buttonStopCharge.TabIndex = 23;
            this.buttonStopCharge.Text = "Stop Charging";
            this.buttonStopCharge.UseVisualStyleBackColor = true;
            this.buttonStopCharge.Click += new System.EventHandler(this.ButtonStopChargeClick);
            // 
            // buttonCharge
            // 
            this.buttonCharge.Location = new System.Drawing.Point(112, 27);
            this.buttonCharge.Name = "buttonCharge";
            this.buttonCharge.Size = new System.Drawing.Size(108, 23);
            this.buttonCharge.TabIndex = 22;
            this.buttonCharge.Text = "Charge";
            this.buttonCharge.UseVisualStyleBackColor = true;
            this.buttonCharge.Click += new System.EventHandler(this.ButtonChargeClick);
            // 
            // progressBarCharge
            // 
            this.progressBarCharge.Location = new System.Drawing.Point(265, 27);
            this.progressBarCharge.Name = "progressBarCharge";
            this.progressBarCharge.Size = new System.Drawing.Size(203, 13);
            this.progressBarCharge.TabIndex = 21;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.CheckBoxOr2);
            this.groupBoxFilters.Controls.Add(this.CheckBoxOr1);
            this.groupBoxFilters.Location = new System.Drawing.Point(424, 92);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(44, 71);
            this.groupBoxFilters.TabIndex = 20;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "OR";
            // 
            // CheckBoxOr2
            // 
            this.CheckBoxOr2.AutoSize = true;
            this.CheckBoxOr2.Location = new System.Drawing.Point(5, 53);
            this.CheckBoxOr2.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxOr2.Name = "CheckBoxOr2";
            this.CheckBoxOr2.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxOr2.TabIndex = 1;
            this.CheckBoxOr2.UseVisualStyleBackColor = true;
            this.CheckBoxOr2.CheckedChanged += new System.EventHandler(this.CheckBoxOr2Changed);
            // 
            // CheckBoxOr1
            // 
            this.CheckBoxOr1.AutoSize = true;
            this.CheckBoxOr1.Location = new System.Drawing.Point(5, 17);
            this.CheckBoxOr1.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxOr1.Name = "CheckBoxOr1";
            this.CheckBoxOr1.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxOr1.TabIndex = 0;
            this.CheckBoxOr1.UseVisualStyleBackColor = true;
            this.CheckBoxOr1.CheckedChanged += new System.EventHandler(this.CheckBoxOr1Changed);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(332, 145);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerTo.TabIndex = 15;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.DateTimePickerToValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(235, 145);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(87, 20);
            this.dateTimePickerFrom.TabIndex = 12;
            this.dateTimePickerFrom.Value = new System.DateTime(2018, 1, 17, 18, 49, 52, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.DateTimePickerFromValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contacts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Messages Search ";
            // 
            // textBoxMessageSearch
            // 
            this.textBoxMessageSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxMessageSearch.Location = new System.Drawing.Point(236, 109);
            this.textBoxMessageSearch.Name = "textBoxMessageSearch";
            this.textBoxMessageSearch.Size = new System.Drawing.Size(182, 20);
            this.textBoxMessageSearch.TabIndex = 9;
            this.textBoxMessageSearch.TextChanged += new System.EventHandler(this.TextBoxMessageSearchTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Messages quick view";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Messages detailed view";
            // 
            // comboBoxUniqueUsers
            // 
            this.comboBoxUniqueUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUniqueUsers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxUniqueUsers.FormattingEnabled = true;
            this.comboBoxUniqueUsers.Location = new System.Drawing.Point(235, 71);
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
            this.listViewMessages.Location = new System.Drawing.Point(234, 190);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(234, 207);
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
            this.comboBoxFormattingOpt.Location = new System.Drawing.Point(16, 108);
            this.comboBoxFormattingOpt.Name = "comboBoxFormattingOpt";
            this.comboBoxFormattingOpt.Size = new System.Drawing.Size(204, 21);
            this.comboBoxFormattingOpt.TabIndex = 1;
            this.comboBoxFormattingOpt.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFormattingIndexChanged);
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxMessages.Location = new System.Drawing.Point(16, 146);
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
            this.label1.Location = new System.Drawing.Point(13, 92);
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
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
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
            // labelChargePers
            // 
            this.labelChargePers.AutoSize = true;
            this.labelChargePers.BackColor = System.Drawing.Color.Transparent;
            this.labelChargePers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChargePers.ForeColor = System.Drawing.Color.Black;
            this.labelChargePers.Location = new System.Drawing.Point(235, 27);
            this.labelChargePers.Name = "labelChargePers";
            this.labelChargePers.Size = new System.Drawing.Size(0, 13);
            this.labelChargePers.TabIndex = 24;
            // 
            // FormMessageFormating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 432);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMessageFormating";
            this.Text = "Messages";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
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
        private System.Windows.Forms.CheckBox CheckBoxOr2;
        private System.Windows.Forms.CheckBox CheckBoxOr1;
        private System.Windows.Forms.Button buttonCharge;
        private System.Windows.Forms.ProgressBar progressBarCharge;
        private System.Windows.Forms.Button buttonStopCharge;
        private System.Windows.Forms.Label labelChargePers;
    }
}

