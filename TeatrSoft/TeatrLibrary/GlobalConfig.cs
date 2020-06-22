using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TeatrLibrary.DataAccess;

namespace TeatrLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection()
        {
            SQLConnector sql = new SQLConnector();
            Connection = sql;
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
