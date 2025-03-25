using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tesis_DDD.Application.Features.Master.Areas.Queries.GetAreas;
using Tesis_DDD.Application.Features.UseCases.Queries;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MasterController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<MasterVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<MasterVm>>> GetResource( GetAreasQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
