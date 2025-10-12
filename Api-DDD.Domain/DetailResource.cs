using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class DetailResource : Entity
    {
        public int ResourceListId { get; set; }
        public virtual ResourceList ResourceList { get; set; }
        public string EstimatedTimePerTask { get; set; }
        public string ExpectedImpact { get; set; }
        public string AbilityToEstimateEffort { get; set; }
    }
}
