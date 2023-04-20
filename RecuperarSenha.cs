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
    public partial class RecuperarSenha : Form
    {
        public RecuperarSenha()
        {
            InitializeComponent();
        }

        private void button2Recuperar_Click(object sender, EventArgs e)
        {

            if ((textBox1Email == null) || (maskedTextBox1 == null))
            {

                MessageBox.Show("Os campos email e telefone não podem ser vazios");
                return;
            }
            else
            {
                string email = textBox1Email.Text;
                string telefone = maskedTextBox1.Text;
                string baseDados = Application.StartupPath + @"\DBSQlite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";




                string query = "SELECT * FROM login2 WHERE email = '" + email + "' AND telefone = '" + telefone + "'";


                DataTable dados = Banco.ConsultarTabela(query);

                if (dados.Rows.Count == 1)
                {
                    MessageBox.Show("Tudo Certo!");
                    //MessageBox.Show("o email é: " + dados.Rows[0].ItemArray[1].ToString());
                    MessageBox.Show("a senha é: " + dados.Rows[0].ItemArray[2].ToString());
                    //MessageBox.Show("o telefone é: " + dados.Rows[0].ItemArray[3].ToString());
                    telefone = dados.Rows[0].ItemArray[3].ToString();

                    Login login = new Login();
                    login.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso negado \n\r Dados inconsistentes");
                    return;
                }

            }

        }

        private void textBox1Email_Click(object sender, EventArgs e)
        {
            textBox1Email.Text = "";
            textBox1Email.Focus();
        }
    }
}
