using CareerPortfolio.Data;
using CareerPortfolio.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CareerPortfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Skill> Skills { get; set; } = new();

        public async Task OnGetAsync()
        {
            Skills = await _context.Skills.ToListAsync();
        }
    }
}
