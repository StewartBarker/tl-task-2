using Data.Mock;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages.Projects.Rationale
{
    public class Index : PageModel
    {
        public string OutgoingAcademyUrn { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Urn { get; set; }
        public string ProjectRationale { get; set; }
        public string TrustOrSponsorRationale { get; set; }
        public bool ReturnToPreview { get; set; }
        
        public void OnGet()
        {
            var projectRepository = new MockProjectRepository();
            var project = projectRepository.GetByUrn(Urn);
            ProjectRationale = project.Result.Result.Rationale.Project;
            TrustOrSponsorRationale = project.Result.Result.Rationale.Trust;
        }
    }
}