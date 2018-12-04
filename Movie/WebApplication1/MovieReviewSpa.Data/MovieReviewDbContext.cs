using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieReviewSpa.Model;

namespace MovieReviewSpa.Data
{
    public class MovieReviewDbContext : IdentityDbContext
    {

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieReview> MovieReviews { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        

        public MovieReviewDbContext(DbContextOptions<MovieReviewDbContext> options):base(options)
        {

        }
    }
}
