using MyShop.ViewModels.Common;
using MyShop.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Login(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest registerRequest);
        Task<UserViewModel> GetUserByUserName(string userName);
    }
}
