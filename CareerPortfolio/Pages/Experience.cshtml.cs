using CareerPortfolio.Data;
using CareerPortfolio.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CareerPortfolio.Pages
{
    public class ExperienceModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ExperienceModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ExperienceEntry> ExperienceEntries { get; set; } = new();

        public async Task OnGetAsync()
        {
            ExperienceEntries = await _context.ExperienceEntries
                .OrderBy(e => e.DisplayOrder)
                .ToListAsync();
        }
    }
}