using System.ComponentModel.DataAnnotations;

namespace BuildsByBrickwell.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
    }
}
