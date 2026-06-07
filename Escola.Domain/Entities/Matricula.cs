using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Domain.Entities
{
    public class Matricula
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; } // Chave estrangeira para o usuário
        public int TurmaId { get; set; } // Chave estrangeira para o curso
        public DateTime DataMatricula { get; set; } 
        public DateTime DataExpiracao { get; set; } 
        public bool Ativa { get; set; } // Indica se a matrícula está ativa ou não
        public ICollection<Nota> Notas { get; set; } // Relacionamento com os usuários matriculados
        public Usuario Usuario { get; set; } // Relacionamento com o usuário
        public Turma Turma { get; set; } // Relacionamento com a turma
    }
}