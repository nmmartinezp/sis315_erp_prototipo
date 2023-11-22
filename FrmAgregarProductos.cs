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
    public partial class FrmAgregarProductos : Form
    {
        public FrmAgregarProductos()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmProductosyVentas FrmProductosyVentas = new FrmProductosyVentas();
            this.Hide();
            FrmProductosyVentas.Show();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            FrmProductosyVentas prodcV = new FrmProductosyVentas();
            prodcV.label35.Text = this.cmbCategoria.Text;
            prodcV.label29.Text = this.txtNombre.Text;
            prodcV.label37.Text = this.txtDescripcion.Text;
            prodcV.label36.Text = this.txtPrecio.Text;
            prodcV.Show();

          
            prodcV.label12.Text = this.txtPrecio.Text;
            prodcV.label38.Text = this.txtNombre.Text;
        }
    }
}
