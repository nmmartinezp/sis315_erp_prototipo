using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROTIPO.ERP
{
    public partial class FrmProductosyVentas : Form
    {
        public FrmProductosyVentas()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarProductos FrmAgregarProductos = new FrmAgregarProductos();
            this.Hide();
            FrmAgregarProductos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnComplimentary_Click(object sender, EventArgs e)
        {
            FrmFactura FrmFactura = new FrmFactura();
            this.Hide();
            FrmFactura.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmFactura FrmFactura = new FrmFactura();
            this.Hide();
            FrmFactura.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmInicio FrmInicio = new FrmInicio();
            this.Hide();
            FrmInicio.Show();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            this.Hide();
            frmInicio.Show();
        }
    }
}



