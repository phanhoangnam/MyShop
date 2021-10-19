using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyShop.Data.EF;
using MyShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly MyShopDBContext _context;

        public UsersController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, MyShopDBContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
    }
}
