using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Siscola.Data;

namespace Siscola.Data
{
    class Banco :DbContext
    {
        public Banco() : base("name=db_siscola")
        {
            Database.SetInitializer<Banco>(null);
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
