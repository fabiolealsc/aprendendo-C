using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models
{
    public class Conexao : DbContext
    {
        public Conexao() : base("CadastroClientes") 
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}