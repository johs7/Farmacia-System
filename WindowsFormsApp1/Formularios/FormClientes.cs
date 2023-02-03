
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Clases;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using WindowsFormsApp1.AppModel;

namespace WindowsFormsApp1.Formularios
{
    public partial class FormClientes : Form
    {
        SqlConnection Con = new SqlConnection("server=DESKTOP-GFGGUM9\\SQL; database=Farmacia; integrated security=true");
        public FormClientes()
        {
            InitializeComponent();
        }
        ClassCliente opC=new ClassCliente();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void CargarDatos()
        {
            
            List<TblCliente> listaClientes = opC.Listar();
            DgvClientes.DataSource = listaClientes;
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
