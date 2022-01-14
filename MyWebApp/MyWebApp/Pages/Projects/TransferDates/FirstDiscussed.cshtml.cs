using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Data.Mock;

namespace MyWebApp.Pages.Projects.TransferDates
{
    public class FirstDiscussedModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string Urn { get; set; }
        public DateTime FirstDiscussed { get; set; }

        public string Date { get; set; }

        public string ModelValidationState { get; set; }
        public string ReturnToPreview { get; set; }
        public string OutgoingAcademyName { get; set; }

        public bool UnknownDate { get; set; }

        public void OnGet()
        {
            var projectRepository = new MockProjectRepository();
            var project = projectRepository.GetByUrn(Urn);
            FirstDiscussed = DateTime.Parse(project.Result.Result.Dates.FirstDiscussed);
        }
    }
}
