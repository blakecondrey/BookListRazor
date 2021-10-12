using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookListRazor.Data;
using BookListRazor.Model;

namespace BookListRazor.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookListRazor.Data.ApplicationDbContext _context;

        public IndexModel(BookListRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            // using System.Linq
            var books = from b in _context.Book
                        select b;
            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.Title.Contains(SearchString));
            }

            Book = await books.ToListAsync();
        }
    }
}
