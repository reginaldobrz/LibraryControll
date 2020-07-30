using Biblioteca.Infra.SqlServer.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Host.Extensions
{
	public static class ContextServiceExtensions
	{
		public static IServiceCollection AddContextConfiguration(this IServiceCollection services, IConfiguration Configuration)
		{
			var connection = Configuration.GetConnectionString("BibliotecaoContext");
			services.AddDbContext<BaseContext>(b => b.UseLazyLoadingProxies(false).UseSqlServer(connection));
			services.Configure<Biblioteca.Domain.Shared.Querys.AppSettingsQueryResult>(Configuration.GetSection("ConnectionStrings"));
			return services;
		}
	}
}
