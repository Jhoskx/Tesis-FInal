using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.Listresource
{
    public class ListresourceQueryHandler : IRequestHandler<ListresourceQuery, IReadOnlyList<MasterVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ListresourceQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<MasterVm>> Handle(ListresourceQuery request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.Repository<ResourceList>().GetAllAsync();

            return _mapper.Map<IReadOnlyList<MasterVm>>(data);
        }
    }
}
