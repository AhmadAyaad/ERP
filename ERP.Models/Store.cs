using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public ICollection<Sales> Sales { get; set; } = new HashSet<Sales>();
        public ICollection<Warehouse> Warehouses { get; set; } = new HashSet<Warehouse>();
        public ICollection<StackHolder> StackHolders { get; set; } = new HashSet<StackHolder>();
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public ICollection<Category> Categories { get; set; } = new HashSet<Category>();


    }
}
