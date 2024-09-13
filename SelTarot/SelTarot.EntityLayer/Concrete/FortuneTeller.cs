using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.EntityLayer.Concrete
{
    public class FortuneTeller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public ICollection<Message> Messages { get; set; }
        public string Bio { get; set; }

        // User ile ilişkilendirme
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public static implicit operator FortuneTeller(User v)
        {
            throw new NotImplementedException();
        }
    }
}
