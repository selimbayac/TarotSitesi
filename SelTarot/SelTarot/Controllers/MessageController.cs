using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SelTarot.BusinessLayer.Abstract;
using SelTarot.EntityLayer.Concrete;
using SelTarot.Models;
using System.Security.Claims;

public class MessageController : Controller
{
    private readonly IMessageService _messageService;
    private readonly IUserService _userService;
    private readonly UserManager<User> _userManager;

    public MessageController(IMessageService messageService, IUserService userService, UserManager<User> userManager)
    {
        _messageService = messageService;
        _userService = userService;
        _userManager = userManager;
    }

    public async Task<IActionResult> Inbox()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

        var messages = await _messageService.GetMessagesByUserIdAsync(userId);

        return View(messages);
    }


    [HttpGet]
    public async Task<IActionResult> SendMessage()
    {
        var falcis = await _userService.GetUsersInRoleAsync("Falcı");
        var model = new SendMessageViewModel
        {
            Falcilar = falcis
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Send(SendMessageViewModel model)
    { // falcı null geliyo çalışıyorsa sorgulama aga anasını sikersin gece 3 ten beri uğraşıyom 
        if (!ModelState.IsValid)
        {
            var senderId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var message = new SelTarot.EntityLayer.Concrete.Message
            {
                SenderId = senderId,
                ReceiverId = model.ReceiverId,
                Content = model.Content,
                SentDate = DateTime.Now
            };

            await _messageService.SendMessageAsync(message);
            return RedirectToAction("Inbox");
        }

        // Model geçerli değilse falcı listesini tekrar yükleyin
        model.Falcilar = await _userService.GetUsersInRoleAsync("Falcı");
        ViewBag.FalciList = model.Falcilar;
        return View("SendMessage", model);
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        var user = await _userManager.FindByIdAsync(userId.ToString());
        var isFortuneTeller = await _userManager.IsInRoleAsync(user, "Falcı");

        if (!isFortuneTeller)
        {
            return RedirectToAction("Index", "Home"); // Falcı değilse anasayfaya yönlendir
        }

        var messages = await _messageService.GetMessagesReceivedByUserAsync(userId);
        var model = new InboxViewModel
        {
            ReceivedMessages = messages.Select(m => new MessageViewModel
            {
                Id = m.Id,
                SenderUserName = m.Sender.UserName,
                Content = m.Content,
                SentDate = m.SentDate,
                SenderId = m.SenderId,
                ReceiverId = m.ReceiverId
            }).ToList()
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Reply(MessageViewModel model)
    {
        if (ModelState.IsValid)
        {
            var senderId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var replyMessage = new SelTarot.EntityLayer.Concrete.Message
            {
                SenderId = senderId,
                ReceiverId = model.SenderId,
                Content = model.ReplyContent,
                SentDate = DateTime.Now
            };

            await _messageService.SendMessageAsync(replyMessage);
            return RedirectToAction("Index");
        }

        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        var messages = await _messageService.GetMessagesReceivedByUserAsync(userId);
        var viewModel = new InboxViewModel
        {
            ReceivedMessages = messages.Select(m => new MessageViewModel
            {
                Id = m.Id,
                SenderUserName = m.Sender.UserName,
                Content = m.Content,
                SentDate = m.SentDate,
                SenderId = m.SenderId,
                ReceiverId = m.ReceiverId
            }).ToList()
        };

        return View("Index", viewModel); // Yanıt vermeyi başarısız olursa tekrar gelen kutusuna dön
    }

    [HttpGet]
    public async Task<IActionResult> SendMessageToUser()
    {
        var users = await _userService.GetAllUsersAsync();
        return View(users);
    }

    [HttpPost]
    public async Task<IActionResult> SendMessageToUser(int receiverId, string content)
    {
        var senderId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        var message = new SelTarot.EntityLayer.Concrete.Message
        {
            SenderId = senderId,
            ReceiverId = receiverId,
            Content = content,
            SentDate = DateTime.UtcNow
        };

        await _messageService.SendMessageAsync(message);
        TempData["Success"] = "Mesaj başarıyla gönderildi.";
        return RedirectToAction("SendMessageToUser");
    }
    [HttpGet]
    public async Task<IActionResult> FortuneTellerInbox()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        var isFortuneTeller = await _userManager.IsInRoleAsync(await _userManager.FindByIdAsync(userId.ToString()), "Falcı");

        if (!isFortuneTeller)
        {
            return RedirectToAction("Index", "Home"); // Falcı değilse anasayfaya yönlendir
        }

        var messages = await _messageService.GetMessagesReceivedByUserAsync(userId);
        var model = new InboxViewModel
        {
            ReceivedMessages = messages.Select(m => new MessageViewModel
            {
                Id = m.Id,
                SenderUserName = m.Sender != null ? m.Sender.UserName : "Bilinmiyor",
                ReceiverUserName = m.Receiver != null ? m.Receiver.UserName : "Bilinmiyor", // Alıcıyı kontrol et
                Content = m.Content,
                SentDate = m.SentDate,
                SenderId = m.SenderId,
                ReceiverId = m.ReceiverId
            }).ToList()
        };

        return View(model);
    }
}
