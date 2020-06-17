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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show( "Por favor, complete todos os campos", "Erro !"
                  , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                UserDAO userdao = new UserDAO();
                if (userdao.SignUp(txtUsername.Text, txtEmail.Text, txtPassword.Text))
                {
                    MessageBox.Show("OK", "Usuario Criado com Sucesso"
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("OK", "Erro ao criar Usuario"
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
