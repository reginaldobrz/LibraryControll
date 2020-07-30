using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Shared.DomainNotifications.Interfaces
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        bool HasNotifications();
        List<T> GetValues();
    }
}
