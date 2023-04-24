using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EscalaApp
{
    public partial class CodigoBarras : Form
    {
        public int id = new Random(DateTime.Now.Millisecond).Next(0, 100000);

        public CodigoBarras()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string nomeConta = comboBox1.Text;
            string tipoConta = comboBox3.Text;
            textBox1.Text = textBox1.Text.Replace(",", ".");
            string valor = textBox1.Text;
            string dataVencimento = dateTimePicker1.Text;
            string frequencia = comboBox2.Text;
            string codigoBarra = maskedTextBox1.Text.Trim();
            string apagar = "A pagar";

            string sql = "INSERT INTO despesa VALUES (" + id + ",'" + codigoBarra + "','" + nomeConta + "', '" + tipoConta + "','" + valor + "', '" + dataVencimento + "','" + frequencia + "', '" + apagar + "')";
           
            Banco.InserirNaTabela(sql);

            Feito feito = new Feito();
            feito.ShowDialog();
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            OpacaoAgendamento opcaoAgendamento = new OpacaoAgendamento();
            opcaoAgendamento.ShowDialog();
        }

        private void button2Recibo_Click(object sender, EventArgs e)
        {


            string email = Banco.email;
            string nomeConta = comboBox1.Text;
            string tipoConta = comboBox3.Text;
            textBox1.Text = textBox1.Text.Replace(",", ".");
            string valor = textBox1.Text;
            string dataVencimento = dateTimePicker1.Text;
            string frequencia = comboBox2.Text;
            string codigoBarra = maskedTextBox1.Text;

            Recibo recibo = new Recibo(nomeConta, tipoConta, valor, dataVencimento, frequencia, codigoBarra, email);
            recibo.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox2.Text = "";
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Focus();
        }

        private void button1Impressao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em construção...");
        }
    }
}
