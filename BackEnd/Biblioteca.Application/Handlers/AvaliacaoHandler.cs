using Biblioteca.Domain.Avaliacao.Handlers.Interface;
using Biblioteca.Domain.Avaliacao.Queries;
using Biblioteca.Domain.Avaliacao.Repositories.Interface;
using Biblioteca.Domain.Shared.DomainNotifications;
using Biblioteca.Domain.Shared.DomainNotifications.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Handlers
{
    public class AvaliacaoHandler : IAvaliacaoHandler
    {
        private readonly IFormularioReadDapperRepository _formularioReadDapperRepository;
        private readonly IHandler<DomainNotification> _notifications;

        public AvaliacaoHandler(IFormularioReadDapperRepository formularioReadDapperRepository,
            IHandler<DomainNotification> notifications)
        {
            _formularioReadDapperRepository = formularioReadDapperRepository;
            _notifications = notifications;
        }

        public async Task<IEnumerable<FormularioQueryResult>> LivrosAsync(string nome, string estado, int nota, string observacao, string nomeUsuario)
        { 
            var cadastroJaExistente = await _formularioReadDapperRepository.FiltrarCadastroAsync(nome, nomeUsuario);

            if (cadastroJaExistente == null)
            {
                var avaliacao = await _formularioReadDapperRepository.FormularioLivroAsync(nome, estado, nota, observacao, nomeUsuario);

                List<FormularioQueryResult> listFormulario = new List<FormularioQueryResult>();
                var formulario = new FormularioQueryResult();

                formulario.Nome = nome;
                formulario.Estado = estado;
                formulario.Nota = nota;
                formulario.Observacao = observacao;
                formulario.NomeUsuario = nomeUsuario;

                listFormulario.Add(formulario);

                return listFormulario;
            }
            else
                return null;
        }
    }
}
