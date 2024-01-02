using MediatR;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.UpdateScreen1
{
    public class UpdateProjectCommand:IRequest<string>
    {

        public string Name { get; set; }
        public string Area { get; set; }
        public string MethodologyId { get; set; }
        public string ResponsiblePosition { get; set; }
        public string DevelopmentType { get; set; }
        public int TestingHours { get; set; }
        public int DeploymentTime { get; set; }
        public DateTime StartDate { get; set; }
    }
}
