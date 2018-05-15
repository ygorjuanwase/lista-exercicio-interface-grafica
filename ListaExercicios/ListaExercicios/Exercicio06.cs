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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;
            try
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
            }
            catch
            {
                MessageBox.Show("A 1º Nota deve apresentar apenas numeros reais.");
                txtNota1.Focus();
                return;
            }
            try
            {
                nota2 = Convert.ToDouble(txtNota2.Text);
            }
            catch
            {
                MessageBox.Show("A 2º Nota deve apenas apresentar numeros reais.");
                txtNota2.Focus();
                return;
            }
            try
            {
                nota3 = Convert.ToDouble(txtNota3.Text);
            }
            catch
            {
                MessageBox.Show("A 3º Nota deve apenas apresemtar numeros reais.");
                txtNota3.Focus();
                return;
            }
            try
            {
                nota4 = Convert.ToDouble(txtNota4.Text);
            }
            catch
            {
                MessageBox.Show("A 4º Nots deve apenas apresentar numeros reais.");
                txtNota4.Focus();
                return;
            }
            txtMediaFinal.Text = "Média: " + (nota1 + nota2 + nota3 + nota4) / 4;
        }
    }
}
