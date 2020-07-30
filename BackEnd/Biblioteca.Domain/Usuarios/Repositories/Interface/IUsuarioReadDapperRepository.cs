using Biblioteca.Domain.Usuarios.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Usuarios.Repositories.Interface
{
    public interface IUsuarioReadDapperRepository
    {
        Task<UsuarioQueryResult> ListarPorNomeAsync(string nome);
        Task<UsuarioQueryResult> CriarUsuarioAsync(string nome);
    }
}
