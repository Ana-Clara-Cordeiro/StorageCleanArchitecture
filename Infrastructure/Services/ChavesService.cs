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
using Storage.Application.DTOs.Request;
using Storage.Domain.Entities;

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

        public async Task<ChavesResponseDto> ObterPorId(long id)
        {
            var chaves = await _repository.ObterPorId(id);

            if(chaves == null)
            {
                return null;
            }

            return _mapper.Map<ChavesResponseDto>(chaves);
        }

        public async Task<ChavesResponseDto> Cadastrar(CadastrarChavesRequestDto request)
        {
            var chaves = _mapper.Map<ChavesModel>(request);
            var result = await _repository.Cadastrar(chaves);
            return _mapper.Map<ChavesResponseDto>(result);
        }

        public async Task<ChavesResponseDto> Atualizar(long id, AtualizarChavesResquestDto request)
        {
            var chaves = await _repository.ObterPorId(id);
            if(chaves == null)
            {
                throw new Exception("Chave não encontrada");
            }

            var chavesDb = _mapper.Map<ChavesModel>(request);
            chavesDb.Id = id;

            var result = await _repository.Atualizar(chavesDb);
            return _mapper.Map<ChavesResponseDto>(result);
        }

    }
}
