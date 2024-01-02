using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class resourceList:MasterEntity
    {
        public int Screen1Id { get; set; }
        public string  Nombre { get; set; }
        public virtual Project Screen1 { get; set; }
    }
}
