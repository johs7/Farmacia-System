﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.AppModel;
using WindowsFormsApp1.Clases;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;

namespace WindowsFormsApp1.Formularios
{
    public partial class FormMedicamentos : Form
    {
        SqlConnection Con = new SqlConnection("server=DESKTOP-GFGGUM9\\SQL; database=Farmacia; integrated security=true");
        public FormMedicamentos()
        {
            InitializeComponent();
    
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        ClassMedicamentos op=new ClassMedicamentos();
        public void Alert(string msg, Formularios.FormAlert.enmType type)
        {
            Formularios.FormAlert frm = new Formularios.FormAlert();
            frm.showAlert(msg, type);
        }
        private void CargarDatos()
        {
           
            
                List<TblMedicamentos> listaMedicamentos = op.Listar();
                DgvMedicamentos.DataSource = listaMedicamentos;
            
        }
        private bool ValidarFecha()
        {
            DateTime hoy = DateTime.Today;
            if (dtpVen.Value.Date >= hoy.AddDays(25))
            {
                Error.SetError(dtpVen, "");
                return true;
            }
            else
            {
                Error.SetError(dtpVen, "Debe Escribir una fecha futura con más de 15 días");
                return false;
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
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombreMed.Text))
            {
                Error.SetError(txtNombreMed, "Debe Escribir El nombre del medicamento");
                return false;
            }
            else
            {
                Error.SetError(txtNombreMed, "");
                return true;
            }
        }
        private bool ValidarTipoMed()
        {
            if (string.IsNullOrEmpty(cmbTipoMed.Text))
            {
                Error.SetError(cmbTipoMed, "Debe Escribir El tipo del medicamento");
                return false;
            }
            else
            {
                Error.SetError(cmbTipoMed, "");
                return true;
            }
        }
        private bool ValidarCantMed()
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                Error.SetError(txtCantidad, "Debe Escribir cantidad de medicamentos");
                return false;
            }
            else
            {
                Error.SetError(txtCantidad, "");
                return true;
            }
        }
        private bool ValidarPrecioMed()
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                Error.SetError(txtPrecio, "Debe Escribir El precio del farmaco");
                return false;
            }
            else
            {
                Error.SetError(txtPrecio, "");
                return true;
            }
        }
        private bool ValidarIdFab()
        {
            if (string.IsNullOrEmpty(txtfabricante.Text))
            {
                Error.SetError(txtfabricante, "Debe Escribir El id del fabricante");
                return false;
            }
            else
            {
                Error.SetError(txtfabricante, "");
                return true;
            }
        }
        private bool ValidarNomFab()
        {
            if (string.IsNullOrEmpty(txtNomFabricante.Text))
            {
                Error.SetError(txtNomFabricante, "Debe Escribir El nombre del fabricante");
                return false;
            }
            else
            {
                Error.SetError(txtNomFabricante, "");
                return true;
            }
        }
        private void ObtenerFabricante()
        {
            txtfabricante.Text = op.ObtenerIdsFabricantes();
        }

        private void ObtenerNomFab()
        {
            int fabId;
            if (Int32.TryParse(txtfabricante.Text.ToString(), out fabId))
            {
                ClassFabricante classFabricante = new ClassFabricante();
                txtNomFabricante.Text = op.ObtenerNomFab(fabId);
            }
            else
            {
                txtNomFabricante.Text = "";
            }
        }
        private void FormMedicamentos_Load(object sender, EventArgs e)
        {
            cmbTipoMed.DropDownStyle = ComboBoxStyle.DropDownList;
       
            ObtenerFabricante();
            CmbFabricante_SelectionChangeCommitted(sender,e);
            CargarDatos();
        }
       new public TblMedicamentos Update()
        {
            int id = int.Parse(txtBuscar.Text);
           TblMedicamentos med = op.Buscar(id);
            if (id != 0)
                return med;
            else
                return null;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarNombre() == false)
                { return; }
                if(ValidarFecha() == false) { return; }
                if (ValidarTipoMed() == false)
                { return; }
                if (ValidarPrecioMed() == false)
                { return; }
                if (ValidarCantMed() == false)
                { return; }
                if (ValidarIdFab() == false)
                { return; }
                if (ValidarNomFab() == false)
                { return; }

                TblMedicamentos med = new TblMedicamentos();
                 med.NomMed=txtNombreMed.Text;
                med.TipoMed = cmbTipoMed.Text;
                med.CantMed = int.Parse(txtCantidad.Text);
                med.PrecioMed=int.Parse(txtPrecio.Text);
                med.FabMedId=int.Parse(txtfabricante.Text);
                med.FabricanteMed=txtNomFabricante.Text;
                med.FechaVencimiento = DateTime.Parse(dtpVen.Text);
                if (op.Guardar(med) == true)
                {
                    this.Alert("¡Registrado Correctamente!", FormAlert.enmType.Success);
                    txtNombreMed.Text = "";
                    cmbTipoMed.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtfabricante.Text = "";
                    txtNomFabricante.Text = "";
                    CargarDatos();
                }
                else
                {
                    this.Alert("¡Error al registrar!", FormAlert.enmType.Error);
                }
            }
            catch { this.Alert("¡Error al registrar!", FormAlert.enmType.Error); }
        }

        private void txtNombreMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
          
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNomFabricante_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
             txtNomFabricante.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNomFabricante.Text);
            txtNomFabricante.SelectionStart = txtNomFabricante.Text.Length;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
               
                TblMedicamentos ven = op.Buscar(int.Parse(txtBuscar.Text));
                if (ven != null)
                {
                    ven = op.Buscar(int.Parse(txtBuscar.Text));
                    txtNombreMed.Text = ven.NomMed;
                    cmbTipoMed.Text = ven.TipoMed;
                    txtCantidad.Text = ven.CantMed.ToString();
                     txtPrecio.Text = ven.PrecioMed.ToString();
                    txtfabricante.Text=ven.FabMedId.ToString();
                    txtNomFabricante.Text=ven.FabricanteMed;
                    dtpVen.Text = ven.FechaVencimiento.ToString();
                }
                else
                    this.Alert("No encontrado", FormAlert.enmType.Error); 
            }
            catch { this.Alert("No encontrado", FormAlert.enmType.Error); }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Update() != null)
                {
                    TblMedicamentos med = Update();
                    med.NomMed = txtNombreMed.Text;
                    med.TipoMed = cmbTipoMed.Text;
                    med.CantMed = int.Parse(txtCantidad.Text);
                    med.PrecioMed = int.Parse(txtPrecio.Text);
                    med.FabMedId = int.Parse(txtfabricante.Text);
                    med.FabricanteMed = txtNomFabricante.Text;
                    med.FechaVencimiento = DateTime.Parse(dtpVen.Text);
                    if (op.Modificar(med) == true)
                    {
                        this.Alert("¡Registro modificado!", Formularios.FormAlert.enmType.Info);
                        txtNombreMed.Text = "";
                        cmbTipoMed.Text = "";
                        txtCantidad.Text = "";
                        txtPrecio.Text = "";
                        txtfabricante.Text = "";
                        txtNomFabricante.Text = "";
                        CargarDatos();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TblMedicamentos med = new TblMedicamentos();
                med.NumMed = Convert.ToInt32(txtBuscar.Text);

                int id = Convert.ToInt32(txtBuscar.Text);

                med = op.Buscar(id);
                if (op.Eliminar(med) == true)
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

        private void CmbFabricante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ObtenerNomFab();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNombreMed_TextChanged(object sender, EventArgs e)
        {
            txtNombreMed.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombreMed.Text);
            txtNombreMed.SelectionStart = txtNombreMed.Text.Length;
        }

        private void txtNomFabricante_TextChanged(object sender, EventArgs e)
        {
            txtNomFabricante.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNomFabricante.Text);
           txtNomFabricante.SelectionStart = txtNomFabricante.Text.Length;
        }

        private void txtfabricante_TextChanged(object sender, EventArgs e)
        {
            if (Con.State == ConnectionState.Closed)
            {
                ObtenerNomFab();
            }
        }
    }
    }

