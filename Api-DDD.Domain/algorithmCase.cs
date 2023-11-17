using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class algorithmCase:MasterEntity
    {
        public int proyectid { get; set; }
        public virtual Screen1 Screen1 { get; set; }
    }
}
