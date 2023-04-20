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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EscalaApp
{
    public partial class Cadastrar : Form
    {
        public MaskedTextBox MaskCompleted { get; set; }

        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button2Cadastrar_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrar entrar = new Entrar();
            entrar.ShowDialog();
        }

        private void button2EfetuarCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1Email.Text))
            {
                MessageBox.Show("O EMAIL não pode ser vazio!");
                textBox1Email.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2Senha.Text))
            {
                MessageBox.Show("A SENHA não pode ser vazia!");
                textBox2Senha.Focus();
                return;
            }
            if (maskedTextBox1Telefone == MaskCompleted)
            {
                var result = MessageBox.Show("sem o telefone não é possível recuperar a senha!!", "OPÇÃO",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.No)
                {
                    maskedTextBox1Telefone.Focus();
                    return;
                }
            }

            //criar a tabela
            string sql = "CREATE TABLE  IF NOT EXISTS login2 (id INT NOT NULL PRIMARY KEY, " +
             "email NVARCHAR(50)," +
             " senha NVARCHAR(20)," +
             " telefone NVARCHAR(20))";

            Banco.CriarTabela(sql);

            string email = textBox1Email.Text;
            string senha = textBox2Senha.Text;
            string telefone = maskedTextBox1Telefone.Text;

            int id = new Random(DateTime.Now.Millisecond).Next(0, 100000);

            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            // localizar arquivo
            try
            {
                string query = "SELECT * FROM login2 WHERE id LIKE '" + id + "'";

                DataTable dados = new DataTable();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();
                adaptador.Fill(dados);

                if (dados.Rows.Count == 1)
                {
                    id++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { conexao.Close(); }

            sql = "INSERT INTO login2 VALUES(" + id + ",'" + email + "', '" + senha + "','" + telefone + "')";

            Banco.InserirNaTabela(sql);

            Entrar entrar = new Entrar();
            entrar.ShowDialog();
        }

        private void textBox1Email_Click(object sender, EventArgs e)
        {
            textBox1Email.Text = "";
            textBox2Senha.Text = "";
            textBox1Email.Focus();  
        }

        private void textBox2Senha_Click(object sender, EventArgs e)
        {
            textBox2Senha.Text = "";
            textBox2Senha.Focus();
        }
    }
}
