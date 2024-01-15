using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
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
    public class ProjectsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProjectVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<ProjectVm>>> GetNew([FromQuery] GetProjectByParamQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        [ProducesResponseType(typeof(AddProjectCommand), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<AddProjectCommand>> CreateProject([FromBody] AddProjectCommand command)
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
