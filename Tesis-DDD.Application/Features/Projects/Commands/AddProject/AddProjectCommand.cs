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
        public int TestingHours { get; set; }
        public int DeploymentTime { get; set; }
        public DateTime StartDate { get; set; }
    }
}
