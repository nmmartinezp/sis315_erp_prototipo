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
    public partial class FrmListadeClientes : Form
    {
        public FrmListadeClientes()
        {
            InitializeComponent();
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente frmAgregarClient = new FrmAgregarCliente();
            this.Hide();
            frmAgregarClient.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            this.Hide();
            frmInicio.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            this.Hide();
            frmInicio.Show();
        }
    }
}
