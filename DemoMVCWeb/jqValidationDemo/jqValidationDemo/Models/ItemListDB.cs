using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace jqValidationDemo.Models
{
    public class ItemListDB : DbContext
    {
        public DbSet<ItemList> ItemLists { get; set; }
    }

    [Table("ItemList")]
    public class ItemList
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ListItemID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Things To Do")]
        public string ListItemEntry { get; set; }
    }
}