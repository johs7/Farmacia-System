namespace WindowsFormsApp1.Formularios
{
    partial class FormFabricante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFabricante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblMedicamentos = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.llbIdBus = new System.Windows.Forms.Label();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpIng = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtDirec = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvFabricantes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrecioMed = new System.Windows.Forms.Label();
            this.txtNomFab = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFabricantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTitleBar.Controls.Add(this.guna2CirclePictureBox1);
            this.panelTitleBar.Controls.Add(this.lblMedicamentos);
            this.panelTitleBar.Controls.Add(this.BtnClose);
            this.panelTitleBar.Controls.Add(this.llbIdBus);
            this.panelTitleBar.Controls.Add(this.txtBuscar);
            this.panelTitleBar.Controls.Add(this.BtnBuscar);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(725, 45);
            this.panelTitleBar.TabIndex = 22;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_vara_de_esculapio_48;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(48, -3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(48, 45);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 20;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblMedicamentos
            // 
            this.lblMedicamentos.AutoSize = true;
            this.lblMedicamentos.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamentos.ForeColor = System.Drawing.Color.White;
            this.lblMedicamentos.Location = new System.Drawing.Point(112, 10);
            this.lblMedicamentos.Name = "lblMedicamentos";
            this.lblMedicamentos.Size = new System.Drawing.Size(104, 20);
            this.lblMedicamentos.TabIndex = 19;
            this.lblMedicamentos.Text = "Fabricantes";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cerrar_ventana_48;
            this.BtnClose.Location = new System.Drawing.Point(679, -3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(48, 45);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // llbIdBus
            // 
            this.llbIdBus.AutoSize = true;
            this.llbIdBus.BackColor = System.Drawing.Color.Transparent;
            this.llbIdBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbIdBus.ForeColor = System.Drawing.Color.DarkGray;
            this.llbIdBus.Location = new System.Drawing.Point(236, 10);
            this.llbIdBus.Name = "llbIdBus";
            this.llbIdBus.Size = new System.Drawing.Size(33, 20);
            this.llbIdBus.TabIndex = 52;
            this.llbIdBus.Text = "ID:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BorderColor = System.Drawing.Color.LightPink;
            this.txtBuscar.BorderRadius = 8;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.Parent = this.txtBuscar;
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.FocusedState.Parent = this.txtBuscar;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.HoverState.Parent = this.txtBuscar;
            this.txtBuscar.Location = new System.Drawing.Point(275, 7);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.ShadowDecoration.Parent = this.txtBuscar;
            this.txtBuscar.Size = new System.Drawing.Size(80, 25);
            this.txtBuscar.TabIndex = 53;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BorderRadius = 10;
            this.BtnBuscar.CheckedState.Parent = this.BtnBuscar;
            this.BtnBuscar.CustomImages.Parent = this.BtnBuscar;
            this.BtnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Lavender;
            this.BtnBuscar.HoverState.Parent = this.BtnBuscar;
            this.BtnBuscar.Location = new System.Drawing.Point(360, 6);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.ShadowDecoration.Parent = this.BtnBuscar;
            this.BtnBuscar.Size = new System.Drawing.Size(95, 24);
            this.BtnBuscar.TabIndex = 47;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.guna2Separator1);
            this.panelContainer.Controls.Add(this.txtTel);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Controls.Add(this.dtpIng);
            this.panelContainer.Controls.Add(this.txtDirec);
            this.panelContainer.Controls.Add(this.label9);
            this.panelContainer.Controls.Add(this.DgvFabricantes);
            this.panelContainer.Controls.Add(this.label12);
            this.panelContainer.Controls.Add(this.BtnEliminar);
            this.panelContainer.Controls.Add(this.BtnEditar);
            this.panelContainer.Controls.Add(this.BtnRegistrar);
            this.panelContainer.Controls.Add(this.txtDni);
            this.panelContainer.Controls.Add(this.lblPrecioMed);
            this.panelContainer.Controls.Add(this.txtNomFab);
            this.panelContainer.Controls.Add(this.lblCantidad);
            this.panelContainer.Location = new System.Drawing.Point(0, 40);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(724, 420);
            this.panelContainer.TabIndex = 43;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(16, 112);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(695, 10);
            this.guna2Separator1.TabIndex = 60;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Transparent;
            this.txtTel.BorderColor = System.Drawing.Color.LightPink;
            this.txtTel.BorderRadius = 8;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.DefaultText = "";
            this.txtTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTel.DisabledState.Parent = this.txtTel;
            this.txtTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTel.FocusedState.Parent = this.txtTel;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTel.HoverState.Parent = this.txtTel;
            this.txtTel.Location = new System.Drawing.Point(407, 44);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTel.MaxLength = 9;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.PlaceholderText = "";
            this.txtTel.SelectedText = "";
            this.txtTel.ShadowDecoration.Parent = this.txtTel;
            this.txtTel.Size = new System.Drawing.Size(108, 29);
            this.txtTel.TabIndex = 59;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(325, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(290, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fecha de ingreso:";
            // 
            // dtpIng
            // 
            this.dtpIng.BackColor = System.Drawing.Color.Transparent;
            this.dtpIng.BorderRadius = 6;
            this.dtpIng.Color = System.Drawing.Color.Silver;
            this.dtpIng.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpIng.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Right;
            this.dtpIng.DisabledColor = System.Drawing.Color.Gray;
            this.dtpIng.DisplayWeekNumbers = false;
            this.dtpIng.DPHeight = 0;
            this.dtpIng.FillDatePicker = false;
            this.dtpIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIng.ForeColor = System.Drawing.Color.Black;
            this.dtpIng.Icon = ((System.Drawing.Image)(resources.GetObject("dtpIng.Icon")));
            this.dtpIng.IconColor = System.Drawing.Color.SteelBlue;
            this.dtpIng.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Left;
            this.dtpIng.LeftTextMargin = 5;
            this.dtpIng.Location = new System.Drawing.Point(444, 79);
            this.dtpIng.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpIng.Name = "dtpIng";
            this.dtpIng.Size = new System.Drawing.Size(220, 32);
            this.dtpIng.TabIndex = 56;
            this.dtpIng.Value = new System.DateTime(2023, 1, 31, 0, 0, 0, 0);
            // 
            // txtDirec
            // 
            this.txtDirec.BackColor = System.Drawing.Color.Transparent;
            this.txtDirec.BorderColor = System.Drawing.Color.LightPink;
            this.txtDirec.BorderRadius = 8;
            this.txtDirec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirec.DefaultText = "";
            this.txtDirec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDirec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDirec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirec.DisabledState.Parent = this.txtDirec;
            this.txtDirec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirec.FocusedState.Parent = this.txtDirec;
            this.txtDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirec.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDirec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirec.HoverState.Parent = this.txtDirec;
            this.txtDirec.Location = new System.Drawing.Point(101, 42);
            this.txtDirec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDirec.Multiline = true;
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.PasswordChar = '\0';
            this.txtDirec.PlaceholderText = "";
            this.txtDirec.SelectedText = "";
            this.txtDirec.ShadowDecoration.Parent = this.txtDirec;
            this.txtDirec.Size = new System.Drawing.Size(188, 64);
            this.txtDirec.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(12, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Direccion:";
            // 
            // DgvFabricantes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DgvFabricantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFabricantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFabricantes.BackgroundColor = System.Drawing.Color.White;
            this.DgvFabricantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvFabricantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvFabricantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFabricantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvFabricantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvFabricantes.EnableHeadersVisualStyles = false;
            this.DgvFabricantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DgvFabricantes.Location = new System.Drawing.Point(2, 204);
            this.DgvFabricantes.Name = "DgvFabricantes";
            this.DgvFabricantes.ReadOnly = true;
            this.DgvFabricantes.RowHeadersVisible = false;
            this.DgvFabricantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvFabricantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFabricantes.Size = new System.Drawing.Size(725, 203);
            this.DgvFabricantes.TabIndex = 50;
            this.DgvFabricantes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DgvFabricantes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DgvFabricantes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvFabricantes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvFabricantes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvFabricantes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvFabricantes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvFabricantes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DgvFabricantes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DgvFabricantes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvFabricantes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvFabricantes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvFabricantes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvFabricantes.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvFabricantes.ThemeStyle.ReadOnly = true;
            this.DgvFabricantes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DgvFabricantes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvFabricantes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvFabricantes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvFabricantes.ThemeStyle.RowsStyle.Height = 22;
            this.DgvFabricantes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DgvFabricantes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvFabricantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFabricantes_CellClick);
            this.DgvFabricantes.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFabricantes_CellLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(322, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Lista de fabricantes";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BorderRadius = 10;
            this.BtnEliminar.CheckedState.Parent = this.BtnEliminar;
            this.BtnEliminar.CustomImages.Parent = this.BtnEliminar;
            this.BtnEliminar.FillColor = System.Drawing.Color.Red;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Lavender;
            this.BtnEliminar.HoverState.Parent = this.BtnEliminar;
            this.BtnEliminar.Location = new System.Drawing.Point(480, 156);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ShadowDecoration.Parent = this.BtnEliminar;
            this.BtnEliminar.Size = new System.Drawing.Size(95, 24);
            this.BtnEliminar.TabIndex = 49;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BorderRadius = 10;
            this.BtnEditar.CheckedState.Parent = this.BtnEditar;
            this.BtnEditar.CustomImages.Parent = this.BtnEditar;
            this.BtnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Lavender;
            this.BtnEditar.HoverState.Parent = this.BtnEditar;
            this.BtnEditar.Location = new System.Drawing.Point(379, 156);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.ShadowDecoration.Parent = this.BtnEditar;
            this.BtnEditar.Size = new System.Drawing.Size(95, 24);
            this.BtnEditar.TabIndex = 48;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BorderRadius = 10;
            this.BtnRegistrar.CheckedState.Parent = this.BtnRegistrar;
            this.BtnRegistrar.CustomImages.Parent = this.BtnRegistrar;
            this.BtnRegistrar.FillColor = System.Drawing.Color.Green;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.Lavender;
            this.BtnRegistrar.HoverState.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Location = new System.Drawing.Point(279, 156);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.ShadowDecoration.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Size = new System.Drawing.Size(95, 24);
            this.BtnRegistrar.TabIndex = 46;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.Transparent;
            this.txtDni.BorderColor = System.Drawing.Color.LightPink;
            this.txtDni.BorderRadius = 8;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.DefaultText = "";
            this.txtDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDni.DisabledState.Parent = this.txtDni;
            this.txtDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDni.FocusedState.Parent = this.txtDni;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDni.HoverState.Parent = this.txtDni;
            this.txtDni.Location = new System.Drawing.Point(387, 7);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PlaceholderText = "";
            this.txtDni.SelectedText = "";
            this.txtDni.ShadowDecoration.Parent = this.txtDni;
            this.txtDni.Size = new System.Drawing.Size(169, 29);
            this.txtDni.TabIndex = 45;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.Validating += new System.ComponentModel.CancelEventHandler(this.txtDni_Validating);
            // 
            // lblPrecioMed
            // 
            this.lblPrecioMed.AutoSize = true;
            this.lblPrecioMed.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMed.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioMed.Location = new System.Drawing.Point(315, 12);
            this.lblPrecioMed.Name = "lblPrecioMed";
            this.lblPrecioMed.Size = new System.Drawing.Size(70, 20);
            this.lblPrecioMed.TabIndex = 44;
            this.lblPrecioMed.Text = "Cedula:";
            // 
            // txtNomFab
            // 
            this.txtNomFab.BackColor = System.Drawing.Color.Transparent;
            this.txtNomFab.BorderColor = System.Drawing.Color.LightPink;
            this.txtNomFab.BorderRadius = 8;
            this.txtNomFab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomFab.DefaultText = "";
            this.txtNomFab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomFab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomFab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomFab.DisabledState.Parent = this.txtNomFab;
            this.txtNomFab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomFab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomFab.FocusedState.Parent = this.txtNomFab;
            this.txtNomFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomFab.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomFab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomFab.HoverState.Parent = this.txtNomFab;
            this.txtNomFab.Location = new System.Drawing.Point(210, 8);
            this.txtNomFab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomFab.Name = "txtNomFab";
            this.txtNomFab.PasswordChar = '\0';
            this.txtNomFab.PlaceholderText = "";
            this.txtNomFab.SelectedText = "";
            this.txtNomFab.ShadowDecoration.Parent = this.txtNomFab;
            this.txtNomFab.Size = new System.Drawing.Size(99, 29);
            this.txtNomFab.TabIndex = 43;
            this.txtNomFab.TextChanged += new System.EventHandler(this.txtNomFab_TextChanged);
            this.txtNomFab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomFab_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCantidad.Location = new System.Drawing.Point(12, 14);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(196, 20);
            this.lblCantidad.TabIndex = 24;
            this.lblCantidad.Text = "Nombre del Fabricante:";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // FormFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFabricante";
            this.Text = "FormFabricante";
            this.Load += new System.EventHandler(this.FormFabricante_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFabricantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblMedicamentos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox BtnClose;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label llbIdBus;
        private Guna.UI2.WinForms.Guna2DataGridView DgvFabricantes;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button BtnEliminar;
        private Guna.UI2.WinForms.Guna2Button BtnEditar;
        private Guna.UI2.WinForms.Guna2Button BtnBuscar;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox txtDni;
        private System.Windows.Forms.Label lblPrecioMed;
        private Guna.UI2.WinForms.Guna2TextBox txtNomFab;
        private System.Windows.Forms.Label lblCantidad;
        private Guna.UI2.WinForms.Guna2TextBox txtDirec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpIng;
        private Guna.UI2.WinForms.Guna2TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.ErrorProvider Error;
    }
}