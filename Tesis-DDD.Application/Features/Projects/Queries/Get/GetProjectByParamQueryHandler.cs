using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Features.Screen1s.Queries.Get;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Projects.Queries.Get
{
    public class GetProjectByParamQueryHandler : IRequestHandler<GetProjectByParamQuery, PaginationVm<ProjectVm>>
    {
        private readonly IUnitOfWork _unitOfWork;



        public Task<PaginationVm<ProjectVm>> Handle(GetProjectByParamQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
