using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class useCase:MasterEntity
    {
        public int idEstimate { get; set; }
        public virtual expertEstimate ExpertEstimate { get; set; }
    }
}
