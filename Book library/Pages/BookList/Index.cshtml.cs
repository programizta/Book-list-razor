using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Book_library
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext dbContext;
        public IEnumerable<Book> Books { get; set; }

        public IndexModel(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task OnGet()
        {
            Books = await dbContext.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var bookToRemove = await dbContext
                .Books
                .FindAsync(id);

            if (bookToRemove is null) return NotFound();

            dbContext.Books.Remove(bookToRemove);
            dbContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}