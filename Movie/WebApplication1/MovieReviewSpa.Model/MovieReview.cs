using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieReviewSpa.Model
{
    public class MovieReview
    {
        public string Id { get; set; }

        [Required]
        [StringLength(300)]
        public string ReviewName { get; set; }
        [Required]
        [StringLength(500)]
        public string ReviewComments { get; set; }
        [Required]
        public int ReviewerRating { get; set; }
        public string MovieId { get; set; }
    }
}
