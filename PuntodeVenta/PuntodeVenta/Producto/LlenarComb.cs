using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta.Producto
{
    class LlenarComb
    {
        OleDbConnection cnn;
        OleDbCommand com;
        OleDbDataReader dr;

        public  LlenarComb()
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

        public void ItemLLenar(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("Select Producto from ProductoTB", cnn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Producto"].ToString());
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
