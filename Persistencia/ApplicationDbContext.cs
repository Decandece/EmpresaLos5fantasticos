using Microsoft.EntityFrameworkCore;
using Dominio;
namespace Persistencia
{
    public class ApplicationDbContext : DbContext
    {
        private const string connectionString = @"Data Source=LAPTOP-MN740OE5;Initial Catalog = EMPRESA;Integrated Security = True";
        public DbSet<Persona> personas { get; set; }
         public DbSet<Empresa> empresa { get; set; }
         public DbSet<Cliente> clientes { get; set; }
         public DbSet<Empleado> empleados { get; set; }
         public DbSet<Directivo> directivos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
               }
        }
    }
}