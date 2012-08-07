using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public String Genre { get; set; }
        public Decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
    }
}
