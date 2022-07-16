using FluentValidation;
using Hospital.Dtos;
using Hospital.Entities;

namespace Hospital.Validator
{
    public class InsuranceValidator : AbstractValidator<CreateInsuranceDto>
    {
        public InsuranceValidator()
        {

            RuleFor(t => t.Name).NotEmpty().WithMessage("نام بیمه را وارد کنید ");


    

            //When(c => c.Discount > c.DiscountCeiling, () =>
            //{
            //    RuleFor(c => c.Discount).Equal(c=>c.DiscountCeiling).WithMessage("مقدار تخفیف از سقف میزان پرداخت بیش تر است");
            //});
                

            
         
        }
    }
}
