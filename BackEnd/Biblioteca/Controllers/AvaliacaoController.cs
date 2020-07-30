using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Domain.Avaliacao.Handlers.Interface;
using Biblioteca.Domain.Avaliacao.Queries;
using Biblioteca.Domain.Avaliacao.Repositories.Interface;
using Biblioteca.Domain.Shared.DomainNotifications;
using Biblioteca.Domain.Shared.DomainNotifications.Interfaces;
using Biblioteca.Host.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ApiBaseController
    {
        private readonly IAvaliacaoHandler _avaliacaoHandler;
        private readonly IFormularioReadDapperRepository _FormularioReadDapperRepository;
        private readonly IHandler<DomainNotification> _notifications;

        public AvaliacaoController(IAvaliacaoHandler avaliacaoHandler, IFormularioReadDapperRepository formularioReadDapperRepository,
            IHandler<DomainNotification> notifications) : base(notifications)
        {
            _avaliacaoHandler = avaliacaoHandler;
            _FormularioReadDapperRepository = formularioReadDapperRepository;
            _notifications = notifications;
        }

        [HttpPost("AvaliacaoLivroBiblioteca")]
        public async Task<IActionResult> LivrosAsync(string nome, string estado, int nota, string observacao, string nomeUsuario)
        {
            var avaliacao = await _avaliacaoHandler.LivrosAsync(nome, estado, nota, observacao, nomeUsuario);

            if (avaliacao != null)
                return Response(avaliacao);
            return BadRequest("Cadastrro já existe!");
        }

        [HttpGet("AvaliacoesPorUsuarioBiblioteca")]
        public async Task<IActionResult> AvaliacoesPorUsuarioAsync(string nomeUsuario)
        {
            var avaliacao = await _FormularioReadDapperRepository.AvaliacoesPorUsuarioAsync(nomeUsuario);

            if (avaliacao != null)
                return Response(avaliacao);
            return BadRequest("Cadastrro já existe!");
        }
    }
}