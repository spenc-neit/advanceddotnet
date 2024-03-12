using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace midterm.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        [Display(Name = "Author ID")]
        public int AuthorId { get; set; }
        [Display(Name = "First Name")]
        public string AuthorFirst { get; set; } = null!;
        [Display(Name = "Last Name")]
        public string AuthorLast { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
