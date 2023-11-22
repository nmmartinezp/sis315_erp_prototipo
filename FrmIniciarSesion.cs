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
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(
                txtUsuario.Text=="usuario" && txtContraseña.Text=="123"
                )
            {
                FrmInicio FrmInicio = new FrmInicio();
                this.Hide();
                FrmInicio.Show();

            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        

        }
    }
}
