using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public Action<object, string> LazyLoader { get; set; }
        public Guid Id { get; protected set; }
        public DateTime CriadoEm { get; protected set; }
        public DateTime? AlteradoEm { get; protected set; }
    }
}
