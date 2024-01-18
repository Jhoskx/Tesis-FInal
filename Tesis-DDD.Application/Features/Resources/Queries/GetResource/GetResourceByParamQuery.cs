using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Resources.Queries.GetResource
{
    public class GetResourceByParamQuery:IRequest<IReadOnlyList<ResourceVm>>
    {
        public int? ProjectId { get; set; }
    }
}
