using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_library
{
    public class UpsertBookModel : PageModel
    {
        public AppDbContext dbContext { get; set; }

        [BindProperty]
        public Book Book { get; set; }

        public UpsertBookModel(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> OnGet(int? id)
        {
            Book = new Book();
            // if user is not passing any number insert book to database
            if (id is null)
            {
                return Page();
            }

            // otherwise retrieve existing book from db and update it
            Book = await dbContext.Books.FindAsync(id);
            if (Book is null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Book.BookId == 0)
                {
                    dbContext.Books.Add(Book);
                }
                else
                {
                    dbContext.Books.Update(Book);
                }

                await dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}