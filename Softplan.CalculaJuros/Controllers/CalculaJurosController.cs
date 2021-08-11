using Microsoft.AspNetCore.Mvc;
using Softplan.CalculaJuros.Model;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Softplan.CalculaJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private const string URL = "https://localhost:5002/api/TaxaJuros/";
        static HttpClient client = new HttpClient();
        JurosModel valorJuros = new JurosModel();

        [HttpGet]
        public async Task<ActionResult> GetAsync(double valorinicial, int meses)
        {
            HttpResponseMessage response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                valorJuros.ValorJuros = double.Parse(result, new CultureInfo("en-US"));
            }

            var jurosComposto = new JurosCompostoModel(valorinicial, valorJuros.ValorJuros, meses);
            return Ok(jurosComposto);
        }
    }
}
