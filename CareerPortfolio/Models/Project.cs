namespace CareerPortfolio.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string .Empty;
        public string Status { get; set; } = string.Empty;
        public string TechStack { get; set; } = string.Empty;
        public string? GitHubUrl { get; set; }
        public string? LiveDemoUrl { get; set; }
    }
}
