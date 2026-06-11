using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Escola.Infra.Data.Context.EntitiesConfiguration
{
    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.HasKey(m => m.Id); // Define a chave primária
            builder.Property(m => m.UsuarioId).IsRequired(); // Define a propriedade UsuarioId como obrigatória
            builder.Property(m => m.TurmaId).IsRequired(); // Define a propriedade TurmaId como obrigatória

            builder.HasOne(m => m.Usuario) // Define o relacionamento entre Matricula e Usuario
                .WithMany(u => u.Matriculas) // Um usuário pode ter muitas matrículas
                .HasForeignKey(m => m.UsuarioId); // A chave estrangeira é UsuarioId

            builder.HasOne(m => m.Turma) // Define o relacionamento entre Matricula e Turma
                .WithMany(t => t.Matriculas) // Uma turma pode ter muitas matrículas
                .HasForeignKey(m => m.TurmaId) // A chave estrangeira é TurmaId
                .OnDelete(DeleteBehavior.Cascade); // Define o comportamento de exclusão em cascata

        
        }
    }
}