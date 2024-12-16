using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Booker.App.Services;

namespace Booker.App.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAllBooksAsync();
            return View(books); 
        }

        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Details(int id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book); 
        }

    }
}