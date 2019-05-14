using FluentValidation;
using FreelaControl.Domain.Entities;
using System;

namespace FreelaControl.Services.Validators
{
    public class UploadValidator : AbstractValidator<Upload>
    {
        public UploadValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto não encontrado!");
                });
            
            RuleFor(x => x.LinkUpload)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Link Upload é Obrigatório!")
                .MaximumLength(255)
                .WithMessage("O Link Upload não pode conter mais do que 255 caracteres!");

        }
    }
}
