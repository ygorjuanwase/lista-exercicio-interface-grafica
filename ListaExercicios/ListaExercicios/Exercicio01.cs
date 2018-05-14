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
    public partial class Exercicio01 : Form
    {

        int numero = 0;
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void lbResultaod_Click(object sender, EventArgs e)
        {

        }
        public void Armazenarinformacao()
        {
            numero = Convert.ToInt32(txtNumero.Text);
            int sucessor = numero + 1;
            int antecessor = numero - 1;
        }
        private void btResutado_Click(object sender, EventArgs e)
        {
         

            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
              
               
                int antecessor = numero - 1;
                int sucessor = numero + 1;
                txtresultado.Text =  "antecessor: " + antecessor+ "\r\nsucesssor: " + sucessor;
            }
            catch
            {
                MessageBox.Show("Numero Deve Apresentar Somente Numeros Reais.");
                txtNumero.Focus();
                return;
            }

          
        }
    }
}
