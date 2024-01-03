using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Features.Screen1s.Queries.Get;
using Tesis_DDD.Application.Helpers;
using Tesis_DDD.Application.Models.ViewModels;
using Tesis_DDD.Application.Specifications.Projects;

namespace Tesis_DDD.Application.Features.Projects.Queries.Get
{
    public class GetProjectByParamQueryHandler : IRequestHandler<GetProjectByParamQuery, PaginationVm<ProjectVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationHelper _paginationHelper;
        private readonly IMapper _mapper;

        public GetProjectByParamQueryHandler(IUnitOfWork unitOfWork, PaginationHelper paginationHelper, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _paginationHelper = paginationHelper;
            _mapper = mapper;
        }

        public async Task<PaginationVm<ProjectVm>> Handle(GetProjectByParamQuery request, CancellationToken cancellationToken)
        {
            var  spec= new ProjectPaginationSpecification(request);
            var project = await _unitOfWork.Repository<Project>().GetAllWithSpec(spec);

            if (project == null)
                return new PaginationVm<ProjectVm>();
            var counspect =new ProjectPaginationCountSpecification(request);
            var total = await _unitOfWork.Repository<Project>().CountAsync(counspect);
            return _paginationHelper.Paginate<Project, ProjectVm>(project, total, request.PageSize, request.PageIndex);
            




        }
    }
}
