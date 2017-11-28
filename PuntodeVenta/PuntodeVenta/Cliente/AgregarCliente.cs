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
            cnn.Open();
            com.CommandText = "INSERT INTO ClienteTB (Nombre, RFC, Direccion, Telefono, Email) values ('" + txt_nombre.Text + "','" + txt_rfc.Text + "','"+ txt_direccion.Text + "','" + txt_telefono.Text + "','"+ txt_email.Text + "')";
            //com.CommandText = "INSERT INTO ClienteTB (FechaCliente) values (#' & this.datefechaCliente. & '#)";
            com.Connection = cnn;
             
            com.ExecuteNonQuery();
            MessageBox.Show("Guardado exitoso");
            cnn.Close(); 

            
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            panelcolor.BackColor = Color.FromArgb(90, Color.Black);
        }
    }
}
