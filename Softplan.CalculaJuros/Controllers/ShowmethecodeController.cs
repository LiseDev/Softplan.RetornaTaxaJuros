using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Softplan.CalculaJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowmethecodeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("https://github.com/LiseDev/calculajuros");
        }

    }
}
