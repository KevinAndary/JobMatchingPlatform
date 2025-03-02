using System.ComponentModel.DataAnnotations;

namespace JobMatchingAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public required string Name { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string PasswordHash { get; set; }

        [Required]
        public required string Role { get; set; } // "JobSeeker" or "Employer"
    }
}
