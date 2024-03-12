using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using midterm;
using midterm.Models;

namespace BookstoreWebApp.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {
            return View(AuthorFunctions.GetAllAuthors());
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author authorToCreate)
        {
            try
            {
                AuthorFunctions.AddAuthor(authorToCreate);
                return RedirectToAction("Index", "Author");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(AuthorFunctions.GetAuthorById(id));
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author authorToEdit)
        {
            try
            {
                AuthorFunctions.EditAuthor(authorToEdit);
                return RedirectToAction("Index", "Author");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(AuthorFunctions.GetAuthorById(id));
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Author author)
        {
            try
            {
                AuthorFunctions.DeleteAuthor(author.AuthorId);
                return RedirectToAction("Index", "Author");
            }
            catch
            {
                return View();
            }
        }
    }
}
