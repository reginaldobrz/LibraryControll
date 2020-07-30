using Biblioteca.Domain.Shared.DomainNotifications;
using Biblioteca.Domain.Shared.DomainNotifications.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Host.Controllers.Base
{
    public class ApiBaseController : ControllerBase
    {
        private readonly IHandler<DomainNotification> notifications;

        public ApiBaseController(IHandler<DomainNotification> notifications)
        {
            this.notifications = notifications;
        }
        protected IEnumerable<DomainNotification> Notifications => notifications.GetValues();

        protected bool IsValidOperation()
        {
            return (!notifications.HasNotifications());
        }

        protected new IActionResult ResponseOk(object result = null)
        {
            if (IsValidOperation())
                return Ok(new { success = true, data = result });
            else
                return Ok(new { success = false, errors = notifications.GetValues().Select(n => n.Value) });
        }

        protected new IActionResult Response(object result = null)
        {
            if (IsValidOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = notifications.GetValues().Select(n => n.Value)
            });
        }

        protected void NotifyModelStateErrors()
        {
            var erros = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var erro in erros)
            {
                var erroMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotifyError(string.Empty, erroMsg);
            }
        }

        protected void NotifyError(string code, string message)
        {
            notifications.Handle(new DomainNotification(code, message));
        }

        protected void AddIdentityErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                NotifyError(result.ToString(), error.Description);
            }
        }

        

       
    }
}