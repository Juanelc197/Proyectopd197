using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta.Cliente
{
    public partial class Menu_Cliente : Form
    {
        public Menu_Cliente()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            AgregarCliente from = new AgregarCliente();
            from.Show();
            this.Close();

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Frm_Menu from = new Frm_Menu();
            from.Show();
            this.Close();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            ConsultaCliente from = new ConsultaCliente();
            from.Show();
            this.Close();
        }
    }
}
