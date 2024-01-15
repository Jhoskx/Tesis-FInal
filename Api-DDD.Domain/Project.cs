using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class Project : MasterEntity
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public int MethodologyId { get; set; }
        public virtual Methodology Methodology { get; set; }
        public string ResponsiblePosition { get; set; }
        public string DevelopmentType { get; set; }
        public int TestingHours { get; set; }
        public int DeploymentTime { get; set; }
        public DateTime StartDate { get; set; }

        public Project(string name, string area, int methodologyId, string responsiblePosition, string developmentType, int testingHours, int deploymentTime, DateTime startDate)
        {
            Name = name;
            Area = area;
            MethodologyId = methodologyId;
            ResponsiblePosition = responsiblePosition;
            DevelopmentType = developmentType;
            TestingHours = testingHours;
            DeploymentTime = deploymentTime;
            StartDate = startDate;
        }

        public Project(){ }
    }
}
