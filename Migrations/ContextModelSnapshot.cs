﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP02.Data;

#nullable disable

namespace TP02.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TP02.Models.Bl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Consignee")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("consignee");

                    b.Property<int>("Ship")
                        .HasColumnType("int")
                        .HasColumnName("ship");

                    b.HasKey("Id");

                    b.ToTable("bls");
                });

            modelBuilder.Entity("TP02_MVC.Models.Container", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("BlId")
                        .HasColumnType("int")
                        .HasColumnName("bl_id");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("size");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("BlId");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("TP02_MVC.Models.Container", b =>
                {
                    b.HasOne("TP02_MVC.Models.Bl", "Bl")
                        .WithMany("Containers")
                        .HasForeignKey("BlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bl");
                });

            modelBuilder.Entity("TP02_MVC.Models.Bl", b =>
                {
                    b.Navigation("Containers");
                });
#pragma warning restore 612, 618
        }
    }
}
