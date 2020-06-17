namespace TodoListProject
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPerfil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.projectsPanel = new System.Windows.Forms.Panel();
            this.btnListarProjetos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNovoProjeto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProjetos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserLogged = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.panelMainMenu.SuspendLayout();
            this.projectsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMainMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelMainMenu.Controls.Add(this.btnExit);
            this.panelMainMenu.Controls.Add(this.btnPerfil);
            this.panelMainMenu.Controls.Add(this.projectsPanel);
            this.panelMainMenu.Controls.Add(this.btnProjetos);
            this.panelMainMenu.Controls.Add(this.btnInicio);
            this.panelMainMenu.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.panelMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(59, 554);
            this.panelMainMenu.TabIndex = 0;
            this.panelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainMenu_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Active = false;
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "    Perfil";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = global::TodoListProject.Properties.Resources.sair;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 50D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(0, 495);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(59, 59);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "    Perfil";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Active = false;
            this.btnPerfil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnPerfil.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerfil.BorderRadius = 0;
            this.btnPerfil.ButtonText = "    Perfil";
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnPerfil, BunifuAnimatorNS.DecorationType.None);
            this.btnPerfil.DisabledColor = System.Drawing.Color.Gray;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPerfil.Iconimage = global::TodoListProject.Properties.Resources.profile1;
            this.btnPerfil.Iconimage_right = null;
            this.btnPerfil.Iconimage_right_Selected = null;
            this.btnPerfil.Iconimage_Selected = null;
            this.btnPerfil.IconMarginLeft = 0;
            this.btnPerfil.IconMarginRight = 0;
            this.btnPerfil.IconRightVisible = true;
            this.btnPerfil.IconRightZoom = 0D;
            this.btnPerfil.IconVisible = true;
            this.btnPerfil.IconZoom = 50D;
            this.btnPerfil.IsTab = false;
            this.btnPerfil.Location = new System.Drawing.Point(0, 323);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnPerfil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnPerfil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPerfil.selected = false;
            this.btnPerfil.Size = new System.Drawing.Size(59, 59);
            this.btnPerfil.TabIndex = 10;
            this.btnPerfil.Text = "    Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Textcolor = System.Drawing.Color.White;
            this.btnPerfil.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // projectsPanel
            // 
            this.projectsPanel.Controls.Add(this.btnListarProjetos);
            this.projectsPanel.Controls.Add(this.btnNovoProjeto);
            this.bunifuTransition1.SetDecoration(this.projectsPanel, BunifuAnimatorNS.DecorationType.None);
            this.projectsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectsPanel.Location = new System.Drawing.Point(0, 196);
            this.projectsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectsPanel.Name = "projectsPanel";
            this.projectsPanel.Size = new System.Drawing.Size(59, 127);
            this.projectsPanel.TabIndex = 6;
            this.projectsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.projectsPanel_Paint);
            // 
            // btnListarProjetos
            // 
            this.btnListarProjetos.Active = false;
            this.btnListarProjetos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnListarProjetos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListarProjetos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListarProjetos.BorderRadius = 0;
            this.btnListarProjetos.ButtonText = "    Projetos";
            this.btnListarProjetos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnListarProjetos, BunifuAnimatorNS.DecorationType.None);
            this.btnListarProjetos.DisabledColor = System.Drawing.Color.Gray;
            this.btnListarProjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarProjetos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnListarProjetos.Iconimage = global::TodoListProject.Properties.Resources.list;
            this.btnListarProjetos.Iconimage_right = null;
            this.btnListarProjetos.Iconimage_right_Selected = null;
            this.btnListarProjetos.Iconimage_Selected = null;
            this.btnListarProjetos.IconMarginLeft = 0;
            this.btnListarProjetos.IconMarginRight = 0;
            this.btnListarProjetos.IconRightVisible = true;
            this.btnListarProjetos.IconRightZoom = 0D;
            this.btnListarProjetos.IconVisible = true;
            this.btnListarProjetos.IconZoom = 50D;
            this.btnListarProjetos.IsTab = false;
            this.btnListarProjetos.Location = new System.Drawing.Point(0, 59);
            this.btnListarProjetos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnListarProjetos.Name = "btnListarProjetos";
            this.btnListarProjetos.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnListarProjetos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnListarProjetos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnListarProjetos.selected = false;
            this.btnListarProjetos.Size = new System.Drawing.Size(59, 59);
            this.btnListarProjetos.TabIndex = 10;
            this.btnListarProjetos.Text = "    Projetos";
            this.btnListarProjetos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarProjetos.Textcolor = System.Drawing.Color.White;
            this.btnListarProjetos.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnListarProjetos.Click += new System.EventHandler(this.btnListarProjetos_Click);
            // 
            // btnNovoProjeto
            // 
            this.btnNovoProjeto.Active = false;
            this.btnNovoProjeto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnNovoProjeto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNovoProjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoProjeto.BorderRadius = 0;
            this.btnNovoProjeto.ButtonText = "   Novo";
            this.btnNovoProjeto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNovoProjeto, BunifuAnimatorNS.DecorationType.None);
            this.btnNovoProjeto.DisabledColor = System.Drawing.Color.Gray;
            this.btnNovoProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovoProjeto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNovoProjeto.Iconimage = global::TodoListProject.Properties.Resources.plus;
            this.btnNovoProjeto.Iconimage_right = null;
            this.btnNovoProjeto.Iconimage_right_Selected = null;
            this.btnNovoProjeto.Iconimage_Selected = null;
            this.btnNovoProjeto.IconMarginLeft = 0;
            this.btnNovoProjeto.IconMarginRight = 0;
            this.btnNovoProjeto.IconRightVisible = true;
            this.btnNovoProjeto.IconRightZoom = 0D;
            this.btnNovoProjeto.IconVisible = true;
            this.btnNovoProjeto.IconZoom = 50D;
            this.btnNovoProjeto.IsTab = false;
            this.btnNovoProjeto.Location = new System.Drawing.Point(0, 0);
            this.btnNovoProjeto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNovoProjeto.Name = "btnNovoProjeto";
            this.btnNovoProjeto.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnNovoProjeto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnNovoProjeto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNovoProjeto.selected = false;
            this.btnNovoProjeto.Size = new System.Drawing.Size(59, 59);
            this.btnNovoProjeto.TabIndex = 10;
            this.btnNovoProjeto.Text = "   Novo";
            this.btnNovoProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProjeto.Textcolor = System.Drawing.Color.White;
            this.btnNovoProjeto.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnNovoProjeto.Click += new System.EventHandler(this.btnNovoProjeto_Click);
            // 
            // btnProjetos
            // 
            this.btnProjetos.Active = false;
            this.btnProjetos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnProjetos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProjetos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProjetos.BorderRadius = 0;
            this.btnProjetos.ButtonText = "    Projetos";
            this.btnProjetos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnProjetos, BunifuAnimatorNS.DecorationType.None);
            this.btnProjetos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjetos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProjetos.Iconimage = global::TodoListProject.Properties.Resources.projeto1;
            this.btnProjetos.Iconimage_right = null;
            this.btnProjetos.Iconimage_right_Selected = null;
            this.btnProjetos.Iconimage_Selected = null;
            this.btnProjetos.IconMarginLeft = 0;
            this.btnProjetos.IconMarginRight = 0;
            this.btnProjetos.IconRightVisible = true;
            this.btnProjetos.IconRightZoom = 0D;
            this.btnProjetos.IconVisible = true;
            this.btnProjetos.IconZoom = 50D;
            this.btnProjetos.IsTab = false;
            this.btnProjetos.Location = new System.Drawing.Point(0, 137);
            this.btnProjetos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnProjetos.Name = "btnProjetos";
            this.btnProjetos.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnProjetos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnProjetos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProjetos.selected = false;
            this.btnProjetos.Size = new System.Drawing.Size(59, 59);
            this.btnProjetos.TabIndex = 9;
            this.btnProjetos.Text = "    Projetos";
            this.btnProjetos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjetos.Textcolor = System.Drawing.Color.White;
            this.btnProjetos.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnProjetos.Click += new System.EventHandler(this.bunifuFlatButton5_Click_1);
            // 
            // btnInicio
            // 
            this.btnInicio.Active = false;
            this.btnInicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnInicio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "    Inicio";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = global::TodoListProject.Properties.Resources.home5;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 50D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(0, 78);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnInicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(112)))));
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(59, 59);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "    Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.White;
            this.btnInicio.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 78);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panel2
            // 
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 554);
            this.panel2.TabIndex = 1;
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.FormPanel, BunifuAnimatorNS.DecorationType.None);
            this.FormPanel.Location = new System.Drawing.Point(59, 54);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1245, 500);
            this.FormPanel.TabIndex = 2;
            this.FormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUserLogged);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(59, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1245, 54);
            this.panel3.TabIndex = 3;
            // 
            // txtUserLogged
            // 
            this.txtUserLogged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserLogged.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.txtUserLogged, BunifuAnimatorNS.DecorationType.None);
            this.txtUserLogged.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLogged.Location = new System.Drawing.Point(1075, 9);
            this.txtUserLogged.Name = "txtUserLogged";
            this.txtUserLogged.Size = new System.Drawing.Size(89, 21);
            this.txtUserLogged.TabIndex = 0;
            this.txtUserLogged.Text = "Teste teste";
            this.txtUserLogged.Click += new System.EventHandler(this.txtUserLogged_Click);
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 554);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.projectsPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel projectsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel FormPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnProjetos;
        private Bunifu.Framework.UI.BunifuFlatButton btnNovoProjeto;
        private Bunifu.Framework.UI.BunifuFlatButton btnListarProjetos;
        private Bunifu.Framework.UI.BunifuFlatButton btnPerfil;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel txtUserLogged;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
    }
}

