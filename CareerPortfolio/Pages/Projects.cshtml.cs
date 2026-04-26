using CareerPortfolio.Data;
using CareerPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System.Threading.Tasks;

namespace CareerPortfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ProjectsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Project> Projects { get; set; } = new();
        [BindProperty]
        public Project NewProject { get; set; } = new();

        public async Task OnGet()
        {
           Projects = await _context.Projects.ToListAsync();
        }

        public async Task<IActionResult> OnPostCreateAsync() //Razor Pages runs OnPostCreateAsync
        {
            if (!ModelState.IsValid) //Check if the form is valid
            {
                Projects = await _context.Projects.ToListAsync(); //If invalid, it reloads the project list
                return Page();//Shows the same page w/errors
            }

            _context.Projects.Add(NewProject); //If valid, it adds the new project to EF Core
            await _context.SaveChangesAsync(); // Saves the changes to SQL Server

            return RedirectToPage(); //Redirects back to the Projects page with new project object loaded
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var project = await _context.Projects.FindAsync(id); //Find the project in the database by id

            if (project == null) //If it doesn't exist, just reload the page
            {
                return RedirectToPage();
            }

            _context.Projects.Remove(project); //If it does exist, remove it
            await _context.SaveChangesAsync(); //Save the database change

            return RedirectToPage(); //Reload the Projects page
        }
    }
}
