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
            this.components = new System.ComponentModel.Container();
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
            this.ApeCliTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomCliTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNomC = new System.Windows.Forms.Label();
            this.CedCliTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TelCliTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecMedTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CantMedTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NomMedTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DGVMedicamentos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.DGVCuenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.DGVTransacciones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnValidarDni = new Guna.UI2.WinForms.Guna2Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
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
            this.BtnClose.Size = new System.Drawing.Size(49, 45);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ApeCliTb
            // 
            this.ApeCliTb.BackColor = System.Drawing.Color.Transparent;
            this.ApeCliTb.BorderColor = System.Drawing.Color.LightPink;
            this.ApeCliTb.BorderRadius = 8;
            this.ApeCliTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApeCliTb.DefaultText = "";
            this.ApeCliTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ApeCliTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ApeCliTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ApeCliTb.DisabledState.Parent = this.ApeCliTb;
            this.ApeCliTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ApeCliTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ApeCliTb.FocusedState.Parent = this.ApeCliTb;
            this.ApeCliTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApeCliTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ApeCliTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ApeCliTb.HoverState.Parent = this.ApeCliTb;
            this.ApeCliTb.Location = new System.Drawing.Point(179, 99);
            this.ApeCliTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApeCliTb.Name = "ApeCliTb";
            this.ApeCliTb.PasswordChar = '\0';
            this.ApeCliTb.PlaceholderText = "";
            this.ApeCliTb.SelectedText = "";
            this.ApeCliTb.ShadowDecoration.Parent = this.ApeCliTb;
            this.ApeCliTb.Size = new System.Drawing.Size(99, 29);
            this.ApeCliTb.TabIndex = 51;
            this.ApeCliTb.TextChanged += new System.EventHandler(this.ApeCliTb_TextChanged);
            this.ApeCliTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApeCliTb_KeyPress);
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
            // NomCliTb
            // 
            this.NomCliTb.BackColor = System.Drawing.Color.Transparent;
            this.NomCliTb.BorderColor = System.Drawing.Color.LightPink;
            this.NomCliTb.BorderRadius = 8;
            this.NomCliTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomCliTb.DefaultText = "";
            this.NomCliTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NomCliTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NomCliTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomCliTb.DisabledState.Parent = this.NomCliTb;
            this.NomCliTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomCliTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomCliTb.FocusedState.Parent = this.NomCliTb;
            this.NomCliTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomCliTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NomCliTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomCliTb.HoverState.Parent = this.NomCliTb;
            this.NomCliTb.Location = new System.Drawing.Point(179, 66);
            this.NomCliTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NomCliTb.Name = "NomCliTb";
            this.NomCliTb.PasswordChar = '\0';
            this.NomCliTb.PlaceholderText = "";
            this.NomCliTb.SelectedText = "";
            this.NomCliTb.ShadowDecoration.Parent = this.NomCliTb;
            this.NomCliTb.Size = new System.Drawing.Size(99, 29);
            this.NomCliTb.TabIndex = 49;
            this.NomCliTb.TextChanged += new System.EventHandler(this.NomCliTb_TextChanged);
            this.NomCliTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NomCliTb_KeyPress);
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
            // CedCliTb
            // 
            this.CedCliTb.BackColor = System.Drawing.Color.Transparent;
            this.CedCliTb.BorderColor = System.Drawing.Color.LightPink;
            this.CedCliTb.BorderRadius = 8;
            this.CedCliTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CedCliTb.DefaultText = "";
            this.CedCliTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CedCliTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CedCliTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CedCliTb.DisabledState.Parent = this.CedCliTb;
            this.CedCliTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CedCliTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CedCliTb.FocusedState.Parent = this.CedCliTb;
            this.CedCliTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedCliTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CedCliTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CedCliTb.HoverState.Parent = this.CedCliTb;
            this.CedCliTb.Location = new System.Drawing.Point(357, 98);
            this.CedCliTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CedCliTb.Name = "CedCliTb";
            this.CedCliTb.PasswordChar = '\0';
            this.CedCliTb.PlaceholderText = "";
            this.CedCliTb.SelectedText = "";
            this.CedCliTb.ShadowDecoration.Parent = this.CedCliTb;
            this.CedCliTb.Size = new System.Drawing.Size(99, 29);
            this.CedCliTb.TabIndex = 55;
            this.CedCliTb.TextChanged += new System.EventHandler(this.CedCliTb_TextChanged);
            this.CedCliTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CedCliTb_KeyPress);
            this.CedCliTb.Validating += new System.ComponentModel.CancelEventHandler(this.CedCliTb_Validating);
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
            // TelCliTb
            // 
            this.TelCliTb.BackColor = System.Drawing.Color.Transparent;
            this.TelCliTb.BorderColor = System.Drawing.Color.LightPink;
            this.TelCliTb.BorderRadius = 8;
            this.TelCliTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TelCliTb.DefaultText = "";
            this.TelCliTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TelCliTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TelCliTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TelCliTb.DisabledState.Parent = this.TelCliTb;
            this.TelCliTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TelCliTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TelCliTb.FocusedState.Parent = this.TelCliTb;
            this.TelCliTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelCliTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TelCliTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TelCliTb.HoverState.Parent = this.TelCliTb;
            this.TelCliTb.Location = new System.Drawing.Point(370, 66);
            this.TelCliTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TelCliTb.Name = "TelCliTb";
            this.TelCliTb.PasswordChar = '\0';
            this.TelCliTb.PlaceholderText = "";
            this.TelCliTb.SelectedText = "";
            this.TelCliTb.ShadowDecoration.Parent = this.TelCliTb;
            this.TelCliTb.Size = new System.Drawing.Size(99, 29);
            this.TelCliTb.TabIndex = 53;
            this.TelCliTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelCliTb_KeyPress);
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
            // PrecMedTb
            // 
            this.PrecMedTb.BackColor = System.Drawing.Color.Transparent;
            this.PrecMedTb.BorderColor = System.Drawing.Color.LightPink;
            this.PrecMedTb.BorderRadius = 8;
            this.PrecMedTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrecMedTb.DefaultText = "";
            this.PrecMedTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrecMedTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrecMedTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrecMedTb.DisabledState.Parent = this.PrecMedTb;
            this.PrecMedTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrecMedTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrecMedTb.FocusedState.Parent = this.PrecMedTb;
            this.PrecMedTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecMedTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PrecMedTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrecMedTb.HoverState.Parent = this.PrecMedTb;
            this.PrecMedTb.Location = new System.Drawing.Point(540, 97);
            this.PrecMedTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PrecMedTb.Name = "PrecMedTb";
            this.PrecMedTb.PasswordChar = '\0';
            this.PrecMedTb.PlaceholderText = "";
            this.PrecMedTb.SelectedText = "";
            this.PrecMedTb.ShadowDecoration.Parent = this.PrecMedTb;
            this.PrecMedTb.Size = new System.Drawing.Size(99, 29);
            this.PrecMedTb.TabIndex = 59;
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
            // CantMedTb
            // 
            this.CantMedTb.BackColor = System.Drawing.Color.Transparent;
            this.CantMedTb.BorderColor = System.Drawing.Color.LightPink;
            this.CantMedTb.BorderRadius = 8;
            this.CantMedTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CantMedTb.DefaultText = "";
            this.CantMedTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CantMedTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CantMedTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CantMedTb.DisabledState.Parent = this.CantMedTb;
            this.CantMedTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CantMedTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CantMedTb.FocusedState.Parent = this.CantMedTb;
            this.CantMedTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantMedTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantMedTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CantMedTb.HoverState.Parent = this.CantMedTb;
            this.CantMedTb.Location = new System.Drawing.Point(561, 65);
            this.CantMedTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CantMedTb.Name = "CantMedTb";
            this.CantMedTb.PasswordChar = '\0';
            this.CantMedTb.PlaceholderText = "";
            this.CantMedTb.SelectedText = "";
            this.CantMedTb.ShadowDecoration.Parent = this.CantMedTb;
            this.CantMedTb.Size = new System.Drawing.Size(99, 29);
            this.CantMedTb.TabIndex = 57;
            this.CantMedTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantMedTb_KeyPress);
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
            // NomMedTb
            // 
            this.NomMedTb.BackColor = System.Drawing.Color.Transparent;
            this.NomMedTb.BorderColor = System.Drawing.Color.LightPink;
            this.NomMedTb.BorderRadius = 8;
            this.NomMedTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomMedTb.DefaultText = "";
            this.NomMedTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NomMedTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NomMedTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomMedTb.DisabledState.Parent = this.NomMedTb;
            this.NomMedTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomMedTb.Enabled = false;
            this.NomMedTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomMedTb.FocusedState.Parent = this.NomMedTb;
            this.NomMedTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomMedTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NomMedTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomMedTb.HoverState.Parent = this.NomMedTb;
            this.NomMedTb.Location = new System.Drawing.Point(413, 137);
            this.NomMedTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NomMedTb.Name = "NomMedTb";
            this.NomMedTb.PasswordChar = '\0';
            this.NomMedTb.PlaceholderText = "";
            this.NomMedTb.SelectedText = "";
            this.NomMedTb.ShadowDecoration.Parent = this.NomMedTb;
            this.NomMedTb.Size = new System.Drawing.Size(99, 29);
            this.NomMedTb.TabIndex = 61;
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
            // DGVMedicamentos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DGVMedicamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMedicamentos.BackgroundColor = System.Drawing.Color.White;
            this.DGVMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMedicamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVMedicamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMedicamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVMedicamentos.EnableHeadersVisualStyles = false;
            this.DGVMedicamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DGVMedicamentos.Location = new System.Drawing.Point(1, 219);
            this.DGVMedicamentos.Name = "DGVMedicamentos";
            this.DGVMedicamentos.ReadOnly = true;
            this.DGVMedicamentos.RowHeadersVisible = false;
            this.DGVMedicamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMedicamentos.Size = new System.Drawing.Size(468, 244);
            this.DGVMedicamentos.TabIndex = 62;
            this.DGVMedicamentos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVMedicamentos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DGVMedicamentos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVMedicamentos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVMedicamentos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVMedicamentos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVMedicamentos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVMedicamentos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DGVMedicamentos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DGVMedicamentos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVMedicamentos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVMedicamentos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVMedicamentos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVMedicamentos.ThemeStyle.HeaderStyle.Height = 23;
            this.DGVMedicamentos.ThemeStyle.ReadOnly = true;
            this.DGVMedicamentos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DGVMedicamentos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVMedicamentos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVMedicamentos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVMedicamentos.ThemeStyle.RowsStyle.Height = 22;
            this.DGVMedicamentos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DGVMedicamentos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedicamentos_CellClick);
            this.DGVMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicamentos_CellContentClick);
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
            // DGVCuenta
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DGVCuenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCuenta.BackgroundColor = System.Drawing.Color.White;
            this.DGVCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCuenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCuenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCuenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVCuenta.EnableHeadersVisualStyles = false;
            this.DGVCuenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DGVCuenta.Location = new System.Drawing.Point(667, 44);
            this.DGVCuenta.Name = "DGVCuenta";
            this.DGVCuenta.ReadOnly = true;
            this.DGVCuenta.RowHeadersVisible = false;
            this.DGVCuenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCuenta.Size = new System.Drawing.Size(538, 194);
            this.DGVCuenta.TabIndex = 66;
            this.DGVCuenta.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVCuenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DGVCuenta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVCuenta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVCuenta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVCuenta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVCuenta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVCuenta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DGVCuenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DGVCuenta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVCuenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVCuenta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVCuenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCuenta.ThemeStyle.HeaderStyle.Height = 23;
            this.DGVCuenta.ThemeStyle.ReadOnly = true;
            this.DGVCuenta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DGVCuenta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCuenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVCuenta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVCuenta.ThemeStyle.RowsStyle.Height = 22;
            this.DGVCuenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DGVCuenta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicamento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // DGVTransacciones
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DGVTransacciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTransacciones.BackgroundColor = System.Drawing.Color.White;
            this.DGVTransacciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTransacciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTransacciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTransacciones.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGVTransacciones.EnableHeadersVisualStyles = false;
            this.DGVTransacciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DGVTransacciones.Location = new System.Drawing.Point(480, 264);
            this.DGVTransacciones.Name = "DGVTransacciones";
            this.DGVTransacciones.ReadOnly = true;
            this.DGVTransacciones.RowHeadersVisible = false;
            this.DGVTransacciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTransacciones.Size = new System.Drawing.Size(725, 199);
            this.DGVTransacciones.TabIndex = 69;
            this.DGVTransacciones.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVTransacciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DGVTransacciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVTransacciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVTransacciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVTransacciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVTransacciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVTransacciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DGVTransacciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DGVTransacciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVTransacciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVTransacciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVTransacciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVTransacciones.ThemeStyle.HeaderStyle.Height = 23;
            this.DGVTransacciones.ThemeStyle.ReadOnly = true;
            this.DGVTransacciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DGVTransacciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTransacciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVTransacciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVTransacciones.ThemeStyle.RowsStyle.Height = 22;
            this.DGVTransacciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DGVTransacciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVTransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTransacciones_CellContentClick);
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
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 462);
            this.Controls.Add(this.DGVMedicamentos);
            this.Controls.Add(this.btnValidarDni);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGVTransacciones);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.DGVCuenta);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NomMedTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrecMedTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantMedTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CedCliTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelCliTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ApeCliTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomCliTb);
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblFact;
        private Guna.UI2.WinForms.Guna2CirclePictureBox BtnClose;
        private Guna.UI2.WinForms.Guna2TextBox ApeCliTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox NomCliTb;
        private System.Windows.Forms.Label lblNomC;
        private Guna.UI2.WinForms.Guna2TextBox CedCliTb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TelCliTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox PrecMedTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox CantMedTb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox NomMedTb;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView DGVMedicamentos;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrar;
        private Guna.UI2.WinForms.Guna2Button BtnAgregar;
        private Guna.UI2.WinForms.Guna2DataGridView DGVCuenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label TotalLbl;
        private Guna.UI2.WinForms.Guna2DataGridView DGVTransacciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNomVen;
        private Guna.UI2.WinForms.Guna2Button BtnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button btnValidarDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ErrorProvider Error;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}