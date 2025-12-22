using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Domain.Entities;

namespace Storage.Domain.Interfaces.Repositories
{
    public interface IChavesRepository
    {
        Task<List<ChavesModel>> ObterTodos();

        Task<ChavesModel?> ObterPorId(long id);

        Task<ChavesModel> Cadastrar(ChavesModel chaves);

        Task<ChavesModel> Atualizar(ChavesModel chaves);
    }
}
