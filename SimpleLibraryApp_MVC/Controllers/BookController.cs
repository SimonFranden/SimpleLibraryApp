using Microsoft.AspNetCore.Mvc;
using SimpleLibraryApp_DataAccess.Models;
using SimpleLibraryApp_DataAccess.Services;

namespace SimpleLibraryApp_MVC.Controllers
{
    public class BookController : Controller
    {
        BookService bookService = new();

        public async Task<IActionResult> Index(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                var books = await bookService.GetAllBooks();
                return View(books);
            }
            else
            {
                var books = await bookService.GetSearchedBooks(query);
                return View(books);
            }
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Title")] Book newBook)
        {
            if (ModelState.IsValid)
            {
                await bookService.CreateBook(newBook);
                return RedirectToAction(nameof(Index));
            }
            return View(newBook);
        }

        //Edit
        public async Task<IActionResult> Edit(int id)
        {
            return View(await bookService.GetBookById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,Title")] Book newBook)
        {
            if (ModelState.IsValid)
            {
                await bookService.EditBook(newBook);
                return RedirectToAction(nameof(Index));
            }
            return View(newBook);
        }

        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            return View(await bookService.GetBookById(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await bookService.DeleteBook(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
