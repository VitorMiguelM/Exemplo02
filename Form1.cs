using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo02
{
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int quantidadeHoras = Convert.ToInt32(txtQuantidadeHoras.Text);
            double valorHora = Convert.ToDouble(txtValorHora.Text);
            double salario = valorHora + quantidadeHoras; 

            string unidadeFederativa = cbUnidadeFederativa.SelectedItem.ToString();
            string cidade = txtCidade.Text.Trim();
            string bairro = txtBairro.Text.Trim();
            string logradouro = txtLogradouro.Text.Trim();
            string complemento = txtComplemento.Text.Trim();
            string numero = txtNumero.Text;
            bool ehFemea = rbFemea.Checked;
            string dataNascimento = dtpDataNascimento.Text;

            if (salario < 1000)
            {
                MessageBox.Show("Professor de LoL");
            }
            else if (salario < 10000)
            {
                MessageBox.Show("Professor de Fortnite");
            }
            else if (salario < 50000)
            {
                MessageBox.Show("Junior de Tíbia");
            }
            else if (salario < 100000)
            {
                MessageBox.Show("Mestre pleno de Tíbia");
            }
        }
    }
}
