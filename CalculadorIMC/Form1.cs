using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double imc = peso / (altura * altura);
            lbIMC.Text = imc.ToString("F2");
            lbIMC.Visible = true;

            string classificacao = string.Empty;

            if (imc < 16.9)
                classificacao = "Muito abaixo do peso";
            else if (imc >= 17 && imc <= 18.4)
                classificacao = "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.99)
                classificacao = "Peso normal";
            else if (imc >= 25 && imc <= 29.9)
                classificacao = "Acima do peso";
            else if (imc >= 30 && imc <= 34.9)
                classificacao = "Obesidade grau I";
            else if (imc >= 35 && imc <= 40)
                classificacao = "Obesidade grau II";
            else if (imc >40)
                classificacao = "Obesidade grau III";

            lbClassificacao.Text = classificacao;
            lbClassificacao.Visible = true;
        }
    }
}
