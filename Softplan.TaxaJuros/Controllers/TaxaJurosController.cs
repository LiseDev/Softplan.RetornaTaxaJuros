using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Softplan.TaxaJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        // GET: api/<TaxaJurosController>
        [HttpGet]
        public decimal Get()
        {
            return 0.01m;
        }

       
    }
}
