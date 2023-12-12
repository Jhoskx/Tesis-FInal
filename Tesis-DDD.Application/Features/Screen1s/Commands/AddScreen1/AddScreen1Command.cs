using MediatR;

namespace Tesis_DDD.Application.Features.Screen1.Commands.AddScreen1
{
    public class AddScreen1Command:  IRequest<string>
    {
        public string NameProject { get; set; }
        public string FinalUser { get; set; }
        public string DevelopmentMethodology { get; set; }
        public string ResponsiblePosition { get; set; }
        public string DevelopmentType { get; set; }
    }
}
