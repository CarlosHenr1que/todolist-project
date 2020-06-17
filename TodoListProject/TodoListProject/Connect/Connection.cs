using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListProject.Connect
{
    class Connection
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["TodoListProject.Properties.Settings.todolistprojectConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
