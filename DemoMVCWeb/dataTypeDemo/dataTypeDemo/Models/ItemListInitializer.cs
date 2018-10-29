using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dataTypeDemo.Models
{
    public class ItemListInitializer : DropCreateDatabaseAlways<ItemListDB>
    {
        protected override void Seed(ItemListDB context)
        {
            base.Seed(context);
            var itemLists = new List<ItemList>
            {
                new ItemList
                {
                    Title = "Groceries",
                    ListItemEntry = "Pick up lettuce, tomatoes, carrots and ...",
                    fundsRequired = 45.50
                },

                new ItemList
                {
                    Title = "Shopping Mall",
                    ListItemEntry = "Purchase jeans, cargo pants, dress shirts",
                    fundsRequired = 380.50
                },
            };
            itemLists.ForEach(y => context.ItemLists.Add(y));
            context.SaveChanges();
        }
    }
}