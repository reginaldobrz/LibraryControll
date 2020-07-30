using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Biblioteca.Infra.SqlServer.Dapper.Context.Interfaces
{
	public interface IConnectionFactory : IDisposable
	{
		IDbConnection BibliotecaConnection { get; }
	}
}
