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
    public partial class Exercicio08 : Form
    {
        public Exercicio08()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double contaluz = 0;
            double contaagua = 0;
            double net = 0;
            double vivo = 0;
            double oi = 0;
            double ipva = 0;
            double iptu = 0;
            double seguroCarro = 0;
            try
            {
                contaluz = Convert.ToDouble(txtLuz.Text);
            }
            catch
            {
                MessageBox.Show("Numero invalido.");
                txtLuz.Focus();
                return;
            }
            try
                {
                    contaagua = Convert.ToDouble(txtagua.Text);
                }
                catch
                {
                    MessageBox.Show("numero invalido.");
                    txtagua.Focus();
                    return;
                }
                try
                {
                    net = Convert.ToDouble(txtnet.Text);
                }
                catch
                {
                    MessageBox.Show("numnero invalido.");
                    txtnet.Focus();
                    return;
                }
                try
                {
                    vivo = Convert.ToDouble(txtvivo.Text);
                }
                catch 
                {
                    MessageBox.Show("numero invalido.");
                    txtvivo.Focus();
                    return;
                }
                try
                {
                    oi = Convert.ToDouble(txtvivo.Text);
                }
                catch
                {
                    MessageBox.Show("numero invalido.");
                    txtoi.Focus();
                    return;
                }
                try
                {
                    iptu = Convert.ToDouble(txtvivo.Text);
                }
                catch
                {
                    MessageBox.Show("numero invalido.");
                    txtiptu.Focus();
                    return;
                }
                try
                {
                    ipva = Convert.ToDouble(txtvivo.Text);
                }
                catch
                {
                    MessageBox.Show("numero invalido.");
                    txtipva.Focus();
                    return;
                }
                try
                {
                    seguroCarro = Convert.ToDouble(txtvivo.Text);
                }
                catch
                {
                    MessageBox.Show("numero invalido.");
                    txtsegurocarro.Focus();
                    return;
                }
                double valortelefones = oi + vivo + net;
                double valorimposto = ipva + iptu ;
                double restante = contaagua + contaluz + seguroCarro;
                double totalDeTudo = iptu + ipva + seguroCarro + net + oi + vivo + contaluz + contaagua;
                txtResultado.Text = "Valor Total dos Telefones: " + valortelefones + "\r\nValor Total De Impostos: " + valorimposto +
                    "\r\nRestantes Das Contas: " + restante + "\r\nValor Total Das Contas:" + totalDeTudo;

            }

            
        }
    }

