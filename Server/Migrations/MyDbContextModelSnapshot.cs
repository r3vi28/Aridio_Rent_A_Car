﻿// <auto-generated />
using System;
using Aridio_Rent_A_Car.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AridioRentACar.Server.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaExpiracionLicencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Licencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ocupacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasaporte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.EstadoVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AireAcondicionado")
                        .HasColumnType("bit");

                    b.Property<bool>("Alfombras")
                        .HasColumnType("bit");

                    b.Property<bool>("Antenas")
                        .HasColumnType("bit");

                    b.Property<bool>("Asientos")
                        .HasColumnType("bit");

                    b.Property<bool>("Bateria")
                        .HasColumnType("bit");

                    b.Property<bool>("Bocinas")
                        .HasColumnType("bit");

                    b.Property<bool>("Cinturones")
                        .HasColumnType("bit");

                    b.Property<bool>("Documentos")
                        .HasColumnType("bit");

                    b.Property<bool>("Encendedor")
                        .HasColumnType("bit");

                    b.Property<bool>("Espejos")
                        .HasColumnType("bit");

                    b.Property<bool>("Gatos")
                        .HasColumnType("bit");

                    b.Property<bool>("GomaRepuesto")
                        .HasColumnType("bit");

                    b.Property<bool>("Limpiabrisas")
                        .HasColumnType("bit");

                    b.Property<bool>("LlaveDeRuedas")
                        .HasColumnType("bit");

                    b.Property<bool>("Llaveros")
                        .HasColumnType("bit");

                    b.Property<bool>("Logos")
                        .HasColumnType("bit");

                    b.Property<bool>("Micas")
                        .HasColumnType("bit");

                    b.Property<bool>("Placa")
                        .HasColumnType("bit");

                    b.Property<bool>("Radio")
                        .HasColumnType("bit");

                    b.Property<bool>("Revista")
                        .HasColumnType("bit");

                    b.Property<bool>("TapaDeBocinas")
                        .HasColumnType("bit");

                    b.Property<bool>("TapaGasolina")
                        .HasColumnType("bit");

                    b.Property<bool>("Vidrios")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("EstadosVehiculos");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.FormaDePago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormasDePago");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Cancelado")
                        .HasColumnType("bit");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("Dias")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaDePagoId")
                        .HasColumnType("int");

                    b.Property<bool>("Pagado")
                        .HasColumnType("bit");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FormaDePagoId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.TipoVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposVehiculos");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolesId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.UsuarioRol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsuariosRoles");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoVehiculoId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroPlaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioPorDia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoVehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoVehiculoId");

                    b.HasIndex("TipoVehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.Reserva", b =>
                {
                    b.HasOne("Aridio_Rent_A_Car.Server.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aridio_Rent_A_Car.Server.Models.FormaDePago", "FormaDePago")
                        .WithMany()
                        .HasForeignKey("FormaDePagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aridio_Rent_A_Car.Server.Models.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("FormaDePago");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.Usuario", b =>
                {
                    b.HasOne("Aridio_Rent_A_Car.Server.Models.UsuarioRol", "Roles")
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Aridio_Rent_A_Car.Server.Models.Vehiculo", b =>
                {
                    b.HasOne("Aridio_Rent_A_Car.Server.Models.EstadoVehiculo", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoVehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aridio_Rent_A_Car.Server.Models.TipoVehiculo", "TipoVehiculo")
                        .WithMany()
                        .HasForeignKey("TipoVehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("TipoVehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
