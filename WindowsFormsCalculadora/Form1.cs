using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumero1.Select();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                int num1 = Convert.ToInt32(txtNumero1.Text);
                int num2 = Convert.ToInt32(txtNumero2.Text);
                int resultado1 = num1 / num2;
                txtRSTdivi.Text = resultado1.ToString();
                int resultado2 = num1 * num2;
                txtRSTmulti.Text = resultado2.ToString();
                int resultado3 = num1 - num2;
                txtRSTsub.Text = resultado3.ToString();
                int resultado4 = num1 + num2;
                txtRSTadi.Text = resultado4.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possivel resolver esse calculado. " + ex.Message.ToString());
                txtNumero2.Text = "";
                txtNumero2.Focus();
            }
        }
    }
}
