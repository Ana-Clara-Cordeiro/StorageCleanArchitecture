using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Domain.Entities;
using Storage.Application.DTOs.Response;

namespace Storage.Application.Services.Interfaces
{
    public interface IChavesService
    {
        Task<List<ChavesResponseDto>> ObterTodos();
    }
}
