using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ConexionItem
    {
        OleDbConnection cnn;
        OleDbCommand com;
        OleDbDataReader dr;

        public ConexionItem()
        {
            try
            {
                cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto: " + ex.ToString());
            }
        }

        public void ItemCliente(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("Select Nombre from ClienteTB", cnn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                }
                //cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno correctamente: " + ex.ToString());
            }
        }

        public void ItemProducto(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("Select Producto from ProductoTB", cnn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Producto"].ToString());
                    //cb.Items.Add(dr["Cantidad"].ToString());
                }
                //cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno correctamente: " + ex.ToString());
            }
        }

        public void ItemCotizacion(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("Select RFC from CotizacionTB", cnn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["RFC"].ToString());
                    //cb.Items.Add(dr["Cantidad"].ToString());
                }
                //cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno correctamente: " + ex.ToString());
            }
        }

        public void ItemCotizacionid(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("Select IdCo from CotizacionTB", cnn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["IdCo"].ToString());
                    //cb.Items.Add(dr["Cantidad"].ToString());
                }
                //cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno correctamente: " + ex.ToString());
            }
        }

        public void ItemNombreVenta(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("Select Nombre from VentaTB", cnn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                    //cb.Items.Add(dr["Cantidad"].ToString());
                }
                //cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno correctamente: " + ex.ToString());
            }
        }
    }
}
