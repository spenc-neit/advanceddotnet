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
                return db.Movies.Find(id);
            }
        }

        public static List<Movie> GetAllMovies()
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Movies.ToList();
            }
        }

        public static List<Transaction> GetAllCheckedOutMovies()
        {
            using (var db = new SE407_BlockBusterContext())
            {
                return db.Transactions.Include(t => t.Movie).Where(t => t.CheckedIn == "N").ToList();
            }
        }
    }
}
