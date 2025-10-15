using Storage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Domain.Interfaces.Repositories
{
    public interface IVoluntarioRepository
    {
        Task<List<VoluntarioModel>> ObterTodos();
        Task<VoluntarioModel?> ObterPorId(string id);
        Task<VoluntarioModel> Cadastrar(VoluntarioModel voluntario);
        Task<VoluntarioModel> Atualizar(VoluntarioModel voluntario);
        Task<bool> Deletar(string id);
    }
}
