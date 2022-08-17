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

            modelBuilder.Entity<Categorias>()
                .Property(b => b.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Ventas>()
                .Property(b => b.MontoTotal).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Productos>()
                .Property(b => b.Precio).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<DetallesPedidos>()
                .Property(b => b.MontoTotal).HasColumnType("decimal(18,2)");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"workstation id=ecoceanobd.mssql.somee.com;packet size=4096;user id=ecoceano_SQLLogin_1;pwd=ngi6zqziey;data source=ecoceanobd.mssql.somee.com;persist security info=False;initial catalog=ecoceanobd;");
            //options.UseSqlServer(@"Server=PC-ARN\SQL_ARN;Initial Catalog=ecoceanobd;MultipleActiveResultSets=true;User ID=sa;Password=41dair;");
        }

    }
}
