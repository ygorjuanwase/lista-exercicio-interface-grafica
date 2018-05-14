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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 0;
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
            }
            catch
            {
                MessageBox.Show("Numero deve apenas apresentar numeros reais.");
                txtNumero.Focus();
                return;
            }
            string tabuada = "";
            
            for (int i = 0; i <= 10; i++)
            {
               
                tabuada += String.Format("{0} x {1} = {2}\r\n", numero, i, numero * i);
            }
            txtTabuada.Text = tabuada;
        }
    }
}
