using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExibirConta : ControllerBase
    {
        [HttpGet("ObterConta")]
        public IActionResult ObterConta()
        {
            var obj = new
            {
                Res = 1 + 1,
            };

            return Ok(obj);
        }
    }
}