using Api_DDD.Domain;
using MediatR;

namespace Tesis_DDD.Application.Features.UseCase.Commands
{
    public class AddUseCaseCommand:IRequest<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int ProjectId { get; set; }
        public int time { get; set; }
    }
}
