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

namespace PuntodeVenta.Producto
{
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Menu_Producto from = new Menu_Producto();
            from.Show();
            this.Close();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Frm_Menu from = new Frm_Menu();
            from.Show();
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();
            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
            cnn.Open();
            com.CommandText = "INSERT INTO ProductoTB (Producto, Descripcion, Cantidad, Precio) values ('" + txt_producto.Text + "','" + txt_descripcion.Text + "','" + txt_cantidad.Text + "','" + txt_precio.Text +"')";
            com.Connection = cnn;

            com.ExecuteNonQuery();
            MessageBox.Show("Guardado exitoso");
            cnn.Close();
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            panelcolor.BackColor = Color.FromArgb(90, Color.Black);
        }
    }
}
