using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Domain.Entities
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CursoId { get; set; } // Chave estrangeira para o curso
        public Curso Curso { get; set; } // Relacionamento com o curso
        public ICollection<Matricula> Matriculas { get; set; } // Relacionamento com as matrículas da turma
    }
}