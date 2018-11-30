using Microsoft.EntityFrameworkCore;
using MovieReviewSpa.Data.Contracts;
using MovieReviewSpa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieReviewSpa.Data.Concrete
{
    public class MovieRepository : IRepository<Movie>
    {
        private MovieReviewDbContext dbCotnext;


        public MovieRepository(MovieReviewDbContext _dbContext)
        {
            this.dbCotnext = _dbContext;
        }

        public void Add(Movie entity)
        {
            if(entity != null)
            {
                dbCotnext.Movies.Add(entity);
                Save();
            }
        }

        public void Delete(Movie entity)
        {
            Movie movie = dbCotnext.Movies.Find(entity);
            if (movie != null)
                dbCotnext.Movies.Remove(entity);
                Save();
        }

        public void Delete(string id)
        {
           if(id != null || id != "")
            {
                var movie = dbCotnext.Movies.FirstOrDefault(x => x.Id == id);
                Delete(movie);
           }
        }

        public IQueryable<Movie> GetAll()
        {
            return dbCotnext.Movies;
        }

        public Movie GetById(string id)
        {
            if (id != null)
                return dbCotnext.Movies.FirstOrDefault(x => x.Id == id);

            return null;
        }

        public void Update(Movie entity)
        {
            if (entity != null)
                dbCotnext.Entry(entity).State = EntityState.Modified;
                Save();
        }

        public void Save()
        {
            dbCotnext.SaveChanges();
        }
    }
}
