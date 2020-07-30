using Biblioteca.Application.Handlers;
using Biblioteca.Domain.Avaliacao.Handlers.Interface;
using Biblioteca.Domain.Avaliacao.Repositories.Interface;
using Biblioteca.Domain.Livros.Repositories.Interface;
using Biblioteca.Domain.Shared.DomainNotifications;
using Biblioteca.Domain.Shared.DomainNotifications.Interfaces;
using Biblioteca.Domain.Shared.UoW.Interface;
using Biblioteca.Domain.Usuarios.Repositories.Interface;
using Biblioteca.Infra.SqlServer.Dapper.Context;
using Biblioteca.Infra.SqlServer.Dapper.Context.Interfaces;
using Biblioteca.Infra.SqlServer.Dapper.Repositories.Avaliacao;
using Biblioteca.Infra.SqlServer.Dapper.Repositories.Livros;
using Biblioteca.Infra.SqlServer.Dapper.Repositories.Usuario;
using Biblioteca.Infra.SqlServer.EF.Context;
using Biblioteca.Infra.SqlServer.EF.Repositories.Usuario;
using Biblioteca.Infra.SqlServer.EF.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace Biblioteca.Infra.IoC
{
    public class NativeBootStrapperBase
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<IConnectionFactory, ConnectionFactory>();
            // Domain - Events
            service.AddScoped<IHandler<DomainNotification>, DomainNotificationHandler>();
             // Repository - Dapper
            service.AddScoped<IUsuarioReadDapperRepository, UsuarioReadDapperRepository>();
            service.AddScoped<ILivrosReadDapperRepository, LivrosReadDapperRepository>();
            service.AddScoped<IFormularioReadDapperRepository, AvaliacaoReadDapperRepository>();
            // handler - handler
            service.AddScoped<IAvaliacaoHandler, AvaliacaoHandler>();            
            // Repository - EF
            service.AddScoped<IUsuarioEfRepository, UsuarioEFRepository>();
            // ExternalData
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<BaseContext>();
        }
    }
}
