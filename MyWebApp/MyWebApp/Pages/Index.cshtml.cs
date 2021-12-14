using System.Collections.Generic;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class Index : PageModel
    {
        private readonly IProjects _projectRepository;

        public Index(IProjects projectRepository)
        {
            _projectRepository = projectRepository;
        }
        
        public List<ProjectSearchResult> Projects;
        public int Page { get; set; }
        public void OnGet()
        {
            Projects = _projectRepository.GetProjects().Result.Result;
        }
    }
}