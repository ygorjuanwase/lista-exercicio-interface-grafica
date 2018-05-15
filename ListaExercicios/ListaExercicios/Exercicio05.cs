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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCarro = txtnomeDocCarro.Text;
            double valorCarro = 0;
            int parcelaCarro = 0;
            double valorParcela = 0;
            try
            {
                valorCarro = Convert.ToDouble(txtvalorDoCarro.Text);
            }
            catch
            {
                MessageBox.Show("Valor do Carro Deve apresentar apena numeros.");
                txtvalorDoCarro.Focus();
                return;
            }
            try
            {
                parcelaCarro = Convert.ToInt32(txtFinanciamento.Text);
            }
            catch
            {
                MessageBox.Show("Finaciamento deve apenas apresentar numeros.");
                    txtFinanciamento.Focus();
                return;
            }
            try
            {
                valorParcela = Convert.ToDouble(txtvalorDecadaParcela.Text);
            }
            catch
            {
                MessageBox.Show("Valor de Parcela deve apresentar apenas numeros.");
                txtvalorDecadaParcela.Focus();
                return;
            }
            nomeCarro = txtnomeDocCarro.Text;
            txtResultado.Text = "Nome Do Carro: " + nomeCarro + "\r\nValor de Carro: " + valorCarro + "\r\nValor Parcela: " + valorParcela +
                "\r\nfinanciamento: " + parcelaCarro;
        }
    }
}
