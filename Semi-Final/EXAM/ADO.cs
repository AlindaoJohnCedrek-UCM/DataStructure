using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace midterm
{
    public class ADO
    {
        public User Login(String username, String password) { 
        
            MySqlConnection connDB = DB.getConnection();
            connDB.Open();

            String query = "SELECT * FROM user WHERE username = @username AND password = @password";
            MySqlCommand cmd = new MySqlCommand(query, connDB);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) {

                return new User
                {
                    id = reader.GetInt32("id").ToString(),
                    username = reader.GetString("username"),
                    Fname = reader.GetString("Fname"),
                    Mname = reader.GetString("Mname"),
                    Lname = reader.GetString("Lname"),
                    password = reader.GetString("password"),
                    suffix = reader.GetString("suffix"),
                    department = reader.GetString("department"),
                    Number = reader.GetString("Number")


                };
               
            }
            return null;
        }
        public bool Register(User user) {
            MySqlConnection connDB = DB.getConnection();
            connDB.Open();

            String query = "INSERT INTO user (username, Fname, Mname, Lname, password, suffix, department, Number) VALUES (@username, @Fname, @Mname, @Lname, @password, @suffix, @department, @Number)";
            MySqlCommand cmd = new MySqlCommand(query, connDB);
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue("@Fname", user.Fname);
            cmd.Parameters.AddWithValue("@Mname", user.Mname);
            cmd.Parameters.AddWithValue("@Lname", user.Lname);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@suffix", user.suffix);
            cmd.Parameters.AddWithValue("@department", user.department);
            cmd.Parameters.AddWithValue("@Number", user.Number);

            return cmd.ExecuteNonQuery() > 0;

        }
    }
}
