using FluentValidation;
using Hospital.Dtos;
using Hospital.Entities;

namespace Hospital.Validator
{
    public class DoctorsValidator:AbstractValidator<Doctor>
    {
        public DoctorsValidator()
        {
            RuleFor(doctor => doctor.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("لطفا نام دکتر را وارد کنید")
                .Length(2 - 50).WithMessage("تعداد کاراکتر های نام باید حداقل ۲ کاراکتر باشد")
                .Must(BeAValidName).WithMessage("نام وارد شده دارای کاراکتر های غیر مجاز میباشد");


            RuleFor(doctor => doctor.Lastname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("لطفا نام خانوادگی دکتر را وارد کنید")
                .Length(2 - 50).WithMessage("تعداد کاراکتر های نام خانوادگی باید حداقل ۲ کاراکتر باشد")
                .Must(BeAValidName).WithMessage("عبارت وارد شده دارای کاراکتر های غیر مجاز میباشد");

            RuleFor(doctor => doctor.SutySystemCode)
                .NotEmpty()
                .InclusiveBetween(100000,999999);
        }



        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }
    }
}
