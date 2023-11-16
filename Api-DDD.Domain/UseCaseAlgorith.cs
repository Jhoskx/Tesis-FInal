using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class UseCaseAlgorith : MasterEntity
    {
        public int idEstimate { get; set; }
        public virtual estimationAlgorithm EstimationAlgorithm { get; set; }
    }

}

