using Distribuidora.br.com.distribuidora.bussines;
using Distribuidora.br.com.distribuidora.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.br.com.distribuidora.tela
{
    public partial class form_cad_produto : Form
    {
        public form_cad_produto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto();
            produto.Nome = txt_nome.Text;
            produto.Valor = double.Parse(txt_valor.Text);
            produto.Descricao = txt_descricao.Text;

            Dao banco = new Dao();
            banco.SalvaProduto(produto,this);
            
        }
    }
}
