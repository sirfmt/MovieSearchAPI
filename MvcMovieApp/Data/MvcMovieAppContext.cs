using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovieApp.Models
{
    public class MvcMovieAppContext : DbContext
    {
        public MvcMovieAppContext (DbContextOptions<MvcMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieApp.Models.Movie> Movie { get; set; }
    }
}
