using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TutorialForRazorPage.Models;

namespace TutorialForRazorPage.Data
{
    public class TutorialForRazorPageContext : DbContext
    {
        public TutorialForRazorPageContext (DbContextOptions<TutorialForRazorPageContext> options)
            : base(options)
        {
        }

        public DbSet<TutorialForRazorPage.Models.Movie> Movie { get; set; }
    }
}
