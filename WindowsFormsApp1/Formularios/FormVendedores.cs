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
using System.Globalization;
using Guna.UI2.WinForms;
using Bunifu.UI.WinForms;

namespace WindowsFormsApp1.Formularios
{
    public partial class FormVendedores : Form
    {
        SqlConnection Con = new SqlConnection("server=DESKTOP-GFGGUM9\\SQL; database=Farmacia; integrated security=true");

        public FormVendedores()
        {
            InitializeComponent();
        }
        ClassVendedor op = new ClassVendedor();

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
        private bool ValidarCampo(Guna2ComboBox control, string mensajeError)
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
        private bool ValidarCampo(BunifuDatePicker control, string mensajeError)
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

            }}

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
            }}
      
        private bool ValidarNombre()
        {
            return ValidarCampo(txtNombre,"Debe escribir el nombre del vendedor");
        }
        private bool ValidarDirec()
        {
            return ValidarCampo(txtDirec, "Debe escribir la direccion del vendedor");
        }
        private bool ValidarContraseña()
        {
            return ValidarCampo(txtPass, "Debe escribir el nombre del vendedor");
        }
        private bool ValidarTelefono()
        {
            return ValidarCampo(txtTel, "Debe escribir el nombre del vendedor");
        }
        private bool ValidarDni()
        {
            return ValidarCampo(txtDni, "Debe escribir el nombre del vendedor");
        }
        private bool ValidarFechaNac()
        {
            return ValidarCampo(dtpNac, "Debe escribir la fecha de nacimiento");
        }
     
        private bool ValidarSexo()
        {
            return ValidarCampo(cmbSexo, "Debe escribir el sexo del vendedor");
        }
        private bool ValidarSalario()
        {
            return ValidarCampo(txtTel, "Debe escribir el salario del vendedor");
        }
    
       new public TblVendedor Update()
        {
            int id = int.Parse(txtBuscar.Text);
            TblVendedor emp = op.Buscar(id);
            if (id != 0)
                return emp;
            else
                return null;
        }


        private void FormVendedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarNombre() == false)
                { return; }
                if (ValidarDni() == false)
                { return; }
                if (ValidarFechaNac() == false)
                { return; }
                if (ValidarSalario() == false)
                { return; }
                if (ValidarSexo() == false)
                { return; }
                if (ValidarTelefono() == false)
                { return; }
                if (ValidarContraseña() == false)
                { return; }
                if (ValidarDirec() == false)
                { return; }
                if (ValidarFecha() == false)
                { return; }
                TblVendedor ven = new TblVendedor();
                ven.NomVen = txtNombre.Text;
                ven.FechaNacVen = DateTime.Parse(dtpNac.Text);
                ven.TelVen = txtTel.Text;
                ven.DirVen = txtDirec.Text;
                ven.CedulaVen = txtDni.Text;
                ven.GenVen = cmbSexo.Text;
                ven.ContraVen = txtPass.Text;
                ven.SueldoVen = int.Parse(txtSal.Text);
                if (op.Guardar(ven) == true)
                {
                    this.Alert("¡Registrado Correctamente!", FormAlert.enmType.Success);
                    txtNombre.Text = "";
                    dtpNac.Text = "";
                    txtTel.Text = "";
                    txtDirec.Text = "";
                    txtDni.Text = "";
                    cmbSexo.Text = "";
                    txtPass.Text = "";
                    txtSal.Text = "";
                    CargarDatos();
                }
                else
                {
                    this.Alert("¡Error al registrar!", FormAlert.enmType.Error);
                } }
            catch { this.Alert("¡Error al registrar!", FormAlert.enmType.Error); }
            }

        private void CargarDatos()
        {
            List<TblVendedor> listaVendedor = op.Listar();
            DgvCuentas.DataSource =listaVendedor;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {SoloLetras(e);  }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {SoloNumeros(e);}

        private void txtDirec_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDirec.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDirec.Text);
            txtDirec.SelectionStart = txtDirec.Text.Length;
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                TblVendedor ven = op.Buscar(int.Parse(txtBuscar.Text));
                if (ven != null)
                {
                    ven = op.Buscar(int.Parse(txtBuscar.Text));
                    txtNombre.Text = ven.NomVen;
                    dtpNac.Text = ven.FechaNacVen.ToString();
                    txtTel.Text = ven.TelVen.ToString();
                    txtDirec.Text = ven.DirVen;
                    txtDni.Text = ven.CedulaVen;
                    cmbSexo.Text = ven.GenVen;
                    txtPass.Text = ven.ContraVen;
                    txtSal.Text = ven.SueldoVen.ToString();
                }
                else
                    this.Alert("No encontrado", FormAlert.enmType.Error);
            }
            catch { this.Alert("No encontrado", FormAlert.enmType.Error); }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try {
                if (Update() != null)
                {
                    TblVendedor ven = Update();
                    ven.NomVen = txtNombre.Text;
                    ven.FechaNacVen = DateTime.Parse(dtpNac.Text);
                    ven.TelVen = txtTel.Text;
                    ven.DirVen = txtDirec.Text;
                    ven.CedulaVen = txtDni.Text;
                    ven.GenVen = cmbSexo.Text;
                    ven.ContraVen = txtPass.Text;
                    ven.SueldoVen = int.Parse(txtSal.Text);
                    if (op.Modificar(ven) == true)
                    {
                        this.Alert("¡Registro modificado!", Formularios.FormAlert.enmType.Info);
                        CargarDatos();
                    }
                    else
                    {
                        this.Alert("¡Error al modificar!", Formularios.FormAlert.enmType.Error);
                    }}}
            catch
            {this.Alert("¡Error al modificar!", Formularios.FormAlert.enmType.Error);}
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try {
                TblVendedor ven = new TblVendedor();
                ven.IdVen = Convert.ToInt32(txtBuscar.Text);

                int id = Convert.ToInt32(txtBuscar.Text);

                ven = op.Buscar(id);
                if (op.Eliminar(ven) == true)
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
            }}

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    e.Cancel = true;
                    return;
                }

                // Verifica si los guiones están en las posiciones correctas
                if (cedula[3] != '-' || cedula[10] != '-')
                {
                    Error.SetError(txtDni, "Los guiones deben estar en las posiciones 4 y 11.");
                    e.Cancel = true;
                    return;
                }

                // Verifica si el primer tres digitos es una combinación válida
                string firstThree = cedula.Substring(0, 3);
                if (!validCombinations.Contains(firstThree))
                {
                    Error.SetError(txtDni, "Los primeros 3 dígitos no son válidos.");
                    e.Cancel = true;
                    return;
                }

                // Verifica si los siguientes 6 digitos es una fecha válida
                string dateString = cedula.Substring(4, 6);
                DateTime date;
                if (!DateTime.TryParseExact(dateString, "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Error.SetError(txtDni, "Los siguientes 6 dígitos no son una fecha válida.");
                    e.Cancel = true;
                    return;
                }

                // Verifica si la persona es mayor de 16 años
                if (DateTime.Now.Subtract(date).TotalDays / 365 < 16)
                {
                    Error.SetError(txtDni, "La persona debe ser mayor de 16 años.");
                    e.Cancel = true;

                    return;
                }

                // Verifica si el último dígito es una letra
                char lastChar = cedula[15];
                if (!char.IsLetter(lastChar))
                {
                    Error.SetError(txtDni, "El último caracter debe ser una letra.");
                    e.Cancel = true;
                    return;
                }

                // Si todas las validaciones pasaron, elimina el error
                Error.SetError(txtDni, "");
                e.Cancel = false;
            }
        }
        private bool ValidarFecha()
        {
            DateTime hoy = DateTime.Today;
            if (dtpNac.Value.AddYears(18) > hoy)
            {
                Error.SetError(dtpNac, "Debe ser mayor de edad");
                return false;
            }
            else
            {
                Error.SetError(dtpNac, "");
                return true;
            }

        }
        private void txtSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDni.Text);
            txtDni.SelectionStart = txtDni.Text.Length;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.Text.Length < 8)
            {
                e.Cancel = true;
                Error.SetError(txtPass, "La contraseña debe tener al menos 8 caracteres");
            }
            else
            {
               Error.SetError(txtPass, "");
            }
        }

        private void txtSal_Validating(object sender, CancelEventArgs e)
        {
            int salario;
            if (!int.TryParse(txtSal.Text, out salario))
            {
                Error.SetError(txtSal,"El valor ingresado no es válido. Por favor ingrese un número.");
                e.Cancel = true;
                return;
            }

            if (salario < 4000)
            {
                Error.SetError(txtSal,"El salario debe ser mayor a 4000.");
                e.Cancel = true;
            }
        }

        private void DgvCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex < 0)
                return;

            DataGridViewRow selectedRow = DgvCuentas.Rows[selectedRowIndex];

            txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
          dtpNac.Text= selectedRow.Cells["FechaNacimiento"].Value.ToString();
            txtTel.Text = selectedRow.Cells["Telefono"].Value.ToString();
            txtDirec.Text = selectedRow.Cells["Direccion"].Value.ToString();
            txtDni.Text = selectedRow.Cells["Cedula"].Value.ToString();
            cmbSexo.Text = selectedRow.Cells["Genero"].Value.ToString();
            txtPass.Text = selectedRow.Cells["Contraseña"].Value.ToString();
            txtSal.Text = selectedRow.Cells["Salario"].Value.ToString();
        }

        private void DgvCuentas_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

