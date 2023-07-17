﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleLibraryApp_DataAccess.Data;

#nullable disable

namespace SimpleLibraryApp_DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230717164436_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleLibraryApp_DataAccess.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("SimpleLibraryApp_DataAccess.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MailAdress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "John",
                            LName = "Doe",
                            MailAdress = "john.doe@example.com",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            FName = "Jane",
                            LName = "Smith",
                            MailAdress = "jane.smith@example.com",
                            PhoneNumber = "9876543210"
                        },
                        new
                        {
                            Id = 3,
                            FName = "Michael",
                            LName = "Johnson",
                            MailAdress = "michael.johnson@example.com",
                            PhoneNumber = "5555555555"
                        },
                        new
                        {
                            Id = 4,
                            FName = "Emily",
                            LName = "Brown",
                            MailAdress = "emily.brown@example.com",
                            PhoneNumber = "9998887777"
                        },
                        new
                        {
                            Id = 5,
                            FName = "David",
                            LName = "Davis",
                            MailAdress = "david.davis@example.com",
                            PhoneNumber = "1112223333"
                        });
                });

            modelBuilder.Entity("SimpleLibraryApp_DataAccess.Models.LentBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateLent")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsReturned")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("LentBooks");
                });

            modelBuilder.Entity("SimpleLibraryApp_DataAccess.Models.LentBook", b =>
                {
                    b.HasOne("SimpleLibraryApp_DataAccess.Models.Book", "Book")
                        .WithMany("LentBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleLibraryApp_DataAccess.Models.Customer", "Customer")
                        .WithMany("LentBooks")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SimpleLibraryApp_DataAccess.Models.Book", b =>
                {
                    b.Navigation("LentBooks");
                });

            modelBuilder.Entity("SimpleLibraryApp_DataAccess.Models.Customer", b =>
                {
                    b.Navigation("LentBooks");
                });
#pragma warning restore 612, 618
        }
    }
}