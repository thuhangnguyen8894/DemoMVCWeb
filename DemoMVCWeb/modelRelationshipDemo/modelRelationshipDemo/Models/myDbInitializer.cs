using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace modelRelationshipDemo.Models
{
    public class myDbInitializer : DropCreateDatabaseAlways<myDbContext>
    {
        protected override void Seed(myDbContext context)
        {
            base.Seed(context);
            //Create supplier records
            var supplier = new List<Supplier>
            {
                new Supplier
                {
                    CompanyName="Earth Farm",
                    City="Seattle",
                    Country="USA",
                },
                new Supplier
                {
                    CompanyName="Vanessa's Deli",
                    City="Northglenn",
                    Country="USA",
                },
                new Supplier
                {
                    CompanyName="Brocadero",
                    City="Tijuana",
                    Country="USA",
                },
            };
            supplier.ForEach(s => context.Suppliers.Add(s));
            context.SaveChanges();

            //Create product records
            var products = new List<Product>
            {
                new Product
                {
                    ProductName = "Watermelon",
                    SupplierId = supplier.Single(s=>s.CompanyName=="Earth Farm").SupplierId,
                    UnitPrice = 3.30
                },
                new Product
                {
                    ProductName = "Cabbage",
                    SupplierId = supplier.Single(s=>s.CompanyName=="Earth Farm").SupplierId,
                    UnitPrice = 1.80
                },
                new Product
                {
                    ProductName = "Frozen Enchilladas",
                    SupplierId = supplier.Single(s=>s.CompanyName=="Vanessa's Deli").SupplierId,
                    UnitPrice = 5.00
                },
                new Product
                {
                    ProductName = "Frozen Meat Pies",
                    SupplierId = supplier.Single(s=>s.CompanyName=="Earth Farm").SupplierId,
                    UnitPrice = 7.50
                },
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}