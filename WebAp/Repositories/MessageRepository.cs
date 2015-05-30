using System.Collections.Generic;
using System.Linq;
using WebAp.IRepositories;
using DataLayer.Models;

namespace WebAp.Repositories
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(ThreeTierContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Message>();
        }

        public IEnumerable<Message> GetAllMessages()
        {
            var query = from msg in context.Messages select msg;
            return query.ToList();
        }

        public Message GetMessageById(int messageId)
        {
            var query = from msg in context.Messages where msg.MessageId == messageId select msg;
            return query.FirstOrDefault();
        }
    }
}