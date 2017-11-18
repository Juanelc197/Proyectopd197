using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta.Producto
{
    public partial class Menu_Producto : Form
    {
        public Menu_Producto()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Frm_Menu from = new Frm_Menu();
            from.Show();
            this.Close();
        }

        private void btn_altaproducto_Click(object sender, EventArgs e)
        {
            AltaProducto from = new AltaProducto();
            from.Show();
            this.Close();
        }

        private void btn_consultaproducto_Click(object sender, EventArgs e)
        {
            ConsultaProductos from = new ConsultaProductos();
            from.Show();
            this.Close();
        }

        private void Menu_Producto_Load(object sender, EventArgs e)
        {
            panelcolor.BackColor = Color.FromArgb(90, Color.Black);
        }
    }
}
