using Distribuidora.br.com.distribuidora.dominio;
using Distribuidora.br.com.distribuidora.tela;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.br.com.distribuidora.bussines
{
    public class Dao
    {
        public void SalvaProduto(Produto produto,form_cad_produto cad_Produto)
        {
            try
            {
                using (var tb = new Context())
                {
                    tb.ObjetoProduto.Add(new Produto { Nome = produto.Nome, Valor = produto.Valor, Descricao = produto.Descricao, Date = DateTime.Now });
                    tb.SaveChanges();
                }
            }
            catch (SqlException )
            {

                throw;
            }
            
        }
    }
}
