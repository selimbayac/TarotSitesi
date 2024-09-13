using Microsoft.AspNetCore.Identity;
using SelTarot.BusinessLayer.Abstract;
using SelTarot.DataAccesLayer.Abstract;
using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.BusinessLayer.Services
{
    public class FortuneTellerService : IFortuneTellerService
    {
        private readonly IFortuneTellerRepository _fortuneTellerRepository;
        private readonly UserManager<User> _userManager;

        public FortuneTellerService(IFortuneTellerRepository fortuneTellerRepository, UserManager<User> userManager)
        {
            _fortuneTellerRepository = fortuneTellerRepository;
            _userManager = userManager;
        }

        public async Task<IEnumerable<User>> GetAllFortuneTellersAsync()
        {
            var allUsers = _userManager.Users.ToList();
            var fortuneTellers = new List<User>();

            foreach (var user in allUsers)
            {
                if (await _userManager.IsInRoleAsync(user, "Falcı"))
                {
                    fortuneTellers.Add(user);
                }
            }

            return fortuneTellers;
        }

        public async Task<User> GetFortuneTellerByIdAsync(int id)
        {
            return await _userManager.FindByIdAsync(id.ToString());
        }
    }
}
