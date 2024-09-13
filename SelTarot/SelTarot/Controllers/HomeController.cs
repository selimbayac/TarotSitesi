using Microsoft.AspNetCore.Mvc;
using SelTarot.Data;
using SelTarot.Models;
using System.Diagnostics;

namespace SelTarot.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Tüm tarot kartlarını al
            var cards = TarotCardRepository.GetAllCards();
            ViewBag.Cards = cards;
            return View();
        }

        // Form gönderimi
        [HttpPost]
        public async Task<IActionResult> Index(string userInput)
        {
            // Burada chat veya başka bir işlem yapabilirsin
            // Eğer bir işlem yapacaksan, response'u ViewBag'e ekle
            // ViewBag.Response = response;

            // Tüm tarot kartlarını tekrar al
            var cards = TarotCardRepository.GetAllCards();
            ViewBag.Cards = cards;
            ViewBag.UserInput = userInput;
            return View();
        }
    }
}