﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.Models;
using System.Data.Entity;
using System.Web.Mvc;


namespace WebAp.ModelsView
{
    public class BillPage
    {
        public Client Client { get; set; }
        public IEnumerable<Building> Buildings { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Bill> Bills { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public IEnumerable<ItemDate> ItemDates { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}