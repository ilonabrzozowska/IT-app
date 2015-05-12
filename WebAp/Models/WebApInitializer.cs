using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAp.Models
{
    public class WebApInitializer : DropCreateDatabaseAlways<WebApContext>
    {
        

        private void AddBuilding(WebApContext context, int buildingId, string district, string street, string city, string postCode, string flatCount, string buildingNumber)
        {
            context.Buildings.Add(
                new Building()
                {
                    BuildingID = buildingId,
                    District = district,
                    Street = street,
                    City = city,
                    PostCode = postCode,
                    FlatCount = flatCount,
                    BuildingNumber = buildingNumber
                });
        }

        private void AddClient(WebApContext context, int clientId, int buildingId, string name, string surname, string flatNumber, string phone, string password, string email)
        {
            context.Clients.Add(
                new Client()
                {
                    ClientID = clientId,
                    BuildingID = buildingId,
                    Name = name,
                    Surname = surname,
                    FlatNumber = flatNumber,
                    Phone = phone,
                    Password = password,
                    Email = email
                });
        }

        private void AddBills(WebApContext context, int billId, int clientId, DateTime dateIssue, float quantity, int itemId, DateTime payDate)
        {
            context.Bills.Add(
                new Bill()
                {
                    BillID = billId,
                    ClientID = clientId,
                    DateIssue = dateIssue,
                    Quantity = quantity,
                    ItemId = itemId,
                    PayDate = payDate,
                });
        }

        private void AddItems(WebApContext context, int itemId, string name, float pricePerUnit, DateTime occurDate)
        {
            context.Items.Add(
                new Item()
                {
                    ItemID = itemId,
                    Name = name,
                    PricePerUnit = pricePerUnit,
                    OccurDate = occurDate,
                });
        }
        
        private void AddMessage(WebApContext context, int messageId, string content, DateTime deliveryDate, int clientId) 
        {
            context.Messages.Add(
                new Message()
                {
                    MessageID = messageId,
                    Content = content,
                    DeliveryDate = deliveryDate,
                    ClientId = clientId,
                });
        }



        protected override void Seed(WebApContext context)
        {
            this.AddBuilding(context, 1, "krzyki", "gajowicka", "wroclaw", "23-232", "10", "1");
            this.AddBuilding(context, 2, "krzyki", "gajowicka", "wroclaw", "23-232", "10", "2");
            this.AddBuilding(context, 3, "krzyki", "gajowicka", "wroclaw", "23-232", "10", "3");


            this.AddClient(context, 1, 1, "Jan", "Kowalski", "1", "123456789", "password", "email");
            this.AddClient(context, 2, 1, "Tomasz", "Cybulski", "2", "123456789", "password", "email");
            this.AddClient(context, 3, 1, "Michal", "Kot", "3", "403628495", "pass", "mail");

            this.AddBills(context, 1, 1, DateTime.Parse("2015-03-05"), 25, 1, DateTime.Parse("2015-03-25"));
            this.AddBills(context, 2, 1, DateTime.Parse("2015-03-05"), 55, 2, DateTime.Parse("2015-03-25"));
            this.AddBills(context, 3, 1, DateTime.Parse("2015-03-05"), 1, 3, DateTime.Parse("2015-03-25"));

            this.AddItems(context, 1, "water", 5, DateTime.Parse("2015-03"));
            this.AddItems(context, 2, "gas", 2, DateTime.Parse("2015-04"));
            this.AddItems(context, 3, "rent", 350, DateTime.Parse("2015-05"));

            this.AddMessage(context, 1, "New message!", DateTime.Parse("2015-05-12"), 1);

            context.SaveChanges();
        }
    }
}