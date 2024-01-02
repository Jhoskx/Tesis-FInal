
using Api_DDD.Domain;
using AutoMapper.Execution;
using MediatR;
using Microsoft.Extensions.Logging;
using Tesis_DDD.Application.Contracts.Persistence;



namespace Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1
{
    public class AddProjectCommandHandler : IRequestHandler<AddProjectCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddProjectCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(AddProjectCommand request, CancellationToken cancellationToken)
        {

            var project = new Project(
               request.Name,
               request.Area,
               request.MethodologyId,
               request.ResponsiblePosition,
               request.DevelopmentType,
               request.TestingHours,
               request.DeploymentTime,
               request.StartDate
                );
            await _unitOfWork.Repository<Project>().AddAsync(project);
            return project.Id;
        }
    }
}
