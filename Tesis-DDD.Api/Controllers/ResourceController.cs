using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tesis_DDD.Application.Features.Resources.Commands.AddResource;
using Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1;

namespace Tesis_DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#if !DEBUG
[Authorize]
#endif
    public class ResourceController : ControllerBase
    {
        private readonly IMediator _mediator;
         
        public ResourceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(AddResourceCommand), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<AddProjectCommand>> CreateProject([FromBody] AddResourceCommand command)
          => Ok(await _mediator.Send(command));
    }
}
