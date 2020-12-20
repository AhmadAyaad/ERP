using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class StackHolder
    {
        public int StackHolderId { get; set; }
        public ICollection<Sales> Sales { get; set; } = new HashSet<Sales>();
        public ICollection<Warehouse> Warehouses{ get; set; } = new HashSet<Warehouse>();

        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();

    }
}
