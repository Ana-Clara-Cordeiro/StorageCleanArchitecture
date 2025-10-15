using FluentValidation;
using Storage.Application.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Application.DTOs.Validation
{
    public class AtualizarVoluntarioValidationDto : AbstractValidator<AtualizarVoluntarioRequestDto>
    {
        public AtualizarVoluntarioValidationDto()
        {
            RuleFor(v => v.Nome)
                .NotEmpty().WithMessage("O nome do voluntário é obrigatório.")
                .MaximumLength(100).WithMessage("O nome do voluntário não pode exceder 100 caracteres.");

            RuleFor(v => v.Telefone)
                .NotEmpty().WithMessage("O telefone do voluntário é obrigatório.")
                .Matches(@"^\d{2} \d{5} \d{4}$").WithMessage("TELEFONE_VOLUNTARIO deve estar no formato: 00 00000 0000");
        }
    }
}
