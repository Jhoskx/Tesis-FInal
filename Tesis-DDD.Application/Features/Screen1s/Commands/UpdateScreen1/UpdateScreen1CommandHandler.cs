using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.UpdateScreen1
{
     public class UpdateScreen1CommandHandler/*:IRequestHandler<UpdateScreen1Command,string>*/
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateScreen1CommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //public Task<string> Handle(UpdateScreen1Command request, CancellationToken cancellationToken)
        //{
            
        //}
    }
}
