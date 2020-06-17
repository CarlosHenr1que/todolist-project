using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListProject.View
{
    public partial class Home : Form
    {
        Person loggedUser;
        public Home(Person person)
        {
            InitializeComponent();
            this.loggedUser = person;
        }

        public void LoadData()
        {
            TodoListProject.Project project = new TodoListProject.Project();
            List<TodoListProject.Project> retorno = project.Show(loggedUser.Id, true);
            bunifuCustomDataGrid1.Rows.Clear();
            foreach (TodoListProject.Project obj in retorno)
            {
                TodoListProject.Project project2 = obj;
                bunifuCustomDataGrid1.Rows.Add(project2.Id, project2.Title, project2.About, project2.Deadline,
                    project2.Completed, project2.Created_at, project2.Updated_at, project2.Deleted_at, project2.User_id);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
    }
}
