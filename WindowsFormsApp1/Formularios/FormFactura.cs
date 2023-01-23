﻿using FontAwesome.Sharp;
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
            ShowMed();
            ShowFact();
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
            NomCliTb.Enabled = false;
            ApeCliTb.Enabled = false;
            CedCliTb.Enabled = false;
            TelCliTb.Enabled = false;
        }
        private void DesbloquearCliente()
        {
            NomCliTb.Enabled = true;
            ApeCliTb.Enabled = true;
            CedCliTb.Enabled = true;
            TelCliTb.Enabled = true;
        }
        int key = 0, Stock;
        int NumMed, PrecioMed, CantMed, TotalMed;
        private void DisminuirCantidad()
        {
           
            try
            {
                int NewCant = Stock - Convert.ToInt32(CantMedTb.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("update TblMedicamentos set CantMed=@CM where NumMed=@NKey", Con);
                cmd.Parameters.AddWithValue("@CM", NewCant);
                cmd.Parameters.AddWithValue("@NKey", key);
                cmd.ExecuteNonQuery();
                this.Alert("¡Registrado Correctamente!", FormAlert.enmType.Success);
                Con.Close();
                ShowMed();
            
            }
            catch
            {

                this.Alert("¡Error al registrar!", FormAlert.enmType.Error);
            }
       
        }
       

        int pos = 60;
        private void ShowMed()
        {
            Con.Open();
            string Query = "select NumMed,NomMed,TipoMed,CantMed,PrecioMed from TblMedicamentos";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVMedicamentos.DataSource = ds.Tables[0];
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
            DGVTransacciones.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void GuardarCuentas()
        {
            ContFact();
            Con.Open();
      

            foreach (DataGridViewRow row in DGVCuenta.Rows)
            {


                SqlCommand cmd = new SqlCommand("insert into TblCuentas(NumFact,NomVen,NomMed,CantMed,PrecioMed,TotalCuenta)values(@NF,@NV,@NM,@CM,@PM,@TC)", Con);
                cmd.Parameters.AddWithValue("@NF", ContVentas);
                cmd.Parameters.AddWithValue("@NV", lblNomVen.Text);
                cmd.Parameters.AddWithValue("@NM", (string)row.Cells[1].Value);
                cmd.Parameters.AddWithValue("@CM", Convert.ToInt32(row.Cells[2].Value));
                cmd.Parameters.AddWithValue("@PM", Convert.ToInt32(row.Cells[3].Value));
                cmd.Parameters.AddWithValue("@TC", Convert.ToInt32(row.Cells[4].Value));
                cmd.ExecuteNonQuery();

            }
            MessageBox.Show("Detalles de venta guardada.");
            Con.Close();
        }


        
       
        private void RegistrarCliente()
        {


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TblCliente(NomCliente,ApeCliente,TelCliente,CedCliente,TotalComp)values(@NC,@AC,@TC,@CC,@TT)", Con);
                cmd.Parameters.AddWithValue("@NC", NomCliTb.Text);
                cmd.Parameters.AddWithValue("@AC", ApeCliTb.Text);
                cmd.Parameters.AddWithValue("@TC", TelCliTb.Text);
                cmd.Parameters.AddWithValue("@CC", CedCliTb.Text);
                cmd.Parameters.AddWithValue("@TT", GrdTotal);
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
        private void InsertarFactura()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TblFactura(NomVen,NomCliente,ApeCliente,TelCliente,CedCliente,FactFecha,FactCantidad)values(@NV,@NC,@AC,@TC,@CC,@FF,@FC)", Con);
                cmd.Parameters.AddWithValue("@NV", lblNomVen.Text);
                cmd.Parameters.AddWithValue("@NC", NomCliTb.Text);
                cmd.Parameters.AddWithValue("@AC", ApeCliTb.Text);
                cmd.Parameters.AddWithValue("@TC", TelCliTb.Text);
                cmd.Parameters.AddWithValue("@CC", CedCliTb.Text);
                cmd.Parameters.AddWithValue("@FF", DateTime.Today.Date);
                cmd.Parameters.AddWithValue("@FC", GrdTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Factura guardada");
                Con.Close();
                ShowFact();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
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
        bool encontrado = false;
        private void ActualizarTotalCliente()
        {
            int totalCliente = 0;

            Con.Open();
            String Query = "select TotalComp from TblCliente where CedCliente='" + CedCliTb.Text + "'";
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
            cmd.Parameters.AddWithValue("@CC", CedCliTb.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Total del cliente actualizado.");
            Con.Close();
        }
        private void ActualizarTelefonoCliente()
        {
            string telCliente = "";

            Con.Open();
            String Query = "select TelCliente from TblCliente where CedCliente='" + CedCliTb.Text + "'";
            SqlCommand cmd1 = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                telCliente = (string)dr["TelCliente"];
            }

            if (telCliente != TelCliTb.Text)
            {
                SqlCommand cmd = new SqlCommand("update TblCliente set TelCliente=@TC where CedCliente=@CC", Con);
                cmd.Parameters.AddWithValue("@TC", TelCliTb.Text);
                cmd.Parameters.AddWithValue("@CC", CedCliTb.Text);
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
            NomMedTb.Text = DGVMedicamentos.SelectedRows[0].Cells[1].Value.ToString();
            //TipMedCb.SelectedItem = DGVMedicamentos.SelectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(DGVMedicamentos.SelectedRows[0].Cells[3].Value.ToString());
            PrecMedTb.Text = DGVMedicamentos.SelectedRows[0].Cells[4].Value.ToString();
            //FabMedCb.SelectedValue = DGVMedicamentos.SelectedRows[0].Cells[5].Value.ToString();
            //FabMedTb.Text = DGVMedicamentos.SelectedRows[0].Cells[6].Value.ToString();
            if (NomMedTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVMedicamentos.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        string NomMed;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Farmacia Angie", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID Medicamento Precio Cantidad Total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(16, 40));
            foreach (DataGridViewRow row in DGVCuenta.Rows)
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
            DGVCuenta.Rows.Clear();
            DGVCuenta.Refresh();
            pos = 100;
            GrdTotal = 0;
            TotalLbl.Text = "C$ " + GrdTotal;
            n = 0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnValidarDni_Click(object sender, EventArgs e)
        {



            Con.Open();
            ResetCedula();
            string Query = "select NomCliente,ApeCliente,TelCLiente from TblCliente where CedCliente='" + CedCliTb.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                NomCliTb.Text = reader.GetString(0);
                ApeCliTb.Text = reader.GetString(1);
                TelCliTb.Text = reader.GetString(2);
            }
            encontrado = true;
            Con.Close();
        }
        private void ResetCedula()
        {
            NomCliTb.Text = "";
            ApeCliTb.Text = "";
            TelCliTb.Text = "";
        }
        int n = 0, GrdTotal = 0;
        int ContCuenta = 0;
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (NomCliTb.Text == "" || ApeCliTb.Text == "" || TelCliTb.Text == "" || CedCliTb.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos del cliente.");
            }
            else
            {
                if (CantMedTb.Text == "" || Convert.ToInt32(CantMedTb.Text) > Stock || CantMedTb.Text == "0")
                {
                    MessageBox.Show("Ingrese la cantidad correcta");
                }
                else
                {
                    int total = Convert.ToInt32(CantMedTb.Text) * Convert.ToInt32(PrecMedTb.Text);
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(DGVCuenta);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = NomMedTb.Text;
                    newRow.Cells[2].Value = CantMedTb.Text;
                    newRow.Cells[3].Value = PrecMedTb.Text;
                    newRow.Cells[4].Value = total;
                    DGVCuenta.Rows.Add(newRow);
                    GrdTotal += total;
                    TotalLbl.Text = "C$ " + GrdTotal;
                    n++;
                    ContCuenta++;
                    if (ContCuenta > 0)
                    {
                        BloquearCliente();
                    }
                    DisminuirCantidad();
                    CantMedTb.Text = "";
                    PrecMedTb.Text = "";
                    NomMedTb.Text = "";
                }
            }
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
          
           
        }
    }
}
