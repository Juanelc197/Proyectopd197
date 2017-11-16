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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();
             OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");

             com.CommandText = "INSERT INTO ClienteTB (Nombre, RFC, Direccion, Telefono, E-mail) values ('" + txt_nombre.Text + "','" + txt_rfc.Text + "','"+ txt_direccion.Text + "','" + txt_telefono.Text + "','"+ txt_email.Text + "')";
             com.Connection = cnn;
             cnn.Open();
             com.ExecuteNonQuery();
             MessageBox.Show("Guardado exitoso");
             cnn.Close(); 

            /*  try
              {

                  OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EjemProyec.accdb");
                  //con.Open();
                  OleDbCommand cmd = new OleDbCommand("Insert into ClienteTB (Nombre, RFC, Direccion, Telefono, E-mail)" + "Values (@Nombre, @RFC, @Direccion, @Telefono, @E-mail)", con);

                  cmd.CommandText = "INSERT INTO ClienteTB (Nombre, RFC, Direccion, Telefono, E-mail) values ('" + txt_nombre.Text + "','" + txt_rfc.Text + "','" + txt_direccion.Text + "','" + txt_telefono.Text + "','" + txt_email.Text + "')";
                  cmd.Connection = con;
                  con.Open();
                  //cmd.CommandText = "Insert into ClienteTB (Nombre, RFC, Direccion, Telefono, E-mail)" + "Values (@Nombre, @RFC, @Direccion, @Telefono, @E-mail)";
                  /* cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text);
                   cmd.Parameters.AddWithValue("@RFC", txt_rfc.Text);
                   cmd.Parameters.AddWithValue("@Direccion", txt_direccion.Text);
                   cmd.Parameters.AddWithValue("@Telefono", txt_telefono.Text);
                   cmd.Parameters.AddWithValue("@E-mail", txt_email.Text); 

                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Completado");
                  con.Close();
              }
              catch
              {
                  MessageBox.Show("Error");
              } */
        }
    }
}
