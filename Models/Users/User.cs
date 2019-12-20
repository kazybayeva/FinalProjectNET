using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Madina.Models.ProfilesInfo;

namespace Madina.Models.Users
{
    public class User
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Name { get; set; }

        [Display(Name = "Username")]
        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Password { get; set; }

        [Display(Name = "Email")]
        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Email { get; set; }


        [Display(Name = "Phone")]
        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Phone { get; set; }


        [Display(Name = "ProfileInfo")]
        public ProfileInfo ProfileInfo { get; set; }
    }
}
