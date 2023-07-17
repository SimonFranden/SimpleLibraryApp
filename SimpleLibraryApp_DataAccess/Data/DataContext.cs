using SimpleLibraryApp_DataAccess;
using SimpleLibraryApp_DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;

namespace SimpleLibraryApp_DataAccess.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookLendrDB;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<LentBook> LentBooks => Set<LentBook>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FName = "John", LName = "Doe", PhoneNumber = "1234567890", MailAdress = "john.doe@example.com" },
                new Customer { Id = 2, FName = "Jane", LName = "Smith", PhoneNumber = "9876543210", MailAdress = "jane.smith@example.com" },
                new Customer { Id = 3, FName = "Michael", LName = "Johnson", PhoneNumber = "5555555555", MailAdress = "michael.johnson@example.com" },
                new Customer { Id = 4, FName = "Emily", LName = "Brown", PhoneNumber = "9998887777", MailAdress = "emily.brown@example.com" },
                new Customer { Id = 5, FName = "David", LName = "Davis", PhoneNumber = "1112223333", MailAdress = "david.davis@example.com" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Alchemist", Author = "Paulo Coelho" },
                new Book { Id = 2, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling" },
                new Book { Id = 3, Title = "The Lord of the Rings: The Fellowship of the Ring", Author = "J.R.R. Tolkien" },
                new Book { Id = 4, Title = "To Kill a Mockingbird", Author = "Harper Lee" },
                new Book { Id = 5, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
                new Book { Id = 6, Title = "Pride and Prejudice", Author = "Jane Austen" },
                new Book { Id = 7, Title = "1984", Author = "George Orwell" },
                new Book { Id = 8, Title = "The Catcher in the Rye", Author = "J.D. Salinger" },
                new Book { Id = 9, Title = "The Chronicles of Narnia: The Lion, the Witch, and the Wardrobe", Author = "C.S. Lewis" },
                new Book { Id = 10, Title = "Moby-Dick", Author = "Herman Melville" },
                new Book { Id = 11, Title = "To the Lighthouse", Author = "Virginia Woolf" },
                new Book { Id = 12, Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams" },
                new Book { Id = 13, Title = "The Picture of Dorian Gray", Author = "Oscar Wilde" },
                new Book { Id = 14, Title = "Brave New World", Author = "Aldous Huxley" },
                new Book { Id = 15, Title = "Jane Eyre", Author = "Charlotte Brontë" },
                new Book { Id = 16, Title = "The Hobbit", Author = "J.R.R. Tolkien" },
                new Book { Id = 17, Title = "The Count of Monte Cristo", Author = "Alexandre Dumas" },
                new Book { Id = 18, Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez" },
                new Book { Id = 19, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky" },
                new Book { Id = 20, Title = "The Little Prince", Author = "Antoine de Saint-Exupéry" },
                new Book { Id = 21, Title = "Wuthering Heights", Author = "Emily Brontë" },
                new Book { Id = 22, Title = "The Shining", Author = "Stephen King" },
                new Book { Id = 23, Title = "The Handmaid's Tale", Author = "Margaret Atwood" },
                new Book { Id = 24, Title = "The Picture of Dorian Gray", Author = "Oscar Wilde" },
                new Book { Id = 25, Title = "The Catch-22", Author = "Joseph Heller" },
                new Book { Id = 26, Title = "The Da Vinci Code", Author = "Dan Brown" },
                new Book { Id = 27, Title = "Gone with the Wind", Author = "Margaret Mitchell" },
                new Book { Id = 28, Title = "The Grapes of Wrath", Author = "John Steinbeck" },
                new Book { Id = 29, Title = "Frankenstein", Author = "Mary Shelley" },
                new Book { Id = 30, Title = "The Kite Runner", Author = "Khaled Hosseini" }
            );


            modelBuilder.Entity<LentBook>().HasData(
                new LentBook { Id = 1, BookId = 1, CustomerId = 1, DateLent = new DateTime(2023, 1, 10), IsReturned = false },
                new LentBook { Id = 2, BookId = 2, CustomerId = 2, DateLent = new DateTime(2023, 2, 15), IsReturned = true },
                new LentBook { Id = 3, BookId = 3, CustomerId = 3, DateLent = new DateTime(2023, 3, 20), IsReturned = false },
                new LentBook { Id = 4, BookId = 4, CustomerId = 4, DateLent = new DateTime(2023, 4, 25), IsReturned = false },
                new LentBook { Id = 5, BookId = 5, CustomerId = 5, DateLent = new DateTime(2023, 5, 30), IsReturned = true },
                new LentBook { Id = 6, BookId = 3, CustomerId = 2, DateLent = new DateTime(2023, 6, 5), IsReturned = true },
                new LentBook { Id = 7, BookId = 1, CustomerId = 4, DateLent = new DateTime(2023, 7, 12), IsReturned = false },
                new LentBook { Id = 8, BookId = 4, CustomerId = 3, DateLent = new DateTime(2023, 8, 18), IsReturned = false }
            );

        }

    }
}
