using Microsoft.AspNetCore.Identity;
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
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        private readonly UserManager<User> _userManager;

        public UserRepository(Context context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public User GetUserByCredentials(string username, string password)
        {
            return _context.Users
             .FirstOrDefault(u => u.UserName == username && u.PasswordHash == password);
        }
       
        public async Task<List<User>> GetFortuneTellersAsync()
        {
            var allUsers = await _userManager.Users.ToListAsync();
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
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<bool> IsUserInRoleAsync(int userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) return false;
            return await _userManager.IsInRoleAsync(user, roleName);
        }
        public async Task<List<User>> GetUsersInRoleAsync(string role)
        {
            // Kullanıcıları rolüne göre almak için UserManager kullanılır
            var users = await _userManager.GetUsersInRoleAsync(role);
            return users.ToList();
        }
        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Message>> GetMessagesReceivedByUserAsync(int userId)
        {
            return await _context.Messages
                                 .Include(m => m.Sender)  // Sender bilgilerini dahil edin
                                 .Include(m => m.Receiver)  // Receiver bilgilerini dahil edin
                                 .Where(m => m.ReceiverId == userId)
                                 .ToListAsync();
        }
        public async Task DeleteAsync(User user)
        {
            // Kullanıcıyı veritabanından sil
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
