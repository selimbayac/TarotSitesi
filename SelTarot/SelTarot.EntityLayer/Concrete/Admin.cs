using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.EntityLayer.Concrete
{
    public class Admin
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // User ile ilişkilendirme
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
