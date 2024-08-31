using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.UseCase.Commands
{
    public class AddUseCaseCommandHandler : IRequestHandler<AddUseCaseCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddUseCaseCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(AddUseCaseCommand request, CancellationToken cancellationToken)
        {
            IEnumerable<useCase> lis = Enumerable.Empty<useCase>();
            foreach (var item in lis)
            {
                lis = lis.Append(new useCase
                 (
                    item.Name,
                    item.ProjectId,
                    item.Time,
                    item.Description
                    )
                    ).ToList();
            }
            await _unitOfWork.Repository<useCase>().AddRangeAsync(lis.ToArray());
            return true;

        }
    }
}
