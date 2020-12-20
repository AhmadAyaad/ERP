using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class SalesProducts
    {
        public int SalesId { get; set; }
        public Sales Sales { get; set; }
        public int ProductId { get; set; }
        public Product Product{ get; set; }
    }
}
