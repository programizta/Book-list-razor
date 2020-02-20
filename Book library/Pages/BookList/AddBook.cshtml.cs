using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_library
{
    public class AddBookModel : PageModel
    {
        private readonly AppDbContext dbContext;
        public Book Book { get; set; }

        public AddBookModel(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnGet()
        {

        }
    }
}