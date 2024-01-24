using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.UseCase.Queries
{
    public class UseCaseByParamQuery: IRequest<IReadOnlyList<UseCaseVm>>
    {
        public int? ProjectId { get; set; }
    }
}
