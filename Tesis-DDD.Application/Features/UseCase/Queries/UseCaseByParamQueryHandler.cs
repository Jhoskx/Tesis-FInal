using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;
using Tesis_DDD.Application.Specifications.UseCase;

namespace Tesis_DDD.Application.Features.UseCase.Queries
{
    public class UseCaseByParamQueryHandler : IRequestHandler<UseCaseByParamQuery, IReadOnlyList<UseCaseVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UseCaseByParamQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
                }

        public async Task<IReadOnlyList<UseCaseVm>> Handle(UseCaseByParamQuery request, CancellationToken cancellationToken)
        {
            var spec = new UseCaseSpesification(request);
            var usecase = await _unitOfWork.Repository<useCase>().GetAllWithSpec(spec);

            return _mapper.Map<IReadOnlyList<UseCaseVm>>(usecase);
        }
    }
}
