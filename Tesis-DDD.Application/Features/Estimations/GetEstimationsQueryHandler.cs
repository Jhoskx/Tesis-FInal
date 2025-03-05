using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Estimations
{
    public  class GetEstimationsQueryHandler:IRequestHandler<GetEstimationsQuery, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetEstimationsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string> Handle(GetEstimationsQuery request, CancellationToken cancellationToken)
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

            var Resource = await _unitOfWork.Repository<Resource>().GetAsync(x=> x.ProjectId.Equals(request.ProjectId));

            var ResultTime= Resource.Sum(x => x.AvailableHoursPerWeek );
            decimal total = (decimal)ResultEffort / ResultTime;


            var result = $"¡Tenemos una estimación para tu proyecto!\n\n Según nuestros cálculos, tu proyecto tomará aproximadamente {total} días en completarse.\n\n " +
                $"Recuerda que esta estimación puede variar según el desarrollo y los ajustes que se realicen en el camino.\n\n " +
                $"Si tienes dudas o necesitas más detalles, puedes solicitar una estimación con un experto para una evaluación más detallada.";





            return result;
        }
    }
}
