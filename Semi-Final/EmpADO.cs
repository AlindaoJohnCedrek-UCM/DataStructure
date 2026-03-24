using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EmployeeRoster
{
    public class EmpADO
    {
        public bool AddEmployee(Employee emp) {
            MySqlConnection EmpConn = EmpDB.GetConnection();
            EmpConn.Open();
            String query = "INSERT INTO employee(F_name,L_name,Address,Number) VALUES (@F_name,@L_name,@Address,@Number)";
            MySqlCommand cmd = new MySqlCommand(query, EmpConn);
            cmd.Parameters.AddWithValue("@F_name", emp.firstName);
            cmd.Parameters.AddWithValue("@L_name", emp.lastName);
            cmd.Parameters.AddWithValue("@Address", emp.Address);
            cmd.Parameters.AddWithValue("@Number", emp.Number);

            return cmd.ExecuteNonQuery() > 0;


        }
        public Employee GetEmployee(String FirstName, String LastName) { 
            MySqlConnection EmpConn = EmpDB.GetConnection();
            EmpConn.Open();
            String query = "SELECT * FROM employee WHERE F_name=@F_name AND L_name=@L_name";
            MySqlCommand cmd = new MySqlCommand(query, EmpConn);
            cmd.Parameters.AddWithValue("@F_name", FirstName);
            cmd.Parameters.AddWithValue("@L_name", LastName);
     

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Employee
                {
                    ID = reader.GetInt32("ID"),
                    firstName = reader.GetString("F_name"),
                    lastName = reader.GetString("L_name"),
                    Address = reader.GetString("Address"),
                    Number = reader.GetValue(reader.GetOrdinal("Number")).ToString()

                };
            }
            return null;
        }
        public List<Employee> getAllEmployee() {
            List<Employee> employees = new List<Employee>();

            MySqlConnection EmpConn = EmpDB.GetConnection();
            EmpConn.Open();

            String query = "SELECT * FROM employee";
            MySqlCommand cmd = new MySqlCommand(query, EmpConn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) { 
            
                employees.Add(new Employee
                {
                    ID = reader.GetInt32("ID"),
                    firstName = reader.GetString("F_name"),
                    lastName = reader.GetString("L_name"),
                    Address = reader.GetString("Address"),
                    Number = reader.GetValue(reader.GetOrdinal("Number")).ToString()
                });

               

            }
            return employees;
        }

        
    }

}
