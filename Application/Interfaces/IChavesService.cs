using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Application.DTOs.Response;

namespace Storage.Application.Interfaces
{
    internal interface IChavesService
    {
        Task<List<ChavesResponseDto>> ObterTodos();
    }
}
