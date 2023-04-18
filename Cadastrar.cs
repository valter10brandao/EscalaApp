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
    public partial class Cadastrar : Form
    {
        string email = "";
        string senha = "";
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button2Cadastrar_Click(object sender, EventArgs e)
        {
            string sql = "CREATE TABLE  IF NOT EXISTS login (id INT NOT NULL PRIMARY KEY, " +
              "email NVARCHAR(50)," +
              " senha NVARCHAR(20))";
             
            Banco.CriarTabela(sql);

            email = textBox1Email.Text;
            senha = textBox2Senha.Text;
            int id = new Random(DateTime.Now.Millisecond).Next(0, 100000);

            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);


            // localizar arquivo
            try
            {
                string query = "SELECT * FROM login WHERE id LIKE '" + id + "'";

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

            sql = "INSERT INTO login VALUES(" + id + ",'" + email + "', '" + senha + "')";
           
           Banco.InserirNaTabela(sql);

        }
    }
}
