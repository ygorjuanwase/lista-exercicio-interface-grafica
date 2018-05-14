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
    public partial class Exrcicio03 : Form
    {
        public Exrcicio03()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnresultados_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int numero2 = 0;
            try
            {
                numero1 = Convert.ToInt32(txtNumero1.Text);
            }
            catch
            {
                MessageBox.Show("Numero deve apresentar somente numeros reais.");
                txtNumero1.Focus();
                return;
            }
            try
            {
                numero2 = Convert.ToInt32(txtNumero2.Text);
                int somaValores = numero1 + numero2;
                int subtracaoValores = numero1 - numero2;
                int multiplicacaoValores = numero1 * numero2;
                int divisaoValores = numero1 / numero2;
                int produtoValores = multiplicacaoValores;
                txtresultado.Text = "Soma: " + somaValores + "\r\nSubtração: " + subtracaoValores + "\r\nMultiplicação: " + multiplicacaoValores +
                "\r\nDivisão: " + divisaoValores + "\r\nProduto: " + produtoValores;
            }
            catch
            {
                MessageBox.Show("Numero deve apresentar apenas numeros.");
                txtNumero2.Focus();
                return;
               
        }
            }
          
        }

       
        }