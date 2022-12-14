using BlazorFarmacia.Server.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorFarmacia.Server.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Lotes> Lotes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ProductosLotes> ProductosLotes { get; set; }
        public DbSet<Ventas> Ventas { get; set; }

    }
}
