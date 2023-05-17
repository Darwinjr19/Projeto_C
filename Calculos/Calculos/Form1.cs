using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {

            if (rbdSomar.Checked == true)
            {
                double r, v1, v2;

                v1 = double.Parse(txtValor1.Text);
                v2 = double.Parse(txtValor2.Text);

                r = v1 + v2;

                lblResult.Text = "A soma é: "+ r;
            }
            else if (rbdSubtrai.Checked == true)
            {

                double r, v1, v2;

                v1 = double.Parse(txtValor1.Text);
                v2 = double.Parse(txtValor2.Text);

                r = v1 - v2;

                lblResult.Text = "O resultado é: " + r;
            }
            else if (rbdMultiplica.Checked == true)
            {

                double r, v1, v2;

                v1 = double.Parse(txtValor1.Text);
                v2 = double.Parse(txtValor2.Text);

                r = v1 * v2;

                lblResult.Text = "O resultado é: " + r;
            }
            else if(rbdDivide.Checked == true)
            {

                double r, v1, v2;

                v1 = double.Parse(txtValor1.Text);
                v2 = double.Parse(txtValor2.Text);

                r = v1 / v2;

                lblResult.Text = "O resultado é: " + r;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbdSomar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
