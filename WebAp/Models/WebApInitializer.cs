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

            context.SaveChanges();
        }
    }
}