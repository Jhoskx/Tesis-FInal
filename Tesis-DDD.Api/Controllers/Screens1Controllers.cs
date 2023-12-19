using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1;

namespace Tesis_DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#if !DEBUG
[Authorize]
#endif
    public class Screens1Controllers : ControllerBase
    {
        private readonly IMediator _mediator;

        public Screens1Controllers(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(AddScreen1Command), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<AddScreen1Command>> CreateScreen1([FromBody] AddScreen1Command command)
          =>Ok(await _mediator.Send(command));
    }
}
