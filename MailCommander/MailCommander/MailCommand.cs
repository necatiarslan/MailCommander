using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;

namespace MailCommander
{
    public class MailCommand
    {
        public string Connection { get; set; }
        public string Command { get; set; }
        public string Description { get; set; }
        public string SqlCommandText { get; set; }
        public string ConditionSqlCommandText { get; set; }
        public int Interval { get; set; }
        public int EndAfterTimes { get; set; }
        public CommandType CommandType { get; set; }
        public string ToAddress { get; set; }
                
        internal DataSet Data { get; set; }
        internal Exception Exception { get; set; }


        public string GetConnectionString(){
            return ConfigurationManager.ConnectionStrings[this.Connection].ConnectionString;
        }

        public string GetConnectionProviderName()
        {
            return ConfigurationManager.ConnectionStrings[this.Connection].ProviderName;
        }
    }

    public enum CommandType
    {
        None = 0,
        MailCommand = 1,
        Exit = 1000,
        Hi = 1001,
        Stop = 1002,
        Start = 1004,
        CommandList = 1003
        
    }
}
