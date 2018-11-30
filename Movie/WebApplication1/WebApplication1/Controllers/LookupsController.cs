using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieReviewSpa.Data.Contracts;
using MovieReviewSpa.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class LookupsController : Controller
    {
        private readonly IRepository<Movie> repositoryMovie;
        private readonly IRepository<MovieReview> repositoryMovieReview;

        public LookupsController(IRepository<Movie> movieRepository, IRepository<MovieReview> movieReviewRepository)
        {
            repositoryMovie = movieRepository;
            repositoryMovieReview = movieReviewRepository;
        }
        
        [HttpGet("movies")]
        public IEnumerable<Movie> GetMovie()
        {
            return repositoryMovie.GetAll().OrderBy(m => m.Id);
        }

        [HttpGet("GetByReviewId")]
        public MovieReview GetByReviewId(string id)
        {
            return repositoryMovieReview.GetById(id);
        }


    }
}