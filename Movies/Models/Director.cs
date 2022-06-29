using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public List<Movie> Movies { get; set; }

        private Director()
        { }

        public Director(string firstName, string lastName, DateTime birthDate, DateTime? deathDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            DeathDate = deathDate;

            Movies = new List<Movie>();
        }
    }
}
