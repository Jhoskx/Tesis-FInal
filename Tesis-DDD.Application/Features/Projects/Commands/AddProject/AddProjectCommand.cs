using MediatR;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1
{
    public class AddProjectCommand :  IRequest<int>
    {
        public string Name { get; set; }
        public int AreaId { get; set; }
        public int MethodologyId { get; set; }
        public int ChargeId { get; set; }
        public int DevelopmentTypeId { get; set; }
        public int TypeEstimationId { get; set; }
        public string? Email { get; set; }

    }
}
