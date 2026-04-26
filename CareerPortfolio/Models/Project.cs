using System.ComponentModel.DataAnnotations;

namespace CareerPortfolio.Models
{
    public class Project
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string .Empty;
        [Required]
        public string Status { get; set; } = string.Empty;
        [Required]
        public string TechStack { get; set; } = string.Empty;
        public string? GitHubUrl { get; set; }
        public string? LiveDemoUrl { get; set; }
    }
}
