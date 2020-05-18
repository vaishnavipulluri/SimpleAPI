using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            var value = _configuration["sarathsecret"];
            return "Value for Secret [sarathsecret] is : " + value;
        }
    }
}