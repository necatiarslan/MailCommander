using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace MailCommander
{
    public partial class MailCommandForm : Form
    {
        public MailCommandForm(MailCommand cmd)
        {
            InitializeComponent();
            this.cmd = cmd;
        }

        MailCommand cmd;

        private void MailCommandForm_Load(object sender, EventArgs e)
        {
            Helper.LoanConnectionComboBox(ConnectionComboBox);

            CommandTextBox.Text = this.cmd.Command;
            ConnectionComboBox.Text = this.cmd.Connection;
            DescriptionTextBox.Text = this.cmd.Description;
            SqlRichTextBox.Text = this.cmd.SqlCommandText;

            Helper.ColorizeRichTextBox(this.SqlRichTextBox);
        }
        


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(CommandTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Command Must Be One Word !!!");
                CommandTextBox.Focus();
                return;
            }

            
            this.cmd.Command = CommandTextBox.Text;
            this.cmd.Connection = ConnectionComboBox.Text;
            this.cmd.Description = DescriptionTextBox.Text;
            this.cmd.SqlCommandText = SqlRichTextBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            this.cmd.Command = CommandTextBox.Text;
            this.cmd.Connection = ConnectionComboBox.Text;
            this.cmd.Description = DescriptionTextBox.Text;
            this.cmd.SqlCommandText = SqlRichTextBox.Text;
            this.cmd.ToAddress = "necati.arslan@turkiyefinans.com.tr";
            this.cmd.CommandType = CommandType.MailCommand;
            MailCommandExecutor.Execute(this.cmd);

            MessageBox.Show("Command Excuted and Result Mail Send To necati.arslan@turkiyefinans.com.tr");
        }



    }
}
