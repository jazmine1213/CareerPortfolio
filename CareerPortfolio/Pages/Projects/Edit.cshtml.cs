using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CareerPortfolio.Data;
using CareerPortfolio.Models;

namespace CareerPortfolio.Pages.Projects
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Project Project { get; set; } = new(); //holds the form data

        public async Task<IActionResult> OnGetAsync(int id) //loads the existing project
        {
            var project =  await _context.Projects.FindAsync(id);

            if (project == null)
            {
                return RedirectToPage("/Projects");
            }

            Project = project;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync() // saves the updated project
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Project).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("/Projects");
        }
    }
}
