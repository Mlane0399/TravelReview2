using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCSite.Models
{
    public class Category
    {
       public int ID { get; set; }
       public string Location { get; set; }
       public string PriceRange { get; set; }
       public string SizeAccomo { get; set; }
       public virtual ICollection<Review> Reviews { get; set; }
    }
}