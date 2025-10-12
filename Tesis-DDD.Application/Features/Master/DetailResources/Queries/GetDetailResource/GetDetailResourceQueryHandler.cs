using System.Diagnostics;
using Api_DDD.Domain;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Features.Master.DetailResources.Queries.GetDetailResource
{
    public class GetDetailResourceQueryHandler : IRequestHandler<GetDetailResourceQuery,IReadOnlyList<DetailResourceVm>>
    {
      private readonly IUnitOfWork _unitOfWork;
      private readonly IMapper _mapper;

        public GetDetailResourceQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<DetailResourceVm>> Handle(GetDetailResourceQuery request, CancellationToken cancellationToken)
        {
            var data =  _unitOfWork.Repository<DetailResource>().GetQuery().Include(x => x.ResourceList).ToList();

            

            return _mapper.Map<IReadOnlyList<DetailResourceVm>>(data);
            
        }
    }
}

