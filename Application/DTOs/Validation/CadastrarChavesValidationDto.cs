using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Storage.Application.DTOs.Request;

namespace Storage.Application.DTOs.Validation
{
    internal class CadastrarChavesValidationDto : AbstractValidator<CadastrarChavesRequestDto>
    {
        public CadastrarChavesValidationDto()
        {
            RuleFor(v => v.Descricao)
                .NotEmpty().WithMessage("Descrição é obrigatório")
                .MaximumLength(60).WithMessage("A descrição não pode ultrapassar 60 caracteres.");

            RuleFor(v => v.Nome)
                .NotEmpty().WithMessage("O nome é obrigatorio")
                .MaximumLength(60).WithMessage("O nome da chave não pode ultrapassar 60 caracteres.");

            RuleFor(v => v.Quantidade)
                .NotEmpty().WithMessage("A quantidade é obrigatoria");

        }

    }
}
