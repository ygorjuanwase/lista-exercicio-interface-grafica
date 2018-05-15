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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int numero2 = 0;

            try
            {
                numero1 = Convert.ToInt32(txtNumero1.Text);
            }
            catch
            {
                MessageBox.Show("numero invalido.");
                txtNumero1.Focus();
                return;
            }
            try
            {
                numero2 = Convert.ToInt32(txtnumero2.Text);
            }
            catch
            {
                MessageBox.Show("numero invalido.");
                txtnumero2.Focus();
                return;
            }
          
            txtResultado.Text = "Numero 1:" + numero2 + "\r\nNumero 2:" + numero1;
            }
        }
    }

