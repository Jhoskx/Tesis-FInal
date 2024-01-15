using Api_DDD.Domain;
using Tesis_DDD.Application.Features.Screen1s.Queries.Get;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Specifications.Projects
{
    public class ProjectSpecification : Specification<Project>
    {
        public ProjectSpecification(GetProjectByParamQuery @params) : base
        ( 
        p=>
        (!@params.Id.HasValue || p.Id==@params.Id )
        )
        {
            AddInclude(fd => fd.Methodology);
        }
    }
}
