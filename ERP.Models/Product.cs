using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int? StoreId { get; set; }
        public Store Store { get; set; }
        public ICollection<Sales> Sales { get; set; } = new HashSet<Sales>();
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
