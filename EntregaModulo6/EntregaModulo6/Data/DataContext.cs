using EntregaModulo6.Models;
using Microsoft.EntityFrameworkCore;

namespace EntregaModulo6.Data
{
    public class DataContext  : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pacote> Pacote { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pacote>().HasData(
                new Pacote { Id = 1, nome = "RJTRIP STANDARD", duracao = "2 dias / 1 noite", preco = 2500},
                new Pacote { Id = 2, nome = "RJTRIP PREMIUM", duracao = "3 dias / 2 noites", preco = 2750 },
                new Pacote { Id = 3, nome = "RJTRIP SUPER PREMIUM", duracao = "7 dias / 6 noites", preco = 4500 },
                new Pacote { Id = 4, nome = "RJTRIP IMPERIAL", duracao = "2 dias / 1 noites", preco = 2900 }
                );
        }

    }
}
