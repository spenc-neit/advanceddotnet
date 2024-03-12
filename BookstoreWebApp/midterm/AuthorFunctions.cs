using Microsoft.EntityFrameworkCore;
using midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class AuthorFunctions
    {
        public static List<Author> GetAllAuthors()
        {
            using (var db = new SE407_BookstoreContext())
            {
                return db.Authors.ToList();
            }
        }

        public static Author GetAuthorById(int id)
        {
            using (var db = new SE407_BookstoreContext())
            {
                return db.Authors.FirstOrDefault(e => e.AuthorId == id);
            }
        }

        public static void AddAuthor(Author author)
        {
            try
            {
                using (var db = new SE407_BookstoreContext())
                {
                    db.Authors.Add(author);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void EditAuthor(Author author)
        {
            try
            {
                using (var db = new SE407_BookstoreContext())
                {
                    db.Authors.Update(author);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void DeleteAuthor(int id)
        {
            try
            {
                using (var db = new SE407_BookstoreContext())
                {
                    var atd = db.Authors.Find(id);
                    db.Authors.Remove(atd);
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
