using Api_DDD.Domain;

namespace Tesis_DDD.Application.Models.ViewModels
{
    public class ResourceVm
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int ProjectId { get; set; }
        public int? ExperienceId { get; set; }
    }
}
