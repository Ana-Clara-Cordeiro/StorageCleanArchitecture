using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Storage.Application.DTOs.Request;
using Storage.Application.DTOs.Response;
using Storage.Application.Services.Interfaces;
using Storage.Domain.Entities;
using Storage.Domain.Interfaces.Repositories;
using Storage.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Application.Services
{
    public class VoluntarioService : IVoluntarioService
    {
        private readonly AppDbContext _context;
        private readonly IVoluntarioRepository _repository;
        private readonly IMapper _mapper;
        public VoluntarioService(AppDbContext context, 
                                 IMapper mapper,
                                 IVoluntarioRepository repository)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<VoluntarioResponseDto>> ObterTodos()
        {
            var voluntarios = await _repository.ObterTodos();
            return _mapper.Map<List<VoluntarioResponseDto>>(voluntarios);
        }

        public async Task<VoluntarioResponseDto> ObterPorId(string id)
        {
            var voluntario = await _repository.ObterPorId(id);

            if (voluntario == null)
            {
                throw new Exception("Voluntário não encontrado");
            }

            return _mapper.Map<VoluntarioResponseDto>(voluntario);
        }

    }
}
