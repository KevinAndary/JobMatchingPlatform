using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMatchingAPI.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        public required string Description { get; set; }

        [Required]
        public required string Company { get; set; }

        [Required]
        public required string Location { get; set; }

        [Required]
        public required string SkillsRequired { get; set; }

        [ForeignKey("Employer")]
        public int EmployerId { get; set; }
        public required User Employer { get; set; }
    }
}
