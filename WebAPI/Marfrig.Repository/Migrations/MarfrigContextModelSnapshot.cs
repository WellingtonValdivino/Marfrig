﻿// <auto-generated />
using System;
using Marfrig.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marfrig.Repository.Migrations
{
    [DbContext(typeof(MarfrigContext))]
    partial class MarfrigContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Marfrig.Domain.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<double>("Preco");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("Marfrig.Domain.CompraGado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEntrega");

                    b.Property<int>("PecuaristaId");

                    b.HasKey("Id");

                    b.HasIndex("PecuaristaId");

                    b.ToTable("CompraGados");
                });

            modelBuilder.Entity("Marfrig.Domain.CompraGadoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalId");

                    b.Property<int>("CompraGadoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("CompraGadoId");

                    b.ToTable("CompraGadoitens");
                });

            modelBuilder.Entity("Marfrig.Domain.Pecuarista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Pecuaristas");
                });

            modelBuilder.Entity("Marfrig.Domain.CompraGado", b =>
                {
                    b.HasOne("Marfrig.Domain.Pecuarista", "Pecuarista")
                        .WithMany()
                        .HasForeignKey("PecuaristaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Marfrig.Domain.CompraGadoItem", b =>
                {
                    b.HasOne("Marfrig.Domain.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Marfrig.Domain.CompraGado", "CompraGado")
                        .WithMany()
                        .HasForeignKey("CompraGadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
