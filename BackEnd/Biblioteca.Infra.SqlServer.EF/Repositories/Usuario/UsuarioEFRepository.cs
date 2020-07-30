using Biblioteca.Domain.Usuarios.Repositories.Interface;
using Biblioteca.Infra.SqlServer.EF.Context;
using Biblioteca.Infra.SqlServer.EF.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Infra.SqlServer.EF.Repositories.Usuario
{
    public class UsuarioEFRepository : Repository<Domain.Usuarios.Entities.Usuario>, IUsuarioEfRepository
    {
        public UsuarioEFRepository(BaseContext context) : base(context) { }
    }
}