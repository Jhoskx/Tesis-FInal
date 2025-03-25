using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.DevelopmentTypes.Queries.GetDevelopmentTypes;

public class GetDevelopmentTypesQuery:IRequest<IReadOnlyList<MasterVm>>
{
}
