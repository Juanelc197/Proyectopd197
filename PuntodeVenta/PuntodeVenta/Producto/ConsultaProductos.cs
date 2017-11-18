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
    public partial class ConsultaProductos : Form
    {
        public ConsultaProductos()
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cadena = "Select * from ProductoTB where Producto ='" + combProductos.Text + "' ";

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                //MessageBox.Show("El registro se a encontrado");

                txt_producto.Text = leer["Producto"].ToString();
                txt_descripcion.Text = leer["Descripcion"].ToString();
                txt_cantidad.Text = leer["Cantidad"].ToString();
                txt_precio.Text = leer["Precio"].ToString();
                lbl_cont.Text = leer["Id"].ToString();


                //comInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //comInfo.AutoCompleteSource = AutoCompleteSource.ListItems; 

            }
            else
            {
                //MessageBox.Show("No se encontro");

                txt_producto.Text = "";
                txt_descripcion.Text = "";
                txt_cantidad.Text = "";
                txt_precio.Text = "";
                
            }
            cnn.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("update ProductoTB set Producto= @producto, Descripcion= @descripcion, Cantidad= @cantidad, Precio= @precio where Id = @id", con);

                cmd.Parameters.AddWithValue("@producto", txt_producto.Text);
                cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                cmd.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                cmd.Parameters.AddWithValue("@precio", txt_precio.Text);
                
                cmd.Parameters.AddWithValue("@id", lbl_cont.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Completado");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();

            cmd.Connection = con;
            String query = "Delete from ProductoTB where Id=" + lbl_cont.Text;
            cmd.CommandText = @query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Eliminado :D");
            con.Close();
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            LlenarComb c = new LlenarComb();
            c.ItemLLenar(combProductos);

            panelcolor.BackColor = Color.FromArgb(90, Color.Black);
        }

        private void btn_verdatos_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();

            try
            {
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                com.Connection = cnn;
                cnn.Open();
                string query = "select Producto, Descripcion, Cantidad, Precio from ProductoTB";
                com.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataverproductos.DataSource = dt;

                com.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());
            }
        }
    }
}
