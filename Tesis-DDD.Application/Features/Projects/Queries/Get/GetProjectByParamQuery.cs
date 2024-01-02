﻿using MediatR;
using Tesis_DDD.Application.Models.ViewModels;
using Tesis_DDD.Application.Specifications.Projects;

namespace Tesis_DDD.Application.Features.Screen1s.Queries.Get
{
    public class GetProjectByParamQuery:ProjectPaginationParams,IRequest<PaginationVm<ProjectVm>>
    {
    }
}
