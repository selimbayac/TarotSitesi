using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SelTarot.DtoLayer.Dtos.AppUserDtos;
using SelTarot.EntityLayer.Concrete;

namespace SelTarot.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<User> _userManager;

        public RegisterController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if (ModelState.IsValid)
            {
                var random = new Random();
                var code = random.Next(1000, 1000000);

                User appUser = new User
                {
                    UserName = appUserRegisterDto.UserName,
                    Email = appUserRegisterDto.Email,
                   ConfirmCode = code
                };

                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    try
                    {
                        var mimeMessage = new MimeMessage();
                        var mailboxAddressFrom = new MailboxAddress("Admin", "ariyelteamforrest@gmail.com"); // Burayı uygun e-posta adresi ile değiştirin
                        var mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                        mimeMessage.From.Add(mailboxAddressFrom);
                        mimeMessage.To.Add(mailboxAddressTo);

                        var bodyBuilder = new BodyBuilder
                        {
                            TextBody = $"Kayıt işlemi gerçekleştirmek için Onay kodunuz: {code}"
                        };
                        mimeMessage.Body = bodyBuilder.ToMessageBody();

                        mimeMessage.Subject = "Sel Tarot Onay Kodu";

                        using (var client = new SmtpClient())
                        {
                            client.Connect("smtp.gmail.com", 587, false);
                            client.Authenticate("ariyelteamforrest@gmail.com", "qcdmyamexezzfmmf"); // Şifreyi çevrimiçi bir şifre yöneticisinde saklayın
                            client.Send(mimeMessage);
                            client.Disconnect(true);
                        }

                        TempData["Mail"] = appUserRegisterDto.Email;
                        return RedirectToAction("Index", "ConfirmMail");
                    }
                    catch (Exception ex)
                    {
                        // Log the exception and handle accordingly
                        Console.WriteLine($"Email gönderme hatası: {ex.Message}");
                        ModelState.AddModelError(string.Empty, "Onay e-postası gönderilirken bir hata oluştu.");
                    }
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(appUserRegisterDto); // Modeli geri döndür
        }
    }
}
