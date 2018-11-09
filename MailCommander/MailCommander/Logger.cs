using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MailCommander;

namespace MailCommander
{
    internal class Logger
    {
        const string _logFile = "log.txt";
        public static string _logFileFullPath = string.Empty;
        const long maxLogSize = 2097152; // 2mb

        public static void Initialize(string basePath)
        {
            _logFileFullPath = Path.Combine(basePath, _logFile);
            if (File.Exists(_logFileFullPath))
            {
                FileInfo f = new FileInfo(_logFileFullPath);
                if (f.Length > maxLogSize)
                {
                    File.WriteAllText(_logFileFullPath, string.Empty);
                }
            }
        }

        public static void Log(string s)
        {
            Helper.MainForm.Log(DateTime.Now.ToString() + ":> " +s);

            try
            {
                if (string.IsNullOrEmpty(_logFileFullPath))
                {
                    Initialize(Path.GetDirectoryName(Application.ExecutablePath));
                }
                using (var stream = new StreamWriter(_logFileFullPath, true))
                {
                    TextWriter writer = stream;
                    writer.Write(DateTime.Now.ToString() + ":> ");
                    writer.WriteLine(s);
                    writer.Close();
                }
            }
            catch (Exception)
            {

            }

        }
    }
}
