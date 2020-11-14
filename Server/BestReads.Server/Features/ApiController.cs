using Microsoft.AspNetCore.Mvc;

namespace BestReads.Server.Features
{
    [ApiController]
    [Route("[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
