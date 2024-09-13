using SelTarot.EntityLayer.Concrete; // Gerekli namespace

namespace SelTarot.Models
{
    public class MessagesViewModel
    {
        public List<SelTarot.EntityLayer.Concrete.Message> Messages { get; set; }// Mesajların listesi
        public List<User> Falcilar { get; set; } // Falcı kullanıcıların listesi
        public int ReceiverId { get; set; } // Mesaj gönderme sırasında alıcının ID'si
        public string Content { get; set; } // Mesajın içeriği
    }
}
