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
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }

        public async Task AddAsync(Message message)
        {
            try
            {
                _context.Messages.Add(message);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Hata mesajını loglayın veya hata ayıklama amaçlı gösterin.
                Console.WriteLine($"Hata oluştu: {ex.Message}");
                throw; // Gerekirse hatayı tekrar fırlatın.
            }
        }
        public async Task<IEnumerable<Message>> GetMessagesBetweenUsersAsync(int userId, int receiverId)
        {
            return await _context.Messages
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .Where(m => (m.SenderId == userId && m.ReceiverId == receiverId) || (m.SenderId == receiverId && m.ReceiverId == userId))
                .ToListAsync();
        }

        public async Task<List<Message>> GetMessagesAsync(int userId)
        {
            return await _context.Messages
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .Where(m => m.ReceiverId == userId || m.SenderId == userId)
                .ToListAsync();
        }

        public async Task AddMessageAsync(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
        }


        public async Task SendMessageAsync(int senderId, int recipientId, string content)
        {
            var message = new Message
            {
                SenderId = senderId,
                ReceiverId = recipientId,
                Content = content,
                SentDate = DateTime.UtcNow
            };

            await AddAsync(message);
        }

        public async Task SendMessageAsync(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
        }

        public Task<List<Message>> GetMessagesForUserAsync(int userId)
        {
            throw new NotImplementedException(); // bu ne aq
        }
  
        public async Task<IEnumerable<Message>> GetMessagesByUserIdAsync(int userId)
        {
            return await _context.Messages
                .Include(m => m.Sender)
                .Include(m => m.Receiver)  // Burada alıcıyı da dahil ediyoruz
                .Where(m => m.SenderId == userId || m.ReceiverId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Message>> GetMessagesReceivedByUserAsync(int userId)
        {
            return await _context.Messages
                .Include(m => m.Sender) // Sender bilgilerini dahil et
                .Where(m => m.ReceiverId == userId)
                .ToListAsync();
        }
        public async Task DeleteMessagesAsync(IEnumerable<Message> messages)
        {
            // Mesajları veritabanından sil
            _context.Messages.RemoveRange(messages);
            await _context.SaveChangesAsync();
        }
    }
}
