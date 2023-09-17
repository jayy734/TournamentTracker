using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;
using System.Runtime.InteropServices;

namespace TrackerLibrary
{
    public class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 
        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.sql:
                    break;
                case DatabaseType.TextFile:
                    break;
                default: 
                    break;
            }
            if (db == DatabaseType.sql)
            {   
                //TODO - set up the sql connector properly 
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile) 
            {
                // TODO - Create the text connection
                TextConnector text = new TextConnector();
                Connection = text;
            }

        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
