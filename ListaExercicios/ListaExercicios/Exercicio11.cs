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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            int dia = 0;
            int mes = 0;
            int ano = 0;
            int anosVivos = 0;
            int mesesVivo = 0;
            int diasVivo = 0;
            int horasVivo = 0;
            int minutosVivo = 0;
            int segundosVivo = 0;
            try
            {
                dia = Convert.ToInt32(txtdia.Text);
                if ((dia > 31) && (dia < 1))
                {
                    MessageBox.Show("O dia de nascimento é invalido.");
                }
            }
                catch
            {
                    MessageBox.Show("Dia deve apresentar somente numero.");
                        txtdia.Focus();
                    return;
            }
            try
            {
                mes = Convert.ToInt32(txtmes.Text);
                if ((mes > 12) && (mes > 0))
                {
                    MessageBox.Show("Mes invalido.");
                }
            }
            catch
            {
                MessageBox.Show("Digite seu mes de nascimento corretamente.");
                txtmes.Focus();
                return;
            }
            try
            {
                ano = Convert.ToInt32(txtano.Text);
                if ((ano > 2018) && (ano <= 1900))
                {
                    MessageBox.Show("Ano invalido.");
                }
            }
            catch
            {
                MessageBox.Show("Ano de nascimento invalido.");
                txtano.Focus();
                return;
            }


            anosVivos = 2018 - ano;
            mesesVivo = anosVivos * 12;
            diasVivo = anosVivos * 365;
            horasVivo = diasVivo * 24;
            minutosVivo = horasVivo * 60;
            segundosVivo = 3600 * minutosVivo;
            txtResultado.Text = "Anos Vivos:" + anosVivos + "\r\nMeses vivos:" + mesesVivo + "\r\nDias vivos:" + diasVivo + "\r\nHoras vivos:"
                + horasVivo + "\r\nMinutos vivos:" + minutosVivo + "\r\nSegundos vivos:" + segundosVivo;


        }
       
    

    
    }
}
