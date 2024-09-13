using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SelTarot.EntityLayer.Concrete;
using SelTarot.Models;

namespace SelTarot.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public LoginController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model); // Görünüm dosyasının adı "Index.cshtml"
            }

            var result = await _signInManager.PasswordSignInAsync(model.Usarname, model.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Geçersiz giriş denemesi.");
            return View("Index", model); // Görünüm dosyasının adı "Index.cshtml"
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }
    }
}

