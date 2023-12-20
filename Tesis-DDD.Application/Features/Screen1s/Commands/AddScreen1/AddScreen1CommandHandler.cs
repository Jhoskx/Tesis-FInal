
using Api_DDD.Domain;
using AutoMapper.Execution;
using MediatR;
using Microsoft.Extensions.Logging;
using Tesis_DDD.Application.Contracts.Persistence;



namespace Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1
{
    public class AddScreen1CommandHandler : IRequestHandler<AddScreen1Command, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddScreen1CommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(AddScreen1Command request, CancellationToken cancellationToken)
        {

            var screen = new Screen1(
                request.NameProject,
                request.FinalUser,
                request.DevelopmentMethodology,
                request.ResponsiblePosition,
                request.DevelopmentType,
                request.DevelopmentArea
                );
            await _unitOfWork.Repository<Screen1>().AddAsync(screen);
            return screen.Id;
        }
    }
}
