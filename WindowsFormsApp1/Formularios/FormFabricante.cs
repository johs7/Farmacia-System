using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Clases;
using WindowsFormsApp1.AppModel;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1.Formularios
{
    public partial class FormFabricante : Form
    {
        public FormFabricante()
        {
            InitializeComponent();
        }
        ClassFabricante op= new ClassFabricante();
        SqlConnection Con = new SqlConnection("server=DESKTOP-GFGGUM9\\SQL; database=Farmacia; integrated security=true");
        private void FormFabricante_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void Alert(string msg, Formularios.FormAlert.enmType type)
        {
            Formularios.FormAlert frm = new Formularios.FormAlert();
            frm.showAlert(msg, type);
        }
       new public TblFabricante Update()
        {
            int id = int.Parse(txtBuscar.Text);
           TblFabricante fab = op.Buscar(id);
            if (id != 0)
                return fab;
            else
                return null;
        }
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (char.IsLetter(v.KeyChar))
            {

                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
                MessageBox.Show("Espacios no permitidos");
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {

                v.Handled = true;
                MessageBox.Show("Digite solo letras porfavor");

            }
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {

            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {

                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Digite solo números porfavor");
            }
        }
        private void CargarDatos()
        {
            string consulta = " select*from TblFabricante";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Con);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DgvFabricantes.DataSource = dt;
        }
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNomFab.Text))
            {
                Error.SetError(txtNomFab, "Debe Escribir El nombre del fabricante");
                return false;
            }
            else
            {
                Error.SetError(txtNomFab, "");
                return true;
            }
        }
        private bool TamañoMinimoTelefono()
        {
            if (txtTel.Text.Length < 8)
            {
                Error.SetError(txtTel, "Debe escribir el tamaño minimo de caracteres");
                return false;
            }
            else
            {
                Error.SetError(txtTel, "");
                return true;
            }
        }
        private bool ValidarDni()
        {
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                Error.SetError(txtDni, "Debe Escribir la cedula del fabricante");
                return false;
            }
            else
            {
                Error.SetError(txtDni, "");
                return true;
            }
        }
        private bool ValidarDirec()
        {
            if (string.IsNullOrEmpty(txtDirec.Text))
            {
                Error.SetError(txtDirec, "Debe Escribir la direccion del vendedor");
                return false;
            }
            else
            {
                Error.SetError(txtDirec, "");
                return true;
            }
        }
        private bool ValidarFecha()
        {
            DateTime hoy = DateTime.Today;
            if (dtpNac.Value.Date > hoy)
            {
                Error.SetError(dtpNac, "Debe Escribir una fecha presente o pasada");
                return false;
            }
            else
            {
                Error.SetError(dtpNac, "");
                return true;
            }

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TblFabricante fab = new TblFabricante();
                fab.FabId = Convert.ToInt32(txtBuscar.Text);

                int id = Convert.ToInt32(txtBuscar.Text);

                fab = op.Buscar(id);
                if (op.Eliminar(fab) == true)
                {
                    this.Alert("¡Eliminado correctamente!", Formularios.FormAlert.enmType.Warning);
                    CargarDatos();
                }
                else
                    this.Alert("¡Error al eliminar!", Formularios.FormAlert.enmType.Error);
            }
            catch
            {
                this.Alert("¡Error al eliminar!", Formularios.FormAlert.enmType.Error);
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TamañoMinimoTelefono() == false)
                {
                    return;
                }
                if (ValidarNombre() == false)
                {
                    return;
                }
                if (ValidarDni() == false)
                {
                    return;
                }
                if (ValidarDirec() == false)
                {
                    return;
                }
                if (ValidarFecha() == false){
                    return;
                }
                TblFabricante fab = new TblFabricante();
                fab.NomFab = txtNomFab.Text;
                fab.DirFab = txtDirec.Text;
                fab.CedulaFab = txtDni.Text;
                fab.TelFab = txtTel.Text;
                fab.FechaInFab = DateTime.Parse(dtpNac.Text);
     
                if (op.Guardar(fab) == true)
            {
                    CargarDatos();
                this.Alert("¡Registrado Correctamente!", FormAlert.enmType.Success);
                    txtNomFab.Text = "";
                    txtDirec.Text = "";
                    txtDni.Text = "";
                    txtTel.Text = "";
                    dtpNac.Text = "";
                     
            }
            else
            {
                this.Alert("¡Error al registrar!", FormAlert.enmType.Error);
            }
        }
            catch { this.Alert("¡Error al registrar!", FormAlert.enmType.Error);
    }
}

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                TblFabricante fab = op.Buscar(int.Parse(txtBuscar.Text));
                if (fab != null)
                {
                    fab = op.Buscar(int.Parse(txtBuscar.Text));
                    txtNomFab.Text = fab.NomFab;
                    txtDirec.Text = fab.DirFab;
                    txtDni.Text = fab.CedulaFab;
                    txtTel.Text = fab.TelFab;
                    dtpNac.Text = fab.FechaInFab.ToString();
                   
                }
                else
                    this.Alert("No se pudo encontrar el registro", FormAlert.enmType.Error);
            }
            catch { this.Alert("No se pudo encontrar el registro", FormAlert.enmType.Error); }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Update() != null)
                {
                    TblFabricante fab = Update();
                    fab.NomFab = txtNomFab.Text;
                    fab.DirFab = txtDirec.Text;
                    fab.CedulaFab = txtDni.Text;
                    fab.TelFab = txtTel.Text;
                    fab.FechaInFab = DateTime.Parse(dtpNac.Text);
                    if (op.Modificar(fab) == true)
                    {
                        CargarDatos();
                        this.Alert("¡Registro modificado!", Formularios.FormAlert.enmType.Info);
                        txtNomFab.Text = "";
                        txtDirec.Text = "";
                        txtDni.Text = "";
                        txtTel.Text = "";
                        dtpNac.Text = "";

                    }
                    else
                    {
                        this.Alert("¡Error al modificar!", Formularios.FormAlert.enmType.Error);
                    }
                }
            }
            catch
            { this.Alert("¡Error al modificar!", Formularios.FormAlert.enmType.Error); }
        }

        private void txtNomFab_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
              //____________________________Validar Longitud_________________________

            if (string.IsNullOrEmpty(txtDni.Text) || txtDni.Text.ToString().Length < 16 || txtDni.Text.ToString().Length > 16)
            {
                Error.SetError(txtDni, "La longitud minima es 16");
                txtDni.Text = string.Empty;
                return;
            }

            //_______________________________Validar Solo Numeros_________________________

            if (!txtDni.Text.Substring(0, 3).All(char.IsDigit))
            { 
                Error.SetError(txtDni, "Formato incorrecto");
                txtDni.Text = string.Empty;
                return;
            }

            if (!txtDni.Text.Substring(4, 6).All(char.IsDigit))
            {
                Error.SetError(txtDni, "Formato incorrecto");
                txtDni.Text = string.Empty;
                return;
            }

            if (!txtDni.Text.Substring(11, 4).All(char.IsDigit))
            {
                Error.SetError(txtDni, "Formato incorrecto");
                txtDni.Text = string.Empty;
                return;
            }

            //________________________VAlidar DIa, mes, año____________________________

            int Validia = Convert.ToInt32(txtDni.Text.Substring(4, 2));

            if (Validia > 31 || Validia < 01)
            {
                Error.SetError(txtDni, "Formato del dia incorrecto");
                txtDni.Text = string.Empty;
                return;
            }

            int ValiMes = Convert.ToInt32(txtDni.Text.Substring(6, 2));

            if (ValiMes > 09 || ValiMes > 12)
            {
                Error.SetError(txtDni, "Formato del mes incorrecto");
                txtDni.Text = string.Empty;
                return;
            }

            //________________________Ultima Letra_______________________________________
   if (!char.IsLetter(txtDni.Text.Last()))
            {
                Error.SetError(txtDni, "Formato incorrecto");
               txtDni.Text = string.Empty;
                return;
            }

            //________________________Validar Guiones__________________________________________

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDni.Text.Substring(3, 1), "[-]"))
            {
                Error.SetError(txtDni, "Formato incorrecto");
                txtDni.Text = string.Empty;
                return;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDni.Text.Substring(10, 1), "[-]"))
            {
                Error.SetError(txtDni, "Formato incorrecto");
                txtDni.Text = string.Empty;
                return;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
