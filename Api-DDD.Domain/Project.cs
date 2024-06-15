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
        public int TypeEstimationId { get; set; }
        public virtual TypeEstimation TypeEstimation { get; set; }

        public Project(string name, string area, int methodologyId, string responsiblePosition, string developmentType, int typeEstimationId)
        {
            Name = name;
            Area = area;
            MethodologyId = methodologyId;
            ResponsiblePosition = responsiblePosition;
            DevelopmentType = developmentType;
            TypeEstimationId = typeEstimationId;
        }

        public Project(){ }
    }
}
