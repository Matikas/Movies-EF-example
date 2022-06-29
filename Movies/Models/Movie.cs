using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }

        public List<Genre> Genres { get; set; }
        public Director Director { get; set; }

        private Movie()
        { }

        public Movie(string name, int releaseYear)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Genres = new List<Genre>();
        }
    }
}
