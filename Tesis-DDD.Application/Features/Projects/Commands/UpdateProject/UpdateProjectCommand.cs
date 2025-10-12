using MediatR;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.UpdateScreen1
{
    public class UpdateDescription:IRequest<string>
    {

        public string Name { get; set; }
        public int AreaId { get; set; }
        public int MethodologyId { get; set; }
        public int ChargeId { get; set; }
        public int DevelopmentTypeId { get; set; }
        public int TestingHours { get; set; }
        public int DeploymentTime { get; set; }
        public DateTime StartDate { get; set; }
    }
}
