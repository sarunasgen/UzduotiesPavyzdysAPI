using UzduotiesPavyzdysAPI.Contracts;
using UzduotiesPavyzdysAPI.Models;

namespace UzduotiesPavyzdysAPI.Services
{
    public class BookService : IBookService
    {
        List<Book> AllBooks = new List<Book>();

        public void AddBook(Book book)
        {
            AllBooks.Add(book);
        }
        public Book GetBookById(int id)
        {
            foreach(Book b in AllBooks)
            {
                if (b.Id == id)
                    return b;
            }
            return null;
        }
        public List<Book> GetAllBooks()
        {
            return AllBooks;
        }
        public void DeleteBook(int id)
        {
            AllBooks.Remove(GetBookById(id));
        }
        public void UpdateBook(Book book)
        {
            foreach(Book b in AllBooks)
            {
                if (b.Id == book.Id)
                {
                    b.Title = book.Title;
                    b.Author = book.Author;
                    b.Year = book.Year;
                }
                    
            }
        }

    }
}
