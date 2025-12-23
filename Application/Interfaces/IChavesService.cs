using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Domain.Entities;
using Storage.Application.DTOs.Response;
using Storage.Application.DTOs.Request;

namespace Storage.Application.Services.Interfaces
{
    public interface IChavesService
    {
        Task<List<ChavesResponseDto>> ObterTodos();

        Task<ChavesResponseDto> ObterPorId(long id);

        Task<ChavesResponseDto> Cadastrar(CadastrarChavesRequestDto request);

        Task<ChavesResponseDto> Atualizar(long id, AtualizarChavesResquestDto request);

        Task Deletar(long id);
    }
}
