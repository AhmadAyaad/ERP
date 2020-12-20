using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public class Sales
    {
        public int SalesId { get; set; }
        public int? StoreId { get; set; }
        public Store Store { get; set; } = new Store();
        public int? StackHolderId { get; set; }
        public StackHolder StackHolders { get; set; } = new StackHolder();
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public ICollection<Category> Categories{ get; set; } = new HashSet<Category>();
    }
}
