using Biblioteca.Domain.Avaliacao.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Avaliacao.Handlers.Interface
{
    public interface IAvaliacaoHandler
    {
        Task<IEnumerable<FormularioQueryResult>> LivrosAsync(string nome, string estado, int nota, string observacao, string nomeUsuario);
    }
}
