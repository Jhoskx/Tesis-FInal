using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tesis_DDD.Application.Features.Master.Areas.Queries.GetAreas;
using Tesis_DDD.Application.Features.Master.Charges.Queries.GetCharges;
using Tesis_DDD.Application.Features.Master.DetailResources.Queries.GetDetailResource;
using Tesis_DDD.Application.Features.Master.DevelopmentTypes.Queries.GetDevelopmentTypes;
using Tesis_DDD.Application.Features.Master.Listresource;
using Tesis_DDD.Application.Features.Master.Methodologys.Queries.GetMethodology;
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


        [HttpGet("Areas")]
        [ProducesResponseType(typeof(List<MasterVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<MasterVm>>> GetAreas()
        {
            return Ok(await _mediator.Send(new GetAreasQuery()));
        }

        [HttpGet("DevelopmentMethodology")]
        [ProducesResponseType(typeof(List<MasterVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<MasterVm>>> GetDevelopmentMethodology()
        {
            return Ok(await _mediator.Send(new GetMethodologyQuery()));
        }

        [HttpGet("PositionResponsible")]
        [ProducesResponseType(typeof(List<MasterVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<MasterVm>>> GetPositionResponsible()
        {
            return Ok(await _mediator.Send(new GetChargesQuery()));
        }

        [HttpGet("DevelopmentType")]
        [ProducesResponseType(typeof(List<MasterVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<MasterVm>>> GetDevelopmentType()
        {
            return Ok(await _mediator.Send(new GetDevelopmentTypesQuery()));
        }

        [HttpGet("ListResource")]
        [ProducesResponseType(typeof(List<MasterVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<MasterVm>>> GetListResource()
        {
            return Ok(await _mediator.Send(new ListresourceQuery()));
        }


        [HttpGet("DetailResource")]
        [ProducesResponseType(typeof(List<MasterVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<MasterVm>>> GetDetailResource()
        {
            return Ok(await _mediator.Send(new GetDetailResourceQuery()));
        }


    }
}
