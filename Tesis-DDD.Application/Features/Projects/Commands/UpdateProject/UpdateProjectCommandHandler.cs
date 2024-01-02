using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Exceptions;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.UpdateScreen1
{
     public class UpdateProjectCommandHandler:IRequestHandler<UpdateProjectCommand,string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProjectCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _unitOfWork.Repository<Project>().GetFirstOrDefaultAsync(x=>x.Name == request.Name);
            if (project == null)
                throw new NotFoundException($"No Project Found With The Name: {request.Name}");


            project.Name =request.Name;
            project.Area = request.Area;
            project.MethodologyId = request.MethodologyId;
            project.ResponsiblePosition =request.ResponsiblePosition;
            project.DevelopmentType = request.DevelopmentType;
            project.TestingHours = request.TestingHours;
            project.DeploymentTime = request.DeploymentTime;
            project.StartDate = request.StartDate;


            await _unitOfWork.Complete();

            return project.Name;
        }
    }
}
