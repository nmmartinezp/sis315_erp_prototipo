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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

    

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmProductosyVentas FrmProductosyVentas = new FrmProductosyVentas();
            this.Hide();
            FrmProductosyVentas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmIniciarSesionADM FrmIniciarSesionADM = new FrmIniciarSesionADM();
            this.Hide();
            FrmIniciarSesionADM.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmListadeClientes frmListadeClientes = new FrmListadeClientes();
            this.Hide();
            frmListadeClientes.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            this.Hide();
            frmInventario.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmInforme FrmInforme = new FrmInforme();
            this.Hide();
            FrmInforme.Show();
        }
    }
}
