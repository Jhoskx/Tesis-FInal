using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Estimations
{
    public  class GetEstimationsQueryHandler:IRequestHandler<GetEstimationsQuery, EstimationVm>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetEstimationsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<EstimationVm> Handle(GetEstimationsQuery request, CancellationToken cancellationToken)
        {
            //    var UseProject = await _unitOfWork.Repository<useCase>().GetAsync(x=>x.ProjectId.Equals(request.ProjectId),
            //include: q => q.Include(x => x));


            var UseProject = await _unitOfWork.Repository<useCase>()
                .GetWithIncludeAsync(
                x=>x.ProjectId.Equals(request.ProjectId),
                q=>q.Include(x=>x.Complexity)
                );
            var ComplexityValues = UseProject.Select(x => x.Complexity?.Value).ToList();

            var ResultEffort = ComplexityValues.Sum(x => x * 3);

            var Resource = await _unitOfWork.Repository<Resource>().GetAsync(x=> x.Project .Equals(request.ProjectId));

            var ResultTime= Resource.Sum(x => x.AvailableHoursPerWeek );

            return new EstimationVm
            {

            };
        }
    }
}
