using Biblioteca.Domain.Usuarios.Entities;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Biblioteca.Infra.SqlServer.EF.Context
{
    public class BaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Usuario> Usuario { get; set; }
        public BaseContext(DbContextOptions<BaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Exemplo
            //modelBuilder.ApplyConfiguration(new SincMap());


            modelBuilder.Ignore<Notification>();
            modelBuilder.ApplyConfiguration(new Config.UsuarioConfig());
        }
    }
}
