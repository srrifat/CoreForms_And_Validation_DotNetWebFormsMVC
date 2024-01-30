using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CoreForms_And_Validation_DotNetWebFormsMVC.Models
{
    public class Account
    {
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string Username{ get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        public string Password{ get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email{ get; set; }
        [Url]
        public string Website{ get; set; }
    }
}
