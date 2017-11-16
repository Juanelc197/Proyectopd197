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

namespace PuntodeVenta.Cliente
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Frm_Menu from = new Frm_Menu();
            from.Show();
            this.Close();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Menu_Cliente from = new Menu_Cliente();
            from.Show();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cadena = "Select * from ClienteTB where Nombre ='" + comboClient.Text + "' ";

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                //MessageBox.Show("El registro se a encontrado");

                txt_nombre.Text = leer["Nombre"].ToString();
                txt_rfc.Text = leer["RFC"].ToString();
                txt_direccion.Text = leer["Direccion"].ToString();
                txt_telefono.Text = leer["Telefono"].ToString();
                txt_email.Text = leer["Email"].ToString();
                this.datefechacliente.Text = leer["FechaCliente"].ToString();
                lbl_con.Text = leer["Id"].ToString();

                //comInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //comInfo.AutoCompleteSource = AutoCompleteSource.ListItems; 

            }
            else
            {
                //MessageBox.Show("No se encontro");

                txt_nombre.Text = "";
                txt_rfc.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
            }
            cnn.Close();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();

            cmd.Connection = con;
            String query = "Delete from ClienteTB where Id=" + lbl_con.Text;
            cmd.CommandText = @query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Eliminado :D");
            con.Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("update ClienteTB set Nombre= @nombre, RFC= @rfc, Direccion= @direccion, Telefono= @telefono, Email= @email, FechaCliente= @fechac where Id = @id", con);

                cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                cmd.Parameters.AddWithValue("@rfc", txt_rfc.Text);
                cmd.Parameters.AddWithValue("@direccion", txt_direccion.Text);
                cmd.Parameters.AddWithValue("@telefono", txt_telefono.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@fechac", this.datefechacliente.Text);
                cmd.Parameters.AddWithValue("@id", lbl_con.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Completado");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            LlenarConex c = new LlenarConex();

            c.ItemLLenar(comboClient);
        }
    }
}
