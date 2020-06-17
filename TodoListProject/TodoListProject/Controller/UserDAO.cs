using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListProject.Connect;

namespace TodoListProject.Controller
{
    class UserDAO
    {
        private MySqlConnection con;
        private Connection connection;

        public object[] SignIn(String email, String password)
        {
            object[] retorno = new object[3];

            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();
            String query = "SELECT * FROM Persons WHERE email = ?email " +
                "AND password = ?password";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?password", password);
                
                MySqlDataReader mysqlDR = cmd.ExecuteReader();
                while (mysqlDR.Read())
                {
                    retorno[0] = mysqlDR["id"];
                    retorno[1] = mysqlDR["username"];
                    retorno[2] = mysqlDR["email"];
                }
                mysqlDR.Close();
                return retorno;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public Boolean SignUp (String username, String email, String password)
        {
            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();
            String query = "INSERT INTO Persons(username, email, password) VALUES(?username, ?email, ?password)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("?username", username);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?password", password);
                int response = cmd.ExecuteNonQuery();
                Console.WriteLine(response);
                if (response > 0)
                {
                    return true;
                }
                else { 
                    return false; 
                }

            }
            finally
            {
                con.Close();
            }
        }

        public bool Update(Person person)
        {
            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "UPDATE Persons SET username = ?username, password = ?password " +
                "WHERE id = ?id";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?username", person.Username);
                cmd.Parameters.AddWithValue("?password", person.Password);
                cmd.Parameters.AddWithValue("?id", person.Id);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
