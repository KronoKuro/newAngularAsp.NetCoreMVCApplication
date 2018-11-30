using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieReviewSpa.Model
{
    public class Movie
    {
        public string Id { get; set; }

        [Required]
        [StringLength(300)]
        public string MovieName { get; set; }
        [Required]
        [StringLength(300)]
        public string DirectorName { get; set; }
        [Required]
        [StringLength(10)]
        public string ReleaseYear { get; set; }
        public virtual ICollection<MovieReview> Reviews { get; set; }
    }
}
