namespace MailCommander
{
    partial class MailCommandForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionComboBox = new System.Windows.Forms.ComboBox();
            this.SqlRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.MailRadioButton = new System.Windows.Forms.RadioButton();
            this.AttachmentRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(636, 508);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(555, 508);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sql :";
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CommandTextBox.Location = new System.Drawing.Point(106, 6);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(218, 20);
            this.CommandTextBox.TabIndex = 5;
            // 
            // ConnectionComboBox
            // 
            this.ConnectionComboBox.FormattingEnabled = true;
            this.ConnectionComboBox.Location = new System.Drawing.Point(106, 32);
            this.ConnectionComboBox.Name = "ConnectionComboBox";
            this.ConnectionComboBox.Size = new System.Drawing.Size(218, 21);
            this.ConnectionComboBox.TabIndex = 6;
            // 
            // SqlRichTextBox
            // 
            this.SqlRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SqlRichTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SqlRichTextBox.Location = new System.Drawing.Point(106, 85);
            this.SqlRichTextBox.Name = "SqlRichTextBox";
            this.SqlRichTextBox.Size = new System.Drawing.Size(605, 417);
            this.SqlRichTextBox.TabIndex = 7;
            this.SqlRichTextBox.Text = "";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(106, 59);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(218, 20);
            this.DescriptionTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description :";
            // 
            // TestButton
            // 
            this.TestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TestButton.Location = new System.Drawing.Point(106, 508);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 10;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MailRadioButton);
            this.panel1.Controls.Add(this.AttachmentRadioButton);
            this.panel1.Location = new System.Drawing.Point(330, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 70);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Result Content :";
            // 
            // MailRadioButton
            // 
            this.MailRadioButton.AutoSize = true;
            this.MailRadioButton.Checked = true;
            this.MailRadioButton.Location = new System.Drawing.Point(86, 2);
            this.MailRadioButton.Name = "MailRadioButton";
            this.MailRadioButton.Size = new System.Drawing.Size(44, 17);
            this.MailRadioButton.TabIndex = 1;
            this.MailRadioButton.TabStop = true;
            this.MailRadioButton.Text = "Mail";
            this.MailRadioButton.UseVisualStyleBackColor = true;
            // 
            // AttachmentRadioButton
            // 
            this.AttachmentRadioButton.AutoSize = true;
            this.AttachmentRadioButton.Enabled = false;
            this.AttachmentRadioButton.Location = new System.Drawing.Point(136, 2);
            this.AttachmentRadioButton.Name = "AttachmentRadioButton";
            this.AttachmentRadioButton.Size = new System.Drawing.Size(79, 17);
            this.AttachmentRadioButton.TabIndex = 0;
            this.AttachmentRadioButton.Text = "Attachment";
            this.AttachmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // MailCommandForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SqlRichTextBox);
            this.Controls.Add(this.ConnectionComboBox);
            this.Controls.Add(this.CommandTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MailCommandForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Command";
            this.Load += new System.EventHandler(this.MailCommandForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.ComboBox ConnectionComboBox;
        private System.Windows.Forms.RichTextBox SqlRichTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton MailRadioButton;
        private System.Windows.Forms.RadioButton AttachmentRadioButton;
    }
}