using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using MediatR.Pipeline;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.Areas.Queries.GetAreas;

public class GetAreasQueryHandler:IRequestHandler<GetAreasQuery,IReadOnlyList<MasterVm>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAreasQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<MasterVm>> Handle(GetAreasQuery request, CancellationToken cancellationToken)
    {
        var area = await _unitOfWork.Repository<Area>().GetAllAsync();

        return _mapper.Map<IReadOnlyList<MasterVm>>(area);
    }
}
