using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class Project : MasterEntity
    {
        public string Name { get; set; }
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
        public int MethodologyId { get; set; }
        public virtual Methodology Methodology { get; set; }
        public int ChargeId { get; set; }
        public virtual Charge Charge { get; set; }
        public int DevelopmentTypeId { get; set; }
        public virtual DevelopmentType DevelopmentType { get; set; }
        public int TypeEstimationId { get; set; }
        public virtual TypeEstimation TypeEstimation { get; set; }
        public string? Email { get; set; }

        public Project(string name, int areaId, int methodologyId, int chargeId, int developmentTypeId, int typeEstimationId, string? email)
        {
            Name = name;
            AreaId = areaId;
            MethodologyId = methodologyId;
            ChargeId = chargeId;
            DevelopmentTypeId = developmentTypeId;
            TypeEstimationId = typeEstimationId;
            Email = email;
        }

        public Project(){ }
    }
}
