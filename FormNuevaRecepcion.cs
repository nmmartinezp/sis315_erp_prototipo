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
    public partial class FormNuevaRecepcion : Form
    {
        public FormNuevaRecepcion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInventario Inven = new FrmInventario();
            Inven.label6.Text = this.textBox1.Text;
            Inven.label4.Text = this.cmbCategoria.Text;
            Inven.label5.Text = this.txtRFname.Text;
            Inven.label7.Text = this.textBox2.Text;
            Inven.label8.Text = this.textBox3.Text;
            Inven.label9.Text = this.textBox4.Text;
            Inven.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            this.Hide();
            frmInventario.Show();
        }

        private void txtRFname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
