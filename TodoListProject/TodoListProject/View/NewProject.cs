using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoListProject.Controller;

namespace TodoListProject.View
{
    public partial class NewProject : Form
    {
        int user_id;
        public NewProject(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            TodoListProject.Project project = new TodoListProject.Project();
            if (project.Create(txtTitle.Text, txtAbout.Text, deadlineDataPicker.Value, user_id))
            {
                MessageBox.Show("Sucesso !", "Projeto criado com sucesso"
                   , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
            }
            else
            {

            }
           
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewProject_Load(object sender, EventArgs e)
        {

        }
    }
}
