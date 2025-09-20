using Microsoft.AspNetCore.Mvc;

namespace CitiesManager.Web.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomControllerBase:ControllerBase
    {
    }
}