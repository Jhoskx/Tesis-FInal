using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.Methodologys.Queries.GetMethodology;

public  class GetMethodologyQuery : IRequest<IReadOnlyList<MasterVm>>
{
}
