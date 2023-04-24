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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EscalaApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrar entrar = new Entrar();
            entrar.ShowDialog();
        }

        private void button2Login_Click(object sender, EventArgs e)
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

            string email = textBox1Email.Text;
            string senha = textBox2Senha.Text;
            // localizar arquivo



            string query = "SELECT * FROM login2 WHERE email = '" + email + "' AND senha = '" + senha + "'";


            DataTable dados = Banco.ConsultarTabela(query);

            if (dados.Rows.Count > 0)
            {
                Banco.ConsultarTabelaEmail(query);
                MessageBox.Show("Tudo Certo! \n\r Acesso autorizado");

                ItensMenu itensMenu = new ItensMenu();
                itensMenu.ShowDialog();
            }

            else
            {
                MessageBox.Show("Acesso negado");

                return;
            }



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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desculpe, indisponível no momento! Tente mais tarde");
            radioButton1.Checked = radioButton1.Enabled;
            Login login = new Login();
            login.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RecuperarSenha recuperarSenha = new RecuperarSenha();
            recuperarSenha.ShowDialog();
        }

        private void button4FaceBook_Click(object sender, EventArgs e)
        {
            EntraFacebook entrarFacebook = new EntraFacebook();
            entrarFacebook.ShowDialog();
        }

        private void button3Google_Click(object sender, EventArgs e)
        {
            EntrarGoogle entrarGoogle = new EntrarGoogle(); 
            entrarGoogle.ShowDialog();
        }
    }
}
