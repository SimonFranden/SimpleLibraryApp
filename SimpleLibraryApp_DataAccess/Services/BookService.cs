using Microsoft.EntityFrameworkCore;
using SimpleLibraryApp_DataAccess.Data;
using SimpleLibraryApp_DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryApp_DataAccess.Services
{
    public class BookService
    {
        private readonly DataContext _context = new();

        public async Task<List<Book>> GetAllBooks()
        {
            var books = await _context.Books.ToListAsync();
            return (books);
        }

        public async Task<Book> GetBookById(int bookId)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == bookId);
            return book;
        }

        public async Task<List<Book>> GetSearchedBooks(string query)
        {
            var books = await _context.Books
                .Where(b => b.Title.Contains(query) || b.Author.Contains(query))
                .ToListAsync();

            return books;
        }

        public async Task CreateBook(Book newBook)
        {
            _context.Books.Add(newBook);
            await _context.SaveChangesAsync();
        }

        public async Task EditBook(Book newBook)
        {
            _context.Books.Update(newBook);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBook(int bookId)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == bookId);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
