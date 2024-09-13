using Microsoft.AspNetCore.Http;
using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.BusinessLayer.Abstract
{
    public interface IMessageService
    {
      //  Task SendMessageAsync(Message message);
        Task<IEnumerable<Message>> GetMessagesForUserAsync(int userId);
        Task<IEnumerable<Message>> GetMessagesBetweenUsersAsync(int userId, int receiverId);
        Task<List<Message>> GetMessagesAsync(int userId);
        // Task SendMessageAsync(int senderId, int receiverId, string content);

        Task<IEnumerable<Message>> GetMessagesByUserIdAsync(int userId);
    
      

        Task SendMessageAsync(Message message);
        Task<IEnumerable<Message>> GetMessagesReceivedByUserAsync(int userId);

       
    }
}
