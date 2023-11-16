using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class ResultAlgorith:MasterEntity
    {
        public int idEstimate { get; set; }
        public virtual estimationAlgorithm EstimationAlgorithm { get; set; }
    }
}
