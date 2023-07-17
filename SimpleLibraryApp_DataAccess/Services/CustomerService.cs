using Microsoft.EntityFrameworkCore;
using SimpleLibraryApp_DataAccess.Data;
using SimpleLibraryApp_DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLibraryApp_DataAccess.Services
{
    public class CustomerService
    {
        private readonly DataContext _context = new();

        public async Task<List<Customer>> GetAllCustomers()
        {
            var customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public async Task<Customer> GetCustomerById(int customerId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
            return customer;
        }

        public async Task<List<Customer>> GetSearchedCustomers(string query)
        {
            var customers = await _context.Customers
                .Where(c => c.FName.Contains(query) || c.LName.Contains(query))
                .ToListAsync();

            return customers;
        }

        public async Task CreateCustomer(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task EditCustomer(Customer newCustomer)
        {
            _context.Customers.Update(newCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCustomer(int customerId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task CreateBookLend(LentBook newBookLend)
        {
            _context.LentBooks.Add(newBookLend);
            await _context.SaveChangesAsync();
        }

        public async Task<List<LentBook>> GetCustomerLentBooks(int customerId)
        {
            var LentBooks = await _context.LentBooks
                .Where(rb => rb.CustomerId == customerId)
                .Include(rb => rb.Book)
                .Include(rb => rb.Customer)
                .ToListAsync();

            return LentBooks;
        }

        public async Task ReturnBook(int id)
        {
            var lentBook = await _context.LentBooks.FirstOrDefaultAsync(rb => rb.Id == id);
            Console.WriteLine("ID:" + id + "returned:" + lentBook.IsReturned);
            lentBook.IsReturned = true;
            Console.WriteLine("returned:" + lentBook.IsReturned);
            _context.LentBooks.Update(lentBook);
            await _context.SaveChangesAsync();
        }
    }
}
