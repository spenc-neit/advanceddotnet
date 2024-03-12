using midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace midterm
{
    public class BookFunctions
    {
        public static Book GetBookByTitle(string pTitle)
        {
            using (var db = new SE407_BookstoreContext())
            {
                return db.Books.Include(m => m.Genre).Include(m => m.Author).FirstOrDefault(e => e.BookTitle == pTitle);
            }
        }

        public static List<Book> GetAllBooksByAuthorLastName(string name)
        {
            using (var db = new SE407_BookstoreContext())
            {
                return db.Books.Include(t => t.Author).Where(t => t.Author.AuthorLast == name).Include(m => m.Genre).ToList();
            }
        }

        public static List<Book> GetAllBooks()
        {
            using (var db = new SE407_BookstoreContext())
            {
                return db.Books.Include(m => m.Author).Include(m => m.Genre).ToList();
            }
        }

        public static Book GetBookById(int id)
        {
            using (var db = new SE407_BookstoreContext())
            {
                return db.Books.Include(m => m.Genre).Include(m => m.Author).FirstOrDefault(e => e.BookId == id);
            }
        }

        public static void AddBook(Book book)
        {
            try
            {
                using (var db = new SE407_BookstoreContext())
                {
                    db.Books.Add(book);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void EditBook(Book book)
        {
            try
            {
                using(var db = new SE407_BookstoreContext())
                {
                    db.Books.Update(book);
                    db.SaveChanges();
                }
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void DeleteBook(int id)
        {
            try
            {
                using (var db = new SE407_BookstoreContext())
                {
                    var btd = db.Books.Find(id);
                    db.Books.Remove(btd);
                    db.SaveChanges();
                }
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
