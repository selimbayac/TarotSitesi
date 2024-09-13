using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.DataAccesLayer.Abstract
{
    public interface IUserRepository
    {
        User GetUserByCredentials(string username, string password);
        Task<List<User>> GetFortuneTellersAsync();
        Task<List<User>> GetAllUsersAsync();
        Task<bool> IsUserInRoleAsync(int userId, string roleName);
        Task<List<User>> GetUsersInRoleAsync(string role);
        Task<User> GetByIdAsync(int id);
        Task<IEnumerable<Message>> GetMessagesReceivedByUserAsync(int userId);
        Task DeleteAsync(User user);
    }
}
