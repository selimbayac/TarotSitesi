using System.ComponentModel.DataAnnotations;

namespace SelTarot.Models
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        public string SenderUserName { get; set; }
        public string Content { get; set; }
        public DateTime SentDate { get; set; }

        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverUserName { get; set; }
        [Required]
        public string ReplyContent { get; set; }
    }
}
