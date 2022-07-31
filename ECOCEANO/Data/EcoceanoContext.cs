using ECOCEANO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOCEANO.Data
{
    public class EcoceanoContext : DbContext
    {
            public EcoceanoContext(DbContextOptions<EcoceanoContext> options) : base(options)
            {

            }
            public DbSet<Usuarios> Usuario { get; set; }
            public DbSet<Productos> Producto { get; set; }
            public DbSet<Categorias> Categoria { get; set; }
            public DbSet<Pedidos> Pedido { get; set; }
            public DbSet<Ventas> Venta { get; set; }
            public DbSet<DetallesVentas> DetalleVentas { get; set; }
            public DbSet<DetallesPedidos> DetallePedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuarios>()
                .Property(b => b.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Ventas>()
                .Property(b => b.MontoTotal).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Productos>()
                .Property(b => b.Precio).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<DetallesPedidos>()
                .Property(b => b.MontoTotal).HasColumnType("decimal(18,2)");

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    {
        //        //options.UseMySQL("Server=localhost;Port=3306;Database=ecoceanobd;User ID=root;Password=41dair;CharSet=utf8;");
        //    }

    }
}
