using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1;
using Tesis_DDD.Application.Features.Screen1s.Commands.UpdateScreen1;
using Tesis_DDD.Application.Features.Screen1s.Queries.Get;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#if !DEBUG
[Authorize]
#endif
    public class ProjectsControllers : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectsControllers(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [ProducesResponseType(typeof(PaginationVm<ProjectVm>), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<PaginationVm<ProjectVm>>> GetQuotation([FromQuery] GetProjectByParamQuery query)
          => Ok(await _mediator.Send(query));

        [HttpPost]
        [ProducesResponseType(typeof(AddProjectCommand), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<AddProjectCommand>> CreateScreen1([FromBody] AddProjectCommand command)
          =>Ok(await _mediator.Send(command));


        [HttpPut("{nameproject}")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> UpdateScreen([FromBody] UpdateProjectCommand command, string nameProject)
        {
            command.Name = nameProject;
            return Ok(await _mediator.Send(nameProject));
        }
    }
}
