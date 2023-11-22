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
    public partial class FrmNuevoEmpleado : Form
    {
        public FrmNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEmpleados FrmEmpleados = new FrmEmpleados();
            this.Hide();
            FrmEmpleados.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleados Emple = new FrmEmpleados();
            Emple.label3.Text = this.txtRFname.Text;
            Emple.label4.Text = this.comboBox1.Text;
            Emple.label5.Text = this.textBox1.Text;
            Emple.label7.Text = this.txtPhone.Text;
            Emple.Show();
        }
    }
}
