using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using 

namespace Tesis_DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [ProducesResponseType(typeof(codeerr),(int)HttpStatusCode.BadRequest)]
    [Authorize]
    public class Screen1Controllers:ControllerBase
    {
    }
}
