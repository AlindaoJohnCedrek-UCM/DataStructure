using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace midterm
{
    public class DB
    {
        public static MySqlConnection getConnection() {
        
            String connDB = "server=localhost;user=root;password=;database=userdb";
            return new MySqlConnection(connDB);
        }
    }
}
