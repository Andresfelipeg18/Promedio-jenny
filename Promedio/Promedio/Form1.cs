using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, promedio;
            string condicion;

            nota1 = double.Parse(txtnota1.Text);
            nota2 = double.Parse(txtnota2.Text);
            nota3 = double.Parse(txtnota3.Text);

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio < 3) 
            {
                condicion = "DESAPROBADO";
                txtpromedio.Text = promedio.ToString("N1");
                txtcondicion.Text = condicion;
            }else if (promedio > 3 && promedio<=5) 
            {
                condicion = "APROBADO";
                txtpromedio.Text = promedio.ToString("N1");
                txtcondicion.Text = condicion;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtcondicion.Clear();
            txtpromedio.Clear();
            txtnota1.Focus();
        }
    }
}
