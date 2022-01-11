using Data.Mock;
using Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages.Projects.TransferDates

{
    public class Index : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Urn { get; set; }

        public string FirstDiscussedDate { get; set; }

        public bool? HasFirstDiscussedDate { get; set; }

        public bool ReturnToPreview { get; set; }

        public string HtbDate { get; set; }

        public bool? HasHtbDate { get; set; }

        public string TargetDate { get; set; }

        public bool? HasTargetDate { get; set; }
        
        public void OnGet()
        {
            var projectRepository = new MockProjectRepository();
            var project = projectRepository.GetByUrn(Urn);

            FirstDiscussedDate = DateHelpers.ConvertDateToGovukDate(project.Result.Result.Dates?.FirstDiscussed);
            HasFirstDiscussedDate = project.Result.Result.Dates?.HasFirstDiscussedDate;

            HtbDate = DateHelpers.ConvertDateToGovukDate(project.Result.Result.Dates?.Htb);
            HasHtbDate = project.Result.Result.Dates?.HasHtbDate;

            TargetDate = DateHelpers.ConvertDateToGovukDate(project.Result.Result.Dates?.Target);
            HasTargetDate = project.Result.Result.Dates?.HasTargetDate;

        }
    }
}