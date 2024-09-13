using Microsoft.EntityFrameworkCore;
using SelTarot.DataAccesLayer.Abstract;
using SelTarot.DtoLayer.Concrete;
using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.DataAccesLayer.Repositories
{
    public class FortuneTellerRepository : IFortuneTellerRepository
    {
        private readonly Context _context;

        public FortuneTellerRepository(Context context)
        {
            _context = context;
        }

        public async Task<FortuneTeller> GetByIdAsync(int id)
        {
            return await _context.FortuneTellers.FindAsync(id);
        }

        public async Task<IEnumerable<FortuneTeller>> GetAllAsync()
        {
            return await _context.FortuneTellers.ToListAsync();
        }
    }
}
