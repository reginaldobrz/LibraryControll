using Biblioteca.Domain.Shared.Commands.CommandResponse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Shared.UoW.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
