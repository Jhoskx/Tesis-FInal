using Api_DDD.Domain;
using Tesis_DDD.Application.Features.UseCase.Queries;

namespace Tesis_DDD.Application.Specifications.UseCase
{
    public class UseCaseSpesification:Specification<useCase>
    {
        public UseCaseSpesification(UseCaseByParamQuery @params) : base
            (
            u=>
            (!@params.ProjectId.HasValue||u.ProjectId==@params.ProjectId)
            )
        {
            AddInclude(u => u.Project);
        }
    }
}
