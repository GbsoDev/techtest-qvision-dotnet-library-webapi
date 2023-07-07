﻿// <auto-generated />
using System;
using GbsoDev.TechTest.Library.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GbsoDev.TechTest.Library.Dal.Migrations
{
    [DbContext(typeof(RootContext))]
    partial class RootContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GbsoDev.TechTest.Library.El.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 7, 9, 29, 24, 560, DateTimeKind.Local).AddTicks(5956));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("autores", (string)null);
                });

            modelBuilder.Entity("GbsoDev.TechTest.Library.El.Editorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Sede")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("Editoriales", (string)null);
                });

            modelBuilder.Entity("GbsoDev.TechTest.Library.El.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ISBN");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditorialId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("NPaginas")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.HasIndex("EditorialId");

                    b.ToTable("libros", (string)null);
                });

            modelBuilder.Entity("autores_has_libros", b =>
                {
                    b.Property<int>("autores_id")
                        .HasColumnType("int");

                    b.Property<int>("libros_ISBN")
                        .HasColumnType("int");

                    b.HasKey("autores_id", "libros_ISBN");

                    b.HasIndex("libros_ISBN");

                    b.ToTable("autores_has_libros", (string)null);
                });

            modelBuilder.Entity("GbsoDev.TechTest.Library.El.Libro", b =>
                {
                    b.HasOne("GbsoDev.TechTest.Library.El.Editorial", "Editorial")
                        .WithMany("Libros")
                        .HasForeignKey("EditorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editorial");
                });

            modelBuilder.Entity("autores_has_libros", b =>
                {
                    b.HasOne("GbsoDev.TechTest.Library.El.Autor", null)
                        .WithMany()
                        .HasForeignKey("autores_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GbsoDev.TechTest.Library.El.Libro", null)
                        .WithMany()
                        .HasForeignKey("libros_ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GbsoDev.TechTest.Library.El.Editorial", b =>
                {
                    b.Navigation("Libros");
                });
#pragma warning restore 612, 618
        }
    }
}