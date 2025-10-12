using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Exceptions;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.UpdateScreen1
{
     public class UpdateDescriptionCommandHandler:IRequestHandler<UpdateDescription,string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateDescriptionCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(UpdateDescription request, CancellationToken cancellationToken)
        {
            var project = await _unitOfWork.Repository<Project>().GetFirstOrDefaultAsync(x=>x.Name == request.Name);
            if (project == null)
                throw new NotFoundException($"No Project Found With The Name: {request.Name}");


            project.Name =request.Name;
            project.AreaId = request.AreaId;
            project.MethodologyId = request.MethodologyId;
            project.ChargeId =request.ChargeId;
            project.DevelopmentTypeId = request.DevelopmentTypeId;
  


            await _unitOfWork.Complete();

            return project.Name;
        }
    }
}
