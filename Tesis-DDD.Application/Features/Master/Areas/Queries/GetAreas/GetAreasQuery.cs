using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.Areas.Queries.GetAreas;

 public class GetAreasQuery : IRequest<IReadOnlyList<MasterVm>>
{
}
