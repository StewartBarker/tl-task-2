using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages.Projects.Rationale
{
    public class Index : PageModel
    {
        public string OutgoingAcademyUrn { get; set; }
        public string Urn { get; set; }
        public void OnGet(string urn)
        {
            Urn = urn;
        }
    }
}