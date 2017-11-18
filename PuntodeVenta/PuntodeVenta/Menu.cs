using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente.Menu_Cliente from = new Cliente.Menu_Cliente();
            from.Show();
        }

        private void btn_Producto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Producto.Menu_Producto from = new Producto.Menu_Producto();
            from.Show();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            panelcolor.BackColor = Color.FromArgb(90, Color.Black);
        }
    }
}
