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
        private bool ValidarTxtBuscar()
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                Error.SetError(txtBuscar, "Debe Escribir El id a buscar");
                return false;
            }
            else
            {
                Error.SetError(txtBuscar, "");
                return true;
            }}
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                Error.SetError(txtNombre, "Debe Escribir El nombre");
                return false;
            }
            else
            {
                Error.SetError(txtNombre, "");
                return true;
            }}
        private bool ValidarContraseña()
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                Error.SetError(txtPass, "Debe Escribir la contraseña");
                return false;
            }
            else
            {
                Error.SetError(txtPass, "");
                return true;
            }
        }
        private bool ValidarTelefono()
        {
            if (string.IsNullOrEmpty(txtTel.Text))
            {
                Error.SetError(txtTel, "Debe Escribir el telefono del vendedor");
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
                Error.SetError(txtDni, "Debe Escribir la cedula del vendedor");
                return false;
            }
            else
            {
                Error.SetError(txtDni, "");
                return true;
            }
        }
        private bool ValidarFechaNac()
        {
            if (string.IsNullOrEmpty(dtpNac.Text))
            {
                Error.SetError(dtpNac, "Debe Escribir lá fecha de nacimiento del vendedor");
                return false;
            }
            else
            {
                Error.SetError(dtpNac, "");
                return true;
            }
        }
        private bool ValidarSexo()
        {
            if (string.IsNullOrEmpty(cmbSexo.Text))
            {
                Error.SetError(cmbSexo, "Debe Escribir el sexo del vendedor");
                return false;
            }
            else
            {
                Error.SetError(cmbSexo, "");
                return true;
            }
        }
        private bool ValidarSalario()
        {
            if (string.IsNullOrEmpty(txtSal.Text))
            {
                Error.SetError(txtSal, "Debe Escribir el salario del vendedor");
                return false;
            }
            else
            {
                Error.SetError(txtSal, "");
                return true;
            }
        }
        public TblVendedor Update()
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
            string consulta = " select*from TblVendedor";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Con);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DgvCuentas.DataSource = dt;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {SoloLetras(e);}

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {SoloNumeros(e);}

        private void txtDirec_KeyPress(object sender, KeyPressEventArgs e)
        {}

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
                    this.Alert("No se pudo encontrar el registro", FormAlert.enmType.Error);
            }
            catch {this.Alert("No se pudo encontrar el registro", FormAlert.enmType.Error); }
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
    }
}

