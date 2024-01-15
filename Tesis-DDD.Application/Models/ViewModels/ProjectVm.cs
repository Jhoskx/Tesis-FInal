namespace Tesis_DDD.Application.Models.ViewModels
{
    public class ProjectVm
    {
        public int IdProject { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string MethodologyId { get; set; }
        public string ResponsiblePosition { get; set; }
        public string DevelopmentType { get; set; }
        public int TestingHours { get; set; }
        public int DeploymentTime { get; set; }
        public DateTime StartDate { get; set; }
    }
}
