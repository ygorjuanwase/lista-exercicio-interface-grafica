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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 0;
            try
            {
                idade = Convert.ToInt32(txtanodanascimento.Text);
                if (idade > 2018)
                {
                    MessageBox.Show("Você nao Pode ter vindo do futuro.");
                }
                else if(idade < 0)
                {
                    MessageBox.Show("Você por acaso é jesus, não né,entao digita certo essa porra.");
                }
            }
            catch
            {
                MessageBox.Show("ano invalido");
                txtanodanascimento.Focus();
                return;
            }
            int suaidade = 2018 - idade;

            txtsuaidade.Text = "Sua Idade é: " + suaidade;
        }
    }
}
