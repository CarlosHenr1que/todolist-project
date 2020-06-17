using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListProject.Connect;

namespace TodoListProject.Controller
{
    class ProjectDAO
    {
        private MySqlConnection con;
        private Connection connection;

        public List<Project> Index(int user_id, bool completed)
        {
            List<Project> retorno = new List<Project>();

            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();
            String query = "SELECT * FROM Projects WHERE user_id = ?user_id AND completed = ?completed";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?user_id", user_id);
                cmd.Parameters.AddWithValue("?completed", completed);
                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                while (mysqlDR.Read())
                {
                    Project projetoAtual = new Project();
                    projetoAtual.Id = (int)mysqlDR["id"];
                    projetoAtual.Title = (string)mysqlDR["title"];
                    projetoAtual.About = (string)mysqlDR["about"];
                    projetoAtual.Deadline = (DateTime)mysqlDR["deadline"];
                    projetoAtual.Completed = (bool)mysqlDR["completed"];
                    projetoAtual.Created_at = (DateTime)mysqlDR["created_at"];
                    projetoAtual.Updated_at = (DateTime)mysqlDR["updated_at"];
                    //projetoAtual.Deleted_at = (DateTime)mysqlDR["deleted_at"];
                    projetoAtual.User_id = (int)mysqlDR["user_id"];
                    retorno.Add(projetoAtual);
                    
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
        public bool Create(String title, String about, DateTime deadline, int user_id)
        {
            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "INSERT INTO Projects(title, about, deadline, user_id) " +
                "VALUES(?title, ?about, ?deadline, ?user_id)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("?title", title);
                cmd.Parameters.AddWithValue("?about", about);
                cmd.Parameters.AddWithValue("?deadline", deadline);
                cmd.Parameters.AddWithValue("?user_id", user_id);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            finally
            {
                con.Close();
            }
        }

        public bool Update(Project project)
        {
            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "UPDATE Projects SET title = ?title, about = ?about, deadline = ?deadline, " +
                "completed = ?completed, created_at = ?created_at, updated_at = ?updated_at WHERE id = ?id";
        
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?title", project.Title);
                cmd.Parameters.AddWithValue("?about", project.About);
                cmd.Parameters.AddWithValue("?deadline", project.Deadline);
                cmd.Parameters.AddWithValue("?completed", project.Completed);
                cmd.Parameters.AddWithValue("?created_at", project.Created_at);
                cmd.Parameters.AddWithValue("?updated_at", DateTime.Today);
                cmd.Parameters.AddWithValue("?deleted_at", project.Deleted_at);
                cmd.Parameters.AddWithValue("?id", project.Id);
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

        public bool Delete(Project project)
        {
            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "DELETE FROM Projects WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", project.Id);
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
