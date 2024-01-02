
using Api_DDD.Domain;
using AutoMapper.Execution;
using MediatR;
using Microsoft.Extensions.Logging;
using Tesis_DDD.Application.Contracts.Persistence;



namespace Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1
{
    public class AddProjectCommandHandler : IRequestHandler<AddScreen1Command, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddProjectCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(AddScreen1Command request, CancellationToken cancellationToken)
        {

            var screen = new Project(
               
                );
            await _unitOfWork.Repository<Project>().AddAsync((Project)screen);
            return screen.Id;
        }
    }
}
