﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Movie> Movies { get; set; }

        private Genre()
        { }

        public Genre(string name)
        {
            Name = name;
            Movies = new List<Movie>();
        }
    }
}
