using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace displayNameDemo.Models
{
    public class ListItem
    {
        public int ListItemID { get; set; }

        [DisplayName("List Title")]
        public string Title { get; set; }

        [DisplayName("List Entry")]
        public string ListItemEntry { get; set; }

        [DisplayName("Created At")]
        public string TimeCreated { get; set; }
    }
}