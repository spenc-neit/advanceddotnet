using BookstoreWebApp.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using midterm;
using midterm.Models;

namespace BookstoreWebApp.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View(BookFunctions.GetBookById(id));
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = DropdownFormatter.GenreDropdown();
            ViewBag.AuthorId = DropdownFormatter.AuthorDropdown();
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book bookToCreate)
        {
            try
            {
                BookFunctions.AddBook(bookToCreate);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.GenreId = DropdownFormatter.GenreDropdown();
            ViewBag.AuthorId = DropdownFormatter.AuthorDropdown();
            return View(BookFunctions.GetBookById(id));
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book bookToEdit)
        {
            try
            {
                BookFunctions.EditBook(bookToEdit);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(BookFunctions.GetBookById(id));
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Book book)
        {
            try
            {
                BookFunctions.DeleteBook(book.BookId);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
