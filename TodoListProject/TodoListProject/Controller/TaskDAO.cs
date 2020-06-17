using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListProject.Connect;

namespace TodoListProject.Controller
{
    class TaskDAO
    {
        private MySqlConnection con;
        private Connection connection;

        public List<Task> Index(int project_id)
        {
            List<Task> retorno = new List<Task>();

            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();
            String query = "SELECT * FROM Tasks WHERE project_id = ?project_id  AND completed = FALSE ";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?project_id", project_id);
                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                while (mysqlDR.Read())
                {
                    Task task = new Task();
                    task.Id = (int)mysqlDR["id"];
                    task.Title = (string)mysqlDR["title"];
                    task.Deadline = (DateTime)mysqlDR["deadline"];
                    task.Completed = (bool)mysqlDR["completed"];
                    task.Created_at = (DateTime)mysqlDR["created_at"];
                    task.Updated_at = (DateTime)mysqlDR["updated_at"];
                    task.Project_id = (int)mysqlDR["project_id"];
                    retorno.Add(task);

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

        public bool Create(Task task)
        {
            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "INSERT INTO Tasks(title, deadline, project_id) " +
                "VALUES(?title, ?deadline, ?project_id)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("?title", task.Title);
                cmd.Parameters.AddWithValue("?deadline", task.Deadline);
                cmd.Parameters.AddWithValue("?project_id", task.Project_id);

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

        public bool Update(Task task)
        {
            con = new MySqlConnection();
            connection = new Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "UPDATE Tasks SET title = ?title, deadline = ?deadline, " +
                "completed = ?completed, created_at = ?created_at, updated_at = ?updated_at WHERE id = ?id";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?title", task.Title);
                cmd.Parameters.AddWithValue("?deadline", task.Deadline);
                cmd.Parameters.AddWithValue("?completed", task.Completed);
                cmd.Parameters.AddWithValue("?created_at", task.Created_at);
                cmd.Parameters.AddWithValue("?updated_at", DateTime.Today);
                cmd.Parameters.AddWithValue("?id", task.Id);
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
