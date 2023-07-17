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
    [Migration("20230717164507_SeedingData")]
    partial class SeedingData
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Paulo Coelho",
                            Title = "The Alchemist"
                        },
                        new
                        {
                            Id = 2,
                            Author = "J.K. Rowling",
                            Title = "Harry Potter and the Sorcerer's Stone"
                        },
                        new
                        {
                            Id = 3,
                            Author = "J.R.R. Tolkien",
                            Title = "The Lord of the Rings: The Fellowship of the Ring"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Harper Lee",
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 5,
                            Author = "F. Scott Fitzgerald",
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Jane Austen",
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            Id = 7,
                            Author = "George Orwell",
                            Title = "1984"
                        },
                        new
                        {
                            Id = 8,
                            Author = "J.D. Salinger",
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            Id = 9,
                            Author = "C.S. Lewis",
                            Title = "The Chronicles of Narnia: The Lion, the Witch, and the Wardrobe"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Herman Melville",
                            Title = "Moby-Dick"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Virginia Woolf",
                            Title = "To the Lighthouse"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Douglas Adams",
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Oscar Wilde",
                            Title = "The Picture of Dorian Gray"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Aldous Huxley",
                            Title = "Brave New World"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Charlotte Brontë",
                            Title = "Jane Eyre"
                        },
                        new
                        {
                            Id = 16,
                            Author = "J.R.R. Tolkien",
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = 17,
                            Author = "Alexandre Dumas",
                            Title = "The Count of Monte Cristo"
                        },
                        new
                        {
                            Id = 18,
                            Author = "Gabriel García Márquez",
                            Title = "One Hundred Years of Solitude"
                        },
                        new
                        {
                            Id = 19,
                            Author = "Fyodor Dostoevsky",
                            Title = "Crime and Punishment"
                        },
                        new
                        {
                            Id = 20,
                            Author = "Antoine de Saint-Exupéry",
                            Title = "The Little Prince"
                        },
                        new
                        {
                            Id = 21,
                            Author = "Emily Brontë",
                            Title = "Wuthering Heights"
                        },
                        new
                        {
                            Id = 22,
                            Author = "Stephen King",
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 23,
                            Author = "Margaret Atwood",
                            Title = "The Handmaid's Tale"
                        },
                        new
                        {
                            Id = 24,
                            Author = "Oscar Wilde",
                            Title = "The Picture of Dorian Gray"
                        },
                        new
                        {
                            Id = 25,
                            Author = "Joseph Heller",
                            Title = "The Catch-22"
                        },
                        new
                        {
                            Id = 26,
                            Author = "Dan Brown",
                            Title = "The Da Vinci Code"
                        },
                        new
                        {
                            Id = 27,
                            Author = "Margaret Mitchell",
                            Title = "Gone with the Wind"
                        },
                        new
                        {
                            Id = 28,
                            Author = "John Steinbeck",
                            Title = "The Grapes of Wrath"
                        },
                        new
                        {
                            Id = 29,
                            Author = "Mary Shelley",
                            Title = "Frankenstein"
                        },
                        new
                        {
                            Id = 30,
                            Author = "Khaled Hosseini",
                            Title = "The Kite Runner"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CustomerId = 1,
                            DateLent = new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReturned = false
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CustomerId = 2,
                            DateLent = new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReturned = true
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            CustomerId = 3,
                            DateLent = new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReturned = false
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            CustomerId = 4,
                            DateLent = new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReturned = false
                        },
                        new
                        {
                            Id = 5,
                            BookId = 5,
                            CustomerId = 5,
                            DateLent = new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReturned = true
                        },
                        new
                        {
                            Id = 6,
                            BookId = 3,
                            CustomerId = 2,
                            DateLent = new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReturned = true
                        },
                        new
                        {
                            Id = 7,
                            BookId = 1,
                            CustomerId = 4,
                            DateLent = new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReturned = false
                        },
                        new
                        {
                            Id = 8,
                            BookId = 4,
                            CustomerId = 3,
                            DateLent = new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReturned = false
                        });
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
