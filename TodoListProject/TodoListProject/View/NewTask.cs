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
    public partial class NewTask : Form
    {
        Task task;
        int project_id;
        public NewTask(int project_id)
        {
            InitializeComponent();
            this.project_id = project_id;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            task = new Task();
            task.Title = txtTitle.Text;
            task.Deadline = deadlineDataPicker.Value;
            task.Project_id = this.project_id;
            if (task.Create())
            {
                MessageBox.Show("Tarefa criada com sucesso", "OK"
                  , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Houve erros na criação da tarefa", "Erro"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
