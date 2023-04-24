using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EscalaApp
{
    public partial class Recibo : Form
    {
        string txt = "";
        string nomeConta;
        string tipoConta;
        string valor;
        string dataVencimento;
        string frequencia;
        string codigoBarra;
        string email;
        public Recibo(string NomeConta, string TipoConta, string Valor, string DataVencimento, string Frequencia, string CodigoBarra, string Email)
        {
            InitializeComponent();
            nomeConta = NomeConta;
            tipoConta = TipoConta;
            valor = Valor.Replace(",", ".");
            dataVencimento = DataVencimento;
            frequencia = Frequencia;
            codigoBarra = CodigoBarra;
            email = Email;

        }
        private void SalvarArquivo(string path)

        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txt);
                FileInfo file = new FileInfo(path);
                // Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                // Gerenciador.FileExt = file.Extension;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo \n\r" + ex.Message);
            }
            finally
            {
                writer.Close();
            }
        }

        private void button2CodigoBarras_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            txt = "----- Comprovante de pagamento ----- \n\r";

            txt += "-------------------------------------------------- \n\r";

            txt += "Data Vencimento: " + dataVencimento + "\n\r";
            txt += "Valor original : R$ " + valor + "\n\r";
            txt += "Documento: " + nomeConta + "\n\r";
            txt += "Pagador: " + textBox4Email.Text + "\n\r";
            txt += "Agencia: " + textBox2.Text + "\n\r";
            txt += "Conta: " + textBox3.Text + "\n\r";
            txt += "Frequencia: " + frequencia + "\n\r";
            txt += "Data e hora do Recibo: " + dateTime  + "\n\r";
            txt += " -------- Codigo de autenticação ------ \n\r";
            txt += codigoBarra;





            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar";
            dialog.Filter = "portavel|*.pdf";

            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;
            var result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(dialog.FileName);
                MessageBox.Show("Arquivo salvo com sucesso! \n\r" + saveFileDialog1.FileName);

            }
        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            label9DataHora.Text = dateTime.ToString();
            textBox3.Text = "Não informada";
            textBox2.Text = "Não informada";

            textBox4Email.Text = email;
            textBox1.Text = dataVencimento;
            label12.Text = valor;
            label11.Text = nomeConta;
            textBox1.Text = dataVencimento;
            string agencia = textBox2.Text;
            string conta = textBox3.Text;
            string nome = textBox4Email.Text;
            label13.Text = codigoBarra;
            label8.Text = frequencia;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Focus();   
        }

        private void textBox3_Click(object sender, EventArgs e)
        {

            textBox3.Text = "";
            textBox3.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            txt = "----- Comprovante de pagamento ----- \n\r";

            txt += "-------------------------------------------------- \n\r";

            txt += "Data Vencimento: " + dataVencimento + "\n\r";
            txt += "Valor original : R$ " + valor + "\n\r";
            txt += "Documento: " + nomeConta + "\n\r";
            txt += "Pagador: " + textBox4Email.Text + "\n\r";
            txt += "Agencia: " + textBox2.Text + "\n\r";
            txt += "Conta: " + textBox3.Text + "\n\r";
            txt += "Frequencia: " + frequencia + "\n\r";
            txt += "Data e hora do Recibo: " + dateTime + "\n\r";
            txt += " -------- Codigo de autenticação ------ \n\r";
            txt += codigoBarra;



            Font letra = new Font("Arial", 12, FontStyle.Regular);
            Brush pincel = new SolidBrush(Color.Black);
            e.Graphics.DrawString(txt, letra, pincel, new PointF(20, 20));

        }
    }
}
