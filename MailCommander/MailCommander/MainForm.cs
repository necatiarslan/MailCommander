using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailCommander
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        MailCommandDataSet ds = new MailCommandDataSet();

        public bool IsServiceReply()
        {
            return ServiceReplyCheckBox.Checked;
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            MailCommand cmd = new MailCommand();
            cmd.CommandType = CommandType.MailCommand;
            MailCommandForm frm = new MailCommandForm(cmd);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ds.Tables[0].Rows.Add(cmd.Command, cmd.Connection, cmd.Description, cmd.SqlCommandText);
                SaveMailCommandList();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MailCommandDataGridView.AutoGenerateColumns = false;
            MailCommandDataGridView.DataSource = new DataView(ds.Tables[0], "ISNULL(CommandType,1)=1", "", DataViewRowState.CurrentRows);

            LoadMailCommandList();
            Helper.MainForm = this;
            LoadCustomSettings();


            StartService();
        }

        private void LoadCustomSettings()
        {
            try
            {
                AllowedMailsTextBox.Text = ConfigurationManager.AppSettings["AllowedMails"].ToString();
            }
            catch { }

            try
            {
                RestrictedMailsTextBox.Text = ConfigurationManager.AppSettings["RestrictedMails"].ToString();
            }
            catch { }
        }

        private void LoadMailCommandList()
        {
            string fileName = Helper.GetMailCommandListFileName();
            if (File.Exists(fileName))
            {
                this.ds.Clear();
                this.ds.ReadXml(fileName);
            }
        }

        private void SaveMailCommandList()
        {
            string filePath = Helper.GetMailCommandListFileName();
            this.ds.WriteXml(filePath);
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (MailCommandDataGridView.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = MailCommandDataGridView.SelectedRows[0];
            MailCommand cmd = new MailCommand();
            cmd.Command = row.Cells["colCommand"].Value.ToString();
            cmd.Connection = row.Cells["colConnection"].Value.ToString();
            cmd.Description = row.Cells["colDescription"].Value.ToString();
            cmd.SqlCommandText = row.Cells["colSqlCommandText"].Value.ToString();
            cmd.CommandType = CommandType.MailCommand;

            MailCommandForm frm = new MailCommandForm(cmd);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                row.Cells["colCommand"].Value = cmd.Command;
                row.Cells["colConnection"].Value = cmd.Connection;
                row.Cells["colDescription"].Value = cmd.Description;
                row.Cells["colSqlCommandText"].Value = cmd.SqlCommandText;
                //row.Cells["colCommandType"].Value = cmd.CommandType;
                
                SaveMailCommandList();
            }
        }
        
        private void TestToolStripButton_Click(object sender, EventArgs e)
        {
            if (MailCommandDataGridView.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = MailCommandDataGridView.SelectedRows[0];
            MailCommand cmd = new MailCommand();
            cmd.Command = row.Cells["colCommand"].Value.ToString();
            cmd.Connection = row.Cells["colConnection"].Value.ToString();
            cmd.Description = row.Cells["colDescription"].Value.ToString();
            cmd.SqlCommandText = row.Cells["colSqlCommandText"].Value.ToString();
            cmd.CommandType = CommandType.MailCommand;
            cmd.ToAddress = "necati.arslan@turkiyefinans.com.tr";

            MailCommandExecutor.Execute(cmd);

            MessageBox.Show("Command Excuted and Result Mail Send To necati.arslan@turkiyefinans.com.tr");
        }
        
        private void RemoveToolStripButton_Click(object sender, EventArgs e)
        {
            if (MailCommandDataGridView.SelectedRows.Count == 0)
                return;
            
            DataGridViewRow row = MailCommandDataGridView.SelectedRows[0];

            if (MessageBox.Show("Delete ?", "Delete ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MailCommandDataGridView.Rows.Remove(row);
                SaveMailCommandList();
            }

        }

        private void EnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!EnableCheckBox.Focused)
                return;

            if (EnableCheckBox.Checked)
                StartService();
            else
                StopService();
        }

        private void CheckMailIntervalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MailCommandTimer.Interval = (int)CheckMailIntervalNumericUpDown.Value * 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckMailToExecute();
        }

        private void CheckMailToExecute()
        {
            LastExecuteTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
            MailCommandExecutor.CheckMailToExecute();
        }

        public void StopService()
        {
            MailCommandTimer.Enabled = false;
            EnableCheckBox.Checked = false;
            EnableCheckBox.Text = "Service Stoped";
            this.EnableCheckBox.ForeColor = System.Drawing.Color.Red;
            ServiceToolStripMenuItem.Text = "Start";
            ServiceReplyCheckBox.Checked = false;
            Logger.Log("Service Stoped");
        }

        public void StartService()
        {
            MailCommandTimer.Enabled = true;
            EnableCheckBox.Checked = true;
            ServiceToolStripMenuItem.Text = "Stop";
            EnableCheckBox.Text = "Service Running";
            this.EnableCheckBox.ForeColor = System.Drawing.Color.Green;
            ServiceReplyCheckBox.Checked = true;
            Logger.Log("Service Started");
        }

        public void Log(string text)
        {
            LogTextBox.Text += Environment.NewLine + text;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void ServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MailCommandTimer.Enabled)
            {
                StopService();
            }
            else
            {
                StartService();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.ShowBalloonTip(1000);
            }

            if (WindowState == FormWindowState.Normal)
            {
                ShowInTaskbar = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopService();

            SaveCustomSettings();
        }

        private void SaveCustomSettings()
        {
            try
            {
                ConfigurationManager.AppSettings.Set("AllowedMails", AllowedMailsTextBox.Text);
                ConfigurationManager.AppSettings.Set("RestrictedMails", RestrictedMailsTextBox.Text);
            }
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/necatiarslan/MailCommander");
        }

        public string GetAllowedMails()
        {
            return AllowedMailsTextBox.Text;
        }
        
        internal string GetRestrictedMails()
        {
            return RestrictedMailsTextBox.Text;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void ExecuteNowButton_Click(object sender, EventArgs e)
        {
            CheckMailToExecute();
        }


        private static object ReadCellValue(DataGridViewRow row, string columnName)
        {
            object result = 0;

            if(row.Cells[columnName].Value == DBNull.Value)
            {
                if (row.Cells[columnName].ValueType == typeof(string))
                    result = string.Empty;
                else
                    result = 0;
            
            }
            else
            {
                result = row.Cells[columnName].Value;
            }            

            return result;
        }

    }
}
