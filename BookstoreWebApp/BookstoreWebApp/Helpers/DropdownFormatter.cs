using Microsoft.AspNetCore.Mvc.Rendering;
using midterm;

namespace BookstoreWebApp.Helpers
{
    public class DropdownFormatter
    {
        //author, genre
        public static SelectList AuthorDropdown()
        {
            return new SelectList(AuthorFunctions.GetAllAuthors()
                .OrderBy(a=>a.AuthorLast)
                .ToDictionary(a=>a.AuthorId, a=>a.AuthorLast + ", " + a.AuthorFirst), "Key", "Value");
        }

        public static SelectList GenreDropdown()
        {
            return new SelectList(GenreFunctions.GetAllGenres()
                .OrderBy(g => g.GenreType)
                .ToDictionary(g => g.GenreId, g => g.GenreType), "Key", "Value");
        }
    }
}
