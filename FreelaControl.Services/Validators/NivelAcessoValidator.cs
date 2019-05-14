using FluentValidation;
using FreelaControl.Domain.Entities;
using System;

namespace FreelaControl.Services.Validators
{
    public class NivelAcessoValidator : AbstractValidator<NivelAcesso>
    {
        public NivelAcessoValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto não encontrado!");
                });

            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Nome é Obrigatório!")
                .MaximumLength(100)
                .WithMessage("O Nome não pode conter mais do que 100 caracteres!");

        }
    }
}