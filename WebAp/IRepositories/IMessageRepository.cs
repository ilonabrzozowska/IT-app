using System.Collections.Generic;
using DataLayer.Models;

namespace WebAp.IRepositories
{
    interface IMessageRepository : IRepository<Message>
    {
        Message GetMessageById(int messageId);
        IEnumerable<Message> GetAllMessages();
    }
}
