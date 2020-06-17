using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TutorialForRazorPage.Data;
using TutorialForRazorPage.Models;

namespace TutorialForRazorPage.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly TutorialForRazorPage.Data.TutorialForRazorPageContext _context;

        public IndexModel(TutorialForRazorPage.Data.TutorialForRazorPageContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
