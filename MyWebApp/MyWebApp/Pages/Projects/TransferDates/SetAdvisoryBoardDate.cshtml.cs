using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace MyWebApp.Pages.Projects.TransferDates
{
    public class SetAdvisoryBoardDateModel : PageModel
    {

        public string Urn { get; set; }
        public DateTime HtbDate { get; set; }

        public DateTime Date { get; set; }

        public string ModelValidationState { get; set; }
        public string ReturnToPreview { get; set; }
        public string OutgoingAcademyName { get; set; }

        public bool UnknownDate { get; set; }
        public void OnGet()
        {
        }
    }
}
