using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitialiseConnections(bool database, bool textFile)
        {
            if (database)
            {
                //TODO - Setup the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFile)
            {
                //TODO - Setup the SQL Connector properly
                TextConnector text = new TextConnector();
                Connections.Add(text);

            }
        }
    }
}
