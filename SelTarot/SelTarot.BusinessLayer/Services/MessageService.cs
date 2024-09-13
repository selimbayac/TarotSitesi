using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SelTarot.BusinessLayer.Abstract;
using SelTarot.DataAccesLayer.Abstract;
using SelTarot.DtoLayer.Concrete;
using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.BusinessLayer.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

      

        public async Task<IEnumerable<Message>> GetMessagesForUserAsync(int userId)
        {
            return await _messageRepository.GetMessagesByUserIdAsync(userId);
        }

        public async Task<IEnumerable<Message>> GetMessagesBetweenUsersAsync(int userId, int receiverId)
        {
            return await _messageRepository.GetMessagesBetweenUsersAsync(userId, receiverId);
        }
        public async Task<List<Message>> GetMessagesAsync(int userId)
        {
            return (List<Message>)await _messageRepository.GetMessagesByUserIdAsync(userId);
        }

        public async Task<IEnumerable<Message>> GetMessagesReceivedByUserAsync(int userId)
        {
            return await _messageRepository.GetMessagesReceivedByUserAsync(userId);
        }
        public async Task SendMessageAsync(Message message)
        {
            await _messageRepository.AddAsync(message);
        }
        
        public async Task<IEnumerable<Message>> GetMessagesByUserIdAsync(int userId)
        {
            return await _messageRepository.GetMessagesByUserIdAsync(userId);
        }
    }
}