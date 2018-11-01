using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace jqValidationDemo.Models
{
    public class ItemListsInitializer : DropCreateDatabaseAlways<ItemListDB>
    {
        protected override void Seed(ItemListDB context)
        {
            base.Seed(context);
            var itemLists = new List<ItemList>
            {
                new ItemList
                {
                    Title = "Groceries",
                    ListItemEntry = "Pick up lettuce tomatoes carrots and ...",
                },

                new ItemList
                {
                    Title = "Shopping Mall",
                    ListItemEntry = "Purchase jeans cargo pants dress shirts",
                },
            };
            itemLists.ForEach(y => context.ItemLists.Add(y));
            context.SaveChanges();
        }
    }
}