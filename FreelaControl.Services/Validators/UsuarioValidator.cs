using FluentValidation;
using FreelaControl.Domain.Entities;
using System;

namespace FreelaControl.Services.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
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

            RuleFor(x => x.Identificador)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Identificador é Obrigatório!")
                .MaximumLength(100)
                .WithMessage("O Identificador não pode conter mais do que 100 caracteres!");

            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Email é Obrigatório!")
                .MaximumLength(100)
                .WithMessage("O Email não pode conter mais do que 100 caracteres!")
                .EmailAddress()
                .WithMessage("O Email não é válido!");

            RuleFor(x => x.Senha)
                .NotNull()
                .NotEmpty()
                .WithMessage("A Senha é Obrigatória!")
                .MaximumLength(255)
                .WithMessage("A Senha não pode conter mais do que 255 caracteres!");

            RuleFor(x => x.NivelAcessoId)
                .GreaterThan(0)
                .WithMessage("O Nivel de Acesso é obrigatório!");

            RuleFor(x => x.Rua)
                .NotNull()
                .NotEmpty()
                .WithMessage("A Rua é Obrigatória!")
                .MaximumLength(100)
                .WithMessage("A Rua não pode conter mais do que 100 caracteres!");

            RuleFor(x => x.Numero)
                .NotNull()
                .NotEmpty()
                .WithMessage("O numero é Obrigatório!")
                .MaximumLength(100)
                .WithMessage("O Numero não pode conter mais do que 100 caracteres!");

            RuleFor(x => x.Bairro)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Bairro é Obrigatório!")
                .MaximumLength(100)
                .WithMessage("O Bairro não pode conter mais do que 100 caracteres!");

            RuleFor(x => x.Cidade)
                .NotNull()
                .NotEmpty()
                .WithMessage("A Cidade é Obrigatória!")
                .MaximumLength(100)
                .WithMessage("A cidade não pode conter mais do que 100 caracteres!");

            RuleFor(x => x.Estado)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Estado é Obrigatório!")
                .MaximumLength(100)
                .WithMessage("O Estado não pode conter mais do que 100 caracteres!");

            RuleFor(x => x.Cep)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Cep é Obrigatório!")
                .MaximumLength(50)
                .WithMessage("O Cep não pode conter mais do que 50 caracteres!");

            RuleFor(x => x.Complemento)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Complemento é Obrigatório!")
                .MaximumLength(150)
                .WithMessage("O Complemento não pode conter mais do que 150 caracteres!");

            RuleFor(x => x.TelefoneUm)
                .MaximumLength(20)
                .WithMessage("O Telefone Um não pode conter mais do que 20 caracteres!");

            RuleFor(x => x.TelefoneDois)
                .MaximumLength(20)
                .WithMessage("O Telefone Dois não pode conter mais do que 100 caracteres!");
        }
    }
}
