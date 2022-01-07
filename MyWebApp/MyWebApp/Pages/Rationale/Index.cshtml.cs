using Data.Models;
using Data.Models.KeyStagePerformance;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Pages.Rationale;

namespace MyWebApp.Pages.Rationale
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

