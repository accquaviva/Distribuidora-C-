using Distribuidora.br.com.distribuidora.dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.br.com.distribuidora.bussines
{
    public class Context : DbContext
    {
        public Context() : base("Conexao")
        {

        }

        public DbSet<Produto> ObjetoProduto { get; set; }

    }
}
