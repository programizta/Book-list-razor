using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_library
{
    public class EditBookModel : PageModel
    {
        public AppDbContext dbContext { get; set; }

        [BindProperty]
        public Book Book { get; set; }

        public EditBookModel(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task OnGet(int id)
        {
            Book = await dbContext.Books.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookToUpdate = await dbContext
                    .Books
                    .FindAsync(Book.BookId);

                bookToUpdate.Author = Book.Author;
                bookToUpdate.Title = Book.Title;
                bookToUpdate.ISBN = Book.ISBN;

                await dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}