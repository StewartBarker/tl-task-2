using Data.Models;
using Data.Models.KeyStagePerformance;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Pages.Project;

namespace MyWebApp.Pages.Project
{
    public class Index : PageModel
    {
        public string OutgoingAccademyUrn { get; set; }
        public string OutgoingAccademyName { get; set; }
        public ProjectStatuses FeatureTransferStatus { get; set; }

        public void OnGet()
        {
            
        }
    }
  
        

    
}


