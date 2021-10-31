using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ViewModels.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Tên không thể bỏ trống");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Họ không thể bỏ trống");

            RuleFor(x => x.Dob).NotEmpty().WithMessage("Ngày sinh không thể bỏ trống");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không thể bỏ trống");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Số điện thoại không thể bỏ trống")
                .Matches(@"^0+[0-9]{9}$")
                .WithMessage("Số điện thoại không đúng định dạng");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tên tài khoản không thể bỏ trống");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không thể bỏ trống")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")
                .WithMessage("Mật khẩu tối thiểu 8 ký tự, ít nhất một ký tự hoa, một ký tự viết thường, một số và một ký tự đặc biệt");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Xác nhận mật khẩu không đúng");
                }
            });
        }
    }
}
