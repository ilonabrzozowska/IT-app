using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}