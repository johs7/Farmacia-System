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
using WindowsFormsApp1.AppModel;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1.Formularios
{
    public partial class FormMedicamentos : Form
    {
        SqlConnection Con = new SqlConnection("server=DESKTOP-GFGGUM9\\SQL; database=Farmacia; integrated security=true");
        public FormMedicamentos()
        {
            InitializeComponent();
    
        }
         ClassMedicamentos op=new ClassMedicamentos();
        public void Alert(string msg, Formularios.FormAlert.enmType type)
        {
            Formularios.FormAlert frm = new Formularios.FormAlert();
            frm.showAlert(msg, type);
        }
        private void CargarDatos()
        {
            string consulta = " select*from TblMedicamentos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Con);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DgvMedicamentos.DataSource = dt;
        }
        private void CargarID()
        {
           Con.Open();

            string consulta = "Select*from TblMedicamentos where NumMed='" + txtBuscar.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,Con);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
          DgvMedicamentos.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta,Con);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            Con.Close();
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
            if (string.IsNullOrEmpty(CmbFabricante.Text))
            {
                Error.SetError(CmbFabricante, "Debe Escribir El id del fabricante");
                return false;
            }
            else
            {
                Error.SetError(CmbFabricante, "");
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
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select FabId from TblFabricante", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FabId", typeof(int));
            dt.Load(Rdr);
            CmbFabricante.ValueMember = "FabId";
            CmbFabricante.DataSource = dt;
            Con.Close();
        }
        private void ObtenerNomFab()
        {
            Con.Open();
            string Query = "Select * from TblFabricante where FabId='" + CmbFabricante.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtNomFabricante.Text = dr["NomFab"].ToString();
            }
            Con.Close();
        }
        private void FormMedicamentos_Load(object sender, EventArgs e)
        {
            cmbTipoMed.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFabricante.DropDownStyle= ComboBoxStyle.DropDownList;
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
                med.FabMedId=int.Parse(CmbFabricante.Text);
                med.FabricanteMed=txtNomFabricante.Text;
                if (op.Guardar(med) == true)
                {
                    this.Alert("¡Registrado Correctamente!", FormAlert.enmType.Success);
                    txtNombreMed.Text = "";
                    cmbTipoMed.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    CmbFabricante.Text = "";
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
            txtNombreMed.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombreMed.Text);
            txtNombreMed.SelectionStart = txtNombreMed.Text.Length;
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
                    CmbFabricante.Text=ven.FabMedId.ToString();
                    txtNomFabricante.Text=ven.FabricanteMed;
                }
                else
                    this.Alert("No se pudo encontrar el registro", FormAlert.enmType.Error);
            }
            catch { this.Alert("No se pudo encontrar el registro", FormAlert.enmType.Error); }
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
                    med.FabMedId = int.Parse(CmbFabricante.Text);
                    med.FabricanteMed = txtNomFabricante.Text;
                    if (op.Modificar(med) == true)
                    {
                        this.Alert("¡Registro modificado!", Formularios.FormAlert.enmType.Info);
                        txtNombreMed.Text = "";
                        cmbTipoMed.Text = "";
                        txtCantidad.Text = "";
                        txtPrecio.Text = "";
                        CmbFabricante.Text = "";
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
    }
    }

