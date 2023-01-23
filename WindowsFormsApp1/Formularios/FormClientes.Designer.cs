namespace WindowsFormsApp1.Formularios
{
    partial class FormClientes
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTitleBar.Controls.Add(this.guna2CirclePictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.BtnClose);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(721, 45);
            this.panelTitleBar.TabIndex = 20;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_vara_de_esculapio_48;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(301, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(48, 45);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 20;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Clientes";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cerrar_ventana_48;
            this.BtnClose.Location = new System.Drawing.Point(679, -7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(48, 45);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(319, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lista de clientes";
            // 
            // DgvClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.DgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.DgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvClientes.EnableHeadersVisualStyles = false;
            this.DgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.DgvClientes.Location = new System.Drawing.Point(0, 74);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersVisible = false;
            this.DgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(724, 378);
            this.DgvClientes.TabIndex = 22;
            this.DgvClientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.DgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.DgvClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.DgvClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.DgvClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvClientes.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvClientes.ThemeStyle.ReadOnly = true;
            this.DgvClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.DgvClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvClientes.ThemeStyle.RowsStyle.Height = 22;
            this.DgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.DgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(729, 10);
            this.guna2Separator1.TabIndex = 23;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.DgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox BtnClose;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView DgvClientes;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}