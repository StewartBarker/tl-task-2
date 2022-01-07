using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages.Projects.TransferDates

{
    public class Index : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Urn { get; set; }

        public string FirstDiscussedDate { get; set; }

        public string HasFirstDiscussedDate { get; set; }

        public bool ReturnToPreview { get; set; }

        public string HtbDate { get; set; }

        public string HasHtbDate { get; set; }

        public string TargetDate { get; set; }

        public string HasTargetDate { get; set; }
        public void OnGet()
        {

        }
    }
}