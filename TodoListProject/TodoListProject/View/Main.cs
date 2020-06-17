using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
using TodoListProject.View;

namespace TodoListProject
{
    public partial class Main : Form
    {
        Person userLogged;
        ProjectsList projectsList;
        Perfil perfil;
        Home home;

        public Main(Person person)
        {
            InitializeComponent();
            customizeDesign();
            userLogged = person;
            LoadUserInfo(person);

            projectsList = new ProjectsList(userLogged.Id);
            perfil = new Perfil(userLogged);
            home = new Home(userLogged);


        }

        public void LoadUserInfo(Person user)
        {
            txtUserLogged.Text = user.Username;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            
        }

        private void customizeDesign()
        {
            projectsPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if(projectsPanel.Visible == true)
            {
                projectsPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void subMenu1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void projectsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
          

        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            showSubMenu(projectsPanel);
        }

        private void btnNovoProjeto_Click(object sender, EventArgs e)
        {
            NewProject newProject = new NewProject(userLogged.Id);
            newProject.ShowDialog();
            projectsList.LoadData();
        }

        private void btnListarProjetos_Click(object sender, EventArgs e)
        {
            
            projectsList.TopLevel = false;
            projectsList.AutoScroll = true;
            FormPanel.Controls.Add(projectsList);
            projectsList.Show();
            perfil.Hide();
            home.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtUserLogged_Click(object sender, EventArgs e)
        {

        }

        private void FormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            perfil.TopLevel = false;
            perfil.AutoScroll = true;
            FormPanel.Controls.Add(perfil);
            projectsList.Hide();
            perfil.Show();
            home.Hide();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            home.TopLevel = false;
            home.AutoScroll = true;
            FormPanel.Controls.Add(home);
            home.Show();
            perfil.Hide();
            projectsList.Hide();

        }
    }
}
