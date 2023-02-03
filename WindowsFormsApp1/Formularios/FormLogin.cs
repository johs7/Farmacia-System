
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {

        ClassVendedor op=new ClassVendedor();
        SqlConnection Con = new SqlConnection("server=DESKTOP-GFGGUM9\\SQL; database=Farmacia; integrated security=true");
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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
            string name = txtUser.Text;
            string pass = txtPass.Text;
            if (op.Verificar(name, pass))
            {
                Usuario = txtUser.Text;
                Formularios.FormFactura obj = new Formularios.FormFactura();
                obj.ShowDialog();
            }
            else
            {
                this.Alert("¡Credenciales incorrectas!", Formularios.FormAlert.enmType.Error);
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

