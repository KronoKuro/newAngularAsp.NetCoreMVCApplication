using MovieReviewSpa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieReviewSpa.Data.SimpleData
{
    public class InitialData
    {
        private MovieReviewDbContext _dbContext;

        public InitialData(MovieReviewDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedData()
        {
            if(!_dbContext.Movies.Any())
            {
                var movie = new Movie
                {
                    MovieName = "Avatar",
                    DirectorName = "James Cameron",
                    ReleaseYear = "2009"
                };

                _dbContext.Movies.Add(movie);
                var secondMovie = new Movie()
                {
                    MovieName = "Titanic",
                    DirectorName = "James Cameron",
                    ReleaseYear = "1997"
                };
                _dbContext.Add(secondMovie);

                var thirdMovie = new Movie()
                {
                    MovieName = "Die Another day",
                    DirectorName = "Lee Tamahori",
                    ReleaseYear = "2002"
                };
                _dbContext.Add(thirdMovie);
                var anothermovieWithReview = new Movie()
                {
                    MovieName = "Godzila",
                    DirectorName = "Gareth Edwards",
                    ReleaseYear = "2014",
                    Reviews = new List<MovieReview>
                    {
                        new MovieReview
                        {
                            ReviewerRating = 5,
                            ReviewComments = "Excellent",
                            ReviewName = "Rahul Sahay"
                        },
                        new MovieReview
                        {
                            ReviewerRating = 5,
                            ReviewComments = "Awesome",
                            ReviewName = "John"
                        },
                        new MovieReview
                        {
                            ReviewerRating = 5,
                            ReviewComments = "Mind Blowing",
                            ReviewName = "Black Dave"
                        }
                    }

                };
                _dbContext.Movies.Add(anothermovieWithReview);

                _dbContext.MovieReviews.AddRange(anothermovieWithReview.Reviews);
                _dbContext.SaveChanges();
            }

        }

    }
}
