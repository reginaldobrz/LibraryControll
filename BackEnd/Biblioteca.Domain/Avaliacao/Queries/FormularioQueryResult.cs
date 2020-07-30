using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Avaliacao.Queries
{
    public class FormularioQueryResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string EstadoConsevacao { get; set; }
        public int Nota { get; set; }
        public string Observacao { get; set; }
        public string NomeUsuario { get; set; }
    }
}
