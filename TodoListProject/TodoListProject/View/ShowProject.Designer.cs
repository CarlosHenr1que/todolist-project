namespace TodoListProject.View
{
    partial class ShowProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProject));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblAbout = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.deadlineDataPicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDeadline = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTaks = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdateTask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewTaks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMarkTaskAsCompleted = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TasksDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveProject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMarksProjectAsCompleted = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateProject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAbout = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtTitle = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(35, 252);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(103, 17);
            this.lblAbout.TabIndex = 15;
            this.lblAbout.Text = "Sobre o projeto";
            // 
            // deadlineDataPicker
            // 
            this.deadlineDataPicker.BackColor = System.Drawing.Color.DodgerBlue;
            this.deadlineDataPicker.BorderRadius = 0;
            this.deadlineDataPicker.ForeColor = System.Drawing.Color.White;
            this.deadlineDataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.deadlineDataPicker.FormatCustom = null;
            this.deadlineDataPicker.Location = new System.Drawing.Point(37, 182);
            this.deadlineDataPicker.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.deadlineDataPicker.Name = "deadlineDataPicker";
            this.deadlineDataPicker.Size = new System.Drawing.Size(740, 44);
            this.deadlineDataPicker.TabIndex = 13;
            this.deadlineDataPicker.Value = new System.DateTime(2020, 5, 6, 21, 45, 34, 741);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(33, 36);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 17);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Titulo do Projeto";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(35, 139);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(106, 17);
            this.lblDeadline.TabIndex = 16;
            this.lblDeadline.Text = "Data de entrega";
            this.lblDeadline.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // lblTaks
            // 
            this.lblTaks.AutoSize = true;
            this.lblTaks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaks.Location = new System.Drawing.Point(35, 359);
            this.lblTaks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaks.Name = "lblTaks";
            this.lblTaks.Size = new System.Drawing.Size(118, 17);
            this.lblTaks.TabIndex = 18;
            this.lblTaks.Text = "Tarefas do projeto";
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Active = false;
            this.btnUpdateTask.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateTask.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateTask.BorderRadius = 0;
            this.btnUpdateTask.ButtonText = "Editar Tarefa";
            this.btnUpdateTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTask.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateTask.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateTask.Iconimage = null;
            this.btnUpdateTask.Iconimage_right = null;
            this.btnUpdateTask.Iconimage_right_Selected = null;
            this.btnUpdateTask.Iconimage_Selected = null;
            this.btnUpdateTask.IconMarginLeft = 0;
            this.btnUpdateTask.IconMarginRight = 0;
            this.btnUpdateTask.IconRightVisible = true;
            this.btnUpdateTask.IconRightZoom = 0D;
            this.btnUpdateTask.IconVisible = true;
            this.btnUpdateTask.IconZoom = 90D;
            this.btnUpdateTask.IsTab = false;
            this.btnUpdateTask.Location = new System.Drawing.Point(1077, 382);
            this.btnUpdateTask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateTask.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateTask.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateTask.selected = false;
            this.btnUpdateTask.Size = new System.Drawing.Size(199, 47);
            this.btnUpdateTask.TabIndex = 20;
            this.btnUpdateTask.Text = "Editar Tarefa";
            this.btnUpdateTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateTask.Textcolor = System.Drawing.Color.White;
            this.btnUpdateTask.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnNewTaks
            // 
            this.btnNewTaks.Active = false;
            this.btnNewTaks.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnNewTaks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewTaks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewTaks.BorderRadius = 0;
            this.btnNewTaks.ButtonText = "Nova tarefa";
            this.btnNewTaks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTaks.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewTaks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewTaks.Iconimage = null;
            this.btnNewTaks.Iconimage_right = null;
            this.btnNewTaks.Iconimage_right_Selected = null;
            this.btnNewTaks.Iconimage_Selected = null;
            this.btnNewTaks.IconMarginLeft = 0;
            this.btnNewTaks.IconMarginRight = 0;
            this.btnNewTaks.IconRightVisible = true;
            this.btnNewTaks.IconRightZoom = 0D;
            this.btnNewTaks.IconVisible = true;
            this.btnNewTaks.IconZoom = 90D;
            this.btnNewTaks.IsTab = false;
            this.btnNewTaks.Location = new System.Drawing.Point(1077, 439);
            this.btnNewTaks.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNewTaks.Name = "btnNewTaks";
            this.btnNewTaks.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnNewTaks.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnNewTaks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewTaks.selected = false;
            this.btnNewTaks.Size = new System.Drawing.Size(199, 47);
            this.btnNewTaks.TabIndex = 22;
            this.btnNewTaks.Text = "Nova tarefa";
            this.btnNewTaks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewTaks.Textcolor = System.Drawing.Color.White;
            this.btnNewTaks.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTaks.Click += new System.EventHandler(this.btnNewTaks_Click);
            // 
            // btnMarkTaskAsCompleted
            // 
            this.btnMarkTaskAsCompleted.Active = false;
            this.btnMarkTaskAsCompleted.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnMarkTaskAsCompleted.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMarkTaskAsCompleted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarkTaskAsCompleted.BorderRadius = 0;
            this.btnMarkTaskAsCompleted.ButtonText = "Finalizar tarefa";
            this.btnMarkTaskAsCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkTaskAsCompleted.DisabledColor = System.Drawing.Color.Gray;
            this.btnMarkTaskAsCompleted.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMarkTaskAsCompleted.Iconimage = null;
            this.btnMarkTaskAsCompleted.Iconimage_right = null;
            this.btnMarkTaskAsCompleted.Iconimage_right_Selected = null;
            this.btnMarkTaskAsCompleted.Iconimage_Selected = null;
            this.btnMarkTaskAsCompleted.IconMarginLeft = 0;
            this.btnMarkTaskAsCompleted.IconMarginRight = 0;
            this.btnMarkTaskAsCompleted.IconRightVisible = true;
            this.btnMarkTaskAsCompleted.IconRightZoom = 0D;
            this.btnMarkTaskAsCompleted.IconVisible = true;
            this.btnMarkTaskAsCompleted.IconZoom = 90D;
            this.btnMarkTaskAsCompleted.IsTab = false;
            this.btnMarkTaskAsCompleted.Location = new System.Drawing.Point(1077, 496);
            this.btnMarkTaskAsCompleted.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMarkTaskAsCompleted.Name = "btnMarkTaskAsCompleted";
            this.btnMarkTaskAsCompleted.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnMarkTaskAsCompleted.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnMarkTaskAsCompleted.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMarkTaskAsCompleted.selected = false;
            this.btnMarkTaskAsCompleted.Size = new System.Drawing.Size(199, 47);
            this.btnMarkTaskAsCompleted.TabIndex = 23;
            this.btnMarkTaskAsCompleted.Text = "Finalizar tarefa";
            this.btnMarkTaskAsCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMarkTaskAsCompleted.Textcolor = System.Drawing.Color.White;
            this.btnMarkTaskAsCompleted.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkTaskAsCompleted.Click += new System.EventHandler(this.btnMarkTaskAsCompleted_Click);
            // 
            // btnExit
            // 
            this.btnExit.Active = false;
            this.btnExit.Activecolor = System.Drawing.Color.Gray;
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "Cancelar";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = null;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(1077, 578);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Silver;
            this.btnExit.OnHovercolor = System.Drawing.Color.Silver;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(199, 47);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Cancelar";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // TasksDataGridView
            // 
            this.TasksDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TasksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TasksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TasksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TasksDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TasksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TasksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TasksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TasksDataGridView.ColumnHeadersHeight = 45;
            this.TasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.deadline,
            this.completed,
            this.created_at,
            this.updated_at,
            this.project_id});
            this.TasksDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TasksDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TasksDataGridView.DoubleBuffered = true;
            this.TasksDataGridView.EnableHeadersVisualStyles = false;
            this.TasksDataGridView.GridColor = System.Drawing.Color.White;
            this.TasksDataGridView.HeaderBgColor = System.Drawing.Color.White;
            this.TasksDataGridView.HeaderForeColor = System.Drawing.Color.DodgerBlue;
            this.TasksDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TasksDataGridView.Location = new System.Drawing.Point(37, 411);
            this.TasksDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TasksDataGridView.Name = "TasksDataGridView";
            this.TasksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TasksDataGridView.RowHeadersVisible = false;
            this.TasksDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.TasksDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TasksDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.TasksDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TasksDataGridView.RowTemplate.Height = 30;
            this.TasksDataGridView.RowTemplate.ReadOnly = true;
            this.TasksDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TasksDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TasksDataGridView.Size = new System.Drawing.Size(779, 231);
            this.TasksDataGridView.TabIndex = 27;
            this.TasksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksDataGridView_CellClick);
            this.TasksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksDataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.HeaderText = "Titutlo";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            // 
            // deadline
            // 
            this.deadline.HeaderText = "Data de entrega";
            this.deadline.MinimumWidth = 6;
            this.deadline.Name = "deadline";
            // 
            // completed
            // 
            this.completed.HeaderText = "Finalizado";
            this.completed.MinimumWidth = 6;
            this.completed.Name = "completed";
            this.completed.Visible = false;
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Data de Inicio";
            this.created_at.MinimumWidth = 6;
            this.created_at.Name = "created_at";
            // 
            // updated_at
            // 
            this.updated_at.HeaderText = "Ultima Alteração";
            this.updated_at.MinimumWidth = 6;
            this.updated_at.Name = "updated_at";
            // 
            // project_id
            // 
            this.project_id.HeaderText = "Id do Projeto";
            this.project_id.MinimumWidth = 6;
            this.project_id.Name = "project_id";
            this.project_id.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Excluir Projeto";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::TodoListProject.Properties.Resources.delete;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1077, 238);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(199, 47);
            this.bunifuFlatButton1.TabIndex = 26;
            this.bunifuFlatButton1.Text = "Excluir Projeto";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Active = false;
            this.btnSaveProject.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnSaveProject.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveProject.BorderRadius = 0;
            this.btnSaveProject.ButtonText = "Salvar Edições";
            this.btnSaveProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProject.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveProject.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveProject.Iconimage = global::TodoListProject.Properties.Resources.save;
            this.btnSaveProject.Iconimage_right = null;
            this.btnSaveProject.Iconimage_right_Selected = null;
            this.btnSaveProject.Iconimage_Selected = null;
            this.btnSaveProject.IconMarginLeft = 0;
            this.btnSaveProject.IconMarginRight = 0;
            this.btnSaveProject.IconRightVisible = true;
            this.btnSaveProject.IconRightZoom = 0D;
            this.btnSaveProject.IconVisible = true;
            this.btnSaveProject.IconZoom = 50D;
            this.btnSaveProject.IsTab = false;
            this.btnSaveProject.Location = new System.Drawing.Point(1077, 103);
            this.btnSaveProject.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnSaveProject.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnSaveProject.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveProject.selected = false;
            this.btnSaveProject.Size = new System.Drawing.Size(199, 47);
            this.btnSaveProject.TabIndex = 25;
            this.btnSaveProject.Text = "Salvar Edições";
            this.btnSaveProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveProject.Textcolor = System.Drawing.Color.White;
            this.btnSaveProject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // btnMarksProjectAsCompleted
            // 
            this.btnMarksProjectAsCompleted.Active = false;
            this.btnMarksProjectAsCompleted.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnMarksProjectAsCompleted.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMarksProjectAsCompleted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarksProjectAsCompleted.BorderRadius = 0;
            this.btnMarksProjectAsCompleted.ButtonText = "Finalizar Projeto";
            this.btnMarksProjectAsCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarksProjectAsCompleted.DisabledColor = System.Drawing.Color.Gray;
            this.btnMarksProjectAsCompleted.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMarksProjectAsCompleted.Iconimage = global::TodoListProject.Properties.Resources.done;
            this.btnMarksProjectAsCompleted.Iconimage_right = null;
            this.btnMarksProjectAsCompleted.Iconimage_right_Selected = null;
            this.btnMarksProjectAsCompleted.Iconimage_Selected = null;
            this.btnMarksProjectAsCompleted.IconMarginLeft = 0;
            this.btnMarksProjectAsCompleted.IconMarginRight = 0;
            this.btnMarksProjectAsCompleted.IconRightVisible = true;
            this.btnMarksProjectAsCompleted.IconRightZoom = 0D;
            this.btnMarksProjectAsCompleted.IconVisible = true;
            this.btnMarksProjectAsCompleted.IconZoom = 60D;
            this.btnMarksProjectAsCompleted.IsTab = false;
            this.btnMarksProjectAsCompleted.Location = new System.Drawing.Point(1077, 171);
            this.btnMarksProjectAsCompleted.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMarksProjectAsCompleted.Name = "btnMarksProjectAsCompleted";
            this.btnMarksProjectAsCompleted.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnMarksProjectAsCompleted.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnMarksProjectAsCompleted.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMarksProjectAsCompleted.selected = false;
            this.btnMarksProjectAsCompleted.Size = new System.Drawing.Size(199, 47);
            this.btnMarksProjectAsCompleted.TabIndex = 21;
            this.btnMarksProjectAsCompleted.Text = "Finalizar Projeto";
            this.btnMarksProjectAsCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMarksProjectAsCompleted.Textcolor = System.Drawing.Color.White;
            this.btnMarksProjectAsCompleted.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarksProjectAsCompleted.Click += new System.EventHandler(this.btnMarksProjectAsCompleted_Click);
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Active = false;
            this.btnUpdateProject.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateProject.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProject.BorderRadius = 0;
            this.btnUpdateProject.ButtonText = "Editar Projeto";
            this.btnUpdateProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProject.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateProject.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateProject.Iconimage = global::TodoListProject.Properties.Resources.edit;
            this.btnUpdateProject.Iconimage_right = null;
            this.btnUpdateProject.Iconimage_right_Selected = null;
            this.btnUpdateProject.Iconimage_Selected = null;
            this.btnUpdateProject.IconMarginLeft = 0;
            this.btnUpdateProject.IconMarginRight = 0;
            this.btnUpdateProject.IconRightVisible = true;
            this.btnUpdateProject.IconRightZoom = 0D;
            this.btnUpdateProject.IconVisible = true;
            this.btnUpdateProject.IconZoom = 60D;
            this.btnUpdateProject.IsTab = false;
            this.btnUpdateProject.Location = new System.Drawing.Point(1077, 36);
            this.btnUpdateProject.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateProject.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateProject.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateProject.selected = false;
            this.btnUpdateProject.Size = new System.Drawing.Size(199, 47);
            this.btnUpdateProject.TabIndex = 17;
            this.btnUpdateProject.Text = "Editar Projeto";
            this.btnUpdateProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateProject.Textcolor = System.Drawing.Color.White;
            this.btnUpdateProject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // txtAbout
            // 
            this.txtAbout.AcceptsReturn = false;
            this.txtAbout.AcceptsTab = false;
            this.txtAbout.AnimationSpeed = 200;
            this.txtAbout.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAbout.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAbout.BackColor = System.Drawing.Color.Transparent;
            this.txtAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAbout.BackgroundImage")));
            this.txtAbout.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAbout.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAbout.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAbout.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAbout.BorderRadius = 1;
            this.txtAbout.BorderThickness = 1;
            this.txtAbout.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAbout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbout.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtAbout.DefaultText = "";
            this.txtAbout.Enabled = false;
            this.txtAbout.FillColor = System.Drawing.Color.White;
            this.txtAbout.HideSelection = true;
            this.txtAbout.IconLeft = null;
            this.txtAbout.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbout.IconPadding = 10;
            this.txtAbout.IconRight = null;
            this.txtAbout.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbout.Lines = new string[0];
            this.txtAbout.Location = new System.Drawing.Point(37, 295);
            this.txtAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAbout.MaxLength = 32767;
            this.txtAbout.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAbout.Modified = false;
            this.txtAbout.Multiline = false;
            this.txtAbout.Name = "txtAbout";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAbout.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAbout.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAbout.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAbout.OnIdleState = stateProperties4;
            this.txtAbout.PasswordChar = '\0';
            this.txtAbout.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAbout.PlaceholderText = "Enter text";
            this.txtAbout.ReadOnly = false;
            this.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAbout.SelectedText = "";
            this.txtAbout.SelectionLength = 0;
            this.txtAbout.SelectionStart = 0;
            this.txtAbout.ShortcutsEnabled = true;
            this.txtAbout.Size = new System.Drawing.Size(593, 43);
            this.txtAbout.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAbout.TabIndex = 14;
            this.txtAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAbout.TextMarginBottom = 0;
            this.txtAbout.TextMarginLeft = 3;
            this.txtAbout.TextMarginTop = 0;
            this.txtAbout.TextPlaceholder = "Enter text";
            this.txtAbout.UseSystemPasswordChar = false;
            this.txtAbout.WordWrap = true;
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = false;
            this.txtTitle.AcceptsTab = false;
            this.txtTitle.AnimationSpeed = 200;
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTitle.BackgroundImage")));
            this.txtTitle.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTitle.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTitle.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTitle.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTitle.BorderRadius = 1;
            this.txtTitle.BorderThickness = 1;
            this.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTitle.DefaultText = "";
            this.txtTitle.Enabled = false;
            this.txtTitle.FillColor = System.Drawing.Color.White;
            this.txtTitle.HideSelection = true;
            this.txtTitle.IconLeft = null;
            this.txtTitle.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.IconPadding = 10;
            this.txtTitle.IconRight = null;
            this.txtTitle.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(37, 76);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTitle.Modified = false;
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTitle.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnIdleState = stateProperties8;
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTitle.PlaceholderText = "Enter text";
            this.txtTitle.ReadOnly = false;
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(405, 43);
            this.txtTitle.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTitle.TabIndex = 10;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.TextMarginBottom = 0;
            this.txtTitle.TextMarginLeft = 3;
            this.txtTitle.TextMarginTop = 0;
            this.txtTitle.TextPlaceholder = "Enter text";
            this.txtTitle.UseSystemPasswordChar = false;
            this.txtTitle.WordWrap = true;
            // 
            // ShowProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 657);
            this.Controls.Add(this.TasksDataGridView);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMarkTaskAsCompleted);
            this.Controls.Add(this.btnNewTaks);
            this.Controls.Add(this.btnMarksProjectAsCompleted);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.lblTaks);
            this.Controls.Add(this.btnUpdateProject);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.deadlineDataPicker);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.ShowProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblAbout;
        private Bunifu.UI.WinForms.BunifuTextBox txtAbout;
        private Bunifu.Framework.UI.BunifuDatepicker deadlineDataPicker;
        private Bunifu.UI.WinForms.BunifuTextBox txtTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeadline;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateProject;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTaks;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateTask;
        private Bunifu.Framework.UI.BunifuFlatButton btnMarksProjectAsCompleted;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewTaks;
        private Bunifu.Framework.UI.BunifuFlatButton btnMarkTaskAsCompleted;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveProject;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid TasksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_id;
    }
}