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
    public partial class MuestraCoti : Form
    {
        public MuestraCoti()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Frm_Cotización from = new Frm_Cotización();
            from.Show();
            this.Close();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            OleDbDataReader dr;
            OleDbCommand com = new OleDbCommand();

            try
            {
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                com.Connection = cnn;
                cnn.Open();
                string query = "select Nombre, RFC, Telefono, Email, Direccion, Fecha, Producto, Cantidad, PrecioUnitario, SubTotal, Total  from CotizacionTB";
                com.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataverCot.DataSource = dt;

                com.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());
            }
        }
    }
}
