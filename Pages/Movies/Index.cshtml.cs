using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Zadanie_back.Data;
using Zadanie_back.Models;

namespace Zadanie_back.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Zadanie_back.Data.Zadanie_backContext _context;

        public IndexModel(Zadanie_back.Data.Zadanie_backContext context)
        {
            _context = context;
        }
        public IList<Movie> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Product_department
                                            select m.Product_department;

            var movies = from m in _context.Movie
                         select m;

            if (!String.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Product_name.Contains(SearchString));
            }

            if (!String.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Product_department == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}