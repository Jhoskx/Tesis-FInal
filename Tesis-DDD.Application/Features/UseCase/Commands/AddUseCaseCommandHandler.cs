using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;

namespace Tesis_DDD.Application.Features.UseCase.Commands
{
    public class AddUseCaseCommandHandler : IRequestHandler<AddUseCaseCommand, int>
    {
        private readonly IUnitOfWork _UnitOfWork;

        public AddUseCaseCommandHandler(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task<int> Handle(AddUseCaseCommand request, CancellationToken cancellationToken)
        {

            var use = new useCase
           (
                request.Name,
                request.ProjectId,
                request.time,
                request.Description
           );
            await _UnitOfWork.Repository<useCase>().AddAsync(use);

            return use.Id;
            
        }
    }
}
