using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_library.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly AppDbContext dbContext;

        public BookController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Json(new { data = await dbContext.Books.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var bookToDelete = await dbContext
                .Books
                .FirstOrDefaultAsync(x => x.BookId == id);

            if (bookToDelete is null)
            {
                return Json(new { success = false, message = "An error appeared while deleting book." });
            }

            dbContext.Books.Remove(bookToDelete);
            await dbContext.SaveChangesAsync();
            return Json(new { success = true, message = "Book has been deleted successfully!" });
        }
    }
}