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
    public partial class FrmIniciarSesionADM : Form
    {
        public FrmIniciarSesionADM()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
                txtUsuarioADM.Text == "administrador" && txtContraseñaADM.Text == "contraseña"
                )
            {
                FrmEmpleados FrmEmpleados = new FrmEmpleados();
                this.Hide();
                FrmEmpleados.Show();

            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInicio FrmInicio = new FrmInicio();
            this.Hide();
            FrmInicio.Show();
        }
    }
}
