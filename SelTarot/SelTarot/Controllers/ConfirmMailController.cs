using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SelTarot.EntityLayer.Concrete;
using SelTarot.Models;

namespace SelTarot.Controllers
{
    public class ConfirmMailController : Controller
    {
        private readonly UserManager<User> _userManager;

        public ConfirmMailController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var value = TempData["Mail"];
            ViewBag.v = value;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ConfirmMailViewModel confirm)
        {
            var value = TempData["Mail"];
            ViewBag.v = value;
            var user = await _userManager.FindByEmailAsync(confirm.Mail);
            if (user.ConfirmCode == confirm.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();     
     
        }
    }
}
