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
    public partial class ProjectsList : Form
    {
        int user_id;
        private Int32 catchRowIndex;
        public ProjectsList(int user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
        }

        public void LoadData()
        {
            TodoListProject.Project project = new TodoListProject.Project();
            List<TodoListProject.Project> retorno = project.Show(user_id, false);
            bunifuCustomDataGrid1.Rows.Clear();
            foreach (TodoListProject.Project obj in retorno)
            {
                TodoListProject.Project project2 = obj;
                bunifuCustomDataGrid1.Rows.Add(project2.Id, project2.Title, project2.About, project2.Deadline, 
                    project2.Completed, project2.Created_at, project2.Updated_at, project2.Deleted_at, project2.User_id);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectsList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuCustomDataGrid1.Rows[e.RowIndex].Selected = true;
            if(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value != null)
            {
                Project project = new Project();
                project.Id = int.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString());
                project.Title = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
                project.About = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
                project.Deadline = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString());
                project.Completed = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString() == "True" ? true : false;
                project.Created_at = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString());
                project.Updated_at = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString());
                project.Deleted_at = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[7].Value.ToString());
                project.User_id = int.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[8].Value.ToString());
                ShowProject showproject = new ShowProject(project);
                showproject.ShowDialog();
                LoadData();

            }


        }

        private void bunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
