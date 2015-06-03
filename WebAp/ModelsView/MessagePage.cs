using System.Collections.Generic;
using DataLayer.Models;


namespace WebAp.ModelsView
{
    public class MessagePage
    {
        public Client Client { get; set; }

        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Message> Messages { get; set; }
    }
}