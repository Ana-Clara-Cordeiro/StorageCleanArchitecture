using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Domain.Entities;

namespace Storage.Domain.Interfaces.Repositories
{
    internal interface IChavesRepository
    {
        Task<List<ChavesModel>> ObterTodos();
    }
}
