using Biblioteca.Domain.Livros.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Livros.Repositories.Interface
{
    public interface ILivrosReadDapperRepository
    {
        Task<IEnumerable<LivrosQueryResult>> ListarLivrosAsync();
    }
}
