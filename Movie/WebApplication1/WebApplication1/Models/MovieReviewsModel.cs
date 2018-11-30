using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MovieReviewsModel
    {
        public string Id { get; set; }

        public string MovieName { get; set; }

        public string DirectorName { get; set; }

        public string ReleaseYear { get; set; }

        public int NoOfReviews { get; set; }
    }
}
