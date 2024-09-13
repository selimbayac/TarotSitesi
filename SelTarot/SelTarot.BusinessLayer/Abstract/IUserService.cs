using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.BusinessLayer.Abstract
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
        Task<List<User>> GetFortuneTellersAsync();
        Task<List<User>> GetUsersInRoleAsync(string role);
        Task<User> GetUserByIdAsync(int id);

        Task<bool> DeleteUserAsync(int userId);
        Task<List<User>> GetAllUsersAsync();
     
    }
}

