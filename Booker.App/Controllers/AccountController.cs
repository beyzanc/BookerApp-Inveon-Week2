using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Booker.App.Models;
using Microsoft.AspNetCore.Authorization;

namespace Booker.App.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                ModelState.AddModelError("", "Geçersiz giriş denemesi.");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, password, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                if (await _userManager.IsInRoleAsync(user, "Admin"))
                {
                    return RedirectToAction("Index", "AdminPanel");
                }
                else
                {
                    return RedirectToAction("Index", "Books");
                }
            }

            ModelState.AddModelError("", "Geçersiz giriş denemesi.");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            var userName = User.Identity.Name;
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string fullName, string email, string password)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = email.Split('@')[0],
                    Email = email,
                    FullName = fullName,
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                    return RedirectToAction("Login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View();
        }


    }
}
