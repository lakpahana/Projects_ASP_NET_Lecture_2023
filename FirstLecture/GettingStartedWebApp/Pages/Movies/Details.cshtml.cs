using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GettingStartedWebApp.Data;
using GettingStartedWebApp.Models;

namespace GettingStartedWebApp.Pages_Movies
{
    public class DetailsModel : PageModel
    {
        private readonly GettingStartedWebApp.Data.GettingStartedWebAppContext _context;

        public DetailsModel(GettingStartedWebApp.Data.GettingStartedWebAppContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
