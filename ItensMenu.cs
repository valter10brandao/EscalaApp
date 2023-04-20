using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalaApp
{
    public partial class ItensMenu : Form
    {
        public ItensMenu()
        {
            InitializeComponent();
        }

        private void button3TodosBoletos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DateTime dataAtual = DateTime.Now;
            DateTime dataVenc = DateTime.Now;
            string nomeConta = "";
            string valor = "";
            string dataVencimento = "";

            dataGridView1.Rows.Clear();



            string query = "SELECT * FROM despesa ORDER BY id";

            DataTable dados = Banco.ConsultarTabela(query);

            foreach (DataRow linha in dados.Rows)
            {
                dataGridView1.Rows.Add(linha.ItemArray);

            }
            nomeConta = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            valor = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dataVencimento = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            label4NomeConta.Text = nomeConta;
            if (nomeConta == "Cartão de Crédito")
            {
                pictureBox1.Image = Image.FromFile("img/cartao.png");
            }
            else if (nomeConta == "Luz")
            {
                pictureBox1.Image = Image.FromFile("img/luz.png");
            }
            else if (nomeConta == "Água")
            {
                pictureBox1.Image = Image.FromFile("img/agua.jpg");
            }
            else if (nomeConta == "Telefone")
            {
                pictureBox1.Image = Image.FromFile("img/telefone.png");
            }
            else if (nomeConta == "Outros")
            {
                pictureBox1.Image = Image.FromFile("img/outros.png");
            }
            else if (nomeConta == "Aluguel")
            {
                pictureBox1.Image = Image.FromFile("img/aluguel.png");
            }

            label7ValorDaConta.Text = valor.Replace(".", ",");
            label2DataVencimento.Text = dataVencimento;

            try
            {
                dataVenc = DateTime.Parse(dataVencimento);


            }
            catch (FormatException)
            {
                MessageBox.Show("não foi possivel corverter a data:" + dataVencimento);
            }



            // soma dos valores

            string query2 = "SELECT SUM (valor) FROM despesa";
            DataTable dados2 = Banco.ConsultarTabela(query2);

            string totais = dados2.Rows[0][0].ToString();
            label3Total.Text = totais.ToString();


            dataVenc = DateTime.Parse(dataVencimento);

            TimeSpan dia = TimeSpan.Zero;
            dia = dataAtual.Subtract(dataVenc);

            dia = dataVenc.Subtract(dataAtual);
            int dias = (int)dia.TotalDays;




            if (dias > 0)
            {
                dias = dias + 1;
                textBox1.BackColor = Color.Green;
                label5DiasEmAtraso.Text = "Falta " + dias + " dias para vencimento!!";
                textBox1.Text = "A Vencer";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;
            }
            else if (dias < 0)
            {
                dias = dias + 1;
                dias = dias * -1;
                textBox1.BackColor = Color.Red;
                label5DiasEmAtraso.Text = "esta conta Venceu a  " + dias + " dias";
                textBox1.Text = "Conta Vencida";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;
            }
            else
            {

                textBox1.BackColor = Color.Yellow;
                label5DiasEmAtraso.Text = "Vencimento hoje!! ";
                textBox1.Text = "Vence hoje!!";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;

            }
        }

        private void button4BoletosParaPagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DateTime dataAtual = DateTime.Now;
            DateTime dataVenc = DateTime.Now;
            string nomeConta = "";
            string valor = "";
            string dataVencimento = "";
            string apagar = "A pagar";




            dataGridView1.Rows.Clear();

            string query = "SELECT * FROM despesa WHERE apagar LIKE '" + apagar + "' ORDER BY dataVencimento";

            DataTable dados3 = Banco.ConsultarTabela(query);

            foreach (DataRow linha in dados3.Rows)
            {
                dataGridView1.Rows.Add(linha.ItemArray);

            }

            nomeConta = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            valor = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dataVencimento = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            label4NomeConta.Text = nomeConta;
            if (nomeConta == "Cartão de Crédito")
            {
                pictureBox1.Image = Image.FromFile("img/cartao.png");
            }
            else if (nomeConta == "Luz")
            {
                pictureBox1.Image = Image.FromFile("img/luz.png");
            }
            else if (nomeConta == "Água")
            {
                pictureBox1.Image = Image.FromFile("img/agua.jpg");
            }
            else if (nomeConta == "Telefone")
            {
                pictureBox1.Image = Image.FromFile("img/telefone.png");
            }
            else if (nomeConta == "Outros")
            {
                pictureBox1.Image = Image.FromFile("img/outros.png");
            }
            else if (nomeConta == "Aluguel")
            {
                pictureBox1.Image = Image.FromFile("img/aluguel.png");
            }

            label7ValorDaConta.Text = valor.Replace(".", ",");
            label2DataVencimento.Text = dataVencimento;

            try
            {
                dataVenc = DateTime.Parse(dataVencimento);
            }
            catch (FormatException)
            {
                MessageBox.Show("não foi possivel corverter a data:" + dataVencimento);
            }



            // soma dos valores

            string query2 = "SELECT SUM (valor) FROM despesa WHERE apagar = '" + apagar + "'";
            DataTable dados2 = Banco.ConsultarTabela(query2);

            string totais = dados2.Rows[0][0].ToString();
            label3Total.Text = totais.ToString();

            dataVenc = DateTime.Parse(dataVencimento);

            TimeSpan dia = TimeSpan.Zero;
            dia = dataAtual.Subtract(dataVenc);

            dia = dataVenc.Subtract(dataAtual);
            int dias = (int)dia.TotalDays;

            if (dias > 0)
            {
                dias = dias + 1;
                textBox1.BackColor = Color.Green;
                label5DiasEmAtraso.Text = "Falta " + dias + " dias para vencimento!!";
                textBox1.Text = "A Vencer";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;
            }
            else if (dias < 0)
            {

                dias = dias + 1;
                dias = dias * -1;
                textBox1.BackColor = Color.Red;
                label5DiasEmAtraso.Text = "esta conta Venceu a  " + dias + " dias";
                textBox1.Text = "Conta Vencida";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;
            }
            else
            {

                textBox1.BackColor = Color.Yellow;
                label5DiasEmAtraso.Text = "Vencimento hoje!! ";
                textBox1.Text = "Vence hoje!!";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DateTime dataAtual = DateTime.Now;
            DateTime dataVenc = DateTime.Now;
            string nomeConta = "";
            string valor = "";
            string dataVencimento = "";
            string apagar = "CONTA PAGA";




            dataGridView1.Rows.Clear();

            string query = "SELECT * FROM despesa WHERE apagar LIKE '" + apagar + "'ORDER BY id";

            DataTable dados3 = Banco.ConsultarTabela(query);


            foreach (DataRow linha in dados3.Rows)
            {
                dataGridView1.Rows.Add(linha.ItemArray);

            }
            nomeConta = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            valor = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dataVencimento = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            label4NomeConta.Text = nomeConta;
            if (nomeConta == "Cartão de Crédito")
            {
                pictureBox1.Image = Image.FromFile("img/cartao.png");
            }
            else if (nomeConta == "Luz")
            {
                pictureBox1.Image = Image.FromFile("img/luz.png");
            }
            else if (nomeConta == "Água")
            {
                pictureBox1.Image = Image.FromFile("img/agua.jpg");
            }
            else if (nomeConta == "Telefone")
            {
                pictureBox1.Image = Image.FromFile("img/telefone.png");
            }
            else if (nomeConta == "Outros")
            {
                pictureBox1.Image = Image.FromFile("img/outros.png");
            }
            else if (nomeConta == "Aluguel")
            {
                pictureBox1.Image = Image.FromFile("img/aluguel.png");
            }

            label7ValorDaConta.Text = valor.Replace(".", ",");
            label2DataVencimento.Text = dataVencimento;

            try
            {
                dataVenc = DateTime.Parse(dataVencimento);
            }
            catch (FormatException)
            {
                MessageBox.Show("não foi possivel corverter a data:" + dataVencimento);
            }



            // soma dos valores




            string query2 = "SELECT SUM (valor) FROM despesa WHERE apagar = '" + apagar + "'";
            DataTable dados2 = Banco.ConsultarTabela(query2);

            string totais = dados2.Rows[0][0].ToString();
            label3Total.Text = totais.ToString();


            dataVenc = DateTime.Parse(dataVencimento);

            TimeSpan dia = TimeSpan.Zero;
            dia = dataAtual.Subtract(dataVenc);

            dia = dataVenc.Subtract(dataAtual);
            int dias = (int)dia.TotalDays;

            if (dias > 0)
            {
                dias = dias + 1;
                textBox1.BackColor = Color.Green;
                label5DiasEmAtraso.Text = "Falta " + dias + " dias para vencimento!!";
                textBox1.Text = "A Vencer";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;
            }
            else if (dias < 0)
            {

                dias = dias + 1;
                dias = dias * -1;
                textBox1.BackColor = Color.Red;
                label5DiasEmAtraso.Text = "esta conta Venceu a  " + dias + " dias";
                textBox1.Text = "Conta Vencida";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;
            }
            else
            {

                textBox1.BackColor = Color.Yellow;
                label5DiasEmAtraso.Text = "Vencimento hoje!! ";
                textBox1.Text = "Vence hoje!!";
                label4NomeConta.Text = nomeConta;
                label7ValorDaConta.Text = valor.Replace(".", ",");
                label2DataVencimento.Text = dataVencimento;

            }

        }

        private void button1BoletosPagos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            //alterar arquivo


            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string pago = "CONTA PAGA";

            string query = "UPDATE despesa SET apagar = '" + pago + "' WHERE id LIKE '" + id + "'";
            Banco.AlterarDados(query);

        }

        private void button2Deletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            // deletar arquivo

            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            string query = "DELETE FROM despesa WHERE id = '" + id + "'";
            Banco.DeletarDados(query);
        }

        private void button2MaisBoletos_Click(object sender, EventArgs e)
        {
            OpacaoAgendamento opacaoAgendamento = new OpacaoAgendamento();
            opacaoAgendamento.ShowDialog();
        }

        private void ItensMenu_Load(object sender, EventArgs e)
        {

            string sql = "CREATE TABLE  IF NOT EXISTS despesa (id INT NOT NULL PRIMARY KEY, " +
               "codigoBarra NVARCHAR(50)," +
               " nomeConta NVARCHAR(20)," +
               " tipoConta NVARCHAR(20)," +
               " valor NVARCHAR(20)," +
               " dataVencimento NVARCHAR (20)," +
               " frequencia NVARCHAR(20)," +
               " apagar NVARCHAR(20))";

            Banco.CriarTabela(sql);
           
        }
    }

}



