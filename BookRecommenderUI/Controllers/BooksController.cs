using BookRecommenderUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookRecommenderUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BookService _bookService;
        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _bookService.GetBooks();
            return Ok(result);
        }
    }
}
