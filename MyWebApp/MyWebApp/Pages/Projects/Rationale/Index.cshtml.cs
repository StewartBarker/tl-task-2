using Data.Mock;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages.Projects.Rationale
{
    public class Index : PageModel
    {
        public string Urn { get; set; }
        public void OnGet()
        {

        }
    }
}