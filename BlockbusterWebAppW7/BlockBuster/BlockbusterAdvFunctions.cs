using BlockBuster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace BlockBuster
{
    public class BlockbusterAdvFunctions
    {
        public static List<Movie> GetAllMoviesByGenre(string genre)
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Movies.Include(t => t.Genre).Where(t => t.Genre.GenreDescr == genre).Include(m => m.Director).ToList();
            }
        }

        public static List<Movie> GetAllMoviesByDirectorLastName(string name)
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Movies.Include(t=>t.Director).Where(t=>t.Director.LastName == name).Include(m=>m.Genre).ToList();
            }
        }

        public static Movie GetMovieByTitle(string pTitle)
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Movies.Include(m => m.Genre).Include(m => m.Director).FirstOrDefault(e=>e.Title == pTitle);
            }
        }
    }
}
