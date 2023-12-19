
using Api_DDD.Domain;
using MediatR;
using Microsoft.Extensions.Logging;
using Tesis_DDD.Application.Contracts.Persistence;



namespace Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1
{
    public class AddScreen1CommandHandler : IRequestHandler<AddScreen1Command, string> { 
        private readonly IUnitOfWork _unitOfWork;

        public AddScreen1CommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<string> Handle(AddScreen1Command request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
