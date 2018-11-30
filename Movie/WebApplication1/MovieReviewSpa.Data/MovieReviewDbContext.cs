using System;
using Microsoft.EntityFrameworkCore;
using MovieReviewSpa.Model;

namespace MovieReviewSpa.Data
{
    public class MovieReviewDbContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieReview> MovieReviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        

        public MovieReviewDbContext(DbContextOptions<MovieReviewDbContext> options):base(options)
        {

        }
    }
}
