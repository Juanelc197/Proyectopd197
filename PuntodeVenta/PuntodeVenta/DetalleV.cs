using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    public partial class DetalleV : Form
    {
        public DetalleV()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Frm_Menu from = new Frm_Menu();
            from.Show();
            this.Close();
        }

        private void DetalleV_Load(object sender, EventArgs e)
        {
            panelcolor.BackColor = Color.FromArgb(90, Color.Black);
        }

        private void monthAntes_DateChanged(object sender, DateRangeEventArgs e)
        {
            //lbl_Antes.Text = 
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            //string fecha;
            //txt_Antes.Text = monthAntes.SelectionRange.Start.ToString("dd/MM/yyyy");

            //lbl_Despues.Text = monthAntes.SelectionRange.Start.ToString("dd/MM/yyyy");

            //fecha = Convert.ToString(txt_Antes);

         /*   try
            {
                OleDbDataReader dr;
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                com.Connection = cnn;
                cnn.Open();
                string query = "select Nombre, RFC, Email from CotizacionTB where Fecha ='" + monthAntes.MinDate + "' ";
                com.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataMostrarDatos.DataSource = dt;

                com.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());
            } */

        }
    }
}
