
using Biblioteca.Domain.Usuarios.Queries;
using Biblioteca.Domain.Usuarios.Repositories.Interface;
using Biblioteca.Infra.SqlServer.Dapper.Context.Interfaces;
using Biblioteca.Infra.SqlServer.Dapper.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.SqlServer.Dapper.Repositories.Usuario
{
    public class UsuarioReadDapperRepository : ReadDapperRepository<object>,IUsuarioReadDapperRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public UsuarioReadDapperRepository(IConnectionFactory context)
        {
            _connectionFactory = context;
        }

        public async Task<UsuarioQueryResult> ListarPorNomeAsync(string nome)
        {
            using (System.Data.IDbConnection connection = _connectionFactory.BibliotecaConnection)
            {
                string sQuery = " SELECT Id, Nome FROM Usuario (NOLOCK)  where nome = @nome";
                var resultado = await connection.QueryAsync<UsuarioQueryResult>(sQuery, new { nome });
                var usuario = resultado.FirstOrDefault();
                return usuario;
            }
        }
        public async Task<UsuarioQueryResult> CriarUsuarioAsync(string nome)
        {
            using (System.Data.IDbConnection connection = _connectionFactory.BibliotecaConnection)
            {
                string sQuery = "INSERT INTO Usuario values (newid(), @nome)";
                var resultado = await connection.QueryAsync<UsuarioQueryResult>(sQuery, new { nome });
                var usuario = resultado.FirstOrDefault();
                return usuario;
            }
        }
    }
}
