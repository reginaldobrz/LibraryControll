using Biblioteca.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Usuarios.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public Guid Id { get; set; }
        public Usuario(Guid id,
            string nome)
        {
            Id = id;
           
            Nome = nome;
            AddNotifications(new Flunt.Validations.Contract()
             .IsNotNullOrEmpty(nome, "Email", "Necessário informar o Email"));
        }
    }
}