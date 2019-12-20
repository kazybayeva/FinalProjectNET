using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Madina.Models.Movies;
using Madina.Models.Users;

namespace Madina.Models.Posts
{
    public class Post
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }


        [Display(Name = "Subtitle")]
        public string Subtitle { get; set; }

        [Display(Name = "Content")]
        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string Content { get; set; }

        [Display(Name = "Likes")]
        public int Likes { get; set; }

        [Display(Name = "Movie")]
        public Movie Movie { get; set; }

        [Display(Name = "Author")]
        public User Author { get; set; }

    }
}
