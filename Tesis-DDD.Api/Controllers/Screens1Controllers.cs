using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using Tesis_DDD.Application.Features.Screen1s.Commands.AddScreen1;

namespace Tesis_DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
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


        //[HttpGet]
        //[ProducesResponseType(typeof(List<TaskVm>), (int)HttpStatusCode.OK)]
        //public async Task<ActionResult<List<TaskVm>>> GetTask([FromQuery] GetTaskByParamQuery query)
        //{
        //    return Ok(await _mediator.Send(query));
        //}


        [HttpPost]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> CreateScreen1([FromBody] AddScreen1Command create)
           => (await _mediator.Send(create));
    }
}
