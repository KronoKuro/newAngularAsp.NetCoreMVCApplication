using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieReviewSpa.Data;
using MovieReviewSpa.Data.Contracts;
using MovieReviewSpa.Model;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/movies")]
    public class MovieController : Controller
    {
        IRepository<Movie> movieRepository;


        public MovieController(IRepository<Movie> repositoryMovie)
        {
            movieRepository = repositoryMovie;
        }

        [HttpGet]
        public IQueryable Get()
        {
            var model = movieRepository.GetAll()
                .OrderByDescending(s => s.Reviews.Count())
                .Select(m => new MovieReviewsModel
                {
                    Id = m.Id,
                    MovieName = m.MovieName,
                    DirectorName = m.DirectorName,
                    ReleaseYear = m.ReleaseYear,
                    NoOfReviews = m.Reviews.Count()
                });
            return model;

        }

        [HttpGet("{id}")]
        public Movie GetId(string id)
        {
            var movie = movieRepository.GetById(id);
                if(movie != null)
                return movie;

            throw new Exception(new HttpResponseMessage(HttpStatusCode.NotFound).ToString());
        }


        [HttpPut]
        public HttpResponseMessage Put([FromBody]Movie movie)
        {
            movieRepository.Update(movie);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        [Authorize]
        [HttpPost]
        public int Post([FromBody]Movie movie)
        {
            movieRepository.Add(movie);
            return Response.StatusCode = (int)HttpStatusCode.Created;
        }

        [HttpDelete("{id}")]
        public HttpResponseMessage Delete(string id)
        {
            movieRepository.Delete(id);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}