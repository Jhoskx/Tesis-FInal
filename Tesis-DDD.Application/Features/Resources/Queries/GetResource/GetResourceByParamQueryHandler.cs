using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;
using Tesis_DDD.Application.Specifications.Resources;

namespace Tesis_DDD.Application.Features.Resources.Queries.GetResource
{
    public class GetResourceByParamQueryHandler :IRequestHandler<GetResourceByParamQuery,IReadOnlyList<ResourceVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetResourceByParamQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<ResourceVm>> Handle(GetResourceByParamQuery request, CancellationToken cancellationToken)
        {
            var spec = new ResourceSpecification(request);
            var resource = await _unitOfWork.Repository<Resource>().GetAllWithSpec(spec);

            return _mapper.Map<IReadOnlyList<ResourceVm>>(resource);  
        }
    }
}
