using Biblioteca.Domain.Avaliacao.Queries;
using Biblioteca.Domain.Avaliacao.Repositories.Interface;
using Biblioteca.Infra.SqlServer.Dapper.Context.Interfaces;
using Biblioteca.Infra.SqlServer.Dapper.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.SqlServer.Dapper.Repositories.Avaliacao
{
    public class AvaliacaoReadDapperRepository : ReadDapperRepository<object>, IFormularioReadDapperRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public AvaliacaoReadDapperRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<FormularioQueryResult> FormularioLivroAsync(string nome, string estado, int nota, string observacao, string nomeUsuario)
        {
            using (System.Data.IDbConnection connection = _connectionFactory.BibliotecaConnection)
            {
                string sQuery = " INSERT INTO Formulario VALUES(newid(),@nome, @estado, @nota, @observacao, @nomeUsuario)";
                var resultado = await connection.QueryAsync<FormularioQueryResult>(sQuery, new {nome, estado, nota, observacao, nomeUsuario });
                return resultado.FirstOrDefault();
            }
        }

        public async Task<FormularioQueryResult> FiltrarCadastroAsync(string nomeLivro, string nomeUsuario)
        {
            using (System.Data.IDbConnection connection = _connectionFactory.BibliotecaConnection)
            {
                string sQuery = " SELECT * FROM Formulario where Nome = @nomeLivro AND NomeUsuario= @nomeUsuario";
                var resultado = await connection.QueryAsync<FormularioQueryResult>(sQuery, new { nomeLivro, nomeUsuario });
                return resultado.FirstOrDefault();
            }
        }

    }
}
