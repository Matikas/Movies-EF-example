using Microsoft.EntityFrameworkCore;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class DbRepository
    {
        private readonly MoviesDbContext _dbContext;

        public DbRepository()
        {
            _dbContext = new MoviesDbContext();
        }

        public void AddDirector(Director director)
        {
            _dbContext.Directors.Add(director);
        }

        public List<Director> GetAllDirectorsOrdered(int pageNumber, int pageSize)
        {
            return _dbContext.Directors.OrderBy(d => d.BirthDate).ToList();
        }

        public Director GetDirectorById(int id)
        {
            return _dbContext.Directors.FirstOrDefault(d => d.Id == id);
        }

        public Movie GetMovie(int id)
        {
            return _dbContext.Movies.Include(m => m.Genres).FirstOrDefault(m => m.Id == id);
        }

        public Genre GetGenre(string genre)
        {
            return _dbContext.Genres.FirstOrDefault(g => g.Name.ToUpper() == genre.ToUpper());
        }

        public void UpdateMovie(Movie movie)
        {
            _dbContext.Update(movie);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
