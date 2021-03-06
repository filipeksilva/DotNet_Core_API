using System;
using Microsoft.EntityFrameworkCore;


namespace Models
{
    class DBContexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Conexao.Dados);
            }
        }

        public DbSet<Cliente> Clientes { get; set;  }
    }
}
