using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyShop.Data.Entities;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;

        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signinManager,
            RoleManager<AppRole> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _signinManager = signinManager;
            _roleManager = roleManager;
            _config = config;
        }

        public async Task<UserViewModel> GetUserByUserName(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var userVm = new UserViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Dob = user.Dob,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
            };
            return userVm;
        }

        public async Task<ApiResult<string>> Login(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
            {
                return new ApiErrorResult<string>("Tài khoản không tồn tại");
            }
            var result = await _signinManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>("Đăng nhập không đúng");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";", roles)),
                new Claim(ClaimTypes.Name, user.UserName), 

            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {
                return new ApiErrorResult<bool>("Tài khoản đã tồn tại");
            }

            var emailUser = await _userManager.FindByEmailAsync(request.Email);
            if (emailUser != null)
            {
                return new ApiErrorResult<bool>("Emai đã tồn tại");
            }

            user = new AppUser()
            {
                Dob = request.Dob,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Đăng ký không thành công");
        }
    }
}
