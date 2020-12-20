using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public int? StoreId { get; set; }
        public Store Store { get; set; } = new Store();
    }
}
