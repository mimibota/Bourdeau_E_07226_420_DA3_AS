using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.IO;

namespace MultiTiersLab1.Utils
{
    internal class DbUtils {




        public static SqlConnection GetDefaultConnection() {
            
            
            SqlConnection conn = new SqlConnection("Server=tcp:127.0.0.1, 1433;" +
                                                   "User ID = sa;" +
                                                   "Password = yourStrong(!)Password;" +
                                                   "database = multi_tier_lab1;" +
                                                   "Integrated security = false;");


            return conn;
        }
    }
}