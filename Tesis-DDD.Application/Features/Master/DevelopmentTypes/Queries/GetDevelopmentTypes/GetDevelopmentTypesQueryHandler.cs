using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.DevelopmentTypes.Queries.GetDevelopmentTypes;

public class GetDevelopmentTypesQueryHandler:IRequestHandler<GetDevelopmentTypesQuery,IReadOnlyList<MasterVm>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetDevelopmentTypesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<MasterVm>> Handle(GetDevelopmentTypesQuery request, CancellationToken cancellationToken)
    {
        var developmentType = await _unitOfWork.Repository<DevelopmentType>().GetAllAsync();

        return _mapper.Map<IReadOnlyList<MasterVm>>(developmentType);
    }
}
