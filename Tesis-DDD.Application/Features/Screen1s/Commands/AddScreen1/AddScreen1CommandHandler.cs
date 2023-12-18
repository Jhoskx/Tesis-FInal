
using Api_DDD.Domain;
using MediatR;
using Microsoft.Extensions.Logging;
using Tesis_DDD.Application.Contracts.Persistence;



namespace Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1
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
            var screen1 = new Screen1(
              request.NameProject,
              request.FinalUser,
              request.DevelopmentMethodology,
              request.ResponsiblePosition,
              request.DevelopmentType,
              request.DevelopmentArea
     
                );
            await  _unitOfWork.Repository<Screen1>().AddAsync( screen1 );
            string msg = $"se ha cregado el registro con el Id: {screen1.Id}";
            return msg ;
        }
    }
}
