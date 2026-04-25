using CareerPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace CareerPortfolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ExperienceEntry> ExperienceEntries { get; set; }
    }
}
