using Biblioteca.Domain.Shared.DomainNotifications;
using Biblioteca.Domain.Shared.DomainNotifications.Interfaces;
using Microsoft.Extensions.Configuration;
using System.ServiceModel;

namespace Biblioteca.Infra.Integrations.Base
{
    public class ServiceBase
    {
        private readonly IConfiguration _configuration;
        private readonly IHandler<DomainNotification> _notifications;

        public EndpointAddress Endpoint { get; set; }

        public static readonly BasicHttpBinding Binding = new BasicHttpBinding
        {
            MaxReceivedMessageSize = long.MaxValue,
            MaxBufferSize = int.MaxValue
        };

        public ServiceBase(IConfiguration configuration, IHandler<DomainNotification> notifications)
        {
            _configuration = configuration;
            _notifications = notifications;
        }
    }
}