using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escola.Domain.Entities;

namespace Escola.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        // Adicionei a propriedade DbSet para a entidade 
        public DbSet<Curso> Cursos { get; set; } 
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Cria as Configurações de mapeamento para as entidades
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais de mapeamento podem ser feitas aqui
        }
    }
}