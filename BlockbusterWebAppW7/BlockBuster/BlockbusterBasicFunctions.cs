using BlockBuster.Models;
using Microsoft.EntityFrameworkCore;

namespace BlockBuster
{
    public class BlockbusterBasicFunctions
    {
        public static Movie GetMovieById(int id)
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Movies.Include(m => m.Genre).Include(m => m.Director).FirstOrDefault(e => e.MovieId == id);
            }
        }

        public static List<Movie> GetAllMovies()
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Movies.Include(m => m.Director).Include(m=>m.Genre).ToList();
            }
        }

        public static List<Transaction> GetAllCheckedOutMoviesT()
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Transactions.Include(t => t.Movie).Where(t => t.CheckedIn == "N").ToList();
            }
        }
        public static List<Movie> GetAllCheckedOutMoviesM()
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Movies.Include(t => t.Transactions.Where(t => t.CheckedIn == "N")).Include(m => m.Genre).Include(m => m.Director).ToList();
            }
        }



    }
}
