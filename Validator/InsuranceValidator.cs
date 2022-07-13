using FluentValidation;
using Hospital.Dtos;
using Hospital.Entities;

namespace Hospital.Validator
{
    public class InsuranceValidator:AbstractValidator<CreateInsuranceDto>
    {
        public InsuranceValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage("نام بیمه را وارد کنید ");
            RuleFor(t => t.Discount).GreaterThan(1000);
        }
    }
}
