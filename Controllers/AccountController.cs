using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using WebMash.Models;
using WebMash.Service.Interface;
using WebMash.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebMash.Controllers
{
    //[Route("auth")]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //[Route("login")]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            });
        }

        //[Route("login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var (isValid, user) = await _userService.ValidateUserCredentialsAsync(model.UserName, model.Password);
                if (isValid)
                {
                    await LoginAsync(user);
                    if (IsUrlValid(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("InvalidCredentials", "Invalid credentials.");
            }

            return View(model);
        }

        private async Task LoginAsync(User user)
        {
            var claims = new List<Claim>
                                        {
                                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                                            new Claim(ClaimTypes.Name, user.UserName),
                                            new Claim(ClaimTypes.GivenName, user.FirstName),
                                            new Claim(ClaimTypes.Surname, user.LastName),
                                            new Claim(ClaimTypes.DateOfBirth, user.DateOfBirth.ToString("o"), ClaimValueTypes.DateTime)
                                        };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);
        }

        private static bool IsUrlValid(string returnUrl)
        {
            return !string.IsNullOrWhiteSpace(returnUrl)
                   && Uri.IsWellFormedUriString(returnUrl, UriKind.Relative);
        }
    }
}
