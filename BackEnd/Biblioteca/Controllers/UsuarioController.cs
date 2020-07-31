using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Domain.Shared.DomainNotifications;
using Biblioteca.Domain.Shared.DomainNotifications.Interfaces;
using Biblioteca.Domain.Usuarios.Repositories.Interface;
using Biblioteca.Host.Controllers.Base;
using Castle.Core.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ApiBaseController
    {
        private readonly IUsuarioReadDapperRepository _usuarioReadDapperRepository;
        private readonly IHandler<DomainNotification> _notifications;

        public UsuarioController(IUsuarioReadDapperRepository usuarioReadDapperRepository,
            IHandler<DomainNotification> notifications) : base(notifications)
        {
            _usuarioReadDapperRepository = usuarioReadDapperRepository;
            _notifications = notifications;
        }

       
        [HttpPost("UsuarioBiblioteca")]
        public async Task<IActionResult> UsuarioAsync(string nome)
        {
            var usuario = await _usuarioReadDapperRepository.ListarPorNomeAsync(nome.ToLower());
            if(usuario != null)
                return Response(usuario);
            return BadRequest();
        }

        [HttpPost("CriarUsuarioBiblioteca")]
        public async Task<IActionResult> CriarUsuarioAsync(string nome)
        {
            var usuarioJaExiste = await _usuarioReadDapperRepository.ListarPorNomeAsync(nome);
            if (usuarioJaExiste == null)
                return await NovoUsuario(nome);
            else
                return Response("Usuario já cadastrado!");
        }

        private async Task<IActionResult> NovoUsuario(string nome)
        {
            var usuario = await _usuarioReadDapperRepository.CriarUsuarioAsync(nome.ToLower());
            if (usuario == null)
                return Response(nome);
            return BadRequest();
        }
    }
}