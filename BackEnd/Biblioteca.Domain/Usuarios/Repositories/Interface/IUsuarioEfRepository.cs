using Biblioteca.Domain.Shared.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Usuarios.Repositories.Interface
{
    public interface IUsuarioEfRepository : IRepository<Domain.Usuarios.Entities.Usuario>
    {
    }
}
