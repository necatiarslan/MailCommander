using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailCommander
{
    public class MailCommandExecutor
    {

        public static void CheckMailToExecute()
        {

            try
            {
                Microsoft.Office.Interop.Outlook.Application myApp = new Microsoft.Office.Interop.Outlook.ApplicationClass();
                Microsoft.Office.Interop.Outlook.NameSpace mapiNameSpace = myApp.GetNamespace("MAPI");
                Microsoft.Office.Interop.Outlook.MAPIFolder myInbox = mapiNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

                Microsoft.Office.Interop.Outlook.Items oItems = myInbox.Items.Restrict("[UnRead] = True");

                foreach (var item in oItems)
                {
                    if (item is Microsoft.Office.Interop.Outlook.MailItem)
                    {
                        Microsoft.Office.Interop.Outlook.MailItem mail = (Microsoft.Office.Interop.Outlook.MailItem)item;
                        if (mail.UnRead && mail.Subject.StartsWith("MC"))
                        {
                            mail.UnRead = false;
                            ExecuteMail(mail);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }

        }

        private static void ExecuteMail(Microsoft.Office.Interop.Outlook.MailItem mail)
        {
            string command = mail.Subject.Replace("MC ", "");
            MailCommand mailCommand;

            Logger.Log("Mail Received From:" + mail.SenderEmailAddress + " Subject:" + mail.Subject);

            if(!IsAllowedMail(mail.SenderEmailAddress))
            {
                Logger.Log(mail.SenderEmailAddress + " Is Not Allowed :-(");
                return;
            }

            if (command == "EXIT")
            {
                Logger.Log("Application Exiting");
                Helper.MainForm.Close();
                return;
            }


            if (command == "STOP")
            {
                Logger.Log("Service Is Stoping");
                Helper.MainForm.StopService();
                mailCommand = new MailCommand();
                mailCommand.Command = "STOP";
                mailCommand.CommandType = CommandType.Stop;
                mailCommand.Description = "Mail Command Service Stoped";
                mailCommand.ToAddress = mail.SenderEmailAddress;
                Execute(mailCommand);
                Logger.Log("Service Is Stoped");
                return;
            }

            if (command == "START")
            {
                Logger.Log("Service Is Starting");
                Helper.MainForm.StartService();
                mailCommand = new MailCommand();
                mailCommand.Command = "START";
                mailCommand.CommandType = CommandType.Start;
                mailCommand.Description = "Mail Command Service Started";
                mailCommand.ToAddress = mail.SenderEmailAddress;
                Execute(mailCommand);
                Logger.Log("Service Is Stoped");
                return;
            }

            if (command == "HI")
            {
                mailCommand = new MailCommand();
                mailCommand.Command = "HI";
                mailCommand.CommandType = CommandType.Hi;
                mailCommand.Description = "Hi :-)), Im here for your command.";
                mailCommand.ToAddress = mail.SenderEmailAddress;
                Execute(mailCommand);
                return;
            }

            if (command == "CL")
            {
                mailCommand = new MailCommand();
                mailCommand.Command = "CL";
                mailCommand.CommandType = CommandType.CommandList;
                mailCommand.Data = Helper.GetCommandList();
                mailCommand.Description = "Command List :-)";
                mailCommand.ToAddress = mail.SenderEmailAddress;
                Execute(mailCommand);
                return;
            }

            if (!Helper.MainForm.IsServiceReply())
            {
                return;
            }


            mailCommand = Helper.GetMailCommand(command);
            mailCommand.ToAddress = mail.SenderEmailAddress;

            Execute(mailCommand);
        }

        private static bool IsAllowedMail(string senderMailAddress)
        {
            string allowedMails = Helper.MainForm.GetAllowedMails();
            string restrictedMails = Helper.MainForm.GetRestrictedMails();

            if (allowedMails == string.Empty & restrictedMails == string.Empty)
                return true;

            string[] restrictedMailList = restrictedMails.Split(';');

            foreach (string s in restrictedMailList)
            {
                if (s != string.Empty & senderMailAddress.Contains(s))
                    return false;
            }

            string[] allowedMailList = allowedMails.Split(';');

            foreach(string s in allowedMailList)
            {
                if (s != string.Empty & senderMailAddress.Contains(s))
                    return true;
            }
            
            return false;
        }

        public static void Execute(MailCommand mailCommand)
        {
            if (mailCommand.CommandType == CommandType.MailCommand)
            {
                try
                {
                    if (mailCommand.GetConnectionProviderName().Contains("Oracle"))
                    {
                        mailCommand.Data = ExecuteOracleDataset(mailCommand.GetConnectionString(), mailCommand.SqlCommandText);
                    }
                    else
                    {
                        mailCommand.Data = ExecuteSqlDataSet(mailCommand.GetConnectionString(), mailCommand.SqlCommandText);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log("ERROR : " + ex.Message);
                    mailCommand.Exception = ex;
                }
            }

            sendEMailThroughOUTLOOK(mailCommand);
        }

        private static DataSet ExecuteSqlDataSet(string connectionString, string commandText)
        {
            if (connectionString == null || connectionString.Length == 0) throw new ArgumentNullException("connectionString");
            if (commandText == null || commandText.Length == 0) throw new ArgumentNullException("commandText");

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(commandText, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            
            return ds;
        }

        //public static DataSet ExecuteOracleDataset(string connectionString, string commandText)
        //{
        //    if (connectionString == null || connectionString.Length == 0) throw new ArgumentNullException("connectionString");
        //    if (commandText == null || commandText.Length == 0) throw new ArgumentNullException("commandText");

        //    OracleConnection connection = new OracleConnection();
        //    connection.ConnectionString = connectionString;
        //    connection.Open();

        //    OracleDataAdapter da = new OracleDataAdapter(commandText, connection);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    connection.Close();

        //    return ds;
        //}

        public static DataSet ExecuteOracleDataset(string connectionString, string commandText)
        {
            if (connectionString == null || connectionString.Length == 0) throw new ArgumentNullException("connectionString");
            if (commandText == null || commandText.Length == 0) throw new ArgumentNullException("commandText");

            Oracle.DataAccess.Client.OracleConnection connection = new Oracle.DataAccess.Client.OracleConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            Oracle.DataAccess.Client.OracleDataAdapter da = new Oracle.DataAccess.Client.OracleDataAdapter(commandText, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();

            return ds;
        }

        //method to send email to outlook
        private static void sendEMailThroughOUTLOOK(MailCommand mailCommand)
        {
            try
            {
                // Create the Outlook application.
                Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();
                // Create a new mail item.
                Microsoft.Office.Interop.Outlook.MailItem oMsg = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                // Set HTMLBody. 
                //add the body of the email
                if (mailCommand.Exception != null)
                {
                    oMsg.HTMLBody = "Error !!!" + Environment.NewLine + Environment.NewLine + mailCommand.Exception.Message;
                }
                else if (mailCommand.CommandType == CommandType.Exit | mailCommand.CommandType == CommandType.Hi | mailCommand.CommandType == CommandType.Stop | mailCommand.CommandType == CommandType.Start)
                {
                    oMsg.HTMLBody = mailCommand.Description;
                }
                else
                {
                    oMsg.HTMLBody = ConvertToHtmlFile(mailCommand);
                }

                //Add an attachment.
                //String sDisplayName = "MyAttachment";
                int iPosition = (int)oMsg.Body.Length + 1;
                //int iAttachType = (int)Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue;
                //now attached the file
                //Outlook.Attachment oAttach = oMsg.Attachments.Add(@"C:\\fileName.jpg", iAttachType, iPosition, sDisplayName);
                //Subject line
                oMsg.Subject = mailCommand.Command + " Executed (" + DateTime.Now.ToLongTimeString() + ")";
                // Add a recipient.
                Microsoft.Office.Interop.Outlook.Recipients oRecips = (Microsoft.Office.Interop.Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                Microsoft.Office.Interop.Outlook.Recipient oRecip = (Microsoft.Office.Interop.Outlook.Recipient)oRecips.Add(mailCommand.ToAddress);
                oRecip.Resolve();
                // Send.
                oMsg.Send();
                // Clean up.
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;

                Logger.Log(mailCommand.Command + " Result Send To " + mailCommand.ToAddress);
            }//end of try block
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }//end of catch
        }//end of Email Method

        private static string ConvertToHtmlFile(MailCommand mailCommand)
        {
            string result = "";


            if (mailCommand.Data == null)
            {
                throw new System.ArgumentNullException("Invalid MailCommand.Data");
            }
            else
            {
                //Continue.
            }


            //Get a worker object.
            StringBuilder htmlBuilder = new StringBuilder();


            //Open tags and write the top portion.
            htmlBuilder.Append("<html>");
            htmlBuilder.Append("<head>");
            htmlBuilder.Append("<title>");
            htmlBuilder.Append("Page-");
            htmlBuilder.Append(Guid.NewGuid().ToString());
            htmlBuilder.Append("</title>");
            htmlBuilder.Append("</head>");
            htmlBuilder.Append("<body>");

            foreach (DataTable dt in mailCommand.Data.Tables)
            {
                ConvertDataTableToHtmlTable(dt, htmlBuilder);
                htmlBuilder.Append("</br></br></br>&nbsp  &nbsp  ");
            }

            htmlBuilder.Append("<br>Connection : " + mailCommand.Connection);
            htmlBuilder.Append("<br>Description : " + mailCommand.Description);

            htmlBuilder.Append("</body>");
            htmlBuilder.Append("</html>");


            //Get the string for return.
            result = htmlBuilder.ToString();

            return result;
        }

        private static void ConvertDataTableToHtmlTable(DataTable targetTable, StringBuilder myBuilder)
        {
            myBuilder.Append("<table border='1px' cellpadding='5' cellspacing='0' ");
            myBuilder.Append("style='border: solid 1px Silver; font-size: x-small;'>");


            //Add the headings row.


            myBuilder.Append("<tr align='left' valign='top'>");


            foreach (DataColumn myColumn in targetTable.Columns)
            {
                myBuilder.Append("<td align='left' valign='top'>");
                myBuilder.Append(myColumn.ColumnName);
                myBuilder.Append("</td>");
            }


            myBuilder.Append("</tr>");


            //Add the data rows.
            foreach (DataRow myRow in targetTable.Rows)
            {
                myBuilder.Append("<tr align='left' valign='top'>");


                foreach (DataColumn myColumn in targetTable.Columns)
                {
                    myBuilder.Append("<td align='left' valign='top'>");
                    myBuilder.Append(myRow[myColumn.ColumnName].ToString());
                    myBuilder.Append("</td>");
                }


                myBuilder.Append("</tr>");
            }


            //Close tags.
            myBuilder.Append("</table>");
        }
    }
}
