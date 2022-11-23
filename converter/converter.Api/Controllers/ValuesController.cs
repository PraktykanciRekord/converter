using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using converter.Core;

namespace converter.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class converter : ControllerBase
    {
        Converter? _converter = new Converter();

        [HttpGet]
        public string[] Get(string from, string to, string val)
        {
            return _converter.Convert(from, to, double.Parse(val));
        }
    }

}
