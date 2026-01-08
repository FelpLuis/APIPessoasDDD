using APIPessoasDDD.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace APIPessoasDDD.Data
{
    public class PessoasDbContext : DbContext
    {

        public PessoasDbContext(DbContextOptions<PessoasDbContext> options ) : base(options)
        { 
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<TipoCliente> TipoCliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<TipoEndereco> TipoEndereco { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<TipoContato> TipoContato { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadatro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;  
                }
            }
            return base.SaveChanges();
        }


    }
}
