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
    public partial class ContaManual1 : Form
    {
        public ContaManual1()
        {
            InitializeComponent();
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            OpacaoAgendamento opacaoAgendamento = new OpacaoAgendamento();  
            opacaoAgendamento.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nomeConta = comboBox1.Text;
            string tipoConta = comboBox2.Text;

            ContaManual2 contaManual2 = new ContaManual2(nomeConta, tipoConta);
            contaManual2.ShowDialog();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            pictureBoxNomeConta.Image = Image.FromFile("img/checkVerdeTransparente.jpg");
        }
    }
}
