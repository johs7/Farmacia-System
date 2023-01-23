namespace WindowsFormsApp1
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtUser = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnAdmin);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Location = new System.Drawing.Point(113, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 237);
            this.panel1.TabIndex = 1;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BorderColor = System.Drawing.Color.CadetBlue;
            this.BtnAdmin.BorderThickness = 2;
            this.BtnAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnAdmin.CheckedState.Parent = this.BtnAdmin;
            this.BtnAdmin.CustomImages.Parent = this.BtnAdmin;
            this.BtnAdmin.FillColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnAdmin.HoverState.FillColor = System.Drawing.Color.SlateBlue;
            this.BtnAdmin.HoverState.Parent = this.BtnAdmin;
            this.BtnAdmin.Location = new System.Drawing.Point(81, 199);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.ShadowDecoration.Parent = this.BtnAdmin;
            this.BtnAdmin.Size = new System.Drawing.Size(120, 31);
            this.BtnAdmin.TabIndex = 3;
            this.BtnAdmin.Text = "Administrador";
            this.BtnAdmin.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.AcceptsReturn = false;
            this.txtPass.AcceptsTab = false;
            this.txtPass.AnimationSpeed = 200;
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPass.BackgroundImage")));
            this.txtPass.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPass.BorderColorIdle = System.Drawing.Color.SlateBlue;
            this.txtPass.BorderRadius = 17;
            this.txtPass.BorderThickness = 0;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.DefaultText = "";
            this.txtPass.FillColor = System.Drawing.Color.White;
            this.txtPass.HideSelection = true;
            this.txtPass.IconLeft = null;
            this.txtPass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.IconPadding = 10;
            this.txtPass.IconRight = global::WindowsFormsApp1.Properties.Resources.cerrar;
            this.txtPass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(45, 94);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPass.Modified = false;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.SlateBlue;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnIdleState = stateProperties4;
            this.txtPass.Padding = new System.Windows.Forms.Padding(3);
            this.txtPass.PasswordChar = '●';
            this.txtPass.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPass.PlaceholderText = "Contraseña";
            this.txtPass.ReadOnly = false;
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(198, 41);
            this.txtPass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextMarginBottom = 0;
            this.txtPass.TextMarginLeft = 3;
            this.txtPass.TextMarginTop = 0;
            this.txtPass.TextPlaceholder = "Contraseña";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WordWrap = true;
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = false;
            this.txtUser.AcceptsTab = false;
            this.txtUser.AnimationSpeed = 200;
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUser.BackgroundImage")));
            this.txtUser.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUser.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUser.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txtUser.BorderRadius = 17;
            this.txtUser.BorderThickness = 0;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.DefaultText = "";
            this.txtUser.FillColor = System.Drawing.Color.White;
            this.txtUser.HideSelection = true;
            this.txtUser.IconLeft = null;
            this.txtUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.IconPadding = 10;
            this.txtUser.IconRight = global::WindowsFormsApp1.Properties.Resources.usuario;
            this.txtUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(45, 36);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUser.Modified = false;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUser.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.SteelBlue;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnIdleState = stateProperties8;
            this.txtUser.Padding = new System.Windows.Forms.Padding(3);
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUser.PlaceholderText = "Usuario";
            this.txtUser.ReadOnly = false;
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(198, 41);
            this.txtUser.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMarginBottom = 0;
            this.txtUser.TextMarginLeft = 3;
            this.txtUser.TextMarginTop = 0;
            this.txtUser.TextPlaceholder = "Usuario";
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.WordWrap = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderColor = System.Drawing.Color.CadetBlue;
            this.BtnLogin.BorderRadius = 15;
            this.BtnLogin.BorderThickness = 2;
            this.BtnLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnLogin.CheckedState.Parent = this.BtnLogin;
            this.BtnLogin.CustomImages.Parent = this.BtnLogin;
            this.BtnLogin.FillColor = System.Drawing.Color.Transparent;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnLogin.HoverState.FillColor = System.Drawing.Color.SlateBlue;
            this.BtnLogin.HoverState.Parent = this.BtnLogin;
            this.BtnLogin.Location = new System.Drawing.Point(74, 145);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.ShadowDecoration.Parent = this.BtnLogin;
            this.BtnLogin.Size = new System.Drawing.Size(131, 32);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Iniciar Sesion";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContainer.BackgroundImage")));
            this.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContainer.BorderRadius = 1;
            this.pnlContainer.Controls.Add(this.BtnClose);
            this.pnlContainer.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlContainer.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(239)))), ((int)(((byte)(215)))));
            this.pnlContainer.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(191)))), ((int)(((byte)(215)))));
            this.pnlContainer.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(191)))), ((int)(((byte)(215)))));
            this.pnlContainer.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.pnlContainer.Location = new System.Drawing.Point(-1, -6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Quality = 10;
            this.pnlContainer.Size = new System.Drawing.Size(522, 182);
            this.pnlContainer.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cerrar_ventana_48;
            this.BtnClose.Location = new System.Drawing.Point(479, -2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(48, 45);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 1;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo_angie_blanco;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(192, 13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(148, 132);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(520, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel pnlContainer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtPass;
        private Bunifu.UI.WinForms.BunifuTextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnAdmin;
    }
}

