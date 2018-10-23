using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace modelRelationshipDemo.Models
{
    public class myDbContext
    {
    }
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }

        [Display(Name ="Company Name")]
        public string CompanyName { get; set; }

        [Display(Name ="Supplier City")]
        public string City { get; set; }

        [Display(Name ="Supplier Country")]
        public string Country { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    [Table("Product")]
    public class Product
    {

    }
}