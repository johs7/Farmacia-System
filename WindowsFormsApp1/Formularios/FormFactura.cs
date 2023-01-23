using FontAwesome.Sharp;
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
using System.Windows.Input;
using System.Drawing.Printing;

namespace WindowsFormsApp1.Formularios
{
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
            lblNomVen.Text = FormLogin.Usuario;
        }
        SqlConnection Con = new SqlConnection("server=DESKTOP-GFGGUM9\\SQL; database=Farmacia; integrated security=true");
        ClassCliente op = new ClassCliente();
        public void Alert(string msg, Formularios.FormAlert.enmType type)
        {
            Formularios.FormAlert frm = new Formularios.FormAlert();
            frm.showAlert(msg, type);
        }
        private void BloquearCliente()
        {
            txtNomC.Enabled = false;
            txtApeC.Enabled = false;
            txtDni.Enabled = false;
            txtTel.Enabled = false;
        }
        private void DesbloquearCliente()
        {
            txtNomC.Enabled = true;
            txtApeC.Enabled = true;
            txtDni.Enabled = true;
            txtTel.Enabled = true;
        }
        private void DisminuirCantidad()
        {
            try
            {
                int NewCant = Stock - Convert.ToInt32(txtC.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("update TblMedicamentos set CantMed=@CM where NumMed=@NKey", Con);
                cmd.Parameters.AddWithValue("@CM", NewCant);
                cmd.Parameters.AddWithValue("@NKey", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicamento actualizado");
                Con.Close();
                ShowMed();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0, Stock;
        int NumMed, PrecioMed, CantMed, TotalMed;

        int pos = 60;
        private void ShowMed()
        {
            Con.Open();
            string Query = "select NumMed,NomMed,TipoMed,CantMed,PrecioMed from TblMedicamentos";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DgvMedicamentos.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ShowFact()
        {
            Con.Open();
            string Query = "select * from TblFactura where NomVen='" + lblNomVen.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DgvTrans.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void GuardarCuentas()
        {

            Con.Open();
            ContFact();

            foreach (DataGridViewRow row in DgvCuenta.Rows)
            {


                SqlCommand cmd = new SqlCommand("insert into TblCuentas(NumFact,NomVen,NomMed,CantMed,PrecioMed,TotalCuenta)values(@NF,@NV,@NM,@CM,@PM,@TC)", Con);
                cmd.Parameters.AddWithValue("@NF", ContVentas);
                cmd.Parameters.AddWithValue("@NV", lblNomVen.Text);
                cmd.Parameters.AddWithValue("@NM", (string)row.Cells[1].Value);
                cmd.Parameters.AddWithValue("@CM", Convert.ToInt32(row.Cells[2].Value));
                cmd.Parameters.AddWithValue("@PM", Convert.ToInt32(row.Cells[3].Value));
                cmd.Parameters.AddWithValue("@TC", Convert.ToInt32(row.Cells[4].Value));
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            MessageBox.Show("Detalles de venta guardada.");
        
        }


        int ContVentas;
        private void ContFact()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from TblFactura", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ContVentas = (int)dt.Rows[0][0];
            Con.Close();
        }
        private void RegistrarCliente()
        {
            try
            {
                TblCliente cl = new TblCliente();
                cl.NomCliente = txtNomC.Text;
                cl.ApeCliente = txtApeC.Text;
                cl.TelCliente = txtTel.Text;
                cl.CedCliente = txtDni.Text;
                cl.TotalComp = GrdTotal;


                if (op.Guardar(cl) == true)
                {

                    this.Alert("¡Registrado Correctamente!", FormAlert.enmType.Success);
                    txtNomC.Text = "";
                    txtApeC.Text = "";
                    txtTel.Text = "";
                    txtDni.Text = "";


                }
                else
                {
                    this.Alert("¡Error al registrar!", FormAlert.enmType.Error);
                }
                ShowFact();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void InsertarFactura()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TblFactura(NomVen,NomCliente,ApeCliente,TelCliente,CedCliente,FactFecha,FactCantidad)values(@NV,@NC,@AC,@TC,@CC,@FF,@FC)", Con);
                cmd.Parameters.AddWithValue("@NV", lblNomVen.Text);
                cmd.Parameters.AddWithValue("@NC", txtNomC.Text);
                cmd.Parameters.AddWithValue("@AC", txtApeC.Text);
                cmd.Parameters.AddWithValue("@TC", txtTel.Text);
                cmd.Parameters.AddWithValue("@CC", txtDni.Text);
                cmd.Parameters.AddWithValue("@FF", DateTime.Today.Date);
                cmd.Parameters.AddWithValue("@FC", GrdTotal);
                cmd.ExecuteNonQuery();
                this.Alert("¡Registrado Correctamente!", FormAlert.enmType.Success);
                ShowFact();
                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        bool encontrado = false;
        private void ActualizarTotalCliente()
        {
            int totalCliente = 0;

            Con.Open();
            String Query = "select TotalComp from TblCliente where CedCliente='" + txtDni.Text + "'";
            SqlCommand cmd1 = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                totalCliente = (int)dr["TotalComp"];
            }

            totalCliente += GrdTotal;
            SqlCommand cmd = new SqlCommand("update TblCliente set TotalComp=@TC where CedCliente=@CC", Con);
            cmd.Parameters.AddWithValue("@TC", totalCliente);
            cmd.Parameters.AddWithValue("@CC", txtDni.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Total del cliente actualizado.");
            Con.Close();
        }
        private void ActualizarTelefonoCliente()
        {
            string telCliente = "";

            Con.Open();
            String Query = "select TelCliente from TblCliente where CedCliente='" + txtDni.Text + "'";
            SqlCommand cmd1 = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                telCliente = (string)dr["TelCliente"];
            }

            if (telCliente != txtTel.Text)
            {
                SqlCommand cmd = new SqlCommand("update TblCliente set TelCliente=@TC where CedCliente=@CC", Con);
                cmd.Parameters.AddWithValue("@TC", txtTel.Text);
                cmd.Parameters.AddWithValue("@CC", txtDni.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teléfono del cliente actualizado.");
            }
            Con.Close();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (GrdTotal == 0)
            {
                MessageBox.Show("La cuenta está vacía, porfavor proceder con su llenado.");
            }
            else
            {
                InsertarFactura();
                GuardarCuentas();

                if (encontrado == true)
                {
                    ActualizarTotalCliente();
                    ActualizarTelefonoCliente();
                    encontrado = false;
                }
                else
                {
                    RegistrarCliente();
                }

                DesbloquearCliente();
                ContCuenta = 0;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }
        String Med = "";
        int Cant_Temporal;

        private void DgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomMedi.Text = DgvMedicamentos.SelectedRows[0].Cells[1].Value.ToString();
            //TipMedCb.SelectedItem = DGVMedicamentos.SelectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(DgvMedicamentos.SelectedRows[0].Cells[3].Value.ToString());
            txtPrecio.Text = DgvMedicamentos.SelectedRows[0].Cells[4].Value.ToString();
            //FabMedCb.SelectedValue = DGVMedicamentos.SelectedRows[0].Cells[5].Value.ToString();
            //FabMedTb.Text = DGVMedicamentos.SelectedRows[0].Cells[6].Value.ToString();
            if (txtNomMedi.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DgvMedicamentos.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        string NomMed;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Farmacia Angie", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID Medicamento Precio Cantidad Total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(16, 40));
            foreach (DataGridViewRow row in DgvCuenta.Rows)
            {
                NumMed = Convert.ToInt32(row.Cells["Column1"].Value);
                NomMed = "" + row.Cells["Column2"].Value;
                PrecioMed = Convert.ToInt32(row.Cells["Column3"].Value);
                CantMed = Convert.ToInt32(row.Cells["Column4"].Value);
                TotalMed = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + NumMed, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(16, pos));
                e.Graphics.DrawString("" + NomMed, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(35, pos));
                e.Graphics.DrawString("" + PrecioMed, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(150, pos));
                e.Graphics.DrawString("" + CantMed, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(200, pos));
                e.Graphics.DrawString("" + TotalMed, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(250, pos));
                pos += 20;
            }
            e.Graphics.DrawString("Total final:C$ " + GrdTotal, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(80, pos + 50));
            e.Graphics.DrawString("*********Farmacia Angie*********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(35, pos + 85));
            DgvCuenta.Rows.Clear();
            DgvCuenta.Refresh();
            pos = 100;
            GrdTotal = 0;
            TotalLbl.Text = "C$ " + GrdTotal;
            n = 0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int n = 0, GrdTotal = 0;

        private void btnValidarDni_Click(object sender, EventArgs e)
        {

            ResetCedula();

            Con.Open();
            string Query = "select NomCliente,ApeCliente,TelCLiente from TblCliente where CedCliente='" + txtDni.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNomC.Text = reader.GetString(0);
                txtApeC.Text = reader.GetString(1);
                 txtTel.Text = reader.GetString(2);
            }
            encontrado = true;
            Con.Close();
        }
        private void ResetCedula()
        {
           txtNomC.Text = "";
           txtApeC.Text = "";
           txtTel.Text = "";
        }
        int ContCuenta = 0;

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtC.Text == "" || Convert.ToInt32(txtC.Text) > Stock || txtC.Text == "0")
            {
                MessageBox.Show("Ingrese la cantidad correcta");
            }
            else
            {
                int total = Convert.ToInt32(txtC.Text) * Convert.ToInt32(txtPrecio.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DgvCuenta);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtNomMedi.Text;
                newRow.Cells[2].Value = txtC.Text;
                newRow.Cells[3].Value = txtPrecio.Text;
                newRow.Cells[4].Value = total;
                DgvCuenta.Rows.Add(newRow);
                GrdTotal += total;
                TotalLbl.Text = "C$ " + GrdTotal;
                n++;
                ContCuenta++;
            }
            if (ContCuenta > 0)
            {
                BloquearCliente();
            }
            DisminuirCantidad();
            txtC.Text = "";
            txtPrecio.Text = "";
            txtNomMedi.Text = "";
        }

       
      

        private void FormFactura_Load(object sender, EventArgs e)
        {
            ShowMed();
            ShowFact();
           
        }
    }
}
