using Microsoft.AspNetCore.Mvc;
using Storage.Application.Services.Interfaces;
using Storage.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoluntariosController : ControllerBase
    {
        private readonly IVoluntarioService service;

        public VoluntariosController(IVoluntarioService service)
        {
            this.service = service;
        }

        [HttpGet("voluntarios")]
        public async Task<ActionResult> ObterTodos()
        {
            return Ok(await this.service.ObterTodos());
        }

        [HttpGet("voluntarios/{id}")]
        public async Task<ActionResult> ObterPorId([FromRoute] string id)
        {
            return Ok(await this.service.ObterPorId(id));
        }
    }
}
