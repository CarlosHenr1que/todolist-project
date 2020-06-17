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
    public partial class Perfil : Form
    {
        Person loggedUser;
        public Perfil(Person person)
        {
            InitializeComponent();
            this.loggedUser = person;
        }

        public void LoadUserInfo()
        {
            lblUsername.Text = loggedUser.Username;
            txtEmail.Text = loggedUser.Email;
            txtPassword.Text = loggedUser.Password;
            txtUsername.Text = loggedUser.Username;
        }

        private void EnableChange()
        {
            string message = !txtUsername.Enabled ? "Os campos foram habilidatos para alteração" : "Campos desabilitados";

            txtUsername.Enabled = !txtUsername.Enabled;
            txtPassword.Enabled = !txtPassword.Enabled;

            MessageBox.Show(message, "Atenção"
                   , MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            EnableChange();
          
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            loggedUser.Username = txtUsername.Text;
            loggedUser.Password = txtPassword.Text;

            if (loggedUser.Update())
            {
                MessageBox.Show("Alteração realizada.", "OK"
                  , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Algo deu errado.", "Erro"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
