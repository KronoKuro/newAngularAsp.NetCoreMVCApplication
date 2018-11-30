using MovieReviewSpa.Data.Concrete;
using MovieReviewSpa.Data.Contracts;
using MovieReviewSpa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieReviewSpa.Data
{
    public class MovieReviewUow : IDisposable
    {
        private MovieReviewDbContext dbContext;
        private MovieRepository movieRepository;
        private MovieReviewsRepository reviewRepository;
        
        public MovieReviewUow()
        {
            //CreateDbContext();
            
        }

        public MovieRepository  Movies
        {
            get
            {
                if (movieRepository == null)
                    movieRepository = new MovieRepository(dbContext);
                return movieRepository;
            }
        }

        public MovieReviewsRepository MovieReviews
        {
            get
            {
                if (reviewRepository == null)
                    reviewRepository = new MovieReviewsRepository(dbContext);
                return reviewRepository;
            }
        }


      

        /*protected void CreateDbContext()
       {

          // DbContext = db;
       }

      private IRepository<T> GetStandartRepo<T>() where T : class
       {
           return RepositoryProvider.GetRepositoryForEntityType<T>();
       }

       private T GetRepo<T>() where T :class
       {
           return RepositoryProvider.GetRepository<T>();
       }*/

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(dbContext != null)
                {
                    dbContext.Dispose();
                }
            }
        }



    }
}
