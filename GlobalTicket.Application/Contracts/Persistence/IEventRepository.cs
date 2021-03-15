using GlobalTicket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
    }
}
