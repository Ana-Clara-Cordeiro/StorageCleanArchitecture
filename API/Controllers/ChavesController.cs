using Microsoft.AspNetCore.Mvc;
using Storage.Application.Services.Interfaces;
using Storage.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

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

    }
}
