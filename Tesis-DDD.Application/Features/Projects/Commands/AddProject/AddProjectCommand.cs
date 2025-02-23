using MediatR;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1
{
    public class AddProjectCommand :  IRequest<int>
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public int MethodologyId { get; set; }
        public string ResponsiblePosition { get; set; }
        public string DevelopmentType { get; set; }
        public int TypeEstimationId { get; set; }
        public string Email { get; set; }

    }
}
