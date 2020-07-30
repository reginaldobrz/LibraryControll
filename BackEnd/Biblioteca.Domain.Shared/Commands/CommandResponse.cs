using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Shared.Commands.CommandResponse
{
    public class CommandResponse
    {
        public CommandResponse(bool success = false)
        {
            Success = success;
        }

        public bool Success { get; private set; }
    }
}
