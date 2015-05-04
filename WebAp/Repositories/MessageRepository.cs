using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.Models;
using WebAp.IRepositories;
using WebAp.Repositories;
using WebAp.Controllers;
using WebAp.ModelsView;
using System.Data.Entity;

namespace WebAp.Repositories
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(WebApContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Message>();
        }

        IEnumerable<Message> GetAllMessages()
        {
            var query = from msg in context.Messages select msg;
            return query.ToList();
        }

        public Message GetMessageById(int messageId)
        {
            var query = from msg in context.Messages where msg.MessageID == messageId select msg;
            return query.FirstOrDefault();
        }
    }
}