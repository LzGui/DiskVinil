using DiskVinil.Entities;
using DiskVinil.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DiskVinil.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscoController : ControllerBase
    {
        private readonly ILogger<DiscoController> _logger;
        private readonly IDiscoService _disco;

        public DiscoController(ILogger<DiscoController> logger, IDiscoService disco)
        {
            _logger = logger;
            _disco = disco;
        }

        [HttpGet]
        public IActionResult TodosDiscos()
        {
            return Ok(_disco.RetornarListaDisco());
        }

        [HttpGet("{id}")]

        public IActionResult disco(int id)
        {
            return Ok(_disco.RetornarDiscoPorId(id));
        }

        [HttpPost]
        public IActionResult discoAdd([FromBody] Disco novoDisco)
        {
            return Ok(_disco.AdicionarDisco(novoDisco));
        }

        [HttpPut]
        public IActionResult discoUpdate([FromBody] Disco novoDisco)
        {
            return Ok(_disco.AtualizarDisco(novoDisco));
        }

        [HttpDelete ("{id}")]
        public IActionResult discoDelete(int id)
        {
            return Ok(_disco.DeletarDisco(id));
        }
    }
}
