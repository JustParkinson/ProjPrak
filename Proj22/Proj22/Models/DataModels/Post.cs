using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj22.Models.DataModels
{
    public class Post
    {

        [Key]
        public int Id { get; set; }
        public Blog Blog { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public string Text { get; set; }
        DateTime CreationDate { get; set; }
    }
}
