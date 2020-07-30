using Biblioteca.Domain.Shared.DomainNotifications;
using Biblioteca.Domain.Shared.DomainNotifications.Interfaces;
using Biblioteca.Domain.Shared.UoW.Interface;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Shared.Commands
{
    public class CommandHandler : Notifiable
    {
        private readonly IUnitOfWork _uow;
        private readonly IHandler<DomainNotification> _notifications;

        public CommandHandler(IUnitOfWork uow, IHandler<DomainNotification> notifications)
        {
            this._uow = uow;
            this._notifications = notifications;
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            var commandResponse = _uow.Commit();
            if (commandResponse.Success) return true;

            AddNotification("Commit", "Erro ao persistir dados.");
            return false;
        }
    }
}
