using CareerPortfolio.Data;
using CareerPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace CareerPortfolio.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                new Project
                {
                    Title = "Career Portfolio Website",
                    Description = "A personal portfolio website built with ASP.NET Core Razor Pages to showcase my experience, skills, and development growth.",
                    Status = "In Progress",
                    TechStack = "C#, ASP.NET Core, Razor Pages, HTML, CSS, Bootstrap"
                },
                new Project
                {
                    Title = "Job Application Tracker",
                    Description = "A full-stack application for tracking job applications, interview stages, follow-ups, notes, and outcomes.",
                    Status = "Planned",
                    TechStack = "C#, ASP.NET Core, SQL Server, React"
                },
                new Project
                {
                    Title = "Audit History Tracker",
                    Description = "A project inspired by real-world work involving change tracking, with a focus on capturing and displaying record updates clearly.",
                    Status = "Planned",
                    TechStack = "C#, ASP.NET Core, SQL Server, JSON"
                }
                );
                //return; // DB already seeded
            }

            if (!context.Skills.Any())
            {
                context.Skills.AddRange(
                new Skill { Name = "C#", Category = "Language" },
                new Skill { Name = ".NET", Category = "Framework" },
                new Skill { Name = "ASP.NET Core", Category = "Framework" },
                new Skill { Name = "Razor Pages", Category = "Framework" },
                new Skill { Name = "SQL Server", Category = "Database" },
                new Skill { Name = "JavaScript", Category = "Language" },
                new Skill { Name = "HTML", Category = "Frontend" },
                new Skill { Name = "CSS", Category = "Frontend" },
                new Skill { Name = "Git", Category = "Tools" },
                new Skill { Name = "Azure DevOps", Category = "Tools" }
                );
            }

            if (!context.ExperienceEntries.Any())
            {
                context.ExperienceEntries.AddRange(
                    new ExperienceEntry
                    {
                        JobTitle = "Business Application Developer",
                        Company = "Blue Cross Blue Shield of Michigan",
                        DateRange = "Apr 2022 – Jun 2025",
                        Description = "Developed and maintained internal applications supporting healthcare operations. Troubleshot production issues by analyzing logs, stack traces, and SQL queries. Worked with C#, ASP.NET, and SQL Server to build and enhance application features.",
                        DisplayOrder = 1
                    },
                    new ExperienceEntry
                    {
                        JobTitle = "Associate Software Developer",
                        Company = "United Wholesale Mortgage",
                        DateRange = "Apr 2021 – Apr 2022",
                        Description = "Supported development and maintenance of internal systems in a fast-paced environment. Assisted with debugging and resolving application and data-related issues. Worked with SQL queries and backend logic to support business processes.",
                        DisplayOrder = 2
                    },
                    new ExperienceEntry
                    {
                        JobTitle = "Technical Writer / Reporting Analyst / IT Support",
                        Company = "Central Transport",
                        DateRange = "Oct 2015 – Apr 2021",
                        Description = "Created documentation and reports to support business operations and decision-making. Worked with SQL to extract and analyze data. Provided technical support and troubleshooting for internal users.",
                        DisplayOrder = 3
                    }
                );
            }

            context.SaveChanges();
        }
    }
}
