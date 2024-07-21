using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Exceptions;

namespace Tesis_DDD.Application.Features.Projects.Commands.UpdateDescription
{
     public class UpdateDescriptionCommandHandler:IRequestHandler<UpdateDescriptionCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateDescriptionCommandHandler(IUnitOfWork unitOfWork)
        {   
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(UpdateDescriptionCommand request, CancellationToken cancellationToken)
        {
            var project = await _unitOfWork.Repository<Project>().GetFirstOrDefaultAsync(x=>x.Id == request.Id);
            if (project == null)
                throw new NotFoundException($"No Project Found With The Name: {request.Id}");

            project.Description =request.Description;

            await _unitOfWork.Complete();

            return project.Id;
        }
    }
}
