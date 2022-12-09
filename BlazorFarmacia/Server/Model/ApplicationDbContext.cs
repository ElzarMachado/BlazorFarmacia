
using BlazorFarmacia.Server.Model;
using BlazorFarmacia.Server.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorContactos.Server.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Clientes> Cliente { get; set; }

        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Lotes> Lotes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ProductosLotes> ProductosLotes { get; set; }
        public DbSet<Ventas> Ventas { get; set; }

    }
}
