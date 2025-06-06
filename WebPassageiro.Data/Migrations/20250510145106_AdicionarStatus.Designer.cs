﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebPassageiro.Data.Context;

#nullable disable

namespace WebPassageiro.Data.Migrations
{
    [DbContext(typeof(DbContexto))]
    [Migration("20250510145106_AdicionarStatus")]
    partial class AdicionarStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebPassageiro.Dominio.Dominio.Aviao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Companhia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poltrona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Portao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("passageiroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("passageiroId")
                        .IsUnique();

                    b.ToTable("Avioes");
                });

            modelBuilder.Entity("WebPassageiro.Dominio.Dominio.Passageiro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePassageiro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Passageiros");
                });

            modelBuilder.Entity("WebPassageiro.Dominio.Dominio.Aviao", b =>
                {
                    b.HasOne("WebPassageiro.Dominio.Dominio.Passageiro", "Passageiro")
                        .WithOne("Aviao")
                        .HasForeignKey("WebPassageiro.Dominio.Dominio.Aviao", "passageiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passageiro");
                });

            modelBuilder.Entity("WebPassageiro.Dominio.Dominio.Passageiro", b =>
                {
                    b.Navigation("Aviao");
                });
#pragma warning restore 612, 618
        }
    }
}
