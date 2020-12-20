using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int? StoreId { get; set; }
        public Store Store { get; set; }
        public ICollection<Sales> Sales { get; set; } = new HashSet<Sales>();
        public ICollection<Product> Products{ get; set; } = new HashSet<Product>();

    }
}
