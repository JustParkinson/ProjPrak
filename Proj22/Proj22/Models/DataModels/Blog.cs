using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proj22.Models.DataModels
{
    public class Blog
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        IList<Post> Posts { get; set; }
    }
}
