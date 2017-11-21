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
    public partial class DetalleV : Form
    {
        public DetalleV()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Frm_Menu from = new Frm_Menu();
            from.Show();
            this.Close();
        }

        private void DetalleV_Load(object sender, EventArgs e)
        {
            panelcolor.BackColor = Color.FromArgb(90, Color.Black);
        }
    }
}
