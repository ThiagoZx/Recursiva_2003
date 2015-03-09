using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double result = 1;

        public string Interactive_function(double valor) 
        {
            double result = 1;

            if (valor == 0) { return "0"; }

            for (double i = 0; i < valor; i++) 
            { 
                result *= valor - i;
            }

            return Convert.ToString(result);
        }

        public double Recursive_function( double valor) {

            if (valor == 0) { return 0; }
            if (valor <= 1) { return result; }

            result *= valor;
            valor = valor - 1;
            
            return Recursive_function(valor);
        }
        

        private void Interactive_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Result_box.Text = Interactive_function(a);
        }

        private void Recursive_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            result = 1;
            Result_box.Text = Convert.ToString(Recursive_function(a));
        }

    }
}
