using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleLibraryApp_DataAccess.Models;
using SimpleLibraryApp_DataAccess.Services;
using SimpleLibraryApp_MVC.Models;

namespace SimpleLibraryApp_MVC.Controllers
{
    public class CustomerController : Controller
    {
        CustomerService customerService = new();
        BookService bookService = new();
        LentBookService lentBookService = new();
        public async Task<IActionResult> Index(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                var customers = await customerService.GetAllCustomers();
                return View(customers);
            }
            else
            {
                var customers = await customerService.GetSearchedCustomers(query);
                return View(customers);
            }
        }

        public async Task<IActionResult> LentBooks(int id)
        {
            Customer customer = await customerService.GetCustomerById(id);
            List<LentBook> LentBooks = await customerService.GetCustomerLentBooks(id);
            LentBooksViewModel lentBooksViewModel = new()
            {
                Customer = customer,
                LentBooks = LentBooks
            };
            return View(lentBooksViewModel);
        }

        public async Task<IActionResult> LendBook(int id)
        {
            LendBookViewModel lendBookViewModel = new()
            {
                Customer = await customerService.GetCustomerById(id),
                Books = await bookService.GetAllBooks()
            };
            return View(lendBookViewModel);
        }

        public async Task<IActionResult> CreateBookLend(int bookId, int customerId)
        {
            LentBook newLend = new()
            {
                CustomerId = customerId,
                BookId = bookId,
                DateLent = DateTime.Now
            };
            await customerService.CreateBookLend(newLend);

            Customer customer = await customerService.GetCustomerById(customerId);
            List<LentBook> LentBooks = await customerService.GetCustomerLentBooks(customerId);
            LentBooksViewModel lentBooksViewModel = new()
            {
                Customer = customer,
                LentBooks = LentBooks
            };
            return View("LentBooks", lentBooksViewModel);
        }

        public async Task<IActionResult> ReturnBook(int id)
        {
            LentBook lentBook = await lentBookService.GetLentBookById(id);
            int customerId = lentBook.CustomerId;
                   
            await customerService.ReturnBook(id);
            Customer customer = await customerService.GetCustomerById(customerId);
            List<LentBook> LentBooks = await customerService.GetCustomerLentBooks(customerId);
            LentBooksViewModel lentBooksViewModel = new()
            {
                Customer = customer,
                LentBooks = LentBooks
            };
            return View("LentBooks", lentBooksViewModel);
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FName,LName,MailAdress,PhoneNumber")] Customer newCustomer)
        {
            if (ModelState.IsValid)
            {
                await customerService.CreateCustomer(newCustomer);
                return RedirectToAction(nameof(Index));
            }
            return View(newCustomer);
        }

        //Edit
        public async Task<IActionResult> Edit(int id)
        {
            return View(await customerService.GetCustomerById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,FName,LName,MailAdress,PhoneNumber")] Customer newCustomer)
        {
            if (ModelState.IsValid)
            {
                await customerService.EditCustomer(newCustomer);
                return RedirectToAction(nameof(Index));
            }
            return View(newCustomer);
        }

        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            return View(await customerService.GetCustomerById(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await customerService.DeleteCustomer(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
