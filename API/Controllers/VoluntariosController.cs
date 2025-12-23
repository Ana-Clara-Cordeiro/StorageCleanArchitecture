using Microsoft.AspNetCore.Mvc;
using Storage.Application.DTOs.Request;
using Storage.Application.Services.Interfaces;
using Storage.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("voluntarios")]
    public class VoluntariosController : ControllerBase
    {
        private readonly IVoluntarioService service;

        public VoluntariosController(IVoluntarioService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult> ObterTodos()
        {
            return Ok(await this.service.ObterTodos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterPorId([FromRoute] string id)
        {
            return Ok(await this.service.ObterPorId(id));
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar([FromBody] CadastrarVoluntarioRequestDto request)
        {
            return Ok(await this.service.Cadastrar(request));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Atualizar([FromRoute] string id, [FromBody] AtualizarVoluntarioRequestDto request)
        {
            return Ok(await this.service.Atualizar(id, request));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Deletar([FromRoute] string id)
        {
            return Ok(await this.service.Deletar(id));
        }
    }
}
