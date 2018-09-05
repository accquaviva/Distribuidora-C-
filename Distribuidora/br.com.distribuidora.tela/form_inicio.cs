using Distribuidora.br.com.distribuidora.tela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora
{
    public partial class form_inicio : Form
    {
        public form_inicio()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cad_produto cadastro = new form_cad_produto();
            cadastro.Show();
        }
    }
}
