using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Proj22.Models.DataModels
{
    public class User : IdentityUser<int>
    {   
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BrithDay { get; set; }
        
    }
}
