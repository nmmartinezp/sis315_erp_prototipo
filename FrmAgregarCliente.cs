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
    public partial class FrmAgregarCliente : Form
    {
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmListadeClientes ListaClientes = new FrmListadeClientes();
            ListaClientes.nombre.Text = this.txtNombre.Text;
            ListaClientes.ci.Text = this.txtCI.Text;
            ListaClientes.tel.Text = this.txtTelefono.Text;
            ListaClientes.direc.Text = this.txtDireccion.Text;
            ListaClientes.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            FrmListadeClientes frmListadeClientes = new FrmListadeClientes();
            this.Hide();
            frmListadeClientes.Show();
        }
    }
}
