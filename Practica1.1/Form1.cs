using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var num1 = 7;
            var num2 = 7;

            // Suma
            operaciones op = new operaciones();
            int resultado = op.suma(num1, num2);  

            // Resta
            operaciones opp = new operaciones();
            int resul = opp.resta(num1, num2);

            // Multiplicacion
            operaciones opera = new operaciones();
            double resu = opera.multi(num1, num2);
        
            // Division
            operaciones operaciones = new operaciones();
            double resulta = operaciones.division(num1, num2);

        }


    }
    class operaciones
    {
        // Suma
        public int suma (int a, int b)
        {
            int totalsuma = a + b;
            return totalsuma;
        }
        // Resta
        public int resta(int c, int d)
        {
            int totalresta = c - d;
            return totalresta;
        }
        // Multiplicacion
        public double multi(double e, double f)
        {
            double totalmulti = e * f;
            return totalmulti;
        }
        // Division
        public double division(double g, double h)
        {
            double totaldivision = g / h;
            return totaldivision;
        }
    }
}
