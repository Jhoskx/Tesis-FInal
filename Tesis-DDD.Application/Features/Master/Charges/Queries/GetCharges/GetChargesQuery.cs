using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.Charges.Queries.GetCharges;

public class GetChargesQuery : IRequest<IReadOnlyList<MasterVm>>
{
}
