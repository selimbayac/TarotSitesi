using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelTarot.BusinessLayer.Abstract;
using SelTarot.EntityLayer.Concrete;
using SelTarot.Models;

namespace SelTarot.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;
        public AdminController(UserManager<User> userManager , IUserService userService)
        {
            _userManager = userManager;
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> AssignAdminRole(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            return RedirectToAction("UserManagement");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveAdminRole(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }
            return RedirectToAction("UserManagement");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFortuneTellerRole(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, "Falcı");
             //   user.IsFortuneTeller = false;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("UserManagement");
        }

        [HttpPost]
        public async Task<IActionResult> AssignFortuneTellerRole(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, "Falcı");
             //   user.IsFortuneTeller = true;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("UserManagement");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var result = await _userService.DeleteUserAsync(userId);
            if (!result)
            {
                // Hata yönetimi - Silme işlemi başarısız
                return BadRequest("Kullanıcı silinemedi.");
            }
            return RedirectToAction("UserManagement");
        }

        public async Task<IActionResult> UserManagement()
        {
            // Kullanıcıları veritabanından alın
            var users = await _userManager.Users.ToListAsync();

            // Her kullanıcı için rol verilerini alın
            var userViewModels = new List<UserManagementViewModel>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userViewModels.Add(new UserManagementViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    Roles = roles.ToList() // Listeye dönüştür
                });
            }

            // Görünüm için model verisi döndür
            return View(userViewModels);
        }

    }

}
