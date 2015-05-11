using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAp.Models
{
    public class WebApInitializer : DropCreateDatabaseAlways<WebApContext>
    {
        private void AddCategory(WebApContext context, string categoryName)
        {
            context.Categories.Add(
            new Category()
            {
                CategoryName = categoryName
            });
        }

        private void AddBuilding(WebApContext context, string district, string street, string city, string postCode, string flatCount, string buildingNumber)
        {
            context.Buildings.Add(
                new Building()
                {
                    District = district,
                    Street = street,
                    City = city,
                    PostCode = postCode,
                    FlatCount = flatCount,
                    BuildingNumber = buildingNumber
                });
        }

        private void AddClient(WebApContext context, int buildingId, string name, string surname, string flatNumber, string phone, string password, string email)
        {
            context.Clients.Add(
                new Client()
                {
                    BuildingID = buildingId,
                    Name = name,
                    Surname = surname,
                    FlatNumber = flatNumber,
                    Phone = phone,
                    Password = password,
                    Email = email
                });
        }

        private void AddBills(WebApContext context, string billId, string pesel, DateTime dateIssue)
        {
            context.Bills.Add(
                new Bill()
                {
                    BillID = billId,
                    PESEL = pesel,
                    DateIssue = dateIssue,
                });
        }

        private void AddItems(WebApContext context, int itemId, string name, float price)
        {
            context.Items.Add(
                new Item()
                {
                    ItemID = itemId,
                    Name = name,
                    Price = price,
                });
        }

        private void AddItemDates(WebApContext context, int itemDateId, int itemId, DateTime from, DateTime to)
        {
            context.ItemDates.Add(
                new ItemDate()
                {
                    ItemDateID = itemDateId,
                    ItemID = itemId,
                    From = from,
                    To = to,
                });
        }

        private void AddPositions(WebApContext context, int positionId, int billId, int ItemId, int quantity, DateTime datePay)
        {
            context.Positions.Add(
                new Position()
                {
                    PositionID = positionId,
                    BillID = billId,
                    ItemID = ItemId,
                    Quantity = quantity,
                    DatePay = datePay,
                });
        }


        protected override void Seed(WebApContext context)
        {
            this.AddCategory(context, "Beverages");
            this.AddCategory(context, "Condiments");
            this.AddCategory(context, "Confections");
            this.AddCategory(context, "Dairy Products");
            this.AddCategory(context, "Grains/Cereals");
            this.AddCategory(context, "Meat/Poultry");
            this.AddCategory(context, "Produce");
            this.AddCategory(context, "Seafood");
            this.AddCategory(context, "nana");

            this.AddBuilding(context, "krzyki", "gajowicka", "wroclaw", "23-232", "10", "1");
            this.AddBuilding(context, "krzyki", "gajowicka", "wroclaw", "23-232", "10", "2");
            this.AddBuilding(context, "krzyki", "gajowicka", "wroclaw", "23-232", "10", "3");


            this.AddClient(context, 1, "Jan", "Kowalski", "1", "123456789", "password", "email");
            this.AddClient(context, 1, "Tomasz", "Cybulski", "2", "123456789", "password", "email");
            this.AddClient(context, 1, "Michal", "Kot", "3", "403628495", "pass", "mail");

            this.AddBills(context, "1", "1234", DateTime.Parse("2015-03-05"));
            this.AddBills(context, "2", "6543", DateTime.Parse("2015-04-05"));
            this.AddBills(context, "3", "8674", DateTime.Parse("2015-05-05"));

            this.AddItems(context, 1, "water", 100);
            this.AddItems(context, 2, "gas", 90);
            this.AddItems(context, 3, "rent", 400);

            this.AddItemDates(context, 1, 1, DateTime.Parse("2015-03-05"), DateTime.Parse("2015-03-15"));
            this.AddItemDates(context, 2, 2, DateTime.Parse("2015-04-05"), DateTime.Parse("2015-04-15"));
            this.AddItemDates(context, 3, 3, DateTime.Parse("2015-05-05"), DateTime.Parse("2015-05-15"));

            this.AddPositions(context, 1, 1, 1, 490, DateTime.Parse("2015-03-15"));
            this.AddPositions(context, 2, 2, 2, 490, DateTime.Parse("2015-04-15"));
            this.AddPositions(context, 3, 3, 3, 490, DateTime.Parse("2015-05-15"));

            context.SaveChanges();
        }
    }
}