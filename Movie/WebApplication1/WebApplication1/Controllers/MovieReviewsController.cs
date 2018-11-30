using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieReviewSpa.Data.Contracts;
using MovieReviewSpa.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class MovieReviewsController : Controller
    {

        private readonly IRepository<MovieReview> movieReviewsRepository;

        public MovieReviewsController(IRepository<MovieReview> repositoryMovieReviews)
        {
            movieReviewsRepository = repositoryMovieReviews;
        }

        [HttpGet]
        public IEnumerable<MovieReview> Get()
        {
            return movieReviewsRepository.GetAll().OrderBy(m => m.MovieId);
        }

        [HttpGet("{id}")]
        public MovieReview GetByReviewId(string id)
        {
            var reviewsMovie = movieReviewsRepository.GetAll()
                .FirstOrDefault(m => m.Id == id);
            if (reviewsMovie != null)
                return reviewsMovie;

            throw new Exception(new HttpResponseMessage(HttpStatusCode.NotFound).ToString());
        }

        [HttpPut]
        public HttpResponseMessage Put([FromBody]MovieReview review)
        {
            movieReviewsRepository.Update(review);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        [HttpPost("{id}")]
        public int Post([FromBody]MovieReview review)
        {
            review.MovieId = Guid.NewGuid().ToString();
            movieReviewsRepository.Add(review);

            return Response.StatusCode = (int)HttpStatusCode.Created;
        }

        [HttpDelete("{id}")]
        public HttpResponseMessage Delete(string id)
        {
            movieReviewsRepository.Delete(id);

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}