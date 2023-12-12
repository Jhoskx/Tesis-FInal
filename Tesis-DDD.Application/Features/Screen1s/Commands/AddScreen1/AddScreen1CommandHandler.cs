
using MediatR;
using Microsoft.Extensions.Logging;
using Tesis_DDD.Application.Contracts.Persistence;


namespace Tesis_DDD.Application.Features.Screen1.Commands.AddScreen1
{
    public class AddScreen1CommandHandler: IRequestHandler<AddScreen1Command,string>
    {
        private readonly ILogger<AddScreen1CommandHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AddScreen1CommandHandler(ILogger<AddScreen1CommandHandler> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task<string>Handle(AddScreen1Command request , CancellationToken cancellationToken)
        {
            var screen1 = new Screen1();


        }
    }
}
