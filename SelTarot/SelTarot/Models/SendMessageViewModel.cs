using SelTarot.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace SelTarot.Models
{
    public class SendMessageViewModel
    {
        //public int ReceiverId { get; set; }
        //public string Content { get; set; }
        //public User Receiver { get; set; } // Mesaj gönderilen kullanıcı
        //public List<User> Falcilar { get; set; } // Falcı olan kullanıcıları listele
        //public List<EntityLayer.Concrete.Message> Messages { get; internal set; }
        //public List<User> Users { get; set; } = new List<User>(); // User modelini kullanacağız 


        public int ReceiverId { get; set; }
        [Required]
        public string Content { get; set; }
        public List<User> Falcilar { get; set; } // Falcıların listesi
    }
}

