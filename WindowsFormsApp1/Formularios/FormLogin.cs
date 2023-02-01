using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {


        SqlConnection Con = new SqlConnection("server=DESKTOP-GFGGUM9\\SQL; database=Farmacia; integrated security=true");
        public FormLogin()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Formularios.FormAlert.enmType type)
        {
            Formularios.FormAlert frm = new Formularios.FormAlert();
            frm.showAlert(msg, type);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Alert("¡Bienvenido!", Formularios.FormAlert.enmType.Success);
        }
        public static string Usuario = "";
        private void BtnLogin_Click(object sender, EventArgs e)
        {

       
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from TblVendedor where NomVen='" + txtUser.Text + "'and ContraVen='" + txtPass.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Usuario = txtUser.Text;
                Formularios.FormFactura obj = new Formularios.FormFactura();
                obj.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                this.Alert("¡Credenciales incorrectas!", Formularios.FormAlert.enmType.Error);
                Con.Close();
            }
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña del administrador.");
            }
            else
            if (txtPass.Text == "Admin" && txtUser.Text=="Admin")
            {
                Formularios.FormMain frmP = new Formularios.FormMain ();
                frmP.ShowDialog();
            }
            else
            {
                MessageBox.Show("Contraseña de administrador incorrecta");
                txtPass.Text = "";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlContainer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

