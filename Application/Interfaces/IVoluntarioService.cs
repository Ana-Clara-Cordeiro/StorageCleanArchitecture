using Storage.Application.DTOs.Response;
using Storage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Storage.Application.Services.Interfaces
{
    public interface IVoluntarioService
    {
        Task<List<VoluntarioResponseDto>> ObterTodos();
        Task<VoluntarioResponseDto> ObterPorId(string id);
    }
}
