namespace MailCommander
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.MailCommandDataGridView = new System.Windows.Forms.DataGridView();
            this.colCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConnection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSqlCommandText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MailCommandToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TestToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ConfigTabPage = new System.Windows.Forms.TabPage();
            this.ServiceReplyCheckBox = new System.Windows.Forms.CheckBox();
            this.ExecuteNowButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AllowedMailsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RestrictedMailsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastExecuteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckMailIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LogTabPage = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.MailCommandTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MailCommandDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.MailCommandToolStrip.SuspendLayout();
            this.ConfigTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckMailIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutNumericUpDown)).BeginInit();
            this.InfoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogTabPage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.MainTabPage);
            this.MainTabControl.Controls.Add(this.ConfigTabPage);
            this.MainTabControl.Controls.Add(this.InfoTabPage);
            this.MainTabControl.Controls.Add(this.LogTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(671, 441);
            this.MainTabControl.TabIndex = 2;
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.MailCommandDataGridView);
            this.MainTabPage.Controls.Add(this.panel1);
            this.MainTabPage.Location = new System.Drawing.Point(4, 22);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(663, 415);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Main";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // MailCommandDataGridView
            // 
            this.MailCommandDataGridView.AllowUserToAddRows = false;
            this.MailCommandDataGridView.AllowUserToDeleteRows = false;
            this.MailCommandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MailCommandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCommand,
            this.colConnection,
            this.colDescription,
            this.colSqlCommandText});
            this.MailCommandDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailCommandDataGridView.Location = new System.Drawing.Point(3, 3);
            this.MailCommandDataGridView.MultiSelect = false;
            this.MailCommandDataGridView.Name = "MailCommandDataGridView";
            this.MailCommandDataGridView.ReadOnly = true;
            this.MailCommandDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MailCommandDataGridView.Size = new System.Drawing.Size(657, 382);
            this.MailCommandDataGridView.TabIndex = 1;
            // 
            // colCommand
            // 
            this.colCommand.DataPropertyName = "Command";
            this.colCommand.HeaderText = "Command";
            this.colCommand.Name = "colCommand";
            this.colCommand.ReadOnly = true;
            // 
            // colConnection
            // 
            this.colConnection.DataPropertyName = "Connection";
            this.colConnection.HeaderText = "Connection";
            this.colConnection.Name = "colConnection";
            this.colConnection.ReadOnly = true;
            this.colConnection.Width = 200;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 200;
            // 
            // colSqlCommandText
            // 
            this.colSqlCommandText.DataPropertyName = "SqlCommandText";
            this.colSqlCommandText.HeaderText = "SqlCommandText";
            this.colSqlCommandText.Name = "colSqlCommandText";
            this.colSqlCommandText.ReadOnly = true;
            this.colSqlCommandText.Width = 300;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MailCommandToolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 27);
            this.panel1.TabIndex = 0;
            // 
            // MailCommandToolStrip
            // 
            this.MailCommandToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.EditToolStripButton,
            this.RemoveToolStripButton,
            this.toolStripSeparator1,
            this.TestToolStripButton});
            this.MailCommandToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MailCommandToolStrip.Name = "MailCommandToolStrip";
            this.MailCommandToolStrip.Size = new System.Drawing.Size(657, 25);
            this.MailCommandToolStrip.TabIndex = 0;
            this.MailCommandToolStrip.Text = "toolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.Image = global::MailCommander.Properties.Resources.plus_green;
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.NewToolStripButton.Text = "New";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.Image = global::MailCommander.Properties.Resources.case_mixed;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.EditToolStripButton.Text = "Edit";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // RemoveToolStripButton
            // 
            this.RemoveToolStripButton.Image = global::MailCommander.Properties.Resources.delete_red;
            this.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveToolStripButton.Name = "RemoveToolStripButton";
            this.RemoveToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.RemoveToolStripButton.Text = "Delete";
            this.RemoveToolStripButton.Click += new System.EventHandler(this.RemoveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TestToolStripButton
            // 
            this.TestToolStripButton.Image = global::MailCommander.Properties.Resources.yes;
            this.TestToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TestToolStripButton.Name = "TestToolStripButton";
            this.TestToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.TestToolStripButton.Text = "Test";
            this.TestToolStripButton.Click += new System.EventHandler(this.TestToolStripButton_Click);
            // 
            // ConfigTabPage
            // 
            this.ConfigTabPage.Controls.Add(this.ServiceReplyCheckBox);
            this.ConfigTabPage.Controls.Add(this.ExecuteNowButton);
            this.ConfigTabPage.Controls.Add(this.label6);
            this.ConfigTabPage.Controls.Add(this.AllowedMailsTextBox);
            this.ConfigTabPage.Controls.Add(this.label5);
            this.ConfigTabPage.Controls.Add(this.RestrictedMailsTextBox);
            this.ConfigTabPage.Controls.Add(this.label3);
            this.ConfigTabPage.Controls.Add(this.LastExecuteTextBox);
            this.ConfigTabPage.Controls.Add(this.label2);
            this.ConfigTabPage.Controls.Add(this.CheckMailIntervalNumericUpDown);
            this.ConfigTabPage.Controls.Add(this.label1);
            this.ConfigTabPage.Controls.Add(this.TimeoutNumericUpDown);
            this.ConfigTabPage.Controls.Add(this.EnableCheckBox);
            this.ConfigTabPage.Location = new System.Drawing.Point(4, 22);
            this.ConfigTabPage.Name = "ConfigTabPage";
            this.ConfigTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTabPage.Size = new System.Drawing.Size(663, 415);
            this.ConfigTabPage.TabIndex = 3;
            this.ConfigTabPage.Text = "Config";
            this.ConfigTabPage.UseVisualStyleBackColor = true;
            // 
            // ServiceReplyCheckBox
            // 
            this.ServiceReplyCheckBox.AutoSize = true;
            this.ServiceReplyCheckBox.Checked = true;
            this.ServiceReplyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServiceReplyCheckBox.Location = new System.Drawing.Point(79, 89);
            this.ServiceReplyCheckBox.Name = "ServiceReplyCheckBox";
            this.ServiceReplyCheckBox.Size = new System.Drawing.Size(92, 17);
            this.ServiceReplyCheckBox.TabIndex = 12;
            this.ServiceReplyCheckBox.Text = "Service Reply";
            this.ServiceReplyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExecuteNowButton
            // 
            this.ExecuteNowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExecuteNowButton.ForeColor = System.Drawing.Color.Green;
            this.ExecuteNowButton.Location = new System.Drawing.Point(239, 61);
            this.ExecuteNowButton.Name = "ExecuteNowButton";
            this.ExecuteNowButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteNowButton.TabIndex = 11;
            this.ExecuteNowButton.Text = "Exec Now";
            this.ExecuteNowButton.UseVisualStyleBackColor = true;
            this.ExecuteNowButton.Click += new System.EventHandler(this.ExecuteNowButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Allowed Mails: ([ ; ] Seperated)";
            // 
            // AllowedMailsTextBox
            // 
            this.AllowedMailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllowedMailsTextBox.Location = new System.Drawing.Point(30, 255);
            this.AllowedMailsTextBox.Multiline = true;
            this.AllowedMailsTextBox.Name = "AllowedMailsTextBox";
            this.AllowedMailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AllowedMailsTextBox.Size = new System.Drawing.Size(627, 34);
            this.AllowedMailsTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Restricted Mails: ([ ; ] Seperated)";
            // 
            // RestrictedMailsTextBox
            // 
            this.RestrictedMailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestrictedMailsTextBox.Location = new System.Drawing.Point(30, 199);
            this.RestrictedMailsTextBox.Multiline = true;
            this.RestrictedMailsTextBox.Name = "RestrictedMailsTextBox";
            this.RestrictedMailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RestrictedMailsTextBox.Size = new System.Drawing.Size(627, 34);
            this.RestrictedMailsTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Execution Time";
            // 
            // LastExecuteTextBox
            // 
            this.LastExecuteTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastExecuteTextBox.Location = new System.Drawing.Point(30, 62);
            this.LastExecuteTextBox.Name = "LastExecuteTextBox";
            this.LastExecuteTextBox.Size = new System.Drawing.Size(61, 21);
            this.LastExecuteTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Check Mail Interval Second";
            // 
            // CheckMailIntervalNumericUpDown
            // 
            this.CheckMailIntervalNumericUpDown.Location = new System.Drawing.Point(30, 112);
            this.CheckMailIntervalNumericUpDown.Name = "CheckMailIntervalNumericUpDown";
            this.CheckMailIntervalNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.CheckMailIntervalNumericUpDown.TabIndex = 3;
            this.CheckMailIntervalNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.CheckMailIntervalNumericUpDown.ValueChanged += new System.EventHandler(this.CheckMailIntervalNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command Timeout Value Second (Default 0)";
            // 
            // TimeoutNumericUpDown
            // 
            this.TimeoutNumericUpDown.Enabled = false;
            this.TimeoutNumericUpDown.Location = new System.Drawing.Point(30, 138);
            this.TimeoutNumericUpDown.Name = "TimeoutNumericUpDown";
            this.TimeoutNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.TimeoutNumericUpDown.TabIndex = 1;
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Checked = true;
            this.EnableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnableCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnableCheckBox.ForeColor = System.Drawing.Color.Green;
            this.EnableCheckBox.Location = new System.Drawing.Point(30, 25);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Size = new System.Drawing.Size(184, 28);
            this.EnableCheckBox.TabIndex = 0;
            this.EnableCheckBox.Text = "Service Running";
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            this.EnableCheckBox.CheckedChanged += new System.EventHandler(this.EnableCheckBox_CheckedChanged);
            // 
            // InfoTabPage
            // 
            this.InfoTabPage.Controls.Add(this.label4);
            this.InfoTabPage.Controls.Add(this.pictureBox1);
            this.InfoTabPage.Controls.Add(this.InfoTextBox);
            this.InfoTabPage.Controls.Add(this.linkLabel1);
            this.InfoTabPage.Location = new System.Drawing.Point(4, 22);
            this.InfoTabPage.Name = "InfoTabPage";
            this.InfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTabPage.Size = new System.Drawing.Size(663, 415);
            this.InfoTabPage.TabIndex = 2;
            this.InfoTabPage.Text = "Info";
            this.InfoTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "How To Use && Setup :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MailCommander.Properties.Resources.email_2_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 129);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InfoTextBox.Location = new System.Drawing.Point(6, 141);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(651, 268);
            this.InfoTextBox.TabIndex = 1;
            this.InfoTextBox.Text = resources.GetString("InfoTextBox.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(153, 61);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(467, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/necatiarslan/MailCommander";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LogTabPage
            // 
            this.LogTabPage.Controls.Add(this.LogTextBox);
            this.LogTabPage.Location = new System.Drawing.Point(4, 22);
            this.LogTabPage.Name = "LogTabPage";
            this.LogTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogTabPage.Size = new System.Drawing.Size(663, 415);
            this.LogTabPage.TabIndex = 4;
            this.LogTabPage.Text = "Log";
            this.LogTabPage.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(3, 3);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(657, 409);
            this.LogTextBox.TabIndex = 0;
            // 
            // MailCommandTimer
            // 
            this.MailCommandTimer.Interval = 60000;
            this.MailCommandTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Application Minimized";
            this.notifyIcon1.BalloonTipTitle = "Mail Commander";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Mail Commander";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ServiceToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 70);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ServiceToolStripMenuItem
            // 
            this.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem";
            this.ServiceToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ServiceToolStripMenuItem.Text = "Stop";
            this.ServiceToolStripMenuItem.Click += new System.EventHandler(this.ServiceToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 465);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Commander v20181109";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainTabControl.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MailCommandDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MailCommandToolStrip.ResumeLayout(false);
            this.MailCommandToolStrip.PerformLayout();
            this.ConfigTabPage.ResumeLayout(false);
            this.ConfigTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckMailIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutNumericUpDown)).EndInit();
            this.InfoTabPage.ResumeLayout(false);
            this.InfoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogTabPage.ResumeLayout(false);
            this.LogTabPage.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabPage InfoTabPage;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView MailCommandDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip MailCommandToolStrip;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton RemoveToolStripButton;
        private System.Windows.Forms.TabPage ConfigTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TimeoutNumericUpDown;
        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TestToolStripButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CheckMailIntervalNumericUpDown;
        private System.Windows.Forms.Timer MailCommandTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastExecuteTextBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.TabPage LogTabPage;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AllowedMailsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RestrictedMailsTextBox;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button ExecuteNowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSqlCommandText;
        private System.Windows.Forms.CheckBox ServiceReplyCheckBox;

    }
}

