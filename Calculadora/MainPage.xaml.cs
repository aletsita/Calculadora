using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        private double PrimerNum;
        private double SegundoNum;
        private string Calculo;

        public MainPage()
        {
            InitializeComponent();
        }

        //INTRODUCCION DE NUMEROS
        private void OnNumberClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = button.Text;
            }
            else
                lblResultado.Text += button.Text;
        }

        // OPERACIONES DE SUMA, RESTA, MULTIPLICACION Y DIVISION
        private void OnAddClicked(object sender, EventArgs e)
        {
            PrimerNum = double.Parse(lblResultado.Text);
            Calculo = "+";
            lblResultado.Text = "0";
        }

        private void OnSubtractClicked(object sender, EventArgs e)
        {
            PrimerNum = double.Parse(lblResultado.Text);
            Calculo = "-";
            lblResultado.Text = "0";
        }

        private void OnMultiplyClicked(object sender, EventArgs e)
        {
            PrimerNum = double.Parse(lblResultado.Text);
            Calculo = "×";
            lblResultado.Text = "0";
        }

        private void OnDivideClicked(object sender, EventArgs e)
        {
            PrimerNum = double.Parse(lblResultado.Text);
            Calculo = "÷";
            lblResultado.Text = "0";
        }

        private void OnEqualClicked(object sender, EventArgs e)
        {
            SegundoNum = double.Parse(lblResultado.Text);
            double result = 0;

            switch (Calculo)
            {
                case "+":
                    result = PrimerNum + SegundoNum;
                    break;
                case "-":
                    result = PrimerNum - SegundoNum;
                    break;
                case "×":
                    result = PrimerNum * SegundoNum;
                    break;
                case "÷":
                    result = PrimerNum / SegundoNum;
                    break;
            }

            lblResultado.Text = result.ToString();
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            PrimerNum = 0;
            SegundoNum = 0;
            Calculo = string.Empty;
        }
    }
}

