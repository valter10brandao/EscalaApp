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
    public partial class OpacaoAgendamento : Form
    {
        public OpacaoAgendamento()
        {
            InitializeComponent();
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            ItensMenu menu = new ItensMenu();   
            menu.ShowDialog();
        }

        private void button2CodigoBarras_Click(object sender, EventArgs e)
        {
            CodigoBarras codigoBarras = new CodigoBarras(); 
            codigoBarras.ShowDialog();
        }

        private void button3Manual_Click(object sender, EventArgs e)
        {
            ContaManual1 contaManual1 = new ContaManual1();
            contaManual1.ShowDialog();
        }
    }
}
