using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class Resource:MasterEntity
    {
        public string Name {get; set;}
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public int? ExperienceId { get; set; }

        public Resource(string name,string description, int projectId, int? experienceId)
        {
            Name = name;
            ProjectId = projectId;
            ExperienceId = experienceId;
            Description = description;
        }
    }
}
