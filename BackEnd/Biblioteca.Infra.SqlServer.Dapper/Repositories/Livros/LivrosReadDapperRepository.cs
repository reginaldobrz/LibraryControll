using Biblioteca.Domain.Livros.Queries;
using Biblioteca.Domain.Livros.Repositories.Interface;
using Biblioteca.Infra.SqlServer.Dapper.Context.Interfaces;
using Biblioteca.Infra.SqlServer.Dapper.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.SqlServer.Dapper.Repositories.Livros
{
    public class LivrosReadDapperRepository : ReadDapperRepository<object>, ILivrosReadDapperRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public LivrosReadDapperRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<LivrosQueryResult>> ListarLivrosAsync()
        {
            using (System.Data.IDbConnection connection = _connectionFactory.BibliotecaConnection)
            {
                string sQuery = " SELECT Nome FROM Livros (NOLOCK)";
                var resultado = await connection.QueryAsync<LivrosQueryResult>(sQuery, new {});
                return resultado;
            }
        }
    }
}
