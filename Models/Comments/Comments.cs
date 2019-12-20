using Madina.Models.Posts;
using Madina.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Comments
{
    public class Comments
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Content")]
        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string Content { get; set; }

        [Display(Name = "Post")]
        public Post Post { get; set; }

        [Display(Name = "Author")]
        public User Author { get; set; }

    }
}
