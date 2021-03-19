using Microsoft.EntityFrameworkCore;
using SStTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SStTest.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
           : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
