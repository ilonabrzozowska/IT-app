using System.Collections.Generic;
using DataLayer.Models;


namespace WebAp.ModelsView
{
    public class BillPage
    {
        public Client Client { get; set; }
        public IEnumerable<Building> Buildings { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Bill> Bills { get; set; }
        public IEnumerable<Item> Items { get; set; }

    }
}