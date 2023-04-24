using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalaApp
{
    public partial class ContaManual2 : Form
    {
        string nomeConta;
        string tipoConta;


        public ContaManual2(string nome, string tipo)
        {
            InitializeComponent();
            nomeConta = nome;
            tipoConta = tipo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBoxDataPreco.Image = Image.FromFile("img/checkVerdeTransparente.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string data = dateTimePicker1.Text;

            textBox1.Text = textBox1.Text.Replace(",", ".");

            string valor = textBox1.Text;

            ContaManual3 contaManual3 = new ContaManual3(nomeConta, tipoConta, data, valor);
            contaManual3.ShowDialog();
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            ContaManual1 contaManual1 = new ContaManual1();
            contaManual1.ShowDialog();

        }
    }
}
