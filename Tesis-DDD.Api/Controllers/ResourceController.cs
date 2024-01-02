using Microsoft.AspNetCore.Mvc;

namespace Tesis_DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#if !DEBUG
[Authorize]
#endif
    public class ResourceController : ControllerBase
    {

    }
}
