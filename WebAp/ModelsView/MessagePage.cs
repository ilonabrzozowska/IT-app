<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayer.Models;

=======
﻿using System.Collections.Generic;
using DataLayer.Models;


>>>>>>> origin/master
namespace WebAp.ModelsView
{
    public class MessagePage
    {
        public Client Client { get; set; }
<<<<<<< HEAD
        public IEnumerable<Building> Buildings { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Bill> Bills { get; set; }
        public IEnumerable<Item> Items { get; set; }
=======

        public IEnumerable<Client> Clients { get; set; }
>>>>>>> origin/master
        public IEnumerable<Message> Messages { get; set; }
    }
}