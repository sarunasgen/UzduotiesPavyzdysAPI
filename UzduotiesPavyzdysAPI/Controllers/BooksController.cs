using Microsoft.AspNetCore.Mvc;
using UzduotiesPavyzdysAPI.Contracts;
using UzduotiesPavyzdysAPI.Models;

namespace UzduotiesPavyzdysAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }
        [HttpGet("GetBooksById")]
        public Book GetBooksById(int id)
        {
            return _bookService.GetBookById(id);
        }
        [HttpPost("AddBook")]
        public void AddBook(Book book)
        {
            _bookService.AddBook(book);
        }
        [HttpDelete("DeleteBook")]
        public void DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
        }
        [HttpPut("UpdateBook")]
        public void UpdateBook(Book book)
        {
            _bookService.UpdateBook(book);
        }

    }
}
