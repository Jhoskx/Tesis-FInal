using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class useCase : Entity
    {
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        //public int Time { get; set; }



        public useCase(string name, int projectId)
        {
            Name = name;
            ProjectId = projectId;
            //Time = time;
        }
    }
}
