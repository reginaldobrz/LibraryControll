using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Shared.DomainNotifications.Interfaces
{
    public interface IDomainEvent
    {
        int Version { get; }
        DateTime OccurrenceDate { get; }
    }
}
