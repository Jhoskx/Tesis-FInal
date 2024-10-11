using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class useCase : Entity
    {   
            public string Name { get; set; }
            public int Transactions { get; set; }
            public string ProjectId { get; set; }
            public virtual Project Project { get; set; }
            public int ComplexityId { get; set; }
            public virtual ComplexityLevel Complexity { get; set; }
        
        public useCase()
        {

        }

        public useCase(string name, string projectId,int complexityId)
        {
            Name = name;
            ProjectId = projectId;
            ComplexityId = complexityId;
        }

        public enum ComplexityLevel
        {
            Simple,
            Average,
            Complex
        }
    }
}
