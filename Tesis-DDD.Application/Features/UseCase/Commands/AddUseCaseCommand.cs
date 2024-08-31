using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Models.Request;

namespace Tesis_DDD.Application.Features.UseCase.Commands
{
    public class AddUseCaseCommand:IRequest<bool>
    {
        public List<UseCaseRequest> UseCaseRequests { get; set; }
        
    }
}
