
using SelTarot.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.DataAccesLayer.Abstract
{
    public interface IMessageRepository
    {
        Task AddAsync(EntityLayer.Concrete.Message message);
        Task<List<EntityLayer.Concrete.Message>> GetMessagesAsync(int userId);      
        Task AddMessageAsync(EntityLayer.Concrete.Message message); // Mesaj ekleme
        Task<IEnumerable<EntityLayer.Concrete.Message>> GetMessagesBetweenUsersAsync(int userId, int receiverId); // İki kullanıcı arasındaki mesajları getir
        Task<List<Message>> GetMessagesForUserAsync(int userId);
        Task SendMessageAsync(int senderId, int recipientId, string content);

        Task SendMessageAsync(Message message);
        Task<IEnumerable<Message>> GetMessagesByUserIdAsync(int userId);
       
        Task<IEnumerable<Message>> GetMessagesReceivedByUserAsync(int userId);
        Task DeleteMessagesAsync(IEnumerable<Message> messages);

    }
}
