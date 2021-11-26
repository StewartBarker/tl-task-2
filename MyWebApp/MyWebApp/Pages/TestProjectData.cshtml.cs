using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class TestProjectData : PageModel
    {
        private readonly IProjects _projectsRepository;
        public string AcademyName { get; set; }
        
        [BindProperty]
        public List<string> ProjectUrns { get; set; }

        public TestProjectData(IProjects projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }
        
        public async Task<IActionResult> OnGet()
        {
            var projects = await _projectsRepository.GetProjects();
            if (!projects.IsValid)
            {
                return new RedirectToPageResult("Shared/_ErrorPage", projects.Error.ErrorMessage); //, projects.Error.ErrorMessage);
            }

            var projectResult = projects.Result;
            
            ProjectUrns = new List<string>();
            foreach (var project in projectResult)
            {
                ProjectUrns.Add(project.Urn);
            }
            //_logger.LogInformation("Home page loaded");

            return Page();
        }
    }
}