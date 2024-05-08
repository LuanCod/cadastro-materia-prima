﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cadastro_materia_prima.Models;

#nullable disable

namespace cadastro_materia_prima.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240508232928_M01-AddTableMateria")]
    partial class M01AddTableMateria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("cadastro_materia_prima.Models.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AcucaresAdicionados")
                        .HasColumnType("float");

                    b.Property<double>("AcucaresTotais")
                        .HasColumnType("float");

                    b.Property<double>("Carboidratos")
                        .HasColumnType("float");

                    b.Property<double>("FibraAlimentar")
                        .HasColumnType("float");

                    b.Property<double>("GordurasSaturadas")
                        .HasColumnType("float");

                    b.Property<double>("GordurasTotais")
                        .HasColumnType("float");

                    b.Property<double>("GordurasTrans")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Proteinas")
                        .HasColumnType("float");

                    b.Property<double>("Sodio")
                        .HasColumnType("float");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorEnergetico")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Materia");
                });
#pragma warning restore 612, 618
        }
    }
}