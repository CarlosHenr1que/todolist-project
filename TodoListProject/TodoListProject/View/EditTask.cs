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
    public partial class EditTask : Form
    {
        Task task;
        public EditTask(Task task)
        {
            InitializeComponent();
            this.task = task;
        }

        private void LoadData()
        {
            txtTitle.Text = task.Title;
            deadlineDataPicker.Value = task.Deadline;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            task.Title = txtTitle.Text;
            task.Deadline = deadlineDataPicker.Value;
            if (task.Update())
            {
                MessageBox.Show("Projeto alterado com sucesso", "OK"
                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void EditTask_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
