using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Domain.Entities;
using Storage.Domain.Interfaces.Repositories;
using Storage.Infrastructure.Context;


namespace Storage.Infrastructure.Repositories
{
    public class ChavesRepository : IChavesRepository
    {
        private readonly AppDbContext _context;

        public ChavesRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<ChavesModel>> ObterTodos()
        {
            return await _context.Chaves
                .AsNoTracking()
                .ToListAsync();

        }

        public async Task<ChavesModel?> ObterPorId(long id)
        {
            return await _context.Chaves
                .AsNoTracking()
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<ChavesModel> Cadastrar(ChavesModel chaves)
        {
            await _context.Chaves.AddAsync(chaves);
            await _context.SaveChangesAsync();
            return chaves;
        }
            

    }
}
