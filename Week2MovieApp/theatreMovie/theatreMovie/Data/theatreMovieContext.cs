using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using theatreMovie.Models;

namespace theatreMovie.Models
{
    public class theatreMovieContext : DbContext
    {
        public theatreMovieContext (DbContextOptions<theatreMovieContext> options)
            : base(options)
        {
        }

        public DbSet<theatreMovie.Models.Movie> Movie { get; set; }

        public DbSet<theatreMovie.Models.Catagory> Catagory { get; set; }
    }
}
