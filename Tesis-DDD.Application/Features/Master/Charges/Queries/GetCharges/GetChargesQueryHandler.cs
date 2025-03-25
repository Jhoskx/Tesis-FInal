using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.Charges.Queries.GetCharges;

public class GetChargesQueryHandler:IRequestHandler<GetChargesQuery,IReadOnlyList<MasterVm>> 
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetChargesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<MasterVm>> Handle(GetChargesQuery request, CancellationToken cancellationToken)
    {
        var charge = await _unitOfWork.Repository<Charge>().GetAllAsync();

        return _mapper.Map<IReadOnlyList<MasterVm>>(charge);
    }
}
