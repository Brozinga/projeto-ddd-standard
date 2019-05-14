using FluentValidation;
using FreelaControl.Domain.Entities;
using System;

namespace FreelaControl.Services.Validators
{
    public class TrabalhoValidator : AbstractValidator<Trabalho>
    {
        public TrabalhoValidator()
        {
            RuleFor(x => x)
               .NotNull()
               .OnAnyFailure(x =>
               {
                   throw new ArgumentNullException("Objeto não encontrado!");
               });

            RuleFor(x => x.Titulo)
               .NotNull()
               .NotEmpty()
               .WithMessage("O Titulo é Obrigatório!")
               .MaximumLength(150)
               .WithMessage("O Titulo não pode conter mais do que 150 caracteres!");

            RuleFor(x => x.Descricao)
               .NotNull()
               .NotEmpty()
               .WithMessage("A Descrição é Obrigatória!");

            RuleFor(x => x.Prazo)
                .GreaterThan(0)
                .WithMessage("O Prazo não pode ser menor que Zero!");

            RuleFor(x => x.ValorHora)
                .GreaterThan(0)
                .WithMessage("O Valor por Hora não pode ser menor que Zero!");

            RuleFor(x => x.ValorFechado)
                .GreaterThan(0)
                .WithMessage("O Valor Fechado não pode ser menor que Zero!");
        }
    }
}
