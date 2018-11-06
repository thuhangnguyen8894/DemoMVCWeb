using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace customValMsgDemo.Models
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
        
        [Required(ErrorMessage = "Please enter a title.")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Things To Do")]
        public string ListItemEntry { get; set; }

        [Display(Name = "Complete By")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime CompleteByDate { get; set; }
    }
}