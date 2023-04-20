using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EscalaApp
{
    public static class Banco
    {
        public static string email = "";
        public static void ConectarBancoDeDados()
        {
            //conectar banco e cria a base de dados

            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            if (!File.Exists(strConection))
            {
                SQLiteConnection.CreateFile(baseDados);
            }
            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                conexao.Close();
            }
        }

        public static void CriarTabela(string sql)
        {
            // cria a tabela

            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";
            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { conexao.Close(); }


        }

        public static void InserirNaTabela(string sql)
        {
            //faz inserções na tabela
            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro inserido com sucesso");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { conexao.Close(); }

        }
        public static DataTable ConsultarTabela(string sql)
        {
            // localizar arquivo


            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            DataTable dados = new DataTable();
            try
            {

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, strConection);

                conexao.Open();
                adaptador.Fill(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            { conexao.Close(); }
            return dados;
           
        }
        public static void ConsultarTabelaEmail(string sql)
        {
            // localizar arquivo


            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            DataTable dados = new DataTable();
            try
            {

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, strConection);

                conexao.Open();
                adaptador.Fill(dados);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            { conexao.Close(); }

            email = dados.Rows[0].ItemArray[1].ToString();
        }

        public static void AlterarDados(string sql)
        {
            //alterar arquivo
            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            var result = MessageBox.Show("Deseja mesmo alterar o status para CONTA PAGA?", "ALTERAR",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                MessageBox.Show("Nada foi alterado!");
                return;
            }

            try
            {
                conexao.Open();


                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                string query = sql;
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Alterado com sucesso");
                comando.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                conexao.Close();
            }
        }

        public static void DeletarDados(string sql)
        {
            // deletar arquivo

            string baseDados = Application.StartupPath + @"\DBSQlite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);


            var result = MessageBox.Show("Deseja mesmo Deletar esta conta? \n\r ATENÇÃO Esta ação não poderá ser revertida!!!", "DELETAR",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                MessageBox.Show("Nada foi Deletado!");
                return;
            }

            try
            {
                conexao.Open();


                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                string query = sql;
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Excluido com sucesso");
                comando.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { conexao.Close(); }
        }
    }

}


