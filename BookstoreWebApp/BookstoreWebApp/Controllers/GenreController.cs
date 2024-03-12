using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using midterm;
using midterm.Models;

namespace BookstoreWebApp.Controllers
{
    public class GenreController : Controller
    {
        // GET: GenreController
        public ActionResult Index()
        {
            return View(GenreFunctions.GetAllGenres());
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genreToCreate) {
            
            try
            {
                GenreFunctions.AddGenre(genreToCreate);
                return RedirectToAction("Index", "Genre");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(GenreFunctions.GetGenreById(id));
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genreToEdit)
        {
            try
            {
                GenreFunctions.EditGenre(genreToEdit);
                return RedirectToAction("Index", "Genre");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GenreFunctions.GetGenreById(id));
        }

        // POST: GenreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Genre genre)
        {
            try
            {
                GenreFunctions.DeleteGenre(genre.GenreId);
                return RedirectToAction("Index", "Genre");
            }
            catch
            {
                return View();
            }
        }
        
    }
    
}
