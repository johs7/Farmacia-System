namespace WindowsFormsApp1.Formularios
{
    partial class FormFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblNomVen = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblFact = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtApeC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomC = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNomC = new System.Windows.Forms.Label();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomMedi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvMedicamentos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.DgvCuenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.DgvTrans = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidarDni = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.CadetBlue;
            this.panelTitleBar.Controls.Add(this.lblNomVen);
            this.panelTitleBar.Controls.Add(this.guna2CirclePictureBox1);
            this.panelTitleBar.Controls.Add(this.lblFact);
            this.panelTitleBar.Controls.Add(this.BtnClose);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1207, 45);
            this.panelTitleBar.TabIndex = 21;
            // 
            // lblNomVen
            // 
            this.lblNomVen.AutoSize = true;
            this.lblNomVen.BackColor = System.Drawing.Color.Transparent;
            this.lblNomVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomVen.ForeColor = System.Drawing.Color.Ivory;
            this.lblNomVen.Location = new System.Drawing.Point(965, 12);
            this.lblNomVen.Name = "lblNomVen";
            this.lblNomVen.Size = new System.Drawing.Size(97, 20);
            this.lblNomVen.TabIndex = 71;
            this.lblNomVen.Text = "Bienvenido";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_vara_de_esculapio_48;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(284, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(48, 45);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 20;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblFact
            // 
            this.lblFact.AutoSize = true;
            this.lblFact.BackColor = System.Drawing.Color.Transparent;
            this.lblFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFact.ForeColor = System.Drawing.Color.White;
            this.lblFact.Location = new System.Drawing.Point(338, 12);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(66, 20);
            this.lblFact.TabIndex = 19;
            this.lblFact.Text = "Ventas";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cerrar_ventana_48;
            this.BtnClose.Location = new System.Drawing.Point(1158, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(48, 45);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtApeC
            // 
            this.txtApeC.BackColor = System.Drawing.Color.Transparent;
            this.txtApeC.BorderColor = System.Drawing.Color.LightPink;
            this.txtApeC.BorderRadius = 8;
            this.txtApeC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApeC.DefaultText = "";
            this.txtApeC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApeC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApeC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApeC.DisabledState.Parent = this.txtApeC;
            this.txtApeC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApeC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApeC.FocusedState.Parent = this.txtApeC;
            this.txtApeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApeC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApeC.HoverState.Parent = this.txtApeC;
            this.txtApeC.Location = new System.Drawing.Point(179, 99);
            this.txtApeC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApeC.Name = "txtApeC";
            this.txtApeC.PasswordChar = '\0';
            this.txtApeC.PlaceholderText = "";
            this.txtApeC.SelectedText = "";
            this.txtApeC.ShadowDecoration.Parent = this.txtApeC;
            this.txtApeC.Size = new System.Drawing.Size(99, 29);
            this.txtApeC.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Apellido del cliente:";
            // 
            // txtNomC
            // 
            this.txtNomC.BackColor = System.Drawing.Color.Transparent;
            this.txtNomC.BorderColor = System.Drawing.Color.LightPink;
            this.txtNomC.BorderRadius = 8;
            this.txtNomC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomC.DefaultText = "";
            this.txtNomC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomC.DisabledState.Parent = this.txtNomC;
            this.txtNomC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomC.FocusedState.Parent = this.txtNomC;
            this.txtNomC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomC.HoverState.Parent = this.txtNomC;
            this.txtNomC.Location = new System.Drawing.Point(179, 66);
            this.txtNomC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomC.Name = "txtNomC";
            this.txtNomC.PasswordChar = '\0';
            this.txtNomC.PlaceholderText = "";
            this.txtNomC.SelectedText = "";
            this.txtNomC.ShadowDecoration.Parent = this.txtNomC;
            this.txtNomC.Size = new System.Drawing.Size(99, 29);
            this.txtNomC.TabIndex = 49;
            // 
            // lblNomC
            // 
            this.lblNomC.AutoSize = true;
            this.lblNomC.BackColor = System.Drawing.Color.Transparent;
            this.lblNomC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomC.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNomC.Location = new System.Drawing.Point(12, 71);
            this.lblNomC.Name = "lblNomC";
            this.lblNomC.Size = new System.Drawing.Size(166, 20);
            this.lblNomC.TabIndex = 48;
            this.lblNomC.Text = "Nombre del Cliente:";
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
            this.txtDni.Location = new System.Drawing.Point(357, 98);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PlaceholderText = "";
            this.txtDni.SelectedText = "";
            this.txtDni.ShadowDecoration.Parent = this.txtDni;
            this.txtDni.Size = new System.Drawing.Size(99, 29);
            this.txtDni.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(285, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Cedula:";
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
            this.txtTel.Location = new System.Drawing.Point(370, 66);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.PlaceholderText = "";
            this.txtTel.SelectedText = "";
            this.txtTel.ShadowDecoration.Parent = this.txtTel;
            this.txtTel.Size = new System.Drawing.Size(99, 29);
            this.txtTel.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(285, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Telefono:";
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
            this.txtPrecio.Location = new System.Drawing.Point(540, 97);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(99, 29);
            this.txtPrecio.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(476, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Precio:";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.Transparent;
            this.txtC.BorderColor = System.Drawing.Color.LightPink;
            this.txtC.BorderRadius = 8;
            this.txtC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtC.DefaultText = "";
            this.txtC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtC.DisabledState.Parent = this.txtC;
            this.txtC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtC.FocusedState.Parent = this.txtC;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtC.HoverState.Parent = this.txtC;
            this.txtC.Location = new System.Drawing.Point(561, 65);
            this.txtC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtC.Name = "txtC";
            this.txtC.PasswordChar = '\0';
            this.txtC.PlaceholderText = "";
            this.txtC.SelectedText = "";
            this.txtC.ShadowDecoration.Parent = this.txtC;
            this.txtC.Size = new System.Drawing.Size(99, 29);
            this.txtC.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(475, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Cantidad:";
            // 
            // txtNomMedi
            // 
            this.txtNomMedi.BackColor = System.Drawing.Color.Transparent;
            this.txtNomMedi.BorderColor = System.Drawing.Color.LightPink;
            this.txtNomMedi.BorderRadius = 8;
            this.txtNomMedi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomMedi.DefaultText = "";
            this.txtNomMedi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomMedi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomMedi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomMedi.DisabledState.Parent = this.txtNomMedi;
            this.txtNomMedi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomMedi.Enabled = false;
            this.txtNomMedi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomMedi.FocusedState.Parent = this.txtNomMedi;
            this.txtNomMedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMedi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomMedi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomMedi.HoverState.Parent = this.txtNomMedi;
            this.txtNomMedi.Location = new System.Drawing.Point(413, 137);
            this.txtNomMedi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomMedi.Name = "txtNomMedi";
            this.txtNomMedi.PasswordChar = '\0';
            this.txtNomMedi.PlaceholderText = "";
            this.txtNomMedi.SelectedText = "";
            this.txtNomMedi.ShadowDecoration.Parent = this.txtNomMedi;
            this.txtNomMedi.Size = new System.Drawing.Size(99, 29);
            this.txtNomMedi.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(291, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Medicamento:";
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
            this.DgvMedicamentos.Location = new System.Drawing.Point(1, 219);
            this.DgvMedicamentos.Name = "DgvMedicamentos";
            this.DgvMedicamentos.ReadOnly = true;
            this.DgvMedicamentos.RowHeadersVisible = false;
            this.DgvMedicamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMedicamentos.Size = new System.Drawing.Size(433, 244);
            this.DgvMedicamentos.TabIndex = 62;
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
            this.DgvMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicamentos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(157, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Stock de medicamentos:";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BorderRadius = 10;
            this.BtnRegistrar.CheckedState.Parent = this.BtnRegistrar;
            this.BtnRegistrar.CustomImages.Parent = this.BtnRegistrar;
            this.BtnRegistrar.FillColor = System.Drawing.Color.Red;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.Lavender;
            this.BtnRegistrar.HoverState.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Location = new System.Drawing.Point(12, 169);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.ShadowDecoration.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Size = new System.Drawing.Size(103, 24);
            this.BtnRegistrar.TabIndex = 64;
            this.BtnRegistrar.Text = "Limpiar factura";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BorderRadius = 10;
            this.BtnAgregar.CheckedState.Parent = this.BtnAgregar;
            this.BtnAgregar.CustomImages.Parent = this.BtnAgregar;
            this.BtnAgregar.FillColor = System.Drawing.Color.Green;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Lavender;
            this.BtnAgregar.HoverState.Parent = this.BtnAgregar;
            this.BtnAgregar.Location = new System.Drawing.Point(121, 169);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.ShadowDecoration.Parent = this.BtnAgregar;
            this.BtnAgregar.Size = new System.Drawing.Size(132, 24);
            this.BtnAgregar.TabIndex = 65;
            this.BtnAgregar.Text = "Agregar a la cuenta";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvCuenta
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DgvCuenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCuenta.BackgroundColor = System.Drawing.Color.White;
            this.DgvCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCuenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCuenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medicamento,
            this.Cantidad,
            this.Precio,
            this.Total});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCuenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvCuenta.EnableHeadersVisualStyles = false;
            this.DgvCuenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DgvCuenta.Location = new System.Drawing.Point(667, 44);
            this.DgvCuenta.Name = "DgvCuenta";
            this.DgvCuenta.ReadOnly = true;
            this.DgvCuenta.RowHeadersVisible = false;
            this.DgvCuenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCuenta.Size = new System.Drawing.Size(538, 194);
            this.DgvCuenta.TabIndex = 66;
            this.DgvCuenta.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DgvCuenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DgvCuenta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCuenta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvCuenta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCuenta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCuenta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvCuenta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DgvCuenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DgvCuenta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCuenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvCuenta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCuenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCuenta.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvCuenta.ThemeStyle.ReadOnly = true;
            this.DgvCuenta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DgvCuenta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCuenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvCuenta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvCuenta.ThemeStyle.RowsStyle.Height = 22;
            this.DgvCuenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DgvCuenta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotal.Location = new System.Drawing.Point(548, 185);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Text = "Total:";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.TotalLbl.Location = new System.Drawing.Point(605, 185);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(46, 20);
            this.TotalLbl.TabIndex = 68;
            this.TotalLbl.Text = "C$ 0";
            // 
            // DgvTrans
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DgvTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTrans.BackgroundColor = System.Drawing.Color.White;
            this.DgvTrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTrans.DefaultCellStyle = dataGridViewCellStyle9;
            this.DgvTrans.EnableHeadersVisualStyles = false;
            this.DgvTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DgvTrans.Location = new System.Drawing.Point(480, 264);
            this.DgvTrans.Name = "DgvTrans";
            this.DgvTrans.ReadOnly = true;
            this.DgvTrans.RowHeadersVisible = false;
            this.DgvTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTrans.Size = new System.Drawing.Size(725, 199);
            this.DgvTrans.TabIndex = 69;
            this.DgvTrans.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DgvTrans.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DgvTrans.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvTrans.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvTrans.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvTrans.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvTrans.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvTrans.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DgvTrans.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DgvTrans.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvTrans.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvTrans.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvTrans.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvTrans.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvTrans.ThemeStyle.ReadOnly = true;
            this.DgvTrans.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DgvTrans.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvTrans.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvTrans.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvTrans.ThemeStyle.RowsStyle.Height = 22;
            this.DgvTrans.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DgvTrans.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(815, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Historial de transacciones";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BorderRadius = 10;
            this.BtnImprimir.CheckedState.Parent = this.BtnImprimir;
            this.BtnImprimir.CustomImages.Parent = this.BtnImprimir;
            this.BtnImprimir.FillColor = System.Drawing.Color.Green;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.Lavender;
            this.BtnImprimir.HoverState.Parent = this.BtnImprimir;
            this.BtnImprimir.Location = new System.Drawing.Point(1038, 237);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ShadowDecoration.Parent = this.BtnImprimir;
            this.BtnImprimir.Size = new System.Drawing.Size(132, 24);
            this.BtnImprimir.TabIndex = 71;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Medicamento
            // 
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btnValidarDni
            // 
            this.btnValidarDni.BorderRadius = 10;
            this.btnValidarDni.CheckedState.Parent = this.btnValidarDni;
            this.btnValidarDni.CustomImages.Parent = this.btnValidarDni;
            this.btnValidarDni.FillColor = System.Drawing.Color.Green;
            this.btnValidarDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarDni.ForeColor = System.Drawing.Color.Lavender;
            this.btnValidarDni.HoverState.Parent = this.btnValidarDni;
            this.btnValidarDni.Location = new System.Drawing.Point(259, 169);
            this.btnValidarDni.Name = "btnValidarDni";
            this.btnValidarDni.ShadowDecoration.Parent = this.btnValidarDni;
            this.btnValidarDni.Size = new System.Drawing.Size(132, 24);
            this.btnValidarDni.TabIndex = 72;
            this.btnValidarDni.Text = "Validar cedula";
            this.btnValidarDni.Click += new System.EventHandler(this.btnValidarDni_Click);
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 462);
            this.Controls.Add(this.btnValidarDni);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvTrans);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.DgvCuenta);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvMedicamentos);
            this.Controls.Add(this.txtNomMedi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApeC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomC);
            this.Controls.Add(this.lblNomC);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblFact;
        private Guna.UI2.WinForms.Guna2CirclePictureBox BtnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtApeC;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNomC;
        private System.Windows.Forms.Label lblNomC;
        private Guna.UI2.WinForms.Guna2TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtC;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNomMedi;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView DgvMedicamentos;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrar;
        private Guna.UI2.WinForms.Guna2Button BtnAgregar;
        private Guna.UI2.WinForms.Guna2DataGridView DgvCuenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label TotalLbl;
        private Guna.UI2.WinForms.Guna2DataGridView DgvTrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNomVen;
        private Guna.UI2.WinForms.Guna2Button BtnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2Button btnValidarDni;
    }
}