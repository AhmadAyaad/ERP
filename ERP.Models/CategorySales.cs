using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class CategorySales
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SalesId { get; set; }
        public Sales Sales { get; set; }
    }
}
