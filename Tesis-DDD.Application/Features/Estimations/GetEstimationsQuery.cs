using MediatR;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Estimations
{
    public class GetEstimationsQuery:IRequest<EstimationVm>
    {
        public int ProjectId { get; set; }
    }
}
