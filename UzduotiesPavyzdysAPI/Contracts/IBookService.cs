using UzduotiesPavyzdysAPI.Models;

namespace UzduotiesPavyzdysAPI.Contracts
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        void DeleteBook(int id);
        void UpdateBook(Book book);
        Book GetBookById(int id);
    }
}