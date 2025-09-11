using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2=Convert.ToDouble(txtnum2.Text);

            double suma = num1 + num2;

            txtresultado.Text = suma.ToString();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2= Convert.ToDouble(txtnum2.Text);

            double resta = num1 - num2;

            txtresultado.Text = resta.ToString();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);

            double multilplicacion = num1 * num2;
            txtresultado.Text= multilplicacion.ToString();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);

            double division = num1 / num2;
            txtresultado.Text = division.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtresultado.Clear();
        }
    }
}
