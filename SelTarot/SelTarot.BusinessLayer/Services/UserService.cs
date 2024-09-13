using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SelTarot.DtoLayer.Concrete;
using SelTarot.BusinessLayer.Abstract;
using SelTarot.DataAccesLayer.Abstract;
using SelTarot.DataAccesLayer.Repositories;

namespace SelTarot.BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly Context _context;
        private readonly IUserRepository _userRepository;
        private readonly IMessageRepository _messageRepository;
        public UserService(Context context , IUserRepository userRepository, IMessageRepository messageRepository)
        {
            _context = context;
            _userRepository = userRepository;
            _messageRepository = messageRepository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public User ValidateUser(string username, string password)
        {
            // Kullanıcıyı veritabanından kontrol etme işlemi
            return _userRepository.GetUserByCredentials(username, password);
        }


        public async Task<List<User>> GetFortuneTellersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            var fortuneTellers = new List<User>();

            foreach (var user in users)
            {
                if (await _userRepository.IsUserInRoleAsync(user.Id, "Falcı"))
                {
                    fortuneTellers.Add(user);
                }
            }

            return fortuneTellers;
        }
        public async Task<List<User>> GetUsersInRoleAsync(string role)
        {
            return await _userRepository.GetUsersInRoleAsync(role);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }
        public async Task<bool> DeleteUserAsync(int userId)
        {
            // Kullanıcıyı bul
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
                return false; // Kullanıcı bulunamazsa false dön

            // Kullanıcıya ait mesajları al
            var messagesToDelete = await _messageRepository.GetMessagesByUserIdAsync(userId);

            // Mesajları sil
            await _messageRepository.DeleteMessagesAsync(messagesToDelete);

            // Kullanıcıyı sil
            await _userRepository.DeleteAsync(user);

            return true; // Silme işlemi başarılı
        }
    }
}
