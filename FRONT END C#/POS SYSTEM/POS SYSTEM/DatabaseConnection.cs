using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public class DatabaseConnection
    {
        public static string connectionString = @"server=localhost;database=logindb;uid=root;pwd=root";
    }
}
