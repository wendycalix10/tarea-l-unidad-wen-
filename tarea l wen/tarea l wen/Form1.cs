using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_l_wen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(textBox1.Text);

            int result = numero / 2;

            if (result == 0)
            {
                textBox2.Text = "El numero ingresado es par y positivo";
            }

            else
            {
                textBox2.Text = "El numero ingresado es impar y positivo";
            }

            if (result > 0)
            {
                textBox2.Text = "El numero ingresado es positivo";

            }
            else
            {
                textBox2.Text = "El numero ingresado es negativo";
            }
        }
    }
}
