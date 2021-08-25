using LABOL;
using LAUI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAUI.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        readonly UserManager<LAUser> userManager;
        readonly SignInManager<LAUser> signInManager;

        public AccountController(UserManager<LAUser> _userManager, SignInManager<LAUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                LAUser user = new LAUser()
                {
                    UserName = model.UserName,
                    Email = model.Email
                };

                var resultCreate = await userManager.CreateAsync(user, model.Password);
                if (resultCreate != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create user in database");
                }
                
                var resultRoleAssign = await userManager.AddToRoleAsync(user, "User");             
                var resultSignIn = await signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);
                if (resultSignIn.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var Result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, true);
                if (Result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
