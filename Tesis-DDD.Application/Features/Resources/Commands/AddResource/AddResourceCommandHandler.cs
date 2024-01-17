using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;

namespace Tesis_DDD.Application.Features.Resources.Commands.AddResource
{
    public class AddResourceCommandHandler : IRequestHandler<AddResourceCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddResourceCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(AddResourceCommand request, CancellationToken cancellationToken)
        {
            var resource = new Resource
                (
                request.Name,
                request.Description,
                request.ProjectId,
                request.ExperienceId
                );
            await _unitOfWork.Repository<Resource>().AddAsync (resource);
            return resource.Id;
        }
    }
}
