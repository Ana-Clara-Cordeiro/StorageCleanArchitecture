using AutoMapper;
using Storage.Application.DTOs.Request;
using Storage.Application.DTOs.Response;
using Storage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Application.Automapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<VoluntarioModel, VoluntarioResponseDto>();
            CreateMap<CadastrarVoluntarioRequestDto, VoluntarioModel>();
            CreateMap<AtualizarVoluntarioRequestDto, VoluntarioModel>();
        }
    }
}
