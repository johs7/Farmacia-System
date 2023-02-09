namespace WindowsFormsApp1.Formularios
{
    partial class FormMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicamentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMedicamentos = new System.Windows.Forms.Label();
            this.llbIdBus = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.BtnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.lblNomMed = new System.Windows.Forms.Label();
            this.txtNombreMed = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTipoMed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTipMed = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpVen = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtfabricante = new Guna.UI2.WinForms.Guna2TextBox();
            this.DgvMedicamentos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtNomFabricante = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNomFab = new System.Windows.Forms.Label();
            this.lblFabId = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrecioMed = new System.Windows.Forms.Label();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTitleBar.Controls.Add(this.guna2CirclePictureBox1);
            this.panelTitleBar.Controls.Add(this.txtBuscar);
            this.panelTitleBar.Controls.Add(this.lblMedicamentos);
            this.panelTitleBar.Controls.Add(this.llbIdBus);
            this.panelTitleBar.Controls.Add(this.BtnClose);
            this.panelTitleBar.Controls.Add(this.BtnBuscar);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(724, 45);
            this.panelTitleBar.TabIndex = 21;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_vara_de_esculapio_48;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(141, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(48, 45);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 20;
            this.guna2CirclePictureBox1.TabStop = false;
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
            this.txtBuscar.Location = new System.Drawing.Point(410, 9);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.ShadowDecoration.Parent = this.txtBuscar;
            this.txtBuscar.Size = new System.Drawing.Size(84, 25);
            this.txtBuscar.TabIndex = 53;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblMedicamentos
            // 
            this.lblMedicamentos.AutoSize = true;
            this.lblMedicamentos.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamentos.ForeColor = System.Drawing.Color.White;
            this.lblMedicamentos.Location = new System.Drawing.Point(200, 12);
            this.lblMedicamentos.Name = "lblMedicamentos";
            this.lblMedicamentos.Size = new System.Drawing.Size(125, 20);
            this.lblMedicamentos.TabIndex = 19;
            this.lblMedicamentos.Text = "Medicamentos\r\n";
            // 
            // llbIdBus
            // 
            this.llbIdBus.AutoSize = true;
            this.llbIdBus.BackColor = System.Drawing.Color.Transparent;
            this.llbIdBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbIdBus.ForeColor = System.Drawing.Color.DarkGray;
            this.llbIdBus.Location = new System.Drawing.Point(371, 12);
            this.llbIdBus.Name = "llbIdBus";
            this.llbIdBus.Size = new System.Drawing.Size(33, 20);
            this.llbIdBus.TabIndex = 52;
            this.llbIdBus.Text = "ID:";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cerrar_ventana_48;
            this.BtnClose.Location = new System.Drawing.Point(679, -4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(48, 45);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.BtnBuscar.Location = new System.Drawing.Point(503, 9);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.ShadowDecoration.Parent = this.BtnBuscar;
            this.BtnBuscar.Size = new System.Drawing.Size(95, 24);
            this.BtnBuscar.TabIndex = 47;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblNomMed
            // 
            this.lblNomMed.AutoSize = true;
            this.lblNomMed.BackColor = System.Drawing.Color.Transparent;
            this.lblNomMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMed.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNomMed.Location = new System.Drawing.Point(12, 69);
            this.lblNomMed.Name = "lblNomMed";
            this.lblNomMed.Size = new System.Drawing.Size(217, 20);
            this.lblNomMed.TabIndex = 23;
            this.lblNomMed.Text = "Nombre del medicamento:";
            // 
            // txtNombreMed
            // 
            this.txtNombreMed.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreMed.BorderColor = System.Drawing.Color.LightPink;
            this.txtNombreMed.BorderRadius = 8;
            this.txtNombreMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMed.DefaultText = "";
            this.txtNombreMed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMed.DisabledState.Parent = this.txtNombreMed;
            this.txtNombreMed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMed.FocusedState.Parent = this.txtNombreMed;
            this.txtNombreMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreMed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMed.HoverState.Parent = this.txtNombreMed;
            this.txtNombreMed.Location = new System.Drawing.Point(236, 64);
            this.txtNombreMed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.PasswordChar = '\0';
            this.txtNombreMed.PlaceholderText = "";
            this.txtNombreMed.SelectedText = "";
            this.txtNombreMed.ShadowDecoration.Parent = this.txtNombreMed;
            this.txtNombreMed.Size = new System.Drawing.Size(99, 29);
            this.txtNombreMed.TabIndex = 22;
            this.txtNombreMed.TextChanged += new System.EventHandler(this.txtNombreMed_TextChanged);
            this.txtNombreMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMed_KeyPress);
            // 
            // cmbTipoMed
            // 
            this.cmbTipoMed.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoMed.BorderRadius = 6;
            this.cmbTipoMed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMed.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoMed.FocusedState.Parent = this.cmbTipoMed;
            this.cmbTipoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoMed.FormattingEnabled = true;
            this.cmbTipoMed.HoverState.Parent = this.cmbTipoMed;
            this.cmbTipoMed.ItemHeight = 30;
            this.cmbTipoMed.Items.AddRange(new object[] {
            "Tabletas",
            "Capsulas",
            "Gotas",
            "Inyecciones",
            "Inhaladores",
            "Otros"});
            this.cmbTipoMed.ItemsAppearance.Parent = this.cmbTipoMed;
            this.cmbTipoMed.Location = new System.Drawing.Point(532, 58);
            this.cmbTipoMed.Name = "cmbTipoMed";
            this.cmbTipoMed.ShadowDecoration.Parent = this.cmbTipoMed;
            this.cmbTipoMed.Size = new System.Drawing.Size(140, 36);
            this.cmbTipoMed.TabIndex = 41;
            // 
            // lblTipMed
            // 
            this.lblTipMed.AutoSize = true;
            this.lblTipMed.BackColor = System.Drawing.Color.Transparent;
            this.lblTipMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipMed.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTipMed.Location = new System.Drawing.Point(342, 69);
            this.lblTipMed.Name = "lblTipMed";
            this.lblTipMed.Size = new System.Drawing.Size(189, 20);
            this.lblTipMed.TabIndex = 40;
            this.lblTipMed.Text = "Tipo del medicamento:";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Controls.Add(this.dtpVen);
            this.panelContainer.Controls.Add(this.txtfabricante);
            this.panelContainer.Controls.Add(this.DgvMedicamentos);
            this.panelContainer.Controls.Add(this.label12);
            this.panelContainer.Controls.Add(this.BtnEliminar);
            this.panelContainer.Controls.Add(this.BtnEditar);
            this.panelContainer.Controls.Add(this.BtnRegistrar);
            this.panelContainer.Controls.Add(this.txtNomFabricante);
            this.panelContainer.Controls.Add(this.lblNomFab);
            this.panelContainer.Controls.Add(this.lblFabId);
            this.panelContainer.Controls.Add(this.txtPrecio);
            this.panelContainer.Controls.Add(this.lblPrecioMed);
            this.panelContainer.Controls.Add(this.txtCantidad);
            this.panelContainer.Controls.Add(this.lblCantidad);
            this.panelContainer.Location = new System.Drawing.Point(0, 44);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(724, 409);
            this.panelContainer.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(319, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Fecha de Vencimiento";
            // 
            // dtpVen
            // 
            this.dtpVen.BackColor = System.Drawing.Color.Transparent;
            this.dtpVen.BorderRadius = 6;
            this.dtpVen.Color = System.Drawing.Color.Silver;
            this.dtpVen.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpVen.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Right;
            this.dtpVen.DisabledColor = System.Drawing.Color.Gray;
            this.dtpVen.DisplayWeekNumbers = false;
            this.dtpVen.DPHeight = 0;
            this.dtpVen.FillDatePicker = false;
            this.dtpVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVen.ForeColor = System.Drawing.Color.Black;
            this.dtpVen.Icon = ((System.Drawing.Image)(resources.GetObject("dtpVen.Icon")));
            this.dtpVen.IconColor = System.Drawing.Color.SteelBlue;
            this.dtpVen.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Left;
            this.dtpVen.LeftTextMargin = 5;
            this.dtpVen.Location = new System.Drawing.Point(513, 97);
            this.dtpVen.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpVen.Name = "dtpVen";
            this.dtpVen.Size = new System.Drawing.Size(180, 32);
            this.dtpVen.TabIndex = 58;
            this.dtpVen.Value = new System.DateTime(2023, 1, 31, 0, 0, 0, 0);
            // 
            // txtfabricante
            // 
            this.txtfabricante.BackColor = System.Drawing.Color.Transparent;
            this.txtfabricante.BorderColor = System.Drawing.Color.LightPink;
            this.txtfabricante.BorderRadius = 8;
            this.txtfabricante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfabricante.DefaultText = "";
            this.txtfabricante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfabricante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfabricante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfabricante.DisabledState.Parent = this.txtfabricante;
            this.txtfabricante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfabricante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfabricante.FocusedState.Parent = this.txtfabricante;
            this.txtfabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfabricante.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtfabricante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfabricante.HoverState.Parent = this.txtfabricante;
            this.txtfabricante.Location = new System.Drawing.Point(511, 63);
            this.txtfabricante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfabricante.Name = "txtfabricante";
            this.txtfabricante.PasswordChar = '\0';
            this.txtfabricante.PlaceholderText = "";
            this.txtfabricante.SelectedText = "";
            this.txtfabricante.ShadowDecoration.Parent = this.txtfabricante;
            this.txtfabricante.Size = new System.Drawing.Size(99, 29);
            this.txtfabricante.TabIndex = 52;
            this.txtfabricante.TextChanged += new System.EventHandler(this.txtfabricante_TextChanged);
            // 
            // DgvMedicamentos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DgvMedicamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMedicamentos.BackgroundColor = System.Drawing.Color.White;
            this.DgvMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMedicamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvMedicamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMedicamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvMedicamentos.EnableHeadersVisualStyles = false;
            this.DgvMedicamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DgvMedicamentos.Location = new System.Drawing.Point(0, 212);
            this.DgvMedicamentos.Name = "DgvMedicamentos";
            this.DgvMedicamentos.ReadOnly = true;
            this.DgvMedicamentos.RowHeadersVisible = false;
            this.DgvMedicamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMedicamentos.Size = new System.Drawing.Size(724, 197);
            this.DgvMedicamentos.TabIndex = 50;
            this.DgvMedicamentos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DgvMedicamentos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DgvMedicamentos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvMedicamentos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvMedicamentos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvMedicamentos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvMedicamentos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvMedicamentos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DgvMedicamentos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DgvMedicamentos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvMedicamentos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvMedicamentos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvMedicamentos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvMedicamentos.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvMedicamentos.ThemeStyle.ReadOnly = true;
            this.DgvMedicamentos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DgvMedicamentos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvMedicamentos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvMedicamentos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvMedicamentos.ThemeStyle.RowsStyle.Height = 22;
            this.DgvMedicamentos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DgvMedicamentos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicamentos_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(296, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Lista de medicamentos";
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
            this.BtnEliminar.Location = new System.Drawing.Point(453, 141);
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
            this.BtnEditar.Location = new System.Drawing.Point(354, 142);
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
            this.BtnRegistrar.Location = new System.Drawing.Point(252, 142);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.ShadowDecoration.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Size = new System.Drawing.Size(95, 24);
            this.BtnRegistrar.TabIndex = 46;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // txtNomFabricante
            // 
            this.txtNomFabricante.BackColor = System.Drawing.Color.Transparent;
            this.txtNomFabricante.BorderColor = System.Drawing.Color.LightPink;
            this.txtNomFabricante.BorderRadius = 8;
            this.txtNomFabricante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomFabricante.DefaultText = "";
            this.txtNomFabricante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomFabricante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomFabricante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomFabricante.DisabledState.Parent = this.txtNomFabricante;
            this.txtNomFabricante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomFabricante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomFabricante.FocusedState.Parent = this.txtNomFabricante;
            this.txtNomFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomFabricante.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomFabricante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomFabricante.HoverState.Parent = this.txtNomFabricante;
            this.txtNomFabricante.Location = new System.Drawing.Point(213, 99);
            this.txtNomFabricante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomFabricante.Name = "txtNomFabricante";
            this.txtNomFabricante.PasswordChar = '\0';
            this.txtNomFabricante.PlaceholderText = "";
            this.txtNomFabricante.SelectedText = "";
            this.txtNomFabricante.ShadowDecoration.Parent = this.txtNomFabricante;
            this.txtNomFabricante.Size = new System.Drawing.Size(99, 29);
            this.txtNomFabricante.TabIndex = 43;
            this.txtNomFabricante.TextChanged += new System.EventHandler(this.txtNomFabricante_TextChanged);
            this.txtNomFabricante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomFabricante_KeyPress);
            // 
            // lblNomFab
            // 
            this.lblNomFab.AutoSize = true;
            this.lblNomFab.BackColor = System.Drawing.Color.Transparent;
            this.lblNomFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomFab.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNomFab.Location = new System.Drawing.Point(22, 104);
            this.lblNomFab.Name = "lblNomFab";
            this.lblNomFab.Size = new System.Drawing.Size(191, 20);
            this.lblNomFab.TabIndex = 43;
            this.lblNomFab.Text = "Nombre del fabricante:";
            // 
            // lblFabId
            // 
            this.lblFabId.AutoSize = true;
            this.lblFabId.BackColor = System.Drawing.Color.Transparent;
            this.lblFabId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabId.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFabId.Location = new System.Drawing.Point(404, 67);
            this.lblFabId.Name = "lblFabId";
            this.lblFabId.Size = new System.Drawing.Size(100, 20);
            this.lblFabId.TabIndex = 43;
            this.lblFabId.Text = "Fabricante:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.BorderColor = System.Drawing.Color.LightPink;
            this.txtPrecio.BorderRadius = 8;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.Parent = this.txtPrecio;
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.FocusedState.Parent = this.txtPrecio;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.HoverState.Parent = this.txtPrecio;
            this.txtPrecio.Location = new System.Drawing.Point(298, 63);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(99, 29);
            this.txtPrecio.TabIndex = 45;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecioMed
            // 
            this.lblPrecioMed.AutoSize = true;
            this.lblPrecioMed.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMed.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioMed.Location = new System.Drawing.Point(232, 67);
            this.lblPrecioMed.Name = "lblPrecioMed";
            this.lblPrecioMed.Size = new System.Drawing.Size(64, 20);
            this.lblPrecioMed.TabIndex = 44;
            this.lblPrecioMed.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidad.BorderColor = System.Drawing.Color.LightPink;
            this.txtCantidad.BorderRadius = 8;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.Parent = this.txtCantidad;
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.FocusedState.Parent = this.txtCantidad;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.HoverState.Parent = this.txtCantidad;
            this.txtCantidad.Location = new System.Drawing.Point(126, 62);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.ShadowDecoration.Parent = this.txtCantidad;
            this.txtCantidad.Size = new System.Drawing.Size(99, 29);
            this.txtCantidad.TabIndex = 43;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCantidad.Location = new System.Drawing.Point(39, 68);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(86, 20);
            this.lblCantidad.TabIndex = 24;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // FormMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.cmbTipoMed);
            this.Controls.Add(this.lblTipMed);
            this.Controls.Add(this.lblNomMed);
            this.Controls.Add(this.txtNombreMed);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMedicamentos";
            this.Text = "FormMedicamentos";
            this.Load += new System.EventHandler(this.FormMedicamentos_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblMedicamentos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox BtnClose;
        private System.Windows.Forms.Label lblNomMed;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreMed;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoMed;
        private System.Windows.Forms.Label lblTipMed;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblFabId;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecioMed;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private Guna.UI2.WinForms.Guna2TextBox txtNomFabricante;
        private System.Windows.Forms.Label lblNomFab;
        private Guna.UI2.WinForms.Guna2Button BtnEliminar;
        private Guna.UI2.WinForms.Guna2Button BtnEditar;
        private Guna.UI2.WinForms.Guna2Button BtnBuscar;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrar;
        private Guna.UI2.WinForms.Guna2DataGridView DgvMedicamentos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider Error;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label llbIdBus;
        private Guna.UI2.WinForms.Guna2TextBox txtfabricante;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpVen;
    }
}