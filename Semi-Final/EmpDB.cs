using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace EmployeeRoster
{
    public class EmpDB
    {
        public static MySqlConnection GetConnection() {
            String ConnectionString = "server=localhost;user=root;password=;database=empdb;";
            return new MySqlConnection(ConnectionString);

        }
    }
}
