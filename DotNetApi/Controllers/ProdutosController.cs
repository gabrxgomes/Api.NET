using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //jamais se esqueça de usar o import do mvc

namespace DotNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        // GET: api/produtos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "Produto1", "Produto2" });
        }

        // GET: api/produtos/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Produto {id}");
        }

        // POST: api/produtos
        [HttpPost]
        public IActionResult Post([FromBody] string produto)
        {
            // Adicione lógica para salvar o produto
            return CreatedAtAction(nameof(Get), new { id = 1 }, produto);
        }
    }
}