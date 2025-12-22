using System.Net;
using Microsoft.AspNetCore.Mvc;
using Storage.Application.Services;
using Storage.Application.Services.Interfaces;
using Storage.Application.DTOs.Request;
using Storage.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChavesController : ControllerBase
    {
        private readonly IChavesService service;

        public ChavesController(IChavesService service)
        {
            this.service = service;
        }

        [HttpGet("chaves")]

        public async Task<ActionResult> obterTodos()
        {
            return Ok(await this.service.ObterTodos());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(long id)
        {
            var chave = await service.ObterPorId(id);

            if (chave == null)
                return NotFound(new { mensagem = $"Chave com registro {id} não encontrada." });

            return Ok(chave);
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar([FromBody] CadastrarChavesRequestDto request)
        {
            return Ok(await this.service.Cadastrar(request));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Atualizar([FromRoute] string id, [FromBody] AtualizarChaveRequestDto request)
        {
            return Ok(await this.service.Atualizar(id, request));
        }

    }
}
