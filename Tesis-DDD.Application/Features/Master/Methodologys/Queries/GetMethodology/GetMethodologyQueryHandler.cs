using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.Methodologys.Queries.GetMethodology;

public class GetMethodologyQueryHandler : IRequestHandler<GetMethodologyQuery,IReadOnlyList<MasterVm>>
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetMethodologyQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<MasterVm>> Handle(GetMethodologyQuery request, CancellationToken cancellationToken)
    {
        var developmentType = await _unitOfWork.Repository<Methodology>().GetAllAsync();

        return _mapper.Map<IReadOnlyList<MasterVm>>(developmentType);
    }
}
