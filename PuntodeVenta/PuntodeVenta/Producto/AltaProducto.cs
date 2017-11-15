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
    }
}
