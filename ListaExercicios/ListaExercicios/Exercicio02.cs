using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaExercicios
{
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
           
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            double quantidadeDeLitros = 0;
            int anosConsumidos = 0;
            double valorPorLitro = 0;
            try
            {
                quantidadeDeLitros = Convert.ToDouble(txtQuantidadeLitros.Text);
            }
            catch
            {
                MessageBox.Show("Quantidade de Litros deve  apenas apresentar numeros.");
                txtQuantidadeLitros.Focus();
                return;
            }
            try
            {
                anosConsumidos = Convert.ToInt32(txtAnosConsumidos.Text);
            }
            catch
            {
                MessageBox.Show("Anos Consumudos deve apenas apresentar numeros.");
                txtAnosConsumidos.Focus();
                return;
            }
            try
            {
                valorPorLitro = Convert.ToDouble(txtvalorporLitro.Text);
                int ano = anosConsumidos * 365;
                double somaLitrosConsumidos = quantidadeDeLitros * ano;
                double valorTotal = somaLitrosConsumidos * valorPorLitro;
                txtResultado1.Text = "Quantidade de Litros consumidos: " + somaLitrosConsumidos + "\r\nValor total pago: " + valorTotal;
            }
            catch
            {
                MessageBox.Show("Valor por litro deve apenas apresentar numeros.");
                txtvalorporLitro.Focus();
                return;
            }
        }
    }
}
