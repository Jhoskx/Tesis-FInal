using Api_DDD.Domain;

namespace Tesis_DDD.Application.Specifications.Projects
{
    public class ProjectPaginationSpecification : Specification<Project>
    {

        public ProjectPaginationSpecification(ProjectPaginationParams @params) : base

            (
            p => (!@params.ProjectId.HasValue || p.Id == @params.ProjectId)
            )

        {
            AddInclude(t => t.Methodology);

            //"estabele la cantidad de paginacion"
            ApplyPaging(@params.PageSize * (@params.PageIndex - 1), @params.PageSize);
            if (!string.IsNullOrEmpty(@params.Sort))
            {
                switch (@params.Sort)
                {
                    default:
                        AddOrderBy(p => p.CreatedDate);

                        break;
                }
            }
        }


    }
}
