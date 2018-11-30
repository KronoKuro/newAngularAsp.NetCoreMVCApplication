using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieReviewSpa.Data;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private MovieReviewDbContext _dbContext;

        public HomeController(MovieReviewDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var movie = _dbContext.Movies.ToList();
            return View(movie);
        }
    }
}