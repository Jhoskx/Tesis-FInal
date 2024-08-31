using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Models.Request;

namespace Tesis_DDD.Application.Features.Resources.Commands.AddResource
{
    public class AddResourceCommand : IRequest<bool> 
    {
        public List<ResourceRequest> ResourceRequests { get; set; }
    }
}
