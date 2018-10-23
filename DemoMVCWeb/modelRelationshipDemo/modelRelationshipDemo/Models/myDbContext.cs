using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace modelRelationshipDemo.Models
{
    public class myDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
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

        //Navigate property: Implement Supplier side of relationship
        //Many products can be supplied by one supplier
        public virtual ICollection<Product> Products { get; set; }
    }

    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name ="Product Name")]
        public string ProductName { get; set; }

        [Display(Name ="Unit Price")]
        [DataType(DataType.Currency)]
        public Nullable<double> UnitPrice { get; set; }

        //Foreign key field
        [Display(Name ="Supplier ID")]
        public Nullable<int> SupplierId { get; set; }

        //Navigation property: Implement Product side of Relationship.
        //One supplier can supply many products
        public virtual Supplier Supplier { get; set; }
    }
}