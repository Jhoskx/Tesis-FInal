using System.Runtime.Intrinsics.X86;

namespace Tesis_DDD.Application.Models.ViewModels
{
    public class EstimationVm
    {
        public string NameProject { get; set; }
        public int Days { get; set; }
        public int EstimateInHours { get; set; }
        public int TotalUseCases { get; set; }
        public int TotalResources { get; set; }
    }
}
