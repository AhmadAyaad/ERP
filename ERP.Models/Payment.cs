using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int? StackHolderId { get; set; }
        public StackHolder StackHolder { get; set; } = new StackHolder();
    }
}
