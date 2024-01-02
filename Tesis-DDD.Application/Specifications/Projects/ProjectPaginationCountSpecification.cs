using Api_DDD.Domain;

namespace Tesis_DDD.Application.Specifications.Projects
{
    public class ProjectPaginationCountSpecification : Specification<Project>
    {
        public ProjectPaginationCountSpecification(ProjectPaginationParams @params) : base
            (
            p=>(!@params.ProjectId.HasValue || p.Id ==@params.ProjectId)
            )

            {
            //AddInclude(t => t.Methodology);
        }
    }
}
