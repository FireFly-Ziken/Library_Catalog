using LibraryCatalog.Data;
using LibraryCatalog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryCatalog.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : Controller
    {
        private readonly BooksApiDbContext dbContext;
        public BooksController(BooksApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            return Ok(await dbContext.Books.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBook(Guid id)
        {
            var book = await dbContext.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(AddBookRequestModel addBookRequest)
        {
            var book = new BookModel()
            {
                Id = Guid.NewGuid(),
                Author = addBookRequest.Author,
                Title = addBookRequest.Title,
                Year = addBookRequest.Year,
                PageCount = addBookRequest.PageCount,
                PurchaseDate = addBookRequest.PurchaseDate
            };
            await dbContext.Books.AddAsync(book);
            await dbContext.SaveChangesAsync();
            return Ok(book);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateBook(Guid id, UpdateBookRequestModel updateBookRequest)
        {
            var book = await dbContext.Books.FindAsync(id);
            if (book == null) return NotFound();
            book.Author = updateBookRequest.Author;
            book.Title = updateBookRequest.Title;
            book.Year = updateBookRequest.Year;
            book.PageCount = updateBookRequest.PageCount;
            book.PurchaseDate = updateBookRequest.PurchaseDate;

            await dbContext.SaveChangesAsync();
            return Ok(book);

        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            var book = await dbContext.Books.FindAsync(id);
            if (book == null) return NotFound();
            dbContext.Remove(book);
            await dbContext.SaveChangesAsync();
            return Ok(book);
        }
    }
}
