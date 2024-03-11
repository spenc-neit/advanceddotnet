using Microsoft.AspNetCore.Mvc.Rendering;
using BlockBuster;

namespace BlockbusterWebApp.Helpers
{
    public class DropdownFormatter
    {
        public static SelectList FormatDirectors()
        {
            return new SelectList(BlockbusterBasicFunctions.GetAllDirectors()
                .OrderBy(d=>d.LastName)
                .ToDictionary(d => d.DirectorId, d => d.LastName + ", " + d.FirstName), "Key", "Value");
        }

        public static SelectList FormatGenres()
        {
            return new SelectList(BlockbusterBasicFunctions.GetAllGenres()
                .OrderBy(g => g.GenreDescr)
                .ToDictionary(g => g.GenreId, g => g.GenreDescr), "Key", "Value");
        }
    }
}
