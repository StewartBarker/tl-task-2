using Data;
using Data.Models;
using Data.Models.KeyStagePerformance;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Pages.Project;

namespace MyWebApp.Pages.Project
{
    public class Index : PageModel
    {
        private readonly IProjects _projectRepository;

        public Index(IProjects projectRepository)
        {
            _projectRepository = projectRepository;
        }
        
        public string OutgoingAccademyUrn { get; set; }
        public string OutgoingAccademyName { get; set; }
        public string Urn { get; set; }
        public bool HasKeyStage2PerformanceInformation { get; set; }
        public bool HasKeyStage4PerformanceInformation { get; set; }
        public bool HasKeyStage5PerformanceInformation { get; set; }
        public ProjectStatuses TransferDatesStatus { get; set; }
        public ProjectStatuses BenefitsAndOtherFactorsStatus { get; set; }
        public ProjectStatuses RationaleStatus { get; set; }
        public ProjectStatuses AcademyAndTrustInformationStatus { get; set; }

        public ProjectStatuses FeatureTransferStatus { get; set; }

        public void OnGet()
        {
            var result = _projectRepository.GetByUrn(Urn).Result;

            if (result.IsValid)
            {
                OutgoingAccademyUrn = result?.Result?.OutgoingAcademyUrn;
                OutgoingAccademyName = result?.Result?.OutgoingAcademyName;
            }

        }
    }
  
        

    
}


