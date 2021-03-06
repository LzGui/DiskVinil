// <auto-generated />
using System;
using DiskVinil.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DiskVinil.Migrations
{
    [DbContext(typeof(LocalDbContext))]
    [Migration("20210410144837_Adicionando Discos")]
    partial class AdicionandoDiscos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DiskVinil.Entities.Disco", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("ano")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("autor")
                        .HasColumnType("text");

                    b.Property<int>("faixa")
                        .HasColumnType("integer");

                    b.Property<char>("lado")
                        .HasColumnType("character(1)");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("discos");
                });
#pragma warning restore 612, 618
        }
    }
}
