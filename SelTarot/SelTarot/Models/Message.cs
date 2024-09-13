using SelTarot.EntityLayer.Concrete;

namespace SelTarot.Models
{
    public class Message
    {
        public User Sender { get; set; }
        public string Content { get; set; }
        public DateTime SentDate { get; set; }

    }
}
