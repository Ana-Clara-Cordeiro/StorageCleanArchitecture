using Microsoft.EntityFrameworkCore;
using Storage.Domain.Entities;
using Storage.Domain.Interfaces.Repositories;
using Storage.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Infrastructure.Repositories
{
    public class VoluntarioRepository : IVoluntarioRepository
    {
        private readonly AppDbContext _context;

        public VoluntarioRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<VoluntarioModel>> ObterTodos()
        {
            return await _context.Voluntarios
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<VoluntarioModel?> ObterPorId(string id)
        {
            return await _context.Voluntarios
                .AsNoTracking()
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<VoluntarioModel> Cadastrar(VoluntarioModel voluntario)
        {
            await _context.Voluntarios.AddAsync(voluntario);
            await _context.SaveChangesAsync();
            return voluntario;
        }

        public async Task<VoluntarioModel> Atualizar(VoluntarioModel voluntario)
        {
            _context.Voluntarios.Update(voluntario);
            await _context.SaveChangesAsync();
            return voluntario;
        }

        public async Task<bool> Deletar(string id)
        {
            var voluntario = await _context.Voluntarios.FindAsync(id);
            if (voluntario == null)
                return false;

            _context.Voluntarios.Remove(voluntario);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
