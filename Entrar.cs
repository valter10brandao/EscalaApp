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
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void button2Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog(); 
        }

        private void button1Entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("O EMAIL não pode ser vazio!");
                textBox1.Focus();
                return;

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("A SENHA não pode ser vazia!");
                    textBox2.Focus();
                    return;
                }
            }
            string email = textBox1.Text;
            string senha = textBox2.Text;

            string sql = "SELECT * FROM login WHERE email = '" + email + "' AND senha = '" + senha + "'";

          DataTable dados =  Banco.ConsultarTabela(sql);

            if (dados.Rows.Count > 0)
            {
                MessageBox.Show("Tudo Certo! \n\r Acesso autorizado");
             
            }
            else
            {
                MessageBox.Show("Acesso negado");
               
                return;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
