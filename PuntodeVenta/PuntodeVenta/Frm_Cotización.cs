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
    public partial class Frm_Cotización : Form
    {
        public Frm_Cotización()
        {
            InitializeComponent();
        }

        private void comboNombreCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = "Select * from ClienteTB where Nombre ='" + comboNombreCli.Text + "' ";

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                //MessageBox.Show("El registro se a encontrado");

                //txt_nombre.Text = leer["Nombre"].ToString();
                txt_rfc.Text = leer["RFC"].ToString();
                txt_direccion.Text = leer["Direccion"].ToString();
                txt_telefono.Text = leer["Telefono"].ToString();
                txt_email.Text = leer["Email"].ToString();
                //this.datefechacliente.Text = leer["FechaCliente"].ToString();
                //lbl_con.Text = leer["Id"].ToString();

                //comInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //comInfo.AutoCompleteSource = AutoCompleteSource.ListItems; 

            }
            else
            {
                //MessageBox.Show("No se encontro");

                //txt_nombre.Text = "";
                txt_rfc.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
            }
            cnn.Close();
        }

        private void Frm_Cotización_Load(object sender, EventArgs e)
        {
            ConexionItem cliente = new ConexionItem();
            cliente.ItemCliente(comboNombreCli);
            cliente.ItemProducto(comboProducto);

            panelcolor.BackColor = Color.FromArgb(90, Color.Black);
        }

        private void comboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = "Select * from ProductoTB where Producto ='" + comboProducto.Text + "' ";

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                //MessageBox.Show("El registro se a encontrado");

                //txt_nombre.Text = leer["Nombre"].ToString();
                txt_conCant.Text = leer["Cantidad"].ToString();
                txt_valorU.Text = leer["Precio"].ToString();
                txt_Precio.Text = leer["Precio"].ToString();
                //txt_email.Text = leer["Email"].ToString();
                //this.datefechacliente.Text = leer["FechaCliente"].ToString();
                txt_idP.Text = leer["Id"].ToString();

                //comInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //comInfo.AutoCompleteSource = AutoCompleteSource.ListItems; 

            }
            else
            {
                //MessageBox.Show("No se encontro");
                //numericCont.Value = 1;
                //txt_nombre.Text = "";
                txt_conCant.Text = "...";
                txt_valorU.Text = "";
                //txt_telefono.Text = "";
                //txt_email.Text = "";
            }
            cnn.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                cnn.Open();
                com.Connection = cnn;
                com.CommandText = "insert into VentasTemporalesTB (Producto, Cantidad, Precio) VALUES ('" + comboProducto.Text + "','" + numericCont.Value + "','" + txt_valorU.Text + "')";
                com.ExecuteNonQuery();
                //MessageBox.Show("Cliente guardado exitosamente");
                cnn.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("No se pudo guardar " + ex);
            }

            try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                cnn.Open();
                com.Connection = cnn;
                string query = "select Producto, Cantidad, Precio from VentasTemporalesTB";
                com.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataMostrarInfo.DataSource = dt;
                com.Clone();
                cnn.Close();
            }
            catch (Exception ex)
            {
                //connection.Close();
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }

            try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                cnn.Open();
                com.Connection = cnn;
                //string IdProducto = Convert.ToString(txtIdProducto.Text);
                com.CommandText = "insert into DetalleVentaTB (Cantidad, Precio) VALUES ('" + numericCont.Text + "','" + txt_valorU.Text + "')";
                com.ExecuteNonQuery();
                MessageBox.Show("Venta guardada exitosamente");
                cnn.Close();
            }
            catch (Exception ex)
            {
                //connection.Close();
                MessageBox.Show("error " + ex);
            }

            double subtotal = 0;
            double iva = 0;

            foreach (DataGridViewRow row in dataMostrarInfo.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["Precio"].Value);
            }
            txt_subtotal.Text = Convert.ToString(subtotal);

            if (checkB_iva.Checked == true)
            {
                iva += Convert.ToDouble(subtotal * 0.16);
                txt_total.Text = Convert.ToString(iva + subtotal);
            }
            else
            {
                txt_total.Text = Convert.ToString(subtotal);
            }
        }

        private void checkB_iva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_iva.Checked == false)
            {
                double subtotal = Convert.ToDouble(txt_subtotal.Text);
                txt_iva.Text = "0";
                txt_total.Text = Convert.ToString(subtotal);
            }
            else if (txt_subtotal.Text != "")
            {
                double subtotal = Convert.ToDouble(txt_subtotal.Text);
                double iva = 0;
                txt_iva.Text = "16";
                iva += Convert.ToDouble(subtotal * 0.16);
                txt_total.Text = Convert.ToString(iva + subtotal);
            }
            else
            {
                txt_iva.Text = "16";
            }
        }

        private void numericCont_ValueChanged(object sender, EventArgs e)
        {
            double Precio = Convert.ToDouble(txt_Precio.Text);
            int Cantidad = Convert.ToInt32(txt_conCant.Text);
            double P_unitario = Convert.ToDouble(txt_valorU.Text);

            txt_conCant.Text = Convert.ToString(numericCont.Value);

            Cantidad = Cantidad + 1;

            if (numericCont.Value < Cantidad)
            {
                P_unitario = P_unitario - Precio;
                txt_valorU.Text = Convert.ToString(P_unitario);
            }
            else if (numericCont.Value > 1)
            {
                P_unitario = P_unitario + Precio;
                txt_valorU.Text = Convert.ToString(P_unitario);
                Cantidad = Cantidad - 1;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                cnn.Open();
                com.CommandText = "INSERT INTO CotizacionTB (Nombre, RFC, Telefono, Email, Direccion, Fecha, Producto, Cantidad, PrecioUnitario, SubTotal, Total) values ('" + comboNombreCli.Text + "','" + txt_rfc.Text + "','" + txt_telefono.Text + "','" + txt_email.Text + "','" + txt_direccion.Text + "','" + dateFecha.Value.Date + "','" + comboProducto.Text + "','" + numericCont.Text + "','" + txt_valorU.Text + "','" + txt_subtotal.Text + "','" + txt_total.Text + "')";
                com.Connection = cnn;

                com.ExecuteNonQuery();
                MessageBox.Show("Guardado exitoso");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas " + ex);
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Frm_Menu from = new Frm_Menu();
            from.Show();
            this.Close();
        }

        private void panelcolor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
