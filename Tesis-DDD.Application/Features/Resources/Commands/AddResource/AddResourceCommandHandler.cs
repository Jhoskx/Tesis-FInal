using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.Request;

namespace Tesis_DDD.Application.Features.Resources.Commands.AddResource
{
    public class AddResourceCommandHandler : IRequestHandler<AddResourceCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddResourceCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(AddResourceCommand request, CancellationToken cancellationToken)
        {
            IEnumerable<Resource> list = Enumerable.Empty<Resource>();

            foreach (var item in request.ResourceRequests)
            {
                list = list.Append(new Resource
                (

                       item.Description,
                       item.ProjectId,
                       item.HoursPerWeek
                )
                    ).ToList();
            }
            
            await _unitOfWork.Repository<Resource>().AddRangeAsync(list.ToArray());

             var x = request.ResourceRequests.Select(x=>x.ProjectId).FirstOrDefault();
            return x;
            ;
        }
    }
}
