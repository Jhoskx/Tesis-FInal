using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class Resource:MasterEntity
    {
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public int AvailableHoursPerWeek { get; set; }
        public virtual Project Project { get; set; }

        public Resource(string description, int projectId, int availableHoursPerWeek) 
        {
            AvailableHoursPerWeek = availableHoursPerWeek;
            ProjectId = projectId;
            Description = description;
        }

    
    }
}
