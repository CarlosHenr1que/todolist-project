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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            Person person = new Person();

            Person userLogged = person.SignIn(txtEmail.Text, txtPassword.Text);
            if (userLogged != null)
            {
                MessageBox.Show("Logado com sucesso", "Sucesso !"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                new Main(userLogged).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto", "Erro ao autenticar"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
