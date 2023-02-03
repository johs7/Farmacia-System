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
using System.Globalization;
using System.Runtime.Remoting.Contexts;

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
        ClassCliente opCl = new ClassCliente();
        ClassFactura opFct=new ClassFactura();
        ClassCuentas opCuenta=new ClassCuentas();
        ClassMedicamentos opMed=new ClassMedicamentos();
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
        private bool TamañoMinimoTelefono()
        {
            if (TelCliTb.Text.Length < 8)
            {
                Error.SetError(TelCliTb, "Debe escribir el tamaño minimo de caracteres");
                return false;
            }
            else
            {
                Error.SetError(TelCliTb, "");
                return true;
            }
        }

        private bool ValidarNom()
        {
            if (string.IsNullOrEmpty(NomCliTb.Text))
            {
                Error.SetError(NomCliTb, "Debe Escribir El nombre del cliente");
                return false;
            }
            else
            {
                Error.SetError(NomCliTb, "");
                return true;
            }
        }
        private bool ValidarApe()
        {
            if (string.IsNullOrEmpty(ApeCliTb.Text))
            {
                Error.SetError(ApeCliTb, "Debe Escribir El apellido del cliente");
                return false;
            }
            else
            {
                Error.SetError(ApeCliTb, "");
                return true;
            }
        }
        private bool ValidarTel()
        {
            if (string.IsNullOrEmpty(TelCliTb.Text))
            {
                Error.SetError(TelCliTb, "Debe Escribir El telefono del cliente");
                return false;
            }
            else
            {
                Error.SetError(TelCliTb, "");
                return true;
            }
        }
        private bool ValidarCant()
        {
            if (string.IsNullOrEmpty(CantMedTb.Text))
            {
                Error.SetError(CantMedTb, "Debe Escribir la cantidad de medicamentos");
                return false;
            }
            else
            {
                Error.SetError(CantMedTb, "");
                return true;
            }
        }
        private bool ValidarCedula()
        {
            if (string.IsNullOrEmpty(CedCliTb.Text))
            {
                Error.SetError(CedCliTb, "Debe Escribir la cedula del cliente");
                return false;
            }
            else
            {
                Error.SetError(CedCliTb, "");
                return true;
            }
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
            List<TblMedicamentos> listaMedicamentos = opMed.Listar();
            DGVMedicamentos.DataSource = listaMedicamentos;
        }
      
        private void ShowFact()
        {
            var result = opFct.Listar().Where(f => f.NomVen == lblNomVen.Text);
            DGVTransacciones.DataSource = result.ToList();
        }
        private void GuardarCuentas()
        {
            ContFact();

      

            foreach (DataGridViewRow row in DGVCuenta.Rows)
            {

                TblCuentas cuent=new TblCuentas();
                cuent.NumFact = ContVentas;
                cuent.NomVen = lblNomVen.Text;
                cuent.NomMed = Convert.ToString(row.Cells[1].Value);
                cuent.CantMed = Convert.ToInt32(row.Cells[2].Value);
                cuent.PrecioMed=Convert.ToInt32(row.Cells[3].Value);
                cuent.TotalCuenta = Convert.ToInt32(row.Cells[4].Value);
                if (opCuenta.Guardar(cuent) == true)
                {

                    ShowFact();
                }
                else
                {

                }
            }
        }


        
       
        private void RegistrarCliente()
        {
          
            try
            {

                TblCliente cl = new TblCliente();
                cl.NomCliente = NomCliTb.Text;
                cl.ApeCliente = ApeCliTb.Text;
                cl.TelCliente = TelCliTb.Text;
                cl.CedCliente = CedCliTb.Text;
                cl.TotalComp = GrdTotal;
                if (opCl.Guardar(cl) == true)
                {

                    ShowFact();
                }
                else
                {

                }

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
                TblFactura fct = new TblFactura();
                fct.NomVen = lblNomVen.Text;
                fct.NomCliente = NomCliTb.Text;
                fct.ApeCliente = ApeCliTb.Text;
                fct.TelCliente = TelCliTb.Text;
                fct.CedCliente = CedCliTb.Text;
                fct.FactFecha = DateTime.Today.Date;
                fct.FactCantidad =  GrdTotal;
                if (opFct.Guardar(fct) == true)
                {
                   
                    ShowFact();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int ContVentas;
        private void ContFact()
        {
            opFct.ContarRegistros();
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
        /*using (FarmaciaEntities db = new FarmaciaEntities())
{
TblCliente cliente = db.TblCliente.FirstOrDefault(c => c.CedCliente == CedCliTb.Text);
cliente.TotalComp += GrdTotal;
db.SaveChanges();
MessageBox.Show("Total del cliente actualizado.");
}*/
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
                telCliente = Convert.ToString(dr["TelCliente"]);
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

        private void NomCliTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
           
        }

        private void ApeCliTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
         
        }

        private void TelCliTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void CantMedTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void CedCliTb_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void DGVMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NomMedTb.Text = DGVMedicamentos.SelectedRows[0].Cells[1].Value.ToString();

            Stock = Convert.ToInt32(DGVMedicamentos.SelectedRows[0].Cells[3].Value.ToString());
            PrecMedTb.Text = DGVMedicamentos.SelectedRows[0].Cells[4].Value.ToString();

            if (NomMedTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVMedicamentos.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CedCliTb_Validating(object sender, CancelEventArgs e)
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
                   /*Rivas*/ "561","562","563","564","565","566","567","568","569","570"
                   /*Boaco*/
                   /*Chontales*/
                   /*Jinotega*/
                   /*Matagalpa*/
                   /*RAAN*/
                   /*RAAS*/
                   /*RIO SAN JUAN*/
                };

                string cedula = CedCliTb.Text.Trim();
                // Verifica si la longitud es correcta
                if (cedula.Length != 16)
                {
                    Error.SetError(CedCliTb, "La cédula debe tener 16 caracteres.");
                    e.Cancel = true;
                    return;
                }

                // Verifica si los guiones están en las posiciones correctas
                if (cedula[3] != '-' || cedula[10] != '-')
                {
                    Error.SetError(CedCliTb, "Los guiones deben estar en las posiciones 4 y 11.");
                    e.Cancel = true;
                    return;
                }

                // Verifica si el primer tres digitos es una combinación válida
                string firstThree = cedula.Substring(0, 3);
                if (!validCombinations.Contains(firstThree))
                {
                    Error.SetError(CedCliTb, "Los primeros 3 dígitos no son válidos.");
                    e.Cancel = true;
                    return;
                }

                // Verifica si los siguientes 6 digitos es una fecha válida
                string dateString = cedula.Substring(4, 6);
                DateTime date;
                if (!DateTime.TryParseExact(dateString, "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Error.SetError(CedCliTb, "Los siguientes 6 dígitos no son una fecha válida.");
                    e.Cancel = true;
                    return;
                }

                // Verifica si la persona es mayor de 16 años
                if (DateTime.Now.Subtract(date).TotalDays / 365 < 16)
                {
                    Error.SetError(CedCliTb, "La persona debe ser mayor de 16 años.");
                    e.Cancel = true;

                    return;
                }

                // Verifica si el último dígito es una letra
                char lastChar = cedula[15];
                if (!char.IsLetter(lastChar))
                {
                    Error.SetError(CedCliTb, "El último caracter debe ser una letra.");
                    e.Cancel = true;
                    return;
                }

                // Si todas las validaciones pasaron, elimina el error
                Error.SetError(CedCliTb, "");
                e.Cancel = false;
            }
        }

        private void NomCliTb_TextChanged(object sender, EventArgs e)
        {
            NomCliTb.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(NomCliTb.Text);
            NomCliTb.SelectionStart = NomCliTb.Text.Length;
        }

        private void ApeCliTb_TextChanged(object sender, EventArgs e)
        {
            ApeCliTb.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ApeCliTb.Text);
            ApeCliTb.SelectionStart = ApeCliTb.Text.Length;
        }

        private void CedCliTb_TextChanged(object sender, EventArgs e)
        {
            CedCliTb.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CedCliTb.Text);
            CedCliTb.SelectionStart = CedCliTb.Text.Length;
        }

        private void DGVTransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int n = 0, GrdTotal = 0;
        int ContCuenta = 0;
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarNom() == false)
            { return; }
            if (ValidarApe() == false)
            { return; }
            if (ValidarCedula() == false)
            { return; }
            if(ValidarCant()==false)
            { return; }
            if(ValidarTel() == false)
            { return; }

            else
            {
                if (CantMedTb.Text == "" || Convert.ToInt32(CantMedTb.Text) > Stock || CantMedTb.Text == "0")
                {
                    this.Alert("¡Cantidad incorrecta!", FormAlert.enmType.Error);
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
