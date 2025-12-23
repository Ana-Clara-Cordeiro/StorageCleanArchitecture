using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Storage.Application.DTOs.Request;

namespace Storage.Application.DTOs.Validation
{
    internal class AtualizarChavesValidationDto : AbstractValidator<AtualizarChavesResquestDto>

    {
        public AtualizarChavesValidationDto()
        {
            RuleFor(v => v.Nome)
                .NotEmpty().WithMessage("O nome da chave é obrigatorio.")
                .MaximumLength(60).WithMessage("O nome da chave não pode exceder 60 caracteres.");

            RuleFor(v => v.Descricao)
                .NotEmpty().WithMessage("Descrição é obrigatorio.")
                .MaximumLength(60).WithMessage("A descrição não pode ultrapassar 60 caracteres.");

            RuleFor(v => v.Quantidade)
                .NotEmpty().WithMessage("A quantidade é obrigatoria.");
        }
    }
}
