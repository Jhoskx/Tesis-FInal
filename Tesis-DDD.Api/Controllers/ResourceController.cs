using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tesis_DDD.Application.Features.Resources.Commands.AddResource;
using Tesis_DDD.Application.Features.Resources.Queries.GetResource;
using Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1;
using Tesis_DDD.Application.Features.Screen1s.Queries.Get;
using Tesis_DDD.Application.Models.ViewModels;

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

        [HttpGet]
        [ProducesResponseType(typeof(List<ResourceVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<ResourceVm>>> GetResource([FromQuery] GetResourceByParamQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        [ProducesResponseType(typeof(AddResourceCommand), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<AddProjectCommand>> CreateProject([FromBody] AddResourceCommand command)
          => Ok(await _mediator.Send(command));
    }
}
