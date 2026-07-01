using Microsoft.AspNetCore.Mvc;

namespace CustomerReceiverAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventReceiverController : ControllerBase
    {
        public IActionResult Receive([FromBody] object data)
        {
           Console.WriteLine(data.ToString());
            return Ok();
        }
    }
}
