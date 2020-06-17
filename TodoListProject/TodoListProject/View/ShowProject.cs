using Org.BouncyCastle.Utilities;
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
    public partial class ShowProject : Form
    {
        Project project;
        Task task = new Task();
        public ShowProject(Project project)
        {
            InitializeComponent();
            this.project = project;
        }

        public void loadProject()
        {
            txtTitle.Text = project.Title;
            txtAbout.Text = project.About;
            deadlineDataPicker.Value = project.Deadline;
        }

        public void LoadData()
        {
            List<Task> retorno = task.Show(project.Id);
            TasksDataGridView.Rows.Clear();
            foreach (TodoListProject.Task obj in retorno)
            {
                TodoListProject.Task task2 = obj;
                TasksDataGridView.Rows.Add(task2.Id, task2.Title, task2.Deadline,
                    task2.Completed, task2.Created_at, task2.Updated_at,  task2.Project_id);
            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowProject_Load(object sender, EventArgs e)
        {
            loadProject();
            LoadData();
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            EnableChange();
        }

        private void EnableChange()
        {
            string message = !txtTitle.Enabled ? "Os campos foram habilidatos para alteração" : "Campos desabilitados";
            
            txtTitle.Enabled = !txtTitle.Enabled;
            txtAbout.Enabled = !txtAbout.Enabled;
            //deadlineDataPicker.Enabled = !deadlineDataPicker.Enabled;

            MessageBox.Show(message, "Atenção"
                   , MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            project.Title = txtTitle.Text;
            project.About = txtAbout.Text;
            project.Deadline = deadlineDataPicker.Value;
            if (project.Update())
            {
                MessageBox.Show("Projeto alterado com sucesso", "OK"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Houve erros na alteração do projeto", "Erro"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTitle.Enabled = !txtTitle.Enabled;
            txtAbout.Enabled = !txtAbout.Enabled;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (project.Delete())
            {
                MessageBox.Show("Deletado com sucesso", "OK"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnMarksProjectAsCompleted_Click(object sender, EventArgs e)
        {

            project.Completed = true;
            if (project.Update())
            {
                MessageBox.Show("Projeto finalizado com sucesso", "OK"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnNewTaks_Click(object sender, EventArgs e)
        {
            NewTask newtask = new NewTask(project.Id);
            newtask.ShowDialog();
            LoadData();
        }

        private void TasksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TasksDataGridView.Rows[e.RowIndex].Selected = true;
            if (TasksDataGridView.CurrentRow.Cells[0].Value != null)
            {
                task.Id = int.Parse(TasksDataGridView.CurrentRow.Cells[0].Value.ToString());
                task.Title = TasksDataGridView.CurrentRow.Cells[1].Value.ToString();
                task.Deadline = DateTime.Parse(TasksDataGridView.CurrentRow.Cells[2].Value.ToString());
                task.Completed = TasksDataGridView.CurrentRow.Cells[3].Value.ToString() == "True" ? true : false;
                task.Created_at = DateTime.Parse(TasksDataGridView.CurrentRow.Cells[4].Value.ToString());
                task.Updated_at = DateTime.Parse(TasksDataGridView.CurrentRow.Cells[5].Value.ToString());
                task.Project_id = int.Parse(TasksDataGridView.CurrentRow.Cells[6].Value.ToString());
            }


        }

        private void TasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMarkTaskAsCompleted_Click(object sender, EventArgs e)
        {
           if(task.Id != 0)
            {
                task.Completed = true;
                if (task.Update())
                {
                    MessageBox.Show("Tarefa finalizado com sucesso", "OK"
                     , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Nenhuma tarefa foi selecionada", "OK"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
          if(task.Id != 0)
            {
                EditTask edittask = new EditTask(task);
                edittask.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Nenhuma tarefa foi selecionada", "OK"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
