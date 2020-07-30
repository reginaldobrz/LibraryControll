using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Domain.Livros.Queries;
using Biblioteca.Domain.Livros.Repositories.Interface;
using Biblioteca.Domain.Shared.DomainNotifications;
using Biblioteca.Domain.Shared.DomainNotifications.Interfaces;
using Biblioteca.Host.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ApiBaseController
    {
        private readonly ILivrosReadDapperRepository _livrosReadDapperRepository;
        private readonly IHandler<DomainNotification> _notifications;

        public LivrosController(ILivrosReadDapperRepository livrosReadDapperRepository,
            IHandler<DomainNotification> notifications) : base(notifications)
        {
            _livrosReadDapperRepository = livrosReadDapperRepository;
            _notifications = notifications;
        }

        [HttpGet("LivrosBiblioteca")]
        public async Task<IActionResult> LivrosAsync()
        {
            ; var usuario = await _livrosReadDapperRepository.ListarLivrosAsync();
            if (usuario != null)
                return Response(usuario);
            return BadRequest();
        }
    }
}