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
            if (!_dbContext.Roles.Any())
            {
                _dbContext.Roles.AddRange(
                    new Role
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "User",
                    }
                );
                _dbContext.Roles.AddRange(
                    new Role
                    {
                        Id = "b44c9bd1-ad78-447a-b498-97cd2e86e7e3",
                        Name = "Admin",
                    }
                );
            }
            _dbContext.SaveChanges();
            if (!_dbContext.Users.Any())
            {
                var user = _dbContext.Roles.FirstOrDefault(u => u.Name == "User");
                var admin = _dbContext.Roles.FirstOrDefault(a => a.Name == "Admin");
                _dbContext.Users.AddRange(
                    new User
                    {
                        Id = Guid.NewGuid().ToString(),
                        Login = "User",
                        Password = "7Rbtv04wQNxgyhu4OpD7MQ==",
                        RoleId = string.IsNullOrEmpty(user.Id) ? null : user.Id
                    }
                );
                _dbContext.Users.AddRange(
                    new User
                    {
                        Id = Guid.NewGuid().ToString(),
                        Login = "Admin",
                        Password = "o6dRJbVxag8bW3NhXG5K7g==",
                        RoleId = string.IsNullOrEmpty(admin.Id) ? null : admin.Id
                    }
                );
                if (!_dbContext.Movies.Any())
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
            _dbContext.SaveChanges();
        }
    }
}
