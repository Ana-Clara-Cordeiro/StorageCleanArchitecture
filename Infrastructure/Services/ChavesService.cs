using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Storage.Domain.Interfaces.Repositories;
using Storage.Infrastructure.Context;
using Storage.Application.DTOs.Response;
using Storage.Application.Services.Interfaces;

namespace Storage.Application.Services
{
    public class ChavesService : IChavesService
    {

        private readonly AppDbContext _context;
        private readonly IChavesRepository _repository;
        private readonly IMapper _mapper;

        public ChavesService(AppDbContext context,
                                 IMapper mapper,
                                 IChavesRepository repository)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        public async Task<List<ChavesResponseDto>> ObterTodos()
        {
            var chaves = await _repository.ObterTodos();
            return _mapper.Map<List<ChavesResponseDto>>(chaves);
        }

    }
}
