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
using System.Runtime.InteropServices;
using System.Globalization;
using System.Windows.Controls;
using Guna.UI2.WinForms;
using Bunifu.UI.WinForms;

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
            dtpIng.Value=DateTime.Now;
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
        private bool ValidarCampo(Guna2TextBox control, string mensajeError)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                Error.SetError(control, mensajeError);
                return false;
            }
            else
            {
                Error.SetError(control, "");
                return true;
            }
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
            List<TblFabricante> listaFabricantes = op.Listar();
            DgvFabricantes.DataSource = listaFabricantes;
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
            if (txtTel.Text.Length != 8)
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
            return ValidarCampo(txtDni, "Debe escribir la cedula del fabricante");
        }
        private bool ValidarDirec()
        {
            return ValidarCampo(txtDirec,"Debe escribir la dirección del fabricante");
        }
        private bool ValidarFecha()
        {
            DateTime hoy = DateTime.Today;
            if (dtpIng.Value.Date > hoy)
            {
                Error.SetError(dtpIng, "Debe Escribir una fecha presente o pasada");
                return false;
            }
            else
            {
                Error.SetError(dtpIng, "");
                return true;
            }

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
                fab.FechaInFab = DateTime.Parse(dtpIng.Text);
     
                if (op.Guardar(fab) == true)
            {
                    CargarDatos();
                this.Alert("¡Registrado Correctamente!", FormAlert.enmType.Success);
                    txtNomFab.Text = "";
                    txtDirec.Text = "";
                    txtDni.Text = "";
                    txtTel.Text = "";
                    dtpIng.Text = "";
                     
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
                    dtpIng.Text = fab.FechaInFab.ToString();
                   
                }
                else
                    this.Alert("No encontrado", FormAlert.enmType.Error);
            }
            catch { this.Alert("No encontrado", FormAlert.enmType.Error); }
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
                    fab.FechaInFab = DateTime.Parse(dtpIng.Text);
                    if (op.Modificar(fab) == true)
                    {
                        CargarDatos();
                        this.Alert("¡Registro modificado!", Formularios.FormAlert.enmType.Info);
                        txtNomFab.Text = "";
                        txtDirec.Text = "";
                        txtDni.Text = "";
                        txtTel.Text = "";
                        dtpIng.Text = "";

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

            {
                string[] validCombinations = {/*Managua*/ "001", "002", "003", "004", "005", "006", "007", "008", "009", 
                    /*Nueva segovia*/ "481", "482", "483", "484", "485", "486", "487", "488", "489", "490", "491", "492", "493",
                    /*Madriz*/"321","322","323","324","325","326","327","328","329",
                    /*Esteli*/"161","162","163","164","165","166",
                    /*Leon*/"281","282","283","284","285","286","287","288","289","290","291",
                    /*Chinandega*/ "081","082","083","084","085","086","087","088","089","090","091","092","093",
                    /*Granada*/"201","202","203","204",
                    /*Masaya*/ "401","402","403","404","405","406","407","408","409",
                     /*Carazo*/ "041","042","043","044","045","046","047","048",
                   /*Rivas*/ "561","562","563","564","565","566","567","568","569","570",
                   /*Boaco*/"361","362","363","364","365","366",
                   /*Chontales*/"121","122","123","124","125","126","127","128","129","130","603","604","616","628",
                   /*Jinotega*/"241","242","243","244","246","247","248","492",
                   /*Matagalpa*/"441","442","443","444","445","446","447","448","449","450","451","452","453","454",
                   /*RAAN*/"606","607","608","610","611","612","629",
                   /*RAAS*/"601","602","605","615","619","624","626","627",
                   /*RIO SAN JUAN*/"521","522","523","524","525","526"
                };

                string cedula = txtDni.Text.Trim();
                // Verifica si la longitud es correcta
                if (cedula.Length != 16)
                {
                    Error.SetError(txtDni, "La cédula debe tener 16 caracteres.");
           
                    return;
                }

                // Verifica si los guiones están en las posiciones correctas
                if (cedula[3] != '-' || cedula[10] != '-')
                {
                    Error.SetError(txtDni, "Los guiones deben estar en las posiciones 4 y 11.");
             
                    return;
                }

                // Verifica si el primer tres digitos es una combinación válida
                string firstThree = cedula.Substring(0, 3);
                if (!validCombinations.Contains(firstThree))
                {
                    Error.SetError(txtDni   , "Los primeros 3 dígitos no son válidos.");
                
                    return;
                }

                // Verifica si los siguientes 6 digitos es una fecha válida
                string dateString = cedula.Substring(4, 6);
                DateTime date;
                if (!DateTime.TryParseExact(dateString, "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Error.SetError(txtDni   , "Los siguientes 6 dígitos no son una fecha válida.");
                
                    return;
                }

                // Verifica si la persona es mayor de 16 años
                if (DateTime.Now.Subtract(date).TotalDays / 365 < 16)
                {
                    Error.SetError(txtDni, "La persona debe ser mayor de 16 años.");
      

                    return;
                }

                // Verifica si el último dígito es una letra
                char lastChar = cedula[15];
                if (!char.IsLetter(lastChar))
                {
                    Error.SetError(txtDni, "El último caracter debe ser una letra.");
     
                    return;
                }

                // Si todas las validaciones pasaron, elimina el error
                Error.SetError(txtDni, "");
  
            }

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDni.Text);
            txtDni.SelectionStart = txtDni.Text.Length;
        }

        private void txtNomFab_TextChanged(object sender, EventArgs e)
        {
            txtNomFab.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNomFab.Text);
            txtNomFab.SelectionStart = txtNomFab.Text.Length;
        }

        private void DgvFabricantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex < 0)
                return;
            DataGridViewRow selectedRow = DgvFabricantes.Rows[selectedRowIndex];

            txtNomFab.Text = selectedRow.Cells["NomFab"].Value.ToString();
            txtDirec.Text = selectedRow.Cells["DirFab"].Value.ToString();
            txtTel.Text = selectedRow.Cells["TelFab"].Value.ToString();
            txtDni.Text = selectedRow.Cells["CedulaFab"].Value.ToString();
           dtpIng.Text = selectedRow.Cells["FechaInFab"].Value.ToString();
        }

        private void DgvFabricantes_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DgvFabricantes.CurrentRow.Index)
            {
                txtNomFab.Text = "";
                txtDirec.Text = "";
                txtDni.Text = "";
                txtTel.Text = "";
                dtpIng.Text = "";
            }
        }

   
        
    }
}
