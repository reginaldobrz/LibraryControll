using Biblioteca.Domain.Avaliacao.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Avaliacao.Repositories.Interface
{
    public interface IFormularioReadDapperRepository
    {
        Task<FormularioQueryResult> FormularioLivroAsync(string nome, string estado, int nota, string observacao, string nomeUsuario);
        Task<FormularioQueryResult> FiltrarCadastroAsync(string nomeLivro, string nomeUsuario);
        Task<IEnumerable<FormularioQueryResult>> AvaliacoesPorUsuarioAsync(string nomeUsuario);
        Task<IEnumerable<FormularioQueryResult>> DeleteAvaliacoesPorUsuarioAsync(string idAvaliacao);
    }
}
