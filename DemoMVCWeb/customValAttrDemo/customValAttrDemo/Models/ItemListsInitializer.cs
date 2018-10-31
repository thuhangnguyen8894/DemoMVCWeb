using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace customValAttrDemo.Models
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
                    CompleteByDate = new DateTime(2014,7,4,11,0,0)
                },

                new ItemList
                {
                    Title = "Shopping Mall",
                    ListItemEntry = "Purchase jeans cargo pants dress shirts",
                    CompleteByDate = new DateTime(2014,7,7,9,0,0)
                },
            };
            itemLists.ForEach(y => context.ItemLists.Add(y));
            context.SaveChanges();
        }
    }
}