﻿// <auto-generated />
using System;
using Codenation.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Codenation.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Codenation.Dominio.Entidades.Carro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnName("Ano")
                        .HasColumnType("int");

                    b.Property<int?>("MarcaID")
                        .HasColumnType("int");

                    b.Property<int?>("ModeloID")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnName("Observacao")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("Quilometragem")
                        .HasColumnName("Quilometragem")
                        .HasColumnType("int");

                    b.Property<int?>("VersaoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.HasIndex("ModeloID");

                    b.HasIndex("VersaoID");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("Codenation.Dominio.Entidades.Marca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(250)");

                    b.HasKey("ID");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Codenation.Dominio.Entidades.Modelo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarcaID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Codenation.Dominio.Entidades.Veiculo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoFabricacao")
                        .HasColumnName("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnName("AnoModelo")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnName("Cor")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnName("Imagem")
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("MarcaID")
                        .HasColumnType("int");

                    b.Property<int?>("ModeloID")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnName("Preco")
                        .HasColumnType("float");

                    b.Property<int>("Quilometragem")
                        .HasColumnName("Quilometragem")
                        .HasColumnType("int");

                    b.Property<int?>("VersaoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.HasIndex("ModeloID");

                    b.HasIndex("VersaoID");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("Codenation.Dominio.Entidades.Versao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ModeloID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(250)");

                    b.HasKey("ID");

                    b.HasIndex("ModeloID");

                    b.ToTable("Versao");
                });

            modelBuilder.Entity("Codenation.Dominio.Entidades.Carro", b =>
                {
                    b.HasOne("Codenation.Dominio.Entidades.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID");

                    b.HasOne("Codenation.Dominio.Entidades.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloID");

                    b.HasOne("Codenation.Dominio.Entidades.Versao", "Versao")
                        .WithMany()
                        .HasForeignKey("VersaoID");
                });

            modelBuilder.Entity("Codenation.Dominio.Entidades.Modelo", b =>
                {
                    b.HasOne("Codenation.Dominio.Entidades.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Codenation.Dominio.Entidades.Veiculo", b =>
                {
                    b.HasOne("Codenation.Dominio.Entidades.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID");

                    b.HasOne("Codenation.Dominio.Entidades.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloID");

                    b.HasOne("Codenation.Dominio.Entidades.Versao", "Versao")
                        .WithMany()
                        .HasForeignKey("VersaoID");
                });

            modelBuilder.Entity("Codenation.Dominio.Entidades.Versao", b =>
                {
                    b.HasOne("Codenation.Dominio.Entidades.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
