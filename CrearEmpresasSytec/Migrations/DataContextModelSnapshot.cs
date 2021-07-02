﻿// <auto-generated />
using System;
using CrearEmpresasSytec.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrearEmpresasSytec.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrearEmpresasSytec.Models.Configuracion", b =>
                {
                    b.Property<int>("IdConfigFacturacion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("APIKey");

                    b.Property<int>("AmbienteTimbrado");

                    b.Property<byte[]>("Certificado");

                    b.Property<int>("IdEmpresa");

                    b.Property<string>("LlavePrivada")
                        .HasMaxLength(100);

                    b.Property<byte[]>("LlavePublica");

                    b.Property<string>("NcMetodoPago")
                        .HasMaxLength(2);

                    b.Property<string>("NombreCertificado");

                    b.Property<string>("NombreLlavePublica");

                    b.Property<string>("OpcionEnviarFactura")
                        .HasMaxLength(100);

                    b.Property<string>("OpcionTimbrado")
                        .HasMaxLength(100);

                    b.Property<int>("PAC");

                    b.Property<string>("PassPac")
                        .HasMaxLength(50);

                    b.Property<string>("UserPac")
                        .HasMaxLength(50);

                    b.Property<int>("VersionCFDI");

                    b.HasKey("IdConfigFacturacion");

                    b.HasIndex("IdEmpresa")
                        .IsUnique();

                    b.ToTable("Configuraciones");
                });

            modelBuilder.Entity("CrearEmpresasSytec.Models.Empresa", b =>
                {
                    b.Property<int>("IdEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Asunto");

                    b.Property<string>("CP");

                    b.Property<string>("CURP");

                    b.Property<string>("Calle");

                    b.Property<string>("ClaveEPago");

                    b.Property<string>("Colonia");

                    b.Property<string>("Contraseña");

                    b.Property<bool>("DeSistema");

                    b.Property<string>("Email");

                    b.Property<bool>("EsAmbieteDePrueba");

                    b.Property<string>("EsEntidadPublica");

                    b.Property<string>("EsEntidadprivada");

                    b.Property<string>("HabilitarCifrado");

                    b.Property<int>("IdEstados");

                    b.Property<int>("IdPaises");

                    b.Property<int>("IdRiesgoPuesto");

                    b.Property<int>("IdSATRegimenFiscal");

                    b.Property<string>("Mensaje");

                    b.Property<string>("Municipio");

                    b.Property<string>("NombreComercil");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired();

                    b.Property<string>("Puerto1");

                    b.Property<string>("Puerto2");

                    b.Property<string>("RFC");

                    b.Property<string>("RegimenFiscal");

                    b.Property<string>("RegistroPatronal");

                    b.Property<bool>("SNCF");

                    b.Property<int>("SeguridadClienteId");

                    b.Property<string>("Servidor1");

                    b.Property<string>("Servidro2");

                    b.Property<string>("Sucursal");

                    b.Property<string>("TEL");

                    b.HasKey("IdEmpresa");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("CrearEmpresasSytec.Models.Configuracion", b =>
                {
                    b.HasOne("CrearEmpresasSytec.Models.Empresa", "EMPRESA")
                        .WithOne("Configuracion")
                        .HasForeignKey("CrearEmpresasSytec.Models.Configuracion", "IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
