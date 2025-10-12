using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.Listresource
{
    public class ListresourceQuery : IRequest<IReadOnlyList<MasterVm>>
    {
    }
}
