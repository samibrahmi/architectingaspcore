using GlobalTicket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.Application.Contracts.Persistence
{
    pubblic interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
