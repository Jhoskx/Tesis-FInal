using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Features.Screen1s.Queries.Get;
using Tesis_DDD.Application.Models.ViewModels;
using Tesis_DDD.Application.Specifications.Projects;

namespace Tesis_DDD.Application.Features.Projects.Queries.Get
{
    public class GetProjectByParamQueryHandler : IRequestHandler<GetProjectByParamQuery,IReadOnlyList<ProjectVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProjectByParamQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<ProjectVm>> Handle(GetProjectByParamQuery request, CancellationToken cancellationToken)
        {
            var spec = new ProjectSpecification(request);
            var project = await _unitOfWork.Repository<Project>().GetAllWithSpec(spec);

            return _mapper.Map<IReadOnlyList<ProjectVm>>(project);
        }
    }
}

