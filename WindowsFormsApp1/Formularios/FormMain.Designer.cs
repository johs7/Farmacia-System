namespace WindowsFormsApp1.Formularios
{
    partial class FormMain
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCantV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCuentas = new FontAwesome.Sharp.IconButton();
            this.BtnMedic = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnVendedores = new FontAwesome.Sharp.IconButton();
            this.BtnFabricante = new FontAwesome.Sharp.IconButton();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.GhostWhite;
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.BtnCuentas);
            this.panelContainer.Controls.Add(this.BtnMedic);
            this.panelContainer.Controls.Add(this.BtnClientes);
            this.panelContainer.Controls.Add(this.BtnVendedores);
            this.panelContainer.Controls.Add(this.BtnFabricante);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(679, 546);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.lblCantV);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 100);
            this.panel1.TabIndex = 18;
            // 
            // lblCantV
            // 
            this.lblCantV.AutoSize = true;
            this.lblCantV.BackColor = System.Drawing.Color.Transparent;
            this.lblCantV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantV.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCantV.Location = new System.Drawing.Point(11, 10);
            this.lblCantV.Name = "lblCantV";
            this.lblCantV.Size = new System.Drawing.Size(118, 15);
            this.lblCantV.TabIndex = 19;
            this.lblCantV.Text = "Cantidad vendida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(10, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cantidad vendida";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.money_growth;
            this.pictureBox1.Location = new System.Drawing.Point(121, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelTitleBar.Controls.Add(this.label6);
            this.panelTitleBar.Controls.Add(this.pictureBox2);
            this.panelTitleBar.Controls.Add(this.BtnClose);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(679, 72);
            this.panelTitleBar.TabIndex = 15;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(88, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Farmacia Angie-Bienvenido";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.medical_report__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cerrar_ventana_48;
            this.BtnClose.Location = new System.Drawing.Point(638, -5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(43, 41);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(279, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Medicamentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(487, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vendedores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(284, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fabricantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(70, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(70, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cuentas";
            // 
            // BtnCuentas
            // 
            this.BtnCuentas.BackColor = System.Drawing.Color.Transparent;
            this.BtnCuentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuentas.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtnCuentas.IconColor = System.Drawing.Color.LimeGreen;
            this.BtnCuentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCuentas.IconSize = 98;
            this.BtnCuentas.Location = new System.Drawing.Point(12, 100);
            this.BtnCuentas.Name = "BtnCuentas";
            this.BtnCuentas.Size = new System.Drawing.Size(181, 132);
            this.BtnCuentas.TabIndex = 2;
            this.BtnCuentas.UseVisualStyleBackColor = false;
            this.BtnCuentas.Click += new System.EventHandler(this.BtnCuentas_Click);
            // 
            // BtnMedic
            // 
            this.BtnMedic.BackColor = System.Drawing.Color.Transparent;
            this.BtnMedic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnMedic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedic.IconChar = FontAwesome.Sharp.IconChar.PrescriptionBottleMedical;
            this.BtnMedic.IconColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMedic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMedic.IconSize = 80;
            this.BtnMedic.Location = new System.Drawing.Point(249, 100);
            this.BtnMedic.Name = "BtnMedic";
            this.BtnMedic.Size = new System.Drawing.Size(181, 132);
            this.BtnMedic.TabIndex = 3;
            this.BtnMedic.UseVisualStyleBackColor = false;
            this.BtnMedic.Click += new System.EventHandler(this.BtnMedic_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.Transparent;
            this.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnClientes.IconColor = System.Drawing.Color.RosyBrown;
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.IconSize = 98;
            this.BtnClientes.Location = new System.Drawing.Point(12, 259);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(181, 132);
            this.BtnClientes.TabIndex = 4;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnVendedores
            // 
            this.BtnVendedores.BackColor = System.Drawing.Color.Transparent;
            this.BtnVendedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendedores.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.BtnVendedores.IconColor = System.Drawing.Color.Crimson;
            this.BtnVendedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVendedores.IconSize = 98;
            this.BtnVendedores.Location = new System.Drawing.Point(446, 175);
            this.BtnVendedores.Name = "BtnVendedores";
            this.BtnVendedores.Size = new System.Drawing.Size(181, 132);
            this.BtnVendedores.TabIndex = 6;
            this.BtnVendedores.UseVisualStyleBackColor = false;
            this.BtnVendedores.Click += new System.EventHandler(this.BtnVendedores_Click);
            // 
            // BtnFabricante
            // 
            this.BtnFabricante.BackColor = System.Drawing.Color.Transparent;
            this.BtnFabricante.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.BtnFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFabricante.IconChar = FontAwesome.Sharp.IconChar.Bong;
            this.BtnFabricante.IconColor = System.Drawing.Color.Turquoise;
            this.BtnFabricante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFabricante.IconSize = 98;
            this.BtnFabricante.Location = new System.Drawing.Point(249, 259);
            this.BtnFabricante.Name = "BtnFabricante";
            this.BtnFabricante.Size = new System.Drawing.Size(181, 132);
            this.BtnFabricante.TabIndex = 5;
            this.BtnFabricante.UseVisualStyleBackColor = false;
            this.BtnFabricante.Click += new System.EventHandler(this.BtnFabricante_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 546);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnCuentas;
        private FontAwesome.Sharp.IconButton BtnMedic;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private FontAwesome.Sharp.IconButton BtnFabricante;
        private FontAwesome.Sharp.IconButton BtnVendedores;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCantV;
        private System.Windows.Forms.Label label8;
    }
}