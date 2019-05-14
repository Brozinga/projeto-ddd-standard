using FluentValidation;
using FreelaControl.Domain.Entities;
using System;

namespace FreelaControl.Services.Validators
{
    public class ConfiguracaoValidator : AbstractValidator<Configuracao>
    {
        public ConfiguracaoValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto não encontrado!");
                });

            RuleFor(x => x.ValorCobradoMensal)
                .GreaterThan(0)
                .WithMessage("O Valor Mensal não pode ser menor que Zero!");

            RuleFor(x => x.DiaTrabalhadosMes)
                .GreaterThan(0)
                .WithMessage("Os Dias Trabalhados não pode ser menor que Zero!");

            RuleFor(x => x.HorasTrabalho)
                .GreaterThan(0)
                .WithMessage("As Horas Trabalhadas não pode ser menor que Zero!");
        }
    }
}
