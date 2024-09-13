using Microsoft.AspNetCore.Mvc;
using SelTarot.BusinessLayer.Abstract;
using SelTarot.Data;

namespace SelTarot.Controllers
{
    public class TarotController : Controller
    {
        public IActionResult SevenCardSpread()
        {
            var cards = TarotCardRepository.GetAllCards();
            ViewBag.Cards = cards;
            return View();
        }

        [HttpPost]
        public IActionResult RevealCards(int[] selectedCardIds)
        {
            var cards = TarotCardRepository.GetAllCards();
            var selectedCards = cards.Where(c => selectedCardIds.Contains(c.Id)).ToList();
            return PartialView("_CardResults", selectedCards);
        }
        // 3 Kart yayışımı 
        public IActionResult ThreeCardSpread()
        {
            var cards = TarotCardRepository.GetAllCards();
            ViewBag.Cards = cards;
            return View();
        }
        [HttpPost]
        public IActionResult RevealThreeCards(int[] selectedCardIds)
        {
            var cards = TarotCardRepository.GetAllCards();
            var selectedCards = cards.Where(c => selectedCardIds.Contains(c.Id)).ToList();
            return PartialView("_CardResults", selectedCards);
        }
        public IActionResult SingleCardSpread()
        {
            var cards = TarotCardRepository.GetAllCards();
            ViewBag.Cards = cards;
            return View();
        }

        [HttpPost]
        public IActionResult RevealSingleCard(int selectedCardId)
        {
            var card = TarotCardRepository.GetAllCards().FirstOrDefault(c => c.Id == selectedCardId);
            if (card == null)
            {
                return NotFound();
            }
            return PartialView("_SingleCardResult", card);
        }
    }
}
