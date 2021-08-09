using Infra.Model;
using Microsoft.EntityFrameworkCore;

namespace Negocio.Context
{
    public class SimpleContext : DbContext
    {
        public DbSet<FirstModel> Firsts { get; set; }
        public DbSet<SecondModel> Seconds { get; set; }

        public SimpleContext() { }
        public SimpleContext(DbContextOptions<SimpleContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer($"Data Source=(localdb)\\mssqllocaldb;Initial Catalog=FactoryDb;Integrated Security=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}