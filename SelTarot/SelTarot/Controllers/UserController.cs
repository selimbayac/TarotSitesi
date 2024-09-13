using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelTarot.DtoLayer.Concrete;
using SelTarot.EntityLayer.Concrete;

namespace SelTarot.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly Context _context;
        public UserController(UserManager<User> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        public IActionResult SendMessage(int fortuneTellerId)
        {
            ViewBag.FortuneTellerId = fortuneTellerId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(int fortuneTellerId, string content)
        {
            var userId = _userManager.GetUserId(User);

            var message = new Message
            {
                SenderId = int.Parse(userId),
                ReceiverId = fortuneTellerId,
                Content = content,
              //  CreatedDate = DateTime.Now
            };

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return RedirectToAction("Messages", "User");
        }

        [HttpGet]
        public async Task<IActionResult> Messages()
        {
            var userId = _userManager.GetUserId(User);
            var messages = await _context.Messages
                .Where(m => m.SenderId == int.Parse(userId) || m.ReceiverId == int.Parse(userId))
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .ToListAsync();

            return View(messages);
        }
    }
}
