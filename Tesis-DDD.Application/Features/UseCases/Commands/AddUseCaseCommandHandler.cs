using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.UseCases.Commands
{
    public class AddUseCaseCommandHandler : IRequestHandler<AddUseCaseCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddUseCaseCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(AddUseCaseCommand request, CancellationToken cancellationToken)
        {
            IEnumerable<useCase> lis = Enumerable.Empty<useCase>();
            foreach (var item in lis)
            {
                lis = lis.Append(new useCase
                 (
                    item.Name,
                    item.ProjectId,
                    item.ComplexityId

                    )
                    ).ToList();
            }
            await _unitOfWork.Repository<useCase>().AddRangeAsync(lis.ToArray());
            return request.UseCaseRequests.Select(x=>x.ProjectId).FirstOrDefault();

        }
    }
}
