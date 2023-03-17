using Catalog.Application.Features.Products.Commands;
using FluentValidation;

namespace Catalog.Application.Features.Products.CommandValidations
{
    public class CreateProductCommandValidation : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidation()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{Title} is required.")
                .NotNull()
                .MaximumLength(150).WithMessage("{Title} must not exceed 150 characters.");
            
            RuleFor(p => p.ImageName)
                .NotEmpty().WithMessage("{ImageName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{ImageName} must not exceed 50 characters."); 
            
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{Description} is required.")
                .NotNull()
                .MaximumLength(500).WithMessage("{Description} must not exceed 500 characters.");


        }
    }
}
