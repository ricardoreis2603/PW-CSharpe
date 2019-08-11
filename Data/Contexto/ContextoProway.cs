using Dominio;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexto
{
    
    public class ContextoProway : DbContext
    {
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        public ContextoProway():base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\66046\Documents\GitHub\Data\DbLocal\Database.mdf;Integrated Security=True")
        {

        }
    }
}
