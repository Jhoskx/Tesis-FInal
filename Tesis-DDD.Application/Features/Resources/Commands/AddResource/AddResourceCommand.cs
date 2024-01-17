using Api_DDD.Domain;
using MediatR;

namespace Tesis_DDD.Application.Features.Resources.Commands.AddResource
{
    public class AddResourceCommand : IRequest<int> 
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int ProjectId { get; set; }
        public int? ExperienceId { get; set; }
    }
}
