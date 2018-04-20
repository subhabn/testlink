using System.ComponentModel.DataAnnotations;

namespace BL.Link.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}