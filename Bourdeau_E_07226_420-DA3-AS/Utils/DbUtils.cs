using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.IO;

namespace MultiTiersLab1.Utils
{
    internal class DbUtils {


        private static readonly string DEFAULT_DB_FILE_NAME = "lab.mdf";

        public static readonly string EXECUTION_DIRECTORY = 
            Path.GetFullPath(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

        public static readonly string DEFAULT_DB_FILE_PATH = Path.GetFullPath(
            EXECUTION_DIRECTORY + Path.DirectorySeparatorChar + 
            ".." + Path.DirectorySeparatorChar + 
            ".." + Path.DirectorySeparatorChar + DEFAULT_DB_FILE_NAME);


        public static SqlConnection GetDefaultConnection() {

            // option 1 : connection string as a literal string
            string connectionStringLiteral0 = $"Server=.\\SQL2019EXPRESS; " +
                                              $"Integrated_security=true; " +
                                              $"AttachDbFilename={DEFAULT_DB_FILE_PATH}; " +
                                              $"User Instance=true;";


            // option 2 : connection string built from a dictionary
            Dictionary<string, string> connStringKeyValuePairs = new Dictionary<string, string>();
            connStringKeyValuePairs.Add("Server", ".\\SQL2019EXPRESS");
            connStringKeyValuePairs.Add("Integrated_security", "true");
            connStringKeyValuePairs.Add("AttachDbFilename", DEFAULT_DB_FILE_PATH);
            connStringKeyValuePairs.Add("User Instance", "true");

            string connectionString = "";
            foreach (KeyValuePair<string, string> pair in connStringKeyValuePairs) {
                connectionString += pair.Key + "=" + pair.Value + ";";
            }



            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}