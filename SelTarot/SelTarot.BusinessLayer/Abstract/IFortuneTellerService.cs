using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.BusinessLayer.Abstract
{
    public interface IFortuneTellerService
    {
        Task<IEnumerable<User>> GetAllFortuneTellersAsync();
        Task<User> GetFortuneTellerByIdAsync(int id);
    }
}
