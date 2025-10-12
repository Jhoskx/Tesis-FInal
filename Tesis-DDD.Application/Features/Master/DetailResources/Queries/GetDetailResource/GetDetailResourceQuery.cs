using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.DetailResources.Queries.GetDetailResource
{
    public class GetDetailResourceQuery : IRequest<IReadOnlyList<DetailResourceVm>>
    {
    }
}
