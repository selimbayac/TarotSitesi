using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.EntityLayer.Concrete
{
    public class Message
    {
        //public int Id { get; set; }
        //public string Content { get; set; }
        //public int SenderId { get; set; }
        //public int ReceiverId { get; set; }
        //public DateTime SentDate { get; set; }

        //public virtual User Sender { get; set; }
        //public virtual User Receiver { get; set; }

        public int Id { get; set; }
        public int SenderId { get; set; }
        public User Sender { get; set; }
        public int ReceiverId { get; set; }
        public User Receiver { get; set; }
        public string Content { get; set; }
        public DateTime SentDate { get; set; }
    }
}
