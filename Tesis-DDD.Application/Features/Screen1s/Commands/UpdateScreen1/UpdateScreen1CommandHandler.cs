using Api_DDD.Domain;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Exceptions;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.UpdateScreen1
{
     public class UpdateScreen1CommandHandler:IRequestHandler<UpdateScreen1Command,string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateScreen1CommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(UpdateScreen1Command request, CancellationToken cancellationToken)
        {
            var scren = await _unitOfWork.Repository<Screen1>().GetFirstOrDefaultAsync(x=>x.NameProject == request.NameProject);
            if (scren == null)
                throw new NotFoundException($"No Project Found With The Name: {request.NameProject}");

            scren.NameProject = request.NameProject;
            scren.FinalUser = request.FinalUser;
            scren.DevelopmentMethodology = request.DevelopmentMethodology;
            scren.ResponsiblePosition = request.ResponsiblePosition;
            scren.DevelopmentType = request.DevelopmentType;
            scren.DevelopmentArea = request.DevelopmentArea;
            await _unitOfWork.Complete();

            return scren.NameProject;
        }
    }
}
