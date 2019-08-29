using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1._0
{
    public partial class Mostrar : Form
    {
        double Primero;
        double Segundo;
        string Operador;
        public Mostrar()
        {
            InitializeComponent();
        }
        Clases.Suma Procedimineto = new Clases.Suma();
        Clases.Resta Procedimineto2 = new Clases.Resta();
        Clases.Divicion Procedimineto3 = new Clases.Divicion();
        Clases.Multiplicacion Procedimineto4 = new Clases.Multiplicacion();
        Clases. Porcentaje Procedimiento5 = new Clases.Porcentaje();
        private void Form1_Load(object sender, EventArgs e)
        {

        }   

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number_0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void Number_1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void Number_2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void Number_3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void Number_4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void Number_5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void Number_6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void Number_7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void Number_8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void Number_9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            Operador = "+";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            Operador = "x";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Porcentaje_Click(object sender, EventArgs e)
        {
            Operador = "%";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }
        
        private void Resultado_Click(object sender, EventArgs e)
        {
            Segundo = double.Parse(Pantalla.Text);
            double Sumaa;
            double restaa;
            double multiplicacionn;
            double divicionn;
            double porcentajee;
            if (Operador == "+")
            {
               Sumaa = Procedimineto.Sum( (Primero), (Segundo));
                Pantalla.Text = Sumaa.ToString();
              
            }
            if (Operador == "-")
            {
                restaa = Procedimineto2.Restar((Primero), (Segundo));
                Pantalla.Text = restaa.ToString();

            }
            if (Operador == "/")
            {
                divicionn = Procedimineto3.Divicione((Primero), (Segundo));
                Pantalla.Text = divicionn.ToString();

            }
            if (Operador == "x")
            {
                multiplicacionn = Procedimineto4.Multiplicar((Primero), (Segundo));
                Pantalla.Text = multiplicacionn.ToString();
                

            }
            if (Operador == "%")
            {
                porcentajee = Procedimiento5.Porcentajes((Primero), (Segundo));
                Pantalla.Text = porcentajee.ToString();

            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length == 1)
                Pantalla.Text = "";
            else
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
        }
    }
}
