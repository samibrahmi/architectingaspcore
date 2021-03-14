using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public int TotalOrer { get; set; }
        public DateTime OrderOlaced { get; set; }
        public int OrderPaid { get; set; }
    }
}
