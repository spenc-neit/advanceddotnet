using Microsoft.EntityFrameworkCore;
using midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class GenreFunctions
    {
        public static List<Genre> GetAllGenres()
        {
            using (var db = new SE407_BookstoreContext())
            {
                return db.Genres.ToList();
            }
        }

        public static Genre GetGenreById(int id)
        {
            using (var db = new SE407_BookstoreContext())
            {
                return db.Genres.FirstOrDefault(e => e.GenreId == id);
            }
        }

        public static void AddGenre(Genre genre)
        {
            try
            {
                using (var db = new SE407_BookstoreContext())
                {
                    db.Genres.Add(genre);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void EditGenre(Genre genre)
        {
            try
            {
                using (var db = new SE407_BookstoreContext())
                {
                    db.Genres.Update(genre);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void DeleteGenre(int id)
        {
            try
            {
                using (var db = new SE407_BookstoreContext())
                {
                    var gtd = db.Genres.Find(id);
                    db.Genres.Remove(gtd);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
