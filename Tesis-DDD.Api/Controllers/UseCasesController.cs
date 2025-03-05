using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tesis_DDD.Application.Features.UseCases.Commands;
using Tesis_DDD.Application.Features.UseCases.Queries;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseCasesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UseCasesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ResourceVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<ResourceVm>>> GetResource([FromQuery] UseCaseByParamQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        [ProducesResponseType(typeof(AddUseCaseCommand), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<AddUseCaseCommand>> CreateProject([FromBody] AddUseCaseCommand command)
      =>    Ok(await _mediator.Send(command));

    }
}
