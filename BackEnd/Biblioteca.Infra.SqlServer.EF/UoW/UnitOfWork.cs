using Biblioteca.Domain.Shared.Commands.CommandResponse;
using Biblioteca.Domain.Shared.UoW.Interface;
using Biblioteca.Infra.SqlServer.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Infra.SqlServer.EF.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BaseContext _context;

        public UnitOfWork(BaseContext context)
        {
            _context = context;
        }


        public CommandResponse Commit()
        {
            var rowsAffected = int.MinValue;

            try
            {
                rowsAffected = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }

            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
