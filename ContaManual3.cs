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
    public partial class ContaManual3 : Form
    {
        public int id = new Random(DateTime.Now.Millisecond).Next(0, 100000);

        string codigoBarra = "Não informado";
        string nomeConta;
        string tipoConta;
        string dataVencimento;
        string valor;
        string frequencia;
        string apagar;

        public ContaManual3(string conta, string tipo, string data, string v)
        {
            InitializeComponent();

            nomeConta = conta;
            tipoConta = tipo;
            dataVencimento = data;
            valor = v;
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
              ContaManual2 contaManual2 = new ContaManual2(nomeConta,tipoConta);
              contaManual2.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frequencia = "";
            apagar = "A pagar";

            if (radioButton1.Checked)
            {
                frequencia = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                frequencia = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                frequencia = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                frequencia = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                frequencia = radioButton5.Text;
            }
            else
            {
                frequencia = radioButton6.Text;
            }



            string sql = "INSERT INTO despesa VALUES (" + id + ",'" + codigoBarra.Trim() + "','" + nomeConta + "', '" + tipoConta + "','" + valor + "', '" + dataVencimento + "','" + frequencia + "', '" + apagar + "')";
            Banco.InserirNaTabela(sql);
           

            Feito feito = new Feito();
            feito.ShowDialog();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxRepeticao.Image = Image.FromFile("img/checkVerdeTransparente.jpg");
        }
    }
}
