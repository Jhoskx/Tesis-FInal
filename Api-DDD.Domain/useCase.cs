using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class useCase : MasterEntity
    {
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public int time { get; set; }


    }
}
