using Microsoft.EntityFrameworkCore;
using MovieReviewSpa.Data.Contracts;
using MovieReviewSpa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieReviewSpa.Data.Concrete
{
    public class MovieReviewsRepository : IRepository<MovieReview>
    {
        private MovieReviewDbContext dbCotnext;


        public MovieReviewsRepository(MovieReviewDbContext _dbContext)
        {
            this.dbCotnext = _dbContext;
        }

        public void Add(MovieReview entity)
        {
            if (entity != null)
            {
                dbCotnext.MovieReviews.Add(entity);
                Save();
            }
        }

        public void Delete(MovieReview entity)
        {
            MovieReview movie = dbCotnext.MovieReviews.Find(entity);
            if (movie != null)
                dbCotnext.MovieReviews.Remove(entity);
                Save();
        }

        public void Delete(string id)
        {
            if (id != null || id != "")
            {
                var movie = dbCotnext.MovieReviews.FirstOrDefault(x => x.Id == id);
                Delete(movie);
            }
        }

        public IQueryable<MovieReview> GetAll()
        {
            return dbCotnext.MovieReviews;
        }

        public MovieReview GetById(string id)
        {
            if (id != null)
                return dbCotnext.MovieReviews.FirstOrDefault(x => x.Id == id);
            
            return null;
        }

        public void Update(MovieReview entity)
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