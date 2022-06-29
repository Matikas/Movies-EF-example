using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class MoviesService
    {
        private readonly DbRepository _repository;

        public MoviesService()
        {
            _repository = new DbRepository();
        }

        public void CreateDirector(string firstName, string lastName, DateTime birthDate, DateTime? deathDate = null)
        {
            var director = new Director(firstName, lastName, birthDate, deathDate);

            _repository.AddDirector(director);
            _repository.SaveChanges();
        }

        public IEnumerable<Director> GetAllDirectors()
        {
            return _repository.GetAllDirectorsOrdered();
        }

        public Director GetDirectorById(int id)
        {
            return _repository.GetDirectorById(id);
        }

        public void AssignGenreToMovie(int movieId, string genre)
        {
            var movie = _repository.GetMovie(movieId);

            if (movie.Genres.Any(g => g.Name.Equals(genre, StringComparison.InvariantCultureIgnoreCase)))
            {
                return;
            }

            var genreFromDb = _repository.GetGenre(genre);

            movie.Genres.Add(genreFromDb ?? new Genre(genre));

            _repository.UpdateMovie(movie);
            _repository.SaveChanges();
        }
    }
}
