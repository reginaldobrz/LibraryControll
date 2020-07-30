using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Infra.SqlServer.EF.Config
{
    public class UsuarioConfig : IEntityTypeConfiguration<Biblioteca.Domain.Usuarios.Entities.Usuario>
    {
        public void Configure(EntityTypeBuilder<Biblioteca.Domain.Usuarios.Entities.Usuario> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("Usuario");

            builder.Property(e => e.Nome)
               .HasMaxLength(100)
               .IsUnicode(false);

            builder.Property(e => e.CriadoEm)
               .HasMaxLength(100)
               .IsUnicode(false);

            builder.Property(e => e.AlteradoEm)
               .HasMaxLength(100)
               .IsUnicode(false);
        }
    }
}
