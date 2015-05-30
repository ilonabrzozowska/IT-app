using System.Collections.Generic;
using DataLayer.Models;


namespace WebAp.ModelsView
{
    public class HomePage
    {
        public Client Client { get; set; }

        public IEnumerable<Building> Buildings { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}