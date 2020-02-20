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
    }
}