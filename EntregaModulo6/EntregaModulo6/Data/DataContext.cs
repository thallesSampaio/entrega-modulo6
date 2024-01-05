using EntregaModulo6.Models;
using Microsoft.EntityFrameworkCore;

namespace EntregaModulo6.Data
{
    public class DataContext  : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Mensagem> Mensage { get; set; }

    }
}
