﻿// <auto-generated />
using System;
using ECOCEANO.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECOCEANO.Migrations
{
    [DbContext(typeof(EcoceanoContext))]
    [Migration("20220811053559_ p1")]
    partial class p1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECOCEANO.Models.Categorias", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("estatus")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("ECOCEANO.Models.DetallesPedidos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PedidoID")
                        .HasColumnType("int");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("estatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecharegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("PedidoID");

                    b.HasIndex("ProductoID");

                    b.ToTable("DetallePedidos");
                });

            modelBuilder.Entity("ECOCEANO.Models.DetallesVentas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.Property<bool>("estatus")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ProductoID");

                    b.ToTable("DetalleVentas");
                });

            modelBuilder.Entity("ECOCEANO.Models.Pedidos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("estatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecharegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("ECOCEANO.Models.Productos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("estatus")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("ECOCEANO.Models.Usuarios", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecharegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("pApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sApellido")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ECOCEANO.Models.Ventas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Articulos")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.Property<bool>("estatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecharegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ProductoID");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("ECOCEANO.Models.DetallesPedidos", b =>
                {
                    b.HasOne("ECOCEANO.Models.Pedidos", "pedido")
                        .WithMany()
                        .HasForeignKey("PedidoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECOCEANO.Models.Productos", "producto")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECOCEANO.Models.DetallesVentas", b =>
                {
                    b.HasOne("ECOCEANO.Models.Productos", "producto")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECOCEANO.Models.Pedidos", b =>
                {
                    b.HasOne("ECOCEANO.Models.Usuarios", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECOCEANO.Models.Productos", b =>
                {
                    b.HasOne("ECOCEANO.Models.Categorias", "categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECOCEANO.Models.Ventas", b =>
                {
                    b.HasOne("ECOCEANO.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
