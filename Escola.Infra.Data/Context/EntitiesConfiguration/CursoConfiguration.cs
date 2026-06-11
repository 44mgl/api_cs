using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.Data.Context.EntitiesConfiguration
{
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(c => c.Id); // Define a chave primária
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100); // Define a propriedade Nome como obrigatória e com tamanho máximo de 100 caracteres
            builder.Property(c => c.Descricao).HasMaxLength(500); // Define a propriedade Descricao com tamanho máximo de 500 caracteres

            // Configurações adicionais de mapeamento podem ser feitas aqui
        }
    }
}