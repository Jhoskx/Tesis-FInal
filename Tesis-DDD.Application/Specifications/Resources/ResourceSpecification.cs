using Api_DDD.Domain;
using Tesis_DDD.Application.Features.Resources.Queries.GetResource;

namespace Tesis_DDD.Application.Specifications.Resources
{
    public class ResourceSpecification : Specification<Resource>
    {
        public ResourceSpecification(GetResourceByParamQuery @params) :base
            (
            r=>
            (!@params.ProjectId.HasValue||r.ProjectId==@params.ProjectId)
            )
        {
            AddInclude(fd => fd.Experience);
        }
    }
}
