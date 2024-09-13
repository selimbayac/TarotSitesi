using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.DataAccesLayer.Abstract
{
    public interface IFortuneTellerRepository
    {
        Task<FortuneTeller> GetByIdAsync(int id);
        Task<IEnumerable<FortuneTeller>> GetAllAsync();
    }
}
