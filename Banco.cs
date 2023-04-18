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

    }
}
