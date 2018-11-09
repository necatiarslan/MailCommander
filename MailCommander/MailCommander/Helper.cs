using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MailCommander
{
    class Helper
    {
        public static MainForm MainForm;

        public static string GetRootPath()
        {
            return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        public static void LoanConnectionComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (ConnectionStringSettings conn in ConfigurationManager.ConnectionStrings)
            {
                comboBox.Items.Add(conn.Name);
            }
        }

        public static string GetMailCommandListFileName()
        {
            return Helper.GetRootPath() + "\\MailCommandList.xml";
        }

        public static MailCommandDataSet GetMailCommandDataSet()
        {
            MailCommandDataSet result = new MailCommandDataSet();
            string filePath = Helper.GetMailCommandListFileName();
            result.ReadXml(filePath);

            return result;

        }

        public static MailCommand GetMailCommand(MailCommandDataSet mailCommandDataSet, string command)
        {
            MailCommand result = new MailCommand();
            DataRow[] dr = mailCommandDataSet.Tables[0].Select("Command='" + command + "'");

            if (dr.Length == 0)
                throw new Exception("No command found for " + command);

            if (dr.Length > 1)
                throw new Exception("Too many command found for " + command);


            result.Command = dr[0]["Command"].ToString();
            result.Connection = dr[0]["Connection"].ToString();
            result.Description = dr[0]["Description"].ToString();
            result.SqlCommandText = dr[0]["SqlCommandText"].ToString();
            result.CommandType = CommandType.MailCommand;

            return result;
                 
        }

        public static MailCommand GetMailCommand(string command)
        {
            return GetMailCommand(GetMailCommandDataSet(), command);
        }

        public static DataSet GetCommandList()
        {
            DataSet result = GetMailCommandDataSet().Copy();

            foreach(DataRow dr in result.Tables[0].Rows)
            {
                dr["SqlCommandText"] = "";
            }

            return result;
        }

        public static void ColorizeRichTextBox(RichTextBox richTextBox)
        {
            foreach (string key in GetTsqlReservedKeywords())
            {
                ColorizeText(richTextBox, 0, key, Color.Blue);
            }

        }

        private static void ColorizeText(RichTextBox richTextBox, int startIndex, string text, Color color)
        {
            int resultIndex = richTextBox.Find(text, startIndex, RichTextBoxFinds.WholeWord);

            if (resultIndex != -1)
            {
                richTextBox.SelectionColor = color;
                ColorizeText(richTextBox, resultIndex + 1, text, color);
            }

        }

        private static List<string> GetTsqlReservedKeywords()
        {
            List<string> result = new List<string>();
            result.Add("ADD");
            result.Add("EXTERNAL");
            result.Add("PROCEDURE");
            result.Add("ALL");
            result.Add("FETCH");
            result.Add("PUBLIC");
            result.Add("ALTER");
            result.Add("FILE");
            result.Add("RAISERROR");
            result.Add("AND");
            result.Add("FILLFACTOR");
            result.Add("READ");
            result.Add("ANY");
            result.Add("FOR");
            result.Add("READTEXT");
            result.Add("AS");
            result.Add("FOREIGN");
            result.Add("RECONFIGURE");
            result.Add("ASC");
            result.Add("FREETEXT");
            result.Add("REFERENCES");
            result.Add("AUTHORIZATION");
            result.Add("FREETEXTTABLE");
            result.Add("REPLICATION");
            result.Add("BACKUP");
            result.Add("FROM");
            result.Add("RESTORE");
            result.Add("BEGIN");
            result.Add("FULL");
            result.Add("RESTRICT");
            result.Add("BETWEEN");
            result.Add("FUNCTION");
            result.Add("RETURN");
            result.Add("BREAK");
            result.Add("GOTO");
            result.Add("REVERT");
            result.Add("BROWSE");
            result.Add("GRANT");
            result.Add("REVOKE");
            result.Add("BULK");
            result.Add("GROUP");
            result.Add("RIGHT");
            result.Add("BY");
            result.Add("HAVING");
            result.Add("ROLLBACK");
            result.Add("CASCADE");
            result.Add("HOLDLOCK");
            result.Add("ROWCOUNT");
            result.Add("CASE");
            result.Add("IDENTITY");
            result.Add("ROWGUIDCOL");
            result.Add("CHECK");
            result.Add("IDENTITY_INSERT");
            result.Add("RULE");
            result.Add("CHECKPOINT");
            result.Add("IDENTITYCOL");
            result.Add("SAVE");
            result.Add("CLOSE");
            result.Add("IF");
            result.Add("SCHEMA");
            result.Add("CLUSTERED");
            result.Add("IN");
            result.Add("SECURITYAUDIT");
            result.Add("COALESCE");
            result.Add("INDEX");
            result.Add("SELECT");
            result.Add("COLLATE");
            result.Add("INNER");
            result.Add("SEMANTICKEYPHRASETABLE");
            result.Add("COLUMN");
            result.Add("INSERT");
            result.Add("SEMANTICSIMILARITYDETAILSTABLE");
            result.Add("COMMIT");
            result.Add("INTERSECT");
            result.Add("SEMANTICSIMILARITYTABLE");
            result.Add("COMPUTE");
            result.Add("INTO");
            result.Add("SESSION_USER");
            result.Add("CONSTRAINT");
            result.Add("IS");
            result.Add("SET");
            result.Add("CONTAINS");
            result.Add("JOIN");
            result.Add("SETUSER");
            result.Add("CONTAINSTABLE");
            result.Add("KEY");
            result.Add("SHUTDOWN");
            result.Add("CONTINUE");
            result.Add("KILL");
            result.Add("SOME");
            result.Add("CONVERT");
            result.Add("LEFT");
            result.Add("STATISTICS");
            result.Add("CREATE");
            result.Add("LIKE");
            result.Add("SYSTEM_USER");
            result.Add("CROSS");
            result.Add("LINENO");
            result.Add("TABLE");
            result.Add("CURRENT");
            result.Add("LOAD");
            result.Add("TABLESAMPLE");
            result.Add("CURRENT_DATE");
            result.Add("MERGE");
            result.Add("TEXTSIZE");
            result.Add("CURRENT_TIME");
            result.Add("NATIONAL");
            result.Add("THEN");
            result.Add("CURRENT_TIMESTAMP");
            result.Add("NOCHECK");
            result.Add("TO");
            result.Add("CURRENT_USER");
            result.Add("NONCLUSTERED");
            result.Add("TOP");
            result.Add("CURSOR");
            result.Add("NOT");
            result.Add("TRAN");
            result.Add("DATABASE");
            result.Add("NULL");
            result.Add("TRANSACTION");
            result.Add("DBCC");
            result.Add("NULLIF");
            result.Add("TRIGGER");
            result.Add("DEALLOCATE");
            result.Add("OF");
            result.Add("TRUNCATE");
            result.Add("DECLARE");
            result.Add("OFF");
            result.Add("TRY_CONVERT");
            result.Add("DEFAULT");
            result.Add("OFFSETS");
            result.Add("TSEQUAL");
            result.Add("DELETE");
            result.Add("ON");
            result.Add("UNION");
            result.Add("DENY");
            result.Add("OPEN");
            result.Add("UNIQUE");
            result.Add("DESC");
            result.Add("OPENDATASOURCE");
            result.Add("UNPIVOT");
            result.Add("DISK");
            result.Add("OPENQUERY");
            result.Add("UPDATE");
            result.Add("DISTINCT");
            result.Add("OPENROWSET");
            result.Add("UPDATETEXT");
            result.Add("DISTRIBUTED");
            result.Add("OPENXML");
            result.Add("USE");
            result.Add("DOUBLE");
            result.Add("OPTION");
            result.Add("USER");
            result.Add("DROP");
            result.Add("OR");
            result.Add("VALUES");
            result.Add("DUMP");
            result.Add("ORDER");
            result.Add("VARYING");
            result.Add("ELSE");
            result.Add("OUTER");
            result.Add("VIEW");
            result.Add("END");
            result.Add("OVER");
            result.Add("WAITFOR");
            result.Add("ERRLVL");
            result.Add("PERCENT");
            result.Add("WHEN");
            result.Add("ESCAPE");
            result.Add("PIVOT");
            result.Add("WHERE");
            result.Add("EXCEPT");
            result.Add("PLAN");
            result.Add("WHILE");
            result.Add("EXEC");
            result.Add("PRECISION");
            result.Add("WITH");
            result.Add("EXECUTE");
            result.Add("PRIMARY");
            result.Add("WITHIN GROUP");
            result.Add("EXISTS");
            result.Add("PRINT");
            result.Add("WRITETEXT");
            result.Add("EXIT");
            result.Add("PROC");
            result.Add("GO");
            return result;
        }

    }
}
