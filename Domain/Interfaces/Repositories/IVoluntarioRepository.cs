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

        /*Task<VoluntarioModel> AdicionarAsync(VoluntarioModel voluntario);
        Task<VoluntarioModel> AtualizarAsync(VoluntarioModel voluntario);
        Task<bool> DeletarAsync(int id);*/
    }
}
